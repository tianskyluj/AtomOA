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
                        <button class="btn btn-success" data-toggle="collapse" data-target="#advanced-search">
                            <i class="icon-filter"></i>高级查询</button>
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
                            <thead>
                                <tr>
                                    <th>
                                        Target
                                    </th>
                                    <th>
                                        Search text
                                    </th>
                                    <th>
                                        Treat as regex
                                    </th>
                                    <th>
                                        Use smart search
                                    </th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr id="filter_global">
                                    <td align="center">
                                        Global search
                                    </td>
                                    <td align="center">
                                        <input type="text" name="global_filter" id="global_filter">
                                    </td>
                                    <td align="center">
                                        <input type="checkbox" name="global_regex" id="global_regex">
                                    </td>
                                    <td align="center">
                                        <input type="checkbox" name="global_smart" id="global_smart" checked>
                                    </td>
                                </tr>
                                <tr id="filter_col1">
                                    <td align="center">
                                        Rendering engine
                                    </td>
                                    <td align="center">
                                        <input type="text" name="col1_filter" id="col1_filter">
                                    </td>
                                    <td align="center">
                                        <input type="checkbox" name="col1_regex" id="col1_regex">
                                    </td>
                                    <td align="center">
                                        <input type="checkbox" name="col1_smart" id="col1_smart" checked>
                                    </td>
                                </tr>
                                <tr id="filter_col2">
                                    <td align="center">
                                        Browser
                                    </td>
                                    <td align="center">
                                        <input type="text" name="col2_filter" id="col2_filter">
                                    </td>
                                    <td align="center">
                                        <input type="checkbox" name="col2_regex" id="col2_regex">
                                    </td>
                                    <td align="center">
                                        <input type="checkbox" name="col2_smart" id="col2_smart" checked>
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
                                    <input type="checkbox" id="toggle-checkboxes" value="option2">
                                </th>
                                <th>
                                    Rendering engine
                                </th>
                                <th>
                                    Browser
                                </th>
                                <th>
                                    Platform(s)
                                </th>
                                <th>
                                    Engine version
                                </th>
                                <th>
                                    CSS grade
                                </th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr class="odd gradeX">
                                <td>
                                    <input type="checkbox" id="inlineCheckbox2" value="option2">
                                </td>
                                <td>
                                    Trident
                                </td>
                                <td>
                                    Internet Explorer 4.0
                                </td>
                                <td>
                                    Win 95+
                                </td>
                                <td class="center">
                                    4
                                </td>
                                <td class="center">
                                    X
                                </td>
                            </tr>
                            <tr class="even gradeC">
                                <td>
                                    <input type="checkbox" id="inlineCheckbox2" value="option2">
                                </td>
                                <td>
                                    Trident
                                </td>
                                <td>
                                    Internet Explorer 5.0
                                </td>
                                <td>
                                    Win 95+
                                </td>
                                <td class="center">
                                    5
                                </td>
                                <td class="center">
                                    C
                                </td>
                            </tr>
                            <tr class="odd gradeA">
                                <td>
                                    <input type="checkbox" id="inlineCheckbox2" value="option2">
                                </td>
                                <td>
                                    Trident
                                </td>
                                <td>
                                    Internet Explorer 5.5
                                </td>
                                <td>
                                    Win 95+
                                </td>
                                <td class="center">
                                    5.5
                                </td>
                                <td class="center">
                                    A
                                </td>
                            </tr>
                            <tr class="even gradeA">
                                <td>
                                    <input type="checkbox" id="inlineCheckbox2" value="option2">
                                </td>
                                <td>
                                    Trident
                                </td>
                                <td>
                                    Internet Explorer 6
                                </td>
                                <td>
                                    Win 98+
                                </td>
                                <td class="center">
                                    6
                                </td>
                                <td class="center">
                                    A
                                </td>
                            </tr>
                            <tr class="odd gradeA">
                                <td>
                                    <input type="checkbox" id="inlineCheckbox2" value="option2">
                                </td>
                                <td>
                                    Trident
                                </td>
                                <td>
                                    Internet Explorer 7
                                </td>
                                <td>
                                    Win XP SP2+
                                </td>
                                <td class="center">
                                    7
                                </td>
                                <td class="center">
                                    A
                                </td>
                            </tr>
                            <tr class="even gradeA">
                                <td>
                                    <input type="checkbox" id="inlineCheckbox2" value="option2">
                                </td>
                                <td>
                                    Trident
                                </td>
                                <td>
                                    AOL browser (AOL desktop)
                                </td>
                                <td>
                                    Win XP
                                </td>
                                <td class="center">
                                    6
                                </td>
                                <td class="center">
                                    A
                                </td>
                            </tr>
                            <tr class="gradeA">
                                <td>
                                    <input type="checkbox" id="inlineCheckbox2" value="option2">
                                </td>
                                <td>
                                    Gecko
                                </td>
                                <td>
                                    Firefox 1.0
                                </td>
                                <td>
                                    Win 98+ / OSX.2+
                                </td>
                                <td class="center">
                                    1.7
                                </td>
                                <td class="center">
                                    A
                                </td>
                            </tr>
                            <tr class="gradeA">
                                <td>
                                    <input type="checkbox" id="inlineCheckbox2" value="option2">
                                </td>
                                <td>
                                    Gecko
                                </td>
                                <td>
                                    Firefox 1.5
                                </td>
                                <td>
                                    Win 98+ / OSX.2+
                                </td>
                                <td class="center">
                                    1.8
                                </td>
                                <td class="center">
                                    A
                                </td>
                            </tr>
                            <tr class="gradeA">
                                <td>
                                    <input type="checkbox" id="inlineCheckbox2" value="option2">
                                </td>
                                <td>
                                    Gecko
                                </td>
                                <td>
                                    Firefox 2.0
                                </td>
                                <td>
                                    Win 98+ / OSX.2+
                                </td>
                                <td class="center">
                                    1.8
                                </td>
                                <td class="center">
                                    A
                                </td>
                            </tr>
                            <tr class="gradeA">
                                <td>
                                    <input type="checkbox" id="inlineCheckbox2" value="option2">
                                </td>
                                <td>
                                    Gecko
                                </td>
                                <td>
                                    Firefox 3.0
                                </td>
                                <td>
                                    Win 2k+ / OSX.3+
                                </td>
                                <td class="center">
                                    1.9
                                </td>
                                <td class="center">
                                    A
                                </td>
                            </tr>
                            <tr class="gradeA">
                                <td>
                                    <input type="checkbox" id="inlineCheckbox2" value="option2">
                                </td>
                                <td>
                                    Gecko
                                </td>
                                <td>
                                    Camino 1.0
                                </td>
                                <td>
                                    OSX.2+
                                </td>
                                <td class="center">
                                    1.8
                                </td>
                                <td class="center">
                                    A
                                </td>
                            </tr>
                            <tr class="gradeA">
                                <td>
                                    <input type="checkbox" id="inlineCheckbox2" value="option2">
                                </td>
                                <td>
                                    Gecko
                                </td>
                                <td>
                                    Camino 1.5
                                </td>
                                <td>
                                    OSX.3+
                                </td>
                                <td class="center">
                                    1.8
                                </td>
                                <td class="center">
                                    A
                                </td>
                            </tr>
                            <tr class="gradeA">
                                <td>
                                    <input type="checkbox" id="inlineCheckbox2" value="option2">
                                </td>
                                <td>
                                    Gecko
                                </td>
                                <td>
                                    Netscape 7.2
                                </td>
                                <td>
                                    Win 95+ / Mac OS 8.6-9.2
                                </td>
                                <td class="center">
                                    1.7
                                </td>
                                <td class="center">
                                    A
                                </td>
                            </tr>
                            <tr class="gradeA">
                                <td>
                                    <input type="checkbox" id="inlineCheckbox2" value="option2">
                                </td>
                                <td>
                                    Gecko
                                </td>
                                <td>
                                    Netscape Browser 8
                                </td>
                                <td>
                                    Win 98SE+
                                </td>
                                <td class="center">
                                    1.7
                                </td>
                                <td class="center">
                                    A
                                </td>
                            </tr>
                            <tr class="gradeA">
                                <td>
                                    <input type="checkbox" id="inlineCheckbox2" value="option2">
                                </td>
                                <td>
                                    Gecko
                                </td>
                                <td>
                                    Netscape Navigator 9
                                </td>
                                <td>
                                    Win 98+ / OSX.2+
                                </td>
                                <td class="center">
                                    1.8
                                </td>
                                <td class="center">
                                    A
                                </td>
                            </tr>
                            <tr class="gradeA">
                                <td>
                                    <input type="checkbox" id="inlineCheckbox2" value="option2">
                                </td>
                                <td>
                                    Gecko
                                </td>
                                <td>
                                    Mozilla 1.0
                                </td>
                                <td>
                                    Win 95+ / OSX.1+
                                </td>
                                <td class="center">
                                    1
                                </td>
                                <td class="center">
                                    A
                                </td>
                            </tr>
                            <tr class="gradeA">
                                <td>
                                    <input type="checkbox" id="inlineCheckbox2" value="option2">
                                </td>
                                <td>
                                    Gecko
                                </td>
                                <td>
                                    Mozilla 1.1
                                </td>
                                <td>
                                    Win 95+ / OSX.1+
                                </td>
                                <td class="center">
                                    1.1
                                </td>
                                <td class="center">
                                    A
                                </td>
                            </tr>
                            <tr class="gradeA">
                                <td>
                                    <input type="checkbox" id="inlineCheckbox2" value="option2">
                                </td>
                                <td>
                                    Gecko
                                </td>
                                <td>
                                    Mozilla 1.2
                                </td>
                                <td>
                                    Win 95+ / OSX.1+
                                </td>
                                <td class="center">
                                    1.2
                                </td>
                                <td class="center">
                                    A
                                </td>
                            </tr>
                            <tr class="gradeA">
                                <td>
                                    <input type="checkbox" id="inlineCheckbox2" value="option2">
                                </td>
                                <td>
                                    Gecko
                                </td>
                                <td>
                                    Mozilla 1.3
                                </td>
                                <td>
                                    Win 95+ / OSX.1+
                                </td>
                                <td class="center">
                                    1.3
                                </td>
                                <td class="center">
                                    A
                                </td>
                            </tr>
                            <tr class="gradeA">
                                <td>
                                    <input type="checkbox" id="inlineCheckbox2" value="option2">
                                </td>
                                <td>
                                    Gecko
                                </td>
                                <td>
                                    Mozilla 1.4
                                </td>
                                <td>
                                    Win 95+ / OSX.1+
                                </td>
                                <td class="center">
                                    1.4
                                </td>
                                <td class="center">
                                    A
                                </td>
                            </tr>
                            <tr class="gradeA">
                                <td>
                                    <input type="checkbox" id="inlineCheckbox2" value="option2">
                                </td>
                                <td>
                                    Gecko
                                </td>
                                <td>
                                    Mozilla 1.5
                                </td>
                                <td>
                                    Win 95+ / OSX.1+
                                </td>
                                <td class="center">
                                    1.5
                                </td>
                                <td class="center">
                                    A
                                </td>
                            </tr>
                            <tr class="gradeA">
                                <td>
                                    <input type="checkbox" id="inlineCheckbox2" value="option2">
                                </td>
                                <td>
                                    Gecko
                                </td>
                                <td>
                                    Mozilla 1.6
                                </td>
                                <td>
                                    Win 95+ / OSX.1+
                                </td>
                                <td class="center">
                                    1.6
                                </td>
                                <td class="center">
                                    A
                                </td>
                            </tr>
                            <tr class="gradeA">
                                <td>
                                    <input type="checkbox" id="inlineCheckbox2" value="option2">
                                </td>
                                <td>
                                    Gecko
                                </td>
                                <td>
                                    Mozilla 1.7
                                </td>
                                <td>
                                    Win 98+ / OSX.1+
                                </td>
                                <td class="center">
                                    1.7
                                </td>
                                <td class="center">
                                    A
                                </td>
                            </tr>
                            <tr class="gradeA">
                                <td>
                                    <input type="checkbox" id="inlineCheckbox2" value="option2">
                                </td>
                                <td>
                                    Gecko
                                </td>
                                <td>
                                    Mozilla 1.8
                                </td>
                                <td>
                                    Win 98+ / OSX.1+
                                </td>
                                <td class="center">
                                    1.8
                                </td>
                                <td class="center">
                                    A
                                </td>
                            </tr>
                            <tr class="gradeA">
                                <td>
                                    <input type="checkbox" id="inlineCheckbox2" value="option2">
                                </td>
                                <td>
                                    Gecko
                                </td>
                                <td>
                                    Seamonkey 1.1
                                </td>
                                <td>
                                    Win 98+ / OSX.2+
                                </td>
                                <td class="center">
                                    1.8
                                </td>
                                <td class="center">
                                    A
                                </td>
                            </tr>
                            <tr class="gradeA">
                                <td>
                                    <input type="checkbox" id="inlineCheckbox2" value="option2">
                                </td>
                                <td>
                                    Gecko
                                </td>
                                <td>
                                    Epiphany 2.20
                                </td>
                                <td>
                                    Gnome
                                </td>
                                <td class="center">
                                    1.8
                                </td>
                                <td class="center">
                                    A
                                </td>
                            </tr>
                            <tr class="gradeA">
                                <td>
                                    <input type="checkbox" id="inlineCheckbox2" value="option2">
                                </td>
                                <td>
                                    Webkit
                                </td>
                                <td>
                                    Safari 1.2
                                </td>
                                <td>
                                    OSX.3
                                </td>
                                <td class="center">
                                    125.5
                                </td>
                                <td class="center">
                                    A
                                </td>
                            </tr>
                            <tr class="gradeA">
                                <td>
                                    <input type="checkbox" id="inlineCheckbox2" value="option2">
                                </td>
                                <td>
                                    Webkit
                                </td>
                                <td>
                                    Safari 1.3
                                </td>
                                <td>
                                    OSX.3
                                </td>
                                <td class="center">
                                    312.8
                                </td>
                                <td class="center">
                                    A
                                </td>
                            </tr>
                            <tr class="gradeA">
                                <td>
                                    <input type="checkbox" id="inlineCheckbox2" value="option2">
                                </td>
                                <td>
                                    Webkit
                                </td>
                                <td>
                                    Safari 2.0
                                </td>
                                <td>
                                    OSX.4+
                                </td>
                                <td class="center">
                                    419.3
                                </td>
                                <td class="center">
                                    A
                                </td>
                            </tr>
                            <tr class="gradeA">
                                <td>
                                    <input type="checkbox" id="inlineCheckbox2" value="option2">
                                </td>
                                <td>
                                    Webkit
                                </td>
                                <td>
                                    Safari 3.0
                                </td>
                                <td>
                                    OSX.4+
                                </td>
                                <td class="center">
                                    522.1
                                </td>
                                <td class="center">
                                    A
                                </td>
                            </tr>
                            <tr class="gradeA">
                                <td>
                                    <input type="checkbox" id="inlineCheckbox2" value="option2">
                                </td>
                                <td>
                                    Webkit
                                </td>
                                <td>
                                    OmniWeb 5.5
                                </td>
                                <td>
                                    OSX.4+
                                </td>
                                <td class="center">
                                    420
                                </td>
                                <td class="center">
                                    A
                                </td>
                            </tr>
                            <tr class="gradeA">
                                <td>
                                    <input type="checkbox" id="inlineCheckbox2" value="option2">
                                </td>
                                <td>
                                    Webkit
                                </td>
                                <td>
                                    iPod Touch / iPhone
                                </td>
                                <td>
                                    iPod
                                </td>
                                <td class="center">
                                    420.1
                                </td>
                                <td class="center">
                                    A
                                </td>
                            </tr>
                            <tr class="gradeA">
                                <td>
                                    <input type="checkbox" id="inlineCheckbox2" value="option2">
                                </td>
                                <td>
                                    Webkit
                                </td>
                                <td>
                                    S60
                                </td>
                                <td>
                                    S60
                                </td>
                                <td class="center">
                                    413
                                </td>
                                <td class="center">
                                    A
                                </td>
                            </tr>
                            <tr class="gradeA">
                                <td>
                                    <input type="checkbox" id="inlineCheckbox2" value="option2">
                                </td>
                                <td>
                                    Webkit
                                </td>
                                <td>
                                    Opera 7.0
                                </td>
                                <td>
                                    Win 95+ / OSX.1+
                                </td>
                                <td class="center">
                                    -
                                </td>
                                <td class="center">
                                    A
                                </td>
                            </tr>
                            <tr class="gradeA">
                                <td>
                                    <input type="checkbox" id="inlineCheckbox2" value="option2">
                                </td>
                                <td>
                                    Webkit
                                </td>
                                <td>
                                    Opera 7.5
                                </td>
                                <td>
                                    Win 95+ / OSX.2+
                                </td>
                                <td class="center">
                                    -
                                </td>
                                <td class="center">
                                    A
                                </td>
                            </tr>
                            <tr class="gradeA">
                                <td>
                                    <input type="checkbox" id="inlineCheckbox2" value="option2">
                                </td>
                                <td>
                                    Webkit
                                </td>
                                <td>
                                    Opera 8.0
                                </td>
                                <td>
                                    Win 95+ / OSX.2+
                                </td>
                                <td class="center">
                                    -
                                </td>
                                <td class="center">
                                    A
                                </td>
                            </tr>
                            <tr class="gradeA">
                                <td>
                                    <input type="checkbox" id="inlineCheckbox2" value="option2">
                                </td>
                                <td>
                                    Webkit
                                </td>
                                <td>
                                    Opera 8.5
                                </td>
                                <td>
                                    Win 95+ / OSX.2+
                                </td>
                                <td class="center">
                                    -
                                </td>
                                <td class="center">
                                    A
                                </td>
                            </tr>
                            <tr class="gradeA">
                                <td>
                                    <input type="checkbox" id="inlineCheckbox2" value="option2">
                                </td>
                                <td>
                                    Webkit
                                </td>
                                <td>
                                    Opera 9.0
                                </td>
                                <td>
                                    Win 95+ / OSX.3+
                                </td>
                                <td class="center">
                                    -
                                </td>
                                <td class="center">
                                    A
                                </td>
                            </tr>
                            <tr class="gradeA">
                                <td>
                                    <input type="checkbox" id="inlineCheckbox2" value="option2">
                                </td>
                                <td>
                                    Webkit
                                </td>
                                <td>
                                    Opera 9.2
                                </td>
                                <td>
                                    Win 88+ / OSX.3+
                                </td>
                                <td class="center">
                                    -
                                </td>
                                <td class="center">
                                    A
                                </td>
                            </tr>
                            <tr class="gradeA">
                                <td>
                                    <input type="checkbox" id="inlineCheckbox2" value="option2">
                                </td>
                                <td>
                                    Webkit
                                </td>
                                <td>
                                    Opera 9.5
                                </td>
                                <td>
                                    Win 88+ / OSX.3+
                                </td>
                                <td class="center">
                                    -
                                </td>
                                <td class="center">
                                    A
                                </td>
                            </tr>
                            <tr class="gradeA">
                                <td>
                                    <input type="checkbox" id="inlineCheckbox2" value="option2">
                                </td>
                                <td>
                                    Webkit
                                </td>
                                <td>
                                    Opera for Wii
                                </td>
                                <td>
                                    Wii
                                </td>
                                <td class="center">
                                    -
                                </td>
                                <td class="center">
                                    A
                                </td>
                            </tr>
                            <tr class="gradeA">
                                <td>
                                    <input type="checkbox" id="inlineCheckbox2" value="option2">
                                </td>
                                <td>
                                    Webkit
                                </td>
                                <td>
                                    Nokia N800
                                </td>
                                <td>
                                    N800
                                </td>
                                <td class="center">
                                    -
                                </td>
                                <td class="center">
                                    A
                                </td>
                            </tr>
                            <tr class="gradeA">
                                <td>
                                    <input type="checkbox" id="inlineCheckbox2" value="option2">
                                </td>
                                <td>
                                    Webkit
                                </td>
                                <td>
                                    Nintendo DS browser
                                </td>
                                <td>
                                    Nintendo DS
                                </td>
                                <td class="center">
                                    8.5
                                </td>
                                <td class="center">
                                    C/A<sup>1</sup>
                                </td>
                            </tr>
                            <tr class="gradeC">
                                <td>
                                    <input type="checkbox" id="inlineCheckbox2" value="option2">
                                </td>
                                <td>
                                    KHTML
                                </td>
                                <td>
                                    Konqureror 3.1
                                </td>
                                <td>
                                    KDE 3.1
                                </td>
                                <td class="center">
                                    3.1
                                </td>
                                <td class="center">
                                    C
                                </td>
                            </tr>
                            <tr class="gradeA">
                                <td>
                                    <input type="checkbox" id="inlineCheckbox2" value="option2">
                                </td>
                                <td>
                                    KHTML
                                </td>
                                <td>
                                    Konqureror 3.3
                                </td>
                                <td>
                                    KDE 3.3
                                </td>
                                <td class="center">
                                    3.3
                                </td>
                                <td class="center">
                                    A
                                </td>
                            </tr>
                            <tr class="gradeA">
                                <td>
                                    <input type="checkbox" id="inlineCheckbox2" value="option2">
                                </td>
                                <td>
                                    KHTML
                                </td>
                                <td>
                                    Konqureror 3.5
                                </td>
                                <td>
                                    KDE 3.5
                                </td>
                                <td class="center">
                                    3.5
                                </td>
                                <td class="center">
                                    A
                                </td>
                            </tr>
                            <tr class="gradeX">
                                <td>
                                    <input type="checkbox" id="inlineCheckbox2" value="option2">
                                </td>
                                <td>
                                    Tasman
                                </td>
                                <td>
                                    Internet Explorer 4.5
                                </td>
                                <td>
                                    Mac OS 8-9
                                </td>
                                <td class="center">
                                    -
                                </td>
                                <td class="center">
                                    X
                                </td>
                            </tr>
                            <tr class="gradeC">
                                <td>
                                    <input type="checkbox" id="inlineCheckbox2" value="option2">
                                </td>
                                <td>
                                    Tasman
                                </td>
                                <td>
                                    Internet Explorer 5.1
                                </td>
                                <td>
                                    Mac OS 7.6-9
                                </td>
                                <td class="center">
                                    1
                                </td>
                                <td class="center">
                                    C
                                </td>
                            </tr>
                            <tr class="gradeC">
                                <td>
                                    <input type="checkbox" id="inlineCheckbox2" value="option2">
                                </td>
                                <td>
                                    Tasman
                                </td>
                                <td>
                                    Internet Explorer 5.2
                                </td>
                                <td>
                                    Mac OS 8-X
                                </td>
                                <td class="center">
                                    1
                                </td>
                                <td class="center">
                                    C
                                </td>
                            </tr>
                            <tr class="gradeA">
                                <td>
                                    <input type="checkbox" id="inlineCheckbox2" value="option2">
                                </td>
                                <td>
                                    Misc
                                </td>
                                <td>
                                    NetFront 3.1
                                </td>
                                <td>
                                    Embedded devices
                                </td>
                                <td class="center">
                                    -
                                </td>
                                <td class="center">
                                    C
                                </td>
                            </tr>
                            <tr class="gradeA">
                                <td>
                                    <input type="checkbox" id="inlineCheckbox2" value="option2">
                                </td>
                                <td>
                                    Misc
                                </td>
                                <td>
                                    NetFront 3.4
                                </td>
                                <td>
                                    Embedded devices
                                </td>
                                <td class="center">
                                    -
                                </td>
                                <td class="center">
                                    A
                                </td>
                            </tr>
                            <tr class="gradeX">
                                <td>
                                    <input type="checkbox" id="inlineCheckbox2" value="option2">
                                </td>
                                <td>
                                    Misc
                                </td>
                                <td>
                                    Dillo 0.8
                                </td>
                                <td>
                                    Embedded devices
                                </td>
                                <td class="center">
                                    -
                                </td>
                                <td class="center">
                                    X
                                </td>
                            </tr>
                            <tr class="gradeX">
                                <td>
                                    <input type="checkbox" id="inlineCheckbox2" value="option2">
                                </td>
                                <td>
                                    Misc
                                </td>
                                <td>
                                    Links
                                </td>
                                <td>
                                    Text only
                                </td>
                                <td class="center">
                                    -
                                </td>
                                <td class="center">
                                    X
                                </td>
                            </tr>
                            <tr class="gradeX">
                                <td>
                                    <input type="checkbox" id="inlineCheckbox2" value="option2">
                                </td>
                                <td>
                                    Misc
                                </td>
                                <td>
                                    Lynx
                                </td>
                                <td>
                                    Text only
                                </td>
                                <td class="center">
                                    -
                                </td>
                                <td class="center">
                                    X
                                </td>
                            </tr>
                            <tr class="gradeC">
                                <td>
                                    <input type="checkbox" id="inlineCheckbox2" value="option2">
                                </td>
                                <td>
                                    Misc
                                </td>
                                <td>
                                    IE Mobile
                                </td>
                                <td>
                                    Windows Mobile 6
                                </td>
                                <td class="center">
                                    -
                                </td>
                                <td class="center">
                                    C
                                </td>
                            </tr>
                            <tr class="gradeC">
                                <td>
                                    <input type="checkbox" id="inlineCheckbox2" value="option2">
                                </td>
                                <td>
                                    Misc
                                </td>
                                <td>
                                    PSP browser
                                </td>
                                <td>
                                    PSP
                                </td>
                                <td class="center">
                                    -
                                </td>
                                <td class="center">
                                    C
                                </td>
                            </tr>
                            <tr class="gradeU">
                                <td>
                                    <input type="checkbox" id="inlineCheckbox2" value="option2">
                                </td>
                                <td>
                                    Other browsers
                                </td>
                                <td>
                                    All others
                                </td>
                                <td>
                                    -
                                </td>
                                <td class="center">
                                    -
                                </td>
                                <td class="center">
                                    U
                                </td>
                            </tr>
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
