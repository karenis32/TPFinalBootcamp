#pragma checksum "C:\Users\Usuario\OneDrive\Escritorio\Bootcamp C#\Web Api .NET Core\TPFinalBootcamp\slnKarenIslas\SistemaWebMisRecetas\Views\Receta\ByNombreAutor.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d7cf54b0b0c8cec1af4a94c2284670a299de8266"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Receta_ByNombreAutor), @"mvc.1.0.view", @"/Views/Receta/ByNombreAutor.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7cf54b0b0c8cec1af4a94c2284670a299de8266", @"/Views/Receta/ByNombreAutor.cshtml")]
    #nullable restore
    public class Views_Receta_ByNombreAutor : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SistemaWebMisRecetas.Models.Receta>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Usuario\OneDrive\Escritorio\Bootcamp C#\Web Api .NET Core\TPFinalBootcamp\slnKarenIslas\SistemaWebMisRecetas\Views\Receta\ByNombreAutor.cshtml"
  
    ViewData["Title"] = "Recetas por Autor";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Recetas por Autor</h2>\r\n\r\n");
#nullable restore
#line 9 "C:\Users\Usuario\OneDrive\Escritorio\Bootcamp C#\Web Api .NET Core\TPFinalBootcamp\slnKarenIslas\SistemaWebMisRecetas\Views\Receta\ByNombreAutor.cshtml"
Write(Html.ActionLink("Volver","Index","Receta"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<table>\r\n    <tr>\r\n        <th>Titulo</th>\r\n        <th>Categoria</th>\r\n        <th>Ingredientes</th>\r\n        <th>Instrucciones</th>\r\n        <th>Autor</th>\r\n        <th>Apellido</th>\r\n        <th>Edad</th>\r\n        <th>Email</th>\r\n\r\n    </tr>\r\n");
#nullable restore
#line 22 "C:\Users\Usuario\OneDrive\Escritorio\Bootcamp C#\Web Api .NET Core\TPFinalBootcamp\slnKarenIslas\SistemaWebMisRecetas\Views\Receta\ByNombreAutor.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("                           <tr> \r\n                            <td>\r\n                ");
#nullable restore
#line 26 "C:\Users\Usuario\OneDrive\Escritorio\Bootcamp C#\Web Api .NET Core\TPFinalBootcamp\slnKarenIslas\SistemaWebMisRecetas\Views\Receta\ByNombreAutor.cshtml"
           Write(Html.DisplayFor(modelItem=>item.Titulo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            \r\n                            </td>\r\n                                 <td>\r\n                ");
#nullable restore
#line 30 "C:\Users\Usuario\OneDrive\Escritorio\Bootcamp C#\Web Api .NET Core\TPFinalBootcamp\slnKarenIslas\SistemaWebMisRecetas\Views\Receta\ByNombreAutor.cshtml"
           Write(Html.DisplayFor(modelItem=>item.Categoria));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                    <td>\r\n                ");
#nullable restore
#line 33 "C:\Users\Usuario\OneDrive\Escritorio\Bootcamp C#\Web Api .NET Core\TPFinalBootcamp\slnKarenIslas\SistemaWebMisRecetas\Views\Receta\ByNombreAutor.cshtml"
           Write(Html.DisplayFor(modelItem=>item.Ingredientes));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                            <td>\r\n                ");
#nullable restore
#line 36 "C:\Users\Usuario\OneDrive\Escritorio\Bootcamp C#\Web Api .NET Core\TPFinalBootcamp\slnKarenIslas\SistemaWebMisRecetas\Views\Receta\ByNombreAutor.cshtml"
           Write(Html.DisplayFor(modelItem=>item.Instrucciones));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                            <td>\r\n                ");
#nullable restore
#line 39 "C:\Users\Usuario\OneDrive\Escritorio\Bootcamp C#\Web Api .NET Core\TPFinalBootcamp\slnKarenIslas\SistemaWebMisRecetas\Views\Receta\ByNombreAutor.cshtml"
           Write(Html.DisplayFor(modelItem=>item.Autor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                              </td>\r\n                              <td>\r\n                ");
#nullable restore
#line 42 "C:\Users\Usuario\OneDrive\Escritorio\Bootcamp C#\Web Api .NET Core\TPFinalBootcamp\slnKarenIslas\SistemaWebMisRecetas\Views\Receta\ByNombreAutor.cshtml"
           Write(Html.DisplayFor(modmodelItemel=>item.Apellido));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                        <td>\r\n                ");
#nullable restore
#line 45 "C:\Users\Usuario\OneDrive\Escritorio\Bootcamp C#\Web Api .NET Core\TPFinalBootcamp\slnKarenIslas\SistemaWebMisRecetas\Views\Receta\ByNombreAutor.cshtml"
           Write(Html.DisplayFor(modelItem=>item.Edad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                            <td>\r\n                ");
#nullable restore
#line 48 "C:\Users\Usuario\OneDrive\Escritorio\Bootcamp C#\Web Api .NET Core\TPFinalBootcamp\slnKarenIslas\SistemaWebMisRecetas\Views\Receta\ByNombreAutor.cshtml"
           Write(Html.DisplayFor(modelItem=>item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                        </tr>\r\n");
#nullable restore
#line 51 "C:\Users\Usuario\OneDrive\Escritorio\Bootcamp C#\Web Api .NET Core\TPFinalBootcamp\slnKarenIslas\SistemaWebMisRecetas\Views\Receta\ByNombreAutor.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
