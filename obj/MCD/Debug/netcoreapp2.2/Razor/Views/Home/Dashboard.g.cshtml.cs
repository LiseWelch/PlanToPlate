#pragma checksum "C:\Users\Lise\Desktop\CodingDojo\cSharpStack\ORMs\Entity\project\Views\Home\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20a6ccf294ec1a30868ad57cbfc40c7f2bb926c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Dashboard), @"mvc.1.0.view", @"/Views/Home/Dashboard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Dashboard.cshtml", typeof(AspNetCore.Views_Home_Dashboard))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20a6ccf294ec1a30868ad57cbfc40c7f2bb926c1", @"/Views/Home/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89e31fbbec8fb4222cf117a26f28137c5b00e63f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DashboardView>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Lise\Desktop\CodingDojo\cSharpStack\ORMs\Entity\project\Views\Home\Dashboard.cshtml"
  
    ViewData["Title"] = "Dashboard";
    ViewData["Username"] = Model.user.Username;

#line default
#line hidden
            BeginContext(116, 170, true);
            WriteLiteral("\r\n<div class=\"container-fluid align-items-center\">\r\n    <div class=\"row justify-content-center\" style=\"height: 85vh;\">\r\n        <div class=\"col-sm-4 align-self-center\">\r\n");
            EndContext();
#line 10 "C:\Users\Lise\Desktop\CodingDojo\cSharpStack\ORMs\Entity\project\Views\Home\Dashboard.cshtml"
              
                for (int x = 0; x < 7; x++)
                {
                    string name = @Model.days[x].date.ToString("dddd");
                    string date = @Model.days[x].date.ToString("MM/dd/yy");
                    

#line default
#line hidden
            BeginContext(536, 30, true);
            WriteLiteral("<div class=\"Day py-2 px-4 m-4\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 566, "\"", 587, 1);
#line 15 "C:\Users\Lise\Desktop\CodingDojo\cSharpStack\ORMs\Entity\project\Views\Home\Dashboard.cshtml"
WriteAttributeValue("", 571, Model.values[x], 571, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(588, 168, true);
            WriteLiteral(">\r\n                        <div class=\"row justify-content-between align-items-center px-2 DayHeader bg-dark text-light\">\r\n                            <h1 class=\"mx-2\">");
            EndContext();
            BeginContext(757, 4, false);
#line 17 "C:\Users\Lise\Desktop\CodingDojo\cSharpStack\ORMs\Entity\project\Views\Home\Dashboard.cshtml"
                                        Write(name);

#line default
#line hidden
            EndContext();
            BeginContext(761, 52, true);
            WriteLiteral("</h1>\r\n                            <h3 class=\"mx-2\">");
            EndContext();
            BeginContext(814, 4, false);
#line 18 "C:\Users\Lise\Desktop\CodingDojo\cSharpStack\ORMs\Entity\project\Views\Home\Dashboard.cshtml"
                                        Write(date);

#line default
#line hidden
            EndContext();
            BeginContext(818, 534, true);
            WriteLiteral(@"</h3>
                        </div>
                        <div class=""DayInfo mt-3"">
                            <h4 class=""mx-3"">Breakfast</h4>
                            <p class=""mx-5"">- MDJV Ndskv dSVDvd</p>
                            <h4 class=""mx-3"">Lunch</h4>
                            <p class=""mx-5"">- MDJV Ndskv dSVDvd</p>
                            <h4 class=""mx-3"">Dinner</h4>
                            <p class=""mx-5"">- MDJV Ndskv dSVDvd</p>
                        </div>
                    </div>
");
            EndContext();
#line 29 "C:\Users\Lise\Desktop\CodingDojo\cSharpStack\ORMs\Entity\project\Views\Home\Dashboard.cshtml"
                }
            

#line default
#line hidden
            BeginContext(1386, 267, true);
            WriteLiteral(@"        </div>
        <div class=""col-sm-3"">
            <div class=""List py-2 px-2 m-4"">
                <h1 class=""bg-dark text-light text-center py-1"" style=""border-radius: 5px; font-weight: 300;"">This Week's List</h1>
                <ul class=""py-1 px-5"">
");
            EndContext();
#line 36 "C:\Users\Lise\Desktop\CodingDojo\cSharpStack\ORMs\Entity\project\Views\Home\Dashboard.cshtml"
                      
                        for (int x = 0; x < 10; x++)
                        {

#line default
#line hidden
            BeginContext(1758, 68, true);
            WriteLiteral("                            <li class=\"mx-3 my-2\">rovlgnsdvsd</li>\r\n");
            EndContext();
#line 40 "C:\Users\Lise\Desktop\CodingDojo\cSharpStack\ORMs\Entity\project\Views\Home\Dashboard.cshtml"
                        }
                    

#line default
#line hidden
            BeginContext(1876, 310, true);
            WriteLiteral(@"                </ul>
            </div>
        </div>
        <div class=""col-sm-3"">
            <div class=""List py-2 px-2 m-4"">
                <h1 class=""bg-dark text-light text-center py-1"" style=""border-radius: 5px; font-weight: 300;"">Next Week's List</h1>
                <ul class=""py-1 px-5"">
");
            EndContext();
#line 49 "C:\Users\Lise\Desktop\CodingDojo\cSharpStack\ORMs\Entity\project\Views\Home\Dashboard.cshtml"
                      
                        for (int x = 0; x < 10; x++)
                        {

#line default
#line hidden
            BeginContext(2291, 68, true);
            WriteLiteral("                            <li class=\"mx-3 my-2\">rovlgnsdvsd</li>\r\n");
            EndContext();
#line 53 "C:\Users\Lise\Desktop\CodingDojo\cSharpStack\ORMs\Entity\project\Views\Home\Dashboard.cshtml"
                        }
                    

#line default
#line hidden
            BeginContext(2409, 77, true);
            WriteLiteral("                </ul>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DashboardView> Html { get; private set; }
    }
}
#pragma warning restore 1591