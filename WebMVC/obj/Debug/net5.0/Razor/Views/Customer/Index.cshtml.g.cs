#pragma checksum "D:\WebMVC\WebMVC\Views\Customer\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4a1676d83f9b6a6c052bf01d61743a73d6328f4d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_Index), @"mvc.1.0.view", @"/Views/Customer/Index.cshtml")]
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
#line 1 "D:\WebMVC\WebMVC\Views\Customer\Index.cshtml"
using WebMVC.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\WebMVC\WebMVC\Views\Customer\Index.cshtml"
using WebMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a1676d83f9b6a6c052bf01d61743a73d6328f4d", @"/Views/Customer/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d07e873f05b36c9d83cd6a184d4bfbe1720fee4b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Customer_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<section class=""products section bg-gray"">
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-lg-3 title text-center"">
                 <h2>Category</h2>
                 <ul class=""list-group"">
                      <li class=""list-group-item list-group-item-action list-group-item-warning"" ><a href=""/Customer/List"">ALL</a></li>
");
#nullable restore
#line 11 "D:\WebMVC\WebMVC\Views\Customer\Index.cshtml"
                      
                        List<Category> listCategory = new DAOCategory().GetAllCategory();
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\WebMVC\WebMVC\Views\Customer\Index.cshtml"
                     foreach(Category category in listCategory)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"list-group-item list-group-item-action list-group-item-warning\"><a");
            BeginWriteAttribute("href", " href=\"", 768, "\"", 805, 2);
            WriteAttributeValue("", 775, "/Customer/List?ID=", 775, 18, true);
#nullable restore
#line 16 "D:\WebMVC\WebMVC\Views\Customer\Index.cshtml"
WriteAttributeValue("", 793, category.ID, 793, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 16 "D:\WebMVC\WebMVC\Views\Customer\Index.cshtml"
                                                                                                                                       Write(category.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 17 "D:\WebMVC\WebMVC\Views\Customer\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </ul>\r\n            </div>\r\n            <div class=\"col-lg-9 title text-center\">\r\n                <h2>Product</h2>\r\n                <div class=\"row\" style=\"margin-left: 3%\">\r\n");
#nullable restore
#line 23 "D:\WebMVC\WebMVC\Views\Customer\Index.cshtml"
                     foreach(Product product in Model)
                    {
                        if (product.isSell)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"col-lg-3 text-center\" style=\"border: 1px solid black; border-radius: 10px ; margin: 2%;margin-left: 3%; width: 20vw; height: 45vh\">\r\n                                <h5>");
#nullable restore
#line 28 "D:\WebMVC\WebMVC\Views\Customer\Index.cshtml"
                               Write(product.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                <img");
            BeginWriteAttribute("src", " src=\"", 1468, "\"", 1488, 1);
#nullable restore
#line 29 "D:\WebMVC\WebMVC\Views\Customer\Index.cshtml"
WriteAttributeValue("", 1474, product.Image, 1474, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"alt\" width=\"100\" height=\"100\"><br>\r\n                                <p>Price: ");
#nullable restore
#line 30 "D:\WebMVC\WebMVC\Views\Customer\Index.cshtml"
                                      Write(product.Price + "Đ");

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <button class=\"posision-fixed\" style=\"radius: 10px\" ><a");
            BeginWriteAttribute("href", " href=\"", 1688, "\"", 1730, 2);
            WriteAttributeValue("", 1695, "/Cart/Add?name=", 1695, 15, true);
#nullable restore
#line 31 "D:\WebMVC\WebMVC\Views\Customer\Index.cshtml"
WriteAttributeValue("", 1710, product.ProductName, 1710, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Add to Cart</a></button>\r\n                            </div>\r\n");
#nullable restore
#line 33 "D:\WebMVC\WebMVC\Views\Customer\Index.cshtml"
                        }
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Product>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
