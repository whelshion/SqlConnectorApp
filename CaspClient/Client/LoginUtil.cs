using CaspClient.Common.Data;
using CaspClient.Common.DataTran;
using CaspClient.Common.Encrypt;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Net;
using CaspClient.Client.Config;
using CaspClient.Common.Code;
using CaspClient.Client.Socket;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;

namespace CaspClient.Client
{
    public class LoginUtil
    {
        private static LoginUtil loginUtil;

        public static LoginUtil getInstance()
        {
            if (LoginUtil.loginUtil == null)
            {
                LoginUtil.loginUtil = new LoginUtil();
            }
            return LoginUtil.loginUtil;
        }

        /// <summary>
        /// casp_client_config.xml相对目录
        /// </summary>
        /// <param name="path"></param>
        public void init(string path)
        {
            CaspConfigUtil.init(path);
            ResultCodeUtil.init();
        }


        public bool isEnable()
        {
            return CaspConfigUtil.CaspClientConfig.EnableCaspClient;
        }

        public void setStatus(bool status)
        {
            CaspConfigUtil.CaspClientConfig.EnableCaspClient = status;
        }

        public bool checkTicket(HttpRequest request)
        {
            return request.Query.ContainsKey("iamcaspticket");
        }

        public string getTicket(HttpRequest request)
        {
            return request.Query["iamcaspticket"].ToString();
        }

        public async System.Threading.Tasks.Task<bool> hasAliveServer()
        {
            return await CaspServerManager.hasAliveServer();
        }

        public TransferTicket analysTicket(string ticket)
        {
            IClientTran clientTran = TranFactory.createClientTran(CaspConfigUtil.CaspClientConfig.DataFormatMode);
            TransferTicket transferTicket = (TransferTicket)clientTran.tranStrToBody(ticket, CaspConfigUtil.CaspClientConfig.AppKey, typeof(TransferTicket).FullName);
            if (transferTicket != null)
            {
                transferTicket.RetCode = "1000";
            }
            return transferTicket;
        }

        public async Task<UserInfo> qryUserByTicket(TransferTicket ticket)
        {
            CaspRequest caspRequest = new CaspRequest();
            Header header = this.createHeader("3");
            caspRequest.Header = header;
            ticket.TempKey = EncryptUtil.generateOTPKey();
            caspRequest.Body = ticket;
            CaspResponse caspResponse = await CaspSocket.send(caspRequest);
            if (caspResponse == null)
            {
                return null;
            }
            return (UserInfo)caspResponse.Body;
        }

        public async Task<TransferTicket> getSsoTicket(string rootTicket, string targetAppCode, string slaveAcc)
        {
            CaspRequest caspRequest = new CaspRequest();
            Header header = this.createHeader("4");
            caspRequest.Header = header;
            caspRequest.Body = new TransferTicket
            {
                RootTicket = rootTicket,
                TargetAppCode = targetAppCode,
                SlaveAcc = slaveAcc,
                TempKey = EncryptUtil.generateOTPKey()
            };
            CaspResponse caspResponse = await CaspSocket.send(caspRequest);
            if (caspResponse == null)
            {
                return null;
            }
            return (TransferTicket)caspResponse.Body;
        }

        public async Task<TransferTicket> accStaticPwdAuth(string masterAcc, string slaveAcc, string staticPwd, string userLoginIp)
        {
            CaspRequest caspRequest = new CaspRequest();
            Header header = this.createHeader("1");
            caspRequest.Header = header;
            caspRequest.Body = new AuthParam
            {
                Account = masterAcc,
                SlaveAcc = slaveAcc,
                PassWord = staticPwd,
                ClientIp = userLoginIp,
                AuthType = "passwordAuth",
                TempKey = EncryptUtil.generateOTPKey()
            };
            CaspResponse caspResponse = await CaspSocket.send(caspRequest);
            if (caspResponse == null)
            {
                return null;
            }
            return (TransferTicket)caspResponse.Body;
        }

        public async Task<TransferTicket> accTokenAuth(string masterAcc, string token, string pinCode, string userLoginIp, string slaveAcc)
        {
            CaspRequest caspRequest = new CaspRequest();
            Header header = this.createHeader("1");
            caspRequest.Header = header;
            caspRequest.Body = new AuthParam
            {
                Account = masterAcc,
                PassWord = token,
                PinCode = pinCode,
                ClientIp = userLoginIp,
                SlaveAcc = slaveAcc,
                AuthType = "tokenAuth",
                TempKey = EncryptUtil.generateOTPKey()
            };
            CaspResponse caspResponse = await CaspSocket.send(caspRequest);
            if (caspResponse == null)
            {
                return null;
            }
            return (TransferTicket)caspResponse.Body;
        }

