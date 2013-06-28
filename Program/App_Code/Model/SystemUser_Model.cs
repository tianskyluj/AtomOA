using System;
namespace ATOM.Model
{
    /// <summary>
    /// SystemUser:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class SystemUser
    {
        public SystemUser()
        { }
        #region Model
        private int _id;
        private int? _companyid = 0;
        private string _username = "";
        private string _password = "";
        private string _name = "";
        private string _phone = "";
        private string _email = "";
        private string _qq = "";
        private string _avatar = "";
        private int? _ifadmin = 0;
        private int? _provinceid = 0;
        private int? _cityid = 0;
        private int? _areaid = 0;
        private int? _departmentid = 0;
        private int? _state = 0;
        private string _remark = "";
        private int? _createuser = 0;
        private string _createip = "";
        private DateTime? _createtime = DateTime.Now;
        private int? _updateuser = 0;
        private string _updateip = "";
        private DateTime? _updatetime = DateTime.Now;
        /// <summary>
        /// 
        /// </summary>
        public int Id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? CompanyId
        {
            set { _companyid = value; }
            get { return _companyid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string UserName
        {
            set { _username = value; }
            get { return _username; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PassWord
        {
            set { _password = value; }
            get { return _password; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Name
        {
            set { _name = value; }
            get { return _name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Phone
        {
            set { _phone = value; }
            get { return _phone; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Email
        {
            set { _email = value; }
            get { return _email; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string QQ
        {
            set { _qq = value; }
            get { return _qq; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Avatar
        {
            set { _avatar = value; }
            get { return _avatar; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? IfAdmin
        {
            set { _ifadmin = value; }
            get { return _ifadmin; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? ProvinceId
        {
            set { _provinceid = value; }
            get { return _provinceid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? CityId
        {
            set { _cityid = value; }
            get { return _cityid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? AreaId
        {
            set { _areaid = value; }
            get { return _areaid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? DepartmentId
        {
            set { _departmentid = value; }
            get { return _departmentid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? state
        {
            set { _state = value; }
            get { return _state; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string remark
        {
            set { _remark = value; }
            get { return _remark; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? createUser
        {
            set { _createuser = value; }
            get { return _createuser; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string createIp
        {
            set { _createip = value; }
            get { return _createip; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? createTime
        {
            set { _createtime = value; }
            get { return _createtime; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? updateUser
        {
            set { _updateuser = value; }
            get { return _updateuser; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string updateIp
        {
            set { _updateip = value; }
            get { return _updateip; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? updateTime
        {
            set { _updatetime = value; }
            get { return _updatetime; }
        }
        #endregion Model

    }
}

