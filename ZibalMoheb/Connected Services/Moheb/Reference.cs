﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ZibalMoheb.Moheb {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AccountTransactionResponse", Namespace="http://schemas.datacontract.org/2004/07/KPP.Moheb.BusinessFacade.Services.Account" +
        ".DTO")]
    [System.SerializableAttribute()]
    public partial class AccountTransactionResponse : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ZibalMoheb.Moheb.AccountTransaction[] AccountTransactionsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ResponseCodeField;
        
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
        public ZibalMoheb.Moheb.AccountTransaction[] AccountTransactions {
            get {
                return this.AccountTransactionsField;
            }
            set {
                if ((object.ReferenceEquals(this.AccountTransactionsField, value) != true)) {
                    this.AccountTransactionsField = value;
                    this.RaisePropertyChanged("AccountTransactions");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ResponseCode {
            get {
                return this.ResponseCodeField;
            }
            set {
                if ((this.ResponseCodeField.Equals(value) != true)) {
                    this.ResponseCodeField = value;
                    this.RaisePropertyChanged("ResponseCode");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="AccountTransaction", Namespace="http://schemas.datacontract.org/2004/07/KPP.Moheb.BusinessFacade.Services.Account" +
        ".DTO")]
    [System.SerializableAttribute()]
    public partial class AccountTransaction : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long AccountTransactionIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long BalanceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int BranchCodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long ChqNumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ChqSeriField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long CreditAmountField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long DebitAmountField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long DepositIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int DocTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EffectiveDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EffectiveTimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PayerNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long RowSeqPerDayField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TransDescField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TransactionDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TransactionTimeField;
        
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
        public long AccountTransactionID {
            get {
                return this.AccountTransactionIDField;
            }
            set {
                if ((this.AccountTransactionIDField.Equals(value) != true)) {
                    this.AccountTransactionIDField = value;
                    this.RaisePropertyChanged("AccountTransactionID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long Balance {
            get {
                return this.BalanceField;
            }
            set {
                if ((this.BalanceField.Equals(value) != true)) {
                    this.BalanceField = value;
                    this.RaisePropertyChanged("Balance");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int BranchCode {
            get {
                return this.BranchCodeField;
            }
            set {
                if ((this.BranchCodeField.Equals(value) != true)) {
                    this.BranchCodeField = value;
                    this.RaisePropertyChanged("BranchCode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long ChqNumber {
            get {
                return this.ChqNumberField;
            }
            set {
                if ((this.ChqNumberField.Equals(value) != true)) {
                    this.ChqNumberField = value;
                    this.RaisePropertyChanged("ChqNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ChqSeri {
            get {
                return this.ChqSeriField;
            }
            set {
                if ((this.ChqSeriField.Equals(value) != true)) {
                    this.ChqSeriField = value;
                    this.RaisePropertyChanged("ChqSeri");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long CreditAmount {
            get {
                return this.CreditAmountField;
            }
            set {
                if ((this.CreditAmountField.Equals(value) != true)) {
                    this.CreditAmountField = value;
                    this.RaisePropertyChanged("CreditAmount");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long DebitAmount {
            get {
                return this.DebitAmountField;
            }
            set {
                if ((this.DebitAmountField.Equals(value) != true)) {
                    this.DebitAmountField = value;
                    this.RaisePropertyChanged("DebitAmount");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long DepositID {
            get {
                return this.DepositIDField;
            }
            set {
                if ((this.DepositIDField.Equals(value) != true)) {
                    this.DepositIDField = value;
                    this.RaisePropertyChanged("DepositID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int DocType {
            get {
                return this.DocTypeField;
            }
            set {
                if ((this.DocTypeField.Equals(value) != true)) {
                    this.DocTypeField = value;
                    this.RaisePropertyChanged("DocType");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EffectiveDate {
            get {
                return this.EffectiveDateField;
            }
            set {
                if ((object.ReferenceEquals(this.EffectiveDateField, value) != true)) {
                    this.EffectiveDateField = value;
                    this.RaisePropertyChanged("EffectiveDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EffectiveTime {
            get {
                return this.EffectiveTimeField;
            }
            set {
                if ((object.ReferenceEquals(this.EffectiveTimeField, value) != true)) {
                    this.EffectiveTimeField = value;
                    this.RaisePropertyChanged("EffectiveTime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PayerName {
            get {
                return this.PayerNameField;
            }
            set {
                if ((object.ReferenceEquals(this.PayerNameField, value) != true)) {
                    this.PayerNameField = value;
                    this.RaisePropertyChanged("PayerName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long RowSeqPerDay {
            get {
                return this.RowSeqPerDayField;
            }
            set {
                if ((this.RowSeqPerDayField.Equals(value) != true)) {
                    this.RowSeqPerDayField = value;
                    this.RaisePropertyChanged("RowSeqPerDay");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TransDesc {
            get {
                return this.TransDescField;
            }
            set {
                if ((object.ReferenceEquals(this.TransDescField, value) != true)) {
                    this.TransDescField = value;
                    this.RaisePropertyChanged("TransDesc");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TransactionDate {
            get {
                return this.TransactionDateField;
            }
            set {
                if ((object.ReferenceEquals(this.TransactionDateField, value) != true)) {
                    this.TransactionDateField = value;
                    this.RaisePropertyChanged("TransactionDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TransactionTime {
            get {
                return this.TransactionTimeField;
            }
            set {
                if ((object.ReferenceEquals(this.TransactionTimeField, value) != true)) {
                    this.TransactionTimeField = value;
                    this.RaisePropertyChanged("TransactionTime");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="TransactionNoPerDay", Namespace="http://schemas.datacontract.org/2004/07/KPP.Moheb.BusinessFacade.Services.Account" +
        ".DTO")]
    [System.SerializableAttribute()]
    public partial class TransactionNoPerDay : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ResponseCodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long TransactionNoField;
        
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
        public int ResponseCode {
            get {
                return this.ResponseCodeField;
            }
            set {
                if ((this.ResponseCodeField.Equals(value) != true)) {
                    this.ResponseCodeField = value;
                    this.RaisePropertyChanged("ResponseCode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long TransactionNo {
            get {
                return this.TransactionNoField;
            }
            set {
                if ((this.TransactionNoField.Equals(value) != true)) {
                    this.TransactionNoField = value;
                    this.RaisePropertyChanged("TransactionNo");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Moheb.IStatementService")]
    public interface IStatementService {
        
        [System.ServiceModel.OperationContractAttribute(ProtectionLevel=System.Net.Security.ProtectionLevel.Sign, Action="http://tempuri.org/IStatementService/GetAccountTransaction", ReplyAction="http://tempuri.org/IStatementService/GetAccountTransactionResponse")]
        ZibalMoheb.Moheb.AccountTransactionResponse GetAccountTransaction(long accountNo, long rowSeqPerDay, string transactionDate);
        
        [System.ServiceModel.OperationContractAttribute(ProtectionLevel=System.Net.Security.ProtectionLevel.Sign, Action="http://tempuri.org/IStatementService/GetAccountTransaction", ReplyAction="http://tempuri.org/IStatementService/GetAccountTransactionResponse")]
        System.Threading.Tasks.Task<ZibalMoheb.Moheb.AccountTransactionResponse> GetAccountTransactionAsync(long accountNo, long rowSeqPerDay, string transactionDate);
        
        [System.ServiceModel.OperationContractAttribute(ProtectionLevel=System.Net.Security.ProtectionLevel.Sign, Action="http://tempuri.org/IStatementService/GetTransactionNoPerDay", ReplyAction="http://tempuri.org/IStatementService/GetTransactionNoPerDayResponse")]
        ZibalMoheb.Moheb.TransactionNoPerDay GetTransactionNoPerDay(long accountNo, string transactionDate);
        
        [System.ServiceModel.OperationContractAttribute(ProtectionLevel=System.Net.Security.ProtectionLevel.Sign, Action="http://tempuri.org/IStatementService/GetTransactionNoPerDay", ReplyAction="http://tempuri.org/IStatementService/GetTransactionNoPerDayResponse")]
        System.Threading.Tasks.Task<ZibalMoheb.Moheb.TransactionNoPerDay> GetTransactionNoPerDayAsync(long accountNo, string transactionDate);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IStatementServiceChannel : ZibalMoheb.Moheb.IStatementService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class StatementServiceClient : System.ServiceModel.ClientBase<ZibalMoheb.Moheb.IStatementService>, ZibalMoheb.Moheb.IStatementService {
        
        public StatementServiceClient() {
        }
        
        public StatementServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public StatementServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public StatementServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public StatementServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ZibalMoheb.Moheb.AccountTransactionResponse GetAccountTransaction(long accountNo, long rowSeqPerDay, string transactionDate) {
            return base.Channel.GetAccountTransaction(accountNo, rowSeqPerDay, transactionDate);
        }
        
        public System.Threading.Tasks.Task<ZibalMoheb.Moheb.AccountTransactionResponse> GetAccountTransactionAsync(long accountNo, long rowSeqPerDay, string transactionDate) {
            return base.Channel.GetAccountTransactionAsync(accountNo, rowSeqPerDay, transactionDate);
        }
        
        public ZibalMoheb.Moheb.TransactionNoPerDay GetTransactionNoPerDay(long accountNo, string transactionDate) {
            return base.Channel.GetTransactionNoPerDay(accountNo, transactionDate);
        }
        
        public System.Threading.Tasks.Task<ZibalMoheb.Moheb.TransactionNoPerDay> GetTransactionNoPerDayAsync(long accountNo, string transactionDate) {
            return base.Channel.GetTransactionNoPerDayAsync(accountNo, transactionDate);
        }
    }
}
