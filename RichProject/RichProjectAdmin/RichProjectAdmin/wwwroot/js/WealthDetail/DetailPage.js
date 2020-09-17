$(function () {
});

layui.use(['laydate', 'laypage', 'layer', 'table', 'carousel', 'upload', 'element', 'slider'], function () {
    var layer = layui.layer, table = layui.table; //表格
    table.render({
        elem: '#demo',
        height: 420,
        url: Url.GetWealthDetail //数据接口
        ,
        title: '用户表',
        page: true //开启分页
        ,
        where: {},//参数
        limit: 10,
        limits: [5, 10, 15, 20],
        toolbar: 'default' //开启工具栏，此处显示默认图标，可以自定义模板，详见文档
        ,
        totalRow: true //开启合计行
        , cols: [[
            { type: 'checkbox', fixed: 'left' }
            , { field: 'id', width: 80, title: 'ID', sort: true }
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
                    AddWealthDetail();
                    break;
                case 'update':
                    if (data.length === 0) {
                        alert('请选择一行');
                    } else if (data.length > 1) {
                        alert('只能同时编辑一个');
                    } else {
                        notice(data[0]);
                    }
                    break;
                case 'delete':
                    if (data.length === 0) {
                        alert('请选择一行');
                    } else {
                        //obj.del(); //删除对应行（tr）的DOM结构
                        var r = confirm("是否删除该数据!");
                        if (r == true) {
                            DelWealthDetail(data[0].id);
                        }
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
                QueryDetail(data);
            } else if (layEvent === 'del') {
                var r = confirm("是否删除该数据!");
                if (r == true) {
                    obj.del(); //删除对应行（tr）的DOM结构
                    DelWealthDetail(data.id);
                }
            } else if (layEvent === 'edit') {
                notice(data);
            }
        });
    var notice = function (data) {
        //示范一个公告层
        layer.open({
            type: 1,
            title: '编辑财富详情' //不显示标题栏
            ,
            closeBtn: false,
            area: ['60%;','550px'],
            shade: 0.8,
            id: 'LAY_layuipro' //设定一个id，防止重复弹出
            ,
            btn: ['提交', '取消'],
            btnAlign: 'c',
            moveType: 1 //拖拽模式，0或者1
            ,
            content:
                "<div style='width:70%;margin-left:10%'>\
<form class='form-horizontal' role='form' style='margin:auto'>\
    <div class='form-group' style='display:none'>\
        <label for='firstname' class='col-sm-3 control-label'>id</label>\
        <div class='col-sm-9'>\
            <input type='text' class='form-control' placeholder='' id='uid'>\
        </div>\
    </div>\
    <div class='form-group'>\
        <label for='lastname' class='col-sm-3 control-label'>存钱处</label>\
        <div class='col-sm-9'>\
            <input type='text' class='form-control' placeholder='' id='uwealthArea'>\
        </div>\
    </div>\
    <div class='form-group'>\
        <label for='lastname' class='col-sm-3 control-label'>金额</label>\
        <div class='col-sm-9'>\
            <input type='text' class='form-control' placeholder='' id='uamount'>\
        </div>\
    </div>\
    <div class='form-group'>\
        <label for='lastname' class='col-sm-3 control-label'>备注</label>\
        <div class='col-sm-9'>\
            <input type='text' class='form-control' placeholder='' id='uremark'>\
        </div>\
    </div>\
    <div class='form-group'>\
        <label for='lastname' class='col-sm-3 control-label'>创建时间</label>\
        <div class='input-group date col-sm-9' id='datetimepicker3'>\
            <input type='text' class='form-control' id='ucreateTime' />\
            <span class='input-group-addon'>\
                <span class='glyphicon glyphicon-calendar'></span>\
            </span>\
        </div>\
    </div>\
    <div class='form-group'>\
        <label for='lastname' class='col-sm-3 control-label'>更新时间</label>\
        <div class='input-group date col-sm-9' id='datetimepicker4'>\
            <input type='text' class='form-control' id='uupdateTime' />\
            <span class='input-group-addon'>\
                <span class='glyphicon glyphicon-calendar'></span>\
            </span>\
        </div>\
    </div>\
</form>\
</div>",
            success: function (layero, index) {
                $('#datetimepicker3').datetimepicker({
                    format: 'YYYY-MM-DD',
                    locale: moment.locale('zh-cn')
                });
                $('#datetimepicker4').datetimepicker({
                    format: 'YYYY-MM-DD',
                    locale: moment.locale('zh-cn')
                });
                console.log(layero, index);
                $("#uid").val(data.id);
                $("#uwealthArea").val(data.wealthArea);
                $("#uamount").val(data.amount);
                $("#uremark").val(data.remark);
                $("#ucreateTime").val(data.creationTime);
                $("#uupdateTime").val(data.lastModifycationTime);
            },
            yes: function (index, layero) {
                var param = {};
                param.id = $("#uid").val();
                param.wealthArea = $("#uwealthArea").val();
                param.amount = $("#uamount").val();
                param.remark = $("#uremark").val();
                param.creationTime = $("#ucreateTime").val();
                param.lastModifycationTime = $("#uupdateTime").val();
                $.ajax({
                    url: Url.UpdateWealthDetail,
                    type: 'post',
                    async: true,
                    dataType: 'json',
                    data: param,
                    success: function (result) {
                        if (result.result == true) {
                            alert("修改成功");
                            layer.close(index);
                        } else {
                            alert("修改失败");
                        }
                    }
                });
            },
            cancel: function (index, layero) {
                layer.close(index);
            }
        });
    };
});

function DelWealthDetail(id) {
    var param = {};
    param.id = id;
    $.ajax({
        url: Url.DelWealthDetail,
        type: 'post',
        async: true,
        dataType: 'json',
        data: param,
        success: function (result) {
            if (result.result == true) {
                alert("删除成功");
            } else {
                alert("删除失败");
            }
        }
    });
}

function QueryDetail(data) {
    var modal = $("#myModal").prop("outerHTML");
    $("#myModal").remove();
    $("#motaikuang").html(modal);
    $("#myModal").modal({
        backdrop: true
    });
    $('#datetimepicker1').datetimepicker({
        format: 'YYYY-MM-DD',
        locale: moment.locale('zh-cn')
    });
    $('#datetimepicker2').datetimepicker({
        format: 'YYYY-MM-DD',
        locale: moment.locale('zh-cn')
    });
    $("#cid").val(data.id);
    $("#cwealthArea").val(data.wealthArea);
    $("#camount").val(data.amount);
    $("#cremark").val(data.remark);
    $("#ccreateTime").val(data.creationTime);
    $("#cupdateTime").val(data.lastModifycationTime);
    $("#cid,#cwealthArea,#camount,#cremark,#ccreateTime,#cupdateTime").attr("disabled", "disabled");
}

function AddWealthDetail() {
    var modal = $("#myModal").prop("outerHTML");
    $("#myModal").remove();
    $("#motaikuang").html(modal);
    $("#myModal").modal({
        backdrop: true
    });
    $('#datetimepicker1').datetimepicker({
        format: 'YYYY-MM-DD',
        locale: moment.locale('zh-cn')
    });
    $('#datetimepicker2').datetimepicker({
        format: 'YYYY-MM-DD',
        locale: moment.locale('zh-cn')
    });
    $("#cwealthArea,#camount,#cremark,#ccreateTime,#cupdateTime").val("");
    $("#cid,#cwealthArea,#camount,#cremark,#ccreateTime,#cupdateTime").attr("disabled", false);
    $('#addWealthDetail').on('click',
        function () {
            var param = {};
            param.wealthArea = $("#cwealthArea").val();
            param.amount = $("#camount").val();
            param.remark = $("#cremark").val();
            param.creationTime = $("#ccreateTime").val();
            param.lastModifycationTime = $("#cupdateTime").val();
            $.ajax({
                url: Url.AddWealthDetail,
                type: 'post',
                async: true,
                dataType: 'json',
                data: param,
                success: function (result) {
                    if (result.result == true) {
                        alert("新增成功");
                        $("#myModal").modal('hide');
                    } else {
                        alert("新增失败");
                    }
                }
            });
        });
}