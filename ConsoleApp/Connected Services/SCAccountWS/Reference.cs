//------------------------------------------------------------------------------
// <自动生成>
//     此代码由工具生成。
//     //
//     对此文件的更改可能导致不正确的行为，并在以下条件下丢失:
//     代码重新生成。
// </自动生成>
//------------------------------------------------------------------------------

namespace SCAccountWS
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SCAccountWS.AccountServiceSoap")]
    public interface AccountServiceSoap
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/findUser", ReplyAction="*")]
        System.Threading.Tasks.Task<SCAccountWS.findUserResponse> findUserAsync(SCAccountWS.findUserRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/queryUsers", ReplyAction="*")]
        System.Threading.Tasks.Task<SCAccountWS.queryUsersResponse> queryUsersAsync(SCAccountWS.queryUsersRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/modifyUserInfo", ReplyAction="*")]
        System.Threading.Tasks.Task<SCAccountWS.modifyUserInfoResponse> modifyUserInfoAsync(SCAccountWS.modifyUserInfoRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class findUserRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="findUser", Namespace="http://tempuri.org/", Order=0)]
        public SCAccountWS.findUserRequestBody Body;
        
        public findUserRequest()
        {
        }
        
        public findUserRequest(SCAccountWS.findUserRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class findUserRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string userID;
        
        public findUserRequestBody()
        {
        }
        
        public findUserRequestBody(string userID)
        {
            this.userID = userID;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class findUserResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="findUserResponse", Namespace="http://tempuri.org/", Order=0)]
        public SCAccountWS.findUserResponseBody Body;
        
        public findUserResponse()
        {
        }
        
        public findUserResponse(SCAccountWS.findUserResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class findUserResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string findUserResult;
        
        public findUserResponseBody()
        {
        }
        
        public findUserResponseBody(string findUserResult)
        {
            this.findUserResult = findUserResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class queryUsersRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="queryUsers", Namespace="http://tempuri.org/", Order=0)]
        public SCAccountWS.queryUsersRequestBody Body;
        
        public queryUsersRequest()
        {
        }
        
        public queryUsersRequest(SCAccountWS.queryUsersRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class queryUsersRequestBody
    {
        
        public queryUsersRequestBody()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class queryUsersResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="queryUsersResponse", Namespace="http://tempuri.org/", Order=0)]
        public SCAccountWS.queryUsersResponseBody Body;
        
        public queryUsersResponse()
        {
        }
        
        public queryUsersResponse(SCAccountWS.queryUsersResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class queryUsersResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string queryUsersResult;
        
        public queryUsersResponseBody()
        {
        }
        
        public queryUsersResponseBody(string queryUsersResult)
        {
            this.queryUsersResult = queryUsersResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class modifyUserInfoRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="modifyUserInfo", Namespace="http://tempuri.org/", Order=0)]
        public SCAccountWS.modifyUserInfoRequestBody Body;
        
        public modifyUserInfoRequest()
        {
        }
        
        public modifyUserInfoRequest(SCAccountWS.modifyUserInfoRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class modifyUserInfoRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string userInfos;
        
        public modifyUserInfoRequestBody()
        {
        }
        
        public modifyUserInfoRequestBody(string userInfos)
        {
            this.userInfos = userInfos;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class modifyUserInfoResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="modifyUserInfoResponse", Namespace="http://tempuri.org/", Order=0)]
        public SCAccountWS.modifyUserInfoResponseBody Body;
        
        public modifyUserInfoResponse()
        {
        }
        
        public modifyUserInfoResponse(SCAccountWS.modifyUserInfoResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class modifyUserInfoResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string modifyUserInfoResult;
        
        public modifyUserInfoResponseBody()
        {
        }
        
        public modifyUserInfoResponseBody(string modifyUserInfoResult)
        {
            this.modifyUserInfoResult = modifyUserInfoResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    public interface AccountServiceSoapChannel : SCAccountWS.AccountServiceSoap, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    public partial class AccountServiceSoapClient : System.ServiceModel.ClientBase<SCAccountWS.AccountServiceSoap>, SCAccountWS.AccountServiceSoap
    {
        
    /// <summary>
    /// 实现此分部方法，配置服务终结点。
    /// </summary>
    /// <param name="serviceEndpoint">要配置的终结点</param>
    /// <param name="clientCredentials">客户端凭据</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public AccountServiceSoapClient(EndpointConfiguration endpointConfiguration) : 
                base(AccountServiceSoapClient.GetBindingForEndpoint(endpointConfiguration), AccountServiceSoapClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public AccountServiceSoapClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(AccountServiceSoapClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public AccountServiceSoapClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(AccountServiceSoapClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public AccountServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SCAccountWS.findUserResponse> SCAccountWS.AccountServiceSoap.findUserAsync(SCAccountWS.findUserRequest request)
        {
            return base.Channel.findUserAsync(request);
        }
        
        public System.Threading.Tasks.Task<SCAccountWS.findUserResponse> findUserAsync(string userID)
        {
            SCAccountWS.findUserRequest inValue = new SCAccountWS.findUserRequest();
            inValue.Body = new SCAccountWS.findUserRequestBody();
            inValue.Body.userID = userID;
            return ((SCAccountWS.AccountServiceSoap)(this)).findUserAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SCAccountWS.queryUsersResponse> SCAccountWS.AccountServiceSoap.queryUsersAsync(SCAccountWS.queryUsersRequest request)
        {
            return base.Channel.queryUsersAsync(request);
        }
        
        public System.Threading.Tasks.Task<SCAccountWS.queryUsersResponse> queryUsersAsync()
        {
            SCAccountWS.queryUsersRequest inValue = new SCAccountWS.queryUsersRequest();
            inValue.Body = new SCAccountWS.queryUsersRequestBody();
            return ((SCAccountWS.AccountServiceSoap)(this)).queryUsersAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SCAccountWS.modifyUserInfoResponse> SCAccountWS.AccountServiceSoap.modifyUserInfoAsync(SCAccountWS.modifyUserInfoRequest request)
        {
            return base.Channel.modifyUserInfoAsync(request);
        }
        
        public System.Threading.Tasks.Task<SCAccountWS.modifyUserInfoResponse> modifyUserInfoAsync(string userInfos)
        {
            SCAccountWS.modifyUserInfoRequest inValue = new SCAccountWS.modifyUserInfoRequest();
            inValue.Body = new SCAccountWS.modifyUserInfoRequestBody();
            inValue.Body.userInfos = userInfos;
            return ((SCAccountWS.AccountServiceSoap)(this)).modifyUserInfoAsync(inValue);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.AccountServiceSoap))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            if ((endpointConfiguration == EndpointConfiguration.AccountServiceSoap12))
            {
                System.ServiceModel.Channels.CustomBinding result = new System.ServiceModel.Channels.CustomBinding();
                System.ServiceModel.Channels.TextMessageEncodingBindingElement textBindingElement = new System.ServiceModel.Channels.TextMessageEncodingBindingElement();
                textBindingElement.MessageVersion = System.ServiceModel.Channels.MessageVersion.CreateVersion(System.ServiceModel.EnvelopeVersion.Soap12, System.ServiceModel.Channels.AddressingVersion.None);
                result.Elements.Add(textBindingElement);
                System.ServiceModel.Channels.HttpTransportBindingElement httpBindingElement = new System.ServiceModel.Channels.HttpTransportBindingElement();
                httpBindingElement.AllowCookies = true;
                httpBindingElement.MaxBufferSize = int.MaxValue;
                httpBindingElement.MaxReceivedMessageSize = int.MaxValue;
                result.Elements.Add(httpBindingElement);
                return result;
            }
            throw new System.InvalidOperationException(string.Format("找不到名称为“{0}”的终结点。", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.AccountServiceSoap))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:31692/WebService/AccountService.asmx");
            }
            if ((endpointConfiguration == EndpointConfiguration.AccountServiceSoap12))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:31692/WebService/AccountService.asmx");
            }
            throw new System.InvalidOperationException(string.Format("找不到名称为“{0}”的终结点。", endpointConfiguration));
        }
        
        public enum EndpointConfiguration
        {
            
            AccountServiceSoap,
            
            AccountServiceSoap12,
        }
    }
}
