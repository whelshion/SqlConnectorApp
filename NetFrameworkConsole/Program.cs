using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFrameworkConsole
{
    class Program
    {
        static string xml = @"<?xml version='1.0' encoding='UTF-8'?>				 
                            <USERMODIFYREQ>
                                <HEAD>
		                            <CODE>消息标志</CODE>
		                            <SID>消息序列号</SID>
                                    <TIMESTAMP>20171215111111</TIMESTAMP>
		                            <SERVICEID>ZNZJXT</SERVICEID>
                                </HEAD>
                                <BODY>
		                            <OPERATORID>68f3f3af-88e6-41ae-910d-289848209044</OPERATORID>
		                            <OPERATORPWD>Password1</OPERATORPWD>
                                    <OPERATORIP>120.25.238.73</OPERATORIP>
                                    <MODIFYMODE>delete</MODIFYMODE>
		                            <USERINFO>
                                        <USERID>56d7bd52-d8ea-4401-824f-c0dae750047d</USERID>
			                            <LOGINNO>gx4a_2</LOGINNO>
                                        <USERNAME>南宁4A</USERNAME>
                                        <ORGID>1</ORGID>
                                        <EMAIL>jd.gxu@gxu.edu.cn</EMAIL>
                                        <MOBILE>17777777777</MOBILE>
                                        <PASSWORD>123456</PASSWORD>
                                        <STATUS>1</STATUS>
                                        <EFFECTDATE>生效时间</EFFECTDATE>
                                        <EXPIREDATE>20181215111111</EXPIREDATE>
                                        <REMARK>4A添加</REMARK>
                                        <DUTY>职位</DUTY>
				                        <OPERTYPE>操作员类型</OPERTYPE>
				                        <OPERLEVEL>操作员级别</OPERLEVEL>
                                        <DUTYLEVEL>业务级别</DUTYLEVEL>
		                            </USERINFO>
	                            </BODY>
                            </USERMODIFYREQ>";
        static void Main(string[] args)
        {
            TestGxService();
            //TestSCAccountWS();
        }

        private static void TestGxService()
        {
            var wsClient = new GX4AService.GX4AServiceSoapClient();
            var result = wsClient.UpdateAppAcctSoap(xml);
            //var result2 = wsClient(xml);
            Console.WriteLine(result);
            Console.ReadKey();
        }

        private static void TestSCAccountWS()
        {
            var wsClient = new SCAccountWS.AccountServiceSoapClient();
            var result = wsClient.queryUsersAsync().Result;
            Console.WriteLine(result.Body?.queryUsersResult);
            Console.ReadKey();
        }
    }
}
