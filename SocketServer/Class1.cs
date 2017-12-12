using System;
using System.Net;
using System.Net.Sockets;

namespace SocketServer
{
    public class TcpSocketServer
    {
        TcpListener listener = new TcpListener(IPAddress.Any,9999);
        public void Start()
        {
            listener.Start();
        }

        public void Stop()
        {
            listener.Stop();
        }
    }
}
