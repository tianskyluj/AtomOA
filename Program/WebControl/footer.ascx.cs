using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class webControl_footer : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        this.userId.Text = ATOM.BLL.SystemUser.getSessionSiteUser().Id.ToStr();
    }
}