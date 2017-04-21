// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "CorporationJson.json"
// Version: 1004
// DO NOT MODIFY DIRECTLY - CHANGES WILL BE OVERWRITTEN

using System;
using System.Collections;
using System.Collections.Generic;
using Starcounter.Advanced;
using Starcounter;
using Starcounter.Internal;
using Starcounter.Templates;
using Starcounter.XSON;
#pragma warning disable 0108
#pragma warning disable 1591

namespace Ammad1 {
using __Corporat1__ = global::Ammad1.CorporationJson.JsonByExample;
using _ScTemplate_ = Starcounter.Templates.Template;
using st = Starcounter.Templates;
using s = Starcounter;
using __CoSave__ = global::Ammad1.CorporationJson.Input.Save;
using __CoName__ = global::Ammad1.CorporationJson.Input.Name;
using __CoId__ = global::Ammad1.CorporationJson.Input.Id;
using __CoHtml__ = global::Ammad1.CorporationJson.Input.Html;
using __Corporat2__ = global::Ammad1.CorporationJson.Input;
using _GEN2_ = System.CodeDom.Compiler.GeneratedCodeAttribute;
using __TLong__ = global::Starcounter.Templates.TLong;
using __TString__ = global::Starcounter.Templates.TString;
using __CoSchema__ = global::Ammad1.CorporationJson.JsonByExample.Schema;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json__ = global::Starcounter.Json;
using __Corporat__ = global::Ammad1.CorporationJson;
using _GEN1_ = System.Diagnostics.DebuggerNonUserCodeAttribute;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class CorporationJson_json : s::TemplateAttribute {
}
#line default

#line hidden
public partial class CorporationJson : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __CoSchema__ DefaultTemplate = new __CoSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public CorporationJson() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public CorporationJson(__CoSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __CoSchema__ Template { get { return (__CoSchema__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__Corporat__);
                Properties.ClearExposed();
                Html = Add<__TString__>("Html");
                Html.DefaultValue = "/Ammad1/CorporationJson.html";
                Html.SetCustomAccessors((_p_) => { return ((__Corporat__)_p_).__bf__Html__; }, (_p_, _v_) => { ((__Corporat__)_p_).__bf__Html__ = (System.String)_v_; }, false);
                Id = Add<__TLong__>("Id$");
                Id.DefaultValue = 0L;
                Id.Editable = true;
                Id.SetCustomAccessors((_p_) => { return ((__Corporat__)_p_).__bf__Id__; }, (_p_, _v_) => { ((__Corporat__)_p_).__bf__Id__ = (System.Int64)_v_; }, false);
                Name = Add<__TString__>("Name$");
                Name.DefaultValue = "";
                Name.Editable = true;
                Name.SetCustomAccessors((_p_) => { return ((__Corporat__)_p_).__bf__Name__; }, (_p_, _v_) => { ((__Corporat__)_p_).__bf__Name__ = (System.String)_v_; }, false);
                Save = Add<__TLong__>("Save$");
                Save.DefaultValue = 0L;
                Save.Editable = true;
                Save.SetCustomAccessors((_p_) => { return ((__Corporat__)_p_).__bf__Save__; }, (_p_, _v_) => { ((__Corporat__)_p_).__bf__Save__ = (System.Int64)_v_; }, false);
                Save.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.Save() { App = (CorporationJson)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((CorporationJson)pup).Handle((Input.Save)input); });
            }
            public override object CreateInstance(s.Json parent) { return new __Corporat__(this) { Parent = parent }; }
            public __TString__ Html;
            public __TLong__ Id;
            public __TString__ Name;
            public __TLong__ Save;
        }
        #line default
    }
    #line default
    #line hidden
    private System.String __bf__Html__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Html {
    #line 2 "CorporationJson.json"
        get {
        #line hidden
            return Template.Html.Getter(this); }
        #line 2 "CorporationJson.json"
        set {
        #line hidden
            Template.Html.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__Id__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 Id {
    #line 3 "CorporationJson.json"
        get {
        #line hidden
            return Template.Id.Getter(this); }
        #line 3 "CorporationJson.json"
        set {
        #line hidden
            Template.Id.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__Name__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Name {
    #line 4 "CorporationJson.json"
        get {
        #line hidden
            return Template.Name.Getter(this); }
        #line 4 "CorporationJson.json"
        set {
        #line hidden
            Template.Name.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__Save__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 Save {
    #line 5 "CorporationJson.json"
        get {
        #line hidden
            return Template.Save.Getter(this); }
        #line 5 "CorporationJson.json"
        set {
        #line hidden
            Template.Save.Setter(this, value); } }
        #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
        
        #line hidden
        public class Html : Input<__Corporat__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Id : Input<__Corporat__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class Name : Input<__Corporat__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Save : Input<__Corporat__, __TLong__, long> {
        }
        #line default
    }
    #line default
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108
