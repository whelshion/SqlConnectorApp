﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace NetFrameworkConsole.GX4AService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="GX4AService.GX4AServiceSoap")]
    public interface GX4AServiceSoap {
        
        // CODEGEN: 命名空间 http://tempuri.org/ 的元素名称 RequestInfo 以后生成的消息协定未标记为 nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UpdateAppAcctSoap", ReplyAction="*")]
        NetFrameworkConsole.GX4AService.UpdateAppAcctSoapResponse UpdateAppAcctSoap(NetFrameworkConsole.GX4AService.UpdateAppAcctSoapRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UpdateAppAcctSoap", ReplyAction="*")]
        System.Threading.Tasks.Task<NetFrameworkConsole.GX4AService.UpdateAppAcctSoapResponse> UpdateAppAcctSoapAsync(NetFrameworkConsole.GX4AService.UpdateAppAcctSoapRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UpdateAppAcctSoapRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="UpdateAppAcctSoap", Namespace="http://tempuri.org/", Order=0)]
        public NetFrameworkConsole.GX4AService.UpdateAppAcctSoapRequestBody Body;
        
        public UpdateAppAcctSoapRequest() {
        }
        
        public UpdateAppAcctSoapRequest(NetFrameworkConsole.GX4AService.UpdateAppAcctSoapRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class UpdateAppAcctSoapRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string RequestInfo;
        
        public UpdateAppAcctSoapRequestBody() {
        }
        
        public UpdateAppAcctSoapRequestBody(string RequestInfo) {
            this.RequestInfo = RequestInfo;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UpdateAppAcctSoapResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="UpdateAppAcctSoapResponse", Namespace="http://tempuri.org/", Order=0)]
        public NetFrameworkConsole.GX4AService.UpdateAppAcctSoapResponseBody Body;
        
        public UpdateAppAcctSoapResponse() {
        }
        
        public UpdateAppAcctSoapResponse(NetFrameworkConsole.GX4AService.UpdateAppAcctSoapResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class UpdateAppAcctSoapResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string UpdateAppAcctSoapResult;
        
        public UpdateAppAcctSoapResponseBody() {
        }
        
        public UpdateAppAcctSoapResponseBody(string UpdateAppAcctSoapResult) {
            this.UpdateAppAcctSoapResult = UpdateAppAcctSoapResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface GX4AServiceSoapChannel : NetFrameworkConsole.GX4AService.GX4AServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GX4AServiceSoapClient : System.ServiceModel.ClientBase<NetFrameworkConsole.GX4AService.GX4AServiceSoap>, NetFrameworkConsole.GX4AService.GX4AServiceSoap {
        
        public GX4AServiceSoapClient() {
        }
        
        public GX4AServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public GX4AServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GX4AServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GX4AServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        NetFrameworkConsole.GX4AService.UpdateAppAcctSoapResponse NetFrameworkConsole.GX4AService.GX4AServiceSoap.UpdateAppAcctSoap(NetFrameworkConsole.GX4AService.UpdateAppAcctSoapRequest request) {
            return base.Channel.UpdateAppAcctSoap(request);
        }
        
        public string UpdateAppAcctSoap(string RequestInfo) {
            NetFrameworkConsole.GX4AService.UpdateAppAcctSoapRequest inValue = new NetFrameworkConsole.GX4AService.UpdateAppAcctSoapRequest();
            inValue.Body = new NetFrameworkConsole.GX4AService.UpdateAppAcctSoapRequestBody();
            inValue.Body.RequestInfo = RequestInfo;
            NetFrameworkConsole.GX4AService.UpdateAppAcctSoapResponse retVal = ((NetFrameworkConsole.GX4AService.GX4AServiceSoap)(this)).UpdateAppAcctSoap(inValue);
            return retVal.Body.UpdateAppAcctSoapResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<NetFrameworkConsole.GX4AService.UpdateAppAcctSoapResponse> NetFrameworkConsole.GX4AService.GX4AServiceSoap.UpdateAppAcctSoapAsync(NetFrameworkConsole.GX4AService.UpdateAppAcctSoapRequest request) {
            return base.Channel.UpdateAppAcctSoapAsync(request);
        }
        
        public System.Threading.Tasks.Task<NetFrameworkConsole.GX4AService.UpdateAppAcctSoapResponse> UpdateAppAcctSoapAsync(string RequestInfo) {
            NetFrameworkConsole.GX4AService.UpdateAppAcctSoapRequest inValue = new NetFrameworkConsole.GX4AService.UpdateAppAcctSoapRequest();
            inValue.Body = new NetFrameworkConsole.GX4AService.UpdateAppAcctSoapRequestBody();
            inValue.Body.RequestInfo = RequestInfo;
            return ((NetFrameworkConsole.GX4AService.GX4AServiceSoap)(this)).UpdateAppAcctSoapAsync(inValue);
        }
    }
}
