#pragma checksum "C:\Users\29933\Desktop\RichProject\RichProjectAdmin\RichProjectAdmin\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "82eb75d46daf349e8878629d875c1cde7b95f84c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Layout.cshtml", typeof(AspNetCore.Views_Shared__Layout))]
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
#line 1 "C:\Users\29933\Desktop\RichProject\RichProjectAdmin\RichProjectAdmin\Views\_ViewImports.cshtml"
using RichProjectAdmin;

#line default
#line hidden
#line 2 "C:\Users\29933\Desktop\RichProject\RichProjectAdmin\RichProjectAdmin\Views\_ViewImports.cshtml"
using RichProjectAdmin.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82eb75d46daf349e8878629d875c1cde7b95f84c", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"add860b94493be1deca750b6d77b6dfc6a38e998", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/layui.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/layui.all.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("layui-layout-body"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 25, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(25, 229, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "82eb75d46daf349e8878629d875c1cde7b95f84c4997", async() => {
                BeginContext(31, 166, true);
                WriteLiteral("\r\n    <meta charset=\"utf-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1, maximum-scale=1\">\r\n    <title>layout 后台大布局 - Layui</title>\r\n    ");
                EndContext();
                BeginContext(197, 48, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "82eb75d46daf349e8878629d875c1cde7b95f84c5555", async() => {
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
                EndContext();
                BeginContext(245, 2, true);
                WriteLiteral("\r\n");
                EndContext();
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
            EndContext();
            BeginContext(254, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(256, 3263, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "82eb75d46daf349e8878629d875c1cde7b95f84c7684", async() => {
                BeginContext(288, 2855, true);
                WriteLiteral(@"
    <div class=""layui-layout layui-layout-admin"">
        <div class=""layui-header"">
            <div class=""layui-logo"">致富经</div>
            <!-- 头部区域（可配合layui已有的水平导航） -->
            <ul class=""layui-nav layui-layout-left"">
                <li class=""layui-nav-item""><a href="""">控制台</a></li>
                <li class=""layui-nav-item""><a href="""">商品管理</a></li>
                <li class=""layui-nav-item""><a href="""">用户</a></li>
                <li class=""layui-nav-item"">
                    <a href=""javascript:;"">其它系统</a>
                    <dl class=""layui-nav-child"">
                        <dd><a href="""">邮件管理</a></dd>
                        <dd><a href="""">消息管理</a></dd>
                        <dd><a href="""">授权管理</a></dd>
                    </dl>
                </li>
            </ul>
            <ul class=""layui-nav layui-layout-right"">
                <li class=""layui-nav-item"">
                    <a href=""javascript:;"">
                        <img src=""http://t.cn/RCzsdCq"" class=""");
                WriteLiteral(@"layui-nav-img"">
                        贤心
                    </a>
                    <dl class=""layui-nav-child"">
                        <dd><a href="""">基本资料</a></dd>
                        <dd><a href="""">安全设置</a></dd>
                    </dl>
                </li>
                <li class=""layui-nav-item""><a href="""">退了</a></li>
            </ul>
        </div>

        <div class=""layui-side layui-bg-black"">
            <div class=""layui-side-scroll"">
                <!-- 左侧导航区域（可配合layui已有的垂直导航） -->
                <ul class=""layui-nav layui-nav-tree"" lay-filter=""test"">
                    <li class=""layui-nav-item layui-nav-itemed"">
                        <a class="""" href=""javascript:;"">所有商品</a>
                        <dl class=""layui-nav-child"">
                            <dd><a href=""javascript:;"">列表一</a></dd>
                            <dd><a href=""javascript:;"">列表二</a></dd>
                            <dd><a href=""javascript:;"">列表三</a></dd>
                            <dd");
                WriteLiteral(@"><a href="""">超链接</a></dd>
                        </dl>
                    </li>
                    <li class=""layui-nav-item"">
                        <a href=""javascript:;"">解决方案</a>
                        <dl class=""layui-nav-child"">
                            <dd><a href=""javascript:;"">列表一</a></dd>
                            <dd><a href=""javascript:;"">列表二</a></dd>
                            <dd><a href="""">超链接</a></dd>
                        </dl>
                    </li>
                    <li class=""layui-nav-item""><a href="""">云市场</a></li>
                    <li class=""layui-nav-item""><a href="""">发布商品</a></li>
                </ul>
            </div>
        </div>

        <div class=""layui-body"">
            <!-- 内容主体区域 -->
            <div style=""padding: 15px;""> ");
                EndContext();
                BeginContext(3144, 12, false);
#line 71 "C:\Users\29933\Desktop\RichProject\RichProjectAdmin\RichProjectAdmin\Views\Shared\_Layout.cshtml"
                                    Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(3156, 157, true);
                WriteLiteral("</div>\r\n        </div>\r\n\r\n        <div class=\"layui-footer\">\r\n            <!-- 底部固定区域 -->\r\n            © layui.com - 底部固定区域\r\n        </div>\r\n    </div>\r\n    ");
                EndContext();
                BeginContext(3313, 41, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "82eb75d46daf349e8878629d875c1cde7b95f84c11659", async() => {
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
                EndContext();
                BeginContext(3354, 158, true);
                WriteLiteral("\r\n    <script>\r\n        //JavaScript代码区域\r\n        layui.use(\'element\', function () {\r\n            var element = layui.element;\r\n\r\n        });\r\n    </script>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3519, 9, true);
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591