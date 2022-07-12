using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZibalMoheb
{
    public class Request
    {
        public String Type { get; set; }
        public String URL { get; set; }

        private Request(String type, String url)
        {
            Type = type;
            URL = url;
        }

        public static Request GetRequest(String request)
        {
            if (String.IsNullOrEmpty(request))
                return null;
            
            try
            {
                String[] tokens = request.Split(' ');
                String type = tokens[0];
                String url = tokens[1];
                return new Request(type, url);
            }
            catch (IndexOutOfRangeException)
            {
                return new Request("", "");
            }
            
        }
    }
}
