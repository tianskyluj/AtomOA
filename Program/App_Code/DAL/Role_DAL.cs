using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace ATOM.DAL
{
    /// <summary>
    /// 数据访问类:Role
    /// </summary>
    public partial class Role
    {
        public Role()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int Id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Role");
            strSql.Append(" where Id=@Id");
            SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)
			};
            parameters[0].Value = Id;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(ATOM.Model.Role model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Role(");
            strSql.Append("RoleName,ProvinceId,CityId,AreaId,DepartmentId,ProvinceIds,CityIds,AreaIds,DepartmentIds,DepartmentNames,state,remark,createUser,createIp,createTime,updateUser,updateIp,updateTime)");
            strSql.Append(" values (");
            strSql.Append("@RoleName,@ProvinceId,@CityId,@AreaId,@DepartmentId,@ProvinceIds,@CityIds,@AreaIds,@DepartmentIds,@DepartmentNames,@state,@remark,@createUser,@createIp,@createTime,@updateUser,@updateIp,@updateTime)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@RoleName", SqlDbType.NVarChar,200),
					new SqlParameter("@ProvinceId", SqlDbType.Int,4),
					new SqlParameter("@CityId", SqlDbType.Int,4),
					new SqlParameter("@AreaId", SqlDbType.Int,4),
					new SqlParameter("@DepartmentId", SqlDbType.Int,4),
					new SqlParameter("@ProvinceIds", SqlDbType.NVarChar,200),
					new SqlParameter("@CityIds", SqlDbType.NVarChar,200),
					new SqlParameter("@AreaIds", SqlDbType.NVarChar,200),
					new SqlParameter("@DepartmentIds", SqlDbType.NVarChar,200),
					new SqlParameter("@DepartmentNames", SqlDbType.NVarChar,200),
					new SqlParameter("@state", SqlDbType.Int,4),
					new SqlParameter("@remark", SqlDbType.NVarChar,500),
					new SqlParameter("@createUser", SqlDbType.Int,4),
					new SqlParameter("@createIp", SqlDbType.NVarChar,50),
					new SqlParameter("@createTime", SqlDbType.DateTime),
					new SqlParameter("@updateUser", SqlDbType.Int,4),
					new SqlParameter("@updateIp", SqlDbType.NVarChar,50),
					new SqlParameter("@updateTime", SqlDbType.DateTime)};
            parameters[0].Value = model.RoleName;
            parameters[1].Value = model.ProvinceId;
            parameters[2].Value = model.CityId;
            parameters[3].Value = model.AreaId;
            parameters[4].Value = model.DepartmentId;
            parameters[5].Value = model.ProvinceIds;
            parameters[6].Value = model.CityIds;
            parameters[7].Value = model.AreaIds;
            parameters[8].Value = model.DepartmentIds;
            parameters[9].Value = model.DepartmentNames;
            parameters[10].Value = model.state;
            parameters[11].Value = model.remark;
            parameters[12].Value = model.createUser;
            parameters[13].Value = model.createIp;
            parameters[14].Value = model.createTime;
            parameters[15].Value = model.updateUser;
            parameters[16].Value = model.updateIp;
            parameters[17].Value = model.updateTime;

            object obj = DbHelperSQL.GetSingle(strSql.ToString(), parameters);
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(ATOM.Model.Role model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Role set ");
            strSql.Append("RoleName=@RoleName,");
            strSql.Append("ProvinceId=@ProvinceId,");
            strSql.Append("CityId=@CityId,");
            strSql.Append("AreaId=@AreaId,");
            strSql.Append("DepartmentId=@DepartmentId,");
            strSql.Append("ProvinceIds=@ProvinceIds,");
            strSql.Append("CityIds=@CityIds,");
            strSql.Append("AreaIds=@AreaIds,");
            strSql.Append("DepartmentIds=@DepartmentIds,");
            strSql.Append("DepartmentNames=@DepartmentNames,");
            strSql.Append("state=@state,");
            strSql.Append("remark=@remark,");
            strSql.Append("createUser=@createUser,");
            strSql.Append("createIp=@createIp,");
            strSql.Append("createTime=@createTime,");
            strSql.Append("updateUser=@updateUser,");
            strSql.Append("updateIp=@updateIp,");
            strSql.Append("updateTime=@updateTime");
            strSql.Append(" where Id=@Id");
            SqlParameter[] parameters = {
					new SqlParameter("@RoleName", SqlDbType.NVarChar,200),
					new SqlParameter("@ProvinceId", SqlDbType.Int,4),
					new SqlParameter("@CityId", SqlDbType.Int,4),
					new SqlParameter("@AreaId", SqlDbType.Int,4),
					new SqlParameter("@DepartmentId", SqlDbType.Int,4),
					new SqlParameter("@ProvinceIds", SqlDbType.NVarChar,200),
					new SqlParameter("@CityIds", SqlDbType.NVarChar,200),
					new SqlParameter("@AreaIds", SqlDbType.NVarChar,200),
					new SqlParameter("@DepartmentIds", SqlDbType.NVarChar,200),
					new SqlParameter("@DepartmentNames", SqlDbType.NVarChar,200),
					new SqlParameter("@state", SqlDbType.Int,4),
					new SqlParameter("@remark", SqlDbType.NVarChar,500),
					new SqlParameter("@createUser", SqlDbType.Int,4),
					new SqlParameter("@createIp", SqlDbType.NVarChar,50),
					new SqlParameter("@createTime", SqlDbType.DateTime),
					new SqlParameter("@updateUser", SqlDbType.Int,4),
					new SqlParameter("@updateIp", SqlDbType.NVarChar,50),
					new SqlParameter("@updateTime", SqlDbType.DateTime),
					new SqlParameter("@Id", SqlDbType.Int,4)};
            parameters[0].Value = model.RoleName;
            parameters[1].Value = model.ProvinceId;
            parameters[2].Value = model.CityId;
            parameters[3].Value = model.AreaId;
            parameters[4].Value = model.DepartmentId;
            parameters[5].Value = model.ProvinceIds;
            parameters[6].Value = model.CityIds;
            parameters[7].Value = model.AreaIds;
            parameters[8].Value = model.DepartmentIds;
            parameters[9].Value = model.DepartmentNames;
            parameters[10].Value = model.state;
            parameters[11].Value = model.remark;
            parameters[12].Value = model.createUser;
            parameters[13].Value = model.createIp;
            parameters[14].Value = model.createTime;
            parameters[15].Value = model.updateUser;
            parameters[16].Value = model.updateIp;
            parameters[17].Value = model.updateTime;
            parameters[18].Value = model.Id;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int Id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Role ");
            strSql.Append(" where Id=@Id");
            SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)
			};
            parameters[0].Value = Id;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string Idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Role ");
            strSql.Append(" where Id in (" + Idlist + ")  ");
            int rows = DbHelperSQL.ExecuteSql(strSql.ToString());
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public ATOM.Model.Role GetModel(int Id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 Id,RoleName,ProvinceId,CityId,AreaId,DepartmentId,ProvinceIds,CityIds,AreaIds,DepartmentIds,DepartmentNames,state,remark,createUser,createIp,createTime,updateUser,updateIp,updateTime from Role ");
            strSql.Append(" where Id=@Id");
            SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)
			};
            parameters[0].Value = Id;

            ATOM.Model.Role model = new ATOM.Model.Role();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public ATOM.Model.Role DataRowToModel(DataRow row)
        {
            ATOM.Model.Role model = new ATOM.Model.Role();
            if (row != null)
            {
                if (row["Id"] != null && row["Id"].ToString() != "")
                {
                    model.Id = int.Parse(row["Id"].ToString());
                }
                if (row["RoleName"] != null)
                {
                    model.RoleName = row["RoleName"].ToString();
                }
                if (row["ProvinceId"] != null && row["ProvinceId"].ToString() != "")
                {
                    model.ProvinceId = int.Parse(row["ProvinceId"].ToString());
                }
                if (row["CityId"] != null && row["CityId"].ToString() != "")
                {
                    model.CityId = int.Parse(row["CityId"].ToString());
                }
                if (row["AreaId"] != null && row["AreaId"].ToString() != "")
                {
                    model.AreaId = int.Parse(row["AreaId"].ToString());
                }
                if (row["DepartmentId"] != null && row["DepartmentId"].ToString() != "")
                {
                    model.DepartmentId = int.Parse(row["DepartmentId"].ToString());
                }
                if (row["ProvinceIds"] != null)
                {
                    model.ProvinceIds = row["ProvinceIds"].ToString();
                }
                if (row["CityIds"] != null)
                {
                    model.CityIds = row["CityIds"].ToString();
                }
                if (row["AreaIds"] != null)
                {
                    model.AreaIds = row["AreaIds"].ToString();
                }
                if (row["DepartmentIds"] != null)
                {
                    model.DepartmentIds = row["DepartmentIds"].ToString();
                }
                if (row["DepartmentNames"] != null)
                {
                    model.DepartmentNames = row["DepartmentNames"].ToString();
                }
                if (row["state"] != null && row["state"].ToString() != "")
                {
                    model.state = int.Parse(row["state"].ToString());
                }
                if (row["remark"] != null)
                {
                    model.remark = row["remark"].ToString();
                }
                if (row["createUser"] != null && row["createUser"].ToString() != "")
                {
                    model.createUser = int.Parse(row["createUser"].ToString());
                }
                if (row["createIp"] != null)
                {
                    model.createIp = row["createIp"].ToString();
                }
                if (row["createTime"] != null && row["createTime"].ToString() != "")
                {
                    model.createTime = DateTime.Parse(row["createTime"].ToString());
                }
                if (row["updateUser"] != null && row["updateUser"].ToString() != "")
                {
                    model.updateUser = int.Parse(row["updateUser"].ToString());
                }
                if (row["updateIp"] != null)
                {
                    model.updateIp = row["updateIp"].ToString();
                }
                if (row["updateTime"] != null && row["updateTime"].ToString() != "")
                {
                    model.updateTime = DateTime.Parse(row["updateTime"].ToString());
                }
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Id,RoleName,ProvinceId,CityId,AreaId,DepartmentId,ProvinceIds,CityIds,AreaIds,DepartmentIds,DepartmentNames,state,remark,createUser,createIp,createTime,updateUser,updateIp,updateTime ");
            strSql.Append(" FROM Role ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" Id,RoleName,ProvinceId,CityId,AreaId,DepartmentId,ProvinceIds,CityIds,AreaIds,DepartmentIds,DepartmentNames,state,remark,createUser,createIp,createTime,updateUser,updateIp,updateTime ");
            strSql.Append(" FROM Role ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM Role ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            object obj = DbHelperSQL.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by T." + orderby);
            }
            else
            {
                strSql.Append("order by T.Id desc");
            }
            strSql.Append(")AS Row, T.*  from Role T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /*
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        {
            SqlParameter[] parameters = {
                    new SqlParameter("@tblName", SqlDbType.VarChar, 255),
                    new SqlParameter("@fldName", SqlDbType.VarChar, 255),
                    new SqlParameter("@PageSize", SqlDbType.Int),
                    new SqlParameter("@PageIndex", SqlDbType.Int),
                    new SqlParameter("@IsReCount", SqlDbType.Bit),
                    new SqlParameter("@OrderType", SqlDbType.Bit),
                    new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
                    };
            parameters[0].Value = "Role";
            parameters[1].Value = "Id";
            parameters[2].Value = PageSize;
            parameters[3].Value = PageIndex;
            parameters[4].Value = 0;
            parameters[5].Value = 0;
            parameters[6].Value = strWhere;	
            return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
        }*/

        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}

