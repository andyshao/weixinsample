#pragma checksum "D:\github\weixinsample\src\netcore3.0-mvc\Senparc.Weixin.Sample.NetCore3\Views\Home\QueryDoc.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec63c8c5507eb96da86ee57c9384bf17bead06e3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_QueryDoc), @"mvc.1.0.view", @"/Views/Home/QueryDoc.cshtml")]
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
#nullable restore
#line 1 "D:\github\weixinsample\src\netcore3.0-mvc\Senparc.Weixin.Sample.NetCore3\Views\Home\QueryDoc.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec63c8c5507eb96da86ee57c9384bf17bead06e3", @"/Views/Home/QueryDoc.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"931ae162f46de7fc281b09500bbe6dbc3f933a4d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_QueryDoc : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Senparc.Weixin.Sample.NetCore3.Models.VD.Home_IndexVD>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery.serializeJSON/jquery.serializejson.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("queryform"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("needs-validation"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "QueryResult", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-dark fw-500"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\github\weixinsample\src\netcore3.0-mvc\Senparc.Weixin.Sample.NetCore3\Views\Home\QueryDoc.cshtml"
  
    ViewBag.Title = "";


#line default
#line hidden
#nullable disable
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    <script src=\"http://res.wx.qq.com/open/js/jweixin-1.6.0.js\"></script>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ec63c8c5507eb96da86ee57c9384bf17bead06e36285", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <script>
        $('#querybtn').on('click', function () {
            var form = document.getElementById(""queryform"");
            if (form.reportValidity()) {
                var input = $('#queryform').serializeJSON();
                if (input.gno || input.bno) {
                    console.log(input);
                    var dialog = bootbox.dialog({
                        message: '<div class=""text-center""><i class=""fal fa-spinner fa-pulse fa-lg mr-1""></i> Loading...</div>',
                        closeButton: false
                    })

                    setTimeout(() => {
                        dialog.modal('hide')
                        $('#resultdiv').show();
                    }, 1000)

                } else {
                    bootbox.alert(
                        {
                            message: ""请输入查询条件"",
                            backdrop: true
                        });
                }
            }
            else {
                form.");
                WriteLiteral(@"classList.add('was-validated');
            }
        });
        $('#scanbtn1').on('click', function () {
            console.log('调用微信js sdk')
        });
        $('#scanbtn2').on('click', function () {
            console.log('调用微信js sdk')
        });
        $('#restbtn').on('click', function () {
            var form = document.getElementById(""queryform"");
            form.reset();
            form.classList.remove('was-validated');
            $('#resultdiv').hide();
        });
        $(() => {
            $('#resultdiv').hide();
        })

    </script>

    <script>
        wx.config({
            debug: false, // 开启调试模式,调用的所有api的返回值会在客户端alert出来，若要查看传入的参数，可以在pc端打开，参数信息会通过log打出，仅在pc端时才会打印。
            appId: '");
#nullable restore
#line 61 "D:\github\weixinsample\src\netcore3.0-mvc\Senparc.Weixin.Sample.NetCore3\Views\Home\QueryDoc.cshtml"
               Write(ViewBag.AppId);

#line default
#line hidden
#nullable disable
                WriteLiteral("\', // 必填，公众号的唯一标识\r\n            timestamp: \'");
#nullable restore
#line 62 "D:\github\weixinsample\src\netcore3.0-mvc\Senparc.Weixin.Sample.NetCore3\Views\Home\QueryDoc.cshtml"
                   Write(ViewBag.Timestamp);

#line default
#line hidden
#nullable disable
                WriteLiteral("\', // 必填，生成签名的时间戳\r\n            nonceStr: \'");
#nullable restore
#line 63 "D:\github\weixinsample\src\netcore3.0-mvc\Senparc.Weixin.Sample.NetCore3\Views\Home\QueryDoc.cshtml"
                  Write(ViewBag.NonceStr);

#line default
#line hidden
#nullable disable
                WriteLiteral("\', // 必填，生成签名的随机串\r\n            signature: \'");
#nullable restore
#line 64 "D:\github\weixinsample\src\netcore3.0-mvc\Senparc.Weixin.Sample.NetCore3\Views\Home\QueryDoc.cshtml"
                   Write(ViewBag.Signature);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',// 必填，签名
            jsApiList: [
                    'checkJsApi',
                    'onMenuShareTimeline',
                    'onMenuShareAppMessage',
                    'onMenuShareQQ',
                    'onMenuShareWeibo',
                    'hideMenuItems',
                    'showMenuItems',
                    'hideAllNonBaseMenuItem',
                    'showAllNonBaseMenuItem',
                    'translateVoice',
                    'startRecord',
                    'stopRecord',
                    'onRecordEnd',
                    'playVoice',
                    'pauseVoice',
                    'stopVoice',
                    'uploadVoice',
                    'downloadVoice',
                    'chooseImage',
                    'previewImage',
                    'uploadImage',
                    'downloadImage',
                    'getNetworkType',
                    'openLocation',
                    'getLocation',
                    'hideOptio");
                WriteLiteral(@"nMenu',
                    'showOptionMenu',
                    'closeWindow',
                    'scanQRCode',
                    'chooseWXPay',
                    'openProductSpecificView',
                    'addCard',
                    'chooseCard',
                    'openCard'
            ] // 必填，需要使用的JS接口列表，所有JS接口列表见附录2。详见：http://mp.weixin.qq.com/wiki/7/aaa137b55fb2e0456bf8dd9148dd613f.html
        });

        wx.error(function (res) {
            console.log(res);
            alert('验证失败');
        });
        wx.ready(function () {
                var url = '");
#nullable restore
#line 108 "D:\github\weixinsample\src\netcore3.0-mvc\Senparc.Weixin.Sample.NetCore3\Views\Home\QueryDoc.cshtml"
                       Write(Context.Request.Scheme);

#line default
#line hidden
#nullable disable
                WriteLiteral("://sdk.weixin.senparc.com\';\r\n                var link = url + \'");
#nullable restore
#line 109 "D:\github\weixinsample\src\netcore3.0-mvc\Senparc.Weixin.Sample.NetCore3\Views\Home\QueryDoc.cshtml"
                              Write(Context.Request.PathAndQuery());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"';
             var imgUrl = url + '/images/v2/ewm_01.png';
             console.log(url,link,imgUrl)
                //转发到朋友圈
                wx.onMenuShareTimeline({
                    title: 'JSSDK朋友圈转发测试',
                    link: link,
                    imgUrl: imgUrl,
                    success: function () {
                        alert('转发成功！');
                    },
                    cancel: function () {
                        alert('转发失败！');
                    }
                });
                //转发给朋友
                wx.onMenuShareAppMessage({
                    title: 'JSSDK朋友圈转发测试',
                    desc: '转发给朋友',
                    link: link,
                    imgUrl: imgUrl,
                    type: 'link',
                    dataUrl: '',
                    success: function () {
                        alert('转发成功！');
                    },
                    cancel: function () {
                        alert('转发失败！');
                   ");
                WriteLiteral(" }\r\n                });\r\n            });\r\n    </script>\r\n");
            }
            );
            WriteLiteral(@"

<div class=""row"">
    <div class=""col-xl-12"">
        <div id=""c_1"" class=""card border shadow-0 mb-g shadow-sm-hover"" data-filter-tags=""oliver kopyov"">
            <div class=""card-header pr-3 d-flex align-items-center flex-wrap"">
                <!-- we wrap header title inside a div tag with utility padding -->
                <div class=""card-title"">单证信息查询</div>
                <button onclick=""window.history.back()"" class=""btn   btn-light ml-auto waves-effect waves-themed"">
                    返回
                </button>

            </div>
            <div class=""card-body"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ec63c8c5507eb96da86ee57c9384bf17bead06e314491", async() => {
                WriteLiteral(@"
                    <div class=""form-group"">
                        <div class=""input-group"">
                            <input type=""text"" class="" form-control  rounded-0 border-top-0 border-left-0 border-right-0 px-0 bg-transparent"" placeholder=""核放单号"" name=""gno"" id=""gno"">
                            <div class=""input-group-append"">
                                <button id=""scanbtn1"" class=""btn btn-default btn-icon waves-effect waves-themed"" type=""button"">
                                    <i class=""fal fa-qrcode""></i>
                                </button>
                            </div>
                        </div>
                    </div>
                    <div class=""form-group"">
                        <div class=""input-group"">
                            <input type=""text"" class="" form-control  rounded-0 border-top-0 border-left-0 border-right-0 px-0 bg-transparent"" placeholder=""核注清单号"" name=""bno"" id=""bno"">
                            <div class=""input-group-append"">
  ");
                WriteLiteral(@"                              <button id=""scanbtn2"" class=""btn btn-default btn-icon waves-effect waves-themed"" type=""button"">
                                    <i class=""fal fa-qrcode""></i>
                                </button>
                            </div>
                        </div>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("novalidate", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
            <div class=""card-body border-faded border-left-0 border-right-0 border-bottom-0 d-flex flex-row align-items-center"">
                <button id=""querybtn"" class=""btn btn-primary ml-auto waves-effect waves-themed"" type=""submit"">查询</button>
                <button id=""restbtn"" class=""btn btn-light  ml-1 waves-effect waves-themed"" type=""reset"">重置</button>
            </div>


        </div>
    </div>
</div>
<div class=""row"" id=""resultdiv"">
    <div class=""col-xl-12"">
        <div id=""c_1"" class=""card border shadow-0 mb-g shadow-sm-hover"" data-filter-tags=""oliver kopyov"">

            <div class=""card-body pb-0 px-4 collapse show"">
                <div class=""d-flex align-items-center demo-h-spacing py-2"">
                    <div class=""d-inline-flex align-items-center text-dark"">
                        核放单号:
                    </div>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ec63c8c5507eb96da86ee57c9384bf17bead06e318604", async() => {
                WriteLiteral("\r\n                        000000000001\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
                <div class=""d-flex align-items-center demo-h-spacing py-2"">
                    <div class=""d-inline-flex align-items-center text-dark"">
                        进出标志:
                    </div>
                    <a href=""javascript:void(0);"" class=""text-dark fw-500"">
                        进口
                    </a>
                </div>
                <div class=""d-flex align-items-center demo-h-spacing py-2"">
                    <div class=""d-inline-flex align-items-center text-dark"">
                        车牌&nbsp;&nbsp;&nbsp;号:
                    </div>
                    <a href=""javascript:void(0);"" class=""text-dark fw-500"">
                        苏EX39881
                    </a>
                </div>
                <div class=""d-flex align-items-center demo-h-spacing py-2"">
                    <div class=""d-inline-flex align-items-center text-dark"">
                        绑定类型:
                    </div>
                    <a ");
            WriteLiteral("href=\"javascript:void(0);\" class=\"text-dark fw-500\">\r\n                        一单多车\r\n                    </a>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Senparc.Weixin.Sample.NetCore3.Models.VD.Home_IndexVD> Html { get; private set; }
    }
}
#pragma warning restore 1591
