﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     //
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HuBeiWS
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="HuBeiWS.ReplaySheetWorkSoap")]
    public interface ReplaySheetWorkSoap
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<HuBeiWS.HelloWorldResponse> HelloWorldAsync(HuBeiWS.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/NewWorkSheet", ReplyAction="*")]
        System.Threading.Tasks.Task<HuBeiWS.NewWorkSheetResponse> NewWorkSheetAsync(HuBeiWS.NewWorkSheetRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Tuoming", ReplyAction="*")]
        System.Threading.Tasks.Task<HuBeiWS.TuomingResponse> TuomingAsync(HuBeiWS.TuomingRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public HuBeiWS.HelloWorldRequestBody Body;
        
        public HelloWorldRequest()
        {
        }
        
        public HelloWorldRequest(HuBeiWS.HelloWorldRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HelloWorldRequestBody
    {
        
        public HelloWorldRequestBody()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://tempuri.org/", Order=0)]
        public HuBeiWS.HelloWorldResponseBody Body;
        
        public HelloWorldResponse()
        {
        }
        
        public HelloWorldResponse(HuBeiWS.HelloWorldResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloWorldResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody()
        {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult)
        {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class NewWorkSheetRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="NewWorkSheet", Namespace="http://tempuri.org/", Order=0)]
        public HuBeiWS.NewWorkSheetRequestBody Body;
        
        public NewWorkSheetRequest()
        {
        }
        
        public NewWorkSheetRequest(HuBeiWS.NewWorkSheetRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class NewWorkSheetRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string serSupplier;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string serCaller;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string callerPwd;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string calltime;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string OpDetail;
        
        public NewWorkSheetRequestBody()
        {
        }
        
        public NewWorkSheetRequestBody(string serSupplier, string serCaller, string callerPwd, string calltime, string OpDetail)
        {
            this.serSupplier = serSupplier;
            this.serCaller = serCaller;
            this.callerPwd = callerPwd;
            this.calltime = calltime;
            this.OpDetail = OpDetail;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class NewWorkSheetResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="NewWorkSheetResponse", Namespace="http://tempuri.org/", Order=0)]
        public HuBeiWS.NewWorkSheetResponseBody Body;
        
        public NewWorkSheetResponse()
        {
        }
        
        public NewWorkSheetResponse(HuBeiWS.NewWorkSheetResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class NewWorkSheetResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string NewWorkSheetResult;
        
        public NewWorkSheetResponseBody()
        {
        }
        
        public NewWorkSheetResponseBody(string NewWorkSheetResult)
        {
            this.NewWorkSheetResult = NewWorkSheetResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class TuomingRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Tuoming", Namespace="http://tempuri.org/", Order=0)]
        public HuBeiWS.TuomingRequestBody Body;
        
        public TuomingRequest()
        {
        }
        
        public TuomingRequest(HuBeiWS.TuomingRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class TuomingRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string InterString;
        
        public TuomingRequestBody()
        {
        }
        
        public TuomingRequestBody(string InterString)
        {
            this.InterString = InterString;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class TuomingResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="TuomingResponse", Namespace="http://tempuri.org/", Order=0)]
        public HuBeiWS.TuomingResponseBody Body;
        
        public TuomingResponse()
        {
        }
        
        public TuomingResponse(HuBeiWS.TuomingResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class TuomingResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string TuomingResult;
        
        public TuomingResponseBody()
        {
        }
        
        public TuomingResponseBody(string TuomingResult)
        {
            this.TuomingResult = TuomingResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    public interface ReplaySheetWorkSoapChannel : HuBeiWS.ReplaySheetWorkSoap, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    public partial class ReplaySheetWorkSoapClient : System.ServiceModel.ClientBase<HuBeiWS.ReplaySheetWorkSoap>, HuBeiWS.ReplaySheetWorkSoap
    {
        
    /// <summary>
    /// Implement this partial method to configure the service endpoint.
    /// </summary>
    /// <param name="serviceEndpoint">The endpoint to configure</param>
    /// <param name="clientCredentials">The client credentials</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public ReplaySheetWorkSoapClient(EndpointConfiguration endpointConfiguration) : 
                base(ReplaySheetWorkSoapClient.GetBindingForEndpoint(endpointConfiguration), ReplaySheetWorkSoapClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ReplaySheetWorkSoapClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(ReplaySheetWorkSoapClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ReplaySheetWorkSoapClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(ReplaySheetWorkSoapClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ReplaySheetWorkSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<HuBeiWS.HelloWorldResponse> HuBeiWS.ReplaySheetWorkSoap.HelloWorldAsync(HuBeiWS.HelloWorldRequest request)
        {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<HuBeiWS.HelloWorldResponse> HelloWorldAsync()
        {
            HuBeiWS.HelloWorldRequest inValue = new HuBeiWS.HelloWorldRequest();
            inValue.Body = new HuBeiWS.HelloWorldRequestBody();
            return ((HuBeiWS.ReplaySheetWorkSoap)(this)).HelloWorldAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<HuBeiWS.NewWorkSheetResponse> HuBeiWS.ReplaySheetWorkSoap.NewWorkSheetAsync(HuBeiWS.NewWorkSheetRequest request)
        {
            return base.Channel.NewWorkSheetAsync(request);
        }
        
        public System.Threading.Tasks.Task<HuBeiWS.NewWorkSheetResponse> NewWorkSheetAsync(string serSupplier, string serCaller, string callerPwd, string calltime, string OpDetail)
        {
            HuBeiWS.NewWorkSheetRequest inValue = new HuBeiWS.NewWorkSheetRequest();
            inValue.Body = new HuBeiWS.NewWorkSheetRequestBody();
            inValue.Body.serSupplier = serSupplier;
            inValue.Body.serCaller = serCaller;
            inValue.Body.callerPwd = callerPwd;
            inValue.Body.calltime = calltime;
            inValue.Body.OpDetail = OpDetail;
            return ((HuBeiWS.ReplaySheetWorkSoap)(this)).NewWorkSheetAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<HuBeiWS.TuomingResponse> HuBeiWS.ReplaySheetWorkSoap.TuomingAsync(HuBeiWS.TuomingRequest request)
        {
            return base.Channel.TuomingAsync(request);
        }
        
        public System.Threading.Tasks.Task<HuBeiWS.TuomingResponse> TuomingAsync(string InterString)
        {
            HuBeiWS.TuomingRequest inValue = new HuBeiWS.TuomingRequest();
            inValue.Body = new HuBeiWS.TuomingRequestBody();
            inValue.Body.InterString = InterString;
            return ((HuBeiWS.ReplaySheetWorkSoap)(this)).TuomingAsync(inValue);
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
            if ((endpointConfiguration == EndpointConfiguration.ReplaySheetWorkSoap))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            if ((endpointConfiguration == EndpointConfiguration.ReplaySheetWorkSoap12))
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
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.ReplaySheetWorkSoap))
            {
                return new System.ServiceModel.EndpointAddress("http://10.30.198.187:1001/Plugins/HuBei.CentralizeAnalysis/WebService/ReplaySheet" +
                        "Work.asmx");
            }
            if ((endpointConfiguration == EndpointConfiguration.ReplaySheetWorkSoap12))
            {
                return new System.ServiceModel.EndpointAddress("http://10.30.198.187:1001/Plugins/HuBei.CentralizeAnalysis/WebService/ReplaySheet" +
                        "Work.asmx");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        public enum EndpointConfiguration
        {
            
            ReplaySheetWorkSoap,
            
            ReplaySheetWorkSoap12,
        }
    }
}
