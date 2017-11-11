using CaspClient.Common.Socket;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CaspClient.Client.Config
{
    public class CaspServerManager
    {
        private static bool isAlive;

        private static long preSwitchTime;

        public static async System.Threading.Tasks.Task<bool> hasAliveServer()
        {
            if (!CaspConfigUtil.CaspClientConfig.QueryStateEnable)
            {
                return true;
            }
            if (CaspServerManager.isAlive && !CaspServerManager.isCycleCheckTime())
            {
                return true;
            }
            foreach (CaspServerConfig current in CaspConfigUtil.CaspServerConfigList)
            {
                if (current.IsMaster && await CaspServerManager.connect(current))
                {
                    CaspConfigUtil.CurCaspServerConfig = current;
                    CaspServerManager.isAlive = true;
                    CaspServerManager.preSwitchTime = CaspServerManager.currentTimeMillis();
                    bool result = true;
                    return result;
                }
            }
            foreach (CaspServerConfig current2 in CaspConfigUtil.CaspServerConfigList)
            {
                if (!current2.IsMaster && await CaspServerManager.connect(current2))
                {
                    CaspConfigUtil.CurCaspServerConfig = current2;
                    CaspServerManager.isAlive = true;
                    CaspServerManager.preSwitchTime = CaspServerManager.currentTimeMillis();
                    bool result = true;
                    return result;
                }
            }
            return false;
        }

        private static async System.Threading.Tasks.Task<bool> connect(CaspServerConfig caspServerConfig)
        {
            for (int i = 0; i < 3; i++)
            {
                SocketUtil socketUtil = new SocketUtil();
                bool flag = await socketUtil.check(caspServerConfig.Ip, caspServerConfig.Port, caspServerConfig.TimeOut);
                if (flag)
                {
                    return true;
                }
                Thread.Sleep(300);
            }
            return false;
        }

        private static bool isCycleCheckTime()
        {
            long num = CaspServerManager.currentTimeMillis();
            long num2 = (long)CaspConfigUtil.CaspClientConfig.Switchcycletime;
            return num - CaspServerManager.preSwitchTime > num2;
        }

        private static long currentTimeMillis()
        {
            return (DateTime.UtcNow.Ticks - new DateTime(1970, 1, 1, 0, 0, 0).Ticks) / 10000L;
        }
    }
}
