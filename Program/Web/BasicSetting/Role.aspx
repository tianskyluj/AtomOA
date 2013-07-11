<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Role.aspx.cs" Inherits="Web_BasicSetting_Role" %>

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
                角色管理
            </h3>
        </div>
    </div>
    <div class="row-fluid">
        <div class="span12">
            <div class="social-box">
                <div class="header">
                    <div class="btn-group hidden-phone">
                        <a class="btn btn-primary" id="add-row" href="#"><i class="icon-plus"></i>添加 </a>
                        <a class="btn btn-success disabled" id="modify-row" href="#"><i class="icon-pencil">
                        </i>修改 </a><a class="btn btn-danger disabled" href="#" id="delete-row"><i class="icon-trash">
                        </i>删除 </a>
                    </div>
                    <div class="tools">
                        <a class="btn btn-success btn-advanced" id="btn-advanced" href="javascript:void(0)"
                            data-toggle="collapse" data-target="#advanced-search"><i class="icon-filter"></i>
                            高级查询 </a>
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
                    <table cellpadding="0" cellspacing="0" border="0" class="table table-striped table-bordered"
                        id="listTable">
                        <thead>
                            <tr>
                                <th>
                                    <input type="checkbox" id="toggle-checkboxes" value="option2" />
                                </th>
                                <th>
                                    序号
                                </th>
                                <th>
                                    角色名称
                                </th>
                                <th>
                                    所属部门
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
                                            <input type="checkbox" id="inlineCheckbox2" value="option2" />
                                        </td>
                                        <td>
                                            <span id="dataId">
                                                <%#DataBinder.Eval(Container.DataItem,"id")%></span>
                                        </td>
                                        <td>
                                            <%#DataBinder.Eval(Container.DataItem,"provinceName")%>
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
    <!-- 高级查询选项查询框 -->
    <aside id="advanced_search" class="modal hide fade" tabindex="-1" role="dialog" aria-labelledby="myModalLabel"
        aria-hidden="true">
        <div class="modal-header">
            <button type="button" class="close" data-dismiss="modal" aria-hidden="true">&times;</button>
            <h3 id="myModalLabel">高级查询</h3>
        </div>
        <div class="modal-body">
            <table cellpadding="0" cellspacing="0" border="0" class="table table-hover table-condensed well">
                <tr>
                    <td align="center">
                        角色名称
                    </td>
                    <td align="center">
                        <asp:TextBox ID="roleName_search" runat="server"></asp:TextBox>
                    </td>
                    <td align="center">
                        <asp:CheckBox ID="roleName_check_search" runat="server" Checked="false" />
                    </td>
                </tr>
                 <tr>
                    <td align="center">
                        所属部门
                    </td>
                    <td align="center" colspan="2">
                        <asp:DropDownList ID="department_search" runat="server"></asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td align="center">
                        备注
                    </td>
                    <td align="center">
                        <asp:TextBox ID="remark_search" runat="server"></asp:TextBox>
                    </td>
                    <td align="center">
                        <asp:CheckBox ID="remark_check_search" runat="server" Checked="false" />
                    </td>
                </tr>
            </table>
        </div>
        <div class="modal-footer">
            <button class="btn btn-danger" data-dismiss="modal">关闭</button>
            <a href="javascript:void(0);" class="btn btn-primary" id="confirmSearch">确定</a>
        </div>
    </aside>
    <!-- 高级查询选项查询框 结束 -->
    <!-- 添加修改弹出框 -->
    <aside id="addAndUpdate" class="modal hide fade" tabindex="-1" role="dialog" aria-labelledby="myModalLabel"
        aria-hidden="true">
        <div class="modal-header">
            <button type="button" class="close" data-dismiss="modal" aria-hidden="true">&times;</button>
            <h3 id="H1"><span id="addAndUpdateTitle">添加</span></h3>
        </div>
        <div class="modal-body">
            <div class="control-group">
                <label class="control-label">
                    角色</label>
                <div class="controls">
                    <asp:TextBox ID="roleName_edit" runat="server" CssClass="input-xlarge" placeholder="填写角色名称"></asp:TextBox>
                </div>
            </div>
            <div class="control-group">
                <label class="control-label">所属省份</label>
                <div class="controls">
                    <lan:multiSelect runat="server" ID="province_edit" DefaultText="请选择省份" DefaultValue="0"
                                     CssClass="province_edit">
                    </lan:multiSelect>
                </div>
            </div>
            <div class="control-group">
                <label class="control-label">
                    所属部门</label>
                <div class="controls">
                     <lan:multiSelect runat="server" ID="department_edit" DefaultText="请选择部门" DefaultValue="0">
                     </lan:multiSelect>
                </div>
            </div>
            <div class="control-group">
                <label class="control-label">
                    备注</label>
                <div class="controls">
                    <asp:TextBox ID="remark_edit" runat="server" TextMode="MultiLine" Rows="3" 
                        CssClass="input-xlarge" placeholder="请填写备注">
                    </asp:TextBox>
                </div>
            </div>
        </div>
        <div class="modal-footer">
            <button class="btn btn-danger" data-dismiss="modal">关闭</button>
            <a class="btn btn-primary" id="confirmSave">保存</a>
        </div>
    </aside>
    <!-- 添加修改弹出框 结束 -->
    <div style="visibility: hidden">
        <asp:TextBox ID="id" runat="server" Text="0"></asp:TextBox>
    </div>
    </form>
</body>
<script src="../PostJS/BasicSetting_Role.js"></script>
</html>
