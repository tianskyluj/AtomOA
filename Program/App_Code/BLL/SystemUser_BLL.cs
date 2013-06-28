using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using ATOM.Model;
using System.Web;
using System.Text;
using System.IO;

namespace ATOM.BLL
{
    /// <summary>
    /// SystemUser
    /// </summary>
    public partial class SystemUser
    {
        private readonly ATOM.DAL.SystemUser dal = new ATOM.DAL.SystemUser();
        public SystemUser()
        { }
        #region  Method

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(ATOM.Model.SystemUser model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(ATOM.Model.SystemUser model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int Id)
        {

            return dal.Delete(Id);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string Idlist)
        {
            return dal.DeleteList(Idlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public ATOM.Model.SystemUser GetModel(int Id)
        {

            return dal.GetModel(Id);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public ATOM.Model.SystemUser GetModelByCache(int Id)
        {

            string CacheKey = "SystemUserModel-" + Id;
            object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(Id);
                    if (objModel != null)
                    {
                        int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
                        Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (ATOM.Model.SystemUser)objModel;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            return dal.GetList(strWhere);
        }
        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            return dal.GetList(Top, strWhere, filedOrder);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<ATOM.Model.SystemUser> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<ATOM.Model.SystemUser> DataTableToList(DataTable dt)
        {
            List<ATOM.Model.SystemUser> modelList = new List<ATOM.Model.SystemUser>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                ATOM.Model.SystemUser model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new ATOM.Model.SystemUser();
                    if (dt.Rows[n]["Id"] != null && dt.Rows[n]["Id"].ToString() != "")
                    {
                        model.Id = int.Parse(dt.Rows[n]["Id"].ToString());
                    }
                    if (dt.Rows[n]["CompanyId"] != null && dt.Rows[n]["CompanyId"].ToString() != "")
                    {
                        model.CompanyId = int.Parse(dt.Rows[n]["CompanyId"].ToString());
                    }
                    if (dt.Rows[n]["UserName"] != null && dt.Rows[n]["UserName"].ToString() != "")
                    {
                        model.UserName = dt.Rows[n]["UserName"].ToString();
                    }
                    if (dt.Rows[n]["PassWord"] != null && dt.Rows[n]["PassWord"].ToString() != "")
                    {
                        model.PassWord = dt.Rows[n]["PassWord"].ToString();
                    }
                    if (dt.Rows[n]["Name"] != null && dt.Rows[n]["Name"].ToString() != "")
                    {
                        model.Name = dt.Rows[n]["Name"].ToString();
                    }
                    if (dt.Rows[n]["Phone"] != null && dt.Rows[n]["Phone"].ToString() != "")
                    {
                        model.Phone = dt.Rows[n]["Phone"].ToString();
                    }
                    if (dt.Rows[n]["Email"] != null && dt.Rows[n]["Email"].ToString() != "")
                    {
                        model.Email = dt.Rows[n]["Email"].ToString();
                    }
                    if (dt.Rows[n]["QQ"] != null && dt.Rows[n]["QQ"].ToString() != "")
                    {
                        model.QQ = dt.Rows[n]["QQ"].ToString();
                    }
                    if (dt.Rows[n]["Avatar"] != null && dt.Rows[n]["Avatar"].ToString() != "")
                    {
                        model.Avatar = dt.Rows[n]["Avatar"].ToString();
                    }
                    if (dt.Rows[n]["state"] != null && dt.Rows[n]["state"].ToString() != "")
                    {
                        model.state = int.Parse(dt.Rows[n]["state"].ToString());
                    }
                    if (dt.Rows[n]["remark"] != null && dt.Rows[n]["remark"].ToString() != "")
                    {
                        model.remark = dt.Rows[n]["remark"].ToString();
                    }
                    if (dt.Rows[n]["createUser"] != null && dt.Rows[n]["createUser"].ToString() != "")
                    {
                        model.createUser = int.Parse(dt.Rows[n]["createUser"].ToString());
                    }
                    if (dt.Rows[n]["createIp"] != null && dt.Rows[n]["createIp"].ToString() != "")
                    {
                        model.createIp = dt.Rows[n]["createIp"].ToString();
                    }
                    if (dt.Rows[n]["createTime"] != null && dt.Rows[n]["createTime"].ToString() != "")
                    {
                        model.createTime = DateTime.Parse(dt.Rows[n]["createTime"].ToString());
                    }
                    if (dt.Rows[n]["updateUser"] != null && dt.Rows[n]["updateUser"].ToString() != "")
                    {
                        model.updateUser = int.Parse(dt.Rows[n]["updateUser"].ToString());
                    }
                    if (dt.Rows[n]["updateIp"] != null && dt.Rows[n]["updateIp"].ToString() != "")
                    {
                        model.updateIp = dt.Rows[n]["updateIp"].ToString();
                    }
                    if (dt.Rows[n]["updateTime"] != null && dt.Rows[n]["updateTime"].ToString() != "")
                    {
                        model.updateTime = DateTime.Parse(dt.Rows[n]["updateTime"].ToString());
                    }
                    modelList.Add(model);
                }
            }
            return modelList;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetAllList()
        {
            return GetList("");
        }

        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            return dal.GetRecordCount(strWhere);
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            return dal.GetListByPage(strWhere, orderby, startIndex, endIndex);
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        //public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        //{
        //return dal.GetList(PageSize,PageIndex,strWhere);
        //}
        #endregion  Method

        #region 自定义方法

        /// <summary>
        /// 是否允许用户登录名密码是否有效
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <param name="passWord">密码</param>
        /// <returns></returns>
        public bool Login(string userName, string passWord)
        {
            List<ATOM.Model.SystemUser> userList = GetModelList("userName='" + userName + "' and passWord='" + passWord + "'");
            if (userList.Count > 0)
            {
                Maticsoft.Common.DataSession.setSession("siteUser", userList[0]);
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 判断是否登录
        /// </summary>
        /// <returns></returns>
        public static bool ifLogin()
        {
            if (getSessionSiteUser() != null)
                return true;
            else
                return false;
        }

        //取得Session中的用户ID
        public static ATOM.Model.SystemUser getSessionSiteUser()
        {
            ATOM.Model.SystemUser obj = new ATOM.Model.SystemUser();
            try
            {
                obj = (ATOM.Model.SystemUser)HttpContext.Current.Session["siteUser"];
            }
            catch
            {

            }
            return obj;
        }

        /// <summary>
        /// 获取用户头像
        /// </summary>
        /// <returns></returns>
        public static string getUserAvatar()
        {
            string avatarString = "";
            string fileUrl = inc.getApplicationPath() + "/Upload/Avatar/" + ATOM.BLL.SystemUser.getSessionSiteUser().Id.ToStr() + "_avatar.txt";
            StreamReader sr;
            if (File.Exists(HttpContext.Current.Server.MapPath(fileUrl)))
            {
                sr = File.OpenText(HttpContext.Current.Server.MapPath(fileUrl));
                avatarString = sr.ReadLine();
                sr.Close();
                sr.Dispose();
            }
            return avatarString;
        }

        #endregion
    }
}