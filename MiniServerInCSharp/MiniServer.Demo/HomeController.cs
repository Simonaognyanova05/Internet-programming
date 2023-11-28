using Mini_HTTP_Server.Enums;
using Mini_HTTP_Server.Requests;
using Mini_HTTP_Server.Responses;
using MiniServer.WebServer.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniServer.Demo
{
    public class HomeController
    {
        /// <summary>
        /// HTML
        /// </summary>
        public IHttpResponse Index(IHttpRequest request)
        {
            string content = "<h1> Hello,World! </h1>";
            return new HtmlResult(content, HttpResponseStatusCode.Ok);
        }
    }
}
