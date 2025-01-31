#pragma checksum "C:\Users\dell\Desktop\Sajha-Library\SajhaLibrary\Views\Patron\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c4f45aea79fc2fcd06436b677f28c99cad18212"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Patron_Detail), @"mvc.1.0.view", @"/Views/Patron/Detail.cshtml")]
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
#line 1 "C:\Users\dell\Desktop\Sajha-Library\SajhaLibrary\Views\_ViewImports.cshtml"
using SajhaLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dell\Desktop\Sajha-Library\SajhaLibrary\Views\_ViewImports.cshtml"
using SajhaLibrary.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c4f45aea79fc2fcd06436b677f28c99cad18212", @"/Views/Patron/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"654cca0fceac11360b567fca040ae630bae6bda9", @"/Views/_ViewImports.cshtml")]
    public class Views_Patron_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SajhaLibrary.Models.Patron.PatronDetailModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\dell\Desktop\Sajha-Library\SajhaLibrary\Views\Patron\Detail.cshtml"
  
    ViewBag.Title = @Model.LastName + ", " + @Model.FirstName;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script src=""https://code.jquery.com/jquery-3.1.1.slim.min.js"" integrity=""sha384-A7FZj7v+d/sdmMqp/nOQwliLvUsJfDHW+k9Omg/a/EheAdgtzNs3hpfag6Ed950n"" crossorigin=""anonymous""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/tether/1.4.0/js/tether.min.js"" integrity=""sha384-DztdAPBWPRXSA/3eYEEUWrWCy7G5KFbe8fFjk5JAIxUYHKkDx6Qin1DkWx51bBrb"" crossorigin=""anonymous""></script>
    <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-alpha.6/js/bootstrap.min.js"" integrity=""sha384-vBWWzlZJ8ea9aCX4pEW3rVHjgjt7zpkNpZk+02D9phzyeVkE+jo0ieGizqPLForn"" crossorigin=""anonymous""></script>
");
            }
            );
            WriteLiteral("\r\n");
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-alpha.6/css/bootstrap.min.css\" integrity=\"sha384-rwoIResjU2yc3z8GV/NPeZWAv56rSmLldC3R/AZzGRnGxQQKnKkoFVhFQhNUwEyJ\" crossorigin=\"anonymous\">\r\n");
            }
            );
            WriteLiteral(@"
<div class=""container"">
    <div class=""header clearfix detailHeading"">
        <h2 class=""text-muted"">Patron Information</h2>
    </div>
    <div class=""jumbotron"">
        <div class=""row"">
            <div class=""col-md-4"">
                <div>
                    <h2>");
#nullable restore
#line 24 "C:\Users\dell\Desktop\Sajha-Library\SajhaLibrary\Views\Patron\Detail.cshtml"
                   Write(Model.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 24 "C:\Users\dell\Desktop\Sajha-Library\SajhaLibrary\Views\Patron\Detail.cshtml"
                                    Write(Model.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                    <div class=\"patronContact\">\r\n                        <div id=\"patronTel\">Library Card ID: ");
#nullable restore
#line 26 "C:\Users\dell\Desktop\Sajha-Library\SajhaLibrary\Views\Patron\Detail.cshtml"
                                                        Write(Model.LibraryCardId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        <div id=\"patronAddress\">Address: ");
#nullable restore
#line 27 "C:\Users\dell\Desktop\Sajha-Library\SajhaLibrary\Views\Patron\Detail.cshtml"
                                                    Write(Model.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        <div id=\"patronTel\">Telephone: ");
#nullable restore
#line 28 "C:\Users\dell\Desktop\Sajha-Library\SajhaLibrary\Views\Patron\Detail.cshtml"
                                                  Write(Model.Telephone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        <div id=\"patronDate\">Member Since: ");
#nullable restore
#line 29 "C:\Users\dell\Desktop\Sajha-Library\SajhaLibrary\Views\Patron\Detail.cshtml"
                                                      Write(Model.MemberSince);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        <div id=\"patronLibrary\">Home Library: ");
#nullable restore
#line 30 "C:\Users\dell\Desktop\Sajha-Library\SajhaLibrary\Views\Patron\Detail.cshtml"
                                                         Write(Model.HomeLibrary);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 31 "C:\Users\dell\Desktop\Sajha-Library\SajhaLibrary\Views\Patron\Detail.cshtml"
                         if (@Model.OverdueFees > 0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div id=\"patronHasFees\">Current Fees Due: $");
#nullable restore
#line 33 "C:\Users\dell\Desktop\Sajha-Library\SajhaLibrary\Views\Patron\Detail.cshtml"
                                                                  Write(Model.OverdueFees);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 34 "C:\Users\dell\Desktop\Sajha-Library\SajhaLibrary\Views\Patron\Detail.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div id=\"patronNoFees\">No Fees Currently Due.</div>\r\n");
