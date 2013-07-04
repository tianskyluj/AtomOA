﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;
using System.Data;

public partial class Web_BasicSetting_Role : BasePage
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
        this.provinceName_search.Text = inc.getFormPar("provinceName").Trim();
        this.remark_search.Text = inc.getFormPar("remark").Trim();
        this.department_search.SelectedValue = inc.getFormPar("departmentId").Trim();
        this.provinceName_check_search.Checked = inc.getFormPar("provinceNameIfAccurate") == "true" ? true : false;
        this.remark_check_search.Checked = inc.getFormPar("remarkIfAccurate") == "true" ? true : false;
    }

    /// <summary>
    /// 绑定列表
    /// </summary>
    protected void bindGridView()
    {
        string strSql = " select a.*,b.departmentName from role a left join department b on a.departmentId=b.id where " + this.getSqlWhere();
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

        if (this.provinceName_search.Text.Trim().Length != 0)
        {
            if (this.provinceName_check_search.Checked)
                where.Append(" and provinceName ='" + this.provinceName_search.Text.Trim() + "' ");
            else
                where.Append(" and provinceName like '%" + this.provinceName_search.Text.Trim() + "%' ");
        }

        if (this.remark_search.Text.Trim().Length != 0)
        {
            if (this.remark_check_search.Checked)
                where.Append(" and remark = '" + this.remark_search.Text.Trim() + "' ");
            else
                where.Append(" and remark like '%" + this.remark_search.Text.Trim() + "%' ");
        }
        if (this.department_search.SelectedValue != "0")
        {
            where.Append(" and departmentId= "+this.department_search.SelectedValue);
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
    public static string update(string id, string roleName,string departmentId, string remark)
    {
        ATOM.BLL.Role role_BLL = new ATOM.BLL.Role();
        ATOM.Model.Role role_Model = new ATOM.Model.Role();

        role_Model.Id = id.ToInt();
        role_Model.RoleName = roleName.Trim();
        role_Model.DepartmentId = departmentId.ToInt();
        role_Model.remark = remark.Trim();

        if (province_BLL.AddUpdate(province_Model))
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
        ATOM.BLL.Province province_BLL = new ATOM.BLL.Province();
        string s = Maticsoft.Common.JsonHelper.DTtoJSON(province_BLL.GetList("id=" + id.Trim()).Tables[0]);
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
        ATOM.BLL.Province province_BLL = new ATOM.BLL.Province();
        return province_BLL.Delete(id.ToInt()) ? "1" : "删除出错，请稍候再试";
    }
}