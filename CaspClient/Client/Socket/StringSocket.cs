using CaspClient.Client.Config;
using CaspClient.Common.Socket;
using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace CaspClient.Client.Socket
{
    public class StringSocket
    {
        public static async System.Threading.Tasks.Task<string> send(string requestStr)
        {
            SocketUtil socketUtil = new SocketUtil();
            TcpClient tcpClient = await socketUtil.connect(CaspConfigUtil.CurCaspServerConfig.Ip, CaspConfigUtil.CurCaspServerConfig.Port, CaspConfigUtil.CurCaspServerConfig.TimeOut);
            NetworkStream stream = tcpClient.GetStream();
            UtfUtil.writeUTF(requestStr, stream);
            return UtfUtil.readUTF(stream);
        }
    }
}
