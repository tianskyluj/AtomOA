using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;
using System.Text;
using System.IO;

public partial class Web_System_Profile : BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        showData();
    }

    /// <summary>
    /// 显示页面数据
    /// </summary>
    protected void showData()
    {
        showProfile();
        showNowAvatar();
    }

    // 显示用户当前头像
    protected void showNowAvatar()
    {
        this.avatarNow.Src = ATOM.BLL.SystemUser.getUserAvatar();
    }

    /// <summary>
    /// 显示全局设置
    /// </summary>
    protected void showProfile()
    {
        ATOM.BLL.SystemUser user_bll= new ATOM.BLL.SystemUser();
        ATOM.Model.SystemUser user_model = user_bll.GetModel(ATOM.BLL.SystemUser.getSessionSiteUser().Id);
        this.email_edit.Text = user_model.Email.ToStr().Trim();
        this.telephone_edit.Text = user_model.Phone.ToStr().Trim();
        this.QQ_edit.Text = user_model.QQ.ToStr().Trim();
    }

    /// <summary>
    /// 更新全局变量
    /// </summary>
    /// <param name="companyName"></param>
    /// <param name="modelId"></param>
    /// <returns></returns>
    [WebMethod]
    public static string updateProfile(string telephone, string email, string qq)
    {
        ATOM.BLL.SystemUser user_bll = new ATOM.BLL.SystemUser();
        ATOM.Model.SystemUser user_model = user_bll.GetModel(ATOM.BLL.SystemUser.getSessionSiteUser().Id);

        user_model.Email = email;
        user_model.Phone = telephone;
        user_model.QQ = qq;

        if (user_bll.Update(user_model))
            return "1";
        else
            return "0";
    }

    /// <summary>
    /// 修改密码 
    /// </summary>
    /// <param name="companyName"></param>
    /// <param name="modelId"></param>
    /// <returns></returns>
    [WebMethod]
    public static string changePassword(string oldPassword, string newPassword)
    {
        ATOM.BLL.SystemUser user_bll = new ATOM.BLL.SystemUser();
        ATOM.Model.SystemUser user_model = user_bll.GetModel(ATOM.BLL.SystemUser.getSessionSiteUser().Id);

        string oldPassword_encrypt = Maticsoft.Common.DEncrypt.DEncrypt.Encrypt(oldPassword.Trim());
        if (oldPassword_encrypt.Trim() != user_model.PassWord.Trim())
            return "旧密码输入不正确，请稍候尝试";

        user_model.PassWord = Maticsoft.Common.DEncrypt.DEncrypt.Encrypt(newPassword.Trim());
        if (user_bll.Update(user_model))
            return "1";
        else
            return "修改没有成功，请稍候再试";
    }

    /// <summary>
    /// 上传头像 
    /// </summary>
    /// <param name="avatar">图像的base64编码</param>
    /// <returns></returns>
    [WebMethod]
    public static string uploadAvatar(string avatar)
    {
        ATOM.BLL.SystemUser user_bll = new ATOM.BLL.SystemUser();
        ATOM.Model.SystemUser user_model = user_bll.GetModel(ATOM.BLL.SystemUser.getSessionSiteUser().Id);
        string fileUrl = inc.getApplicationPath() + "/Upload/Avatar/" + ATOM.BLL.SystemUser.getSessionSiteUser().Id.ToStr() + "_avatar.txt";
        StreamWriter sw;
        sw = File.CreateText(HttpContext.Current.Server.MapPath(fileUrl));
        sw.Write(avatar);
        sw.Close();
        sw.Dispose();

        user_model.Avatar = fileUrl;

        if (user_bll.Update(user_model))
            return "1";
        else
            return "修改没有成功，请稍候再试";
    }
}