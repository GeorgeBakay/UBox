#pragma checksum "C:\Users\George\source\repos\GeorgeBakay\UBox\UBox\Views\Home\_PostPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "81c6846d1e51d9131815d040a79b600f415ccbd1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__PostPartial), @"mvc.1.0.view", @"/Views/Home/_PostPartial.cshtml")]
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
#line 2 "C:\Users\George\source\repos\GeorgeBakay\UBox\UBox\Views\_ViewImports.cshtml"
using UBox.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81c6846d1e51d9131815d040a79b600f415ccbd1", @"/Views/Home/_PostPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7679592323fff9c53086bb067ee421684427da2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__PostPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PostPartialView>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Profile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Profile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<div class=\"posts_element\">\r\n\r\n    <div class=\"posts_element_content\">\r\n");
#nullable restore
#line 5 "C:\Users\George\source\repos\GeorgeBakay\UBox\UBox\Views\Home\_PostPartial.cshtml"
          
            if (Model.post.FileType == ".mp4")
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <video autoplay loop>\r\n                    <source");
            BeginWriteAttribute("src", " src=\"", 237, "\"", 267, 1);
#nullable restore
#line 9 "C:\Users\George\source\repos\GeorgeBakay\UBox\UBox\Views\Home\_PostPartial.cshtml"
WriteAttributeValue("", 243, Model.post.PostFilePath, 243, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"video/mp4\" />\r\n                    ?????? ?????????????? ???? ?????????????????? ?????? ?????????? ??????\r\n                </video>\r\n");
#nullable restore
#line 12 "C:\Users\George\source\repos\GeorgeBakay\UBox\UBox\Views\Home\_PostPartial.cshtml"
            }
            else if (Model.post.FileType == ".jpg" || Model.post.FileType == ".png")
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <img");
            BeginWriteAttribute("src", " src=\"", 512, "\"", 542, 1);
#nullable restore
#line 15 "C:\Users\George\source\repos\GeorgeBakay\UBox\UBox\Views\Home\_PostPartial.cshtml"
WriteAttributeValue("", 518, Model.post.PostFilePath, 518, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 16 "C:\Users\George\source\repos\GeorgeBakay\UBox\UBox\Views\Home\_PostPartial.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n\r\n    <div class=\"post_info\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "81c6846d1e51d9131815d040a79b600f415ccbd15411", async() => {
                WriteLiteral("\r\n            <div class=\"post_info_user\">\r\n                <div class=\"post_info_user_img\">\r\n                    <img");
                BeginWriteAttribute("src", " src=\"", 835, "\"", 854, 1);
#nullable restore
#line 24 "C:\Users\George\source\repos\GeorgeBakay\UBox\UBox\Views\Home\_PostPartial.cshtml"
WriteAttributeValue("", 841, Model.avatar, 841, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                </div>\r\n\r\n                <p>");
#nullable restore
#line 27 "C:\Users\George\source\repos\GeorgeBakay\UBox\UBox\Views\Home\_PostPartial.cshtml"
              Write(Model.post.User.user.UserName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n            </div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-userId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 21 "C:\Users\George\source\repos\GeorgeBakay\UBox\UBox\Views\Home\_PostPartial.cshtml"
                                                               WriteLiteral(Model.post.User.userId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-userId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        <div class=\"post_info_descripion\">\r\n            <p>");
#nullable restore
#line 31 "C:\Users\George\source\repos\GeorgeBakay\UBox\UBox\Views\Home\_PostPartial.cshtml"
          Write(Model.post.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n        <div class=\"post_info_comments\">\r\n            <p>?? ?????????????????????? ?????? ???????????? ??????????????????</p>\r\n        </div>\r\n        <div class=\"post_info_action\">\r\n            <div class=\"likeButton\"");
            BeginWriteAttribute("id", " id=\"", 1267, "\"", 1286, 1);
#nullable restore
#line 37 "C:\Users\George\source\repos\GeorgeBakay\UBox\UBox\Views\Home\_PostPartial.cshtml"
WriteAttributeValue("", 1272, Model.post.Id, 1272, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                <svg width=""25"" height=""23"" viewBox=""0 0 25 23"" fill=""none"" xmlns=""http://www.w3.org/2000/svg"">
                    <path class=""path"" d=""M22.6995 1.94516C22.0825 1.32817 21.35 0.838813 20.5438 0.505053C19.7376 0.171293 18.8735 -0.000327185 18.0009 4.68275e-07C17.1284 0.000328121 16.2644 0.172597 15.4585 0.506963C14.6526 0.841328 13.9204 1.33124 13.3039 1.94869L12.4991 2.76327L11.701 1.95045L11.6958 1.94526C11.0791 1.32856 10.347 0.839372 9.54124 0.505616C8.73549 0.171861 7.87189 7.9044e-05 6.99974 7.9044e-05C6.1276 7.9044e-05 5.264 0.171861 4.45825 0.505616C3.6525 0.839372 2.92037 1.32856 2.30368 1.94526L1.94516 2.30379C0.699694 3.54925 0 5.23847 0 6.99982C0 8.76118 0.699694 10.4504 1.94516 11.6959L11.4075 21.1581L12.476 22.2777L12.5015 22.2521L12.5292 22.2798L13.5303 21.2235L23.058 11.6957C24.3016 10.4493 25 8.76041 25 6.99967C25 5.23893 24.3016 3.55009 23.058 2.30363L22.6995 1.94516ZM21.8837 10.5217L12.5015 19.9041L3.1191 10.5217C2.185 9.58762 1.66023 8.32071 1.66023 6.99969C1.66023 5.6");
            WriteLiteral(@"7868 2.185 4.41177 3.1191 3.47767L3.47767 3.11915C4.41131 2.18551 5.67746 1.66078 6.99782 1.66029C8.31819 1.65979 9.58473 2.18357 10.5191 3.1165L12.4955 5.12895L14.4813 3.11915C14.9439 2.65663 15.4929 2.28973 16.0973 2.03941C16.7016 1.7891 17.3493 1.66026 18.0034 1.66026C18.6575 1.66026 19.3052 1.7891 19.9095 2.03941C20.5138 2.28973 21.0629 2.65663 21.5254 3.11915L21.884 3.47762C22.8166 4.41249 23.3404 5.67915 23.3404 6.99971C23.3403 8.32027 22.8165 9.5869 21.8837 10.5217Z"" fill=""black"" />
                </svg>
            </div>
        </div>
        

    </div>

</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PostPartialView> Html { get; private set; }
    }
}
#pragma warning restore 1591
