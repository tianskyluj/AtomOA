$(document).ready(function () {
    //  更新个人基本资料
    $("#profile_confirm").click(function () {
        updateProfile();
        return false;
    })

    //  更改密码
    $("#changePassword_confirm").click(function () {
        changePassword();
        return false;
    })

    //  上次头像
    $("#UploadButton").click(function () {
        uploadAvatar();
        return false;
    })
});

// 更新个人基本资料
function updateProfile() {
    
    var data = '{'
                + ' telephone: "' + $('#telephone_edit').val() + '"'
                + ',email:"' + $('#email_edit').val() + '" '
                + ',qq:"' + $('#QQ_edit').val() + '" '
                + '}'; 
    $.ajax({
        type: "POST",
        url: "System/profile.aspx/updateProfile",
        data: data,
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (json) {
            if (json.d == "1") {
                showSuccess("个人资料更新成功");
            }
            else showError("修改出错:" + json.d);
        },
        error: function (error) {
            alert("调用出错" + error.responseText);
        }
    });
}


// 更改密码
function changePassword() {
    
    var oldPassword = $('#oldPassword_edit').val();
    var newPassword = $('#newPassword_edit').val();
    var newPasswordAgain = $('#newPasswordAgain_edit').val(); 
    if (oldPassword.length == 0) {
        showError("请输入旧密码");
        return false;
    }
    if (newPassword.length == 0) {
        showError("请输入新密码");
        return false;
    }
    if (newPasswordAgain.length == 0) {
        showError("请重复新密码");
        return false;
    }
    if (newPassword.trim() != newPasswordAgain.trim()) {
        showError("两次输入新密码不一致，请重新输入");
        return false;
    }

    var data = '{'
                + ' oldPassword: "' + oldPassword + '"'
                + ',newPassword:"' + newPassword + '" '
                + '}';
    $.ajax({
        type: "POST",
        url: "System/profile.aspx/changePassword",
        data: data,
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (json) {
            if (json.d == "1") {
                showSuccess("密码修改成功 ^_^");
            }
            else showError(json.d);
        },
        error: function (error) {
            alert("调用出错" + error.responseText);
        }
    });
}


// 上次头像
function uploadAvatar() {
    if ($('.fileupload-preview').children().attr('src') == undefined) {
        showError("请先上传图片");
        return false;
    }

    var data = '{'
                + ' avatar: "' + $('.fileupload-preview').children().attr('src') + '"'
                + '}';
    $.ajax({
        type: "POST",
        url: "System/profile.aspx/uploadAvatar",
        data: data,
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (json) {
            if (json.d == "1") {
                showSuccess("头像上传成功");
            }
            else showError("修改出错:" + json.d);
        },
        error: function (error) {
            alert("调用出错" + error.responseText);
        }
    });
}