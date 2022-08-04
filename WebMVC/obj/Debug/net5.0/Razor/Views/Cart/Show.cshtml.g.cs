#pragma checksum "D:\WebMVC\WebMVC\Views\Cart\Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a0a986752543a485e83fe8cb41434af6ad7c887"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Show), @"mvc.1.0.view", @"/Views/Cart/Show.cshtml")]
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
#line 1 "D:\WebMVC\WebMVC\Views\_ViewImports.cshtml"
using WebMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\WebMVC\WebMVC\Views\_ViewImports.cshtml"
using WebMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a0a986752543a485e83fe8cb41434af6ad7c887", @"/Views/Cart/Show.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d07e873f05b36c9d83cd6a184d4bfbe1720fee4b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Cart_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Dictionary<string ,int>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Cart/Update"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"<section class=""page-header"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-md-12"">
                        <div class=""content"">
                            <h1 class=""page-name"">Show Cart</h1>
                        </div>
                    </div>
                </div>
            </div>
 </section>
 <h3 style=""color:red"">");
#nullable restore
#line 13 "D:\WebMVC\WebMVC\Views\Cart\Show.cshtml"
                  Write(ViewData["message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
 <section class=""user-dashboard page-wrapper"" style=""height: 100vh"">
     <div class=""container"">
         <div class=""dashboard-wrapper user-dashboard"">
             <div class=""table-responsive"">
                 <table class=""table"">
                       <thead>
                             <tr>   
                                 <th>Name</th>
                                 <th>Image</th>
                                 <th>Quantity</th>
                                 <th>Price</th>
                                 <th>Total</th>
                                 <th class=""col-md-2 col-sm-3"">Actions</th>
                             </tr>
                       </thead>
                       <tbody>
");
#nullable restore
#line 30 "D:\WebMVC\WebMVC\Views\Cart\Show.cshtml"
                              
                                int sum = 0;
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "D:\WebMVC\WebMVC\Views\Cart\Show.cshtml"
                             foreach(string name in Model.Keys)
                            {
                                string image = new DAOProduct().getImage(name);
                                int price = new DAOProduct().getPrice(name);
                                int quantity = Model[name];
                                int total = quantity * price;
                                sum = sum + total;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>");
#nullable restore
#line 41 "D:\WebMVC\WebMVC\Views\Cart\Show.cshtml"
                                   Write(name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td><img");
            BeginWriteAttribute("src", " src=\"", 1871, "\"", 1883, 1);
#nullable restore
#line 42 "D:\WebMVC\WebMVC\Views\Cart\Show.cshtml"
WriteAttributeValue("", 1877, image, 1877, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1884, "\"", 1890, 0);
            EndWriteAttribute();
            WriteLiteral(" width=\"50\" height=\"50\"></td>\r\n                                    <td>\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3a0a986752543a485e83fe8cb41434af6ad7c8876560", async() => {
                WriteLiteral("\r\n                                            <input type=\"hidden\" name=\"name\"");
                BeginWriteAttribute("value", " value=\"", 2110, "\"", 2123, 1);
#nullable restore
#line 45 "D:\WebMVC\WebMVC\Views\Cart\Show.cshtml"
WriteAttributeValue("", 2118, name, 2118, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">  \r\n                                            <input type=\"number\" name=\"quantity\" min = \"1\"");
                BeginWriteAttribute("value", " value=\"", 2219, "\"", 2236, 1);
#nullable restore
#line 46 "D:\WebMVC\WebMVC\Views\Cart\Show.cshtml"
WriteAttributeValue("", 2227, quantity, 2227, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" onchange=\"this.form.submit()\">\r\n                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>");
#nullable restore
#line 49 "D:\WebMVC\WebMVC\Views\Cart\Show.cshtml"
                                   Write(price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 50 "D:\WebMVC\WebMVC\Views\Cart\Show.cshtml"
                                   Write(total);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td><a");
            BeginWriteAttribute("href", " href=\"", 2510, "\"", 2540, 2);
            WriteAttributeValue("", 2517, "/Cart/Remove?name=", 2517, 18, true);
#nullable restore
#line 51 "D:\WebMVC\WebMVC\Views\Cart\Show.cshtml"
WriteAttributeValue("", 2535, name, 2535, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\" onclick=\"return confirm(\'Are you sure you want to delete?\')\"> Delete</a></td>\r\n                                </tr>\r\n");
#nullable restore
#line 53 "D:\WebMVC\WebMVC\Views\Cart\Show.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                 </table>\r\n                 <h3>Total Amount: ");
#nullable restore
#line 56 "D:\WebMVC\WebMVC\Views\Cart\Show.cshtml"
                              Write(sum);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n             </div>\r\n         </div>\r\n         <a href=\"/Cart/CheckOut\" class=\"btn btn-success w-100\">check out</a>\r\n     </div>\r\n </section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Dictionary<string ,int>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
