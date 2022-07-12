using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ZibalMoheb
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting Server on Port 8080 ...");                                                                                            
            HTTPServer server = new HTTPServer(8080);
            server.Start();
        }
    }
}
