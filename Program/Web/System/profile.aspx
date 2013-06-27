<%@ Page Language="C#" AutoEventWireup="true" CodeFile="profile.aspx.cs" Inherits="Web_System_Profile" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="row-fluid">
        <div class="span12">
            <h3 class="page-title">
                个人资料
            </h3>
        </div>
    </div>
    <div class="row-fluid">
        <div class="span12">
            <div class="social-box">
                <div class="body">
                    <ul id="myTab" class="nav nav-tabs">
                        <li class="active"><a href="#basic" data-toggle="tab"><i class="icon-user"></i> 基本资料</a></li>
                        <li style="display:none" class=""><a href="#avatar" data-toggle="tab"><i class="icon-picture"></i> 设置头像</a></li>
                        <li class=""><a href="#changePassword" data-toggle="tab"><i class="icon-key"></i> 重置密码</a></li>
                    </ul>
                    <div id="myTabContent" class="tab-content">
                        <div class="tab-pane fade active in" id="basic">
                            <div class="row-fluid">
                                <div class="span12">
                                    <div class="body">
                                        <div class="control-group">
                                            <label class="control-label">
                                                电话</label>
                                            <div class="controls">
                                                <asp:TextBox ID="telephone_edit" runat="server" CssClass="input-xlarge" placeholder="填写个人联系电话"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="control-group">
                                            <label class="control-label">
                                                邮件</label>
                                            <div class="controls">
                                                <asp:TextBox ID="email_edit" runat="server" CssClass="input-xlarge" placeholder="填写个人邮件"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="control-group">
                                            <label class="control-label">
                                                QQ</label>
                                            <div class="controls">
                                                <asp:TextBox ID="QQ_edit" runat="server" CssClass="input-xlarge" placeholder="填写QQ号"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div>
                                            <button id="profile_confirm" class="btn btn-primary">
                                                确认修改
                                            </button>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="tab-pane fade " id="changePassword">
                            <div class="row-fluid">
                                <div class="span12">
                                    <div class="body">
                                        <div class="control-group">
                                            <label class="control-label">
                                                旧密码</label>
                                            <div class="controls">
                                                <asp:TextBox ID="oldPassword_edit" TextMode="Password" runat="server" CssClass="input-xlarge" placeholder="请输入旧密码"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="control-group">
                                            <label class="control-label">
                                                新密码</label>
                                            <div class="controls">
                                                <asp:TextBox ID="newPassword_edit" TextMode="Password" runat="server" CssClass="input-xlarge" placeholder="请输入新密码"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="control-group">
                                            <label class="control-label">
                                                再次输入新密码</label>
                                            <div class="controls">
                                                <asp:TextBox ID="newPasswordAgain_edit" TextMode="Password" runat="server" CssClass="input-xlarge" placeholder="请再次输入新密码"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div>
                                            <button id="changePassword_confirm" class="btn btn-primary">
                                                修改密码
                                            </button>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div style="visibility: hidden">
    </div>
    </form>
</body>
<script src="PostJS/System_Profile.js"></script>
</html>
