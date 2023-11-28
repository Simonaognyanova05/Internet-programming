using Mini_HTTP_Server.Enums;
using Mini_HTTP_Server.Headers;
using Mini_HTTP_Server.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniServer.WebServer.Results
{
    public class HtmlResult : HttpResponse
    {
        public HtmlResult(string content, HttpResponseStatusCode responseStatusCode)
            : base(responseStatusCode)
        {
            this.Headers.AddHeader(new HttpHeader("ContentType", "text/html; charset=utf-8")) ;
            this.Content = Encoding.UTF8.GetBytes(content);
        }
    }
}
