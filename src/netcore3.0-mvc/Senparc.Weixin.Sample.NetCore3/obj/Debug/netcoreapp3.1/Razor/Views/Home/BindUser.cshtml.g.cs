#pragma checksum "D:\github\weixinsample\src\netcore3.0-mvc\Senparc.Weixin.Sample.NetCore3\Views\Home\BindUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "803c7d845bcc35e6fb0b80ec2adcae85bf6e9e8b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_BindUser), @"mvc.1.0.view", @"/Views/Home/BindUser.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"803c7d845bcc35e6fb0b80ec2adcae85bf6e9e8b", @"/Views/Home/BindUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"931ae162f46de7fc281b09500bbe6dbc3f933a4d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_BindUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Senparc.Weixin.Sample.NetCore3.Models.VD.Home_IndexVD>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/notifications/toastr/toastr.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery.serializeJSON/jquery.serializejson.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/notifications/toastr/toastr.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("bindform"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("needs-validation"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\github\weixinsample\src\netcore3.0-mvc\Senparc.Weixin.Sample.NetCore3\Views\Home\BindUser.cshtml"
  
    ViewBag.Title = "";


#line default
#line hidden
#nullable disable
            DefineSection("styles", async() => {
                WriteLiteral(" \r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "803c7d845bcc35e6fb0b80ec2adcae85bf6e9e8b5991", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n");
            }
            );
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "803c7d845bcc35e6fb0b80ec2adcae85bf6e9e8b7298", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "803c7d845bcc35e6fb0b80ec2adcae85bf6e9e8b8397", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <script type=""text/javascript"">
        $(() => {
            
            var token =  localStorage.getItem(""token"");
            var openid = localStorage.getItem(""openid"");
            console.log(openid, token);
            if (token) {
                console.log(token);
                window.location.href = '/Home/QrCode';
            } else {
                console.log('no token');
            }

            function uuidv4() {
                return 'xxxxxxxx-xxxx-4xxx-yxxx-xxxxxxxxxxxx'.replace(/[xy]/g, function (c) {
                    var r = Math.random() * 16 | 0, v = c == 'x' ? r : (r & 0x3 | 0x8);
                    return v.toString(16);
                });
            }
            $('#bindingbtn').on('click', function () {
                var form = document.getElementById(""bindform"");
                if (form.reportValidity()) {
                    var user = $('#bindform').serializeJSON();
                    if (openid != null) {
                        u");
                WriteLiteral(@"ser.openid = openid;
                    }
                    else {
                        user.openid = uuidv4();;
                    }
                    console.log(user);
                    var dialog = bootbox.dialog({
                        message: '<p class=""text-center mb-0""><i class=""fal fa-spin fa-spinner""></i> 请等待...</p>',
                        closeButton: false
                    });
                    var data = JSON.stringify({ username: user.username, openid: user.openid });
                    var url = `");
#nullable restore
#line 50 "D:\github\weixinsample\src\netcore3.0-mvc\Senparc.Weixin.Sample.NetCore3\Views\Home\BindUser.cshtml"
                          Write(ViewBag.apihost);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"/api/user/login?token=&loginMark=${user.openid}&data=${data}`;
                    console.log(url);
                    $.post(url).done(res => {
                        setTimeout(() => {
                            dialog.modal('hide');
                        }, 500)
                        console.log(res);
                        //debugger;
                        if (res.code == 200) {
                            showinfo('绑定成功')
                            localStorage.setItem(""token"", res.data.baseinfo.token);
                            localStorage.setItem(""username"", user.username);
                            localStorage.setItem(""openid"", user.openid);
                            window.location.href = '/Home/QrCode';
                        } else {
                            console.log(res.info)
                            if (res.info.includes('此账户已经绑定')) {
                                bootbox.confirm({
                                    message: ""此账户已经绑定,你可以解绑后重新绑定吗?");
                WriteLiteral(@""",
                                    buttons: {
                                        confirm: {
                                            label: '解绑',
                                            className: 'btn-danger'
                                        },
                                        cancel: {
                                            label: '取消',
                                            className: 'btn-success'
                                        }
                                    },
                                    callback:function(result) {
                                        /* your callback code */
                                        console.log(result)

                                        var url = `");
#nullable restore
#line 83 "D:\github\weixinsample\src\netcore3.0-mvc\Senparc.Weixin.Sample.NetCore3\Views\Home\BindUser.cshtml"
                                              Write(ViewBag.apihost);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"/api/user/cancel?token=&loginMark=${user.openid}&data=${data}`;
                                        $.post(url).done(res => {
                                            console.log(res)
                                            if (res.code == 200) {
                                                showinfo('解绑成功')
                                            } else {

                                            }
                                        })


                                    }
                                })
                            } else {
                                bootbox.alert(res.info);
                            }
                        }



                       // window.location.href = '/Home/QrCode';
                    })

                }
                else {
                    form.classList.add('was-validated');
                }
            });
            $('#restbtn').on('click', function () {
                var form = d");
                WriteLiteral(@"ocument.getElementById(""bindform"");
                form.reset();
                form.classList.remove('was-validated');
            });
        })

        function showinfo(msg) {
            toastr[""info""](msg)

            toastr.options = {
                ""closeButton"": false,
                ""debug"": false,
                ""newestOnTop"": true,
                ""progressBar"": false,
                ""positionClass"": ""toast-top-center"",
                ""preventDuplicates"": false,
                ""onclick"": null,
                ""showDuration"": 300,
                ""hideDuration"": 100,
                ""timeOut"": 5000,
                ""extendedTimeOut"": 1000,
                ""showEasing"": ""swing"",
                ""hideEasing"": ""linear"",
                ""showMethod"": ""fadeIn"",
                ""hideMethod"": ""fadeOut""
            }
        }
    </script>
");
            }
            );
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-xl-12"">
        <div id=""c_1"" class=""card border shadow-0 mb-g shadow-sm-hover"" data-filter-tags=""oliver kopyov"">
            <div class=""card-header pr-3 d-flex align-items-center flex-wrap"">
                <!-- we wrap header title inside a div tag with utility padding -->
                <div class=""card-title"">绑定用户</div>
                <button onclick=""window.history.back()"" class=""btn   btn-light ml-auto waves-effect waves-themed"">
                    返回
                </button>

            </div>
            <div class=""card-body"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "803c7d845bcc35e6fb0b80ec2adcae85bf6e9e8b16211", async() => {
                WriteLiteral(@"
                    <div class=""form-group"">
                        <div class=""input-group"">
                            <input type=""text"" class="" form-control  rounded-0 border-top-0 border-left-0 border-right-0 px-0 bg-transparent"" placeholder=""用户名"" required name=""username"" id=""username"">
                        </div>
                    </div>
                    <div class=""form-group"">
                        <div class=""input-group"">
                            <input type=""text"" class="" form-control  rounded-0 border-top-0 border-left-0 border-right-0 px-0 bg-transparent"" placeholder=""手机号"" pattern=""[1](([3][0-9])|([4][5-9])|([5][0-3,5-9])|([6][5,6])|([7][0-8])|([8][0-9])|([9][1,8,9]))[0-9]{8}$"" name=""phonenumber"" id=""phonenumber"">
                        </div>
                    </div>
                    <div class=""form-group"">
                        <div class=""input-group"">
                            <input type=""text"" class="" form-control  rounded-0 border-top-0 border-left-0");
                WriteLiteral(" border-right-0 px-0 bg-transparent\" placeholder=\"企业十位编码\" required pattern=\"[0-9]{10}\" name=\"tradeno\" id=\"tradeno\">\r\n                        </div>\r\n                    </div>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
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
                <button id=""bindingbtn"" class=""btn btn-primary ml-auto waves-effect waves-themed"" type=""button"">绑定</button>
                <button id=""restbtn"" class=""btn btn-light  ml-1 waves-effect waves-themed"" type=""reset"">重置</button>
            </div>


        </div>
    </div>
</div>

");
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