#nullable restore
#line 38 "C:\Users\dell\Desktop\Sajha-Library\SajhaLibrary\Views\Patron\Detail.cshtml"

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-4\">\r\n                <h4>Assets Currently Checked Out</h4>\r\n");
#nullable restore
#line 45 "C:\Users\dell\Desktop\Sajha-Library\SajhaLibrary\Views\Patron\Detail.cshtml"
                 if (@Model.AssetsCheckedOut.Any())
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div id=\"patronAssets\">\r\n                        <ul>\r\n");
#nullable restore
#line 49 "C:\Users\dell\Desktop\Sajha-Library\SajhaLibrary\Views\Patron\Detail.cshtml"
                             foreach (var checkout in @Model.AssetsCheckedOut)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li>\r\n                                    ");
#nullable restore
#line 52 "C:\Users\dell\Desktop\Sajha-Library\SajhaLibrary\Views\Patron\Detail.cshtml"
                               Write(checkout.LibraryAsset.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - (Library Asset ID: ");
#nullable restore
#line 52 "C:\Users\dell\Desktop\Sajha-Library\SajhaLibrary\Views\Patron\Detail.cshtml"
                                                                                 Write(checkout.LibraryAsset.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(")\r\n                                    <ul>\r\n                                        <li>\r\n                                            Since: ");
#nullable restore
#line 55 "C:\Users\dell\Desktop\Sajha-Library\SajhaLibrary\Views\Patron\Detail.cshtml"
                                              Write(checkout.Since);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </li>\r\n                                        <li>\r\n                                            Due: ");
#nullable restore
#line 58 "C:\Users\dell\Desktop\Sajha-Library\SajhaLibrary\Views\Patron\Detail.cshtml"
                                            Write(checkout.Until);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </li>\r\n                                    </ul>\r\n                                </li>\r\n");
#nullable restore
#line 62 "C:\Users\dell\Desktop\Sajha-Library\SajhaLibrary\Views\Patron\Detail.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </ul>\r\n                    </div>\r\n");
#nullable restore
#line 65 "C:\Users\dell\Desktop\Sajha-Library\SajhaLibrary\Views\Patron\Detail.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div>No items currently checked out.</div>\r\n");
#nullable restore
#line 69 "C:\Users\dell\Desktop\Sajha-Library\SajhaLibrary\Views\Patron\Detail.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n\r\n            <div class=\"col-md-4\">\r\n                <h4>Assets Currently On Hold</h4>\r\n");
#nullable restore
#line 74 "C:\Users\dell\Desktop\Sajha-Library\SajhaLibrary\Views\Patron\Detail.cshtml"
                 if (@Model.Holds.Any())
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div id=\"patronHolds\">\r\n                        <ul>\r\n");
#nullable restore
#line 78 "C:\Users\dell\Desktop\Sajha-Library\SajhaLibrary\Views\Patron\Detail.cshtml"
                             foreach (var hold in @Model.Holds)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li>");
#nullable restore
#line 80 "C:\Users\dell\Desktop\Sajha-Library\SajhaLibrary\Views\Patron\Detail.cshtml"
                               Write(hold.LibraryAsset.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - Placed ");
#nullable restore
#line 80 "C:\Users\dell\Desktop\Sajha-Library\SajhaLibrary\Views\Patron\Detail.cshtml"
                                                                 Write(hold.HoldPlaced.ToString("yy-dd-MM - HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 81 "C:\Users\dell\Desktop\Sajha-Library\SajhaLibrary\Views\Patron\Detail.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </ul>\r\n                    </div>\r\n");
#nullable restore
#line 84 "C:\Users\dell\Desktop\Sajha-Library\SajhaLibrary\Views\Patron\Detail.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div>No items on hold.</div>\r\n");
#nullable restore
#line 88 "C:\Users\dell\Desktop\Sajha-Library\SajhaLibrary\Views\Patron\Detail.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SajhaLibrary.Models.Patron.PatronDetailModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
