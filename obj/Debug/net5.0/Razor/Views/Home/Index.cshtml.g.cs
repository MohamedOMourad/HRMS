#pragma checksum "C:\Users\HP\Desktop\HRMS\test\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "537055b30fbdf83a6e907f76c12e3ee16b92f807"
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
#line 1 "C:\Users\HP\Desktop\HRMS\test\Views\_ViewImports.cshtml"
using test;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\Desktop\HRMS\test\Views\_ViewImports.cshtml"
using test.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"537055b30fbdf83a6e907f76c12e3ee16b92f807", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04aae2d41d7a1f2a1b7badf4f453e10febdd2915", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<test.Data.ViewModels.DashboardViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-outline-danger round mb-0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Employee", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DetailsEmployee", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\HP\Desktop\HRMS\test\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    Layout = "_HomeLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""row"">
    <div class=""col-12 mt-3 mb-1"">
        <h2 class=""content-header""> Welcome in Pioneer-solutions Dashboard .. </h2>
        
    </div>
</div>
<section id=""basic-carousel"">
    <div class=""row"">
        <div class=""col-md-12 col-sm-12"">
            <div class=""card"">
                <div class=""card-body"">
                    <div class=""card-block"">
                        <div id=""carousel-example-caption"" class=""carousel slide"" data-ride=""carousel"">
                            <ol class=""carousel-indicators"">
                                <li data-target=""#carousel-example-caption"" data-slide-to=""0"" class=""active""></li>
                                <li data-target=""#carousel-example-caption"" data-slide-to=""1""></li>
                                <li data-target=""#carousel-example-caption"" data-slide-to=""2""></li>
                            </ol>
                            <div class=""carousel-inner"" role=""listbox"">
                                <div clas");
            WriteLiteral(@"s=""carousel-item active"">
                                    <img src=""/img/slide.PNG"" alt=""First slide"">
                                </div>
                                <div class=""carousel-item"">
                                    <img src=""/img/slide2.PNG"" alt=""Second slide"">
                                </div>
                                <div class=""carousel-item"">
                                    <img src=""/img/slide3.PNG"" alt=""Third slide"">
                                </div>
                            </div>
                            <a class=""carousel-control-prev"" href=""#carousel-example-caption"" role=""button"" data-slide=""prev"">
                                <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
                                <span class=""sr-only"">Previous</span>
                            </a>
                            <a class=""carousel-control-next"" href=""#carousel-example-caption"" role=""button"" data-slide=""next"">
        ");
            WriteLiteral(@"                        <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
                                <span class=""sr-only"">Next</span>
                            </a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<!-- Basic Carousel end -->
<section>
    <div class=""row match-height"">
        <div class=""col-xl-3 col-lg-6 col-12"">
            <div class=""card bg-success"" style=""height: 145px;"">
                <div class=""card-body"">
                    <div class=""px-3 py-3"">
                        <div class=""row text-white"">
                            <div class=""col-6"">
                                <h1><i class=""fa fa-usd background-round text-white p-2 font-medium-3""></i></h1>
                                <h4 class=""pt-1 m-0 text-white"">");
#nullable restore
#line 62 "C:\Users\HP\Desktop\HRMS\test\Views\Home\Index.cshtml"
                                                           Write(Model.EmployeeNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" <i class=""fa fa-long-arrow-up""></i></h4>
                            </div>
                            <div class=""col-6 text-right pl-0"">
                                <h5 class=""text-white mb-1 text-bold-900"">Employees</h5>

                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""col-xl-3 col-lg-6 col-12"">
            <div class=""card bg-danger"" style=""height: 145px;"">
                <div class=""card-body"">
                    <div class=""px-3 py-3"">
                        <div class=""row text-white"">
                            <div class=""col-6"">
                                <h1><i class=""fa fa-star-o background-round text-white p-2 font-medium-3""></i></h1>
                                <h4 class=""pt-1 m-0 text-white"">");
#nullable restore
#line 80 "C:\Users\HP\Desktop\HRMS\test\Views\Home\Index.cshtml"
                                                           Write(Model.AbsentNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" <i class=""fa fa-long-arrow-down""></i></h4>
                            </div>
                            <div class=""col-6 text-right pl-0"">
                                <h5 class=""text-white mb-1 text-bold-900"">Absent</h5>
                                <span>");
#nullable restore
#line 84 "C:\Users\HP\Desktop\HRMS\test\Views\Home\Index.cshtml"
                                 Write(Model.AbsentAvg);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" %</span>
                                <br>

                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""col-xl-3 col-lg-6 col-12"">
            <div class=""card bg-info"" style=""height: 145px;"">
                <div class=""card-body"">
                    <div class=""px-3 py-3"">
                        <div class=""row text-white"">
                            <div class=""col-6"">
                                <h1><i class=""fa fa-line-chart background-round text-white p-2 font-medium-3""></i></h1>
                                <h4 class=""pt-1 m-0 text-white"">");
#nullable restore
#line 100 "C:\Users\HP\Desktop\HRMS\test\Views\Home\Index.cshtml"
                                                           Write(Model.CheckInNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" <i class=""fa fa-long-arrow-up""></i></h4>
                            </div>
                            <div class=""col-6 text-right pl-0"">
                                <h5 class=""text-white mb-1 text-bold-900"">Attendance </h5>
                                <span>");
#nullable restore
#line 104 "C:\Users\HP\Desktop\HRMS\test\Views\Home\Index.cshtml"
                                 Write(Model.CheckInAvg);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" %</span>
                                <br>

                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""col-xl-3 col-lg-6 col-12"">
            <div class=""card bg-warning"" style=""height: 145px;"">
                <div class=""card-body"">
                    <div class=""px-3 py-3"">
                        <div class=""row text-white"">
                            <div class=""col-6"">
                                <h1><i class=""fa fa-rocket background-round text-white p-2 font-medium-3""></i></h1>
                                <h4 class=""pt-1 m-0 text-white"">");
#nullable restore
#line 120 "C:\Users\HP\Desktop\HRMS\test\Views\Home\Index.cshtml"
                                                           Write(Model.CheckOutNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" <i class=""fa fa-long-arrow-up""></i></h4>
                            </div>
                            <div class=""col-6 text-right pl-0"">
                                <h5 class=""text-white mb-1 text-bold-900"">Leave</h5>
                                <span>");
#nullable restore
#line 124 "C:\Users\HP\Desktop\HRMS\test\Views\Home\Index.cshtml"
                                 Write(Model.CheckOutAvg);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" %</span>
                                <br>

                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<!--Statistics cards Starts-->
<div class=""row match-height"">
    <div class=""col-12 col-md-8"" id=""recent-sales"">
        <div class=""card"">
            <div class=""card-header"">
                <div class=""card-title-wrap bar-primary"">
                    <h4 class=""card-title"">Recent Activites</h4>
                </div>
                <a class=""heading-elements-toggle"">
                    <i class=""la la-ellipsis-v font-medium-3""></i>
                </a>
            </div>
            <div class=""card-content mt-1"">
                <div class=""table-responsive"">
                    <table class=""table table-hover table-xl mb-0"" id=""recent-orders"">
                        <thead>
                            <tr>
                                <th class=""border");
            WriteLiteral(@"-top-0"">Emplyee id </th>
                                <th class=""border-top-0"">Employee Name </th>
                                <th class=""border-top-0"">Date </th>
                                <th class=""border-top-0"">Attendance date</th>
                                <th class=""border-top-0"">check-out date</th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 160 "C:\Users\HP\Desktop\HRMS\test\Views\Home\Index.cshtml"
                             foreach (var item in @Model.attendenceViewModels)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "537055b30fbdf83a6e907f76c12e3ee16b92f80714149", async() => {
#nullable restore
#line 164 "C:\Users\HP\Desktop\HRMS\test\Views\Home\Index.cshtml"
                                                                                                                                                                      Write(item.Id);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 164 "C:\Users\HP\Desktop\HRMS\test\Views\Home\Index.cshtml"
                                                                                                                                                     WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </td>\r\n                                    <td class=\"text-truncate\">");
#nullable restore
#line 166 "C:\Users\HP\Desktop\HRMS\test\Views\Home\Index.cshtml"
                                                         Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td class=\"text-truncate\">");
#nullable restore
#line 167 "C:\Users\HP\Desktop\HRMS\test\Views\Home\Index.cshtml"
                                                         Write(item.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td class=\"text-truncate\">");
#nullable restore
#line 168 "C:\Users\HP\Desktop\HRMS\test\Views\Home\Index.cshtml"
                                                         Write(item.CheckIn);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                    <td class=\"text-truncate\">");
#nullable restore
#line 169 "C:\Users\HP\Desktop\HRMS\test\Views\Home\Index.cshtml"
                                                         Write(item.CheckOut);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                </tr>\r\n");
#nullable restore
#line 171 "C:\Users\HP\Desktop\HRMS\test\Views\Home\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </tbody>
                    </table>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-xl-4 col-lg-12 col-12"">
        <div class=""card"">
            <div class=""card-header"">
                <div class=""card-title-wrap bar-warning"">
                    <h4 class=""card-title"">Statistics</h4>
                </div>
            </div>
            <div class=""card-body"">
                <p class=""font-medium-2 text-muted text-center pb-2"">Last 24 hours</p>
                <div id=""Stack-bar-chart"" class=""height-300 Stackbarchart mb-2"">
                </div>
            </div>
        </div>
    </div>
</div>

<footer class=""footer footer-static footer-light"">
    <p class=""clearfix text-muted text-center px-2""><span>Copyright  &copy; 2020 <a href=""#"" id=""pixinventLink"" target=""_blank"" class=""text-bold-800 primary darken-2"">Pioneer-solutions</a>, All rights reserved. </span></p>
</footer>
        
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<test.Data.ViewModels.DashboardViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
