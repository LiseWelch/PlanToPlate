#pragma checksum "C:\Users\Lise\Desktop\CodingDojo\cSharpStack\ORMs\Entity\project\Views\Week\DayView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ddeab60f9f763d821e2c8ea606577468dcf6e69"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Week_DayView), @"mvc.1.0.view", @"/Views/Week/DayView.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Week/DayView.cshtml", typeof(AspNetCore.Views_Week_DayView))]
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
#line 1 "C:\Users\Lise\Desktop\CodingDojo\cSharpStack\ORMs\Entity\project\Views\_ViewImports.cshtml"
using Project;

#line default
#line hidden
#line 2 "C:\Users\Lise\Desktop\CodingDojo\cSharpStack\ORMs\Entity\project\Views\_ViewImports.cshtml"
using Project.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ddeab60f9f763d821e2c8ea606577468dcf6e69", @"/Views/Week/DayView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89e31fbbec8fb4222cf117a26f28137c5b00e63f", @"/Views/_ViewImports.cshtml")]
    public class Views_Week_DayView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DayView>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Lise\Desktop\CodingDojo\cSharpStack\ORMs\Entity\project\Views\Week\DayView.cshtml"
  
    ViewData["Title"] = @Model.day.date.ToString("MM/dd/yy");
    ViewData["Username"] = Model.user.Username;

#line default
#line hidden
            BeginContext(135, 205, true);
            WriteLiteral("\r\n<div class=\"container-fluid\">\r\n    <div class=\"row justify-content-center align-items-center\" style=\"height: 85vh;\">\r\n        <div class=\"List p-2 col-sm-10\">\r\n            <input type=\"hidden\" id=\"dayid\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 340, "\"", 364, 1);
