#pragma checksum "C:\Users\sblgn\source\repos\HotelReservation\WebUI\Views\BookingAdmin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dbc9c157290ca01c6210b77805efc00908ed57e4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BookingAdmin_Index), @"mvc.1.0.view", @"/Views/BookingAdmin/Index.cshtml")]
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
#line 1 "C:\Users\sblgn\source\repos\HotelReservation\WebUI\Views\_ViewImports.cshtml"
using WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sblgn\source\repos\HotelReservation\WebUI\Views\_ViewImports.cshtml"
using WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\sblgn\source\repos\HotelReservation\WebUI\Views\_ViewImports.cshtml"
using WebUI.Models.Staff;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\sblgn\source\repos\HotelReservation\WebUI\Views\_ViewImports.cshtml"
using WebUI.Models.Testimonial;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\sblgn\source\repos\HotelReservation\WebUI\Views\_ViewImports.cshtml"
using WebUI.Models.Mail;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\sblgn\source\repos\HotelReservation\WebUI\Views\_ViewImports.cshtml"
using WebUI.Dtos.ServiceDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\sblgn\source\repos\HotelReservation\WebUI\Views\_ViewImports.cshtml"
using WebUI.Dtos.RegisterDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\sblgn\source\repos\HotelReservation\WebUI\Views\_ViewImports.cshtml"
using WebUI.Dtos.LoginDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\sblgn\source\repos\HotelReservation\WebUI\Views\_ViewImports.cshtml"
using WebUI.Dtos.AboutDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\sblgn\source\repos\HotelReservation\WebUI\Views\_ViewImports.cshtml"
using WebUI.Dtos.RoomDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\sblgn\source\repos\HotelReservation\WebUI\Views\_ViewImports.cshtml"
using WebUI.Dtos.TestimonialDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\sblgn\source\repos\HotelReservation\WebUI\Views\_ViewImports.cshtml"
using WebUI.Dtos.StaffDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\sblgn\source\repos\HotelReservation\WebUI\Views\_ViewImports.cshtml"
using WebUI.Dtos.BookingDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\sblgn\source\repos\HotelReservation\WebUI\Views\_ViewImports.cshtml"
using WebUI.Dtos.ContactDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\sblgn\source\repos\HotelReservation\WebUI\Views\_ViewImports.cshtml"
using WebUI.Dtos.GuestDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\sblgn\source\repos\HotelReservation\WebUI\Views\_ViewImports.cshtml"
using WebUI.Dtos.SendMessageDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\sblgn\source\repos\HotelReservation\WebUI\Views\_ViewImports.cshtml"
using WebUI.Dtos.WorkLocationDto;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dbc9c157290ca01c6210b77805efc00908ed57e4", @"/Views/BookingAdmin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f153d6a6325fe61c8ba2cd5dc8fad9cf5f39d258", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_BookingAdmin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ResultBookingDto>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\sblgn\source\repos\HotelReservation\WebUI\Views\BookingAdmin\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/AdminLayout/_AdminLayout.cshtml";
    int count = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            <div class=""table-responsive"">
                <table class=""table"">
                    <thead>
                        <tr>
                            <th>#</th>
                            <th>Quest</th>
                            <th>Login Date</th>
                            <th>LogOut Date</th>
                            <th>Status</th>
                            <th>Approve</th>
                            <th>Cancel</th>
                            <th>Hold On</th>
                            <th>Edit</th>
                            <th>Details</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 25 "C:\Users\sblgn\source\repos\HotelReservation\WebUI\Views\BookingAdmin\Index.cshtml"
                         foreach (var item in Model)
                                {
                                    count++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\n                            <th>");
#nullable restore
#line 29 "C:\Users\sblgn\source\repos\HotelReservation\WebUI\Views\BookingAdmin\Index.cshtml"
                           Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                            <td>");
#nullable restore
#line 30 "C:\Users\sblgn\source\repos\HotelReservation\WebUI\Views\BookingAdmin\Index.cshtml"
                           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 31 "C:\Users\sblgn\source\repos\HotelReservation\WebUI\Views\BookingAdmin\Index.cshtml"
                            Write(((DateTime)item.Checkin).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 32 "C:\Users\sblgn\source\repos\HotelReservation\WebUI\Views\BookingAdmin\Index.cshtml"
                            Write(((DateTime)item.CheckOut).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td><span class=\"badge badge-primary px-2\">");
#nullable restore
#line 33 "C:\Users\sblgn\source\repos\HotelReservation\WebUI\Views\BookingAdmin\Index.cshtml"
                                                                  Write(item.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\n                            <td><a");
            BeginWriteAttribute("href", " href=\"", 1382, "\"", 1438, 2);
            WriteAttributeValue("", 1389, "/BookingAdmin/ApprovedReservation/", 1389, 34, true);
#nullable restore
#line 34 "C:\Users\sblgn\source\repos\HotelReservation\WebUI\Views\BookingAdmin\Index.cshtml"
WriteAttributeValue("", 1423, item.BookingID, 1423, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-outline-primary"">Approved</a></td>
                            <td><a href=""#"" class=""btn btn-outline-danger"">Cancel</a></td>
                            <td><a href=""#"" class=""btn btn-outline-warning"">Hold On</a></td>
                            <td><a href=""#"" class=""btn btn-outline-info"">Edit</a></td>
                            <td><a href=""#"" class=""btn btn-outline-dark"">Details</a></td>
                        </tr>
");
#nullable restore
#line 40 "C:\Users\sblgn\source\repos\HotelReservation\WebUI\Views\BookingAdmin\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\n                </table>\n            </div>\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ResultBookingDto>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
