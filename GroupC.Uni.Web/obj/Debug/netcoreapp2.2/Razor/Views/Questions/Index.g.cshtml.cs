#pragma checksum "C:\Users\ASUS\Desktop\Azure\GroupC.Uni.Web\Views\Questions\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "61fc750e57ddf8afac99d44ec22cd1e1481eb9a0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Questions_Index), @"mvc.1.0.view", @"/Views/Questions/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Questions/Index.cshtml", typeof(AspNetCore.Views_Questions_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61fc750e57ddf8afac99d44ec22cd1e1481eb9a0", @"/Views/Questions/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9c6523b3a210845cd006427ce69aedbc96e4d42", @"/Views/_ViewImports.cshtml")]
    public class Views_Questions_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<GroupC.Uni.Web.ViewModels.QuestionIndexViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/ChildRowForTable.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/datatables/css/jquery.dataTables.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/datatables/js/dataTables.jqueryui.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-bitbucket"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-right:10px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(70, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\ASUS\Desktop\Azure\GroupC.Uni.Web\Views\Questions\Index.cshtml"
  
    
    Layout = "~/Views/Shared/_layout.cshtml";

#line default
#line hidden
            BeginContext(132, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "61fc750e57ddf8afac99d44ec22cd1e1481eb9a06357", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(191, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(193, 79, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "61fc750e57ddf8afac99d44ec22cd1e1481eb9a07609", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(272, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(291, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(297, 70, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "61fc750e57ddf8afac99d44ec22cd1e1481eb9a09039", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(367, 8319, true);
                WriteLiteral(@"
    <script type=""text/javascript"">
        $(document).ready(function () {
            //alert(""!!!"");
        });
        //
        // Pipelining function for DataTables. To be used to the `ajax` option of DataTables
        // Copied from https://datatables.net/examples/server_side/pipeline.html
        //
        $.fn.dataTable.pipeline = function (opts) {
            // Configuration options
            var conf = $.extend({
                pages: 5,     // number of pages to cache. That means action(url) will be called in 1st, 6th, 11th ... pages
                url: '/Questions/GetFilteredItems',  // url to controller action
                data: null,   // function or object with parameters to send to the server
                method: 'GET' // Ajax HTTP method
            }, opts);

            // Private variables for storing the cache
            var cacheLower = -1;
            var cacheUpper = null;
            var cacheLastRequest = null;
            var cacheLastJson = n");
                WriteLiteral(@"ull;

            return function (request, drawCallback, settings) {
                var ajax = false;
                var requestStart = request.start;
                var drawStart = request.start;
                var requestLength = request.length;
                var requestEnd = requestStart + requestLength;

                if (settings.clearCache) {
                    // API requested that the cache be cleared
                    ajax = true;
                    settings.clearCache = false;
                }
                else if (cacheLower < 0 || requestStart < cacheLower || requestEnd > cacheUpper) {
                    // outside cached data - need to make a request
                    ajax = true;
                }

                else if (JSON.stringify(request.order) !== JSON.stringify(cacheLastRequest.order) ||
                    JSON.stringify(request.columns) !== JSON.stringify(cacheLastRequest.columns) ||
                    JSON.stringify(request.search) !== JSON.");
                WriteLiteral(@"stringify(cacheLastRequest.search)
                ) {
                    // properties changed (ordering, columns, searching)
                    ajax = true;
                }

                // Store the request for checking next time around
                cacheLastRequest = $.extend(true, {}, request);

                if (ajax) {
                    // Need data from the server
                    if (requestStart < cacheLower) {
                        requestStart = requestStart - (requestLength * (conf.pages - 1));

                        if (requestStart < 0) {
                            requestStart = 0;
                        }
                    }

                    cacheLower = requestStart;
                    cacheUpper = requestStart + (requestLength * conf.pages);

                    request.start = requestStart;
                    request.length = requestLength * conf.pages;

                    // Provide the same `data` options as DataTables.
          ");
                WriteLiteral(@"          if (typeof conf.data === 'function') {
                        // As a function it is executed with the data object as an arg
                        // for manipulation. If an object is returned, it is used as the
                        // data object to submit
                        var d = conf.data(request);
                        if (d) {
                            $.extend(request, d);
                        }
                    }
                    else if ($.isPlainObject(conf.data)) {
                        // As an object, the data given extends the default
                        $.extend(request, conf.data);
                    }

                    settings.jqXHR = $.ajax({
                        ""type"": conf.method,
                        ""url"": conf.url,
                        ""data"": request,
                        ""dataType"": ""json"",
                        ""cache"": false,
                        ""success"": function (json) {
                        ");
                WriteLiteral(@"    cacheLastJson = $.extend(true, {}, json);

                            if (cacheLower != drawStart) {
                                json.data.splice(0, drawStart - cacheLower);
                            }
                            if (requestLength >= -1) {
                                json.data.splice(requestLength, json.data.length);
                            }

                            drawCallback(json);
                        }
                    });
                }
                else {
                    json = $.extend(true, {}, cacheLastJson);
                    json.draw = request.draw; // Update the echo for each response
                    json.data.splice(0, requestStart - cacheLower);
                    json.data.splice(requestLength, json.data.length);

                    drawCallback(json);
                }
            }
        };

        // Register an API method that will empty the pipelined data, forcing an Ajax
        // fetch on the");
                WriteLiteral(@" next draw (i.e. `table.clearPipeline().draw()`)
        // Copied from https://datatables.net/examples/server_side/pipeline.html
        $.fn.dataTable.Api.register('clearPipeline()', function () {
            return this.iterator('table', function (settings) {
                settings.clearCache = true;
            });
        });
        /////////////////////
        /////RowChild
        function format(d) {
            debugger;
            var str = (d.choices_string);
            var myArray = JSON.parse(str.replace(/\(/g, '[').replace(/\)/g, ']'));
            var table = document.createElement('table');
            for (var i = 0; i < myArray.length; i++) {
                var tr = document.createElement('tr');

                //var td1 = document.createElement('td');
                var td2 = document.createElement('td');

                //var text1 = document.createTextNode('Choice');
                var text2 = document.createTextNode(myArray[i]);

                //td1.ap");
                WriteLiteral(@"pendChild(text1);
                td2.appendChild(text2);
                //tr.appendChild(td1);
                tr.appendChild(td2);

                table.appendChild(tr);
            }
            
            return table;
        }
        //
        // DataTables initialisation
        // Copied from https://datatables.net/examples/server_side/pipeline.html
        // Updated according to our data
        //
        $(document).ready(function () {
            var dt =   $('#QuestionTable').DataTable({
                ""processing"": false,
                ""serverSide"": true,
                ""searching"": true,
                ""paging"": true,
                ""ajax"": $.fn.dataTable.pipeline({
                    url: ""/Questions/GetFilteredItems"",
                    ""dataSrc"": """",
                    pages: 5 //number of pages to cache
                }),
                
                ""columns"": [
                     
                    // For Question.Id
                 ");
                WriteLiteral(@"   { ""data"": ""id"", ""name"": ""Id"" ,""visible"": false},
                    // For Question.Text
                    { ""data"": ""text"", ""name"": ""Text"" },
                    // For Question.MArk
                    { ""data"": ""mark"", ""name"": ""Mark"" },
                    // For Question.IsHtml
                    { ""data"": ""isHtml"", ""name"": ""IsHtml"" },
                     //For Question.TopicName
                    { ""data"": ""topicName"", ""name"": ""TopicName"" },
                    //Details 
                    {
                        ""class"": ""details-control"",
                        ""orderable"": false,
                        ""data"": null,
                        ""defaultContent"": """"
                        //,'render': function (data, type, row) {
                        //    return '<button class=""details-control btn btn-primary ""onclick=\'choicesClick(this)\'>Choices</button>'
                        //}
                    },
                    {
                        'data': null,");
                WriteLiteral(" \"orderable\": false,\r\n                        \'render\': function (data, type, row) {\r\n                            var myUrl = \'");
                EndContext();
                BeginContext(8687, 33, false);
#line 200 "C:\Users\ASUS\Desktop\Azure\GroupC.Uni.Web\Views\Questions\Index.cshtml"
                                    Write(Url.Action("Delete", "Questions"));

#line default
#line hidden
                EndContext();
                BeginContext(8720, 2990, true);
                WriteLiteral(@"/' + row.id;
                            return '  <button class=""btn btn-info"" id=""' + row.id + '"" onclick=\'detailsClick(""' + row.id +'"")\'>Details</button>'
                                + '  <button class=""btn btn-primary"" id=""' + row.id + '"" onclick=\'editClick(""' + row.id +'"")\'>Edit</button>'
                                + '  <button class=""btn btn-danger"" id=""' + row.id + '"" onclick=\'deleteClick(""' + row.id + '"")\'>Delete</button>'
                             
                        }
                    }
                    //+ ' <a href=\""' + myUrl + '\"" "">  delete</a>'
                    //+ '<a class=""btn btn-sm delete"" data-id=""' + row.id + '"" data-controller=\'Questions\' data-action=\'Delete\' data-body-message=\'Are you sure you want to delete this Course?\'>delete</a>'
                    //+ '  <button class=""btn btn-danger"" id=""' + row.id + '"" onclick=""data-id=""' + row.id + '"" data-controller=\""Questions\"" data-action=""\Delete\"" data-body-message=""Are you sure you want to");
                WriteLiteral(@" delete this Course?"">Delete</button>'

                ]
            });
            //ChildRows
            // Array to track the ids of the details displayed rows
            var detailRows = [];

            $('#QuestionTable tbody').on('click', 'tr td.details-control', function () {
                debugger;
            //function choicesClick(obj) {
                debugger;
                var tr = $(this).closest('tr');
                var row = dt.row(tr);
                var idx = $.inArray(tr.attr('id'), detailRows);

                if (row.child.isShown()) {
                    
                    tr.removeClass('details');
                    row.child.hide();

                    // Remove from the 'open' array
                    detailRows.splice(idx, 1);
                }
                else {
                    tr.addClass('details');
                    row.child(format(row.data())).show();

                    // Add to the 'open' array
                    ");
                WriteLiteral(@"if (idx === -1) {
                        detailRows.push(tr.attr('id'));
                    }
                }
            
            });

            // On each draw, loop over the `detailRows` array and show any child rows
            dt.on('draw', function () {
                $.each(detailRows, function (i, id) {
                    $('#' + id + ' td.details-control').trigger('click');
                });
            });
            
        });
       
        //Edit button listener
        function editClick(id) {
            window.location.replace(""/Questions/Edit/"" + id);
            }
        //Delete button listener
        function deleteClick(id) {
            window.location.replace(""/Questions/Delete/"" + id);
             }
        //Details button listener
        function detailsClick(id) {
            window.location.replace(""/Questions/Details/"" + id);
        }
    </script>
");
                EndContext();
            }
            );
            BeginContext(11713, 222, true);
            WriteLiteral("<section class=\"content\">\r\n    <div class=\"box\" style=\"padding: 20px\">\r\n        <div class=\"box-header\">\r\n            <h2 class=\"box-title\">Questions</h2>\r\n        </div>\r\n        <p style=\"text-align:right\">\r\n            ");
            EndContext();
            BeginContext(11935, 105, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "61fc750e57ddf8afac99d44ec22cd1e1481eb9a022866", async() => {
                BeginContext(12017, 19, true);
                WriteLiteral("Create New Question");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(12040, 126, true);
            WriteLiteral("\r\n        </p>\r\n\r\n        <table id=\"QuestionTable\" class=\"table table-striped\" >\r\n            <thead>\r\n                <tr>\r\n");
            EndContext();
            BeginContext(12201, 55, true);
            WriteLiteral("                    <th >\r\n                            ");
            EndContext();
            BeginContext(12257, 38, false);
#line 282 "C:\Users\ASUS\Desktop\Azure\GroupC.Uni.Web\Views\Questions\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(12295, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(12375, 40, false);
#line 285 "C:\Users\ASUS\Desktop\Azure\GroupC.Uni.Web\Views\Questions\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Text));

#line default
#line hidden
            EndContext();
            BeginContext(12415, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(12495, 40, false);
#line 288 "C:\Users\ASUS\Desktop\Azure\GroupC.Uni.Web\Views\Questions\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Mark));

#line default
#line hidden
            EndContext();
            BeginContext(12535, 55, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n");
            EndContext();
            BeginContext(12663, 86, true);
            WriteLiteral("                        Is Html\r\n                    </th>\r\n                    <th>\r\n");
            EndContext();
            BeginContext(12825, 101, true);
            WriteLiteral("                        Topic Name\r\n                    </th>\r\n                    <th>Choices</th>\r\n");
            EndContext();
            BeginContext(13024, 173, true);
            WriteLiteral("                    <th>\r\n                        Actions\r\n                    </th>\r\n                </tr>\r\n            </thead>\r\n        </table>\r\n    </div>\r\n</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<GroupC.Uni.Web.ViewModels.QuestionIndexViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591