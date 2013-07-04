using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;

public partial class Web_BasicSetting_Area : BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // 赋值高级查询条件
        setSearchValue();
        bindGridView();
    }

    /// <summary>
    /// 赋值前台传过来的查询条件
    /// </summary>
    protected void setSearchValue()
    {
        this.areaName_search.Text = inc.getFormPar("areaName").Trim();
        this.remark_search.Text = inc.getFormPar("remark").Trim();
        this.areaName_check_search.Checked = inc.getFormPar("areaNameIfAccurate") == "true" ? true : false;
        this.remark_check_search.Checked = inc.getFormPar("remarkIfAccurate") == "true" ? true : false;
    }

    /// <summary>
    /// 绑定列表
    /// </summary>
    protected void bindGridView()
    {
        ATOM.BLL.Area area_BLL = new ATOM.BLL.Area();
        this.dataRow.DataSource = area_BLL.GetList(getSqlWhere()).Tables[0];
        this.dataRow.DataBind();
    }

    /// <summary>
    /// 获取查询字符串
    /// </summary>
    /// <returns></returns>
    protected string getSqlWhere()
    {
        System.Text.StringBuilder where = new System.Text.StringBuilder("1=1");

        if (this.areaName_search.Text.Trim().Length != 0)
        {
            if (this.areaName_check_search.Checked)
                where.Append(" and areaName ='" + this.areaName_search.Text.Trim() + "' ");
            else
                where.Append(" and areaName like '%" + this.areaName_search.Text.Trim() + "%' ");
        }

        if (this.remark_search.Text.Trim().Length != 0)
        {
            if (this.remark_check_search.Checked)
                where.Append(" and remark = '" + this.remark_search.Text.Trim() + "' ");
            else
                where.Append(" and remark like '%" + this.remark_search.Text.Trim() + "%' ");
        }

        return where.ToStr();
    }

    /// <summary>
    /// 添加或者修改数据
    /// </summary>
    /// <param name="companyName"></param>
    /// <param name="modelId"></param>
    /// <returns></returns>
    [WebMethod]
    public static string update(string id, string areaName, string remark)
    {
        ATOM.BLL.Area area_BLL = new ATOM.BLL.Area();
        ATOM.Model.Area area_Model = new ATOM.Model.Area();

        area_Model.Id = id.ToInt();
        area_Model.AreaName = areaName.Trim();
        area_Model.remark = remark.Trim();

        if (area_BLL.AddUpdate(area_Model))
            return "1";
        else
            return "0";
    }

    /// <summary>
    /// 获取模型数据赋值到前台页面
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    [WebMethod]
    public static string getModelValue(string id)
    {
        ATOM.BLL.Area area_BLL = new ATOM.BLL.Area();
        string s = Maticsoft.Common.JsonHelper.DTtoJSON(area_BLL.GetList("id=" + id.Trim()).Tables[0]);
        return s.ToString();
    }

    /// <summary>
    /// 删除记录
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    [WebMethod]
    public static string deleteModel(string id)
    {
        ATOM.BLL.Area area_BLL = new ATOM.BLL.Area();
        return area_BLL.Delete(id.ToInt()) ? "1" : "删除出错，请稍候再试";
    }
}
