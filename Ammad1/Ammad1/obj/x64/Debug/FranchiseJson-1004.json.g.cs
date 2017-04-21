// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "FranchiseJson.json"
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
using __FrId__ = global::Ammad1.FranchiseJson.Input.Id;
using _ScTemplate_ = Starcounter.Templates.Template;
using st = Starcounter.Templates;
using s = Starcounter;
using __FrSave__ = global::Ammad1.FranchiseJson.Input.Save;
using __FrAddress__ = global::Ammad1.FranchiseJson.Input.Address;
using __FrCountry__ = global::Ammad1.FranchiseJson.Input.Country;
using __FrCity__ = global::Ammad1.FranchiseJson.Input.City;
using __FrZIPCode__ = global::Ammad1.FranchiseJson.Input.ZIPCode;
using __FrStreet__ = global::Ammad1.FranchiseJson.Input.Street;
using __FrName__ = global::Ammad1.FranchiseJson.Input.Name;
using _GEN1_ = System.Diagnostics.DebuggerNonUserCodeAttribute;
using _GEN2_ = System.CodeDom.Compiler.GeneratedCodeAttribute;
using __Franchis2__ = global::Ammad1.FranchiseJson.Input;
using __Franchis1__ = global::Ammad1.FranchiseJson.JsonByExample;
using __TLong__ = global::Starcounter.Templates.TLong;
using __TString__ = global::Starcounter.Templates.TString;
using __FrSchema__ = global::Ammad1.FranchiseJson.JsonByExample.Schema;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json__ = global::Starcounter.Json;
using __Franchis__ = global::Ammad1.FranchiseJson;
using __FrHtml__ = global::Ammad1.FranchiseJson.Input.Html;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class FranchiseJson_json : s::TemplateAttribute {
}
#line default

#line hidden
public partial class FranchiseJson : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __FrSchema__ DefaultTemplate = new __FrSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public FranchiseJson() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public FranchiseJson(__FrSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __FrSchema__ Template { get { return (__FrSchema__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__Franchis__);
                Properties.ClearExposed();
                Html = Add<__TString__>("Html");
                Html.DefaultValue = "/Ammad1/FranchiseJson.html";
                Html.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__Html__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__Html__ = (System.String)_v_; }, false);
                Id = Add<__TLong__>("Id$");
                Id.DefaultValue = 0L;
                Id.Editable = true;
                Id.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__Id__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__Id__ = (System.Int64)_v_; }, false);
                Name = Add<__TString__>("Name$");
                Name.DefaultValue = "";
                Name.Editable = true;
                Name.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__Name__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__Name__ = (System.String)_v_; }, false);
                Street = Add<__TString__>("Street$");
                Street.DefaultValue = "";
                Street.Editable = true;
                Street.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__Street__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__Street__ = (System.String)_v_; }, false);
                ZIPCode = Add<__TString__>("ZIPCode$");
                ZIPCode.DefaultValue = "";
                ZIPCode.Editable = true;
                ZIPCode.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__ZIPCode__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__ZIPCode__ = (System.String)_v_; }, false);
                City = Add<__TString__>("City$");
                City.DefaultValue = "";
                City.Editable = true;
                City.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__City__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__City__ = (System.String)_v_; }, false);
                Country = Add<__TString__>("Country$");
                Country.DefaultValue = "";
                Country.Editable = true;
                Country.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__Country__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__Country__ = (System.String)_v_; }, false);
                Address = Add<__TString__>("Address$");
                Address.DefaultValue = "";
                Address.Editable = true;
                Address.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__Address__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__Address__ = (System.String)_v_; }, false);
                Save = Add<__TLong__>("Save$");
                Save.DefaultValue = 0L;
                Save.Editable = true;
                Save.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__Save__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__Save__ = (System.Int64)_v_; }, false);
                Save.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.Save() { App = (FranchiseJson)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((FranchiseJson)pup).Handle((Input.Save)input); });
            }
            public override object CreateInstance(s.Json parent) { return new __Franchis__(this) { Parent = parent }; }
            public __TString__ Html;
            public __TLong__ Id;
            public __TString__ Name;
            public __TString__ Street;
            public __TString__ ZIPCode;
            public __TString__ City;
            public __TString__ Country;
            public __TString__ Address;
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
    #line 2 "FranchiseJson.json"
        get {
        #line hidden
            return Template.Html.Getter(this); }
        #line 2 "FranchiseJson.json"
        set {
        #line hidden
            Template.Html.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__Id__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 Id {
    #line 3 "FranchiseJson.json"
        get {
        #line hidden
            return Template.Id.Getter(this); }
        #line 3 "FranchiseJson.json"
        set {
        #line hidden
            Template.Id.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__Name__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Name {
    #line 4 "FranchiseJson.json"
        get {
        #line hidden
            return Template.Name.Getter(this); }
        #line 4 "FranchiseJson.json"
        set {
        #line hidden
            Template.Name.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__Street__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Street {
    #line 5 "FranchiseJson.json"
        get {
        #line hidden
            return Template.Street.Getter(this); }
        #line 5 "FranchiseJson.json"
        set {
        #line hidden
            Template.Street.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__ZIPCode__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String ZIPCode {
    #line 6 "FranchiseJson.json"
        get {
        #line hidden
            return Template.ZIPCode.Getter(this); }
        #line 6 "FranchiseJson.json"
        set {
        #line hidden
            Template.ZIPCode.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__City__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String City {
    #line 7 "FranchiseJson.json"
        get {
        #line hidden
            return Template.City.Getter(this); }
        #line 7 "FranchiseJson.json"
        set {
        #line hidden
            Template.City.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__Country__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Country {
    #line 8 "FranchiseJson.json"
        get {
        #line hidden
            return Template.Country.Getter(this); }
        #line 8 "FranchiseJson.json"
        set {
        #line hidden
            Template.Country.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__Address__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Address {
    #line 9 "FranchiseJson.json"
        get {
        #line hidden
            return Template.Address.Getter(this); }
        #line 9 "FranchiseJson.json"
        set {
        #line hidden
            Template.Address.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__Save__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 Save {
    #line 10 "FranchiseJson.json"
        get {
        #line hidden
            return Template.Save.Getter(this); }
        #line 10 "FranchiseJson.json"
        set {
        #line hidden
            Template.Save.Setter(this, value); } }
        #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
        
        #line hidden
        public class Html : Input<__Franchis__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Id : Input<__Franchis__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class Name : Input<__Franchis__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Street : Input<__Franchis__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class ZIPCode : Input<__Franchis__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class City : Input<__Franchis__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Country : Input<__Franchis__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Address : Input<__Franchis__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Save : Input<__Franchis__, __TLong__, long> {
        }
        #line default
    }
    #line default
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108
