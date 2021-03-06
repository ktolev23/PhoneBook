#pragma checksum "C:\Users\Коко\source\repos\PhoneBook\PhoneBook\Views\Contacts\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da16215e8592b43332603077bd78583e370d9fbf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contacts_Index), @"mvc.1.0.view", @"/Views/Contacts/Index.cshtml")]
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
#line 2 "C:\Users\Коко\source\repos\PhoneBook\PhoneBook\Views\Contacts\Index.cshtml"
using PhoneBook.Entity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da16215e8592b43332603077bd78583e370d9fbf", @"/Views/Contacts/Index.cshtml")]
    public class Views_Contacts_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PhoneBook.ViewModels.Contacts.ContactsIndexVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Коко\source\repos\PhoneBook\PhoneBook\Views\Contacts\Index.cshtml"
  
    ViewData["Title"] = "Contacts Management";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<a href=\"/Contacts/Create\">New Contact</a>\r\n\r\n<div class=\"grid\">\r\n    <div class=\"row\">\r\n        <div class=\"col-2\">First Name</div>\r\n        <div class=\"col-2\">Last Name</div>\r\n        <div class=\"col-2\">Email</div>\r\n    </div>\r\n");
#nullable restore
#line 16 "C:\Users\Коко\source\repos\PhoneBook\PhoneBook\Views\Contacts\Index.cshtml"
     foreach (Contact item in Model.Items)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row\">\r\n            <div class=\"col-2\">");
#nullable restore
#line 19 "C:\Users\Коко\source\repos\PhoneBook\PhoneBook\Views\Contacts\Index.cshtml"
                          Write(item.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <div class=\"col-2\">");
#nullable restore
#line 20 "C:\Users\Коко\source\repos\PhoneBook\PhoneBook\Views\Contacts\Index.cshtml"
                          Write(item.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <div class=\"col-2\">");
#nullable restore
#line 21 "C:\Users\Коко\source\repos\PhoneBook\PhoneBook\Views\Contacts\Index.cshtml"
                          Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <div class=\"col-2\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 699, "\"", 732, 2);
            WriteAttributeValue("", 706, "/Contacts/Edit?id=", 706, 18, true);
#nullable restore
#line 23 "C:\Users\Коко\source\repos\PhoneBook\PhoneBook\Views\Contacts\Index.cshtml"
WriteAttributeValue("", 724, item.Id, 724, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">edit</a>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 762, "\"", 796, 2);
            WriteAttributeValue("", 769, "/Contacts/Share?id=", 769, 19, true);
#nullable restore
#line 24 "C:\Users\Коко\source\repos\PhoneBook\PhoneBook\Views\Contacts\Index.cshtml"
WriteAttributeValue("", 788, item.Id, 788, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">share</a>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 827, "\"", 862, 2);
            WriteAttributeValue("", 834, "/Contacts/Delete?id=", 834, 20, true);
#nullable restore
#line 25 "C:\Users\Коко\source\repos\PhoneBook\PhoneBook\Views\Contacts\Index.cshtml"
WriteAttributeValue("", 854, item.Id, 854, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">delete</a>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 28 "C:\Users\Коко\source\repos\PhoneBook\PhoneBook\Views\Contacts\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PhoneBook.ViewModels.Contacts.ContactsIndexVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
