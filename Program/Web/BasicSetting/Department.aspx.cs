using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Web_BasicSetting_Department : BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        bindGridView();
    }

    protected void bindGridView()
    {
        ATOM.BLL.Department department_BLL = new ATOM.BLL.Department();
        this.dataRow.DataSource = department_BLL.GetAllList().Tables[0];
        this.dataRow.DataBind();
    }
}