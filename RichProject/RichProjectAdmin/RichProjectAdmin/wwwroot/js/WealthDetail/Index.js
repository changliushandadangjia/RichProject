// 基于准备好的dom，初始化echarts实例
var myChart = echarts.init(document.getElementById('wealthCircle'));
$.ajax({
    url: Url.GetWealthDetailSimplify,
    type: 'post',
    data: { type: "pie" },
    async: true,
    dataType: 'json',
    success: function (result) {
        myChart.setOption({
            series: [
                {
                    name: '访问来源',
                    type: 'pie', // 设置图表类型为饼图
                    radius: '55%', // 饼图的半径，外半径为可视区尺寸（容器高宽中较小一项）的 55% 长度。
                    data: result.result
                }
            ]
        });
    }
});
var myLine = echarts.init(document.getElementById('wealthLine'));
$.ajax({
    url: Url.GetAmountSummary,
    type: 'post',
    data: { type: "pie" },
    async: true,
    dataType: 'json',
    success: function (result) {
        var xAxisData = [];
        var yAxisData = [];
        $.each(result.result,
            function (index, item) {
                xAxisData.push(item.timeFlag);
            });
        $.each(result.result,
            function (index, item) {
                yAxisData.push(item.amount);
            }),
            option = {
                xAxis: {
                    type: 'category',
                    data: xAxisData,
                    axisLabel: {
                        interval: 1
                    }
                },
                yAxis: {
                    type: 'value'
                },
                series: [
                    {
                        data: yAxisData,
                        type: 'line'
                    }
                ]
            };
        myLine.setOption(option);
    }
});

layui.use('table', function () {
    var table = layui.table;

    table.render({
        elem: '#test'
        , url: Url.GetWealthDetail
        , cellMinWidth: 80 //全局定义常规单元格的最小宽度，layui 2.2.1 新增
        , cols: [[
            { field: 'id', width: 80, title: 'ID', sort: true }
            , { field: 'wealthArea', width: 80, title: '存钱的地方' }
            , { field: 'amount', width: 80, title: '金额', sort: true }
            , { field: 'remark', width: 80, title: '备注' }
            , { field: 'isDeleted', title: '是否删除', width: '30%', minWidth: 100 } //minWidth：局部定义当前单元格的最小宽度，layui 2.2.1 新增
            , { field: 'creationTime', title: '创建时间', sort: true }
            , { field: 'lastModifycationTime', title: '更新时间' }
        ]]
        , parseData: function (res) { //将原始数据解析成 table 组件所规定的数据
            return {
                "code": res.code, //解析接口状态
                "msg": res.msg, //解析提示文本
                "count": res.count, //解析数据长度
                "data": res.data //解析数据列表
            };
        }
    });
});