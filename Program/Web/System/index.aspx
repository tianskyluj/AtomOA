<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="Web_System_index" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="row-fluid">
        <div class="span12">
            <h3 class="page-title">
                系统设置
            </h3>
        </div>
    </div>
    <div class="row-fluid">
        <div class="span12">
            <div class="social-box">
                <div class="body">
                    <ul id="myTab" class="nav nav-tabs">
                        <li class="active"><a href="#home" data-toggle="tab"><i class="icon-home"></i>全局设置</a></li>
                        <li class=""><a href="#profile" data-toggle="tab"><i class="icon-th"></i>模块</a></li>
                        <li class=""><a href="#profile" data-toggle="tab"><i class="icon-group"></i>角色</a></li>
                        <li class=""><a href="#profile" data-toggle="tab"><i class="icon-user"></i>用户</a></li>
                    </ul>
                    <div id="myTabContent" class="tab-content">
                        <div class="tab-pane fade active in" id="home">
                            <div class="row-fluid">
                                <div class="span12">
                                    <div class="body">
                                        <div class="control-group">
                                            <label class="control-label">公司名称</label>
                                            <div class="controls">
                                                <asp:TextBox ID="companyName_edit" runat="server" CssClass="input-xlarge" placeholder="填写公司名称"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div>
                                            <button id="confirm_globalSetting" class="btn btn-primary">
                                                确认修改
                                            </button>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="tab-pane fade " id="profile">
                            <p>
                                <strong>Profile</strong></p>
                            <p>
                                Fugiat, accusamus, odio consequatur facere tempore rem sed sequi facilis quae doloremque
                                voluptates non delectus quaerat error deleniti nam placeat ratione quisquam. Lorem
                                ipsum dolor sit amet, consectetur adipisicing elit. Vel, distinctio!</p>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
     <div style="visibility:hidden">
        <asp:TextBox runat="server" ID="globalSettingId"></asp:TextBox>
    </div>
    </form>
</body>
</html>
<script type="text/javascript">
 $(document).ready(function() { 
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
                $('#brand').html($('#companyName_edit').val());
            }
            else showError(json.d);
        },
        error: function (error) {
            alert("调用出错" + error.responseText);
        }
    });   
}
</script>
