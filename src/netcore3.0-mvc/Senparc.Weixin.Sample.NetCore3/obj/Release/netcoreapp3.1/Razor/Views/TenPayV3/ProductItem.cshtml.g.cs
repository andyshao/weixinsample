#pragma checksum "D:\github\weixinsample\src\netcore3.0-mvc\Senparc.Weixin.Sample.NetCore3\Views\TenPayV3\ProductItem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a1f04ab2aee361a895a789fd7cf82928e4f297a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TenPayV3_ProductItem), @"mvc.1.0.view", @"/Views/TenPayV3/ProductItem.cshtml")]
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
#nullable restore
#line 1 "D:\github\weixinsample\src\netcore3.0-mvc\Senparc.Weixin.Sample.NetCore3\Views\_ViewImports.cshtml"
using Senparc.Weixin.Sample.NetCore3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\github\weixinsample\src\netcore3.0-mvc\Senparc.Weixin.Sample.NetCore3\Views\_ViewImports.cshtml"
using Senparc.Weixin.Sample.NetCore3.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a1f04ab2aee361a895a789fd7cf82928e4f297a", @"/Views/TenPayV3/ProductItem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"931ae162f46de7fc281b09500bbe6dbc3f933a4d", @"/Views/_ViewImports.cshtml")]
    public class Views_TenPayV3_ProductItem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Senparc.Weixin.Sample.NetCore3.Models.ProductModel>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\github\weixinsample\src\netcore3.0-mvc\Senparc.Weixin.Sample.NetCore3\Views\TenPayV3\ProductItem.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\n<html>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3a1f04ab2aee361a895a789fd7cf82928e4f297a3629", async() => {
                WriteLiteral("\n    <meta name=\"viewport\" content=\"width=device-width\" />\n    <title>商品详情</title>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3a1f04ab2aee361a895a789fd7cf82928e4f297a4679", async() => {
                WriteLiteral("\n    <div>\n        <h1>商品名称：");
#nullable restore
#line 14 "D:\github\weixinsample\src\netcore3.0-mvc\Senparc.Weixin.Sample.NetCore3\Views\TenPayV3\ProductItem.cshtml"
            Write(Model.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>\n        <p>单价：");
#nullable restore
#line 15 "D:\github\weixinsample\src\netcore3.0-mvc\Senparc.Weixin.Sample.NetCore3\Views\TenPayV3\ProductItem.cshtml"
         Write(Model.Price.ToString("c"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\n    </div>\n    <hr />\n\n    <h2>支付方式一：H5支付</h2>\n    <p>注意：H5支付用于已经安装微信的手机客户端，使用微信外部浏览器网页内的支付。</p>\n    <p>");
#nullable restore
#line 21 "D:\github\weixinsample\src\netcore3.0-mvc\Senparc.Weixin.Sample.NetCore3\Views\TenPayV3\ProductItem.cshtml"
  Write(Html.ActionLink("点击这里使用H5支付", "H5Pay", "TenPayV3", new { productId = Model.Id, hc = Model.GetHashCode() }, null));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\n    <hr />\n\n    <h2>支付方式二：“扫一扫”支付</h2>\n    <p>\n        使用微信“扫一扫”下方二维码完成支付：<br />\n        <img");
                BeginWriteAttribute("src", " src=\"", 637, "\"", 719, 1);
#nullable restore
#line 27 "D:\github\weixinsample\src\netcore3.0-mvc\Senparc.Weixin.Sample.NetCore3\Views\TenPayV3\ProductItem.cshtml"
WriteAttributeValue("", 643, Url.Action("ProductPayCode",new{productId=Model.Id,hc=Model.GetHashCode()}), 643, 76, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" width=\"300\" />\n    </p>\n    <hr />\n\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</html>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Senparc.Weixin.Sample.NetCore3.Models.ProductModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
