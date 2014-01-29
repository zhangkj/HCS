using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HCS.IDAL;
using HCS.DAL.SqlServce;
using HCS.DALFactory;
/*********************************
 * 类名： SqlDALFactory
 * 创建日期：2012-12-09
 * 功能描述：提供创建sql工厂对象
 * *******************************/
namespace HCS.DALFactory
{
     public class SqlDALFactory:AbstractDALFactory
    {

        public override IPatientService CreatePatientService()
        {
            return new PatientService();
        }
        public override ISBaseInfoService CreateSBaseInfoService()
        {
            return new SBaseInfoService();
        }
        public override IExpenseItemService CreateExpenseItemService()
        {
            return new ExpenseItemService();
        }

        public override IExpenseHeaderService CreateExpenseHeaderService()
        {
            return new ExpenseHeaderService();
        }

        public override IExpenseLineService CreateExpenseLineService()
        {
            return new ExpenseLineService();
        }

        public override IHBaseInfoService CreateHBaseInfoService()
        {
            return new HBaseInfoService();
        }

        public override IRptService CreateRptService()
        {
            return new RptService();
        }

        public override IUserInfoService CreateUserInfoService()
        {
            return new UserInfoService();
        }
    }
}
