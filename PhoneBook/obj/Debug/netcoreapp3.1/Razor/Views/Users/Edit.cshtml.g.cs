#pragma checksum "C:\Users\Коко\source\repos\PhoneBook\PhoneBook\Views\Users\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "85bbdd564e46e065670a4877e14cdf8b6bd229b3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Edit), @"mvc.1.0.view", @"/Views/Users/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85bbdd564e46e065670a4877e14cdf8b6bd229b3", @"/Views/Users/Edit.cshtml")]
    public class Views_Users_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PhoneBook.ViewModels.Users.UsersEditVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Коко\source\repos\PhoneBook\PhoneBook\Views\Users\Edit.cshtml"
  
    ViewData["Title"] = "Edit User";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<fieldset>\r\n    <legend>Edit User</legend>\r\n    <form action=\"/Users/Edit\" method=\"post\">\r\n        ");
#nullable restore
#line 10 "C:\Users\Коко\source\repos\PhoneBook\PhoneBook\Views\Users\Edit.cshtml"
   Write(Html.HiddenFor(m=>m.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"grid\">\r\n            <div class=\"row\">\r\n                <div class=\"col-1\">Username:</div>\r\n                <div class=\"col-2\">");
#nullable restore
#line 14 "C:\Users\Коко\source\repos\PhoneBook\PhoneBook\Views\Users\Edit.cshtml"
                              Write(Html.TextBoxFor(m => m.Username));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                <div class=\"col-2\">");
#nullable restore
#line 15 "C:\Users\Коко\source\repos\PhoneBook\PhoneBook\Views\Users\Edit.cshtml"
                              Write(Html.ValidationMessageFor(m => m.Username));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"col-1\">Password:</div>\r\n                <div class=\"col-2\">");
#nullable restore
#line 19 "C:\Users\Коко\source\repos\PhoneBook\PhoneBook\Views\Users\Edit.cshtml"
                              Write(Html.PasswordFor(m => m.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                <div class=\"col-2\">");
#nullable restore
#line 20 "C:\Users\Коко\source\repos\PhoneBook\PhoneBook\Views\Users\Edit.cshtml"
                              Write(Html.ValidationMessageFor(m => m.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"col-1\">First Name:</div>\r\n                <div class=\"col-2\">");
#nullable restore
#line 24 "C:\Users\Коко\source\repos\PhoneBook\PhoneBook\Views\Users\Edit.cshtml"
                              Write(Html.TextBoxFor(m => m.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                <div class=\"col-2\">");
#nullable restore
#line 25 "C:\Users\Коко\source\repos\PhoneBook\PhoneBook\Views\Users\Edit.cshtml"
                              Write(Html.ValidationMessageFor(m => m.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"col-1\">Last Name:</div>\r\n                <div class=\"col-2\">");
#nullable restore
#line 29 "C:\Users\Коко\source\repos\PhoneBook\PhoneBook\Views\Users\Edit.cshtml"
                              Write(Html.TextBoxFor(m => m.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                <div class=\"col-2\">");
#nullable restore
#line 30 "C:\Users\Коко\source\repos\PhoneBook\PhoneBook\Views\Users\Edit.cshtml"
                              Write(Html.ValidationMessageFor(m => m.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
            </div>
            <div class=""row"">
                <div class=""col-3"">
                    <input type=""submit"" value=""Save"" />
                    <a href=""/Users/Index"">back</a>
                </div>
            </div>
        </div>
    </form>
</fieldset>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PhoneBook.ViewModels.Users.UsersEditVM> Html { get; private set; }
    }
}
#pragma warning restore 1591