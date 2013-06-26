using System;
namespace ATOM.Model
{
    /// <summary>
    /// GlobalSetting:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class GlobalSetting
    {
        public GlobalSetting()
        { }
        #region Model
        private int _id;
        private string _companyname;
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
        public string CompanyName
        {
            set { _companyname = value; }
            get { return _companyname; }
        }
        #endregion Model

    }
}