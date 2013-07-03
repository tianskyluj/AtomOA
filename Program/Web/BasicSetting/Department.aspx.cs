using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;

public partial class Web_BasicSetting_Department : BasePage
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
        this.department_search.Text = inc.getFormPar("departmentName").Trim();
        this.remark_search.Text = inc.getFormPar("remark").Trim();
        this.department_check_search.Checked = inc.getFormPar("departmentNameIfAccurate") == "true" ? true : false;
        this.remark_check_search.Checked = inc.getFormPar("remarkIfAccurate") == "true" ? true : false;
    }

    /// <summary>
    /// 绑定列表
    /// </summary>
    protected void bindGridView()
    {
        ATOM.BLL.Department department_BLL = new ATOM.BLL.Department();
        this.dataRow.DataSource = department_BLL.GetList(getSqlWhere()).Tables[0];
        this.dataRow.DataBind();
    }

    /// <summary>
    /// 获取查询字符串
    /// </summary>
    /// <returns></returns>
    protected string getSqlWhere()
    {
        System.Text.StringBuilder where = new System.Text.StringBuilder("1=1");

        if (this.department_search.Text.Trim().Length != 0)
        {
            if (this.department_check_search.Checked)
                where.Append(" and departmentName ='" + this.department_search.Text.Trim() + "' ");
            else
                where.Append(" and DepartmentName like '%" + this.department_search.Text.Trim() + "%' ");
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
    public static string update(string id,string departmentName, string remark)
    {
        ATOM.BLL.Department department_BLL = new ATOM.BLL.Department();
        ATOM.Model.Department department_Model = new ATOM.Model.Department();

        department_Model.Id = id.ToInt();
        department_Model.DepartmentName = departmentName.Trim();
        department_Model.remark = remark.Trim();

        if (department_BLL.AddUpdate(department_Model))
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
        ATOM.BLL.Department department_BLL = new ATOM.BLL.Department();
        string s = Maticsoft.Common.JsonHelper.DTtoJSON(department_BLL.GetList("id=" + id.Trim()).Tables[0]);
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
        ATOM.BLL.Department department_BLL = new ATOM.BLL.Department();
        return department_BLL.Delete(id.ToInt()) ? "1" : "删除出错，请稍候再试";
    }
}