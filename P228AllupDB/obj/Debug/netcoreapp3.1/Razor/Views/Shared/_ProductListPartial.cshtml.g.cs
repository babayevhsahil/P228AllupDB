#pragma checksum "C:\Users\SAHIL\Desktop\P228AllupDB\P228AllupDB\Views\Shared\_ProductListPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "49a8ea576ecf91f96afb7e4931feaa1e0a4eb651"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ProductListPartial), @"mvc.1.0.view", @"/Views/Shared/_ProductListPartial.cshtml")]
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
#line 2 "C:\Users\SAHIL\Desktop\P228AllupDB\P228AllupDB\Views\_ViewImports.cshtml"
using P228AllupDB.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\SAHIL\Desktop\P228AllupDB\P228AllupDB\Views\_ViewImports.cshtml"
using P228AllupDB.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\SAHIL\Desktop\P228AllupDB\P228AllupDB\Views\_ViewImports.cshtml"
using P228AllupDB.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\SAHIL\Desktop\P228AllupDB\P228AllupDB\Views\_ViewImports.cshtml"
using P228AllupDB.ViewsModels.Home;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49a8ea576ecf91f96afb7e4931feaa1e0a4eb651", @"/Views/Shared/_ProductListPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf4b2564de0b02084bef91eedd4b0a5c1711b643", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__ProductListPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Product>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"product-items\">\r\n    <div class=\"row product-active\">\r\n");
#nullable restore
#line 4 "C:\Users\SAHIL\Desktop\P228AllupDB\P228AllupDB\Views\Shared\_ProductListPartial.cshtml"
         for (int i = 0; i < (int)Math.Ceiling((decimal)Model.Count() / 2); i++)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-lg-2\">\r\n");
#nullable restore
#line 7 "C:\Users\SAHIL\Desktop\P228AllupDB\P228AllupDB\Views\Shared\_ProductListPartial.cshtml"
                 foreach (Product product in Model.Skip(i * 2).Take(2))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"single-product mt-30\">\r\n                        <div class=\"product-image\">\r\n                            <a href=\"single-product.html\">\r\n                                <img class=\"first-image\"");
            BeginWriteAttribute("src", " src=\"", 542, "\"", 588, 2);
            WriteAttributeValue("", 548, "assets/images/product/", 548, 22, true);
#nullable restore
#line 12 "C:\Users\SAHIL\Desktop\P228AllupDB\P228AllupDB\Views\Shared\_ProductListPartial.cshtml"
WriteAttributeValue("", 570, product.MainImage, 570, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"product\">\r\n                                <img class=\"second-image\"");
            BeginWriteAttribute("src", " src=\"", 663, "\"", 710, 2);
            WriteAttributeValue("", 669, "assets/images/product/", 669, 22, true);
#nullable restore
#line 13 "C:\Users\SAHIL\Desktop\P228AllupDB\P228AllupDB\Views\Shared\_ProductListPartial.cshtml"
WriteAttributeValue("", 691, product.HoverImage, 691, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""product"">
                            </a>
                            <ul class=""product-meta"">
                                <li><a href=""#""><i class=""icon ion-bag""></i></a></li>
                                <li><a href=""#""><i class=""icon ion-android-favorite-outline""></i></a></li>
                                <li><a href=""#""><i class=""icon ion-android-options""></i></a></li>
                                <li><a data-toggle=""modal"" data-target=""#productQuickModal"" href=""#""><i class=""icon ion-android-open""></i></a></li>
                            </ul>
");
#nullable restore
#line 21 "C:\Users\SAHIL\Desktop\P228AllupDB\P228AllupDB\Views\Shared\_ProductListPartial.cshtml"
                             if (product.DiscountedPrice > 0)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span class=\"discount-product\">-");
#nullable restore
#line 23 "C:\Users\SAHIL\Desktop\P228AllupDB\P228AllupDB\Views\Shared\_ProductListPartial.cshtml"
                                                            Write((((product.Price * 100) / product.DiscountedPrice) - 100).ToString("0.#"));

#line default
#line hidden
#nullable disable
            WriteLiteral("%</span>\r\n");
#nullable restore
#line 24 "C:\Users\SAHIL\Desktop\P228AllupDB\P228AllupDB\Views\Shared\_ProductListPartial.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </div>
                        <div class=""product-content"">
                            <ul class=""product-rating"">
                                <li class=""rating-on""><i class=""fas fa-star""></i></li>
                                <li class=""rating-on""><i class=""fas fa-star""></i></li>
                                <li class=""rating-on""><i class=""fas fa-star""></i></li>
                                <li class=""rating-on""><i class=""fas fa-star""></i></li>
                                <li class=""rating-on""><i class=""fas fa-star""></i></li>
                            </ul>
                            <h4 class=""product-title""><a href=""single-product.html"">");
#nullable restore
#line 34 "C:\Users\SAHIL\Desktop\P228AllupDB\P228AllupDB\Views\Shared\_ProductListPartial.cshtml"
                                                                               Write(product.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h4>\r\n                            <div class=\"product-price\">\r\n");
#nullable restore
#line 36 "C:\Users\SAHIL\Desktop\P228AllupDB\P228AllupDB\Views\Shared\_ProductListPartial.cshtml"
                                 if (product.DiscountedPrice > 0)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span class=\"regular-price \">€");
#nullable restore
#line 38 "C:\Users\SAHIL\Desktop\P228AllupDB\P228AllupDB\Views\Shared\_ProductListPartial.cshtml"
                                                             Write(product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                    <span class=\"price-sale\">€");
#nullable restore
#line 39 "C:\Users\SAHIL\Desktop\P228AllupDB\P228AllupDB\Views\Shared\_ProductListPartial.cshtml"
                                                         Write(product.DiscountedPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 40 "C:\Users\SAHIL\Desktop\P228AllupDB\P228AllupDB\Views\Shared\_ProductListPartial.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span class=\"price-sale\">€");
#nullable restore
#line 43 "C:\Users\SAHIL\Desktop\P228AllupDB\P228AllupDB\Views\Shared\_ProductListPartial.cshtml"
                                                         Write(product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 44 "C:\Users\SAHIL\Desktop\P228AllupDB\P228AllupDB\Views\Shared\_ProductListPartial.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </div>\r\n                        </div>\r\n                    </div> <!-- single product -->\r\n");
#nullable restore
#line 48 "C:\Users\SAHIL\Desktop\P228AllupDB\P228AllupDB\Views\Shared\_ProductListPartial.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n");
#nullable restore
#line 50 "C:\Users\SAHIL\Desktop\P228AllupDB\P228AllupDB\Views\Shared\_ProductListPartial.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div> <!-- row -->\r\n</div> <!-- product items -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Product>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
