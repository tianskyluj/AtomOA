<%@ Page Language="C#" AutoEventWireup="true" CodeFile="500.aspx.cs" Inherits="Web_500" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <lan:head runat="server" ID="head" />
</head>
<body>
    <div class="wraper sidebar-full">
        <form id="form1" runat="server">
        <%--<lan:sidebar runat="server" ID="sidebar" />
        <lan:header runat="server" ID="header" />--%>
            <div class="container-fluid" id="mainContent">
                <div class="row-fluid">
                    <div class="error-500">
                        <i class="icon-remove-sign icon-4x error-icon"></i>
                        <h1>
                            服务器内部发生错误!</h1>
                        <span class="text-error"><small><strong>Error 500</strong></small></span>
                        <p>
                            抱歉！一个内部错误中断了操作，请返回，我们会尽快处理.</p>
                    </div>
                </div>
            </div>
        <lan:messageControls runat="server" ID="messageControls" />
        <lan:jsInclude runat="server" ID="jsInclude" />
        </form>
    </div>
</body>
</html>
