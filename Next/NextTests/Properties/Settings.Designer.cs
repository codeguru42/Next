﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18047
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NextTests.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?><InstrumentMatch xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance""><Type>A</Type><Identifier>100</Identifier><Currency>SEK</Currency><MainMarketId>0</MainMarketId><Longname>Ericsson A</Longname><MarketID>11</MarketID><Country>SE</Country><Shortname>ERIC A</Shortname><Marketname>OMX Stockholm</Marketname><IsinCode>SE0000108649</IsinCode></InstrumentMatch>")]
        public global::Next.Dtos.InstrumentMatch EricssonInstrumentMatch {
            get {
                return ((global::Next.Dtos.InstrumentMatch)(this["EricssonInstrumentMatch"]));
            }
        }
    }
}
