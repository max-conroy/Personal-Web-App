#pragma checksum "C:\Users\conroy3644\Documents\Visual Studio 2017\Projects\Max-Conroy-Website\Max-Conroy-Website\Pages\Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ecf6fbbe1e2d276e67e58d00a26218fc876380dd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Max_Conroy_Website.Pages.Pages_Contact), @"mvc.1.0.razor-page", @"/Pages/Contact.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Contact.cshtml", typeof(Max_Conroy_Website.Pages.Pages_Contact), null)]
namespace Max_Conroy_Website.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\conroy3644\Documents\Visual Studio 2017\Projects\Max-Conroy-Website\Max-Conroy-Website\Pages\_ViewImports.cshtml"
using Max_Conroy_Website;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ecf6fbbe1e2d276e67e58d00a26218fc876380dd", @"/Pages/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72a1516465214c184ab2c692033ad8981ea6aefd", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Contact : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\conroy3644\Documents\Visual Studio 2017\Projects\Max-Conroy-Website\Max-Conroy-Website\Pages\Contact.cshtml"
  
    ViewData["Title"] = "Contact";

#line default
#line hidden
            BeginContext(71, 474, true);
            WriteLiteral(@"
<div class=""container-fluid contact-container"">
    <h2>Contact Max</h2> <br />
    <address>
        <strong>Email:</strong> <a href=""mailto:conroy3644@gmail.com"">conroy3644@gmail.com</a> <br /><br />
        <strong>Twitter:</strong> <a href=""https://twitter.com/mxconroy"">https://twitter.com/mxconroy</a> <br /><br />
        <strong>Facebook:</strong> <a href=""https://www.facebook.com/max.conroy"">https://www.facebook.com/max.conroy</a>
    </address>
</div>
");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ContactModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ContactModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ContactModel>)PageContext?.ViewData;
        public ContactModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591