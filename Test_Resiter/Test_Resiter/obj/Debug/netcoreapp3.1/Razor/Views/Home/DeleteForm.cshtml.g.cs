#pragma checksum "D:\programming\c#\Test_Resiter\Test_Resiter\Views\Home\DeleteForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd2fb5dddc6a1905a2e375b3a3153e021db1f506"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_DeleteForm), @"mvc.1.0.view", @"/Views/Home/DeleteForm.cshtml")]
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
#line 1 "D:\programming\c#\Test_Resiter\Test_Resiter\Views\_ViewImports.cshtml"
using Test_Resiter;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\programming\c#\Test_Resiter\Test_Resiter\Views\_ViewImports.cshtml"
using Test_Resiter.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd2fb5dddc6a1905a2e375b3a3153e021db1f506", @"/Views/Home/DeleteForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"692809bc731b80d91b658e1555d4e051b603db8f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_DeleteForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Test_Resiter.Models.SendForm>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h2>Удаление заявки</h2>\r\n<dl>\r\n    <dt>Название</dt>\r\n    <dd>\r\n        ");
#nullable restore
#line 6 "D:\programming\c#\Test_Resiter\Test_Resiter\Views\Home\DeleteForm.cshtml"
   Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dd>\r\n\r\n    <dt>Автор</dt>\r\n    <dd>\r\n        ");
#nullable restore
#line 11 "D:\programming\c#\Test_Resiter\Test_Resiter\Views\Home\DeleteForm.cshtml"
   Write(Html.DisplayFor(model => model.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dd>\r\n\r\n    <dt>Цена</dt>\r\n    <dd>\r\n        ");
#nullable restore
#line 16 "D:\programming\c#\Test_Resiter\Test_Resiter\Views\Home\DeleteForm.cshtml"
   Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dd>\r\n    <dd>\r\n        ");
#nullable restore
#line 19 "D:\programming\c#\Test_Resiter\Test_Resiter\Views\Home\DeleteForm.cshtml"
   Write(Html.DisplayFor(model => model.Text));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dd>\r\n    <dd>\r\n        ");
#nullable restore
#line 22 "D:\programming\c#\Test_Resiter\Test_Resiter\Views\Home\DeleteForm.cshtml"
   Write(Html.DisplayFor(model => model.Comment));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dd>\r\n</dl>\r\n\r\n");
#nullable restore
#line 26 "D:\programming\c#\Test_Resiter\Test_Resiter\Views\Home\DeleteForm.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <input type=\"submit\" value=\"Удалить\" />\r\n");
#nullable restore
#line 29 "D:\programming\c#\Test_Resiter\Test_Resiter\Views\Home\DeleteForm.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Test_Resiter.Models.SendForm> Html { get; private set; }
    }
}
#pragma warning restore 1591
