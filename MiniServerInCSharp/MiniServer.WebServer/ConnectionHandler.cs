﻿using Mini_HTTP_Server.Common;
using Mini_HTTP_Server.Enums;
using Mini_HTTP_Server.Exceptions;
using Mini_HTTP_Server.Requests;
using Mini_HTTP_Server.Responses;
using MiniServer.WebServer.Results;
using MiniServer.WebServer.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace MiniServer.WebServer
{
    public class ConnectionHandler
    {
        private readonly Socket client;
        private readonly IServerRoutingTable serverRoutingTable;

        public ConnectionHandler(Socket client, IServerRoutingTable serverRoutingTable)
        {
            CoreValidator.ThrowIfNull(client, nameof(client));
            CoreValidator.ThrowIfNull(serverRoutingTable, nameof(serverRoutingTable));
            this.client = client;
            this.serverRoutingTable = serverRoutingTable;
        }

        private IHttpRequest ReadRequest()
        {
            var result = new StringBuilder();
            var data = new ArraySegment<byte>(new byte[1024]);

            while (true)
            {
                int numberOfBytesToRead = this.client.Receive(data.Array, SocketFlags.None);
                if (numberOfBytesToRead == 0) break;
                var bytesAsString = Encoding.UTF8.GetString(data.Array, 0, numberOfBytesToRead);
                result.Append(bytesAsString);
                if (numberOfBytesToRead < 1023) break;
            }

            if (result.Length == 0) return null;
            return new HttpRequest(result.ToString());
        }

        private IHttpResponse HandleRequest(IHttpRequest httpRequest)
        {
            if (!this.serverRoutingTable.Contains(httpRequest.RequestMethod, httpRequest.Path))
            {
                return new TextResult($"Route with method {httpRequest.RequestMethod} and path \"{httpRequest.Path}\" not found.", HttpResponseStatusCode.NotFound);
            }
            return this.serverRoutingTable.Get(httpRequest.RequestMethod, httpRequest.Path).Invoke(httpRequest);
        }

        private void PrepareResponse(IHttpResponse httpResponse)
        {
            byte[] byteSegments = httpResponse.GetBytes();
            this.client.Send(byteSegments, SocketFlags.None);
        }

        public void ProcessRequest()
        {
            IHttpResponse httpResponse = null;

            try
            {
                IHttpRequest httpRequest = this.ReadRequest();

                if (httpRequest != null)
                {
                    Console.WriteLine($"Processing: {httpRequest.RequestMethod} {httpRequest.Path}...");

                    httpResponse = this.HandleRequest(httpRequest);
                }
            }
            catch (BadRequestException e)
            {
                httpResponse = new TextResult(e.Message, HttpResponseStatusCode.BadREquest);
            }
            catch (Exception e)
            {
                httpResponse = new TextResult(e.Message, HttpResponseStatusCode.InternalServerError);
            }

            this.PrepareResponse(httpResponse);
            this.client.Shutdown(SocketShutdown.Both);
        }
    }

}
