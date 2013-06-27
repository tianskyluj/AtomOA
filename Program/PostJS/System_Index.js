$(document).ready(function () {
    //  点击添加按钮按钮
    $("#confirm_globalSetting").click(function () {
        updateGlobalSetting();
        return false;
    })
});

// 更新全局变量
function updateGlobalSetting() {
    var companyName = $('#companyName_edit').val();
    if (companyName.trim().length == 0) {
        showError("请输入公司名称");
        return false;
    }

    var data = '{ companyName: "' + companyName + '",modelId:"' + $('#globalSettingId').val() + '" }';
    $.ajax({
        type: "POST",
        url: "System/index.aspx/UpdateGlobalSetting",
        data: data,
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (json) {
            if (json.d == "1") {
                showSuccess("成功修改全局变量");
                $('.brand').html($('#companyName_edit').val());
            }
            else showError("修改出错:" + json.d);
        },
        error: function (error) {
            alert("调用出错" + error.responseText);
        }
    });
}