﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceReference1
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Connect", ReplyAction="http://tempuri.org/IService1/ConnectResponse")]
        System.Threading.Tasks.Task ConnectAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Diconnect", ReplyAction="http://tempuri.org/IService1/DiconnectResponse")]
        System.Threading.Tasks.Task DiconnectAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SearchFile", ReplyAction="http://tempuri.org/IService1/SearchFileResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<string>> SearchFileAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SearchFolder", ReplyAction="http://tempuri.org/IService1/SearchFolderResponse")]
        System.Threading.Tasks.Task<string> SearchFolderAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/MovePhoto", ReplyAction="http://tempuri.org/IService1/MovePhotoResponse")]
        System.Threading.Tasks.Task MovePhotoAsync(string source, string destination);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Insert", ReplyAction="http://tempuri.org/IService1/InsertResponse")]
        System.Threading.Tasks.Task InsertAsync(System.Collections.Generic.List<string> dbInfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InsertFolder", ReplyAction="http://tempuri.org/IService1/InsertFolderResponse")]
        System.Threading.Tasks.Task<int> InsertFolderAsync(string dbInfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InsertPhoto", ReplyAction="http://tempuri.org/IService1/InsertPhotoResponse")]
        System.Threading.Tasks.Task<int> InsertPhotoAsync(System.Collections.Generic.List<string> dbInfo);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public interface IService1Channel : ServiceReference1.IService1, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public partial class Service1Client : System.ServiceModel.ClientBase<ServiceReference1.IService1>, ServiceReference1.IService1
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public Service1Client() : 
                base(Service1Client.GetDefaultBinding(), Service1Client.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IService1.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public Service1Client(EndpointConfiguration endpointConfiguration) : 
                base(Service1Client.GetBindingForEndpoint(endpointConfiguration), Service1Client.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public Service1Client(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(Service1Client.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public Service1Client(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(Service1Client.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task ConnectAsync()
        {
            return base.Channel.ConnectAsync();
        }
        
        public System.Threading.Tasks.Task DiconnectAsync()
        {
            return base.Channel.DiconnectAsync();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<string>> SearchFileAsync()
        {
            return base.Channel.SearchFileAsync();
        }
        
        public System.Threading.Tasks.Task<string> SearchFolderAsync()
        {
            return base.Channel.SearchFolderAsync();
        }
        
        public System.Threading.Tasks.Task MovePhotoAsync(string source, string destination)
        {
            return base.Channel.MovePhotoAsync(source, destination);
        }
        
        public System.Threading.Tasks.Task InsertAsync(System.Collections.Generic.List<string> dbInfo)
        {
            return base.Channel.InsertAsync(dbInfo);
        }
        
        public System.Threading.Tasks.Task<int> InsertFolderAsync(string dbInfo)
        {
            return base.Channel.InsertFolderAsync(dbInfo);
        }
        
        public System.Threading.Tasks.Task<int> InsertPhotoAsync(System.Collections.Generic.List<string> dbInfo)
        {
            return base.Channel.InsertPhotoAsync(dbInfo);
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
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IService1))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IService1))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:8733/Design_Time_Addresses/wcfService/Service1/");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return Service1Client.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IService1);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return Service1Client.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IService1);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IService1,
        }
    }
}