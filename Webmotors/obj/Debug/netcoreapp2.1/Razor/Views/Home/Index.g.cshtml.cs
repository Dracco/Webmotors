#pragma checksum "C:\Users\Anderson Duarte\source\repos\Webmotors\Webmotors\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c75eb31fc96e2e08f6c124bde7d8640174b9f5f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\Anderson Duarte\source\repos\Webmotors\Webmotors\Views\_ViewImports.cshtml"
using Webmotors;

#line default
#line hidden
#line 2 "C:\Users\Anderson Duarte\source\repos\Webmotors\Webmotors\Views\_ViewImports.cshtml"
using Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c75eb31fc96e2e08f6c124bde7d8640174b9f5f", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a638a86eb31941239313a52c41488ce0f700caa", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Models.AnuncioWebmotors>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(38, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Anderson Duarte\source\repos\Webmotors\Webmotors\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page Webmotors";

#line default
#line hidden
            BeginContext(95, 716, true);
            WriteLiteral(@"


<div class=""row"">


    <div class=""col-md-12"">
        <!-- Horizontal Form -->
        <div class=""box box-info"">
            <!-- form start -->
            <div class=""box-body"">
                <table class=""table table-bordered table-striped"">
                    <thead>
                        <tr>
                            <th>ID</th>
                            <th>Marca</th>
                            <th>Modelo</th>
                            <th>Versão</th>
                            <th>KM</th>
                            <th>Ano</th>
                            <th>Ações</th>
                        </tr>
                    </thead>
                    <tbody>
");
            EndContext();
#line 30 "C:\Users\Anderson Duarte\source\repos\Webmotors\Webmotors\Views\Home\Index.cshtml"
                         foreach (var m in Model)
                        {

#line default
#line hidden
            BeginContext(889, 70, true);
            WriteLiteral("                            <tr>\r\n                                <td>");
            EndContext();
            BeginContext(960, 4, false);
#line 33 "C:\Users\Anderson Duarte\source\repos\Webmotors\Webmotors\Views\Home\Index.cshtml"
                               Write(m.ID);

#line default
#line hidden
            EndContext();
            BeginContext(964, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(1008, 7, false);
#line 34 "C:\Users\Anderson Duarte\source\repos\Webmotors\Webmotors\Views\Home\Index.cshtml"
                               Write(m.marca);

#line default
#line hidden
            EndContext();
            BeginContext(1015, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(1059, 8, false);
#line 35 "C:\Users\Anderson Duarte\source\repos\Webmotors\Webmotors\Views\Home\Index.cshtml"
                               Write(m.modelo);

#line default
#line hidden
            EndContext();
            BeginContext(1067, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(1111, 8, false);
#line 36 "C:\Users\Anderson Duarte\source\repos\Webmotors\Webmotors\Views\Home\Index.cshtml"
                               Write(m.versao);

#line default
#line hidden
            EndContext();
            BeginContext(1119, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(1163, 15, false);
#line 37 "C:\Users\Anderson Duarte\source\repos\Webmotors\Webmotors\Views\Home\Index.cshtml"
                               Write(m.quilometragem);

#line default
#line hidden
            EndContext();
            BeginContext(1178, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(1222, 5, false);
#line 38 "C:\Users\Anderson Duarte\source\repos\Webmotors\Webmotors\Views\Home\Index.cshtml"
                               Write(m.ano);

#line default
#line hidden
            EndContext();
            BeginContext(1227, 148, true);
            WriteLiteral("</td>\r\n                                <td>\r\n                                    <div class=\"btn-group\">\r\n                                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1375, "\"", 1393, 2);
            WriteAttributeValue("", 1382, "/Edit/", 1382, 6, true);
#line 41 "C:\Users\Anderson Duarte\source\repos\Webmotors\Webmotors\Views\Home\Index.cshtml"
WriteAttributeValue("", 1388, m.ID, 1388, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1394, 155, true);
            WriteLiteral(" class=\"btn btn-default\">Consultar / Editar</a>\r\n                                        <button type=\"button\" class=\"btn btn-default btnDeletar\" data-id=\"");
            EndContext();
            BeginContext(1550, 4, false);
#line 42 "C:\Users\Anderson Duarte\source\repos\Webmotors\Webmotors\Views\Home\Index.cshtml"
                                                                                                     Write(m.ID);

#line default
#line hidden
            EndContext();
            BeginContext(1554, 138, true);
            WriteLiteral("\">Deletar</button>\r\n                                    </div>\r\n                                </td>\r\n                            </tr>\r\n");
            EndContext();
#line 46 "C:\Users\Anderson Duarte\source\repos\Webmotors\Webmotors\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(1719, 749, true);
            WriteLiteral(@"

                    </tbody>
                    <tfoot>
                        <tr>
                            <td colspan=""4""></td>
                            <td><< Previous</td>
                            <td>1</td>
                            <td>Next >></td>
                        </tr>
                    </tfoot>
                </table>

            </div>

            <!-- /.box-body -->
            <div class=""box-footer"">
                <div>
                    <a href=""/Edit"" class=""btn btn-success pull-right"">Novo</a>
                </div>
            </div>
        </div>

        <!-- /.box -->
    </div>
    <!--/.col (right) -->
    <!-- /.row -->
    <!-- /.content -->

</div>


");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2486, 906, true);
                WriteLiteral(@"
    <script type=""text/javascript"">
        $(document).ready(function () {
            $("".btnDeletar"").click(function (e) {
                //Send the JSON array to Controller using AJAX.
                var btn = $(this);
                var d = { id: $(btn).data(""id"") };

                $.ajax({
                    type: ""POST"",
                    url: '/Home/Del',
                    data: d,
                    success: function (r) {
                        if (r != null && r == true) {
                            $(btn).closest(""tr"").hide();
                        }
                        else {
                            console.log(r);
                        }

                    },
                    error: function (e) {
                        console.log(e);
                    }
                });
            });

        });
    </script>
");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Models.AnuncioWebmotors>> Html { get; private set; }
    }
}
#pragma warning restore 1591
