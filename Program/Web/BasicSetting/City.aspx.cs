using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;
using System.Data;

public partial class Web_BasicSetting_City : BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // 赋值高级查询条件
        bindDropdownlist();
        setSearchValue();
        bindGridView();
    }

    /// <summary>
    /// 绑定下拉列表
    /// </summary>
    protected void bindDropdownlist()
    {
        DataTable dt = new ATOM.BLL.Province().GetAllList().Tables[0];
        this.province_edit.DataSource = dt;
        this.province_edit.DataValueField = "id";
        this.province_edit.DataTextField = "provinceName";
        this.province_edit.DataBind();
        this.province_edit.Items.Add(new ListItem("请选择省份","0"));
        this.province_edit.SelectedValue = "0";

        this.province_search.DataSource = dt;
        this.province_search.DataValueField = "id";
        this.province_search.DataTextField = "provinceName";
        this.province_search.DataBind();
        this.province_search.Items.Add(new ListItem("请选择省份", "0"));
        this.province_search.SelectedValue = "0";
    }

    /// <summary>
    /// 赋值前台传过来的查询条件
    /// </summary>
    protected void setSearchValue()
    {
        this.cityName_search.Text = inc.getFormPar("cityName").Trim();
        this.remark_search.Text = inc.getFormPar("remark").Trim();
        this.cityName_check_search.Checked = inc.getFormPar("cityNameIfAccurate") == "true" ? true : false;
        this.remark_check_search.Checked = inc.getFormPar("remarkIfAccurate") == "true" ? true : false;
        this.province_search.SelectedValue = inc.getFormPar("province").Trim();
    }

    /// <summary>
    /// 绑定列表
    /// </summary>
    protected void bindGridView()
    {
        string strSql = " select a.*,b.provinceName from city a left join province b on a.provinceId=b.id where "+this.getSqlWhere();
        DataTable dt = Maticsoft.DBUtility.DbHelperSQL.Query(strSql.ToString()).Tables[0];
        this.dataRow.DataSource = dt;
        this.dataRow.DataBind();
    }

    /// <summary>
    /// 获取查询字符串
    /// </summary>
    /// <returns></returns>
    protected string getSqlWhere()
    {
        System.Text.StringBuilder where = new System.Text.StringBuilder("1=1");

        if (this.cityName_search.Text.Trim().Length != 0)
        {
            if (this.cityName_check_search.Checked)
                where.Append(" and cityName ='" + this.cityName_search.Text.Trim() + "' ");
            else
                where.Append(" and cityName like '%" + this.cityName_search.Text.Trim() + "%' ");
        }

        if (this.remark_search.Text.Trim().Length != 0)
        {
            if (this.remark_check_search.Checked)
                where.Append(" and remark = '" + this.remark_search.Text.Trim() + "' ");
            else
                where.Append(" and remark like '%" + this.remark_search.Text.Trim() + "%' ");
        }
        if (this.province_search.SelectedValue != "0")
        {
            where.Append(" and provinceId= " + this.province_search.SelectedValue);
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
    public static string update(string id, string cityName,string  province, string remark)
    {
        ATOM.BLL.City city_BLL = new ATOM.BLL.City();
        ATOM.Model.City city_Model = new ATOM.Model.City();

        city_Model.Id = id.ToInt();
        city_Model.CityName = cityName.Trim();
        city_Model.ProvinceId = province.ToInt();
        city_Model.remark = remark.Trim();

        if (city_BLL.AddUpdate(city_Model))
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
        ATOM.BLL.City city_BLL = new ATOM.BLL.City();
        string s = Maticsoft.Common.JsonHelper.DTtoJSON(city_BLL.GetList("id=" + id.Trim()).Tables[0]);
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
        ATOM.BLL.City city_BLL = new ATOM.BLL.City();
        return city_BLL.Delete(id.ToInt()) ? "1" : "删除出错，请稍候再试";
    }
}
