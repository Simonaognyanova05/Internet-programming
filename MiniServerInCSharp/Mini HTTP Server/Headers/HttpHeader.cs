using Mini_HTTP_Server.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_HTTP_Server.Headers
{
    public class HttpHeader
    {
        public HttpHeader(string key, string value)
        {
            CoreValidator.ThrowIfNullorEmpty(key, nameof(key));
            CoreValidator.ThrowIfNullorEmpty(value, nameof(value));

            this.Key = key;
            this.Value = value;
        }

           public string Key { get; }
          public string Value { get;  }

        public override string ToString()
        {
            return $"{this.Key}: {this.Value}";
        }


    }

    }
