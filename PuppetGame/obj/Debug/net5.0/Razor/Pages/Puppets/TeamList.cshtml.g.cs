#pragma checksum "C:\Users\ThomasWCooper\Documents\Code\C# Code\ScoreCounter\PuppetGame\Pages\Puppets\TeamList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f8f3542f98c426cd1025a0dee4b82b2253b42b3e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(PuppetGame.Pages.Puppets.Pages_Puppets_TeamList), @"mvc.1.0.razor-page", @"/Pages/Puppets/TeamList.cshtml")]
namespace PuppetGame.Pages.Puppets
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
#line 1 "C:\Users\ThomasWCooper\Documents\Code\C# Code\ScoreCounter\PuppetGame\Pages\_ViewImports.cshtml"
using PuppetGame;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8f3542f98c426cd1025a0dee4b82b2253b42b3e", @"/Pages/Puppets/TeamList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"599e1e56a214c0c265194e1f12ffe3049a4e02c9", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Puppets_TeamList : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\ThomasWCooper\Documents\Code\C# Code\ScoreCounter\PuppetGame\Pages\Puppets\TeamList.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f8f3542f98c426cd1025a0dee4b82b2253b42b3e3547", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "C:\Users\ThomasWCooper\Documents\Code\C# Code\ScoreCounter\PuppetGame\Pages\Puppets\TeamList.cshtml"
           Write(Html.DisplayNameFor(model => model.Team[0].Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "C:\Users\ThomasWCooper\Documents\Code\C# Code\ScoreCounter\PuppetGame\Pages\Puppets\TeamList.cshtml"
           Write(Html.DisplayNameFor(model => model.Team[0].HatChoice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "C:\Users\ThomasWCooper\Documents\Code\C# Code\ScoreCounter\PuppetGame\Pages\Puppets\TeamList.cshtml"
           Write(Html.DisplayNameFor(model => model.Team[0].EyeChoice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "C:\Users\ThomasWCooper\Documents\Code\C# Code\ScoreCounter\PuppetGame\Pages\Puppets\TeamList.cshtml"
           Write(Html.DisplayNameFor(model => model.Team[0].ArmChoice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 29 "C:\Users\ThomasWCooper\Documents\Code\C# Code\ScoreCounter\PuppetGame\Pages\Puppets\TeamList.cshtml"
           Write(Html.DisplayNameFor(model => model.Team[0].LegChoice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 35 "C:\Users\ThomasWCooper\Documents\Code\C# Code\ScoreCounter\PuppetGame\Pages\Puppets\TeamList.cshtml"
 foreach (var item in Model.Team) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 38 "C:\Users\ThomasWCooper\Documents\Code\C# Code\ScoreCounter\PuppetGame\Pages\Puppets\TeamList.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 41 "C:\Users\ThomasWCooper\Documents\Code\C# Code\ScoreCounter\PuppetGame\Pages\Puppets\TeamList.cshtml"
           Write(Html.DisplayFor(modelItem => item.HatChoice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 44 "C:\Users\ThomasWCooper\Documents\Code\C# Code\ScoreCounter\PuppetGame\Pages\Puppets\TeamList.cshtml"
           Write(Html.DisplayFor(modelItem => item.EyeChoice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 47 "C:\Users\ThomasWCooper\Documents\Code\C# Code\ScoreCounter\PuppetGame\Pages\Puppets\TeamList.cshtml"
           Write(Html.DisplayFor(modelItem => item.ArmChoice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 50 "C:\Users\ThomasWCooper\Documents\Code\C# Code\ScoreCounter\PuppetGame\Pages\Puppets\TeamList.cshtml"
           Write(Html.DisplayFor(modelItem => item.LegChoice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            \r\n        </tr>\r\n");
#nullable restore
#line 54 "C:\Users\ThomasWCooper\Documents\Code\C# Code\ScoreCounter\PuppetGame\Pages\Puppets\TeamList.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PuppetGame.Pages.Puppets.TeamListModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PuppetGame.Pages.Puppets.TeamListModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PuppetGame.Pages.Puppets.TeamListModel>)PageContext?.ViewData;
        public PuppetGame.Pages.Puppets.TeamListModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
