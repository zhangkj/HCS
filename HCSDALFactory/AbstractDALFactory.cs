using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HCS.IDAL;
using System.Configuration;

namespace HCS.DALFactory
{
    public abstract class AbstractDALFactory
    {
        public  static AbstractDALFactory ChooseFactory()
        {
            string dbType = ConfigurationManager.AppSettings["DBType"].ToString();
            AbstractDALFactory factory = null;
            switch (dbType)
            {
                case "Sql":
                    factory = new SqlDALFactory();
                    break;
                case "Access":
                    factory = new AccessDALFactory();
                    break;
            }
            return factory;
        }

        public abstract IPatientService CreatePatientService();
        public abstract ISBaseInfoService CreateSBaseInfoService();
        public abstract IHBaseInfoService CreateHBaseInfoService();
        public abstract IExpenseItemService CreateExpenseItemService();
        public abstract IExpenseHeaderService CreateExpenseHeaderService();
        public abstract IExpenseLineService CreateExpenseLineService();
        public abstract IRptService CreateRptService();
        public abstract IUserInfoService CreateUserInfoService();
    }
}
