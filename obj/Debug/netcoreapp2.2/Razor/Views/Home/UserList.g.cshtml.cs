#pragma checksum "C:\Users\Bill\Documents\CodingFiles\CodingDojo\csharp\asp\ViewModelFun\Views\Home\UserList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "380560ce813f7c5f961350e094322f2f5e55a3a5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_UserList), @"mvc.1.0.view", @"/Views/Home/UserList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/UserList.cshtml", typeof(AspNetCore.Views_Home_UserList))]
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
#line 1 "C:\Users\Bill\Documents\CodingFiles\CodingDojo\csharp\asp\ViewModelFun\Views\_ViewImports.cshtml"
using ViewModelFun;

#line default
#line hidden
#line 1 "C:\Users\Bill\Documents\CodingFiles\CodingDojo\csharp\asp\ViewModelFun\Views\Home\UserList.cshtml"
using ViewModelFun.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"380560ce813f7c5f961350e094322f2f5e55a3a5", @"/Views/Home/UserList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7312364e6c23e4cb7805f9e5f986831fce186000", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_UserList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<NewUser>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(50, 44, true);
            WriteLiteral("\r\n<div>\r\n    <h1>Here are some Users!</h1>\r\n");
            EndContext();
#line 6 "C:\Users\Bill\Documents\CodingFiles\CodingDojo\csharp\asp\ViewModelFun\Views\Home\UserList.cshtml"
     foreach (NewUser user in @Model)
    {

#line default
#line hidden
            BeginContext(140, 11, true);
            WriteLiteral("        <p>");
            EndContext();
            BeginContext(152, 9, false);
#line 8 "C:\Users\Bill\Documents\CodingFiles\CodingDojo\csharp\asp\ViewModelFun\Views\Home\UserList.cshtml"
      Write(user.name);

#line default
#line hidden
            EndContext();
            BeginContext(161, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 9 "C:\Users\Bill\Documents\CodingFiles\CodingDojo\csharp\asp\ViewModelFun\Views\Home\UserList.cshtml"
    }

#line default
#line hidden
            BeginContext(174, 6, true);
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<NewUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591
