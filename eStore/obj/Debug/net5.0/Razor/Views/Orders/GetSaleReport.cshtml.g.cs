#pragma checksum "D:\FULearning\Spring2024\PRN211\Assignment3\Ass03Solution_PRN211_3W_TranVuKimAnh-main\eStore\Views\Orders\GetSaleReport.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0746bf52add89dc8b9d0a04e8e324a60f1fe547a9373bb420a9930e58bfcd28c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_GetSaleReport), @"mvc.1.0.view", @"/Views/Orders/GetSaleReport.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\FULearning\Spring2024\PRN211\Assignment3\Ass03Solution_PRN211_3W_TranVuKimAnh-main\eStore\Views\_ViewImports.cshtml"
using eStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\FULearning\Spring2024\PRN211\Assignment3\Ass03Solution_PRN211_3W_TranVuKimAnh-main\eStore\Views\_ViewImports.cshtml"
using eStore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\FULearning\Spring2024\PRN211\Assignment3\Ass03Solution_PRN211_3W_TranVuKimAnh-main\eStore\Views\Orders\GetSaleReport.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"0746bf52add89dc8b9d0a04e8e324a60f1fe547a9373bb420a9930e58bfcd28c", @"/Views/Orders/GetSaleReport.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"075db933fc649c671183c6525454b3de5089adf20bc2cfdf2d13f36fa43cb60d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Orders_GetSaleReport : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<BusinessObject.ProductForReport>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Orders", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n\n\n");
#nullable restore
#line 7 "D:\FULearning\Spring2024\PRN211\Assignment3\Ass03Solution_PRN211_3W_TranVuKimAnh-main\eStore\Views\Orders\GetSaleReport.cshtml"
  
	ViewData["Title"] = "Orders";
	Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0746bf52add89dc8b9d0a04e8e324a60f1fe547a9373bb420a9930e58bfcd28c4593", async() => {
                WriteLiteral("Go back");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<h1>Sale report</h1>

<table class=""table"">
	<thead>
		<tr>
			<th>
				<h5>Product Id</h5>
			</th>
			<th>
				<h5>Product Name</h5>
			</th>
			<th>
				<h5>Unit Price</h5>
			</th>
			<th>
				<h5>Sold amount</h5>
			</th>
		</tr>
	</thead>
	<tbody>
");
#nullable restore
#line 34 "D:\FULearning\Spring2024\PRN211\Assignment3\Ass03Solution_PRN211_3W_TranVuKimAnh-main\eStore\Views\Orders\GetSaleReport.cshtml"
   foreach (var item in Model)
		{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<tr>\n\t\t\t\t<td>\n\t\t\t\t\t");
#nullable restore
#line 38 "D:\FULearning\Spring2024\PRN211\Assignment3\Ass03Solution_PRN211_3W_TranVuKimAnh-main\eStore\Views\Orders\GetSaleReport.cshtml"
Write(Html.DisplayFor(modelItem => item.ProductId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\t\t\t\t</td>\n\t\t\t\t<td>\n\t\t\t\t\t");
#nullable restore
#line 41 "D:\FULearning\Spring2024\PRN211\Assignment3\Ass03Solution_PRN211_3W_TranVuKimAnh-main\eStore\Views\Orders\GetSaleReport.cshtml"
Write(Html.DisplayFor(modelItem => item.ProductName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\t\t\t\t</td>\n\t\t\t\t<td>\n\t\t\t\t\t");
#nullable restore
#line 44 "D:\FULearning\Spring2024\PRN211\Assignment3\Ass03Solution_PRN211_3W_TranVuKimAnh-main\eStore\Views\Orders\GetSaleReport.cshtml"
Write(Html.DisplayFor(modelItem => item.UnitPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\t\t\t\t</td>\n\t\t\t\t<td>\n\t\t\t\t\t");
#nullable restore
#line 47 "D:\FULearning\Spring2024\PRN211\Assignment3\Ass03Solution_PRN211_3W_TranVuKimAnh-main\eStore\Views\Orders\GetSaleReport.cshtml"
Write(Html.DisplayFor(modelItem => item.SoldAmount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\t\t\t\t</td>\n\t\t\t</tr>\n");
#nullable restore
#line 50 "D:\FULearning\Spring2024\PRN211\Assignment3\Ass03Solution_PRN211_3W_TranVuKimAnh-main\eStore\Views\Orders\GetSaleReport.cshtml"
		}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t</tbody>\n</table>\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
<script>
	const params = new Proxy(new URLSearchParams(window.location.search), {
		get: (searchParams, prop) => searchParams.get(prop),
	});
	var errorEl = document.getElementById(""filterMessage"");
	if(params.startDate === null && params.startDate === null) {
		errorEl.style.display = ""none"";
	}

	var startDateEl = document.getElementById(""startDate"");
	var endDateEl = document.getElementById(""endDate"");
	if(params.startDate !== null) {
		startDateEl.value = params.startDate;
	}
	if(params.endDate !== null) {
		endDateEl.value = params.endDate;
	}
</script>
");
            }
            );
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHttpContextAccessor HttpContextAccessor { get; private set; } = default!;
        #nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<BusinessObject.ProductForReport>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
