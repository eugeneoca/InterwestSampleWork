#pragma checksum "D:\softwaredev\InterwestWebContactPage\Views\Contact\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76d5edb3457bee4fb2953678178f30f39d3df2b6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_Index), @"mvc.1.0.view", @"/Views/Contact/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\softwaredev\InterwestWebContactPage\Views\_ViewImports.cshtml"
using InterwestWebContactPage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\softwaredev\InterwestWebContactPage\Views\_ViewImports.cshtml"
using InterwestWebContactPage.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76d5edb3457bee4fb2953678178f30f39d3df2b6", @"/Views/Contact/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aaa706a246fb8d83476b388a99618a42688147b2", @"/Views/_ViewImports.cshtml")]
    public class Views_Contact_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""mb-3"">
    <div class=""row"">
        <div class=""col"">
            <label for=""txt_firstname"" class=""form-label"">First Name</label>
            <input type=""email"" class=""form-control"" id=""txt_firstname"" placeholder=""John"">
        </div>
        <div class=""col"">
            <label for=""txt_lastname"" class=""form-label"">Last Name</label>
            <input type=""email"" class=""form-control"" id=""txt_lastname"" placeholder=""Doe"">
        </div>
    </div>
    
</div>
<div class=""mb-3"">
    <label for=""txt_address"" class=""form-label"">Address</label>
    <input type=""text"" class=""form-control"" id=""txt_address"">
</div>

<div class=""mb-3"">
    <label for=""txt_state"" class=""form-label"">State</label>
    <input type=""text"" class=""form-control"" id=""txt_state"">
</div>

<div class=""mb-3"">
    <label for=""txt_country"" class=""form-label"">Country</label>
    <input type=""text"" class=""form-control"" id=""txt_country"">
</div>

<div class=""mb-3"">
    <label for=""txt_zipcode"" class=""form-");
            WriteLiteral(@"label"">Zip Code</label>
    <input type=""text"" class=""form-control"" id=""txt_zipcode"">
</div>

<div class=""mb-3"">
    <label for=""txt_phone"" class=""form-label"">Phone Number</label>
    <input type=""number"" class=""form-control"" id=""txt_phone"">
</div>

<div class=""mb-3"">
    <label for=""txt_note"" class=""form-label"">Note</label>
    <textarea class=""form-control"" id=""txt_note"" rows=""3"" maxlength=""250""></textarea>
</div>


<div class=""mb-3 text-center"">
    <button type=""button"" class=""btn btn-primary mt-3"">Submit</button>
</div>
");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
