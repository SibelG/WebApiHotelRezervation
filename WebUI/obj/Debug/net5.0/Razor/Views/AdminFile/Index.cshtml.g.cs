#pragma checksum "C:\Users\sblgn\source\repos\HotelReservation\WebUI\Views\AdminFile\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "982c7a758cc25f3739cb8d00ec70f47a63b6a1e4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminFile_Index), @"mvc.1.0.view", @"/Views/AdminFile/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"982c7a758cc25f3739cb8d00ec70f47a63b6a1e4", @"/Views/AdminFile/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f153d6a6325fe61c8ba2cd5dc8fad9cf5f39d258", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_AdminFile_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 2 "C:\Users\sblgn\source\repos\HotelReservation\WebUI\Views\AdminFile\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/AdminLayout/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "982c7a758cc25f3739cb8d00ec70f47a63b6a1e47014", async() => {
                WriteLiteral("\n    <input type=\"file\" name=\"file\" class=\"form-control\" />\n    <br />\n    <button class=\"btn btn-primary\">Dosyayı Yükle</button>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
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
