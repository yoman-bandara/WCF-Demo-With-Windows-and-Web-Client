﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OriginxWindowsClient.WorldWideBranchService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="WorldWideBranchClass", Namespace="http://schemas.datacontract.org/2004/07/OrginxDataService")]
    [System.SerializableAttribute()]
    public partial class WorldWideBranchClass : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string OfficeadminField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string OfficecountryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string OfficedescField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string OfficenameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Officeadmin {
            get {
                return this.OfficeadminField;
            }
            set {
                if ((object.ReferenceEquals(this.OfficeadminField, value) != true)) {
                    this.OfficeadminField = value;
                    this.RaisePropertyChanged("Officeadmin");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Officecountry {
            get {
                return this.OfficecountryField;
            }
            set {
                if ((object.ReferenceEquals(this.OfficecountryField, value) != true)) {
                    this.OfficecountryField = value;
                    this.RaisePropertyChanged("Officecountry");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Officedesc {
            get {
                return this.OfficedescField;
            }
            set {
                if ((object.ReferenceEquals(this.OfficedescField, value) != true)) {
                    this.OfficedescField = value;
                    this.RaisePropertyChanged("Officedesc");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Officename {
            get {
                return this.OfficenameField;
            }
            set {
                if ((object.ReferenceEquals(this.OfficenameField, value) != true)) {
                    this.OfficenameField = value;
                    this.RaisePropertyChanged("Officename");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EmployeeClass", Namespace="http://schemas.datacontract.org/2004/07/OrginxDataService")]
    [System.SerializableAttribute()]
    public partial class EmployeeClass : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Emp_IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int User_levelField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UsernameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Emp_ID {
            get {
                return this.Emp_IDField;
            }
            set {
                if ((this.Emp_IDField.Equals(value) != true)) {
                    this.Emp_IDField = value;
                    this.RaisePropertyChanged("Emp_ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int User_level {
            get {
                return this.User_levelField;
            }
            set {
                if ((this.User_levelField.Equals(value) != true)) {
                    this.User_levelField = value;
                    this.RaisePropertyChanged("User_level");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Username {
            get {
                return this.UsernameField;
            }
            set {
                if ((object.ReferenceEquals(this.UsernameField, value) != true)) {
                    this.UsernameField = value;
                    this.RaisePropertyChanged("Username");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CustomerClass", Namespace="http://schemas.datacontract.org/2004/07/OrginxDataService")]
    [System.SerializableAttribute()]
    public partial class CustomerClass : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AdditionalinfoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ClientlogoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Phoneno1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Phoneno2Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TypeField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Additionalinfo {
            get {
                return this.AdditionalinfoField;
            }
            set {
                if ((object.ReferenceEquals(this.AdditionalinfoField, value) != true)) {
                    this.AdditionalinfoField = value;
                    this.RaisePropertyChanged("Additionalinfo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Address {
            get {
                return this.AddressField;
            }
            set {
                if ((object.ReferenceEquals(this.AddressField, value) != true)) {
                    this.AddressField = value;
                    this.RaisePropertyChanged("Address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Clientlogo {
            get {
                return this.ClientlogoField;
            }
            set {
                if ((object.ReferenceEquals(this.ClientlogoField, value) != true)) {
                    this.ClientlogoField = value;
                    this.RaisePropertyChanged("Clientlogo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Phoneno1 {
            get {
                return this.Phoneno1Field;
            }
            set {
                if ((this.Phoneno1Field.Equals(value) != true)) {
                    this.Phoneno1Field = value;
                    this.RaisePropertyChanged("Phoneno1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Phoneno2 {
            get {
                return this.Phoneno2Field;
            }
            set {
                if ((this.Phoneno2Field.Equals(value) != true)) {
                    this.Phoneno2Field = value;
                    this.RaisePropertyChanged("Phoneno2");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Type {
            get {
                return this.TypeField;
            }
            set {
                if ((object.ReferenceEquals(this.TypeField, value) != true)) {
                    this.TypeField = value;
                    this.RaisePropertyChanged("Type");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WorldWideBranchService.IOriginxDataService")]
    public interface IOriginxDataService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOriginxDataService/getMessage", ReplyAction="http://tempuri.org/IOriginxDataService/getMessageResponse")]
        string getMessage(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOriginxDataService/getMessage", ReplyAction="http://tempuri.org/IOriginxDataService/getMessageResponse")]
        System.Threading.Tasks.Task<string> getMessageAsync(string name);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IOriginxDataServiceChannel : OriginxWindowsClient.WorldWideBranchService.IOriginxDataService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class OriginxDataServiceClient : System.ServiceModel.ClientBase<OriginxWindowsClient.WorldWideBranchService.IOriginxDataService>, OriginxWindowsClient.WorldWideBranchService.IOriginxDataService {
        
        public OriginxDataServiceClient() {
        }
        
        public OriginxDataServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public OriginxDataServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public OriginxDataServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public OriginxDataServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string getMessage(string name) {
            return base.Channel.getMessage(name);
        }
        
        public System.Threading.Tasks.Task<string> getMessageAsync(string name) {
            return base.Channel.getMessageAsync(name);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WorldWideBranchService.IWorlWideBranchService")]
    public interface IWorlWideBranchService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWorlWideBranchService/AddWorldWideBranch", ReplyAction="http://tempuri.org/IWorlWideBranchService/AddWorldWideBranchResponse")]
        void AddWorldWideBranch(OriginxWindowsClient.WorldWideBranchService.WorldWideBranchClass WorldWideBranch);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWorlWideBranchService/AddWorldWideBranch", ReplyAction="http://tempuri.org/IWorlWideBranchService/AddWorldWideBranchResponse")]
        System.Threading.Tasks.Task AddWorldWideBranchAsync(OriginxWindowsClient.WorldWideBranchService.WorldWideBranchClass WorldWideBranch);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWorlWideBranchServiceChannel : OriginxWindowsClient.WorldWideBranchService.IWorlWideBranchService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WorlWideBranchServiceClient : System.ServiceModel.ClientBase<OriginxWindowsClient.WorldWideBranchService.IWorlWideBranchService>, OriginxWindowsClient.WorldWideBranchService.IWorlWideBranchService {
        
        public WorlWideBranchServiceClient() {
        }
        
        public WorlWideBranchServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WorlWideBranchServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WorlWideBranchServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WorlWideBranchServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void AddWorldWideBranch(OriginxWindowsClient.WorldWideBranchService.WorldWideBranchClass WorldWideBranch) {
            base.Channel.AddWorldWideBranch(WorldWideBranch);
        }
        
        public System.Threading.Tasks.Task AddWorldWideBranchAsync(OriginxWindowsClient.WorldWideBranchService.WorldWideBranchClass WorldWideBranch) {
            return base.Channel.AddWorldWideBranchAsync(WorldWideBranch);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WorldWideBranchService.IEmployeeService")]
    public interface IEmployeeService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/addEmployee", ReplyAction="http://tempuri.org/IEmployeeService/addEmployeeResponse")]
        void addEmployee(OriginxWindowsClient.WorldWideBranchService.EmployeeClass emp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/addEmployee", ReplyAction="http://tempuri.org/IEmployeeService/addEmployeeResponse")]
        System.Threading.Tasks.Task addEmployeeAsync(OriginxWindowsClient.WorldWideBranchService.EmployeeClass emp);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEmployeeServiceChannel : OriginxWindowsClient.WorldWideBranchService.IEmployeeService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EmployeeServiceClient : System.ServiceModel.ClientBase<OriginxWindowsClient.WorldWideBranchService.IEmployeeService>, OriginxWindowsClient.WorldWideBranchService.IEmployeeService {
        
        public EmployeeServiceClient() {
        }
        
        public EmployeeServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EmployeeServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmployeeServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmployeeServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void addEmployee(OriginxWindowsClient.WorldWideBranchService.EmployeeClass emp) {
            base.Channel.addEmployee(emp);
        }
        
        public System.Threading.Tasks.Task addEmployeeAsync(OriginxWindowsClient.WorldWideBranchService.EmployeeClass emp) {
            return base.Channel.addEmployeeAsync(emp);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WorldWideBranchService.ICustomerService")]
    public interface ICustomerService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerService/AddCustomer", ReplyAction="http://tempuri.org/ICustomerService/AddCustomerResponse")]
        void AddCustomer(OriginxWindowsClient.WorldWideBranchService.CustomerClass Customer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerService/AddCustomer", ReplyAction="http://tempuri.org/ICustomerService/AddCustomerResponse")]
        System.Threading.Tasks.Task AddCustomerAsync(OriginxWindowsClient.WorldWideBranchService.CustomerClass Customer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerService/DeleteCustomer", ReplyAction="http://tempuri.org/ICustomerService/DeleteCustomerResponse")]
        void DeleteCustomer(OriginxWindowsClient.WorldWideBranchService.CustomerClass Customer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerService/DeleteCustomer", ReplyAction="http://tempuri.org/ICustomerService/DeleteCustomerResponse")]
        System.Threading.Tasks.Task DeleteCustomerAsync(OriginxWindowsClient.WorldWideBranchService.CustomerClass Customer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerService/UpdateCustomer", ReplyAction="http://tempuri.org/ICustomerService/UpdateCustomerResponse")]
        void UpdateCustomer(OriginxWindowsClient.WorldWideBranchService.CustomerClass Customer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerService/UpdateCustomer", ReplyAction="http://tempuri.org/ICustomerService/UpdateCustomerResponse")]
        System.Threading.Tasks.Task UpdateCustomerAsync(OriginxWindowsClient.WorldWideBranchService.CustomerClass Customer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerService/SearchCustomer", ReplyAction="http://tempuri.org/ICustomerService/SearchCustomerResponse")]
        void SearchCustomer(OriginxWindowsClient.WorldWideBranchService.CustomerClass Customer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerService/SearchCustomer", ReplyAction="http://tempuri.org/ICustomerService/SearchCustomerResponse")]
        System.Threading.Tasks.Task SearchCustomerAsync(OriginxWindowsClient.WorldWideBranchService.CustomerClass Customer);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICustomerServiceChannel : OriginxWindowsClient.WorldWideBranchService.ICustomerService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CustomerServiceClient : System.ServiceModel.ClientBase<OriginxWindowsClient.WorldWideBranchService.ICustomerService>, OriginxWindowsClient.WorldWideBranchService.ICustomerService {
        
        public CustomerServiceClient() {
        }
        
        public CustomerServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CustomerServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CustomerServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CustomerServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void AddCustomer(OriginxWindowsClient.WorldWideBranchService.CustomerClass Customer) {
            base.Channel.AddCustomer(Customer);
        }
        
        public System.Threading.Tasks.Task AddCustomerAsync(OriginxWindowsClient.WorldWideBranchService.CustomerClass Customer) {
            return base.Channel.AddCustomerAsync(Customer);
        }
        
        public void DeleteCustomer(OriginxWindowsClient.WorldWideBranchService.CustomerClass Customer) {
            base.Channel.DeleteCustomer(Customer);
        }
        
        public System.Threading.Tasks.Task DeleteCustomerAsync(OriginxWindowsClient.WorldWideBranchService.CustomerClass Customer) {
            return base.Channel.DeleteCustomerAsync(Customer);
        }
        
        public void UpdateCustomer(OriginxWindowsClient.WorldWideBranchService.CustomerClass Customer) {
            base.Channel.UpdateCustomer(Customer);
        }
        
        public System.Threading.Tasks.Task UpdateCustomerAsync(OriginxWindowsClient.WorldWideBranchService.CustomerClass Customer) {
            return base.Channel.UpdateCustomerAsync(Customer);
        }
        
        public void SearchCustomer(OriginxWindowsClient.WorldWideBranchService.CustomerClass Customer) {
            base.Channel.SearchCustomer(Customer);
        }
        
        public System.Threading.Tasks.Task SearchCustomerAsync(OriginxWindowsClient.WorldWideBranchService.CustomerClass Customer) {
            return base.Channel.SearchCustomerAsync(Customer);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WorldWideBranchService.IEmailService")]
    public interface IEmailService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmailService/SendMail", ReplyAction="http://tempuri.org/IEmailService/SendMailResponse")]
        bool SendMail(string emailTo, string subject, string body, bool isBodyHtml);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmailService/SendMail", ReplyAction="http://tempuri.org/IEmailService/SendMailResponse")]
        System.Threading.Tasks.Task<bool> SendMailAsync(string emailTo, string subject, string body, bool isBodyHtml);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEmailServiceChannel : OriginxWindowsClient.WorldWideBranchService.IEmailService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EmailServiceClient : System.ServiceModel.ClientBase<OriginxWindowsClient.WorldWideBranchService.IEmailService>, OriginxWindowsClient.WorldWideBranchService.IEmailService {
        
        public EmailServiceClient() {
        }
        
        public EmailServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EmailServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmailServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmailServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool SendMail(string emailTo, string subject, string body, bool isBodyHtml) {
            return base.Channel.SendMail(emailTo, subject, body, isBodyHtml);
        }
        
        public System.Threading.Tasks.Task<bool> SendMailAsync(string emailTo, string subject, string body, bool isBodyHtml) {
            return base.Channel.SendMailAsync(emailTo, subject, body, isBodyHtml);
        }
    }
}