        public async Task<TransferTicket> certAuth(X509Certificate cert, string userLoginIp)
        {
            CaspRequest caspRequest = new CaspRequest();
            Header header = this.createHeader("2");
            caspRequest.Header = header;
            caspRequest.Body = new AuthParam
            {
                // TODO:未找到以下方法的 .NET STANDARD 版本
                //CertString = cert.GetRawCertDataString(),
                ClientIp = userLoginIp,
                AuthType = "certAuth",
                TempKey = EncryptUtil.generateOTPKey()
            };
            CaspResponse caspResponse = await CaspSocket.send(caspRequest);
            if (caspResponse == null)
            {
                return null;
            }
            return (TransferTicket)caspResponse.Body;
        }

        public async Task<TransferTicket> secondPwdAuth(string masterAcc, string slaveAcc, string staticPwd, string rootTicket, string targetAppCode, string userLoginIp)
        {
            CaspRequest caspRequest = new CaspRequest();
            Header header = this.createHeader("2");
            caspRequest.Header = header;
            caspRequest.Body = new AuthParam
            {
                Account = masterAcc,
                SlaveAcc = slaveAcc,
                PassWord = staticPwd,
                RootTicket = rootTicket,
                TargetAppCode = targetAppCode,
                ClientIp = userLoginIp,
                AuthType = "passwordAuth",
                TempKey = EncryptUtil.generateOTPKey()
            };
            CaspResponse caspResponse = await CaspSocket.send(caspRequest);
            if (caspResponse == null)
            {
                return null;
            }
            return (TransferTicket)caspResponse.Body;
        }

        public async Task<TransferTicket> secondTokenAuth(string masterAcc, string token, string rootTicket, string pinCode, string userLoginIp, string targetAppCode, string slaveAcc)
        {
            CaspRequest caspRequest = new CaspRequest();
            Header header = this.createHeader("2");
            caspRequest.Header = header;
            caspRequest.Body = new AuthParam
            {
                Account = masterAcc,
                PassWord = token,
                RootTicket = rootTicket,
                PinCode = pinCode,
                ClientIp = userLoginIp,
                TargetAppCode = targetAppCode,
                SlaveAcc = slaveAcc,
                AuthType = "tokenAuth",
                TempKey = EncryptUtil.generateOTPKey()
            };
            CaspResponse caspResponse = await CaspSocket.send(caspRequest);
            if (caspResponse == null)
            {
                return null;
            }
            return (TransferTicket)caspResponse.Body;
        }

        public async Task logout(string rootTicket)
        {
            CaspRequest caspRequest = new CaspRequest();
            Header header = this.createHeader("5");
            caspRequest.Header = header;
            caspRequest.Body = new TransferTicket
            {
                RootTicket = rootTicket
            };
            await CaspSocket.send(caspRequest);
        }

        public void redirectToServer(HttpRequest request, HttpResponse response)
        {
            string text = CaspConfigUtil.getLoginUrl();
            string redirectQueryString = this.getRedirectQueryString(request);
            text = text + "?" + redirectQueryString;
            response.Redirect(text);
        }

        public string getCodeMess(string resultCode)
        {
            return ResultCodeUtil.getCodeMess(resultCode);
        }

        private string getRedirectQueryString(HttpRequest request)
        {
            string appCode = CaspConfigUtil.CaspClientConfig.AppCode;
            string targetUrl = this.getTargetUrl(request);
            return "appCode=" + WebUtility.UrlEncode(appCode) + "&target=" + WebUtility.UrlEncode(targetUrl);
        }

        private string getTargetUrl(HttpRequest request)
        {
            //string str = request.PathBase.Url.AbsoluteUri.Replace(request.Url.PathAndQuery, "");
            string str = request.Scheme + "://" + request.Host + request.PathBase + request.Path;
            string text = request.QueryString.ToString();
            Regex regex = new Regex("(^target=[^&]*&) | (&target=[^&]*)");
            if (regex.IsMatch(text))
            {
                text = regex.Replace(text, "");
            }
            return str + "?" + text;
        }

        private Header createHeader(string requestTypeCode)
        {
            return new Header
            {
                AppCode = CaspConfigUtil.CaspClientConfig.AppCode,
                RequestTypeCode = requestTypeCode,
                DataFormatMode = CaspConfigUtil.CaspClientConfig.DataFormatMode
            };
        }
    }
}
