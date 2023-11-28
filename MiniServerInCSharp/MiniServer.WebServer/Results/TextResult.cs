﻿using Mini_HTTP_Server.Enums;
using Mini_HTTP_Server.Headers;
using Mini_HTTP_Server.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniServer.WebServer.Results
{
    public class TextResult:HttpResponse
    {
        public TextResult(string content,HttpResponseStatusCode responseStatusCode,
            string contentType = "text/plain; charset=utf-8")
            :base(responseStatusCode)
        {
           this.Headers.AddHeader(new HttpHeader("Content-Type", contentType));
            this.Content = Encoding.UTF8.GetBytes(content);
        }

        public TextResult(byte[] content, HttpResponseStatusCode responseStatusCode,
          string contentType = "text/plain; charset=utf-8")
          : base(responseStatusCode)
        {
            this.Headers.AddHeader(new HttpHeader("Content-Type", contentType));
            this.Content = content;
        }

    }
}
