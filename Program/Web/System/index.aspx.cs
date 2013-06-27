using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;

public partial class Web_System_index : BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
        }
        showData();
    }

    /// <summary>
    /// 显示页面数据
    /// </summary>
    protected void showData()
    {
        showGlobalSetting();
    }

    /// <summary>
    /// 显示全局设置
    /// </summary>
    protected void showGlobalSetting()
    {
        ATOM.BLL.GlobalSetting global_BLL = new ATOM.BLL.GlobalSetting();
        ATOM.Model.GlobalSetting global_Model = global_BLL.GetModel(1);
        if (global_Model != null)
        {
            this.companyName_edit.Text = global_Model.CompanyName.ToStr();
            this.globalSettingId.Text = global_Model.Id.ToStr();
        }
        else
        {
            global_Model = new ATOM.Model.GlobalSetting();
            global_Model.CompanyName = this.companyName_edit.Text.Trim();
            int globalId = global_BLL.Add(global_Model);
            this.globalSettingId.Text = globalId.ToStr();
        }
    }

    /// <summary>
    /// 更新全局变量
    /// </summary>
    /// <param name="companyName"></param>
    /// <param name="modelId"></param>
    /// <returns></returns>
    [WebMethod]
    public static string updateGlobalSetting(string companyName,string modelId)
    {
        ATOM.BLL.GlobalSetting global_BLL = new ATOM.BLL.GlobalSetting();
        ATOM.Model.GlobalSetting global_Model = new ATOM.Model.GlobalSetting();

        global_Model.Id = modelId.ToInt();
        global_Model.CompanyName = companyName.Trim();

        if (global_BLL.AddUpdate(global_Model))
            return "1";
        else
            return "0";
    }
}