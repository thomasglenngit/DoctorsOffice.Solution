#pragma checksum "/Users/thomasglenn/Desktop/Csharp/DoctorsOffice.Solution/DoctorsOffice/Views/Doctors/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ea82729583e2383bc420af8f1b7adee678173bb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Doctors_Details), @"mvc.1.0.view", @"/Views/Doctors/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Doctors/Details.cshtml", typeof(AspNetCore.Views_Doctors_Details))]
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
#line 5 "/Users/thomasglenn/Desktop/Csharp/DoctorsOffice.Solution/DoctorsOffice/Views/Doctors/Details.cshtml"
using DoctorsOffice.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ea82729583e2383bc420af8f1b7adee678173bb", @"/Views/Doctors/Details.cshtml")]
    public class Views_Doctors_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DoctorsOffice.Models.Doctor>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/thomasglenn/Desktop/Csharp/DoctorsOffice.Solution/DoctorsOffice/Views/Doctors/Details.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(93, 36, true);
            WriteLiteral("\n<h2>Doctor Details</h2>\n<hr />\n<h3>");
            EndContext();
            BeginContext(130, 15, false);
#line 10 "/Users/thomasglenn/Desktop/Csharp/DoctorsOffice.Solution/DoctorsOffice/Views/Doctors/Details.cshtml"
Write(Model.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(145, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(147, 14, false);
#line 10 "/Users/thomasglenn/Desktop/Csharp/DoctorsOffice.Solution/DoctorsOffice/Views/Doctors/Details.cshtml"
                Write(Model.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(161, 12, true);
            WriteLiteral("</h3>\n\n<ul>\n");
            EndContext();
#line 13 "/Users/thomasglenn/Desktop/Csharp/DoctorsOffice.Solution/DoctorsOffice/Views/Doctors/Details.cshtml"
 if (@Model.Patients.Count == 0)
{

#line default
#line hidden
            BeginContext(208, 52, true);
            WriteLiteral("  <p>This Doctor does not contain any patients.</p>\n");
            EndContext();
#line 16 "/Users/thomasglenn/Desktop/Csharp/DoctorsOffice.Solution/DoctorsOffice/Views/Doctors/Details.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(269, 48, true);
            WriteLiteral("  <h4>Patients the Doctor contains:</h4>\n  <ul>\n");
            EndContext();
#line 21 "/Users/thomasglenn/Desktop/Csharp/DoctorsOffice.Solution/DoctorsOffice/Views/Doctors/Details.cshtml"
   foreach(var join in Model.Patients)
  {

#line default
#line hidden
            BeginContext(360, 8, true);
            WriteLiteral("    <li>");
            EndContext();
            BeginContext(369, 21, false);
#line 23 "/Users/thomasglenn/Desktop/Csharp/DoctorsOffice.Solution/DoctorsOffice/Views/Doctors/Details.cshtml"
   Write(join.Patient.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(390, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(393, 22, false);
#line 23 "/Users/thomasglenn/Desktop/Csharp/DoctorsOffice.Solution/DoctorsOffice/Views/Doctors/Details.cshtml"
                           Write(join.Patient.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(415, 6, true);
            WriteLiteral("</li>\n");
            EndContext();
#line 24 "/Users/thomasglenn/Desktop/Csharp/DoctorsOffice.Solution/DoctorsOffice/Views/Doctors/Details.cshtml"
  }

#line default
#line hidden
            BeginContext(425, 8, true);
            WriteLiteral("  </ul>\n");
            EndContext();
#line 26 "/Users/thomasglenn/Desktop/Csharp/DoctorsOffice.Solution/DoctorsOffice/Views/Doctors/Details.cshtml"

}

#line default
#line hidden
            BeginContext(436, 4, true);
            WriteLiteral("\n<p>");
            EndContext();
            BeginContext(441, 43, false);
#line 29 "/Users/thomasglenn/Desktop/Csharp/DoctorsOffice.Solution/DoctorsOffice/Views/Doctors/Details.cshtml"
Write(Html.ActionLink("Back to doctors", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(484, 8, true);
            WriteLiteral("</p>\n<p>");
            EndContext();
            BeginContext(493, 67, false);
#line 30 "/Users/thomasglenn/Desktop/Csharp/DoctorsOffice.Solution/DoctorsOffice/Views/Doctors/Details.cshtml"
Write(Html.ActionLink("Edit Doctor", "Edit", new { id = Model.DoctorId }));

#line default
#line hidden
            EndContext();
            BeginContext(560, 8, true);
            WriteLiteral("</p>\n<p>");
            EndContext();
            BeginContext(569, 79, false);
#line 31 "/Users/thomasglenn/Desktop/Csharp/DoctorsOffice.Solution/DoctorsOffice/Views/Doctors/Details.cshtml"
Write(Html.ActionLink("Add a Specialty", "AddSpecialty", new { id = Model.DoctorId }));

#line default
#line hidden
            EndContext();
            BeginContext(648, 8, true);
            WriteLiteral("</p>\n<p>");
            EndContext();
            BeginContext(657, 71, false);
#line 32 "/Users/thomasglenn/Desktop/Csharp/DoctorsOffice.Solution/DoctorsOffice/Views/Doctors/Details.cshtml"
Write(Html.ActionLink("Delete Doctor", "Delete", new { id = Model.DoctorId }));

#line default
#line hidden
            EndContext();
            BeginContext(728, 4, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DoctorsOffice.Models.Doctor> Html { get; private set; }
    }
}
#pragma warning restore 1591
