﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="Web_System_index" %>

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
                        <li class="active"><a href="#home" data-toggle="tab"><i class="icon-globe"></i>全局设置</a></li>
                        <li class=""><a href="#model" data-toggle="tab"><i class="icon-th"></i>模块</a></li>
                    </ul>
                    <div id="myTabContent" class="tab-content">
                        <div class="tab-pane fade active in" id="home">
                            <div class="row-fluid">
                                <div class="span12">
                                    <div class="body">
                                        <div class="control-group">
                                            <label class="control-label">
                                                公司名称</label>
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
                       <div class="tab-pane fade " id="model">
                           
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div style="visibility: hidden">
        <asp:TextBox runat="server" ID="globalSettingId"></asp:TextBox>
    </div>
    </form>
</body>
<script src="../PostJS/System_Index.js"></script>
</html>
