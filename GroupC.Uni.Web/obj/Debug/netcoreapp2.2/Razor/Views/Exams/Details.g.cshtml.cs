#pragma checksum "C:\Users\ASUS\Desktop\Azure\GroupC.Uni.Web\Views\Exams\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e18468d20b53b6e36ce278925d2ed64f3a7077c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Exams_Details), @"mvc.1.0.view", @"/Views/Exams/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Exams/Details.cshtml", typeof(AspNetCore.Views_Exams_Details))]
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
#line 1 "C:\Users\ASUS\Desktop\Azure\GroupC.Uni.Web\Views\_ViewImports.cshtml"
using GroupC.Uni.Web;

#line default
#line hidden
#line 2 "C:\Users\ASUS\Desktop\Azure\GroupC.Uni.Web\Views\_ViewImports.cshtml"
using GroupC.Uni.Web.Models;

#line default
#line hidden
#line 3 "C:\Users\ASUS\Desktop\Azure\GroupC.Uni.Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "C:\Users\ASUS\Desktop\Azure\GroupC.Uni.Web\Views\_ViewImports.cshtml"
using GroupC.Uni.Core.Entities;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e18468d20b53b6e36ce278925d2ed64f3a7077c", @"/Views/Exams/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9c6523b3a210845cd006427ce69aedbc96e4d42", @"/Views/_ViewImports.cshtml")]
    public class Views_Exams_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GroupC.Uni.Web.ViewModels.ExamViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-github"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(48, 1148, true);
            WriteLiteral(@"<style>

    col-lg-6 h2 {
        font-size: 48px;
        color: #40424a;
        font-family: 'Josefin Sans', sans-serif;
    }

    .hero-info dl dt span {
        color: #40424a;
        display: inline-block;
        min-width: 220px;
    }

    /*.hero-info dl dd {
        font-size: 18px;
        color: #808181;
    }*/
</style>

<section class=""content"">
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-xl-10 offset-xl-1"">
                <div class=""row"">
                    <div class=""col-sm-3""> </div>
                    <div class=""col-sm-6 box-body with-border"" style=""background-color:white; border-top: 3px solid #d2d6de;"">
                        <div class=""col-sm-7"">
                            <div style=""border-bottom: 1px solid #d2d6de;"">
                                <h3>Exam Details</h3>

                            </div>
                            <div class=""hero-info"">
                                <div></di");
            WriteLiteral("v>\r\n                                <dl>\r\n                                    <dt>\r\n                                        ");
            EndContext();
            BeginContext(1197, 53, false);
#line 38 "C:\Users\ASUS\Desktop\Azure\GroupC.Uni.Web\Views\Exams\Details.cshtml"
                                   Write(Html.DisplayNameFor(model => model.DurationInMinutes));

#line default
#line hidden
            EndContext();
            BeginContext(1250, 129, true);
            WriteLiteral("\r\n\r\n                                    </dt>\r\n                                    <dd>\r\n                                        ");
            EndContext();
            BeginContext(1380, 49, false);
#line 42 "C:\Users\ASUS\Desktop\Azure\GroupC.Uni.Web\Views\Exams\Details.cshtml"
                                   Write(Html.DisplayFor(model => model.DurationInMinutes));

#line default
#line hidden
            EndContext();
            BeginContext(1429, 127, true);
            WriteLiteral("\r\n                                    </dd>\r\n                                    <dt>\r\n                                        ");
            EndContext();
            BeginContext(1557, 48, false);
#line 45 "C:\Users\ASUS\Desktop\Azure\GroupC.Uni.Web\Views\Exams\Details.cshtml"
                                   Write(Html.DisplayNameFor(model => model.ExamDateTime));

#line default
#line hidden
            EndContext();
            BeginContext(1605, 129, true);
            WriteLiteral("\r\n\r\n                                    </dt>\r\n                                    <dd>\r\n                                        ");
            EndContext();
            BeginContext(1735, 44, false);
#line 49 "C:\Users\ASUS\Desktop\Azure\GroupC.Uni.Web\Views\Exams\Details.cshtml"
                                   Write(Html.DisplayFor(model => model.ExamDateTime));

#line default
#line hidden
            EndContext();
            BeginContext(1779, 127, true);
            WriteLiteral("\r\n                                    </dd>\r\n                                    <dt>\r\n                                        ");
            EndContext();
            BeginContext(1907, 50, false);
#line 52 "C:\Users\ASUS\Desktop\Azure\GroupC.Uni.Web\Views\Exams\Details.cshtml"
                                   Write(Html.DisplayNameFor(model => model.QuestionsCount));

#line default
#line hidden
            EndContext();
            BeginContext(1957, 127, true);
            WriteLiteral("\r\n                                    </dt>\r\n                                    <dd>\r\n                                        ");
            EndContext();
            BeginContext(2085, 46, false);
#line 55 "C:\Users\ASUS\Desktop\Azure\GroupC.Uni.Web\Views\Exams\Details.cshtml"
                                   Write(Html.DisplayFor(model => model.QuestionsCount));

#line default
#line hidden
            EndContext();
            BeginContext(2131, 127, true);
            WriteLiteral("\r\n                                    </dd>\r\n                                    <dt>\r\n                                        ");
            EndContext();
            BeginContext(2259, 51, false);
#line 58 "C:\Users\ASUS\Desktop\Azure\GroupC.Uni.Web\Views\Exams\Details.cshtml"
                                   Write(Html.DisplayNameFor(model => model.CourseViewModel));

#line default
#line hidden
            EndContext();
            BeginContext(2310, 127, true);
            WriteLiteral("\r\n                                    </dt>\r\n                                    <dd>\r\n                                        ");
            EndContext();
            BeginContext(2438, 52, false);
#line 61 "C:\Users\ASUS\Desktop\Azure\GroupC.Uni.Web\Views\Exams\Details.cshtml"
                                   Write(Html.DisplayFor(model => model.CourseViewModel.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2490, 127, true);
            WriteLiteral("\r\n                                    </dd>\r\n                                    <dt>\r\n                                        ");
            EndContext();
            BeginContext(2618, 55, false);
#line 64 "C:\Users\ASUS\Desktop\Azure\GroupC.Uni.Web\Views\Exams\Details.cshtml"
                                   Write(Html.DisplayNameFor(model => model.TestCenterViewModel));

#line default
#line hidden
            EndContext();
            BeginContext(2673, 127, true);
            WriteLiteral("\r\n                                    </dt>\r\n                                    <dd>\r\n                                        ");
            EndContext();
            BeginContext(2801, 56, false);
#line 67 "C:\Users\ASUS\Desktop\Azure\GroupC.Uni.Web\Views\Exams\Details.cshtml"
                                   Write(Html.DisplayFor(model => model.TestCenterViewModel.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2857, 777, true);
            WriteLiteral(@"
                                    </dd>
                                    <dt>Questions </dt>
                                    <dd>
                                        <table class=""table"" id=""#QuestionExamTable"">
                                            <thead>
                                                <tr>
                                                    <th>Text</th>
                                                    <th>Mark</th>
                                                    <th>Topic Name</th>
                                                    <th>Choices</th>
                                                </tr>
                                            </thead>
                                            <tbody>
");
            EndContext();
#line 81 "C:\Users\ASUS\Desktop\Azure\GroupC.Uni.Web\Views\Exams\Details.cshtml"
                                                 foreach (var item in Model.ExamQuestionsViewModel)
                                                {


#line default
#line hidden
            BeginContext(3788, 119, true);
            WriteLiteral("                                                    <tr>\r\n                                                        <td> ");
            EndContext();
            BeginContext(3908, 18, false);
#line 85 "C:\Users\ASUS\Desktop\Azure\GroupC.Uni.Web\Views\Exams\Details.cshtml"
                                                        Write(item.Question.Text);

#line default
#line hidden
            EndContext();
            BeginContext(3926, 68, true);
            WriteLiteral("</td>\r\n                                                        <td> ");
            EndContext();
            BeginContext(3995, 9, false);
#line 86 "C:\Users\ASUS\Desktop\Azure\GroupC.Uni.Web\Views\Exams\Details.cshtml"
                                                        Write(item.Mark);

#line default
#line hidden
            EndContext();
            BeginContext(4004, 68, true);
            WriteLiteral("</td>\r\n                                                        <td> ");
            EndContext();
            BeginContext(4073, 23, false);
#line 87 "C:\Users\ASUS\Desktop\Azure\GroupC.Uni.Web\Views\Exams\Details.cshtml"
                                                        Write(item.Question.TopicName);

#line default
#line hidden
            EndContext();
            BeginContext(4096, 135, true);
            WriteLiteral("</td>\r\n                                                        <td>\r\n                                                            <ol>\r\n");
            EndContext();
#line 90 "C:\Users\ASUS\Desktop\Azure\GroupC.Uni.Web\Views\Exams\Details.cshtml"
                                                                 foreach (var ch in item.Question.Choices)
                                                                {
                                                                    

#line default
#line hidden
#line 93 "C:\Users\ASUS\Desktop\Azure\GroupC.Uni.Web\Views\Exams\Details.cshtml"
                                                                     if (ch.Type)
                                                                    {

#line default
#line hidden
            BeginContext(4675, 100, true);
            WriteLiteral("                                                                        <li style=\"color:limegreen\">");
            EndContext();
            BeginContext(4776, 7, false);
#line 95 "C:\Users\ASUS\Desktop\Azure\GroupC.Uni.Web\Views\Exams\Details.cshtml"
                                                                                               Write(ch.Text);

#line default
#line hidden
            EndContext();
            BeginContext(4783, 5, true);
            WriteLiteral("</li>");
            EndContext();
#line 95 "C:\Users\ASUS\Desktop\Azure\GroupC.Uni.Web\Views\Exams\Details.cshtml"
                                                                                                                 }

#line default
#line hidden
#line 96 "C:\Users\ASUS\Desktop\Azure\GroupC.Uni.Web\Views\Exams\Details.cshtml"
                                                                     if (!ch.Type)
                                                                    {

#line default
#line hidden
            BeginContext(4946, 94, true);
            WriteLiteral("                                                                        <li style=\"color:red\">");
            EndContext();
            BeginContext(5041, 7, false);
#line 98 "C:\Users\ASUS\Desktop\Azure\GroupC.Uni.Web\Views\Exams\Details.cshtml"
                                                                                         Write(ch.Text);

#line default
#line hidden
            EndContext();
            BeginContext(5048, 5, true);
            WriteLiteral("</li>");
            EndContext();
#line 98 "C:\Users\ASUS\Desktop\Azure\GroupC.Uni.Web\Views\Exams\Details.cshtml"
                                                                                                           }

#line default
#line hidden
#line 98 "C:\Users\ASUS\Desktop\Azure\GroupC.Uni.Web\Views\Exams\Details.cshtml"
                                                                                                            
                                                                }

#line default
#line hidden
            BeginContext(5123, 191, true);
            WriteLiteral("                                                            </ol>\r\n                                                        </td>\r\n\r\n                                                    </tr>\r\n");
            EndContext();
#line 104 "C:\Users\ASUS\Desktop\Azure\GroupC.Uni.Web\Views\Exams\Details.cshtml"

                                                }

#line default
#line hidden
            BeginContext(5367, 396, true);
            WriteLiteral(@"                                            </tbody>
                                        </table>
                                    </dd>
                                </dl>
                            </div>
                            <hr style=""border-top: 1px solid #d2d6de;"" />
                            <div class=""form-group center-block"">
                                ");
            EndContext();
            BeginContext(5763, 77, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e18468d20b53b6e36ce278925d2ed64f3a7077c16825", async() => {
                BeginContext(5832, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 113 "C:\Users\ASUS\Desktop\Azure\GroupC.Uni.Web\Views\Exams\Details.cshtml"
                                                                              WriteLiteral(Model.Id);

#line default
#line hidden
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
            EndContext();
            BeginContext(5840, 112, true);
            WriteLiteral("\r\n                                <a class=\"btn btn-danger delete\"\r\n                                   data-id=\"");
            EndContext();
            BeginContext(5953, 8, false);
#line 115 "C:\Users\ASUS\Desktop\Azure\GroupC.Uni.Web\Views\Exams\Details.cshtml"
                                       Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(5961, 558, true);
            WriteLiteral(@"""
                                   data-controller=""Courses""
                                   data-action=""Delete""
                                   data-body-message=""Are you sure you want to delete this question?"">
                                    delete
                                </a>
                                <div class=""clearfix""></div>

                            </div>

                        </div>
                    </div>


                </div>

            </div>
        </div>
    </div>
</section>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GroupC.Uni.Web.ViewModels.ExamViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
