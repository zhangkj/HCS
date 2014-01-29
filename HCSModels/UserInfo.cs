using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*********************************
 * 类名： Patient
 * 创建日期：2012-12-09
 * 功能描述：基本信息实体类
 * *******************************/
namespace HCS.Models
{
    [Serializable]
    public class UserInfo
    {

        protected string userId;
        protected string username;
        protected string userpassword;

        public string UserId
        {
            get { return userId; }
            set { userId = value; }
        }
        public string UserName
        {
            get { return  username; }
            set { username = value; }
        }

        public string UserPassword
        {
            get { return userpassword; }
            set { userpassword = value; }
        }

    }
}
