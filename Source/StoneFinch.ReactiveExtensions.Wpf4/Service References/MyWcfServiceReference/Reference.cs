﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18033
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StoneFinch.ReactiveExtensions.Wpf4.MyWcfServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MyWcfServiceReference.IMyWcfService")]
    public interface IMyWcfService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyWcfService/GetCurrentDateTimeUtc", ReplyAction="http://tempuri.org/IMyWcfService/GetCurrentDateTimeUtcResponse")]
        System.DateTime GetCurrentDateTimeUtc();
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IMyWcfService/GetCurrentDateTimeUtc", ReplyAction="http://tempuri.org/IMyWcfService/GetCurrentDateTimeUtcResponse")]
        System.IAsyncResult BeginGetCurrentDateTimeUtc(System.AsyncCallback callback, object asyncState);
        
        System.DateTime EndGetCurrentDateTimeUtc(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyWcfService/DateTimeToString", ReplyAction="http://tempuri.org/IMyWcfService/DateTimeToStringResponse")]
        string DateTimeToString(System.DateTime dateTime);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IMyWcfService/DateTimeToString", ReplyAction="http://tempuri.org/IMyWcfService/DateTimeToStringResponse")]
        System.IAsyncResult BeginDateTimeToString(System.DateTime dateTime, System.AsyncCallback callback, object asyncState);
        
        string EndDateTimeToString(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyWcfService/GetRandomNumber", ReplyAction="http://tempuri.org/IMyWcfService/GetRandomNumberResponse")]
        double GetRandomNumber();
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IMyWcfService/GetRandomNumber", ReplyAction="http://tempuri.org/IMyWcfService/GetRandomNumberResponse")]
        System.IAsyncResult BeginGetRandomNumber(System.AsyncCallback callback, object asyncState);
        
        double EndGetRandomNumber(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyWcfService/SelectNamesStartWith", ReplyAction="http://tempuri.org/IMyWcfService/SelectNamesStartWithResponse")]
        string[] SelectNamesStartWith(string nameStartsWith);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IMyWcfService/SelectNamesStartWith", ReplyAction="http://tempuri.org/IMyWcfService/SelectNamesStartWithResponse")]
        System.IAsyncResult BeginSelectNamesStartWith(string nameStartsWith, System.AsyncCallback callback, object asyncState);
        
        string[] EndSelectNamesStartWith(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMyWcfServiceChannel : StoneFinch.ReactiveExtensions.Wpf4.MyWcfServiceReference.IMyWcfService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetCurrentDateTimeUtcCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetCurrentDateTimeUtcCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public System.DateTime Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((System.DateTime)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DateTimeToStringCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public DateTimeToStringCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public string Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetRandomNumberCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetRandomNumberCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public double Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((double)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SelectNamesStartWithCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public SelectNamesStartWithCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public string[] Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((string[])(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MyWcfServiceClient : System.ServiceModel.ClientBase<StoneFinch.ReactiveExtensions.Wpf4.MyWcfServiceReference.IMyWcfService>, StoneFinch.ReactiveExtensions.Wpf4.MyWcfServiceReference.IMyWcfService {
        
        private BeginOperationDelegate onBeginGetCurrentDateTimeUtcDelegate;
        
        private EndOperationDelegate onEndGetCurrentDateTimeUtcDelegate;
        
        private System.Threading.SendOrPostCallback onGetCurrentDateTimeUtcCompletedDelegate;
        
        private BeginOperationDelegate onBeginDateTimeToStringDelegate;
        
        private EndOperationDelegate onEndDateTimeToStringDelegate;
        
        private System.Threading.SendOrPostCallback onDateTimeToStringCompletedDelegate;
        
        private BeginOperationDelegate onBeginGetRandomNumberDelegate;
        
        private EndOperationDelegate onEndGetRandomNumberDelegate;
        
        private System.Threading.SendOrPostCallback onGetRandomNumberCompletedDelegate;
        
        private BeginOperationDelegate onBeginSelectNamesStartWithDelegate;
        
        private EndOperationDelegate onEndSelectNamesStartWithDelegate;
        
        private System.Threading.SendOrPostCallback onSelectNamesStartWithCompletedDelegate;
        
        public MyWcfServiceClient() {
        }
        
        public MyWcfServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MyWcfServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MyWcfServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MyWcfServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public event System.EventHandler<GetCurrentDateTimeUtcCompletedEventArgs> GetCurrentDateTimeUtcCompleted;
        
        public event System.EventHandler<DateTimeToStringCompletedEventArgs> DateTimeToStringCompleted;
        
        public event System.EventHandler<GetRandomNumberCompletedEventArgs> GetRandomNumberCompleted;
        
        public event System.EventHandler<SelectNamesStartWithCompletedEventArgs> SelectNamesStartWithCompleted;
        
        public System.DateTime GetCurrentDateTimeUtc() {
            return base.Channel.GetCurrentDateTimeUtc();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginGetCurrentDateTimeUtc(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetCurrentDateTimeUtc(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.DateTime EndGetCurrentDateTimeUtc(System.IAsyncResult result) {
            return base.Channel.EndGetCurrentDateTimeUtc(result);
        }
        
        private System.IAsyncResult OnBeginGetCurrentDateTimeUtc(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return this.BeginGetCurrentDateTimeUtc(callback, asyncState);
        }
        
        private object[] OnEndGetCurrentDateTimeUtc(System.IAsyncResult result) {
            System.DateTime retVal = this.EndGetCurrentDateTimeUtc(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetCurrentDateTimeUtcCompleted(object state) {
            if ((this.GetCurrentDateTimeUtcCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetCurrentDateTimeUtcCompleted(this, new GetCurrentDateTimeUtcCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetCurrentDateTimeUtcAsync() {
            this.GetCurrentDateTimeUtcAsync(null);
        }
        
        public void GetCurrentDateTimeUtcAsync(object userState) {
            if ((this.onBeginGetCurrentDateTimeUtcDelegate == null)) {
                this.onBeginGetCurrentDateTimeUtcDelegate = new BeginOperationDelegate(this.OnBeginGetCurrentDateTimeUtc);
            }
            if ((this.onEndGetCurrentDateTimeUtcDelegate == null)) {
                this.onEndGetCurrentDateTimeUtcDelegate = new EndOperationDelegate(this.OnEndGetCurrentDateTimeUtc);
            }
            if ((this.onGetCurrentDateTimeUtcCompletedDelegate == null)) {
                this.onGetCurrentDateTimeUtcCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetCurrentDateTimeUtcCompleted);
            }
            base.InvokeAsync(this.onBeginGetCurrentDateTimeUtcDelegate, null, this.onEndGetCurrentDateTimeUtcDelegate, this.onGetCurrentDateTimeUtcCompletedDelegate, userState);
        }
        
        public string DateTimeToString(System.DateTime dateTime) {
            return base.Channel.DateTimeToString(dateTime);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginDateTimeToString(System.DateTime dateTime, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginDateTimeToString(dateTime, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public string EndDateTimeToString(System.IAsyncResult result) {
            return base.Channel.EndDateTimeToString(result);
        }
        
        private System.IAsyncResult OnBeginDateTimeToString(object[] inValues, System.AsyncCallback callback, object asyncState) {
            System.DateTime dateTime = ((System.DateTime)(inValues[0]));
            return this.BeginDateTimeToString(dateTime, callback, asyncState);
        }
        
        private object[] OnEndDateTimeToString(System.IAsyncResult result) {
            string retVal = this.EndDateTimeToString(result);
            return new object[] {
                    retVal};
        }
        
        private void OnDateTimeToStringCompleted(object state) {
            if ((this.DateTimeToStringCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.DateTimeToStringCompleted(this, new DateTimeToStringCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void DateTimeToStringAsync(System.DateTime dateTime) {
            this.DateTimeToStringAsync(dateTime, null);
        }
        
        public void DateTimeToStringAsync(System.DateTime dateTime, object userState) {
            if ((this.onBeginDateTimeToStringDelegate == null)) {
                this.onBeginDateTimeToStringDelegate = new BeginOperationDelegate(this.OnBeginDateTimeToString);
            }
            if ((this.onEndDateTimeToStringDelegate == null)) {
                this.onEndDateTimeToStringDelegate = new EndOperationDelegate(this.OnEndDateTimeToString);
            }
            if ((this.onDateTimeToStringCompletedDelegate == null)) {
                this.onDateTimeToStringCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnDateTimeToStringCompleted);
            }
            base.InvokeAsync(this.onBeginDateTimeToStringDelegate, new object[] {
                        dateTime}, this.onEndDateTimeToStringDelegate, this.onDateTimeToStringCompletedDelegate, userState);
        }
        
        public double GetRandomNumber() {
            return base.Channel.GetRandomNumber();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginGetRandomNumber(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetRandomNumber(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public double EndGetRandomNumber(System.IAsyncResult result) {
            return base.Channel.EndGetRandomNumber(result);
        }
        
        private System.IAsyncResult OnBeginGetRandomNumber(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return this.BeginGetRandomNumber(callback, asyncState);
        }
        
        private object[] OnEndGetRandomNumber(System.IAsyncResult result) {
            double retVal = this.EndGetRandomNumber(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetRandomNumberCompleted(object state) {
            if ((this.GetRandomNumberCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetRandomNumberCompleted(this, new GetRandomNumberCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetRandomNumberAsync() {
            this.GetRandomNumberAsync(null);
        }
        
        public void GetRandomNumberAsync(object userState) {
            if ((this.onBeginGetRandomNumberDelegate == null)) {
                this.onBeginGetRandomNumberDelegate = new BeginOperationDelegate(this.OnBeginGetRandomNumber);
            }
            if ((this.onEndGetRandomNumberDelegate == null)) {
                this.onEndGetRandomNumberDelegate = new EndOperationDelegate(this.OnEndGetRandomNumber);
            }
            if ((this.onGetRandomNumberCompletedDelegate == null)) {
                this.onGetRandomNumberCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetRandomNumberCompleted);
            }
            base.InvokeAsync(this.onBeginGetRandomNumberDelegate, null, this.onEndGetRandomNumberDelegate, this.onGetRandomNumberCompletedDelegate, userState);
        }
        
        public string[] SelectNamesStartWith(string nameStartsWith) {
            return base.Channel.SelectNamesStartWith(nameStartsWith);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginSelectNamesStartWith(string nameStartsWith, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginSelectNamesStartWith(nameStartsWith, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public string[] EndSelectNamesStartWith(System.IAsyncResult result) {
            return base.Channel.EndSelectNamesStartWith(result);
        }
        
        private System.IAsyncResult OnBeginSelectNamesStartWith(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string nameStartsWith = ((string)(inValues[0]));
            return this.BeginSelectNamesStartWith(nameStartsWith, callback, asyncState);
        }
        
        private object[] OnEndSelectNamesStartWith(System.IAsyncResult result) {
            string[] retVal = this.EndSelectNamesStartWith(result);
            return new object[] {
                    retVal};
        }
        
        private void OnSelectNamesStartWithCompleted(object state) {
            if ((this.SelectNamesStartWithCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.SelectNamesStartWithCompleted(this, new SelectNamesStartWithCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void SelectNamesStartWithAsync(string nameStartsWith) {
            this.SelectNamesStartWithAsync(nameStartsWith, null);
        }
        
        public void SelectNamesStartWithAsync(string nameStartsWith, object userState) {
            if ((this.onBeginSelectNamesStartWithDelegate == null)) {
                this.onBeginSelectNamesStartWithDelegate = new BeginOperationDelegate(this.OnBeginSelectNamesStartWith);
            }
            if ((this.onEndSelectNamesStartWithDelegate == null)) {
                this.onEndSelectNamesStartWithDelegate = new EndOperationDelegate(this.OnEndSelectNamesStartWith);
            }
            if ((this.onSelectNamesStartWithCompletedDelegate == null)) {
                this.onSelectNamesStartWithCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnSelectNamesStartWithCompleted);
            }
            base.InvokeAsync(this.onBeginSelectNamesStartWithDelegate, new object[] {
                        nameStartsWith}, this.onEndSelectNamesStartWithDelegate, this.onSelectNamesStartWithCompletedDelegate, userState);
        }
    }
}
