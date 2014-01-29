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
    public static class SBaseInfoManager
    {

        public static AbstractDALFactory facotory = AbstractDALFactory.ChooseFactory();
        public static ISBaseInfoService SbaseInfoService = facotory.CreateSBaseInfoService();
        public static DataSet GetSBaseInfo(SBaseInfo SBaseInfo)
        {
            DataSet ds = new DataSet();
            try
            {
                ds = SbaseInfoService.GetSBaseInfo(SBaseInfo);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            return ds;
        }
        //插入一条病人信息
        public static DataSet InsertSBaseInfo(SBaseInfo SBaseInfo)
        {
            DataSet ds = new DataSet();
            try
            {
                ds = SbaseInfoService.InsertSBaseInfo(SBaseInfo);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            return ds;
        }
        //更新一条病人信息
        public static DataSet UpdatePatient(SBaseInfo SBaseInfo)
        {
            DataSet ds = new DataSet();
            try
            {
                ds = SbaseInfoService.UpdateSBaseInfo(SBaseInfo);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            return ds;
        }
        //删除一条病人信息
        public static DataSet DeleteSBaseInfo(SBaseInfo SBaseInfo)
        {
            DataSet ds = new DataSet();
            try
            {
                ds = SbaseInfoService.DeleteSBaseInfo(SBaseInfo);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            return ds;
        }
    }
}
