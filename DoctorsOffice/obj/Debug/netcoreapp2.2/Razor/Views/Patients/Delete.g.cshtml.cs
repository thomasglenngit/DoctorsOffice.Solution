#pragma checksum "/Users/thomasglenn/Desktop/Csharp/DoctorsOffice.Solution/DoctorsOffice/Views/Patients/Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73f0b1a438174d939c2fa288d4baf85ae153035d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Patients_Delete), @"mvc.1.0.view", @"/Views/Patients/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Patients/Delete.cshtml", typeof(AspNetCore.Views_Patients_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"73f0b1a438174d939c2fa288d4baf85ae153035d", @"/Views/Patients/Delete.cshtml")]
    public class Views_Patients_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DoctorsOffice.Models.Patient>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/thomasglenn/Desktop/Csharp/DoctorsOffice.Solution/DoctorsOffice/Views/Patients/Delete.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(64, 36, true);
            WriteLiteral("\n<h1>Delete Patient</h1>\n<hr />\n<h3>");
            EndContext();
            BeginContext(101, 14, false);
#line 9 "/Users/thomasglenn/Desktop/Csharp/DoctorsOffice.Solution/DoctorsOffice/Views/Patients/Delete.cshtml"
Write(Model.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(115, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(118, 15, false);
#line 9 "/Users/thomasglenn/Desktop/Csharp/DoctorsOffice.Solution/DoctorsOffice/Views/Patients/Delete.cshtml"
                Write(Model.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(133, 53, true);
            WriteLiteral("</h3>\n<h4>Are you sure you want to delete this?</h4>\n");
            EndContext();
#line 11 "/Users/thomasglenn/Desktop/Csharp/DoctorsOffice.Solution/DoctorsOffice/Views/Patients/Delete.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
            BeginContext(214, 66, true);
            WriteLiteral("    <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" />\n");
            EndContext();
#line 14 "/Users/thomasglenn/Desktop/Csharp/DoctorsOffice.Solution/DoctorsOffice/Views/Patients/Delete.cshtml"
}

#line default
#line hidden
            BeginContext(283, 48, false);
#line 15 "/Users/thomasglenn/Desktop/Csharp/DoctorsOffice.Solution/DoctorsOffice/Views/Patients/Delete.cshtml"
Write(Html.ActionLink("Back to Patient List", "Index"));

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DoctorsOffice.Models.Patient> Html { get; private set; }
    }
}
#pragma warning restore 1591
