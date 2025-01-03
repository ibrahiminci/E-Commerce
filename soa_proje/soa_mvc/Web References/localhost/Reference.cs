﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Bu kod araç tarafından oluşturuldu.
//     Çalışma Zamanı Sürümü:4.0.30319.42000
//
//     Bu dosyada yapılacak değişiklikler yanlış davranışa neden olabilir ve
//     kod yeniden oluşturulursa kaybolur.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// Kaynak kodu Microsoft.VSDesigner tarafından otomatik üretilmiş , Sürüm 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace soa_mvc.localhost {
    using System.Diagnostics;
    using System;
    using System.Xml.Serialization;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System.Web.Services;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="SoapConvertSoap", Namespace="http://tempuri.org/")]
    public partial class SoapConvert : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback TurkishLiraToDollarOperationCompleted;
        
        private System.Threading.SendOrPostCallback TurkishLiraToEuroOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public SoapConvert() {
            this.Url = global::soa_mvc.Properties.Settings.Default.soa_mvc_localhost_SoapConvert;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event TurkishLiraToDollarCompletedEventHandler TurkishLiraToDollarCompleted;
        
        /// <remarks/>
        public event TurkishLiraToEuroCompletedEventHandler TurkishLiraToEuroCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/TurkishLiraToDollar", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public double TurkishLiraToDollar(double TurkishLira) {
            object[] results = this.Invoke("TurkishLiraToDollar", new object[] {
                        TurkishLira});
            return ((double)(results[0]));
        }
        
        /// <remarks/>
        public void TurkishLiraToDollarAsync(double TurkishLira) {
            this.TurkishLiraToDollarAsync(TurkishLira, null);
        }
        
        /// <remarks/>
        public void TurkishLiraToDollarAsync(double TurkishLira, object userState) {
            if ((this.TurkishLiraToDollarOperationCompleted == null)) {
                this.TurkishLiraToDollarOperationCompleted = new System.Threading.SendOrPostCallback(this.OnTurkishLiraToDollarOperationCompleted);
            }
            this.InvokeAsync("TurkishLiraToDollar", new object[] {
                        TurkishLira}, this.TurkishLiraToDollarOperationCompleted, userState);
        }
        
        private void OnTurkishLiraToDollarOperationCompleted(object arg) {
            if ((this.TurkishLiraToDollarCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.TurkishLiraToDollarCompleted(this, new TurkishLiraToDollarCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/TurkishLiraToEuro", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public double TurkishLiraToEuro(double TurkishLira) {
            object[] results = this.Invoke("TurkishLiraToEuro", new object[] {
                        TurkishLira});
            return ((double)(results[0]));
        }
        
        /// <remarks/>
        public void TurkishLiraToEuroAsync(double TurkishLira) {
            this.TurkishLiraToEuroAsync(TurkishLira, null);
        }
        
        /// <remarks/>
        public void TurkishLiraToEuroAsync(double TurkishLira, object userState) {
            if ((this.TurkishLiraToEuroOperationCompleted == null)) {
                this.TurkishLiraToEuroOperationCompleted = new System.Threading.SendOrPostCallback(this.OnTurkishLiraToEuroOperationCompleted);
            }
            this.InvokeAsync("TurkishLiraToEuro", new object[] {
                        TurkishLira}, this.TurkishLiraToEuroOperationCompleted, userState);
        }
        
        private void OnTurkishLiraToEuroOperationCompleted(object arg) {
            if ((this.TurkishLiraToEuroCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.TurkishLiraToEuroCompleted(this, new TurkishLiraToEuroCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    public delegate void TurkishLiraToDollarCompletedEventHandler(object sender, TurkishLiraToDollarCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TurkishLiraToDollarCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal TurkishLiraToDollarCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public double Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((double)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    public delegate void TurkishLiraToEuroCompletedEventHandler(object sender, TurkishLiraToEuroCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TurkishLiraToEuroCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal TurkishLiraToEuroCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public double Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((double)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591