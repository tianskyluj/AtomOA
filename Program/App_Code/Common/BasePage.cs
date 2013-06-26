using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

public class BasePage : System.Web.UI.Page
{
    //pageunload事件，并不是指浏览器关闭，而是指页面关闭，所以刷新的时候，依然会执行以下事件 
    protected void Page_Unload(object sender, EventArgs e)
    {

    }
    protected override void OnPreInit(EventArgs e)
    {
        base.OnPreInit(e);
        if (!ATOM.BLL.SystemUser.ifLogin())
        {
            //这里写 跳转到登陆页面：例如： 
            Response.Redirect(inc.getApplicationPath() + "/Web/login.aspx");
            inc.msg("请先登录");
        }
    }
}
