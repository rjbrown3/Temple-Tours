#pragma checksum "C:\Users\18018\source\repos\TempleTours\Views\Home\ViewAppointments.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6eba0958740efc2d4daeb74ec4abbea56b4d4d50"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ViewAppointments), @"mvc.1.0.view", @"/Views/Home/ViewAppointments.cshtml")]
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
#line 1 "C:\Users\18018\source\repos\TempleTours\Views\_ViewImports.cshtml"
using TempleTours;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\18018\source\repos\TempleTours\Views\_ViewImports.cshtml"
using TempleTours.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\18018\source\repos\TempleTours\Views\_ViewImports.cshtml"
using TempleTours.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6eba0958740efc2d4daeb74ec4abbea56b4d4d50", @"/Views/Home/ViewAppointments.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"632e208ac9e57e3f5eb0e7377172ea757fe92565", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ViewAppointments : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Appointment>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<!--We use the Appointment IEnumerable to run through each instance of the appointments and also output the time objects.
    -->
    <br />
    <br />
    <center>
        <div>
            <table class="" table-hover table-striped table-bordered table-layout: auto"">
                <thead class=""text-center"">
                    <tr>
                        <th>Appointment ID</th>
                        <th>Date</th>
                        <th>Time</th>
                        <th>Group Name</th>

                    </tr>

                </thead>
                <tbody class=""text-center"">
                    <!--our for loop that outputs the appointmentID, date of appointment and groupname  ""dd:hh:mm tt""-->
");
#nullable restore
#line 21 "C:\Users\18018\source\repos\TempleTours\Views\Home\ViewAppointments.cshtml"
                     foreach (var x in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td style=\"background-color:lightblue\">");
#nullable restore
#line 24 "C:\Users\18018\source\repos\TempleTours\Views\Home\ViewAppointments.cshtml"
                                                              Write(x.AppointmentId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 25 "C:\Users\18018\source\repos\TempleTours\Views\Home\ViewAppointments.cshtml"
                           Write(x.Time.Date.ToString("MMMM dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 26 "C:\Users\18018\source\repos\TempleTours\Views\Home\ViewAppointments.cshtml"
                           Write(x.Time.Date.ToString("hh:mm tt"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 27 "C:\Users\18018\source\repos\TempleTours\Views\Home\ViewAppointments.cshtml"
                           Write(x.GroupName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n");
#nullable restore
#line 29 "C:\Users\18018\source\repos\TempleTours\Views\Home\ViewAppointments.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </tbody>\r\n\r\n            </table>\r\n        </div>\r\n    </center>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Appointment>> Html { get; private set; }
    }
}
#pragma warning restore 1591
