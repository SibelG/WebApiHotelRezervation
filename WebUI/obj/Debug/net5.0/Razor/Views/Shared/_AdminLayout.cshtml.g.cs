#pragma checksum "C:\Users\sblgn\source\repos\HotelReservation\WebUI\Views\Shared\_AdminLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c7cb840b1aea1c73af08ac6b384cb730c691cd0e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__AdminLayout), @"mvc.1.0.view", @"/Views/Shared/_AdminLayout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7cb840b1aea1c73af08ac6b384cb730c691cd0e", @"/Views/Shared/_AdminLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f153d6a6325fe61c8ba2cd5dc8fad9cf5f39d258", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__AdminLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\n<html lang=\"en\">\n\n");
#nullable restore
#line 4 "C:\Users\sblgn\source\repos\HotelReservation\WebUI\Views\Shared\_AdminLayout.cshtml"
Write(await Html.PartialAsync("/Views/Admin/HeadPartial.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c7cb840b1aea1c73af08ac6b384cb730c691cd0e6255", async() => {
                WriteLiteral("\n\n    <!--*******************\n        Preloader start\n    ********************-->\n    ");
#nullable restore
#line 11 "C:\Users\sblgn\source\repos\HotelReservation\WebUI\Views\Shared\_AdminLayout.cshtml"
Write(await Html.PartialAsync("/Views/Admin/PreloaderPartial.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    <!--*******************
        Preloader end
    ********************-->
    <!--**********************************
        Main wrapper start
    ***********************************-->
    <div id=""main-wrapper"">

        <!--**********************************
            Nav header start
        ***********************************-->
        ");
#nullable restore
#line 23 "C:\Users\sblgn\source\repos\HotelReservation\WebUI\Views\Shared\_AdminLayout.cshtml"
   Write(await Html.PartialAsync("/Views/Admin/NavHeaderPartial.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n        <!--**********************************\n            Nav header end\n        ***********************************-->\n        <!--**********************************\n            Header start\n        ***********************************-->\n       ");
#nullable restore
#line 30 "C:\Users\sblgn\source\repos\HotelReservation\WebUI\Views\Shared\_AdminLayout.cshtml"
  Write(await Html.PartialAsync("/Views/Admin/HeaderPartial.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
        <!--**********************************
            Header end ti-comment-alt
        ***********************************-->
        <!--**********************************
            Sidebar start
        ***********************************-->
       ");
#nullable restore
#line 37 "C:\Users\sblgn\source\repos\HotelReservation\WebUI\Views\Shared\_AdminLayout.cshtml"
  Write(await Html.PartialAsync("/Views/Admin/SideBarHeaderPartial.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
        <!--**********************************
            Sidebar end
        ***********************************-->
        <!--**********************************
            Content body start
        ***********************************-->
        <div class=""content-body"">

            <div class=""row page-titles mx-0"">
                <div class=""col p-md-0"">
                    <ol class=""breadcrumb"">
                        <li class=""breadcrumb-item""><a href=""javascript:void(0)"">Dashboard</a></li>
                        <li class=""breadcrumb-item active""><a href=""javascript:void(0)"">Home</a></li>
                    </ol>
                </div>
            </div>
            <!-- row -->

            <div class=""container-fluid"">
                <div class=""row"">
                    <div class=""col-12"">
                        <div class=""card"">
                            <div class=""card-body"">
                                ");
#nullable restore
#line 61 "C:\Users\sblgn\source\repos\HotelReservation\WebUI\Views\Shared\_AdminLayout.cshtml"
                           Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <!-- #/ container -->
        </div>
        <!--**********************************
            Content body end
        ***********************************-->
        <!--**********************************
            Footer start
        ***********************************-->
        ");
#nullable restore
#line 75 "C:\Users\sblgn\source\repos\HotelReservation\WebUI\Views\Shared\_AdminLayout.cshtml"
   Write(await Html.PartialAsync("/Views/Admin/FooterPartial.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
        <!--**********************************
            Footer end
        ***********************************-->
    </div>
    <!--**********************************
        Main wrapper end
    ***********************************-->
    <!--**********************************
        Scripts

      
    ***********************************-->

    ");
#nullable restore
#line 89 "C:\Users\sblgn\source\repos\HotelReservation\WebUI\Views\Shared\_AdminLayout.cshtml"
Write(await Html.PartialAsync("/Views/Admin/ScriptPartial.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n</html>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
