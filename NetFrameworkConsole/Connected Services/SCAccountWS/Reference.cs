﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace NetFrameworkConsole.SCAccountWS {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SCAccountWS.AccountServiceSoap")]
    public interface AccountServiceSoap {
        
        // CODEGEN: 命名空间 http://tempuri.org/ 的元素名称 userID 以后生成的消息协定未标记为 nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/findUser", ReplyAction="*")]
        NetFrameworkConsole.SCAccountWS.findUserResponse findUser(NetFrameworkConsole.SCAccountWS.findUserRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/findUser", ReplyAction="*")]
        System.Threading.Tasks.Task<NetFrameworkConsole.SCAccountWS.findUserResponse> findUserAsync(NetFrameworkConsole.SCAccountWS.findUserRequest request);
        
        // CODEGEN: 命名空间 http://tempuri.org/ 的元素名称 queryUsersResult 以后生成的消息协定未标记为 nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/queryUsers", ReplyAction="*")]
        NetFrameworkConsole.SCAccountWS.queryUsersResponse queryUsers(NetFrameworkConsole.SCAccountWS.queryUsersRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/queryUsers", ReplyAction="*")]
        System.Threading.Tasks.Task<NetFrameworkConsole.SCAccountWS.queryUsersResponse> queryUsersAsync(NetFrameworkConsole.SCAccountWS.queryUsersRequest request);
        
        // CODEGEN: 命名空间 http://tempuri.org/ 的元素名称 userInfos 以后生成的消息协定未标记为 nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/modifyUserInfo", ReplyAction="*")]
        NetFrameworkConsole.SCAccountWS.modifyUserInfoResponse modifyUserInfo(NetFrameworkConsole.SCAccountWS.modifyUserInfoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/modifyUserInfo", ReplyAction="*")]
        System.Threading.Tasks.Task<NetFrameworkConsole.SCAccountWS.modifyUserInfoResponse> modifyUserInfoAsync(NetFrameworkConsole.SCAccountWS.modifyUserInfoRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class findUserRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="findUser", Namespace="http://tempuri.org/", Order=0)]
        public NetFrameworkConsole.SCAccountWS.findUserRequestBody Body;
        
        public findUserRequest() {
        }
        
        public findUserRequest(NetFrameworkConsole.SCAccountWS.findUserRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class findUserRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string userID;
        
        public findUserRequestBody() {
        }
        
        public findUserRequestBody(string userID) {
            this.userID = userID;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class findUserResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="findUserResponse", Namespace="http://tempuri.org/", Order=0)]
        public NetFrameworkConsole.SCAccountWS.findUserResponseBody Body;
        
        public findUserResponse() {
        }
        
        public findUserResponse(NetFrameworkConsole.SCAccountWS.findUserResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class findUserResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string findUserResult;
        
        public findUserResponseBody() {
        }
        
        public findUserResponseBody(string findUserResult) {
            this.findUserResult = findUserResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class queryUsersRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="queryUsers", Namespace="http://tempuri.org/", Order=0)]
        public NetFrameworkConsole.SCAccountWS.queryUsersRequestBody Body;
        
        public queryUsersRequest() {
        }
        
        public queryUsersRequest(NetFrameworkConsole.SCAccountWS.queryUsersRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class queryUsersRequestBody {
        
        public queryUsersRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class queryUsersResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="queryUsersResponse", Namespace="http://tempuri.org/", Order=0)]
        public NetFrameworkConsole.SCAccountWS.queryUsersResponseBody Body;
        
        public queryUsersResponse() {
        }
        
        public queryUsersResponse(NetFrameworkConsole.SCAccountWS.queryUsersResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class queryUsersResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string queryUsersResult;
        
        public queryUsersResponseBody() {
        }
        
        public queryUsersResponseBody(string queryUsersResult) {
            this.queryUsersResult = queryUsersResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class modifyUserInfoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="modifyUserInfo", Namespace="http://tempuri.org/", Order=0)]
        public NetFrameworkConsole.SCAccountWS.modifyUserInfoRequestBody Body;
        
        public modifyUserInfoRequest() {
        }
        
        public modifyUserInfoRequest(NetFrameworkConsole.SCAccountWS.modifyUserInfoRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class modifyUserInfoRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string userInfos;
        
        public modifyUserInfoRequestBody() {
        }
        
        public modifyUserInfoRequestBody(string userInfos) {
            this.userInfos = userInfos;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class modifyUserInfoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="modifyUserInfoResponse", Namespace="http://tempuri.org/", Order=0)]
        public NetFrameworkConsole.SCAccountWS.modifyUserInfoResponseBody Body;
        
        public modifyUserInfoResponse() {
        }
        
        public modifyUserInfoResponse(NetFrameworkConsole.SCAccountWS.modifyUserInfoResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class modifyUserInfoResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string modifyUserInfoResult;
        
        public modifyUserInfoResponseBody() {
        }
        
        public modifyUserInfoResponseBody(string modifyUserInfoResult) {
            this.modifyUserInfoResult = modifyUserInfoResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface AccountServiceSoapChannel : NetFrameworkConsole.SCAccountWS.AccountServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AccountServiceSoapClient : System.ServiceModel.ClientBase<NetFrameworkConsole.SCAccountWS.AccountServiceSoap>, NetFrameworkConsole.SCAccountWS.AccountServiceSoap {
        
        public AccountServiceSoapClient() {
        }
        
        public AccountServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AccountServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AccountServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AccountServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        NetFrameworkConsole.SCAccountWS.findUserResponse NetFrameworkConsole.SCAccountWS.AccountServiceSoap.findUser(NetFrameworkConsole.SCAccountWS.findUserRequest request) {
            return base.Channel.findUser(request);
        }
        
        public string findUser(string userID) {
            NetFrameworkConsole.SCAccountWS.findUserRequest inValue = new NetFrameworkConsole.SCAccountWS.findUserRequest();
            inValue.Body = new NetFrameworkConsole.SCAccountWS.findUserRequestBody();
            inValue.Body.userID = userID;
            NetFrameworkConsole.SCAccountWS.findUserResponse retVal = ((NetFrameworkConsole.SCAccountWS.AccountServiceSoap)(this)).findUser(inValue);
            return retVal.Body.findUserResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<NetFrameworkConsole.SCAccountWS.findUserResponse> NetFrameworkConsole.SCAccountWS.AccountServiceSoap.findUserAsync(NetFrameworkConsole.SCAccountWS.findUserRequest request) {
            return base.Channel.findUserAsync(request);
        }
        
        public System.Threading.Tasks.Task<NetFrameworkConsole.SCAccountWS.findUserResponse> findUserAsync(string userID) {
            NetFrameworkConsole.SCAccountWS.findUserRequest inValue = new NetFrameworkConsole.SCAccountWS.findUserRequest();
            inValue.Body = new NetFrameworkConsole.SCAccountWS.findUserRequestBody();
            inValue.Body.userID = userID;
            return ((NetFrameworkConsole.SCAccountWS.AccountServiceSoap)(this)).findUserAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        NetFrameworkConsole.SCAccountWS.queryUsersResponse NetFrameworkConsole.SCAccountWS.AccountServiceSoap.queryUsers(NetFrameworkConsole.SCAccountWS.queryUsersRequest request) {
            return base.Channel.queryUsers(request);
        }
        
        public string queryUsers() {
            NetFrameworkConsole.SCAccountWS.queryUsersRequest inValue = new NetFrameworkConsole.SCAccountWS.queryUsersRequest();
            inValue.Body = new NetFrameworkConsole.SCAccountWS.queryUsersRequestBody();
            NetFrameworkConsole.SCAccountWS.queryUsersResponse retVal = ((NetFrameworkConsole.SCAccountWS.AccountServiceSoap)(this)).queryUsers(inValue);
            return retVal.Body.queryUsersResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<NetFrameworkConsole.SCAccountWS.queryUsersResponse> NetFrameworkConsole.SCAccountWS.AccountServiceSoap.queryUsersAsync(NetFrameworkConsole.SCAccountWS.queryUsersRequest request) {
            return base.Channel.queryUsersAsync(request);
        }
        
        public System.Threading.Tasks.Task<NetFrameworkConsole.SCAccountWS.queryUsersResponse> queryUsersAsync() {
            NetFrameworkConsole.SCAccountWS.queryUsersRequest inValue = new NetFrameworkConsole.SCAccountWS.queryUsersRequest();
            inValue.Body = new NetFrameworkConsole.SCAccountWS.queryUsersRequestBody();
            return ((NetFrameworkConsole.SCAccountWS.AccountServiceSoap)(this)).queryUsersAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        NetFrameworkConsole.SCAccountWS.modifyUserInfoResponse NetFrameworkConsole.SCAccountWS.AccountServiceSoap.modifyUserInfo(NetFrameworkConsole.SCAccountWS.modifyUserInfoRequest request) {
            return base.Channel.modifyUserInfo(request);
        }
        
        public string modifyUserInfo(string userInfos) {
            NetFrameworkConsole.SCAccountWS.modifyUserInfoRequest inValue = new NetFrameworkConsole.SCAccountWS.modifyUserInfoRequest();
            inValue.Body = new NetFrameworkConsole.SCAccountWS.modifyUserInfoRequestBody();
            inValue.Body.userInfos = userInfos;
            NetFrameworkConsole.SCAccountWS.modifyUserInfoResponse retVal = ((NetFrameworkConsole.SCAccountWS.AccountServiceSoap)(this)).modifyUserInfo(inValue);
            return retVal.Body.modifyUserInfoResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<NetFrameworkConsole.SCAccountWS.modifyUserInfoResponse> NetFrameworkConsole.SCAccountWS.AccountServiceSoap.modifyUserInfoAsync(NetFrameworkConsole.SCAccountWS.modifyUserInfoRequest request) {
            return base.Channel.modifyUserInfoAsync(request);
        }
        
        public System.Threading.Tasks.Task<NetFrameworkConsole.SCAccountWS.modifyUserInfoResponse> modifyUserInfoAsync(string userInfos) {
            NetFrameworkConsole.SCAccountWS.modifyUserInfoRequest inValue = new NetFrameworkConsole.SCAccountWS.modifyUserInfoRequest();
            inValue.Body = new NetFrameworkConsole.SCAccountWS.modifyUserInfoRequestBody();
            inValue.Body.userInfos = userInfos;
            return ((NetFrameworkConsole.SCAccountWS.AccountServiceSoap)(this)).modifyUserInfoAsync(inValue);
        }
    }
}