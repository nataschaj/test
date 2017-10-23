﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TCPClient.CalculatorReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CalculatorReference.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InsertData", ReplyAction="http://tempuri.org/IService1/InsertDataResponse")]
        int InsertData(double volume, double side);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InsertData", ReplyAction="http://tempuri.org/IService1/InsertDataResponse")]
        System.Threading.Tasks.Task<int> InsertDataAsync(double volume, double side);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetVolume", ReplyAction="http://tempuri.org/IService1/GetVolumeResponse")]
        double GetVolume(double length, double width, double height);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetVolume", ReplyAction="http://tempuri.org/IService1/GetVolumeResponse")]
        System.Threading.Tasks.Task<double> GetVolumeAsync(double length, double width, double height);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetSide", ReplyAction="http://tempuri.org/IService1/GetSideResponse")]
        double GetSide(double volume, double side1, double side2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetSide", ReplyAction="http://tempuri.org/IService1/GetSideResponse")]
        System.Threading.Tasks.Task<double> GetSideAsync(double volume, double side1, double side2);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : TCPClient.CalculatorReference.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<TCPClient.CalculatorReference.IService1>, TCPClient.CalculatorReference.IService1 {
        
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
        
        public int InsertData(double volume, double side) {
            return base.Channel.InsertData(volume, side);
        }
        
        public System.Threading.Tasks.Task<int> InsertDataAsync(double volume, double side) {
            return base.Channel.InsertDataAsync(volume, side);
        }
        
        public double GetVolume(double length, double width, double height) {
            return base.Channel.GetVolume(length, width, height);
        }
        
        public System.Threading.Tasks.Task<double> GetVolumeAsync(double length, double width, double height) {
            return base.Channel.GetVolumeAsync(length, width, height);
        }
        
        public double GetSide(double volume, double side1, double side2) {
            return base.Channel.GetSide(volume, side1, side2);
        }
        
        public System.Threading.Tasks.Task<double> GetSideAsync(double volume, double side1, double side2) {
            return base.Channel.GetSideAsync(volume, side1, side2);
        }
    }
}
