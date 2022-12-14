#pragma checksum "P:\DWI-Proyect-Cont\AdminisEmpleados\Pages\Empleados\Detalles.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "869608e771403a6de60d56cb907ff193ef528bba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AdminisEmpleados.Pages.Empleados.Pages_Empleados_Detalles), @"mvc.1.0.razor-page", @"/Pages/Empleados/Detalles.cshtml")]
namespace AdminisEmpleados.Pages.Empleados
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
#line 1 "P:\DWI-Proyect-Cont\AdminisEmpleados\Pages\_ViewImports.cshtml"
using AdminisEmpleados;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "P:\DWI-Proyect-Cont\AdminisEmpleados\Pages\_ViewImports.cshtml"
using AdminisEmpleados.Modelos;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "empleado/ver/{id:min(1)}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"869608e771403a6de60d56cb907ff193ef528bba", @"/Pages/Empleados/Detalles.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3e55cff1b824ab70c5f9f8aacec583af217c887", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Empleados_Detalles : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private global::AdminisEmpleados.Pages.Empleados.Pages_Empleados_Detalles.__Generated__CabContViewComponentTagHelper __CabContViewComponentTagHelper;
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<!--Mediante el routin podemos esconder los par??metros que se est??n mandando por medio de direcciones personalizadas.-->
<!--Ejemplo: page ""{variable}"" -> page ""{id}""-->
<!--Para evitar errores con la busqueda de datos por medio de ruteo podemos personalizar la ruta por medio de la propiedad page.-->
<!--Ejemplo: page ""[NombParte]/{variable}"" -> page ""ver/{id}""-->
<!--Podemos a??adir restricciones mediante una clase que contengan reglas de ruteo con podemos personalizar la entrada de usuarios.-->
<!--Ejemplo: Creen una clase desde el proyecto en donde se encuentra el sitio web.-->
<!--En el archivo startup.cs busquen las opciones de ruteo y a??ada la restricci??n.-->
<!--Aplicaci??n page ""[Direccionamiento personalizado *opcional*]/{Variable:[Nombre de la regla]}""-->
<!--page ""empleado/ver/{id:even}""-->
");
#nullable restore
#line 12 "P:\DWI-Proyect-Cont\AdminisEmpleados\Pages\Empleados\Detalles.cshtml"
  
    ViewData["Title"] = "Detalles";
    var fotodir = $"~/images/{Model.Empleado.FotoDir ?? "noimage.jpg"}";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Detalles</h1>\r\n<div class=\"row justify-content-center m-3\">\r\n    <!--\r\n");
#nullable restore
#line 19 "P:\DWI-Proyect-Cont\AdminisEmpleados\Pages\Empleados\Detalles.cshtml"
     if (!string.IsNullOrEmpty(Model.Msg))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-sm-8\">\r\n            <div class=\"alert alert-primary\">\r\n                ");
#nullable restore
#line 23 "P:\DWI-Proyect-Cont\AdminisEmpleados\Pages\Empleados\Detalles.cshtml"
           Write(Model.Msg);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 26 "P:\DWI-Proyect-Cont\AdminisEmpleados\Pages\Empleados\Detalles.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    -->\r\n    <!--\r\n");
#nullable restore
#line 29 "P:\DWI-Proyect-Cont\AdminisEmpleados\Pages\Empleados\Detalles.cshtml"
     if (TempData["Msg"] != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-sm-8\">\r\n            <div class=\"alert alert-primary\">\r\n                ");
#nullable restore
#line 33 "P:\DWI-Proyect-Cont\AdminisEmpleados\Pages\Empleados\Detalles.cshtml"
           Write(TempData["Msg"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 36 "P:\DWI-Proyect-Cont\AdminisEmpleados\Pages\Empleados\Detalles.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    -->\r\n");
#nullable restore
#line 38 "P:\DWI-Proyect-Cont\AdminisEmpleados\Pages\Empleados\Detalles.cshtml"
     if (Model.Msg != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-sm-8\">\r\n            <div class=\"alert alert-primary\">\r\n                ");
#nullable restore
#line 42 "P:\DWI-Proyect-Cont\AdminisEmpleados\Pages\Empleados\Detalles.cshtml"
           Write(Model.Msg);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 45 "P:\DWI-Proyect-Cont\AdminisEmpleados\Pages\Empleados\Detalles.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"col-sm-8\">\r\n");
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("vc:cab-cont", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "869608e771403a6de60d56cb907ff193ef528bba8149", async() => {
            }
            );
            __CabContViewComponentTagHelper = CreateTagHelper<global::AdminisEmpleados.Pages.Empleados.Pages_Empleados_Detalles.__Generated__CabContViewComponentTagHelper>();
            __tagHelperExecutionContext.Add(__CabContViewComponentTagHelper);
