﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Nop.Plugin.Tax.Exactor.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Nop.Plugin.Tax.Exactor.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&apos;1.0&apos; encoding=&apos;UTF-8&apos;?&gt;
        ///&lt;TaxRequest xmlns=&apos;http://www.exactor.com/ns&apos;&gt;
        ///  &lt;MerchantId xmlns=&quot;http://www.exactor.com/ns&quot;&gt;{0}&lt;/MerchantId&gt;
        ///  &lt;UserId xmlns=&quot;http://www.exactor.com/ns&quot;&gt;{1}&lt;/UserId&gt;
        ///  &lt;InvoiceRequest xmlns=&quot;http://www.exactor.com/ns&quot;&gt;   
        ///    &lt;ShipTo&gt;
        ///      &lt;FullName&gt;{2}&lt;/FullName&gt;
        ///      &lt;Street1&gt;{3}&lt;/Street1&gt;
        ///      &lt;City&gt;{4}&lt;/City&gt;
        ///      &lt;StateOrProvince&gt;{5}&lt;/StateOrProvince&gt;
        ///      &lt;PostalCode&gt;{6}&lt;/PostalCode&gt;
        ///      &lt;Country&gt;{7}&lt;/Country&gt;
        ///    &lt;/ShipTo&gt;
        ///    &lt;LineItem id [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string taxRequest {
            get {
                return ResourceManager.GetString("taxRequest", resourceCulture);
            }
        }
    }
}
