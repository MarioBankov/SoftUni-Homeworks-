using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace TestWebServer
{
    class Program
    {
        static void Main(string[] args)
        {
            const string NewLine = "\r\n";
            var tcpListener = new TcpListener(IPAddress.Loopback, 12346);
            tcpListener.Start();
            while (true)
            {
                var client = tcpListener.AcceptTcpClient();
                var stream = client.GetStream();
                
                var requestedBytes = new byte[10000];

                var readBytes = stream.Read(requestedBytes, 0, requestedBytes.Length);

                var bytesAsString  = Encoding.UTF8.GetString(requestedBytes, 0, readBytes);

                Console.WriteLine(new string('=', 70));
                Console.WriteLine(bytesAsString);

                string responseBody = "<form method='post'><input type='text' name='tweet' placeholder='Enter tweet...' /><input name='name' /> <input type='submit' /></form>" +
                    "<H1>Hello User</H1>";

                string response = "HTTP/1.1 200 OK" + NewLine +
                                  "Content-Type: text/html" + NewLine +
                                  "Server: MyCustomServer/1.0" + NewLine +
                                  $"Content-Length: {responseBody.Length}" + NewLine + NewLine +
                                  responseBody;
                byte[] responseBytes = Encoding.UTF8.GetBytes(response);
                stream.Write(responseBytes, 0, responseBytes.Length);

            }
        }
    }
}
