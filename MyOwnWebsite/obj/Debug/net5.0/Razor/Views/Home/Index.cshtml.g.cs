#pragma checksum "C:\Users\bebom\source\repos\Abobakr\MyOwnWebsite\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4651c3c28d47bb34c4341700e23322030414c398"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\bebom\source\repos\Abobakr\MyOwnWebsite\Views\_ViewImports.cshtml"
using MyOwnWebsite.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4651c3c28d47bb34c4341700e23322030414c398", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"270a5ccdfad2ad96b05b869ea459a140d3617e5d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("user image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/my-cv.pdf"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\bebom\source\repos\Abobakr\MyOwnWebsite\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>Index</h1>\r\n");
            WriteLiteral("\r\n   <div class=\"header-text\">\r\n                <p>");
#nullable restore
#line 8 "C:\Users\bebom\source\repos\Abobakr\MyOwnWebsite\Views\Home\Index.cshtml"
              Write(Model.owner.Position);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <h1>Hi , I\'m <span>");
#nullable restore
#line 9 "C:\Users\bebom\source\repos\Abobakr\MyOwnWebsite\Views\Home\Index.cshtml"
                              Write(Model.owner.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> <br>");
#nullable restore
#line 9 "C:\Users\bebom\source\repos\Abobakr\MyOwnWebsite\Views\Home\Index.cshtml"
                                                               Write(Model.owner.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
            </div>
        </div>
    </div>
 <!------------------------------about----------->
    <div id=""about"">
        <div class=""container"">
            <div class=""row"">
                <div class=""about-col-1"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4651c3c28d47bb34c4341700e23322030414c3985713", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 515, "~/images/", 515, 9, true);
#nullable restore
#line 18 "C:\Users\bebom\source\repos\Abobakr\MyOwnWebsite\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 524, Model.owner.Avatar, 524, 19, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n                <div class=\"about-col-2\">\r\n                    <h1 class=\"sub-title\">About Me</h1>\r\n                    <p>\r\n                       ");
#nullable restore
#line 23 "C:\Users\bebom\source\repos\Abobakr\MyOwnWebsite\Views\Home\Index.cshtml"
                  Write(Model.owner.Position);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </p>
                    <div class=""tabe-titles"">
                        <p class=""tab-links active-link "" onclick=""openTab('skills')"">Skills</p>
                        <p class=""tab-links "" onclick=""openTab('experience')"">Experience</p>
                        <p class=""tab-links"" onclick=""openTab('education')"">Education</p>
                    </div>
                    <div class=""tab-contents active-tab"" id=""skills"">
                        <ul>
                            <li><span>FrontEnd Developer</span><br>Designing web/app interfaces </li>
                            <li><span>BackEnd Developer</span><br> web app Development </li>
                        </ul>
                    </div>
                    <div class=""tab-contents"" id=""experience"">
                        <ul>
                            <li><span>FreeLancer</span><br>on Mostaql And Upwork </li>
                        </ul>
                    </div>
                    <div class=""tab-cont");
            WriteLiteral(@"ents"" id=""education"">
                        <ul>
                            <li><span>2022</span><br>FullStack Developer Diploma using .Net from ITI</li>
                            <li><span>2020</span><br> FullStack Developer Diploma using Php and Laravel Framework from Yat Acdmic center </li>
                            <li><span>2020</span><br>Bacholar Degree from Egyption E-Learning University </li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </div>

                         <!-- ------------------services-------------- -->

    <div id=""services"">
        <div class=""container"">
            <h1 class=""sub-title""> My Services</h1>
            <div class=""services-list"">
                <div>
                    <i class=""fa-solid fa-code""></i>
                    <h2>frontend development</h2>
                    <p>
                        Lorem ipsum dolor sit amet consectetur adipisicing elit. Officiis qu");
            WriteLiteral(@"isquam, maiores ducimus dicta ipsa commodi possimus asperiores nesciunt repellat blanditiis tempora vitae tenetur rerum nostrum facilis, at corrupti. Soluta, eum?
                    </p>
                    <a href=""#"">See More</a>
                </div>
              
            </div>
        </div>
    </div>

");
#nullable restore
#line 72 "C:\Users\bebom\source\repos\Abobakr\MyOwnWebsite\Views\Home\Index.cshtml"
 foreach(var item in Model.portofolioItems)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <!-- ------------ portofolio ----------->\r\n     <div id=\"portofolio\">\r\n\r\n        <div class=\"container\">\r\n            <h1 class=\"sub-title\"> My Work</h1>\r\n            <div class=\"work-list\">\r\n                <div class=\"work\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4651c3c28d47bb34c4341700e23322030414c39810676", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3441, "~/images/", 3441, 9, true);
#nullable restore
#line 81 "C:\Users\bebom\source\repos\Abobakr\MyOwnWebsite\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 3450, item.ImageUrl, 3450, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    <div class=\"layer\">\r\n                        <h3>");
#nullable restore
#line 83 "C:\Users\bebom\source\repos\Abobakr\MyOwnWebsite\Views\Home\Index.cshtml"
                       Write(item.ProjectName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                        <p> ");
#nullable restore
#line 84 "C:\Users\bebom\source\repos\Abobakr\MyOwnWebsite\Views\Home\Index.cshtml"
                       Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <a href=\"#\"><i class=\"fa-solid fa-arrow-up-right-from-square\"></i></a>\r\n                    </div>\r\n                </div>\r\n\r\n            </div>\r\n            <a href=\"#\" class=\"btn\">See more</a>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 93 "C:\Users\bebom\source\repos\Abobakr\MyOwnWebsite\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
   
    <!-- -------------------------- contact --------------->
    <div id=""contact"">
        <div class=""container"">
            <div class=""row"">
                <div class=""contact-left"">
                    <h1 class=""sub-title""> Contact Me</h1>
                    <p> <i class=""fa-solid fa-paper-plane""></i> abobakr.mohammed95@gmail.com </p>
                    <p> <i class=""fa-solid fa-square-phone""></i> +201009133638</p>
                    <div class=""social-icons"">
                        <a href=""https://www.linkedin.com/in/abobakr-mohammed-934610172/""><i class=""fa-brands fa-linkedin""></i></a>
                        <a href=""https://web.facebook.com/BeboMuhammed12/""><i class=""fa-brands fa-facebook""></i></a>
                        <a href=""https://www.instagram.com/bebo_muhammed/""><i class=""fa-brands fa-instagram""></i></a>
                        <a href=""https://twitter.com/bebo_muhammed12""><i class=""fa-brands fa-twitter-square""></i></i></a>
                        <a href=""https:");
            WriteLiteral("//github.com/abobakr-mohammed\"><i class=\"fa-brands fa-github\"></i></a>\r\n\r\n                    </div>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4651c3c28d47bb34c4341700e23322030414c39814502", async() => {
                WriteLiteral("Download CV");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("download", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

                </div>
                <div class=""contact-right"">

                    <form name=""submit-to-google-sheet"">
                        <input type=""text"" name=""Name"" placeholder=""Your Name"" required>
                        <input type=""email"" name=""Email"" placeholder=""Your Email"" required>
                        <textarea name=""Message"" rows=""6"" placeholder=""Your Message""></textarea>
                        <button type=""submit"" class=""btn btn2"">Submit</button>
                    </form>
                    <span id=""msg""> </span>
                </div>
            </div>
        </div>
       ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591