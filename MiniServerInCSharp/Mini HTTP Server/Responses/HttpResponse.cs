using Mini_HTTP_Server.Common;
using Mini_HTTP_Server.Enums;
using Mini_HTTP_Server.Headers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace Mini_HTTP_Server.Responses
{
    public class HttpResponse : IHttpResponse
    {
        public HttpResponse()
        {
            this.Headers = new HttpHeaderCollection();
            this.Content = new byte[0];
        }

        public HttpResponse(HttpResponseStatusCode statusCode) : this()
        {
             CoreValidator.ThrowIfNull(statusCode, nameof(statusCode));
             this.StatusCode = statusCode;
        }

        public HttpResponseStatusCode StatusCode { get; set; }


        public HttpHeaderCollection Headers { get; } // аз съм го добавила 
        public byte[] Content { get; set; } // аз съм го дабавила 
        byte[] IHttpResponse.Content { get; set; }

        IHttpHeaderCollection IHttpResponse.Headers { get; }

        void IHttpResponse.AddHeader(HttpHeader header)
        {
            CoreValidator.ThrowIfNull(header, nameof(header));
            Headers.AddHeader(header);
        }

        byte[] IHttpResponse.GetBytes()
        {
            var Header = Encoding.UTF8.GetBytes(this.ToString());
            byte[] Response = new byte[Header.Length + Content.Length];
            Array.Copy(Header, 0, Response, 0, Header.Length);
            Array.Copy(Content, 0, Response, Header.Length, Content.Length);
            return Response;

        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result
                .Append($"{GlobalConstants.HttpOneProtocolFragment} {(int)this.StatusCode} {this.StatusCode.ToString()}")
                .Append(GlobalConstants.HttpNewLine)
                .Append(this.Headers)
                .Append(GlobalConstants.HttpNewLine);

            return result.ToString();
        }
    }
}
