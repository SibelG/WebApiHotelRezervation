#pragma checksum "C:\Users\sblgn\source\repos\HotelReservation\WebUI\Views\Shared\Components\_TeamPartial\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "97a25728c826d588cafaf45059700093e10e4027"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__TeamPartial_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_TeamPartial/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"97a25728c826d588cafaf45059700093e10e4027", @"/Views/Shared/Components/_TeamPartial/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f153d6a6325fe61c8ba2cd5dc8fad9cf5f39d258", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components__TeamPartial_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ResultStaffDto>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""container-xxl py-5"">
    <div class=""container"">
        <div class=""text-center wow fadeInUp"" data-wow-delay=""0.1s"">
            <h6 class=""section-title text-center text-primary text-uppercase"">Our Teams</h6>
            <h1 class=""mb-5"">Explore Our <span class=""text-primary text-uppercase"">Staffs</span></h1>
        </div>
        <div class=""row g-4"">
");
#nullable restore
#line 9 "C:\Users\sblgn\source\repos\HotelReservation\WebUI\Views\Shared\Components\_TeamPartial\Default.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-lg-3 col-md-6 wow fadeInUp\" data-wow-delay=\"0.1s\">\n                <div class=\"rounded shadow overflow-hidden\">\n                    <div class=\"position-relative\">\n                        <img class=\"img-fluid\"");
            BeginWriteAttribute("src", " src=\"", 691, "\"", 715, 1);
#nullable restore
#line 14 "C:\Users\sblgn\source\repos\HotelReservation\WebUI\Views\Shared\Components\_TeamPartial\Default.cshtml"
WriteAttributeValue("", 697, item.SocialMedia1, 697, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 716, "\"", 722, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                        <div class=\"position-absolute start-50 top-100 translate-middle d-flex align-items-center\">\n                            <a class=\"btn btn-square btn-primary mx-1\"");
            BeginWriteAttribute("href", " href=\"", 911, "\"", 918, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fab fa-facebook-f\"></i></a>\n                            <a class=\"btn btn-square btn-primary mx-1\"");
            BeginWriteAttribute("href", " href=\"", 1028, "\"", 1035, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fab fa-twitter\"></i></a>\n                            <a class=\"btn btn-square btn-primary mx-1\"");
            BeginWriteAttribute("href", " href=\"", 1142, "\"", 1149, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fab fa-instagram\"></i></a>\n                        </div>\n                    </div>\n                    <div class=\"text-center p-4 mt-3\">\n                        <h5 class=\"fw-bold mb-0\">");
#nullable restore
#line 22 "C:\Users\sblgn\source\repos\HotelReservation\WebUI\Views\Shared\Components\_TeamPartial\Default.cshtml"
                                            Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                        <small>");
#nullable restore
#line 23 "C:\Users\sblgn\source\repos\HotelReservation\WebUI\Views\Shared\Components\_TeamPartial\Default.cshtml"
                          Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\n                    </div>\n                </div>\n            </div>\n");
#nullable restore
#line 27 "C:\Users\sblgn\source\repos\HotelReservation\WebUI\Views\Shared\Components\_TeamPartial\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ResultStaffDto>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591