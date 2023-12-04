﻿using Mini_HTTP_Server.Enums;
using Mini_HTTP_Server.Responses;
using MiniServer.WebServer.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace IRunes.App.Controlles
{
    public abstract class BaseController
    {
        protected BaseController() => this.ViewData = new Dictionary<string, object>();

        protected Dictionary<string, object> ViewData;

        private string ParseTemplate(string viewContent)
        {
            foreach (var param in this.ViewData)
            {
                viewContent = viewContent.Replace($"@Model.${param.Key}", param.Value.ToString());

            }
            return viewContent;
        }

        protected IHttpResponse View([CallerMemberName] string view = null)
        {
            string controllerName = this.GetType().Name.Replace("Controller", string.Empty);
            string viewName = view;
            string viewContent = File.ReadAllText("Views/" + controllerName + "/" + viewName + ".html");
            viewContent = this.ParseTemplate(viewContent);
            HtmlResult htmlResult = new HtmlResult(viewContent, HttpResponseStatusCode.Ok);
            return htmlResult;
        }

        protected IHttpResponse Redict(string url)
        {
            return new RedirectResult(url);
        }
    }
}
