using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Mini_HTTP_Server.Common
{
    public class CoreValidator
    {
        public static void ThrowIfNull(object obj, string name)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(name);
            }
        }

        public static void ThrowIfNullorEmpty(string text, string name)
        {
            if(string.IsNullOrEmpty(text))
            {
                throw new ArgumentNullException($"{name} can not be null or empty", name);
            }
        }
    }
}
