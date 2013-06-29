<%@ Page Language="C#" AutoEventWireup="true" CodeFile="404.aspx.cs" Inherits="Web_Error_404" %>

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
                    <div class="error-404">
                        <i class="icon-warning-sign icon-4x error-icon"></i>
                        <h1>
                            页面没有找到</h1>
                        <span class="text-error"><small><strong>Error 404</strong></small></span>
                        <p>
                            对不起, 您希望访问的页面不存在.</p>
                        <form action="#">
                        
                        </form>
                    </div>
                </div>
            <%--<lan:footer runat="server" ID="footer" />--%>
        </div>
        <lan:messageControls runat="server" ID="messageControls" />
        <lan:jsInclude runat="server" ID="jsInclude" />
        </form>
    </div>
</body>
</html>
