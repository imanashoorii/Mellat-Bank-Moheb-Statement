using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ZibalMoheb
{
    public class HTTPServer
    {

        public const String VERSION = "HTTP/1.1";
        public const String NAME = "IMAN ASHOORI HTTP SERVER";

        private bool running = false;
        private TcpListener listener;
        private Thread serverThread;

        public HTTPServer(int port)
        {
            listener = new TcpListener(new IPEndPoint(IPAddress.Any, port));
        }

        public void Start()
        {
            Thread deamonThread = new Thread(new ThreadStart(Deamon));
            Thread serverThread = new Thread(new ThreadStart(Run));
            this.serverThread = serverThread;
            serverThread.Start();
            deamonThread.Start();
        }

        public void Deamon()
        {
            while (true)
            {
                Thread.Sleep(1000);
                if (!serverThread.IsAlive)
                {
                     serverThread.Start();
                }
            }
            
        }
        private void Run()
        {
            running = true;
            listener.Start();
            while(running)
            {
                try
                {
                    TcpClient client = listener.AcceptTcpClient();
                    if (client != null)
                    {
                        HandleClient(client);
                        client.Close();
                    }
                }
                catch (Exception err)
                {
                    listener.Start();
                    Console.WriteLine(err.Message);
                }
            }

        }

        private void HandleClient(TcpClient client)
        {
            StreamReader reader = new StreamReader(client.GetStream());
            String msg = "";
            while (reader.Peek() != -1)
            {
                msg += reader.ReadLine() + "\n";
            }

            Debug.WriteLine("Request: \n" + msg);
            Request req = Request.GetRequest(msg);
            Response resp = Response.From(req);
            resp.Post(client.GetStream());
            
        }
    }
}
