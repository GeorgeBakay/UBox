#pragma checksum "C:\Users\George\source\repos\GeorgeBakay\UBox\UBox\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb4f8cae35938b68a27f14ce445df8af932d18a6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb4f8cae35938b68a27f14ce445df8af932d18a6", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7679592323fff9c53086bb067ee421684427da2", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddPost", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eb4f8cae35938b68a27f14ce445df8af932d18a65618", async() => {
                WriteLiteral("\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "eb4f8cae35938b68a27f14ce445df8af932d18a65884", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <meta name=""viewport"" content=""width=device-width"">

    <link rel=""preconnect"" href=""https://fonts.googleapis.com"">
    <link rel=""preconnect"" href=""https://fonts.gstatic.com"" crossorigin>
    <link href=""https://fonts.googleapis.com/css2?family=Roboto+Slab:wght@300&display=swap"" rel=""stylesheet"">

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eb4f8cae35938b68a27f14ce445df8af932d18a68179", async() => {
                WriteLiteral("\r\n    \r\n    <div class=\"content\">\r\n        ");
#nullable restore
#line 17 "C:\Users\George\source\repos\GeorgeBakay\UBox\UBox\Views\Shared\_Layout.cshtml"
   Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    </div>
    <footer>
        <div class=""logo_desktop"">
            <svg width=""115"" height=""58"" viewBox=""0 0 115 58"" fill=""none"" xmlns=""http://www.w3.org/2000/svg"">
                <rect y=""11"" width=""38"" height=""40"" rx=""5"" fill=""#FA6D6D"" />
                <path d=""M19.64 46.44C17.1867 46.44 15 45.9333 13.08 44.92C11.16 43.9067 9.66667 42.44 8.6 40.52C7.53333 38.5733 7 36.2933 7 33.68V17.2C7 17.0667 6.88 16.96 6.64 16.88C6.42667 16.8 6.21333 16.76 6 16.76V16H13.72V16.76C13.5067 16.76 13.28 16.8 13.04 16.88C12.8267 16.96 12.72 17.0667 12.72 17.2V32.48C12.72 35.36 13.2933 37.5733 14.44 39.12C15.6133 40.6667 17.3467 41.44 19.64 41.44C22.1467 41.44 23.8133 40.64 24.64 39.04C25.4933 37.44 25.92 35.36 25.92 32.8V17.2C25.92 17.0667 25.8 16.96 25.56 16.88C25.3467 16.8 25.1333 16.76 24.92 16.76V16H32.68V16.76C32.4667 16.76 32.24 16.8 32 16.88C31.7867 16.96 31.68 17.0667 31.68 17.2V32.96C31.68 37.2 30.7067 40.5067 28.76 42.88C26.84 45.2533 23.8 46.44 19.64 46.44Z"" fill=""white"" />
                <path d=""M");
                WriteLiteral(@"56.0241 28.88C56.9041 29.1467 57.7841 29.6667 58.6641 30.44C59.5707 31.1867 60.3174 32.1467 60.9041 33.32C61.5174 34.4933 61.8241 35.8 61.8241 37.24C61.8241 38.7867 61.4507 40.2267 60.7041 41.56C59.9574 42.8933 58.8507 43.9733 57.3841 44.8C55.9174 45.6 54.1707 46 52.1441 46H39.4641V45.24C39.6507 45.24 39.8374 45.2 40.0241 45.12C40.2374 45.04 40.3441 44.9333 40.3441 44.8V17.2C40.3441 17.0667 40.2374 16.96 40.0241 16.88C39.8374 16.8 39.6507 16.76 39.4641 16.76V16H48.7041C50.4907 16 52.0641 16.3467 53.4241 17.04C54.8107 17.7067 55.8774 18.6533 56.6241 19.88C57.3974 21.08 57.7841 22.4533 57.7841 24C57.7841 26 57.1974 27.6267 56.0241 28.88ZM45.5441 20.72V27.8H48.0641C49.7174 27.8 50.8507 27.48 51.4641 26.84C52.1041 26.1733 52.4241 25.2533 52.4241 24.08C52.4241 23.1467 52.0107 22.36 51.1841 21.72C50.3841 21.0533 49.3441 20.72 48.0641 20.72H45.5441ZM50.9841 41.28C53.0107 41.28 54.4507 40.8667 55.3041 40.04C56.1841 39.2133 56.6241 38.2267 56.6241 37.08C56.6241 35.88 56.2507 34.8267 55.5041 33.92C54.7574 32.9867 53.47");
                WriteLiteral(@"74 32.52 51.6641 32.52H45.5441V41.28H50.9841ZM77.6406 46.48C75.6673 46.48 73.9206 46.0667 72.4006 45.24C70.9073 44.3867 69.734 43.2267 68.8806 41.76C68.054 40.2933 67.6406 38.64 67.6406 36.8C67.6406 34.9867 68.054 33.3333 68.8806 31.84C69.734 30.3467 70.9206 29.1733 72.4406 28.32C73.9606 27.44 75.694 27 77.6406 27C79.5073 27 81.2006 27.4267 82.7206 28.28C84.2406 29.1067 85.4406 30.2667 86.3206 31.76C87.2006 33.2267 87.6406 34.9067 87.6406 36.8C87.6406 38.4533 87.2406 40.0267 86.4406 41.52C85.6673 42.9867 84.5206 44.1867 83.0006 45.12C81.4806 46.0267 79.694 46.48 77.6406 46.48ZM77.6406 41.88C79.214 41.88 80.4806 41.4267 81.4406 40.52C82.4273 39.5867 82.9206 38.3867 82.9206 36.92C82.9206 35.4 82.4273 34.1467 81.4406 33.16C80.4806 32.1733 79.214 31.68 77.6406 31.68C76.174 31.68 74.9473 32.1733 73.9606 33.16C72.974 34.12 72.4806 35.3333 72.4806 36.8C72.4806 38.3467 72.974 39.5867 73.9606 40.52C74.9473 41.4267 76.174 41.88 77.6406 41.88ZM113.133 28.36H112.853C112.506 28.36 112.28 28.4267 112.173 28.56L105.813 36.8");
                WriteLiteral(@"8L112.013 45.04C112.12 45.1733 112.44 45.24 112.973 45.24V46H105.933V45.24C106.253 45.24 106.413 45.1733 106.413 45.04C106.413 44.9867 106.36 44.88 106.253 44.72L102.973 40.4L99.6131 44.76L99.5331 44.92C99.5331 45.0267 99.5998 45.12 99.7331 45.2C99.8665 45.2533 100.053 45.28 100.293 45.28V46H92.8531V45.24H93.0531C93.4265 45.24 93.6798 45.1733 93.8131 45.04L100.053 36.8L93.7731 28.56C93.6665 28.4267 93.3465 28.36 92.8131 28.36V27.6H99.8131V28.32C99.4931 28.32 99.3331 28.3867 99.3331 28.52C99.3331 28.6 99.3731 28.7067 99.4531 28.84L102.853 33.32L106.333 28.84L106.413 28.68C106.413 28.5733 106.333 28.4933 106.173 28.44C106.04 28.36 105.853 28.32 105.613 28.32V27.6H113.133V28.36Z"" fill=""black"" />
            </svg>
        </div>
        <ul style=""list-style:none;"">
            <li class=""left_items"">
                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eb4f8cae35938b68a27f14ce445df8af932d18a612750", async() => {
                    WriteLiteral(@"
                    <div class=""item"">
                        <div class=""icon"">
                            <svg width=""34"" height=""35"" viewBox=""0 0 34 35"" fill=""none"" xmlns=""http://www.w3.org/2000/svg"">
                                <path d=""M33.187 14.2368L18.1286 0.666873C17.6391 0.225726 16.9944 -0.0130169 16.3294 0.000547943C15.6643 0.0141128 15.0304 0.278935 14.56 0.739661L0.710728 14.3053L0 15.0014V35H13.3456V22.522H20.625V35H33.9706V14.943L33.187 14.2368ZM16.3816 2.3768C16.4029 2.3768 16.3897 2.38133 16.3806 2.39017C16.3711 2.38133 16.3602 2.3768 16.3816 2.3768ZM31.5441 32.6232H23.0515V22.522C23.0515 21.8916 22.7958 21.2871 22.3408 20.8414C21.8857 20.3957 21.2685 20.1452 20.625 20.1452H13.3456C12.702 20.1452 12.0849 20.3957 11.6298 20.8414C11.1748 21.2871 10.9191 21.8916 10.9191 22.522V32.6232H2.42647V15.9859L16.3816 2.42025C16.3825 2.41936 16.3826 2.41855 16.3834 2.41765L31.5441 15.9859V32.6232Z"" fill=""black"" />
                            </svg>
                        </div>          
 ");
                    WriteLiteral("                       <p>Головна</p>\r\n                    </div>\r\n                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            </li>\r\n            <li class=\"center\">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eb4f8cae35938b68a27f14ce445df8af932d18a615421", async() => {
                    WriteLiteral(@"
                    <div class=""item"">
                        <div class=""icon"">
                            <svg width=""33"" height=""33"" viewBox=""0 0 33 33"" fill=""none"" xmlns=""http://www.w3.org/2000/svg"">
                                <path class=""add_icon"" d=""M33 15.0652H17.9348V0H15.0652V15.0652H0V17.9348H15.0652V33H17.9348V17.9348H33V15.0652Z"" fill=""black"" />
                            </svg>
                        </div>         
                        <p>Створити</p>
                    </div>
                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
            </li>
            <li class=""left_items"">
                <a>
                    <div class=""item"">
                        <div class=""icon"">
                            <svg width=""36"" height=""35"" viewBox=""0 0 36 35"" fill=""none"" xmlns=""http://www.w3.org/2000/svg"">
                                <path d=""M33.8525 28.0193L27.9317 22.0985L23.3775 20.2169C24.8939 18.0605 25.7063 15.4879 25.7034 12.8517C25.7034 5.76522 19.9381 0 12.8517 0C5.76522 0 0 5.76522 0 12.8517C0 19.9381 5.76522 25.7034 12.8517 25.7034C15.5108 25.7064 18.1047 24.88 20.272 23.3392L22.1486 27.8811L28.0692 33.8022C28.449 34.1819 28.8997 34.4832 29.3959 34.6887C29.892 34.8942 30.4237 35 30.9607 35C31.4978 35 32.0295 34.8943 32.5256 34.6888C33.0218 34.4833 33.4726 34.1821 33.8523 33.8024C34.2321 33.4227 34.5333 32.9719 34.7388 32.4758C34.9443 31.9796 35.0501 31.4479 35.0501 30.9109C35.0501 30.3739 34.9444 29.8421 34.7389 29.346C34.5334 28.8498 34.2322 28.399 33.8525 28.0193ZM2.33667 12.8517C2.33667 7.05382 7.05382 2.33667");
                WriteLiteral(@" 12.8517 2.33667C18.6495 2.33667 23.3667 7.05382 23.3667 12.8517C23.3667 18.6495 18.6495 23.3667 12.8517 23.3667C7.05382 23.3667 2.33667 18.6495 2.33667 12.8517ZM32.2001 32.1499C31.8712 32.4781 31.4255 32.6624 30.9609 32.6624C30.4962 32.6624 30.0506 32.4781 29.7216 32.1499L24.1303 26.5586L22.3855 22.3354L26.6088 24.0802L32.2003 29.6715C32.5284 30.0005 32.7127 30.4462 32.7126 30.9108C32.7126 31.3754 32.5283 31.821 32.2001 32.1499Z"" fill=""black"" />
                            </svg>
                        </div>    
                        <p>Пошук</p>
                    </div>
                </a>
            </li>
            <li class=""left_items"">
                <a>
                    <div class=""item"">
                        <div class=""icon"">
                            <svg width=""32"" height=""35"" viewBox=""0 0 32 35"" fill=""none"" xmlns=""http://www.w3.org/2000/svg"">
                                <path d=""M19.2959 17.5C19.6996 16.837 20.1169 16.1514 20.5291 15.4446C21.9087 13.0796 22.1618 ");
                WriteLiteral(@"10.6966 21.2818 8.36174C19.506 3.6507 13.57 0.780305 12.1957 0.322325L11.2294 0L9.72123 3.01698L10.449 3.61157C10.4572 3.61811 11.2656 4.32449 11.3195 5.39534C11.3655 6.30946 10.8644 7.29729 9.83038 8.33158C9.11232 9.04956 8.32424 9.74383 7.48983 10.4788C3.97912 13.5705 0 17.0757 0 23.7067C0 23.7978 0.000856392 23.8884 0.0025692 23.9783C0.0280115 25.4416 0.342291 26.8855 0.927357 28.227C1.51242 29.5684 2.35675 30.7811 3.41184 31.7953C5.5305 33.8561 8.37122 35.0062 11.3268 35H18.0875L17.2529 33.3063C13.8621 26.4245 16.26 22.4861 19.2959 17.5ZM11.3268 32.651C6.46729 32.651 2.44097 28.7409 2.35112 23.9348C2.34975 23.8592 2.34904 23.7831 2.34899 23.7067C2.34899 18.1368 5.7518 15.1393 9.04259 12.2407C9.8676 11.514 10.7208 10.7625 11.4913 9.9918C13.0148 8.4684 13.7463 6.88195 13.6655 5.27679C13.6303 4.59654 13.4497 3.93173 13.136 3.32712C15.1796 4.4437 18.0926 6.56088 19.0839 9.19057C19.711 10.8543 19.5201 12.5129 18.5002 14.2614C18.099 14.9491 17.6875 15.625 17.2895 16.2787C14.3767 21.0624 11.6136 25.5998 14.3935 ");
                WriteLiteral(@"32.651H11.3268Z"" fill=""black"" />
                                <path d=""M30.8278 23.6315C30.8082 23.5539 30.7878 23.476 30.7666 23.3977C29.919 20.2903 25.2276 16.2948 24.6955 15.8494L23.6269 14.9552L22.9261 16.1597C21.3293 18.905 19.959 21.4091 19.3616 24.2499C18.6805 27.4896 19.139 30.7822 20.7637 34.316L21.0779 35H21.8764C23.2829 35.004 24.6715 34.6851 25.9352 34.0679C27.199 33.4506 28.3042 32.5515 29.1657 31.4398C30.0219 30.3523 30.617 29.0828 30.9051 27.729C31.1933 26.3753 31.1668 24.9734 30.8278 23.6315ZM27.3131 29.9946C26.7438 30.7296 26.0308 31.341 25.2176 31.7915C24.4043 32.242 23.5079 32.5223 22.5828 32.6151C20.2675 27.0436 21.6336 23.246 24.244 18.5862C25.9795 20.2007 28.0945 22.5274 28.5003 24.0154C28.5174 24.0782 28.5338 24.1407 28.5494 24.2029C28.8004 25.1985 28.8194 26.2384 28.6051 27.2426C28.3907 28.2467 27.9487 29.1882 27.3131 29.9946Z"" fill=""black"" />
                            </svg>
                        </div>
                        <p>Рекомендації</p>
                    </div>");
                WriteLiteral(@"
                </a>
            </li>
            <li class=""right_items"">
                <a>
                    <div class=""item"">
                        <div class=""icon"">
                            <svg width=""33"" height=""33"" viewBox=""0 0 33 33"" fill=""none"" xmlns=""http://www.w3.org/2000/svg"">
                                <path d=""M33 33H31.9C27.3787 32.9998 23.0089 31.3697 19.592 28.4087L18.4352 27.4061C17.7935 27.4685 17.1446 27.5 16.5 27.5C12.1325 27.5 8.01728 26.0954 4.91233 23.5449C1.74453 20.9428 0 17.4642 0 13.75C0 10.0358 1.74453 6.55717 4.91233 3.95512C8.01728 1.40463 12.1325 0 16.5 0C20.8675 0 24.9827 1.40463 28.0877 3.95512C31.2555 6.55717 33 10.0358 33 13.75C32.9985 15.7244 32.5001 17.6666 31.551 19.3979C30.727 20.9057 29.6298 22.2471 28.3152 23.3535C29.2976 25.8516 30.7825 28.1214 32.6778 30.0223L33 30.3444V33ZM19.1439 25.109L21.0329 26.7462C23.6383 29.0041 26.8823 30.3944 30.3141 30.7241C28.4206 28.6076 26.9583 26.1419 26.0092 23.4653L25.7071 22.6084L26.3402 22.1225C29.2162 19");
                WriteLiteral(@".9154 30.8 16.942 30.8 13.75C30.8 7.38128 24.385 2.2 16.5 2.2C8.61499 2.2 2.2 7.38128 2.2 13.75C2.2 20.1187 8.61499 25.3 16.5 25.3C17.2216 25.2999 17.9425 25.256 18.6588 25.1685L19.1439 25.109Z"" fill=""black"" />
                            </svg>
                        </div>
                        <p>Повідомлення</p>
                    </div>
                </a>
            </li>
            <li class=""right_items"">
                <a>
                    <div class=""item"">
                        <div class=""icon"">
                            <svg width=""32"" height=""35"" viewBox=""0 0 32 35"" fill=""none"" xmlns=""http://www.w3.org/2000/svg"">
                                <path d=""M30.8 24.732L27.3883 18.4332V11.875C27.3883 5.32711 22.0611 0 15.5133 0C8.96536 0 3.63825 5.32711 3.63825 11.875V18.4332L0.226379 24.7319C0.0716536 25.0175 -0.00622027 25.3384 0.000388154 25.6631C0.00699658 25.9879 0.0978605 26.3054 0.264076 26.5845C0.430292 26.8635 0.666158 27.0946 0.948564 27.2551C1.23097 27.4156 1.55");
                WriteLiteral(@"022 27.5 1.87505 27.5H8.66685C8.64825 27.7059 8.63818 27.9141 8.63818 28.125C8.63818 29.9484 9.3625 31.697 10.6518 32.9864C11.9411 34.2757 13.6898 35 15.5132 35C17.3365 35 19.0852 34.2757 20.3745 32.9864C21.6638 31.697 22.3882 29.9484 22.3882 28.125C22.3882 27.9141 22.3781 27.7059 22.3595 27.5H29.1513C29.4761 27.5 29.7953 27.4156 30.0777 27.255C30.36 27.0945 30.5959 26.8634 30.762 26.5844C30.9282 26.3053 31.0191 25.9879 31.0257 25.6631C31.0323 25.3384 30.9544 25.0175 30.7997 24.732H30.8ZM19.8883 28.125C19.8887 28.7262 19.7653 29.3211 19.5256 29.8725C19.286 30.4239 18.9352 30.92 18.4953 31.3298C18.0554 31.7396 17.5357 32.0543 16.9687 32.2544C16.4017 32.4544 15.7996 32.5354 15.1999 32.4923C14.6002 32.4493 14.0159 32.2831 13.4833 32.0041C12.9507 31.7251 12.4813 31.3394 12.1044 30.8709C11.7276 30.4025 11.4513 29.8614 11.2929 29.2814C11.1344 28.7014 11.0973 28.095 11.1836 27.5H19.8428C19.8728 27.707 19.888 27.9158 19.8883 28.125ZM2.92435 25L6.13825 19.0668V11.875C6.13825 9.3886 7.12597 7.00403 8.88413 5.24587C10.6");
                WriteLiteral(@"423 3.48772 13.0268 2.5 15.5133 2.5C17.9997 2.5 20.3842 3.48772 22.1424 5.24587C23.9005 7.00403 24.8883 9.3886 24.8883 11.875V19.0668L28.102 25H2.92435Z"" fill=""black"" />
                            </svg>
                        </div>
                        
                        <p>Сповіщення</p>
                    </div>
                </a>
            </li>
            <li class=""right_items"">
                <a>
                    <div class=""item"">
                        <div class=""icon"">
                            <svg width=""25"" height=""35"" viewBox=""0 0 25 35"" fill=""none"" xmlns=""http://www.w3.org/2000/svg"">
                                <path d=""M24.5 35H21.9297L12.2506 26.6284L2.58614 35H0V0H24.5V35ZM2.33333 2.33333V32.132L12.2494 23.5424L22.1667 32.1198V2.33333H2.33333Z"" fill=""black"" />
                            </svg>
                        </div>
                        
                        <p>Збережено</p>
                    </div>
                </a>
     ");
                WriteLiteral("       </li>\r\n        </ul>\r\n    </footer>\r\n");
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
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
