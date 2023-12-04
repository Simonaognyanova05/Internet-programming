using Mini_HTTP_Server.Requests;
using Mini_HTTP_Server.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRunes.App.Controlles
{
    public class HomeController: BaseController
    {
        public IHttpResponse Index(IHttpRequest httpRequest)
        {
            return (IHttpResponse)View();
        }
    }
}
