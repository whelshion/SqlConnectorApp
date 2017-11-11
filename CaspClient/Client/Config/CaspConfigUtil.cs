using CaspClient.Common.Encrypt;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Xml;

namespace CaspClient.Client.Config
{
    public class CaspConfigUtil
    {
        private static CaspClientConfig caspClientConfig;

        private static CaspServerConfig curCaspServerConfig;

        private static List<CaspServerConfig> caspServerConfigList;

        private static string loginUrl;

        private static string agentSsoUrl;

        public static CaspClientConfig CaspClientConfig
        {
            get
            {
                return CaspConfigUtil.caspClientConfig;
            }
        }

        public static CaspServerConfig CurCaspServerConfig
        {
            get
            {
                return CaspConfigUtil.curCaspServerConfig;
            }
            set
            {
                CaspConfigUtil.curCaspServerConfig = value;
            }
        }

        public static List<CaspServerConfig> CaspServerConfigList
        {
            get
            {
                return CaspConfigUtil.caspServerConfigList;
            }
        }

        public static void init(string path)
        {
            if (!File.Exists(path))
            {
                string location = typeof(CaspConfigUtil).GetTypeInfo().Assembly.Location;
                string path2 = location.Substring(0, location.LastIndexOf("\\")) + "\\casp_client_config.xml";
                if (!File.Exists(path2))
                {
                    throw new FileNotFoundException("casp_client_config.xml file not found.");
                }
            }
            CaspConfigUtil.caspClientConfig = new CaspClientConfig();
            CaspConfigUtil.curCaspServerConfig = new CaspServerConfig();
            CaspConfigUtil.caspServerConfigList = new List<CaspServerConfig>();
            XmlDocument xmlDocument = new XmlDocument();
            using (var stream = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                xmlDocument.Load(stream);
            }
            XmlElement documentElement = xmlDocument.DocumentElement;
            foreach (XmlNode xmlNode in documentElement.ChildNodes)
            {
                if (xmlNode.NodeType == XmlNodeType.Element)
                {
                    string a = xmlNode.Name.ToLower();
                    if (a != "server")
                    {
                        CaspConfigUtil.setCaspClientConfigProperty(xmlNode);
                    }
                    else if (a == "server")
                    {
                        CaspConfigUtil.setCaspServerConfig(xmlNode);
                    }
                }
            }
            EncryptParam encryptParam = new EncryptParam();
            encryptParam.Value = CaspConfigUtil.caspClientConfig.AppKey;
            encryptParam.Key = "IAM";
            IEncrypter encrypter = EncryptFactory.createEncrypter("1");
            string appKey = encrypter.decode(encryptParam);
            CaspConfigUtil.caspClientConfig.AppKey = appKey;
            CaspConfigUtil.curCaspServerConfig = CaspConfigUtil.caspServerConfigList[0];
        }

        private static void setCaspClientConfigProperty(XmlNode xmlNode)
        {
            string a = xmlNode.Name.ToLower();
            if (a == "enablecaspclient")
            {
                CaspConfigUtil.caspClientConfig.EnableCaspClient = Convert.ToBoolean(xmlNode.InnerText);
                return;
            }
            if (a == "appcode")
            {
                CaspConfigUtil.caspClientConfig.AppCode = xmlNode.InnerText;
                return;
            }
            if (a == "appkey")
            {
                CaspConfigUtil.caspClientConfig.AppKey = xmlNode.InnerText;
                return;
            }
            if (a == "querystateenable")
            {
                CaspConfigUtil.caspClientConfig.QueryStateEnable = Convert.ToBoolean(xmlNode.InnerText);
                return;
            }
            if (a == "hasbak")
            {
                CaspConfigUtil.caspClientConfig.Hasbak = Convert.ToBoolean(xmlNode.InnerText);
                return;
            }
            if (a == "switchcycletime")
            {
                CaspConfigUtil.caspClientConfig.Switchcycletime = Convert.ToInt32(xmlNode.InnerText);
                return;
            }
            if (a == "loginurl")
            {
                CaspConfigUtil.caspClientConfig.LoginUrl = xmlNode.InnerText;
                return;
            }
            if (a == "agentssourl")
            {
                CaspConfigUtil.caspClientConfig.AgentSsoUrl = xmlNode.InnerText;
                return;
            }
            if (a == "dataformatmode")
            {
                CaspConfigUtil.caspClientConfig.DataFormatMode = xmlNode.InnerText;
                return;
            }
            if (a == "encodetype")
            {
                CaspConfigUtil.caspClientConfig.EncodeType = xmlNode.InnerText;
            }
        }

        private static void setCaspServerConfig(XmlNode xmlNode)
        {
            CaspServerConfig caspServerConfig = new CaspServerConfig();
            foreach (XmlNode xmlNode2 in xmlNode.ChildNodes)
            {
                if (xmlNode2.NodeType == XmlNodeType.Element)
                {
                    string a = xmlNode2.Name.ToLower();
                    if (a == "id")
                    {
                        caspServerConfig.Id = xmlNode2.InnerText;
                    }
                    else if (a == "ip")
                    {
                        caspServerConfig.Ip = xmlNode2.InnerText;
                    }
                    else if (a == "port")
                    {
                        caspServerConfig.Port = Convert.ToInt32(xmlNode2.InnerText);
                    }
                    else if (a == "probeport")
                    {
                        caspServerConfig.ProbePort = Convert.ToInt32(xmlNode2.InnerText);
                    }
                    else if (a == "webserverport")
                    {
                        caspServerConfig.WebServerPort = Convert.ToInt32(xmlNode2.InnerText);
                    }
                    else if (a == "ismaster")
                    {
                        caspServerConfig.IsMaster = Convert.ToBoolean(xmlNode2.InnerText);
                    }
                    else if (a == "returnvalue")
                    {
                        caspServerConfig.ReturnValue = xmlNode2.InnerText;
                    }
                    else if (a == "timeout")
                    {
                        caspServerConfig.TimeOut = Convert.ToInt32(xmlNode2.InnerText);
                    }
                    else if (a == "appcontext")
                    {
                        caspServerConfig.AppContext = xmlNode2.InnerText;
                    }
                    else if (a == "scheme")
                    {
                        caspServerConfig.Scheme = xmlNode2.InnerText;
                    }
                }
            }
            CaspConfigUtil.caspServerConfigList.Add(caspServerConfig);
        }

        public static string getLoginUrl()
        {
            if (CaspConfigUtil.loginUrl == null)
            {
                CaspConfigUtil.loginUrl = CaspConfigUtil.getCurCaspServerUrl() + "/" + CaspConfigUtil.caspClientConfig.LoginUrl;
            }
            return CaspConfigUtil.loginUrl;
        }

        public static string getAgentSsoUrl()
        {
            if (CaspConfigUtil.agentSsoUrl == null)
            {
                CaspConfigUtil.agentSsoUrl = CaspConfigUtil.getCurCaspServerUrl() + "/" + CaspConfigUtil.caspClientConfig.AgentSsoUrl;
            }
            return CaspConfigUtil.agentSsoUrl;
        }

        private static string getCurCaspServerUrl()
        {
            return string.Concat(new object[]
            {
                CaspConfigUtil.curCaspServerConfig.Scheme,
                "://",
                CaspConfigUtil.curCaspServerConfig.Ip,
                ":",
                CaspConfigUtil.curCaspServerConfig.WebServerPort,
                "/",
                CaspConfigUtil.curCaspServerConfig.AppContext
            });
        }
    }
}
