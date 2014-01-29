using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HCS.DALFactory;

namespace HCS.DALFactory
{
    class AccessDALFactory:AbstractDALFactory
    {

        public override HCS.IDAL.IPatientService CreatePatientService()
        {
            throw new NotImplementedException();
        }

        public override HCS.IDAL.ISBaseInfoService CreateSBaseInfoService()
        {
            throw new NotImplementedException();
        }


        public override HCS.IDAL.IExpenseItemService CreateExpenseItemService()
        {
            throw new NotImplementedException();
        }

        public override HCS.IDAL.IExpenseHeaderService CreateExpenseHeaderService()
        {
            throw new NotImplementedException();
        }

        public override HCS.IDAL.IExpenseLineService CreateExpenseLineService()
        {
            throw new NotImplementedException();
        }

        public override HCS.IDAL.IHBaseInfoService CreateHBaseInfoService()
        {
            throw new NotImplementedException();
        }

        public override HCS.IDAL.IRptService CreateRptService()
        {
            throw new NotImplementedException();
        }

        public override HCS.IDAL.IUserInfoService CreateUserInfoService()
        {
            throw new NotImplementedException();
        }
    }
}
