﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FirstWebWithWCF.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/add", ReplyAction="http://tempuri.org/IService1/addResponse")]
        double add(double num1, double num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/add", ReplyAction="http://tempuri.org/IService1/addResponse")]
        System.Threading.Tasks.Task<double> addAsync(double num1, double num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Sub", ReplyAction="http://tempuri.org/IService1/SubResponse")]
        double Sub(double num1, double num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Sub", ReplyAction="http://tempuri.org/IService1/SubResponse")]
        System.Threading.Tasks.Task<double> SubAsync(double num1, double num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Multiple", ReplyAction="http://tempuri.org/IService1/MultipleResponse")]
        double Multiple(double num1, double num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Multiple", ReplyAction="http://tempuri.org/IService1/MultipleResponse")]
        System.Threading.Tasks.Task<double> MultipleAsync(double num1, double num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Divide", ReplyAction="http://tempuri.org/IService1/DivideResponse")]
        double Divide(double num1, double num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Divide", ReplyAction="http://tempuri.org/IService1/DivideResponse")]
        System.Threading.Tasks.Task<double> DivideAsync(double num1, double num2);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : FirstWebWithWCF.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<FirstWebWithWCF.ServiceReference1.IService1>, FirstWebWithWCF.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public double add(double num1, double num2) {
            return base.Channel.add(num1, num2);
        }
        
        public System.Threading.Tasks.Task<double> addAsync(double num1, double num2) {
            return base.Channel.addAsync(num1, num2);
        }
        
        public double Sub(double num1, double num2) {
            return base.Channel.Sub(num1, num2);
        }
        
        public System.Threading.Tasks.Task<double> SubAsync(double num1, double num2) {
            return base.Channel.SubAsync(num1, num2);
        }
        
        public double Multiple(double num1, double num2) {
            return base.Channel.Multiple(num1, num2);
        }
        
        public System.Threading.Tasks.Task<double> MultipleAsync(double num1, double num2) {
            return base.Channel.MultipleAsync(num1, num2);
        }
        
        public double Divide(double num1, double num2) {
            return base.Channel.Divide(num1, num2);
        }
        
        public System.Threading.Tasks.Task<double> DivideAsync(double num1, double num2) {
            return base.Channel.DivideAsync(num1, num2);
        }
    }
}
