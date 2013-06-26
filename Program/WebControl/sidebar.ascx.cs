using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class webControl_sidebar : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        this.name.Text = ATOM.BLL.SystemUser.getSessionSiteUser().Name.ToStr();
    }
}
