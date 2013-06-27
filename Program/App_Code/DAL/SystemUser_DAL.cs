using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace ATOM.DAL
{
    /// <summary>
    /// 数据访问类:SystemUser
    /// </summary>
    public partial class SystemUser
    {
        public SystemUser()
        { }
        #region  Method
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int Id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from SystemUser");
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
        public int Add(ATOM.Model.SystemUser model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into SystemUser(");
            strSql.Append("CompanyId,UserName,PassWord,Name,Phone,Email,QQ,Avatar,state,remark,createUser,createIp,createTime,updateUser,updateIp,updateTime)");
            strSql.Append(" values (");
            strSql.Append("@CompanyId,@UserName,@PassWord,@Name,@Phone,@Email,@QQ,@Avatar,@state,@remark,@createUser,@createIp,@createTime,@updateUser,@updateIp,@updateTime)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@CompanyId", SqlDbType.Int,4),
					new SqlParameter("@UserName", SqlDbType.NVarChar,200),
					new SqlParameter("@PassWord", SqlDbType.NVarChar,200),
					new SqlParameter("@Name", SqlDbType.NVarChar,200),
					new SqlParameter("@Phone", SqlDbType.NVarChar,200),
					new SqlParameter("@Email", SqlDbType.NVarChar,200),
					new SqlParameter("@QQ", SqlDbType.NVarChar,200),
					new SqlParameter("@Avatar", SqlDbType.NVarChar,200),
					new SqlParameter("@state", SqlDbType.Int,4),
					new SqlParameter("@remark", SqlDbType.NVarChar,500),
					new SqlParameter("@createUser", SqlDbType.Int,4),
					new SqlParameter("@createIp", SqlDbType.NVarChar,50),
					new SqlParameter("@createTime", SqlDbType.DateTime),
					new SqlParameter("@updateUser", SqlDbType.Int,4),
					new SqlParameter("@updateIp", SqlDbType.NVarChar,50),
					new SqlParameter("@updateTime", SqlDbType.DateTime)};
            parameters[0].Value = model.CompanyId;
            parameters[1].Value = model.UserName;
            parameters[2].Value = model.PassWord;
            parameters[3].Value = model.Name;
            parameters[4].Value = model.Phone;
            parameters[5].Value = model.Email;
            parameters[6].Value = model.QQ;
            parameters[7].Value = model.Avatar;
            parameters[8].Value = model.state;
            parameters[9].Value = model.remark;
            parameters[10].Value = model.createUser;
            parameters[11].Value = model.createIp;
            parameters[12].Value = model.createTime;
            parameters[13].Value = model.updateUser;
            parameters[14].Value = model.updateIp;
            parameters[15].Value = model.updateTime;

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
        public bool Update(ATOM.Model.SystemUser model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update SystemUser set ");
            strSql.Append("CompanyId=@CompanyId,");
            strSql.Append("UserName=@UserName,");
            strSql.Append("PassWord=@PassWord,");
            strSql.Append("Name=@Name,");
            strSql.Append("Phone=@Phone,");
            strSql.Append("Email=@Email,");
            strSql.Append("QQ=@QQ,");
            strSql.Append("Avatar=@Avatar,");
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
					new SqlParameter("@CompanyId", SqlDbType.Int,4),
					new SqlParameter("@UserName", SqlDbType.NVarChar,200),
					new SqlParameter("@PassWord", SqlDbType.NVarChar,200),
					new SqlParameter("@Name", SqlDbType.NVarChar,200),
					new SqlParameter("@Phone", SqlDbType.NVarChar,200),
					new SqlParameter("@Email", SqlDbType.NVarChar,200),
					new SqlParameter("@QQ", SqlDbType.NVarChar,200),
					new SqlParameter("@Avatar", SqlDbType.NVarChar,200),
					new SqlParameter("@state", SqlDbType.Int,4),
					new SqlParameter("@remark", SqlDbType.NVarChar,500),
					new SqlParameter("@createUser", SqlDbType.Int,4),
					new SqlParameter("@createIp", SqlDbType.NVarChar,50),
					new SqlParameter("@createTime", SqlDbType.DateTime),
					new SqlParameter("@updateUser", SqlDbType.Int,4),
					new SqlParameter("@updateIp", SqlDbType.NVarChar,50),
					new SqlParameter("@updateTime", SqlDbType.DateTime),
					new SqlParameter("@Id", SqlDbType.Int,4)};
            parameters[0].Value = model.CompanyId;
            parameters[1].Value = model.UserName;
            parameters[2].Value = model.PassWord;
            parameters[3].Value = model.Name;
            parameters[4].Value = model.Phone;
            parameters[5].Value = model.Email;
            parameters[6].Value = model.QQ;
            parameters[7].Value = model.Avatar;
            parameters[8].Value = model.state;
            parameters[9].Value = model.remark;
            parameters[10].Value = model.createUser;
            parameters[11].Value = model.createIp;
            parameters[12].Value = model.createTime;
            parameters[13].Value = model.updateUser;
            parameters[14].Value = model.updateIp;
            parameters[15].Value = model.updateTime;
            parameters[16].Value = model.Id;

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
            strSql.Append("delete from SystemUser ");
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
            strSql.Append("delete from SystemUser ");
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
        public ATOM.Model.SystemUser GetModel(int Id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 Id,CompanyId,UserName,PassWord,Name,Phone,Email,QQ,Avatar,state,remark,createUser,createIp,createTime,updateUser,updateIp,updateTime from SystemUser ");
            strSql.Append(" where Id=@Id");
            SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)
			};
            parameters[0].Value = Id;

            ATOM.Model.SystemUser model = new ATOM.Model.SystemUser();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["Id"] != null && ds.Tables[0].Rows[0]["Id"].ToString() != "")
                {
                    model.Id = int.Parse(ds.Tables[0].Rows[0]["Id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["CompanyId"] != null && ds.Tables[0].Rows[0]["CompanyId"].ToString() != "")
                {
                    model.CompanyId = int.Parse(ds.Tables[0].Rows[0]["CompanyId"].ToString());
                }
                if (ds.Tables[0].Rows[0]["UserName"] != null && ds.Tables[0].Rows[0]["UserName"].ToString() != "")
                {
                    model.UserName = ds.Tables[0].Rows[0]["UserName"].ToString();
                }
                if (ds.Tables[0].Rows[0]["PassWord"] != null && ds.Tables[0].Rows[0]["PassWord"].ToString() != "")
                {
                    model.PassWord = ds.Tables[0].Rows[0]["PassWord"].ToString();
                }
                if (ds.Tables[0].Rows[0]["Name"] != null && ds.Tables[0].Rows[0]["Name"].ToString() != "")
                {
                    model.Name = ds.Tables[0].Rows[0]["Name"].ToString();
                }
                if (ds.Tables[0].Rows[0]["Phone"] != null && ds.Tables[0].Rows[0]["Phone"].ToString() != "")
                {
                    model.Phone = ds.Tables[0].Rows[0]["Phone"].ToString();
                }
                if (ds.Tables[0].Rows[0]["Email"] != null && ds.Tables[0].Rows[0]["Email"].ToString() != "")
                {
                    model.Email = ds.Tables[0].Rows[0]["Email"].ToString();
                }
                if (ds.Tables[0].Rows[0]["QQ"] != null && ds.Tables[0].Rows[0]["QQ"].ToString() != "")
                {
                    model.QQ = ds.Tables[0].Rows[0]["QQ"].ToString();
                }
                if (ds.Tables[0].Rows[0]["Avatar"] != null && ds.Tables[0].Rows[0]["Avatar"].ToString() != "")
                {
                    model.Avatar = ds.Tables[0].Rows[0]["Avatar"].ToString();
                }
                if (ds.Tables[0].Rows[0]["state"] != null && ds.Tables[0].Rows[0]["state"].ToString() != "")
                {
                    model.state = int.Parse(ds.Tables[0].Rows[0]["state"].ToString());
                }
                if (ds.Tables[0].Rows[0]["remark"] != null && ds.Tables[0].Rows[0]["remark"].ToString() != "")
                {
                    model.remark = ds.Tables[0].Rows[0]["remark"].ToString();
                }
                if (ds.Tables[0].Rows[0]["createUser"] != null && ds.Tables[0].Rows[0]["createUser"].ToString() != "")
                {
                    model.createUser = int.Parse(ds.Tables[0].Rows[0]["createUser"].ToString());
                }
                if (ds.Tables[0].Rows[0]["createIp"] != null && ds.Tables[0].Rows[0]["createIp"].ToString() != "")
                {
                    model.createIp = ds.Tables[0].Rows[0]["createIp"].ToString();
                }
                if (ds.Tables[0].Rows[0]["createTime"] != null && ds.Tables[0].Rows[0]["createTime"].ToString() != "")
                {
                    model.createTime = DateTime.Parse(ds.Tables[0].Rows[0]["createTime"].ToString());
                }
                if (ds.Tables[0].Rows[0]["updateUser"] != null && ds.Tables[0].Rows[0]["updateUser"].ToString() != "")
                {
                    model.updateUser = int.Parse(ds.Tables[0].Rows[0]["updateUser"].ToString());
                }
                if (ds.Tables[0].Rows[0]["updateIp"] != null && ds.Tables[0].Rows[0]["updateIp"].ToString() != "")
                {
                    model.updateIp = ds.Tables[0].Rows[0]["updateIp"].ToString();
                }
                if (ds.Tables[0].Rows[0]["updateTime"] != null && ds.Tables[0].Rows[0]["updateTime"].ToString() != "")
                {
                    model.updateTime = DateTime.Parse(ds.Tables[0].Rows[0]["updateTime"].ToString());
                }
                return model;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Id,CompanyId,UserName,PassWord,Name,Phone,Email,QQ,Avatar,state,remark,createUser,createIp,createTime,updateUser,updateIp,updateTime ");
            strSql.Append(" FROM SystemUser ");
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
            strSql.Append(" Id,CompanyId,UserName,PassWord,Name,Phone,Email,QQ,Avatar,state,remark,createUser,createIp,createTime,updateUser,updateIp,updateTime ");
            strSql.Append(" FROM SystemUser ");
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
            strSql.Append("select count(1) FROM SystemUser ");
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
            strSql.Append(")AS Row, T.*  from SystemUser T ");
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
            parameters[0].Value = "SystemUser";
            parameters[1].Value = "Id";
            parameters[2].Value = PageSize;
            parameters[3].Value = PageIndex;
            parameters[4].Value = 0;
            parameters[5].Value = 0;
            parameters[6].Value = strWhere;	
            return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
        }*/

        #endregion  Method
    }
}

