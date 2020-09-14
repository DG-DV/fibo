﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FibonacciWindowsFormsApp.FibonacciServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ArrayOfInt", Namespace="http://tempuri.org/", ItemName="int")]
    [System.SerializableAttribute()]
    public class ArrayOfInt : System.Collections.Generic.List<int> {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="FibonacciServiceReference.FiboWebServiceSoap")]
    public interface FiboWebServiceSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/fibonacci2switch", ReplyAction="*")]
        int fibonacci2switch(int n);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/fibonacci2switch", ReplyAction="*")]
        System.Threading.Tasks.Task<int> fibonacci2switchAsync(int n);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Fibonnacci1", ReplyAction="*")]
        int Fibonnacci1(int n);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Fibonnacci1", ReplyAction="*")]
        System.Threading.Tasks.Task<int> Fibonnacci1Async(int n);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/fibonacci2", ReplyAction="*")]
        int fibonacci2(int n);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/fibonacci2", ReplyAction="*")]
        System.Threading.Tasks.Task<int> fibonacci2Async(int n);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Fibonnacci3", ReplyAction="*")]
        int Fibonnacci3(int n);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Fibonnacci3", ReplyAction="*")]
        System.Threading.Tasks.Task<int> Fibonnacci3Async(int n);
        
        // CODEGEN : La génération du contrat de message depuis le nom d'élément GetFiboResult de l'espace de noms http://tempuri.org/ n'est pas marqué nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetFibo", ReplyAction="*")]
        FibonacciWindowsFormsApp.FibonacciServiceReference.GetFiboResponse GetFibo(FibonacciWindowsFormsApp.FibonacciServiceReference.GetFiboRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetFibo", ReplyAction="*")]
        System.Threading.Tasks.Task<FibonacciWindowsFormsApp.FibonacciServiceReference.GetFiboResponse> GetFiboAsync(FibonacciWindowsFormsApp.FibonacciServiceReference.GetFiboRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Fibonacci", ReplyAction="*")]
        int Fibonacci(int n);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Fibonacci", ReplyAction="*")]
        System.Threading.Tasks.Task<int> FibonacciAsync(int n);
        
        // CODEGEN : La génération du contrat de message depuis le nom d'élément xml de l'espace de noms http://tempuri.org/ n'est pas marqué nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/XmlToJson", ReplyAction="*")]
        FibonacciWindowsFormsApp.FibonacciServiceReference.XmlToJsonResponse XmlToJson(FibonacciWindowsFormsApp.FibonacciServiceReference.XmlToJsonRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/XmlToJson", ReplyAction="*")]
        System.Threading.Tasks.Task<FibonacciWindowsFormsApp.FibonacciServiceReference.XmlToJsonResponse> XmlToJsonAsync(FibonacciWindowsFormsApp.FibonacciServiceReference.XmlToJsonRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetFiboRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetFibo", Namespace="http://tempuri.org/", Order=0)]
        public FibonacciWindowsFormsApp.FibonacciServiceReference.GetFiboRequestBody Body;
        
        public GetFiboRequest() {
        }
        
        public GetFiboRequest(FibonacciWindowsFormsApp.FibonacciServiceReference.GetFiboRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetFiboRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int n;
        
        public GetFiboRequestBody() {
        }
        
        public GetFiboRequestBody(int n) {
            this.n = n;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetFiboResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetFiboResponse", Namespace="http://tempuri.org/", Order=0)]
        public FibonacciWindowsFormsApp.FibonacciServiceReference.GetFiboResponseBody Body;
        
        public GetFiboResponse() {
        }
        
        public GetFiboResponse(FibonacciWindowsFormsApp.FibonacciServiceReference.GetFiboResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetFiboResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public FibonacciWindowsFormsApp.FibonacciServiceReference.ArrayOfInt GetFiboResult;
        
        public GetFiboResponseBody() {
        }
        
        public GetFiboResponseBody(FibonacciWindowsFormsApp.FibonacciServiceReference.ArrayOfInt GetFiboResult) {
            this.GetFiboResult = GetFiboResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class XmlToJsonRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="XmlToJson", Namespace="http://tempuri.org/", Order=0)]
        public FibonacciWindowsFormsApp.FibonacciServiceReference.XmlToJsonRequestBody Body;
        
        public XmlToJsonRequest() {
        }
        
        public XmlToJsonRequest(FibonacciWindowsFormsApp.FibonacciServiceReference.XmlToJsonRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class XmlToJsonRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string xml;
        
        public XmlToJsonRequestBody() {
        }
        
        public XmlToJsonRequestBody(string xml) {
            this.xml = xml;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class XmlToJsonResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="XmlToJsonResponse", Namespace="http://tempuri.org/", Order=0)]
        public FibonacciWindowsFormsApp.FibonacciServiceReference.XmlToJsonResponseBody Body;
        
        public XmlToJsonResponse() {
        }
        
        public XmlToJsonResponse(FibonacciWindowsFormsApp.FibonacciServiceReference.XmlToJsonResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class XmlToJsonResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string XmlToJsonResult;
        
        public XmlToJsonResponseBody() {
        }
        
        public XmlToJsonResponseBody(string XmlToJsonResult) {
            this.XmlToJsonResult = XmlToJsonResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface FiboWebServiceSoapChannel : FibonacciWindowsFormsApp.FibonacciServiceReference.FiboWebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class FiboWebServiceSoapClient : System.ServiceModel.ClientBase<FibonacciWindowsFormsApp.FibonacciServiceReference.FiboWebServiceSoap>, FibonacciWindowsFormsApp.FibonacciServiceReference.FiboWebServiceSoap {
        
        public FiboWebServiceSoapClient() {
        }
        
        public FiboWebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public FiboWebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FiboWebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FiboWebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int fibonacci2switch(int n) {
            return base.Channel.fibonacci2switch(n);
        }
        
        public System.Threading.Tasks.Task<int> fibonacci2switchAsync(int n) {
            return base.Channel.fibonacci2switchAsync(n);
        }
        
        public int Fibonnacci1(int n) {
            return base.Channel.Fibonnacci1(n);
        }
        
        public System.Threading.Tasks.Task<int> Fibonnacci1Async(int n) {
            return base.Channel.Fibonnacci1Async(n);
        }
        
        public int fibonacci2(int n) {
            return base.Channel.fibonacci2(n);
        }
        
        public System.Threading.Tasks.Task<int> fibonacci2Async(int n) {
            return base.Channel.fibonacci2Async(n);
        }
        
        public int Fibonnacci3(int n) {
            return base.Channel.Fibonnacci3(n);
        }
        
        public System.Threading.Tasks.Task<int> Fibonnacci3Async(int n) {
            return base.Channel.Fibonnacci3Async(n);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        FibonacciWindowsFormsApp.FibonacciServiceReference.GetFiboResponse FibonacciWindowsFormsApp.FibonacciServiceReference.FiboWebServiceSoap.GetFibo(FibonacciWindowsFormsApp.FibonacciServiceReference.GetFiboRequest request) {
            return base.Channel.GetFibo(request);
        }
        
        public FibonacciWindowsFormsApp.FibonacciServiceReference.ArrayOfInt GetFibo(int n) {
            FibonacciWindowsFormsApp.FibonacciServiceReference.GetFiboRequest inValue = new FibonacciWindowsFormsApp.FibonacciServiceReference.GetFiboRequest();
            inValue.Body = new FibonacciWindowsFormsApp.FibonacciServiceReference.GetFiboRequestBody();
            inValue.Body.n = n;
            FibonacciWindowsFormsApp.FibonacciServiceReference.GetFiboResponse retVal = ((FibonacciWindowsFormsApp.FibonacciServiceReference.FiboWebServiceSoap)(this)).GetFibo(inValue);
            return retVal.Body.GetFiboResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<FibonacciWindowsFormsApp.FibonacciServiceReference.GetFiboResponse> FibonacciWindowsFormsApp.FibonacciServiceReference.FiboWebServiceSoap.GetFiboAsync(FibonacciWindowsFormsApp.FibonacciServiceReference.GetFiboRequest request) {
            return base.Channel.GetFiboAsync(request);
        }
        
        public System.Threading.Tasks.Task<FibonacciWindowsFormsApp.FibonacciServiceReference.GetFiboResponse> GetFiboAsync(int n) {
            FibonacciWindowsFormsApp.FibonacciServiceReference.GetFiboRequest inValue = new FibonacciWindowsFormsApp.FibonacciServiceReference.GetFiboRequest();
            inValue.Body = new FibonacciWindowsFormsApp.FibonacciServiceReference.GetFiboRequestBody();
            inValue.Body.n = n;
            return ((FibonacciWindowsFormsApp.FibonacciServiceReference.FiboWebServiceSoap)(this)).GetFiboAsync(inValue);
        }
        
        public int Fibonacci(int n) {
            return base.Channel.Fibonacci(n);
        }
        
        public System.Threading.Tasks.Task<int> FibonacciAsync(int n) {
            return base.Channel.FibonacciAsync(n);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        FibonacciWindowsFormsApp.FibonacciServiceReference.XmlToJsonResponse FibonacciWindowsFormsApp.FibonacciServiceReference.FiboWebServiceSoap.XmlToJson(FibonacciWindowsFormsApp.FibonacciServiceReference.XmlToJsonRequest request) {
            return base.Channel.XmlToJson(request);
        }
        
        public string XmlToJson(string xml) {
            FibonacciWindowsFormsApp.FibonacciServiceReference.XmlToJsonRequest inValue = new FibonacciWindowsFormsApp.FibonacciServiceReference.XmlToJsonRequest();
            inValue.Body = new FibonacciWindowsFormsApp.FibonacciServiceReference.XmlToJsonRequestBody();
            inValue.Body.xml = xml;
            FibonacciWindowsFormsApp.FibonacciServiceReference.XmlToJsonResponse retVal = ((FibonacciWindowsFormsApp.FibonacciServiceReference.FiboWebServiceSoap)(this)).XmlToJson(inValue);
            return retVal.Body.XmlToJsonResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<FibonacciWindowsFormsApp.FibonacciServiceReference.XmlToJsonResponse> FibonacciWindowsFormsApp.FibonacciServiceReference.FiboWebServiceSoap.XmlToJsonAsync(FibonacciWindowsFormsApp.FibonacciServiceReference.XmlToJsonRequest request) {
            return base.Channel.XmlToJsonAsync(request);
        }
        
        public System.Threading.Tasks.Task<FibonacciWindowsFormsApp.FibonacciServiceReference.XmlToJsonResponse> XmlToJsonAsync(string xml) {
            FibonacciWindowsFormsApp.FibonacciServiceReference.XmlToJsonRequest inValue = new FibonacciWindowsFormsApp.FibonacciServiceReference.XmlToJsonRequest();
            inValue.Body = new FibonacciWindowsFormsApp.FibonacciServiceReference.XmlToJsonRequestBody();
            inValue.Body.xml = xml;
            return ((FibonacciWindowsFormsApp.FibonacciServiceReference.FiboWebServiceSoap)(this)).XmlToJsonAsync(inValue);
        }
    }
}