#pragma checksum "C:\Users\Lise\Desktop\CodingDojo\cSharpStack\ORMs\Entity\project\Views\Recipe\_Add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe564871de316a3b6feed4ba46582c016a8b4d83"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Recipe__Add), @"mvc.1.0.view", @"/Views/Recipe/_Add.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Recipe/_Add.cshtml", typeof(AspNetCore.Views_Recipe__Add))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe564871de316a3b6feed4ba46582c016a8b4d83", @"/Views/Recipe/_Add.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89e31fbbec8fb4222cf117a26f28137c5b00e63f", @"/Views/_ViewImports.cshtml")]
    public class Views_Recipe__Add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RecipeView>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(19, 101, true);
            WriteLiteral("\r\n<div class=\"CustomBar col-sm-8 offset-sm-2\" id=\"ItemList\" style=\"max-height: 50vh\">\r\n        <ul>\r\n");
            EndContext();
#line 5 "C:\Users\Lise\Desktop\CodingDojo\cSharpStack\ORMs\Entity\project\Views\Recipe\_Add.cshtml"
              
                foreach (Ingriedient i in @Model.items)
                    {

#line default
#line hidden
            BeginContext(216, 28, true);
            WriteLiteral("                        <li>");
            EndContext();
            BeginContext(245, 6, false);
#line 8 "C:\Users\Lise\Desktop\CodingDojo\cSharpStack\ORMs\Entity\project\Views\Recipe\_Add.cshtml"
                       Write(i.Name);

#line default
#line hidden
            EndContext();
            BeginContext(251, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(253, 11, false);
#line 8 "C:\Users\Lise\Desktop\CodingDojo\cSharpStack\ORMs\Entity\project\Views\Recipe\_Add.cshtml"
                               Write(i.AmountNum);

#line default
#line hidden
            EndContext();
            BeginContext(264, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(266, 14, false);
#line 8 "C:\Users\Lise\Desktop\CodingDojo\cSharpStack\ORMs\Entity\project\Views\Recipe\_Add.cshtml"
                                            Write(i.AmountString);

#line default
#line hidden
            EndContext();
            BeginContext(280, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 9 "C:\Users\Lise\Desktop\CodingDojo\cSharpStack\ORMs\Entity\project\Views\Recipe\_Add.cshtml"
                    }
            

#line default
#line hidden
            BeginContext(325, 21, true);
            WriteLiteral("        </ul>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RecipeView> Html { get; private set; }
    }
}
#pragma warning restore 1591
