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
    public static class HBaseInfoManager
    {

        public static AbstractDALFactory facotory = AbstractDALFactory.ChooseFactory();
        public static IHBaseInfoService HbaseInfoService = facotory.CreateHBaseInfoService();
        public static DataSet GetHBaseInfo(HBaseInfo HBaseInfo)
        {
            DataSet ds = new DataSet();
            try
            {
                ds = HbaseInfoService.GetHBaseInfo(HBaseInfo);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            return ds;
        }
        //插入一条病人信息
        public static DataSet InsertHBaseInfo(HBaseInfo HBaseInfo)
        {
            DataSet ds = new DataSet();
            try
            {
                ds = HbaseInfoService.InsertHBaseInfo(HBaseInfo);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            return ds;
        }
        //更新一条病人信息
        public static DataSet UpdateHBaseInfo(HBaseInfo HBaseInfo)
        {
            DataSet ds = new DataSet();
            try
            {
                ds = HbaseInfoService.UpdateHBaseInfo(HBaseInfo);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            return ds;
        }
        //删除一条病人信息
        public static DataSet DeleteHBaseInfo(HBaseInfo HBaseInfo)
        {
            DataSet ds = new DataSet();
            try
            {
                ds = HbaseInfoService.DeleteHBaseInfo(HBaseInfo);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            return ds;
        }
    }
}
