#pragma checksum "C:\Users\Usuario\OneDrive\Escritorio\Bootcamp C#\Web Api .NET Core\slnKarenIslas\SistemaWebMisRecetas\Views\Receta\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67f9953f5db75f10ffd0bf1b55b77f908fca91ae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Receta_Index), @"mvc.1.0.view", @"/Views/Receta/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67f9953f5db75f10ffd0bf1b55b77f908fca91ae", @"/Views/Receta/Index.cshtml")]
    #nullable restore
    public class Views_Receta_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SistemaWebMisRecetas.Models.Receta>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Usuario\OneDrive\Escritorio\Bootcamp C#\Web Api .NET Core\slnKarenIslas\SistemaWebMisRecetas\Views\Receta\Index.cshtml"
  
    ViewData["Title"] = "Index Recetas";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n     <table>\r\n        <tr>\r\n            <h1>Lista de Recetas</h1>\r\n        </tr>\r\n\r\n");
#nullable restore
#line 12 "C:\Users\Usuario\OneDrive\Escritorio\Bootcamp C#\Web Api .NET Core\slnKarenIslas\SistemaWebMisRecetas\Views\Receta\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                       <tr> \r\n                        <td>\r\n                ");
#nullable restore
#line 16 "C:\Users\Usuario\OneDrive\Escritorio\Bootcamp C#\Web Api .NET Core\slnKarenIslas\SistemaWebMisRecetas\Views\Receta\Index.cshtml"
           Write(Html.ActionLink(item.Titulo,"Details","Receta",new{id=item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                             <td>\r\n                ");
#nullable restore
#line 19 "C:\Users\Usuario\OneDrive\Escritorio\Bootcamp C#\Web Api .NET Core\slnKarenIslas\SistemaWebMisRecetas\Views\Receta\Index.cshtml"
           Write(Html.ActionLink(item.Autor,"ByNombreAutor","Receta", new{autor=item.Autor}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                        <td>\r\n");
            WriteLiteral("                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 25 "C:\Users\Usuario\OneDrive\Escritorio\Bootcamp C#\Web Api .NET Core\slnKarenIslas\SistemaWebMisRecetas\Views\Receta\Index.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
#nullable restore
#line 27 "C:\Users\Usuario\OneDrive\Escritorio\Bootcamp C#\Web Api .NET Core\slnKarenIslas\SistemaWebMisRecetas\Views\Receta\Index.cshtml"
Write(Html.ActionLink("Nuevo","Create","Receta"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SistemaWebMisRecetas.Models.Receta>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591