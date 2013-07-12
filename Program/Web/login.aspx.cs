using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ASPNETChatControl;

public partial class web_login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //this.fafa.Text = Maticsoft.Common.DEncrypt.DEncrypt.Encrypt("840513lan");
        try
        {
            if (ATOM.BLL.SystemUser.getSessionSiteUser().Id != null)
                Response.Redirect(inc.getApplicationPath() + "/web/index.aspx");
        }
        catch { }

        this.title_login.Text = ATOM.BLL.GlobalSetting.GetCompanyName();
        this.title.Text = this.title_login.Text + " - 登录";
        
    }

    protected void login_Click(object sender, EventArgs e)
    {
        ATOM.BLL.SystemUser user_BLL = new ATOM.BLL.SystemUser();
        if (user_BLL.Login(this.userName.Value.Trim(), Maticsoft.Common.DEncrypt.DEncrypt.Encrypt(this.passWord.Value.Trim())))
        {
            StartChatSeesion();
            Response.Redirect("index.aspx");
        }
        else
        {
            inc.msg("用户名密码不正确");
        }
    }

    /// <summary>
    /// 开始chat工具seesion
    /// </summary>
    protected void StartChatSeesion()
    {
        if (ChatControl.CurrentChatSession != null)
        {
            ChatControl.StopSession();
        }
        ChatControl.StartSession(ATOM.BLL.SystemUser.getSessionSiteUser().Name);
    }
}