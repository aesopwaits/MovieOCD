﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.296
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=4.0.30319.1.
// 
namespace MovieOCD.Models
{
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class catalog_titles {
        
        private catalog_titlesLink[] linkField;
        
        private string url_templateField;
        
        private ushort number_of_resultsField;
        
        private byte start_indexField;
        
        private byte results_per_pageField;
        
        private catalog_titlesCatalog_title[] catalog_titleField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("link")]
        public catalog_titlesLink[] link {
            get {
                return this.linkField;
            }
            set {
                this.linkField = value;
            }
        }
        
        /// <remarks/>
        public string url_template {
            get {
                return this.url_templateField;
            }
            set {
                this.url_templateField = value;
            }
        }
        
        /// <remarks/>
        public ushort number_of_results {
            get {
                return this.number_of_resultsField;
            }
            set {
                this.number_of_resultsField = value;
            }
        }
        
        /// <remarks/>
        public byte start_index {
            get {
                return this.start_indexField;
            }
            set {
                this.start_indexField = value;
            }
        }
        
        /// <remarks/>
        public byte results_per_page {
            get {
                return this.results_per_pageField;
            }
            set {
                this.results_per_pageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("catalog_title")]
        public catalog_titlesCatalog_title[] catalog_title {
            get {
                return this.catalog_titleField;
            }
            set {
                this.catalog_titleField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class catalog_titlesLink {
        
        private string hrefField;
        
        private string relField;
        
        private string titleField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string href {
            get {
                return this.hrefField;
            }
            set {
                this.hrefField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string rel {
            get {
                return this.relField;
            }
            set {
                this.relField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string title {
            get {
                return this.titleField;
            }
            set {
                this.titleField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class catalog_titlesCatalog_title {
        
        private object[] itemsField;
        
        private ItemsChoiceType[] itemsElementNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("average_rating", typeof(decimal))]
        [System.Xml.Serialization.XmlElementAttribute("box_art", typeof(catalog_titlesCatalog_titleBox_art))]
        [System.Xml.Serialization.XmlElementAttribute("category", typeof(catalog_titlesCatalog_titleCategory))]
        [System.Xml.Serialization.XmlElementAttribute("id", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("link", typeof(catalog_titlesCatalog_titleLink))]
        [System.Xml.Serialization.XmlElementAttribute("release_year", typeof(int))]
        [System.Xml.Serialization.XmlElementAttribute("runtime", typeof(int))]
        [System.Xml.Serialization.XmlElementAttribute("title", typeof(catalog_titlesCatalog_titleTitle))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType[] ItemsElementName {
            get {
                return this.itemsElementNameField;
            }
            set {
                this.itemsElementNameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class catalog_titlesCatalog_titleBox_art {
        
        private string smallField;
        
        private string mediumField;
        
        private string largeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string small {
            get {
                return this.smallField;
            }
            set {
                this.smallField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string medium {
            get {
                return this.mediumField;
            }
            set {
                this.mediumField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string large {
            get {
                return this.largeField;
            }
            set {
                this.largeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class catalog_titlesCatalog_titleCategory {
        
        private string schemeField;
        
        private string labelField;
        
        private string termField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string scheme {
            get {
                return this.schemeField;
            }
            set {
                this.schemeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string label {
            get {
                return this.labelField;
            }
            set {
                this.labelField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string term {
            get {
                return this.termField;
            }
            set {
                this.termField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class catalog_titlesCatalog_titleLink {
        
        private string hrefField;
        
        private string relField;
        
        private string titleField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string href {
            get {
                return this.hrefField;
            }
            set {
                this.hrefField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string rel {
            get {
                return this.relField;
            }
            set {
                this.relField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string title {
            get {
                return this.titleField;
            }
            set {
                this.titleField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class catalog_titlesCatalog_titleTitle {
        
        private string shortField;
        
        private string regularField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string @short {
            get {
                return this.shortField;
            }
            set {
                this.shortField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string regular {
            get {
                return this.regularField;
            }
            set {
                this.regularField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(IncludeInSchema=false)]
    public enum ItemsChoiceType {

        /// <remarks/>
        id,

        /// <remarks/>
        title,

        /// <remarks/>
        average_rating,

        /// <remarks/>
        box_art,

        /// <remarks/>
        link,

        /// <remarks/>
        release_year,

        /// <remarks/>
        category,
       
               
        /// <remarks/>
        runtime
    }
}