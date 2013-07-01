<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Department.aspx.cs" Inherits="Web_BasicSetting_Department" %>

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
                部门管理
            </h3>
        </div>
    </div>
    <div class="row-fluid">
        <div class="span12">
            <div class="social-box">
                <div class="header">
                    <div class="btn-group hidden-phone">
                        <a class="btn btn-primary" id="add-row" href="#">
                            <i class="icon-pencil"></i>添加
                        </a>
                        <a class="btn btn-danger disabled" href="#" id="delete-row">
                            <i class="icon-trash"></i>删除
                        </a>
                    </div>
                    <div class="tools">
                        <button class="btn btn-success btn-advanced" onclick="return false" data-toggle="collapse" data-target="#advanced-search">
                            <i class="icon-filter"></i>高级查询
                        </button>
                        
                        <div class="btn-group">
                            <button class="btn dropdown-toggle" data-toggle="dropdown">
                                <i class="icon-cog"></i>
                            </button>
                            <ul class="dropdown-menu pull-right">
                                <li><a href="#">打印</a></li>
                                <li><a href="#">保存至PDF</a></li>
                                <li class="divider"></li>
                                <li><a href="#">导出EXCEL</a></li>
                            </ul>
                        </div>
                    </div>
                </div>
                <div class="body">
                    <div id="advanced-search" class="collapse">
                        <table cellpadding="0" cellspacing="0" border="0" class="table table-hover table-condensed well">
                            <tbody>
                                
                                <tr id="filter_col1">
                                    <td align="center">
                                        Rendering engine
                                    </td>
                                    <td align="center">
                                        <input type="text" name="col1_filter" id="col1_filter"/>
                                    </td>
                                    <td align="center">
                                        <input type="checkbox" name="col1_regex" id="col1_regex"/>
                                    </td>
                                    <td align="center">
                                        <input type="checkbox" name="col1_smart" id="col1_smart" checked="checked"/>
                                    </td>
                                </tr>
                                <tr id="filter_col2">
                                    <td align="center">
                                        Browser
                                    </td>
                                    <td align="center">
                                        <input type="text" name="col2_filter" id="col2_filter"/>
                                    </td>
                                    <td align="center">
                                        <input type="checkbox" name="col2_regex" id="col2_regex"/>
                                    </td>
                                    <td align="center">
                                        <input type="checkbox" name="col2_smart" id="col2_smart" checked="checked"/>
                                    </td>
                                </tr>
                                 
                            </tbody>
                        </table>
                    </div>
                    <table cellpadding="0" cellspacing="0" border="0" class="table table-striped table-bordered"
                        id="example">
                        <thead>
                            <tr>
                                <th>
                                    <input type="checkbox" id="toggle-checkboxes" value="option2"/>
                                </th>
                                <th>
                                    序号
                                </th>
                                <th>
                                    部门名称
                                </th>
                                <th>
                                    备注
                                </th>
                            </tr>
                        </thead>
                        <tbody>
                            <asp:Repeater ID="dataRow" runat="server">
                                <ItemTemplate>
                                    <tr class="gradeX">
                                        <td>
                                            <input type="checkbox" id="inlineCheckbox2" value="option2"/>
                                        </td>
                                        <td>
                                            <%#DataBinder.Eval(Container.DataItem,"id")%>
                                        </td>
                                        <td>
                                            <%#DataBinder.Eval(Container.DataItem,"departmentName")%>
                                        </td>
                                        <td>
                                            <%#DataBinder.Eval(Container.DataItem,"remark")%>
                                        </td>
                                    </tr>
                                </ItemTemplate>
                            </asp:Repeater>
                        </tbody>
                    </table>
                </div>
            </div>
        </div>
    </div>
    </form>
</body>
<script src="../PostJS/BasicSetting_Department.js"></script>
</html>
