// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.17020
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

// 
//This source code was auto-generated by MonoXSD
//
namespace Terradue.OpenNebula {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://opennebula.org/XMLSchema")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://opennebula.org/XMLSchema", IsNullable=false)]
    public partial class VM_POOL {
        
        private VM[] vMField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("VM", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public VM[] VM {
            get {
                return this.vMField;
            }
            set {
                this.vMField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://opennebula.org/XMLSchema")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://opennebula.org/XMLSchema", IsNullable=true)]
    public partial class VM {
        
        private string iDField;
        
        private string uIDField;
        
        private string gIDField;
        
        private string uNAMEField;
        
        private string gNAMEField;
        
        private string nAMEField;
        
        private VMPERMISSIONS pERMISSIONSField;
        
        private string lAST_POLLField;
        
        private string sTATEField;
        
        private string lCM_STATEField;
        
        private string rESCHEDField;
        
        private string sTIMEField;
        
        private string eTIMEField;
        
        private string dEPLOY_IDField;
        
        private string mEMORYField;
        
        private string cPUField;
        
        private string nET_TXField;
        
        private string nET_RXField;
        
        private object tEMPLATEField;
        
        private object uSER_TEMPLATEField;
        
        private VMHISTORY_RECORDSHISTORY[] hISTORY_RECORDSField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="integer")]
        public string ID {
            get {
                return this.iDField;
            }
            set {
                this.iDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="integer")]
        public string UID {
            get {
                return this.uIDField;
            }
            set {
                this.uIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="integer")]
        public string GID {
            get {
                return this.gIDField;
            }
            set {
                this.gIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string UNAME {
            get {
                return this.uNAMEField;
            }
            set {
                this.uNAMEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string GNAME {
            get {
                return this.gNAMEField;
            }
            set {
                this.gNAMEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string NAME {
            get {
                return this.nAMEField;
            }
            set {
                this.nAMEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public VMPERMISSIONS PERMISSIONS {
            get {
                return this.pERMISSIONSField;
            }
            set {
                this.pERMISSIONSField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="integer")]
        public string LAST_POLL {
            get {
                return this.lAST_POLLField;
            }
            set {
                this.lAST_POLLField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="integer")]
        public string STATE {
            get {
                return this.sTATEField;
            }
            set {
                this.sTATEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="integer")]
        public string LCM_STATE {
            get {
                return this.lCM_STATEField;
            }
            set {
                this.lCM_STATEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="integer")]
        public string RESCHED {
            get {
                return this.rESCHEDField;
            }
            set {
                this.rESCHEDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="integer")]
        public string STIME {
            get {
                return this.sTIMEField;
            }
            set {
                this.sTIMEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="integer")]
        public string ETIME {
            get {
                return this.eTIMEField;
            }
            set {
                this.eTIMEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DEPLOY_ID {
            get {
                return this.dEPLOY_IDField;
            }
            set {
                this.dEPLOY_IDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="integer")]
        public string MEMORY {
            get {
                return this.mEMORYField;
            }
            set {
                this.mEMORYField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="integer")]
        public string CPU {
            get {
                return this.cPUField;
            }
            set {
                this.cPUField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="integer")]
        public string NET_TX {
            get {
                return this.nET_TXField;
            }
            set {
                this.nET_TXField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="integer")]
        public string NET_RX {
            get {
                return this.nET_RXField;
            }
            set {
                this.nET_RXField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public object TEMPLATE {
            get {
                return this.tEMPLATEField;
            }
            set {
                this.tEMPLATEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public object USER_TEMPLATE {
            get {
                return this.uSER_TEMPLATEField;
            }
            set {
                this.uSER_TEMPLATEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArray(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItem(ElementName="HISTORY", IsNullable=false, Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public VMHISTORY_RECORDSHISTORY[] HISTORY_RECORDS {
            get {
                return this.hISTORY_RECORDSField;
            }
            set {
                this.hISTORY_RECORDSField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://opennebula.org/XMLSchema")]
    public partial class VMPERMISSIONS {
        
        private string oWNER_UField;
        
        private string oWNER_MField;
        
        private string oWNER_AField;
        
        private string gROUP_UField;
        
        private string gROUP_MField;
        
        private string gROUP_AField;
        
        private string oTHER_UField;
        
        private string oTHER_MField;
        
        private string oTHER_AField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="integer")]
        public string OWNER_U {
            get {
                return this.oWNER_UField;
            }
            set {
                this.oWNER_UField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="integer")]
        public string OWNER_M {
            get {
                return this.oWNER_MField;
            }
            set {
                this.oWNER_MField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="integer")]
        public string OWNER_A {
            get {
                return this.oWNER_AField;
            }
            set {
                this.oWNER_AField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="integer")]
        public string GROUP_U {
            get {
                return this.gROUP_UField;
            }
            set {
                this.gROUP_UField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="integer")]
        public string GROUP_M {
            get {
                return this.gROUP_MField;
            }
            set {
                this.gROUP_MField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="integer")]
        public string GROUP_A {
            get {
                return this.gROUP_AField;
            }
            set {
                this.gROUP_AField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="integer")]
        public string OTHER_U {
            get {
                return this.oTHER_UField;
            }
            set {
                this.oTHER_UField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="integer")]
        public string OTHER_M {
            get {
                return this.oTHER_MField;
            }
            set {
                this.oTHER_MField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="integer")]
        public string OTHER_A {
            get {
                return this.oTHER_AField;
            }
            set {
                this.oTHER_AField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://opennebula.org/XMLSchema")]
    public partial class VMHISTORY_RECORDSHISTORY {
        
        private string oIDField;
        
        private string sEQField;
        
        private string hOSTNAMEField;
        
        private string hIDField;
        
        private string cIDField;
        
        private string sTIMEField1;
        
        private string eTIMEField1;
        
        private string vMMMADField;
        
        private string vNMMADField;
        
        private string tMMADField;
        
        private string dS_LOCATIONField;
        
        private string dS_IDField;
        
        private string pSTIMEField;
        
        private string pETIMEField;
        
        private string rSTIMEField;
        
        private string rETIMEField;
        
        private string eSTIMEField;
        
        private string eETIMEField;
        
        private string rEASONField;
        
        private string aCTIONField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="integer")]
        public string OID {
            get {
                return this.oIDField;
            }
            set {
                this.oIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="integer")]
        public string SEQ {
            get {
                return this.sEQField;
            }
            set {
                this.sEQField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string HOSTNAME {
            get {
                return this.hOSTNAMEField;
            }
            set {
                this.hOSTNAMEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="integer")]
        public string HID {
            get {
                return this.hIDField;
            }
            set {
                this.hIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="integer")]
        public string CID {
            get {
                return this.cIDField;
            }
            set {
                this.cIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="integer")]
        public string STIME {
            get {
                return this.sTIMEField1;
            }
            set {
                this.sTIMEField1 = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="integer")]
        public string ETIME {
            get {
                return this.eTIMEField1;
            }
            set {
                this.eTIMEField1 = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string VMMMAD {
            get {
                return this.vMMMADField;
            }
            set {
                this.vMMMADField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string VNMMAD {
            get {
                return this.vNMMADField;
            }
            set {
                this.vNMMADField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string TMMAD {
            get {
                return this.tMMADField;
            }
            set {
                this.tMMADField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DS_LOCATION {
            get {
                return this.dS_LOCATIONField;
            }
            set {
                this.dS_LOCATIONField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="integer")]
        public string DS_ID {
            get {
                return this.dS_IDField;
            }
            set {
                this.dS_IDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="integer")]
        public string PSTIME {
            get {
                return this.pSTIMEField;
            }
            set {
                this.pSTIMEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="integer")]
        public string PETIME {
            get {
                return this.pETIMEField;
            }
            set {
                this.pETIMEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="integer")]
        public string RSTIME {
            get {
                return this.rSTIMEField;
            }
            set {
                this.rSTIMEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="integer")]
        public string RETIME {
            get {
                return this.rETIMEField;
            }
            set {
                this.rETIMEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="integer")]
        public string ESTIME {
            get {
                return this.eSTIMEField;
            }
            set {
                this.eSTIMEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="integer")]
        public string EETIME {
            get {
                return this.eETIMEField;
            }
            set {
                this.eETIMEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="integer")]
        public string REASON {
            get {
                return this.rEASONField;
            }
            set {
                this.rEASONField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="integer")]
        public string ACTION {
            get {
                return this.aCTIONField;
            }
            set {
                this.aCTIONField = value;
            }
        }
    }
}
