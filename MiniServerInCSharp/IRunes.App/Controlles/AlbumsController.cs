using Mini_HTTP_Server.Requests;
using Mini_HTTP_Server.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRunes.App.Controlles
{
   public class AlbumsController: BaseController
    {
        public IHttpResponse All(IHttpRequest httpRequest)
        {
            return this.View();
        }
        public IHttpResponse Details(IHttpRequest httpRequest)
        {
            return this.View();
        }
        public IHttpResponse Create(IHttpRequest httpRequest)
        {
            return this.View();
        }
        public IHttpResponse CreateConfirm(IHttpRequest httpRequest)
        {
            return this.View();
        }
    }
}

