using CaspClient.Client.Config;
using CaspClient.Common.Code;
using CaspClient.Common.Data;
using CaspClient.Common.DataTran;
using CaspClient.Common.Encrypt;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace CaspClient.Client.DataTran
{
    public class ClientTranStrImpl : IClientTran
    {
        public string tranResquestToStr(CaspRequest request, string key)
        {
            string str = request.Header.objToStr();
            string value = request.Body.objToStr();
            EncryptParam encryptParam = new EncryptParam();
            encryptParam.Value = value;
            encryptParam.Key = key;
            IEncrypter encrypter = EncryptFactory.createEncrypter(CaspConfigUtil.CaspClientConfig.EncodeType);
            string str2 = encrypter.encode(encryptParam);
            return str + "G|T" + str2;
        }

        public CaspResponse tranStrToResponse(string data, string key)
        {
            string[] array = data.Split(new string[]
            {
                "G|T"
            }, StringSplitOptions.None);
            Header header = new Header();
            header.strToObj(array[0]);
            EncryptParam encryptParam = new EncryptParam();
            encryptParam.Value = array[1];
            encryptParam.Key = key;
            IEncrypter encrypter = EncryptFactory.createEncrypter(CaspConfigUtil.CaspClientConfig.EncodeType);
            string data2 = encrypter.decode(encryptParam);
            string bodyClass = RequestTypeBodyMapping.getBodyClass(header.RequestTypeCode);
            Body body = (Body)typeof(ClientTranStrImpl).GetTypeInfo().Assembly.CreateInstance(bodyClass);
            body.strToObj(data2);
            return new CaspResponse
            {
                Header = header,
                Body = body
            };
        }

        public Body tranStrToBody(string data, string key, string className)
        {
            EncryptParam encryptParam = new EncryptParam();
            encryptParam.Value = data;
            encryptParam.Key = key;
            IEncrypter encrypter = EncryptFactory.createEncrypter(CaspConfigUtil.CaspClientConfig.EncodeType);
            string data2 = encrypter.decode(encryptParam);
            Body body = (Body)typeof(ClientTranStrImpl).GetTypeInfo().Assembly.CreateInstance(className);
            body.strToObj(data2);
            return body;
        }
    }
}
