﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_HTTP_Server.Common
{
    public class GlobalConstants
    {
        public const string HttpOneProtocol = "HTTP/1.1";
        public const string HostHeaderKey = "Host";
        public const string HttpNewLine = "\r\n";

        public static string HttpOneProtocolFragment { get; internal set; }
    }
}
