#pragma checksum "D:\WebMVC\WebMVC\Views\ManagerShipper\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "887747a89ee071bfb4d60ae334eb1804977c86f2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ManagerShipper_Index), @"mvc.1.0.view", @"/Views/ManagerShipper/Index.cshtml")]
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
#line 1 "D:\WebMVC\WebMVC\Views\ManagerShipper\Index.cshtml"
using WebMVC.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\WebMVC\WebMVC\Views\ManagerShipper\Index.cshtml"
using WebMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"887747a89ee071bfb4d60ae334eb1804977c86f2", @"/Views/ManagerShipper/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d07e873f05b36c9d83cd6a184d4bfbe1720fee4b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_ManagerShipper_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/ManagerShipper/UpdateActive"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"<section class=""products section bg-gray"" style=""height: 100vh"">
            <div class=""container-fluid"">
                <div class=""row"">
                    <div class=""col-lg-2 title text-center"">
                        <h2>Manager</h2>
                        <ul class=""list-group"">
                            <li class=""list-group-item"" style=""margin-left: 5%""><a href=""/ManagerAccount/Index"">Account Manager</a></li>
                            <li class=""list-group-item"" style=""margin-left: 5%""><a href=""/ManagerCustomer/Index"">Customer Manager</a></li>
                            <li class=""list-group-item"" style=""margin-left: 5%;background-color: #1bbb1b""><a href=""/ManagerShipper/Index"">Shipper Manager</a></li>
                            <li class=""list-group-item"" style=""margin-left: 5%""><a href=""/ManagerProduct/Index"">Product Manager</a></li>
                            <li class=""list-group-item"" style=""margin-left: 5%""><a href=""/ManagerOrder/Index"">Order Manager</a></li>
             ");
            WriteLiteral(@"           </ul>
                    </div >
                    <div class=""col-lg-9 title text-center"" style=""margin-left: 3%"">
                        <h2>Detail</h2> 
                          <table class=""table table-bordered"">
                            <thead>
                                <tr>
                                    <th>ID</th>
                                    <th>FullName</th>
                                    <th>Phone</th>
                                    <th>Email</th>
                                    <th>Gender</th>
                                    <th>Active</th>
                                    <th>Username</th>
                                </tr>                            
                            </thead>
                            <tbody>
");
#nullable restore
#line 31 "D:\WebMVC\WebMVC\Views\ManagerShipper\Index.cshtml"
                          
                           List<Shipper> list = new DAOShipper().GetAllShipper();
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "D:\WebMVC\WebMVC\Views\ManagerShipper\Index.cshtml"
                         foreach(Shipper shipper in list)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                           <tr>\r\n                                    <td>");
#nullable restore
#line 37 "D:\WebMVC\WebMVC\Views\ManagerShipper\Index.cshtml"
                                   Write(shipper.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 38 "D:\WebMVC\WebMVC\Views\ManagerShipper\Index.cshtml"
                                   Write(shipper.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 39 "D:\WebMVC\WebMVC\Views\ManagerShipper\Index.cshtml"
                                   Write(shipper.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 40 "D:\WebMVC\WebMVC\Views\ManagerShipper\Index.cshtml"
                                   Write(shipper.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 41 "D:\WebMVC\WebMVC\Views\ManagerShipper\Index.cshtml"
                                    Write(shipper.Gender ? "Male" : "Female");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "887747a89ee071bfb4d60ae334eb1804977c86f27653", async() => {
                WriteLiteral("\r\n                                            <input type=\"hidden\" name=\"ID\"");
                BeginWriteAttribute("value", " value=\"", 2680, "\"", 2699, 1);
#nullable restore
#line 44 "D:\WebMVC\WebMVC\Views\ManagerShipper\Index.cshtml"
WriteAttributeValue("", 2688, shipper.ID, 2688, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                            <input type=\"radio\" name=\"active\" value=\"true\" onchange=\"this.form.submit()\" ");
#nullable restore
#line 45 "D:\WebMVC\WebMVC\Views\ManagerShipper\Index.cshtml"
                                                                                                                     Write(shipper.active ? "checked" : "");

#line default
#line hidden
#nullable disable
                WriteLiteral(">Yes\r\n                                            <input type=\"radio\" name=\"active\" value=\"false\" onchange=\"this.form.submit()\" ");
#nullable restore
#line 46 "D:\WebMVC\WebMVC\Views\ManagerShipper\Index.cshtml"
                                                                                                                      Write(shipper.active ? "" : "checked");

#line default
#line hidden
#nullable disable
                WriteLiteral(">No\r\n                                        ");
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
            WriteLiteral("\r\n                                     </td>\r\n                                    <td>");
#nullable restore
#line 49 "D:\WebMVC\WebMVC\Views\ManagerShipper\Index.cshtml"
                                   Write(shipper.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>                                 \r\n                                </tr>\r\n");
#nullable restore
#line 51 "D:\WebMVC\WebMVC\Views\ManagerShipper\Index.cshtml"
                        } 

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </tbody>\r\n                        </table>\r\n               \r\n            </div>\r\n                </div>\r\n            </div>\r\n        </section>\r\n\r\n");
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
