#pragma checksum "C:\Users\Usuario\OneDrive\Escritorio\Bootcamp C#\Web Api .NET Core\TPFinalBootcamp\slnKarenIslas\SistemaWebMisRecetas\Views\Receta\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e806f249883be61b09127dd59df889a9e34baea4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Receta_Details), @"mvc.1.0.view", @"/Views/Receta/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e806f249883be61b09127dd59df889a9e34baea4", @"/Views/Receta/Details.cshtml")]
    #nullable restore
    public class Views_Receta_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SistemaWebMisRecetas.Models.Receta>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Usuario\OneDrive\Escritorio\Bootcamp C#\Web Api .NET Core\TPFinalBootcamp\slnKarenIslas\SistemaWebMisRecetas\Views\Receta\Details.cshtml"
  
    ViewData["Title"] = "Detalle";

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h2>Ver Detalle</h2>\r\n");
#nullable restore
#line 7 "C:\Users\Usuario\OneDrive\Escritorio\Bootcamp C#\Web Api .NET Core\TPFinalBootcamp\slnKarenIslas\SistemaWebMisRecetas\Views\Receta\Details.cshtml"
Write(Html.ActionLink("Volver","Index","Receta"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    <p>\r\n    ");
#nullable restore
#line 10 "C:\Users\Usuario\OneDrive\Escritorio\Bootcamp C#\Web Api .NET Core\TPFinalBootcamp\slnKarenIslas\SistemaWebMisRecetas\Views\Receta\Details.cshtml"
Write(Html.DisplayNameFor(model=>model.Titulo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 11 "C:\Users\Usuario\OneDrive\Escritorio\Bootcamp C#\Web Api .NET Core\TPFinalBootcamp\slnKarenIslas\SistemaWebMisRecetas\Views\Receta\Details.cshtml"
Write(Html.DisplayFor(model=>model.Titulo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </p>\r\n    <p>\r\n    ");
#nullable restore
#line 14 "C:\Users\Usuario\OneDrive\Escritorio\Bootcamp C#\Web Api .NET Core\TPFinalBootcamp\slnKarenIslas\SistemaWebMisRecetas\Views\Receta\Details.cshtml"
Write(Html.DisplayNameFor(model=>model.Categoria));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 15 "C:\Users\Usuario\OneDrive\Escritorio\Bootcamp C#\Web Api .NET Core\TPFinalBootcamp\slnKarenIslas\SistemaWebMisRecetas\Views\Receta\Details.cshtml"
Write(Html.DisplayFor(model=>model.Categoria));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </p>\r\n    <p>\r\n    ");
#nullable restore
#line 18 "C:\Users\Usuario\OneDrive\Escritorio\Bootcamp C#\Web Api .NET Core\TPFinalBootcamp\slnKarenIslas\SistemaWebMisRecetas\Views\Receta\Details.cshtml"
Write(Html.DisplayNameFor(model=>model.Ingredientes));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 19 "C:\Users\Usuario\OneDrive\Escritorio\Bootcamp C#\Web Api .NET Core\TPFinalBootcamp\slnKarenIslas\SistemaWebMisRecetas\Views\Receta\Details.cshtml"
Write(Html.DisplayFor(model=>model.Ingredientes));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </p>\r\n    <p>\r\n    ");
#nullable restore
#line 22 "C:\Users\Usuario\OneDrive\Escritorio\Bootcamp C#\Web Api .NET Core\TPFinalBootcamp\slnKarenIslas\SistemaWebMisRecetas\Views\Receta\Details.cshtml"
Write(Html.DisplayNameFor(model=>model.Instrucciones));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 23 "C:\Users\Usuario\OneDrive\Escritorio\Bootcamp C#\Web Api .NET Core\TPFinalBootcamp\slnKarenIslas\SistemaWebMisRecetas\Views\Receta\Details.cshtml"
Write(Html.DisplayFor(model=>model.Instrucciones));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </p>\r\n    <p>\r\n    ");
#nullable restore
#line 26 "C:\Users\Usuario\OneDrive\Escritorio\Bootcamp C#\Web Api .NET Core\TPFinalBootcamp\slnKarenIslas\SistemaWebMisRecetas\Views\Receta\Details.cshtml"
Write(Html.DisplayNameFor(model=>model.Autor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 27 "C:\Users\Usuario\OneDrive\Escritorio\Bootcamp C#\Web Api .NET Core\TPFinalBootcamp\slnKarenIslas\SistemaWebMisRecetas\Views\Receta\Details.cshtml"
Write(Html.DisplayFor(model=>model.Autor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </p>\r\n    <p>\r\n    ");
#nullable restore
#line 30 "C:\Users\Usuario\OneDrive\Escritorio\Bootcamp C#\Web Api .NET Core\TPFinalBootcamp\slnKarenIslas\SistemaWebMisRecetas\Views\Receta\Details.cshtml"
Write(Html.DisplayNameFor(model=>model.Apellido));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 31 "C:\Users\Usuario\OneDrive\Escritorio\Bootcamp C#\Web Api .NET Core\TPFinalBootcamp\slnKarenIslas\SistemaWebMisRecetas\Views\Receta\Details.cshtml"
Write(Html.DisplayFor(model=>model.Apellido));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </p>\r\n    <p>\r\n    ");
#nullable restore
#line 34 "C:\Users\Usuario\OneDrive\Escritorio\Bootcamp C#\Web Api .NET Core\TPFinalBootcamp\slnKarenIslas\SistemaWebMisRecetas\Views\Receta\Details.cshtml"
Write(Html.DisplayNameFor(model=>model.Edad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 35 "C:\Users\Usuario\OneDrive\Escritorio\Bootcamp C#\Web Api .NET Core\TPFinalBootcamp\slnKarenIslas\SistemaWebMisRecetas\Views\Receta\Details.cshtml"
Write(Html.DisplayFor(model=>model.Edad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </p>\r\n    <p>\r\n    ");
#nullable restore
#line 38 "C:\Users\Usuario\OneDrive\Escritorio\Bootcamp C#\Web Api .NET Core\TPFinalBootcamp\slnKarenIslas\SistemaWebMisRecetas\Views\Receta\Details.cshtml"
Write(Html.DisplayNameFor(model=>model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 39 "C:\Users\Usuario\OneDrive\Escritorio\Bootcamp C#\Web Api .NET Core\TPFinalBootcamp\slnKarenIslas\SistemaWebMisRecetas\Views\Receta\Details.cshtml"
Write(Html.DisplayFor(model=>model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </p>\r\n\r\n");
#nullable restore
#line 42 "C:\Users\Usuario\OneDrive\Escritorio\Bootcamp C#\Web Api .NET Core\TPFinalBootcamp\slnKarenIslas\SistemaWebMisRecetas\Views\Receta\Details.cshtml"
Write(Html.ActionLink("Editar","Editar","Receta",new{id= Model.Id}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 43 "C:\Users\Usuario\OneDrive\Escritorio\Bootcamp C#\Web Api .NET Core\TPFinalBootcamp\slnKarenIslas\SistemaWebMisRecetas\Views\Receta\Details.cshtml"
Write(Html.ActionLink("Eliminar","Delete","Receta",new{id= Model.Id}));

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SistemaWebMisRecetas.Models.Receta> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
