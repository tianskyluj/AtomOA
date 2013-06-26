using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class web_login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //this.fafa.Text = Maticsoft.Common.DEncrypt.DEncrypt.Encrypt("840513lan");
    }

    protected void login_Click(object sender, EventArgs e)
    {
        ATOM.BLL.SystemUser user_BLL = new ATOM.BLL.SystemUser();
        if (user_BLL.Login(this.userName.Value.Trim(), Maticsoft.Common.DEncrypt.DEncrypt.Encrypt(this.passWord.Value.Trim())))
            Response.Redirect("index.aspx");
        else
            inc.msg("用户名密码不正确");

    }
}