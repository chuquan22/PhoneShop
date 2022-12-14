#pragma checksum "D:\WebMVC\WebMVC\Views\ManagerOrder\View.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d90af3612d32362c69eb50b9672a97901bd890d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ManagerOrder_View), @"mvc.1.0.view", @"/Views/ManagerOrder/View.cshtml")]
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
#nullable restore
#line 1 "D:\WebMVC\WebMVC\Views\ManagerOrder\View.cshtml"
using System.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d90af3612d32362c69eb50b9672a97901bd890d1", @"/Views/ManagerOrder/View.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d07e873f05b36c9d83cd6a184d4bfbe1720fee4b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_ManagerOrder_View : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DataTable>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@" <section class=""products section bg-gray"" style=""height: 100vh"">
            <div class=""container-fluid"">
                <div class=""row"">
                    <div class=""col-lg-2 title text-center"">
                        <h2>Manager</h2>
                        <ul class=""list-group"">
                            <li class=""list-group-item"" style=""margin-left: 5%""><a href=""/ManagerAccount/Index"">Account Manager</a></li>
                            <li class=""list-group-item"" style=""margin-left: 5%""><a href=""/ManagerCustomer/Index"">Customer Manager</a></li>
                            <li class=""list-group-item"" style=""margin-left: 5%""><a href=""/ManagerShipper/Index"">Shipper Manager</a></li>
                            <li class=""list-group-item"" style=""margin-left: 5%""><a href=""/ManagerProduct/Index"">Product Manager</a></li>
                            <li class=""list-group-item"" style=""margin-left: 5%;background-color: #1bbb1b""><a href=""/ManagerOrder/Index"">Order Manager</a></li>
            ");
            WriteLiteral(@"            </ul>
                </div >                 
                    <div class=""col-lg-9 title text-center"" style=""margin-left: 3%"">
                        <h2>Detail</h2> 
                        <table class=""table table-bordered"">
                            <thead>
                                <tr>
                                   <th>Product Name</th>
                                    <th>Image</th>
                                    <th>Price</th>
                                    <th>Quantity</th>
                                    <th>Total</th>
                                </tr>
                            </thead>
");
#nullable restore
#line 28 "D:\WebMVC\WebMVC\Views\ManagerOrder\View.cshtml"
                               
                                int sum = 0;
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tbody>                   \r\n");
#nullable restore
#line 32 "D:\WebMVC\WebMVC\Views\ManagerOrder\View.cshtml"
                                  foreach(DataRow dr in Model.Rows)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>");
#nullable restore
#line 35 "D:\WebMVC\WebMVC\Views\ManagerOrder\View.cshtml"
                                       Write(dr["ProductName"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>\r\n                                            <img");
            BeginWriteAttribute("src", " src=\"", 2209, "\"", 2227, 1);
#nullable restore
#line 37 "D:\WebMVC\WebMVC\Views\ManagerOrder\View.cshtml"
WriteAttributeValue("", 2215, dr["image"], 2215, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2228, "\"", 2234, 0);
            EndWriteAttribute();
            WriteLiteral(" width=\"50\" height=\"50\">     \r\n                                        </td>\r\n                                        <td>");
#nullable restore
#line 39 "D:\WebMVC\WebMVC\Views\ManagerOrder\View.cshtml"
                                       Write(dr["price"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 40 "D:\WebMVC\WebMVC\Views\ManagerOrder\View.cshtml"
                                       Write(dr["quantity"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 41 "D:\WebMVC\WebMVC\Views\ManagerOrder\View.cshtml"
                                        Write((int) dr["price"] * (int) dr["quantity"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 42 "D:\WebMVC\WebMVC\Views\ManagerOrder\View.cshtml"
                                          
                                            sum = sum + (int)dr["price"] * (int)dr["quantity"];
                                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </tr>\r\n");
#nullable restore
#line 46 "D:\WebMVC\WebMVC\Views\ManagerOrder\View.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </tbody>\r\n                        </table>\r\n                        <div style=\"color: orange; font-size: 20px\">Grand Total = ");
#nullable restore
#line 50 "D:\WebMVC\WebMVC\Views\ManagerOrder\View.cshtml"
                                                                             Write(sum);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </section>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DataTable> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
