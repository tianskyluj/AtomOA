using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

public partial class webControl_header : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Maticsoft.Common.DataSession.getSessionSiteUser().UserName != "lan")
            this.systemSetting.Visible = false;
    }

    /// <summary>
    /// 登出
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void loginOut_Click(object sender, EventArgs e)
    {
        Maticsoft.Common.DataSession.destroySession();
        Response.Redirect("login.aspx");
    }
}
