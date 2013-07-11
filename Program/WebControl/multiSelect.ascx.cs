using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebControl_multiSelect : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    /// <summary>
    /// 获取或设置如果没有选定值时的默认值 DefaultValue
    /// </summary>
    public string DefaultValue
    {
        get { return this.defaultValue.Text.ToString(); }
        set { this.defaultValue.Text = value; }
    }

    /// <summary>
    /// 没用任务项选中时显示的默认值
    /// </summary>
    public string DefaultText
    {
        get { return this.defaultText.Text.ToString(); }
        set { this.defaultText.Text = value; }
    }

    /// <summary>
    /// 获取或设置对象，数据绑定控件从该对象中检索其数据项列表。
    /// </summary>
    public object DataSource
    {
        get { return this.multiSelect.DataSource; }
        set { this.multiSelect.DataSource = value; }
    }

    /// <summary>
    /// 获取或设置为列表项提供文本内容的数据源字段
    /// </summary>
    public string DataTextField
    {
        get { return this.multiSelect.DataTextField; }
        set { this.multiSelect.DataTextField = value; }
    }

    /// <summary>
    /// 获取或设置为各列表项提供值的数据源字段。
    /// </summary>
    public string DataValueField
    {
        get { return this.multiSelect.DataValueField; }
        set { this.multiSelect.DataValueField = value; }
    }

    /// <summary>
    /// 获取或设置控件的class属性
    /// </summary>
    public string CssClass
    {
        get { return this.lblclass.Text; }
        set { this.lblclass.Text = value; }
    }

    /// <summary>
    /// 获取或设置选定值
    /// </summary>
    public string SelectedValue
    {
        get { return this.GetSelectValue(); }
        set
        {
            this.SetSelectValue(value);
        }
    }

    /// <summary>
    /// 获取选定值，以英文逗号“,”为分隔符。
    /// </summary>
    /// <returns></returns>
    public string GetSelectValue()
    {
        ((System.Web.UI.Page)System.Web.HttpContext.Current.Handler).ClientScript.RegisterStartupScript(((System.Web.UI.Page)System.Web.HttpContext.Current.Handler).GetType(), "script", "getValue();", true);
        return this.selectedValue.Text.Trim();
    }

    /// <summary>
    /// 设置选定项
    /// </summary>
    /// <param name="selectValue">值</param>
    /// <param name="separator">分隔符</param>
    public void SetSelectValue(string selectedValue)
    {
        this.selectedValue.Text = selectedValue;
        //((System.Web.UI.Page)System.Web.HttpContext.Current.Handler).ClientScript.RegisterStartupScript(((System.Web.UI.Page)System.Web.HttpContext.Current.Handler).GetType(), "script", "setValue();", true);
    }
}