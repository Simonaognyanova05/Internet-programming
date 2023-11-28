using Mini_HTTP_Server.Enums;
using MiniServer.WebServer;
using MiniServer.WebServer.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniServer.Demo
{
    public class Launcher
    {
        public static void Main(string[] args)
        {
            // Create Web Routing Table
            IServerRoutingTable serverRoutingTable = new ServerRoutingTable();

            serverRoutingTable.Add
            (
                HttpRequestMethod.Get,
                path: "/",
                request => new HomeController().Index(request)
            );

            // Start Web Server
            Server server = new Server(8000, serverRoutingTable);
            server.Run();
        }
    }
}
