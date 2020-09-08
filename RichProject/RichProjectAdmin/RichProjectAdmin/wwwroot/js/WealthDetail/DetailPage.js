layui.use(['laydate', 'laypage', 'layer', 'table', 'carousel', 'upload', 'element', 'slider'], function () {
    var layer = layui.layer, table = layui.table; //表格
    layer.msg('只能同时编辑一个');
    table.render({
        elem: '#demo',
        height: 420,
        url: Url.GetWealthDetail //数据接口
        ,
        title: '用户表',
        page: true //开启分页
        ,
        toolbar: 'default' //开启工具栏，此处显示默认图标，可以自定义模板，详见文档
        ,
        totalRow: true //开启合计行
        , cols: [[
            { type: 'checkbox', fixed: 'left' }
            ,{ field: 'id', width: 80, title: 'ID', sort: true }
            , { field: 'wealthArea', width: 80, title: '存钱的地方' }
            , { field: 'amount', width: 80, title: '金额', sort: true }
            , { field: 'remark', width: 80, title: '备注' }
            , { field: 'isDeleted', title: '是否删除', width: '30%', minWidth: 100 } //minWidth：局部定义当前单元格的最小宽度，layui 2.2.1 新增
            , { field: 'creationTime', title: '创建时间', sort: true }
            , { field: 'lastModifycationTime', title: '更新时间' }
            , { fixed: 'right', width: 165, align: 'center', toolbar: '#barDemo' }
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

    //监听头工具栏事件
    table.on('toolbar(test)',
        function (obj) {
            var checkStatus = table.checkStatus(obj.config.id), data = checkStatus.data; //获取选中的数据
            switch (obj.event) {
                case 'add':
                    alert('添加');
                    break;
                case 'update':
                    if (data.length === 0) {
                        alert('请选择一行');
                    } else if (data.length > 1) {
                        alert('只能同时编辑一个');
                    } else {
                        alert('编辑 [id]：' + checkStatus.data[0].id);
                    }
                    break;
                case 'delete':
                    if (data.length === 0) {
                        alert('请选择一行');
                    } else {
                        alert('删除');
                    }
                    break;
            };
        });

    //监听行工具事件
    table.on('tool(test)',
        function (obj) { //注：tool 是工具条事件名，test 是 table 原始容器的属性 lay-filter="对应的值"
            var data = obj.data //获得当前行数据
                ,
                layEvent = obj.event; //获得 lay-event 对应的值
            if (layEvent === 'detail') {
                alert('查看操作');
            } else if (layEvent === 'del') {
                layer.confirm('真的删除行么',
                    function (index) {
                        obj.del(); //删除对应行（tr）的DOM结构
                        layer.close(index);
                        //向服务端发送删除指令
                    });
            } else if (layEvent === 'edit') {
                alert('编辑操作');
            }
        });
});