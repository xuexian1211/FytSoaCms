#pragma checksum "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Sale\Back.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb1d23bd93b68cf824a0122cd20f2277fd39739c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FytSoa.Web.Pages.FytAdmin.Sale.Pages_FytAdmin_Sale_Back), @"mvc.1.0.razor-page", @"/Pages/FytAdmin/Sale/Back.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/FytAdmin/Sale/Back.cshtml", typeof(FytSoa.Web.Pages.FytAdmin.Sale.Pages_FytAdmin_Sale_Back), null)]
namespace FytSoa.Web.Pages.FytAdmin.Sale
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\_ViewImports.cshtml"
using FytSoa.Web;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb1d23bd93b68cf824a0122cd20f2277fd39739c", @"/Pages/FytAdmin/Sale/Back.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21c44af9864cf57cf01e8fd1fe389a8e352e148c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_FytAdmin_Sale_Back : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Sale\Back.cshtml"
  
    ViewData["Title"] = "退货管理";
    Layout = AdminLayout.Pjax(HttpContext);

#line default
#line hidden
            BeginContext(141, 365, true);
            WriteLiteral(@"<div id=""container"">
    <div class=""list-wall"">
        <div class=""layui-form list-search"">
            <div class=""layui-inline"">
                <input class=""layui-input"" id=""key"" autocomplete=""off"" placeholder=""请输入关键字查询"">
            </div>
            <div class=""layui-inline"">
                <select id=""branks"" lay-search="""">
                    ");
            EndContext();
            BeginContext(506, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f24c3fbee8f49e49d6bf58cc3c617cb", async() => {
                BeginContext(523, 11, true);
                WriteLiteral("--可根据品牌搜索--");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(543, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 16 "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Sale\Back.cshtml"
                      
                        foreach (var item in Model.codeList)
                        {

#line default
#line hidden
            BeginContext(658, 28, true);
            WriteLiteral("                            ");
            EndContext();
            BeginContext(686, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a88ac3a7af6b468bba1c18819eee617b", async() => {
                BeginContext(714, 9, false);
#line 19 "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Sale\Back.cshtml"
                                                  Write(item.Name);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 19 "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Sale\Back.cshtml"
                               WriteLiteral(item.Guid);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(732, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 20 "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Sale\Back.cshtml"
                        }
                    

#line default
#line hidden
            BeginContext(784, 158, true);
            WriteLiteral("                </select>\r\n            </div>\r\n            <div class=\"layui-inline\">\r\n                <select id=\"shops\" lay-search=\"\">\r\n                    ");
            EndContext();
            BeginContext(942, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "55cba51288ec44fb9432d47c91a569a9", async() => {
                BeginContext(959, 11, true);
                WriteLiteral("--可根据店铺搜索--");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(979, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 27 "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Sale\Back.cshtml"
                      
                        foreach (var item in Model.shopList)
                        {

#line default
#line hidden
            BeginContext(1094, 28, true);
            WriteLiteral("                            ");
            EndContext();
            BeginContext(1122, 50, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "75956dc8c2744c579b6fe3c2ed19594a", async() => {
                BeginContext(1150, 13, false);
#line 30 "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Sale\Back.cshtml"
                                                  Write(item.ShopName);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 30 "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Sale\Back.cshtml"
                               WriteLiteral(item.Guid);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1172, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 31 "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Sale\Back.cshtml"
                        }
                    

#line default
#line hidden
            BeginContext(1224, 3890, true);
            WriteLiteral(@"                </select>
            </div>
            <div class=""layui-inline lay-time-icon"">
                <input class=""layui-input"" id=""times"" autocomplete=""off"" placeholder=""时间区间""><i class=""layui-icon layui-icon-date""></i>
            </div>
            <button type=""button"" class=""layui-btn layui-btn-sm"" data-type=""toolSearch""><i class=""layui-icon layui-icon-search""></i> 搜索</button>
        </div>
        <table class=""layui-hide"" id=""tablist"" lay-filter=""tool""></table>
    </div>
    <script>
        layui.config({
            base: '/themes/js/modules/'
        }).use(['table', 'layer', 'jquery', 'common', 'form', 'laydate'],
            function () {
                var table = layui.table,
                    layer = layui.layer,
                    $ = layui.jquery,
                    os = layui.common,
                    form = layui.form,
                    laydate = layui.laydate;
                form.render('select');
                laydate.render({
              ");
            WriteLiteral(@"      elem: '#times'
                    , theme: '#393D49'
                    , range: true
                });
                table.render({
                    elem: '#tablist',
                    url: '/api/stock/backlist',
                    cols: [
                        [
                            { type: 'checkbox', fixed: 'left' },
                            { field: 'code', width: 170, title: '条形码', sort: true, fixed: 'left' },
                            { field: 'orderNumber', width: 160, title: '订单号', sort: true },
                            { field: 'styleName', title: '商品名称', sort: true, templet: '#nameTpl' },
                            { field: 'shopName', title: '商铺' },
                            { field: 'operator', title: '负责人' },
                            { field: 'backCount', title: '退货数量', sort: true },
                            { field: 'money', title: '退货金额', sort: true },
                            { field: 'summary', title: '退货原因' },
                ");
            WriteLiteral(@"            { field: 'addDate', title: '时间', sort: true }
                        ]
                    ],
                    page: true,
                    id: 'tables'
                });

                var guid = '', active = {
                    reload: function () {
                        table.reload('tables',
                            {
                                page: {
                                    curr: 1
                                },
                                where: {
                                    key: $(""#key"").val(),
                                    brank: $(""#branks"").val(),
                                    time: $(""#times"").val(),
                                    shopGuid: $(""#shops"").val()
                                }
                            });
                    },
                    toolSearch: function () {
                        active.reload();
                    }
                };
                $('.l");
            WriteLiteral(@"ist-search .layui-btn').on('click', function () {
                    var type = $(this).data('type');
                    active[type] ? active[type].call(this) : '';
                });
                //监听工具条
                table.on('tool(tool)', function (obj) {
                    var data = obj.data;
                    if (obj.event === 'edit') {
                        os.Open('编辑条形码', '/fytadmin/goods/barcodemodify/?guid=' + data.guid, '750px', '400px', function () {
                            active.reload();
                        })
                    }
                });
            });
    </script>
    <script type=""text/html"" id=""nameTpl"">
        <a href=""javascript:void(0)"" class=""layui-table-link"">{{ d.brandName+d.styleName+d.seasonName }}</a>
    </script>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FytSoa.Web.Pages.FytAdmin.Sale.BackModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FytSoa.Web.Pages.FytAdmin.Sale.BackModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FytSoa.Web.Pages.FytAdmin.Sale.BackModel>)PageContext?.ViewData;
        public FytSoa.Web.Pages.FytAdmin.Sale.BackModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591