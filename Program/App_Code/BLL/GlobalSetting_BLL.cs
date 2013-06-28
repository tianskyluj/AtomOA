using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using ATOM.Model;
namespace ATOM.BLL
{
    /// <summary>
    /// GlobalSetting
    /// </summary>
    public partial class GlobalSetting
    {
        private readonly ATOM.DAL.GlobalSetting dal = new ATOM.DAL.GlobalSetting();
        public GlobalSetting()
        { }
        #region  Method

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(ATOM.Model.GlobalSetting model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(ATOM.Model.GlobalSetting model)
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
        public ATOM.Model.GlobalSetting GetModel(int Id)
        {

            return dal.GetModel(Id);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public ATOM.Model.GlobalSetting GetModelByCache(int Id)
        {

            string CacheKey = "GlobalSettingModel-" + Id;
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
            return (ATOM.Model.GlobalSetting)objModel;
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
        public List<ATOM.Model.GlobalSetting> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<ATOM.Model.GlobalSetting> DataTableToList(DataTable dt)
        {
            List<ATOM.Model.SystemUser> modelList = new List<ATOM.Model.SystemUser>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                ATOM.Model.SystemUser model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = dal.DataRowToModel(dt.Rows[n]);
                    if (model != null)
                    {
                        modelList.Add(model);
                    }
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

        /// <summary>
        /// 更新或者添加数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool AddUpdate(ATOM.Model.GlobalSetting model)
        {
            if (model.Id == 0)
            {
                if (this.Add(model) > 0)
                    return true;
                else
                    return false;
            }
            else
            {
                return this.Update(model);
            }
        }

        #endregion  Method

        #region 自定义方法

        /// <summary>
        /// 从缓存中获取公司名称
        /// </summary>
        /// <returns></returns>
        public static string GetCompanyName()
        {
            ATOM.BLL.GlobalSetting globalObj_bll = new ATOM.BLL.GlobalSetting();
            ATOM.Model.GlobalSetting globalObj_model = globalObj_bll.GetModelByCache(1);
            return globalObj_model.CompanyName.ToStr();
        }

        #endregion
    }
}

