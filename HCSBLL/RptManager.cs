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
    public static class RptManager
    {

        public static AbstractDALFactory facotory = AbstractDALFactory.ChooseFactory();
        public static IRptService RptService = facotory.CreateRptService();
        public static DataSet GetRpt(string strProcedure,string[] strArray)
        {
            DataSet ds = new DataSet();
            try
            {
                ds = RptService.GetRpt(strProcedure, strArray);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            return ds;
        }
        
    }
}
