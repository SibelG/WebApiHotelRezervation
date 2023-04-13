#pragma checksum "C:\Users\sblgn\source\repos\HotelReservation\WebUI\Views\Shared\Components\_OurRoomsPartial\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ed2323f3398b01a831834a6c5b6f6846e38cc5f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__OurRoomsPartial_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_OurRoomsPartial/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ed2323f3398b01a831834a6c5b6f6846e38cc5f", @"/Views/Shared/Components/_OurRoomsPartial/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f153d6a6325fe61c8ba2cd5dc8fad9cf5f39d258", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components__OurRoomsPartial_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ResultRoomDto>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""container-xxl py-5"">
    <div class=""container"">
        <div class=""text-center wow fadeInUp"" data-wow-delay=""0.1s"">
            <h6 class=""section-title text-center text-primary text-uppercase"">Our Rooms</h6>
            <h1 class=""mb-5"">Odalarımızı <span class=""text-primary text-uppercase"">Explore Our</span></h1>
        </div>
        <div class=""row g-4"">
");
#nullable restore
#line 9 "C:\Users\sblgn\source\repos\HotelReservation\WebUI\Views\Shared\Components\_OurRoomsPartial\Default.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-lg-4 col-md-6 wow fadeInUp\" data-wow-delay=\"0.1s\">\n                <div class=\"room-item shadow rounded overflow-hidden\">\n                    <div class=\"position-relative\">\n                        <img class=\"img-fluid\"");
            BeginWriteAttribute("src", " src=\"", 705, "\"", 731, 1);
#nullable restore
#line 14 "C:\Users\sblgn\source\repos\HotelReservation\WebUI\Views\Shared\Components\_OurRoomsPartial\Default.cshtml"
WriteAttributeValue("", 711, item.RoomCoverImage, 711, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 732, "\"", 738, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                        <small class=\"position-absolute start-0 top-100 translate-middle-y bg-primary text-white rounded py-1 px-3 ms-4\">");
#nullable restore
#line 15 "C:\Users\sblgn\source\repos\HotelReservation\WebUI\Views\Shared\Components\_OurRoomsPartial\Default.cshtml"
                                                                                                                                    Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ₺/Gece</small>\n                    </div>\n                    <div class=\"p-4 mt-2\">\n                        <div class=\"d-flex justify-content-between mb-3\">\n                            <h5 class=\"mb-0\">");
#nullable restore
#line 19 "C:\Users\sblgn\source\repos\HotelReservation\WebUI\Views\Shared\Components\_OurRoomsPartial\Default.cshtml"
                                        Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
                            <div class=""ps-2"">
                                <small class=""fa fa-star text-primary""></small>
                                <small class=""fa fa-star text-primary""></small>
                                <small class=""fa fa-star text-primary""></small>
                                <small class=""fa fa-star text-primary""></small>
                                <small class=""fa fa-star text-primary""></small>
                            </div>
                        </div>
                        <div class=""d-flex mb-3"">
                            <small class=""border-end me-3 pe-3""><i class=""fa fa-bed text-primary me-2""></i>");
#nullable restore
#line 29 "C:\Users\sblgn\source\repos\HotelReservation\WebUI\Views\Shared\Components\_OurRoomsPartial\Default.cshtml"
                                                                                                      Write(item.BedCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Bed</small>\n                            <small class=\"border-end me-3 pe-3\"><i class=\"fa fa-bath text-primary me-2\"></i>");
#nullable restore
#line 30 "C:\Users\sblgn\source\repos\HotelReservation\WebUI\Views\Shared\Components\_OurRoomsPartial\Default.cshtml"
                                                                                                       Write(item.BathCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Bath</small>\n                            <small><i class=\"fa fa-wifi text-primary me-2\"></i>Wifi</small>\n                        </div>\n                        <p class=\"text-body mb-3\">");
#nullable restore
#line 33 "C:\Users\sblgn\source\repos\HotelReservation\WebUI\Views\Shared\Components\_OurRoomsPartial\Default.cshtml"
                                             Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                        <div class=""d-flex justify-content-between"">
                            <a class=""btn btn-sm btn-primary rounded py-2 px-4"" href=""/Booking/Index/"">View Detail</a>
                            <a class=""btn btn-sm btn-dark rounded py-2 px-4"" href=""/Booking/Index/"">Book Now</a>
                        </div>
                    </div>
                </div>
            </div>
");
#nullable restore
#line 41 "C:\Users\sblgn\source\repos\HotelReservation\WebUI\Views\Shared\Components\_OurRoomsPartial\Default.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ResultRoomDto>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591