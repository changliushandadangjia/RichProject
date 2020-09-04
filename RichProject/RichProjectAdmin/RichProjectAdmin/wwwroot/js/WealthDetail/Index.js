// 基于准备好的dom，初始化echarts实例
var myChart = echarts.init(document.getElementById('wealthCircle'));
var myLine = echarts.init(document.getElementById('wealthLine'));
myChart.setOption({
    series: [
        {
            name: '访问来源',
            type: 'pie',    // 设置图表类型为饼图
            radius: '55%',  // 饼图的半径，外半径为可视区尺寸（容器高宽中较小一项）的 55% 长度。
            data: [          // 数据数组，name 为数据项名称，value 为数据项值
                { value: 235, name: '视频广告' },
                { value: 274, name: '联盟广告' },
                { value: 310, name: '邮件营销' },
                { value: 335, name: '直接访问' },
                { value: 400, name: '搜索引擎' }
            ]
        }
    ]
});
option = {
    xAxis: {
        type: 'category',
        data: ['Mon', 'Tue', 'Wed', 'Thu', 'Fri', 'Sat', 'Sun']
    },
    yAxis: {
        type: 'value'
    },
    series: [{
        data: [820, 932, 901, 934, 1290, 1330, 1320],
        type: 'line'
    }]
};
myLine.setOption(option);

layui.use('table', function () {
    var table = layui.table;

    table.render({
        elem: '#test'
        , url: Url.GetStoreUrl
        , cellMinWidth: 80 //全局定义常规单元格的最小宽度，layui 2.2.1 新增
        , cols: [[  
            { field: 'id', width: 80, title: 'ID', sort: true }
            , { field: 'wealthArea', width: 80, title: '存钱的地方' }
            , { field: 'amount', width: 80, title: '金额', sort: true }
            , { field: 'remark', width: 80, title: '备注' }
            , { field: 'isDeleted', title: '是否删除', width: '30%', minWidth: 100 } //minWidth：局部定义当前单元格的最小宽度，layui 2.2.1 新增
            , { field: 'creationTime', title: '创建时间', sort: true }
            , { field: 'lastModifycationTime', title: '更新时间'}
        ]]
        , parseData: function (res) { //将原始数据解析成 table 组件所规定的数据
            return {
                "code": res.result.code, //解析接口状态
                "msg": res.result.msg, //解析提示文本
                "count": res.result.count, //解析数据长度
                "data": res.result.data //解析数据列表
            };
        }
    });
});