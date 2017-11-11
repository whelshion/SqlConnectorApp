using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace CaspClient.Common.Socket
{
    public class SocketUtil
    {
        public async System.Threading.Tasks.Task<bool> check(string ip, int port, int timeoutMSec = 0)
        {
            TcpClient tcpClient = new TcpClient();
            if (timeoutMSec > 0)
            {
                tcpClient.ReceiveTimeout = timeoutMSec;
            }
            await tcpClient.ConnectAsync(ip, port);
            bool result = tcpClient.Connected;
            if (result)
            {
                tcpClient.Client.Dispose();
                tcpClient.Dispose();
            }
            return result;
        }

        /// <summary>
        /// 连接SSL Socket Server
        /// 这是一个异步方法
        /// </summary>
        /// <param name="ip"></param>
        /// <param name="port"></param>
        /// <param name="timeoutMSec">间隔毫秒数</param>
        /// <returns></returns>
        public async System.Threading.Tasks.Task<TcpClient> connect(string ip, int port, int timeoutMSec = 0)
        {
            TcpClient tcpClient = new TcpClient();
            if (timeoutMSec > 0)
            {
                tcpClient.ReceiveTimeout = timeoutMSec;
            }
            await tcpClient.ConnectAsync(ip, port);
            if (tcpClient.Connected)
            {
                return tcpClient;
            }
            throw new SocketException();
        }
    }
}
