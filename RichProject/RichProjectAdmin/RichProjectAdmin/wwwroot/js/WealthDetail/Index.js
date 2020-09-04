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
        , url: '/demo/table/user/'
        , cellMinWidth: 80 //全局定义常规单元格的最小宽度，layui 2.2.1 新增
        , cols: [[
            { field: 'id', width: 80, title: 'ID', sort: true }
            , { field: 'username', width: 80, title: '用户名' }
            , { field: 'sex', width: 80, title: '性别', sort: true }
            , { field: 'city', width: 80, title: '城市' }
            , { field: 'sign', title: '签名', width: '30%', minWidth: 100 } //minWidth：局部定义当前单元格的最小宽度，layui 2.2.1 新增
            , { field: 'experience', title: '积分', sort: true }
            , { field: 'score', title: '评分', sort: true }
            , { field: 'classify', title: '职业' }
            , { field: 'wealth', width: 137, title: '财富', sort: true }
        ]]
    });
});