#nullable restore
#line 48 "P:\DWI-Proyect-Cont\AdminisEmpleados\Pages\Empleados\Detalles.cshtml"
__CabContViewComponentTagHelper.departNom = Model.Empleado.Depart;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("depart-nom", __CabContViewComponentTagHelper.departNom, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    \r\n</div>\r\n    <div class=\"col-sm-8\">\r\n        <div class=\"card\">\r\n            <div class=\"card-header\">\r\n                <h1>");
#nullable restore
#line 54 "P:\DWI-Proyect-Cont\AdminisEmpleados\Pages\Empleados\Detalles.cshtml"
               Write(Model.Empleado.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n            </div>\r\n            <div class=\"card-body text-center\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "869608e771403a6de60d56cb907ff193ef528bba9971", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 57 "P:\DWI-Proyect-Cont\AdminisEmpleados\Pages\Empleados\Detalles.cshtml"
                                   WriteLiteral(fotodir);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 57 "P:\DWI-Proyect-Cont\AdminisEmpleados\Pages\Empleados\Detalles.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                <h4>Empleado ID: ");
#nullable restore
#line 58 "P:\DWI-Proyect-Cont\AdminisEmpleados\Pages\Empleados\Detalles.cshtml"
                            Write(Model.Empleado.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                <h4>Correo electronico: ");
#nullable restore
#line 59 "P:\DWI-Proyect-Cont\AdminisEmpleados\Pages\Empleados\Detalles.cshtml"
                                   Write(Model.Empleado.CorreoE);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                <h4>Departamento: ");
#nullable restore
#line 60 "P:\DWI-Proyect-Cont\AdminisEmpleados\Pages\Empleados\Detalles.cshtml"
                             Write(Model.Empleado.Depart);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n            </div>\r\n            <div class=\"card-footer text-center\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "869608e771403a6de60d56cb907ff193ef528bba13018", async() => {
                WriteLiteral("Volver");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                <a href=\"#\" class=\"btn btn-primary\">Editar</a>\r\n                <a href=\"#\" class=\"btn btn-danger\">Borrar</a>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AdminisEmpleados.Pages.Empleados.DetallesModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AdminisEmpleados.Pages.Empleados.DetallesModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AdminisEmpleados.Pages.Empleados.DetallesModel>)PageContext?.ViewData;
        public AdminisEmpleados.Pages.Empleados.DetallesModel Model => ViewData.Model;
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("vc:cab-cont")]
        public class __Generated__CabContViewComponentTagHelper : Microsoft.AspNetCore.Razor.TagHelpers.TagHelper
        {
            private readonly global::Microsoft.AspNetCore.Mvc.IViewComponentHelper __helper = null;
            public __Generated__CabContViewComponentTagHelper(global::Microsoft.AspNetCore.Mvc.IViewComponentHelper helper)
            {
                __helper = helper;
            }
            [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNotBoundAttribute, global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewContextAttribute]
            public global::Microsoft.AspNetCore.Mvc.Rendering.ViewContext ViewContext { get; set; }
            public AdminisEmpleados.Modelos.Departamento? departNom { get; set; }
            public override async global::System.Threading.Tasks.Task ProcessAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext __context, Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput __output)
            {
                (__helper as global::Microsoft.AspNetCore.Mvc.ViewFeatures.IViewContextAware)?.Contextualize(ViewContext);
                var __helperContent = await __helper.InvokeAsync("CabCont", new { departNom });
                __output.TagName = null;
                __output.Content.SetHtmlContent(__helperContent);
            }
        }
    }
}
#pragma warning restore 1591
