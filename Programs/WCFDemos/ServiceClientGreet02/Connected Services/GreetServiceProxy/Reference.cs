﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceClientGreet02.GreetServiceProxy {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="GreetServiceProxy.IGreetService")]
    public interface IGreetService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGreetService/Welcome", ReplyAction="http://tempuri.org/IGreetService/WelcomeResponse")]
        string Welcome(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGreetService/Welcome", ReplyAction="http://tempuri.org/IGreetService/WelcomeResponse")]
        System.Threading.Tasks.Task<string> WelcomeAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGreetService/GoodBye", ReplyAction="http://tempuri.org/IGreetService/GoodByeResponse")]
        string GoodBye(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGreetService/GoodBye", ReplyAction="http://tempuri.org/IGreetService/GoodByeResponse")]
        System.Threading.Tasks.Task<string> GoodByeAsync(string name);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IGreetServiceChannel : ServiceClientGreet02.GreetServiceProxy.IGreetService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GreetServiceClient : System.ServiceModel.ClientBase<ServiceClientGreet02.GreetServiceProxy.IGreetService>, ServiceClientGreet02.GreetServiceProxy.IGreetService {
        
        public GreetServiceClient() {
        }
        
        public GreetServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public GreetServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GreetServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GreetServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string Welcome(string name) {
            return base.Channel.Welcome(name);
        }
        
        public System.Threading.Tasks.Task<string> WelcomeAsync(string name) {
            return base.Channel.WelcomeAsync(name);
        }
        
        public string GoodBye(string name) {
            return base.Channel.GoodBye(name);
        }
        
        public System.Threading.Tasks.Task<string> GoodByeAsync(string name) {
            return base.Channel.GoodByeAsync(name);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="GreetServiceProxy.ITimedGreetService")]
    public interface ITimedGreetService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITimedGreetService/TimedGreet", ReplyAction="http://tempuri.org/ITimedGreetService/TimedGreetResponse")]
        string TimedGreet(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITimedGreetService/TimedGreet", ReplyAction="http://tempuri.org/ITimedGreetService/TimedGreetResponse")]
        System.Threading.Tasks.Task<string> TimedGreetAsync(string name);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ITimedGreetServiceChannel : ServiceClientGreet02.GreetServiceProxy.ITimedGreetService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TimedGreetServiceClient : System.ServiceModel.ClientBase<ServiceClientGreet02.GreetServiceProxy.ITimedGreetService>, ServiceClientGreet02.GreetServiceProxy.ITimedGreetService {
        
        public TimedGreetServiceClient() {
        }
        
        public TimedGreetServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TimedGreetServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TimedGreetServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TimedGreetServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string TimedGreet(string name) {
            return base.Channel.TimedGreet(name);
        }
        
        public System.Threading.Tasks.Task<string> TimedGreetAsync(string name) {
            return base.Channel.TimedGreetAsync(name);
        }
    }
}