#line 10 "C:\Users\Lise\Desktop\CodingDojo\cSharpStack\ORMs\Entity\project\Views\Week\DayView.cshtml"
WriteAttributeValue("", 348, Model.day.DayID, 348, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(365, 106, true);
            WriteLiteral(">\r\n            <div class=\"row justify-content-between px-3\">\r\n                <h1 class=\"mx-2 display-4\">");
            EndContext();
            BeginContext(472, 31, false);
#line 12 "C:\Users\Lise\Desktop\CodingDojo\cSharpStack\ORMs\Entity\project\Views\Week\DayView.cshtml"
                                      Write(Model.day.date.ToString("dddd"));

#line default
#line hidden
            EndContext();
            BeginContext(503, 240, true);
            WriteLiteral("</h1>\r\n                <div class=\"bg-dark mx-2 py-2 align-self-center text-left row justify-content-end\" style=\"border-radius: 10px; width: 82%\">\r\n                    <h2 class=\"mx-4 text-light align-self-center\" style=\"font-weight: 100;\">");
            EndContext();
            BeginContext(744, 35, false);
#line 14 "C:\Users\Lise\Desktop\CodingDojo\cSharpStack\ORMs\Entity\project\Views\Week\DayView.cshtml"
                                                                                       Write(Model.day.date.ToString("MM/dd/yy"));

#line default
#line hidden
            EndContext();
            BeginContext(779, 622, true);
            WriteLiteral(@"</h2>
                </div>
            </div>
            <div class=""row p-2"">
                <div class=""col-sm-4 px-2 WeekDay border-right border-secondary"" style=""width: 12vw"">
                    <div class=""row justify-content-between align-items-center mx-2 px-2 py-1 bg-dark text-light WeekDayHeader"" style=""border-radius: 5px;"">
                        <h2 class=""m-1"">Breakfast</h2>
                    </div>
                    <div class=""form-group row mx-2 mt-3"">
                        <div class=""col-sm-10 pl-0 pr-3"">
                        <select name=""breakfast"" class=""form-control"">
");
            EndContext();
#line 25 "C:\Users\Lise\Desktop\CodingDojo\cSharpStack\ORMs\Entity\project\Views\Week\DayView.cshtml"
                             foreach (Recipe r in @Model.recipes)
                            {

#line default
#line hidden
            BeginContext(1499, 32, true);
            WriteLiteral("                                ");
            EndContext();
            BeginContext(1531, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9ddeab60f9f763d821e2c8ea606577468dcf6e696637", async() => {
                BeginContext(1581, 6, false);
#line 27 "C:\Users\Lise\Desktop\CodingDojo\cSharpStack\ORMs\Entity\project\Views\Week\DayView.cshtml"
                                                                            Write(r.Name);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
#line 27 "C:\Users\Lise\Desktop\CodingDojo\cSharpStack\ORMs\Entity\project\Views\Week\DayView.cshtml"
                                                        WriteLiteral(r.RecipeID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1596, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 28 "C:\Users\Lise\Desktop\CodingDojo\cSharpStack\ORMs\Entity\project\Views\Week\DayView.cshtml"
                            }

#line default
#line hidden
            BeginContext(1629, 314, true);
            WriteLiteral(@"                        </select>
                        </div>
                        <button type=""button"" id=""AddBRecipe"" class=""btn btn-dark btn-sm col-sm-2"">Add</button>
                    </div>
                    <div class=""CustomBar my-2 px-3 bRecipes"">
                        <h4>Recipes</h4>
");
            EndContext();
#line 35 "C:\Users\Lise\Desktop\CodingDojo\cSharpStack\ORMs\Entity\project\Views\Week\DayView.cshtml"
                         foreach (Breakfast b in @Model.day.breakfast)
                                    {

#line default
#line hidden
            BeginContext(2054, 42, true);
            WriteLiteral("                                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2096, "\"", 2123, 2);
            WriteAttributeValue("", 2103, "/recipes/", 2103, 9, true);
#line 37 "C:\Users\Lise\Desktop\CodingDojo\cSharpStack\ORMs\Entity\project\Views\Week\DayView.cshtml"
WriteAttributeValue("", 2112, b.RecipeID, 2112, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2124, 58, true);
            WriteLiteral(" id=\"b.recipe.RecipeID\" class=\"recipe B-r text-dark mx-3\">");
            EndContext();
            BeginContext(2183, 13, false);
#line 37 "C:\Users\Lise\Desktop\CodingDojo\cSharpStack\ORMs\Entity\project\Views\Week\DayView.cshtml"
                                                                                                                           Write(b.recipe.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2196, 6, true);
            WriteLiteral("</a>\r\n");
            EndContext();
#line 38 "C:\Users\Lise\Desktop\CodingDojo\cSharpStack\ORMs\Entity\project\Views\Week\DayView.cshtml"
                                    }

#line default
#line hidden
            BeginContext(2241, 582, true);
            WriteLiteral(@"                    </div>
                </div>
                <div class=""col-sm-4 px-2 WeekDay border-right border-secondary"" style=""width: 12vw"">
                    <div class=""row justify-content-between align-items-center mx-2 px-2 py-1 bg-dark text-light WeekDayHeader"" style=""border-radius: 5px;"">
                        <h2 class=""m-1"">Lunch</h2>
                    </div>
                    <div class=""form-group row mx-2 mt-3"">
                        <div class=""col-sm-10 pl-0 pr-3"">
                        <select id=""breakfast"" class=""form-control"">
");
            EndContext();
#line 48 "C:\Users\Lise\Desktop\CodingDojo\cSharpStack\ORMs\Entity\project\Views\Week\DayView.cshtml"
                             foreach (Recipe r in @Model.recipes)
                            {

#line default
#line hidden
            BeginContext(2921, 32, true);
            WriteLiteral("                                ");
            EndContext();
            BeginContext(2953, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9ddeab60f9f763d821e2c8ea606577468dcf6e6911957", async() => {
                BeginContext(3003, 6, false);
#line 50 "C:\Users\Lise\Desktop\CodingDojo\cSharpStack\ORMs\Entity\project\Views\Week\DayView.cshtml"
                                                                            Write(r.Name);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
#line 50 "C:\Users\Lise\Desktop\CodingDojo\cSharpStack\ORMs\Entity\project\Views\Week\DayView.cshtml"
                                                        WriteLiteral(r.RecipeID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3018, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 51 "C:\Users\Lise\Desktop\CodingDojo\cSharpStack\ORMs\Entity\project\Views\Week\DayView.cshtml"
                            }

#line default
#line hidden
            BeginContext(3051, 299, true);
            WriteLiteral(@"                        </select>
                        </div>
                        <button type=""button"" id=""Ladd"" class=""btn btn-dark btn-sm col-sm-2"">Add</button>
                    </div>
                    <div class=""CustomBar my-2 px-3"">
                        <h4>Recipes</h4>
");
            EndContext();
#line 58 "C:\Users\Lise\Desktop\CodingDojo\cSharpStack\ORMs\Entity\project\Views\Week\DayView.cshtml"
                         foreach (Lunch L in @Model.day.lunch)
                                    {

#line default
#line hidden
            BeginContext(3453, 42, true);
            WriteLiteral("                                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3495, "\"", 3522, 2);
            WriteAttributeValue("", 3502, "/recipes/", 3502, 9, true);
#line 60 "C:\Users\Lise\Desktop\CodingDojo\cSharpStack\ORMs\Entity\project\Views\Week\DayView.cshtml"
WriteAttributeValue("", 3511, L.RecipeID, 3511, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3523, 54, true);
            WriteLiteral(" id=\"L.recipe.RecipeID\" class=\"recipe text-dark mx-3\">");
            EndContext();
            BeginContext(3578, 13, false);
#line 60 "C:\Users\Lise\Desktop\CodingDojo\cSharpStack\ORMs\Entity\project\Views\Week\DayView.cshtml"
                                                                                                                       Write(L.recipe.Name);

#line default
#line hidden
            EndContext();
            BeginContext(3591, 6, true);
            WriteLiteral("</a>\r\n");
            EndContext();
#line 61 "C:\Users\Lise\Desktop\CodingDojo\cSharpStack\ORMs\Entity\project\Views\Week\DayView.cshtml"
                                    }

#line default
#line hidden
            BeginContext(3636, 553, true);
            WriteLiteral(@"                    </div>
                </div>
                <div class=""col-sm-4 px-2 WeekDay"" style=""width: 12vw"">
                    <div class=""row justify-content-between align-items-center mx-2 px-2 py-1 bg-dark text-light WeekDayHeader"" style=""border-radius: 5px;"">
                        <h2 class=""m-1"">Dinner</h2>
                    </div>
                    <div class=""form-group row mx-2 mt-3"">
                        <div class=""col-sm-10 pl-0 pr-3"">
                        <select id=""breakfast"" class=""form-control"">
");
            EndContext();
#line 71 "C:\Users\Lise\Desktop\CodingDojo\cSharpStack\ORMs\Entity\project\Views\Week\DayView.cshtml"
                             foreach (Recipe r in @Model.recipes)
                            {

#line default
#line hidden
            BeginContext(4287, 32, true);
            WriteLiteral("                                ");
            EndContext();
            BeginContext(4319, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9ddeab60f9f763d821e2c8ea606577468dcf6e6917218", async() => {
                BeginContext(4369, 6, false);
#line 73 "C:\Users\Lise\Desktop\CodingDojo\cSharpStack\ORMs\Entity\project\Views\Week\DayView.cshtml"
                                                                            Write(r.Name);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
#line 73 "C:\Users\Lise\Desktop\CodingDojo\cSharpStack\ORMs\Entity\project\Views\Week\DayView.cshtml"
                                                        WriteLiteral(r.RecipeID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4384, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 74 "C:\Users\Lise\Desktop\CodingDojo\cSharpStack\ORMs\Entity\project\Views\Week\DayView.cshtml"
                            }

#line default
#line hidden
            BeginContext(4417, 299, true);
            WriteLiteral(@"                        </select>
                        </div>
                        <button type=""button"" id=""edit"" class=""btn btn-dark btn-sm col-sm-2"">Add</button>
                    </div>
                    <div class=""CustomBar my-2 px-3"">
                        <h4>Recipes</h4>
");
            EndContext();
#line 81 "C:\Users\Lise\Desktop\CodingDojo\cSharpStack\ORMs\Entity\project\Views\Week\DayView.cshtml"
                         foreach (Dinner d in @Model.day.dinner)
                                    {

#line default
#line hidden
            BeginContext(4821, 42, true);
            WriteLiteral("                                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4863, "\"", 4890, 2);
            WriteAttributeValue("", 4870, "/recipes/", 4870, 9, true);
#line 83 "C:\Users\Lise\Desktop\CodingDojo\cSharpStack\ORMs\Entity\project\Views\Week\DayView.cshtml"
WriteAttributeValue("", 4879, d.RecipeID, 4879, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4891, 54, true);
            WriteLiteral(" id=\"d.recipe.RecipeID\" class=\"recipe text-dark mx-3\">");
            EndContext();
            BeginContext(4946, 13, false);
#line 83 "C:\Users\Lise\Desktop\CodingDojo\cSharpStack\ORMs\Entity\project\Views\Week\DayView.cshtml"
                                                                                                                       Write(d.recipe.Name);

#line default
#line hidden
            EndContext();
            BeginContext(4959, 6, true);
            WriteLiteral("</a>\r\n");
            EndContext();
#line 84 "C:\Users\Lise\Desktop\CodingDojo\cSharpStack\ORMs\Entity\project\Views\Week\DayView.cshtml"
                                    }

#line default
#line hidden
            BeginContext(5004, 106, true);
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DayView> Html { get; private set; }
    }
}
#pragma warning restore 1591