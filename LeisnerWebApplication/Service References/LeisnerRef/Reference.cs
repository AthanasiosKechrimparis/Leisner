﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LeisnerWebApplication.LeisnerRef {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AccidentDTO", Namespace="http://schemas.datacontract.org/2004/07/BWS_ASP")]
    [System.SerializableAttribute()]
    public partial class AccidentDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int AccidentIDk__BackingFieldField;
        
        private int Amountk__BackingFieldField;
        
        private System.DateTime Datek__BackingFieldField;
        
        private int DeviceIDk__BackingFieldField;
        
        private int STk__BackingFieldField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<AccidentID>k__BackingField", IsRequired=true)]
        public int AccidentIDk__BackingField {
            get {
                return this.AccidentIDk__BackingFieldField;
            }
            set {
                if ((this.AccidentIDk__BackingFieldField.Equals(value) != true)) {
                    this.AccidentIDk__BackingFieldField = value;
                    this.RaisePropertyChanged("AccidentIDk__BackingField");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<Amount>k__BackingField", IsRequired=true)]
        public int Amountk__BackingField {
            get {
                return this.Amountk__BackingFieldField;
            }
            set {
                if ((this.Amountk__BackingFieldField.Equals(value) != true)) {
                    this.Amountk__BackingFieldField = value;
                    this.RaisePropertyChanged("Amountk__BackingField");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<Date>k__BackingField", IsRequired=true)]
        public System.DateTime Datek__BackingField {
            get {
                return this.Datek__BackingFieldField;
            }
            set {
                if ((this.Datek__BackingFieldField.Equals(value) != true)) {
                    this.Datek__BackingFieldField = value;
                    this.RaisePropertyChanged("Datek__BackingField");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<DeviceID>k__BackingField", IsRequired=true)]
        public int DeviceIDk__BackingField {
            get {
                return this.DeviceIDk__BackingFieldField;
            }
            set {
                if ((this.DeviceIDk__BackingFieldField.Equals(value) != true)) {
                    this.DeviceIDk__BackingFieldField = value;
                    this.RaisePropertyChanged("DeviceIDk__BackingField");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<ST>k__BackingField", IsRequired=true)]
        public int STk__BackingField {
            get {
                return this.STk__BackingFieldField;
            }
            set {
                if ((this.STk__BackingFieldField.Equals(value) != true)) {
                    this.STk__BackingFieldField = value;
                    this.RaisePropertyChanged("STk__BackingField");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="LeisnerRef.IBWSService")]
    public interface IBWSService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBWSService/Dowork", ReplyAction="http://tempuri.org/IBWSService/DoworkResponse")]
        void Dowork();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBWSService/Dowork", ReplyAction="http://tempuri.org/IBWSService/DoworkResponse")]
        System.Threading.Tasks.Task DoworkAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBWSService/RegisterAccident", ReplyAction="http://tempuri.org/IBWSService/RegisterAccidentResponse")]
        void RegisterAccident(int deviceNR, int amount, System.DateTime timeOfAccident, int Drinks, System.DateTime TimeSleep, System.DateTime TimeToilet, int ToiletVisit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBWSService/RegisterAccident", ReplyAction="http://tempuri.org/IBWSService/RegisterAccidentResponse")]
        System.Threading.Tasks.Task RegisterAccidentAsync(int deviceNR, int amount, System.DateTime timeOfAccident, int Drinks, System.DateTime TimeSleep, System.DateTime TimeToilet, int ToiletVisit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBWSService/GetSatisticBasedOnUser", ReplyAction="http://tempuri.org/IBWSService/GetSatisticBasedOnUserResponse")]
        LeisnerWebApplication.LeisnerRef.AccidentDTO[] GetSatisticBasedOnUser(int ID, System.DateTime startdate, System.DateTime enddate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBWSService/GetSatisticBasedOnUser", ReplyAction="http://tempuri.org/IBWSService/GetSatisticBasedOnUserResponse")]
        System.Threading.Tasks.Task<LeisnerWebApplication.LeisnerRef.AccidentDTO[]> GetSatisticBasedOnUserAsync(int ID, System.DateTime startdate, System.DateTime enddate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBWSService/logIn", ReplyAction="http://tempuri.org/IBWSService/logInResponse")]
        int logIn(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBWSService/logIn", ReplyAction="http://tempuri.org/IBWSService/logInResponse")]
        System.Threading.Tasks.Task<int> logInAsync(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBWSService/RegisterDevice", ReplyAction="http://tempuri.org/IBWSService/RegisterDeviceResponse")]
        void RegisterDevice(int userID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBWSService/RegisterDevice", ReplyAction="http://tempuri.org/IBWSService/RegisterDeviceResponse")]
        System.Threading.Tasks.Task RegisterDeviceAsync(int userID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBWSService/UpdateAccident", ReplyAction="http://tempuri.org/IBWSService/UpdateAccidentResponse")]
        void UpdateAccident(int AccidentID, int Amount, System.DateTime date, int DeviceID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBWSService/UpdateAccident", ReplyAction="http://tempuri.org/IBWSService/UpdateAccidentResponse")]
        System.Threading.Tasks.Task UpdateAccidentAsync(int AccidentID, int Amount, System.DateTime date, int DeviceID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBWSService/DeleteAccidents", ReplyAction="http://tempuri.org/IBWSService/DeleteAccidentsResponse")]
        void DeleteAccidents(int AccidentID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBWSService/DeleteAccidents", ReplyAction="http://tempuri.org/IBWSService/DeleteAccidentsResponse")]
        System.Threading.Tasks.Task DeleteAccidentsAsync(int AccidentID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBWSService/SignUp", ReplyAction="http://tempuri.org/IBWSService/SignUpResponse")]
        void SignUp(string type, string birthday, string UserName, string PassWord, string Name, int deviceID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBWSService/SignUp", ReplyAction="http://tempuri.org/IBWSService/SignUpResponse")]
        System.Threading.Tasks.Task SignUpAsync(string type, string birthday, string UserName, string PassWord, string Name, int deviceID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBWSService/ReadAccidents", ReplyAction="http://tempuri.org/IBWSService/ReadAccidentsResponse")]
        LeisnerWebApplication.LeisnerRef.AccidentDTO[] ReadAccidents(int UserID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBWSService/ReadAccidents", ReplyAction="http://tempuri.org/IBWSService/ReadAccidentsResponse")]
        System.Threading.Tasks.Task<LeisnerWebApplication.LeisnerRef.AccidentDTO[]> ReadAccidentsAsync(int UserID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBWSService/getIDFromUsername", ReplyAction="http://tempuri.org/IBWSService/getIDFromUsernameResponse")]
        int getIDFromUsername(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBWSService/getIDFromUsername", ReplyAction="http://tempuri.org/IBWSService/getIDFromUsernameResponse")]
        System.Threading.Tasks.Task<int> getIDFromUsernameAsync(string username);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBWSServiceChannel : LeisnerWebApplication.LeisnerRef.IBWSService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BWSServiceClient : System.ServiceModel.ClientBase<LeisnerWebApplication.LeisnerRef.IBWSService>, LeisnerWebApplication.LeisnerRef.IBWSService {
        
        public BWSServiceClient() {
        }
        
        public BWSServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BWSServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BWSServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BWSServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void Dowork() {
            base.Channel.Dowork();
        }
        
        public System.Threading.Tasks.Task DoworkAsync() {
            return base.Channel.DoworkAsync();
        }
        
        public void RegisterAccident(int deviceNR, int amount, System.DateTime timeOfAccident, int Drinks, System.DateTime TimeSleep, System.DateTime TimeToilet, int ToiletVisit) {
            base.Channel.RegisterAccident(deviceNR, amount, timeOfAccident, Drinks, TimeSleep, TimeToilet, ToiletVisit);
        }
        
        public System.Threading.Tasks.Task RegisterAccidentAsync(int deviceNR, int amount, System.DateTime timeOfAccident, int Drinks, System.DateTime TimeSleep, System.DateTime TimeToilet, int ToiletVisit) {
            return base.Channel.RegisterAccidentAsync(deviceNR, amount, timeOfAccident, Drinks, TimeSleep, TimeToilet, ToiletVisit);
        }
        
        public LeisnerWebApplication.LeisnerRef.AccidentDTO[] GetSatisticBasedOnUser(int ID, System.DateTime startdate, System.DateTime enddate) {
            return base.Channel.GetSatisticBasedOnUser(ID, startdate, enddate);
        }
        
        public System.Threading.Tasks.Task<LeisnerWebApplication.LeisnerRef.AccidentDTO[]> GetSatisticBasedOnUserAsync(int ID, System.DateTime startdate, System.DateTime enddate) {
            return base.Channel.GetSatisticBasedOnUserAsync(ID, startdate, enddate);
        }
        
        public int logIn(string username, string password) {
            return base.Channel.logIn(username, password);
        }
        
        public System.Threading.Tasks.Task<int> logInAsync(string username, string password) {
            return base.Channel.logInAsync(username, password);
        }
        
        public void RegisterDevice(int userID) {
            base.Channel.RegisterDevice(userID);
        }
        
        public System.Threading.Tasks.Task RegisterDeviceAsync(int userID) {
            return base.Channel.RegisterDeviceAsync(userID);
        }
        
        public void UpdateAccident(int AccidentID, int Amount, System.DateTime date, int DeviceID) {
            base.Channel.UpdateAccident(AccidentID, Amount, date, DeviceID);
        }
        
        public System.Threading.Tasks.Task UpdateAccidentAsync(int AccidentID, int Amount, System.DateTime date, int DeviceID) {
            return base.Channel.UpdateAccidentAsync(AccidentID, Amount, date, DeviceID);
        }
        
        public void DeleteAccidents(int AccidentID) {
            base.Channel.DeleteAccidents(AccidentID);
        }
        
        public System.Threading.Tasks.Task DeleteAccidentsAsync(int AccidentID) {
            return base.Channel.DeleteAccidentsAsync(AccidentID);
        }
        
        public void SignUp(string type, string birthday, string UserName, string PassWord, string Name, int deviceID) {
            base.Channel.SignUp(type, birthday, UserName, PassWord, Name, deviceID);
        }
        
        public System.Threading.Tasks.Task SignUpAsync(string type, string birthday, string UserName, string PassWord, string Name, int deviceID) {
            return base.Channel.SignUpAsync(type, birthday, UserName, PassWord, Name, deviceID);
        }
        
        public LeisnerWebApplication.LeisnerRef.AccidentDTO[] ReadAccidents(int UserID) {
            return base.Channel.ReadAccidents(UserID);
        }
        
        public System.Threading.Tasks.Task<LeisnerWebApplication.LeisnerRef.AccidentDTO[]> ReadAccidentsAsync(int UserID) {
            return base.Channel.ReadAccidentsAsync(UserID);
        }
        
        public int getIDFromUsername(string username) {
            return base.Channel.getIDFromUsername(username);
        }
        
        public System.Threading.Tasks.Task<int> getIDFromUsernameAsync(string username) {
            return base.Channel.getIDFromUsernameAsync(username);
        }
    }
}
