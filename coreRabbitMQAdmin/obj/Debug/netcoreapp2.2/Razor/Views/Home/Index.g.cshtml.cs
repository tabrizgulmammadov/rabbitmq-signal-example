#pragma checksum "C:\Users\Lenovo\source\repos\SignalrAndRabbitMQ\coreRabbitMQAdmin\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b43db8637735b0ca82d38c9ac23edfc3d43da2c7"
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
#line 1 "C:\Users\Lenovo\source\repos\SignalrAndRabbitMQ\coreRabbitMQAdmin\Views\_ViewImports.cshtml"
using coreRabbitMQAdmin;

#line default
#line hidden
#line 2 "C:\Users\Lenovo\source\repos\SignalrAndRabbitMQ\coreRabbitMQAdmin\Views\_ViewImports.cshtml"
using coreRabbitMQAdmin.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b43db8637735b0ca82d38c9ac23edfc3d43da2c7", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"854153b46cdd6e8f4d6fb6a73d65d6ff40d35d7f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Stoc>>
    {
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
            BeginContext(19, 398, true);
            WriteLiteral(@"<script>
    function setValue(selectedOption)
    {
        var price=selectedOption.getAttribute('price');
        document.getElementById(""Value"").value=price;

        var stocID=selectedOption.id;
        document.getElementById(""ID"").value=stocID;
    }
</script>
<div class=""container"">
    <div class=""jumbotron"">
        <h3>Kağıt Fiyatını Güncelle</h3>
    </div>
    <hr>
");
            EndContext();
#line 17 "C:\Users\Lenovo\source\repos\SignalrAndRabbitMQ\coreRabbitMQAdmin\Views\Home\Index.cshtml"
     using (Html.BeginForm("Push", "Home", "FormMethod.Post"))
    {

#line default
#line hidden
            BeginContext(488, 132, true);
            WriteLiteral("        <label>Kağıt Çeşidi:</label>\r\n        <select name=\"Name\" id=\"Name\" onchange=\"setValue(this.options[this.selectedIndex])\">\r\n");
            EndContext();
#line 21 "C:\Users\Lenovo\source\repos\SignalrAndRabbitMQ\coreRabbitMQAdmin\Views\Home\Index.cshtml"
             foreach (var stock in Model)
            {

#line default
#line hidden
            BeginContext(678, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(694, 84, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b43db8637735b0ca82d38c9ac23edfc3d43da2c74379", async() => {
                BeginContext(759, 10, false);
#line 23 "C:\Users\Lenovo\source\repos\SignalrAndRabbitMQ\coreRabbitMQAdmin\Views\Home\Index.cshtml"
                                                                           Write(stock.Name);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 23 "C:\Users\Lenovo\source\repos\SignalrAndRabbitMQ\coreRabbitMQAdmin\Views\Home\Index.cshtml"
                   WriteLiteral(stock.Name);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 23 "C:\Users\Lenovo\source\repos\SignalrAndRabbitMQ\coreRabbitMQAdmin\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 726, stock.ID, 726, 9, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "price", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 23 "C:\Users\Lenovo\source\repos\SignalrAndRabbitMQ\coreRabbitMQAdmin\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 744, stock.Value, 744, 12, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(778, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 24 "C:\Users\Lenovo\source\repos\SignalrAndRabbitMQ\coreRabbitMQAdmin\Views\Home\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(795, 193, true);
            WriteLiteral("        </select>\r\n        <input type=\"text\" name=\"Value\" id=\"Value\">\r\n        <input type=\"hidden\" name=\"ID\" id=\"ID\">\r\n        <input type=\"submit\" value=\"Güncelle\" class=\"btn btn-success\">\r\n");
            EndContext();
#line 29 "C:\Users\Lenovo\source\repos\SignalrAndRabbitMQ\coreRabbitMQAdmin\Views\Home\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(995, 8, true);
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Stoc>> Html { get; private set; }
    }
}
#pragma warning restore 1591
