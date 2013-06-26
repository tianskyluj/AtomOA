using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Maticsoft.Common
{
    /// <summary>
    ///DataSession 的摘要说明
    /// </summary>
    public class DataSession
    {
        public DataSession()
        {
            //
            //TODO: 在此处添加构造函数逻辑
            //
        }
       

        // 销毁session 数据
        public static void destroySession()
        {
            HttpContext.Current.Session.Clear();
        }
        
        //取得Session中的变量值
        public static string getSessionValue(string Sessinname)
        {
            string _str = "";
            try
            {
                _str = HttpContext.Current.Session[Sessinname].ToString();
            }
            catch
            {

            }
            return _str;
        }

        //设置Session变量及值
        public static void setSession(string Sessionname, object Sessionvalue)
        {
            HttpContext.Current.Session[Sessionname] = Sessionvalue;
        }

        
    }
}