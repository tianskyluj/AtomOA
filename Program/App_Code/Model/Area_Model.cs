﻿using System;
namespace ATOM.Model
{
    /// <summary>
    /// Area:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class Area
    {
        public Area()
        { }
        #region Model
        private int _id;
        private int? _provinceid = 0;
        private int? _cityid = 0;
        private string _areaname = "";
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
        public string AreaName
        {
            set { _areaname = value; }
            get { return _areaname; }
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

