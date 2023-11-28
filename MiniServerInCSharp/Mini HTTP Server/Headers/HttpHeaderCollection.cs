using Mini_HTTP_Server.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Mini_HTTP_Server.Headers
{
    public class HttpHeaderCollection : IHttpHeaderCollection
    {
        private readonly Dictionary<string, HttpHeader> Headers;
        public HttpHeaderCollection()
        {
            this.Headers = new Dictionary<string, HttpHeader>();
        }
        public void AddHeader(HttpHeader header)
        {
            CoreValidator.ThrowIfNull(header, nameof(header));
            Headers.Add(header.Key,header);
        }
        public bool ContainsHeader(string key)
        {
            CoreValidator.ThrowIfNullorEmpty(key, nameof(key));
            return Headers.ContainsKey(key);



        }
        public HttpHeader GetHeader(string key)
        {
            CoreValidator.ThrowIfNullorEmpty(key, nameof(key));
            return Headers[key];


        }
        public override string ToString()
            => string.Join(Environment.NewLine, this.Headers.Values.Select(header => header.ToString()));


    }

}
