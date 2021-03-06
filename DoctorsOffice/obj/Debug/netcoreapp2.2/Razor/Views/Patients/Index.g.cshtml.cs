#pragma checksum "/Users/thomasglenn/Desktop/Csharp/DoctorsOffice.Solution/DoctorsOffice/Views/Patients/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "48eebea5d07370c71ddbfb0a7a1d64dc41b2f256"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Patients_Index), @"mvc.1.0.view", @"/Views/Patients/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Patients/Index.cshtml", typeof(AspNetCore.Views_Patients_Index))]
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
#line 5 "/Users/thomasglenn/Desktop/Csharp/DoctorsOffice.Solution/DoctorsOffice/Views/Patients/Index.cshtml"
using DoctorsOffice.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48eebea5d07370c71ddbfb0a7a1d64dc41b2f256", @"/Views/Patients/Index.cshtml")]
    public class Views_Patients_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<DoctorsOffice.Models.Patient>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/thomasglenn/Desktop/Csharp/DoctorsOffice.Solution/DoctorsOffice/Views/Patients/Index.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(100, 27, true);
            WriteLiteral("\n<h1>Patients</h1>\n<hr />\n\n");
            EndContext();
#line 11 "/Users/thomasglenn/Desktop/Csharp/DoctorsOffice.Solution/DoctorsOffice/Views/Patients/Index.cshtml"
 if (@Model.Count == 0)
{

#line default
#line hidden
            BeginContext(153, 43, true);
            WriteLiteral("  <h3>No Patients Have Been Added Yet</h3>\n");
            EndContext();
#line 14 "/Users/thomasglenn/Desktop/Csharp/DoctorsOffice.Solution/DoctorsOffice/Views/Patients/Index.cshtml"
}

#line default
#line hidden
            BeginContext(198, 19, true);
            WriteLiteral("\n<h3>Patients</h3>\n");
            EndContext();
#line 17 "/Users/thomasglenn/Desktop/Csharp/DoctorsOffice.Solution/DoctorsOffice/Views/Patients/Index.cshtml"
 foreach (Patient patient in Model)
{

#line default
#line hidden
            BeginContext(255, 31, true);
            WriteLiteral("  <div class=\"patient\">\n    <p>");
            EndContext();
            BeginContext(287, 101, false);
#line 20 "/Users/thomasglenn/Desktop/Csharp/DoctorsOffice.Solution/DoctorsOffice/Views/Patients/Index.cshtml"
  Write(Html.ActionLink($"{patient.LastName}, {patient.FirstName}", "Details", new { id = patient.PatientId}));

#line default
#line hidden
            EndContext();
            BeginContext(388, 14, true);
            WriteLiteral("</p>\n  </div>\n");
            EndContext();
#line 22 "/Users/thomasglenn/Desktop/Csharp/DoctorsOffice.Solution/DoctorsOffice/Views/Patients/Index.cshtml"
}

#line default
#line hidden
            BeginContext(404, 11, true);
            WriteLiteral("\n<hr />\n<p>");
            EndContext();
            BeginContext(416, 40, false);
#line 25 "/Users/thomasglenn/Desktop/Csharp/DoctorsOffice.Solution/DoctorsOffice/Views/Patients/Index.cshtml"
Write(Html.ActionLink("Add Patient", "Create"));

#line default
#line hidden
            EndContext();
            BeginContext(456, 8, true);
            WriteLiteral("</p>\n<p>");
            EndContext();
            BeginContext(465, 40, false);
#line 26 "/Users/thomasglenn/Desktop/Csharp/DoctorsOffice.Solution/DoctorsOffice/Views/Patients/Index.cshtml"
Write(Html.ActionLink("Home", "Index", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(505, 4, true);
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<DoctorsOffice.Models.Patient>> Html { get; private set; }
    }
}
#pragma warning restore 1591
