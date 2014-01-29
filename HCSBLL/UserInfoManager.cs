using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HCS.DALFactory;
using HCS.Models;
using HCS.IDAL;
using System.Data;
using HCS.DALFactory;

namespace HCS.BLL
{
    public static class UserInfoManager
    {

        public static AbstractDALFactory facotory = AbstractDALFactory.ChooseFactory();
        public static IUserInfoService UserInfoService = facotory.CreateUserInfoService();
        public static DataSet GetUserInfo(UserInfo UserInfo )
        {
            DataSet ds = new DataSet();
            try
            {
                ds = UserInfoService.GetUserInfo(UserInfo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            return ds;
        }
        
    }
}
