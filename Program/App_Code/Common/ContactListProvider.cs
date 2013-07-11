using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ASPNETChatControl.Extensibility;
using ASPNETChat.DataObjects;

namespace Maticsoft.Common
{
    /// <summary>
    ///ContactListProvider 的摘要说明
    /// </summary>
    public class AtomContactListProvider : ContactListProvider
    {

        public override Dictionary<string, string> GetContactsByUserId(string userId)
        {
            //return base.GetContactsByUserId(userId);
            Dictionary<string, string> contactList = new Dictionary<string, string>();
            List<ATOM.Model.SystemUser> listUserObj = new ATOM.BLL.SystemUser().GetModelList("id<>" + userId);
            for (int i = 0; i < listUserObj.Count; i++)
            {
                contactList.Add(listUserObj[i].Id.ToStr(),listUserObj[i].Name.ToStr());
            }
            return contactList;
        }
    }
}
