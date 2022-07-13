using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ZibalMoheb
{
    public class Response
    {
        private Byte[] data = null;
        private String status;
        private String mime;
        
        private Response(String status, String mime, Dictionary<String, dynamic> data)
        {
            this.status = status;
            this.data = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(data));
            this.mime = mime;
        }

        public static Response From(Request request)
        {
            if (request.Type == "GET")
            {
                Regex regexpAuth = new Regex(
                            @"authorization=(\S{43})",
                            RegexOptions.IgnoreCase
                );
                Match authMatch = regexpAuth.Match(request.URL.ToString());
                const String authKey = "******";

                if (!request.URL.ToString().Contains("authorization") || authMatch.Groups[1].Value != authKey)
                {
                    return new Response("403", "application/json", new Dictionary<string, dynamic> { { "error", "Forbiden, Permission Denied" } });
                }
                else
                {
                    if (!request.URL.ToString().Contains("dateTime") || !request.URL.ToString().Contains("key"))
                    {
                        return InvalidParam();
                    }
                    else
                    {
                        string requestString = request.URL.ToString();
                        Regex regexp = new Regex(
                            @"dateTime=(\d{4}/\d{2}/\d{2})",
                            RegexOptions.IgnoreCase
                        );
                        Regex regexpKey = new Regex(
                            @"key=(.\d*)",
                            RegexOptions.IgnoreCase
                        );
                        
                        Match dateTimeMatch = regexp.Match(requestString);
                        Match keyMatch = regexpKey.Match(requestString);
                        
                        string dateTime = dateTimeMatch.Groups[1].Value;
                        string key = keyMatch.Groups[1].Value;

                        try
                        {
                            return BankResponse(dateTime, Int32.Parse(key));
                        }
                        catch (FormatException e)
                        {
                            return new Response("400", "application/json", new Dictionary<string, dynamic> { { "error", "Bad Request" }, { "message", e.Message } });
                        }
                    }

                }
            }

            else
                return MethodNotAllowed();
        }

        private static Response InvalidParam()
        {
            return new Response("400", "application/json", new Dictionary<string, dynamic> { { "error", "Bad Request" }, { "message", "dateTime and key are required" } });
        }

        private static Response BankResponse(string date, int key)
        {
            using (Moheb.StatementServiceClient svc = new Moheb.StatementServiceClient())
            {

                try
                {
                    var result = svc.GetAccountTransaction(9515290514, key, date);
                    if (result.ResponseCode != 0)
                    {
                        return new Response("200", "application/json", new Dictionary<string, dynamic> { { "hasError", true }, { "status", result.ResponseCode } });
                    }
                    else
                        return new Response("200", "application/json", new Dictionary<string, dynamic> { { "hasError", false }, { "status", result.ResponseCode }, { "result", result.AccountTransactions } });
                }
                catch(Exception err)
                {
                    return new Response("400", "application/json", new Dictionary<string, dynamic> { { "error", "Bad Request" }, { "message", err.Message } });
                }
            }
        }

        private static Response MethodNotAllowed()
        {
            return new Response("405", "application/json", new Dictionary<string, dynamic> { {"error","Method Not Allowed" } });
        }   

        public void Post(NetworkStream stream)
        {
            StreamWriter writer = new StreamWriter(stream);
            writer.WriteLine(String.Format("{0} {1}\r\nServer: {2}\r\nContent-Type: {3}\r\nAccept-Ranges: bytes\r\nContent-Length: {4}\r\n",
                HTTPServer.VERSION, status, HTTPServer.NAME, mime, data.Length));
            writer.Flush();
            stream.Write(data, 0, data.Length);
        }
    }
}
