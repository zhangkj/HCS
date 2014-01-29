using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HCS.DALFactory;
using HCS.Models;
using HCS.IDAL;
using System.Data;

namespace HCS.BLL
{
    public static class ExpenseItemManager
    {

        public static AbstractDALFactory facotory = AbstractDALFactory.ChooseFactory();
        public static IExpenseItemService ExpenseItemService = facotory.CreateExpenseItemService();
        public static DataSet GetExpenseItem(ExpenseItem ExpenseItem)
        {
            DataSet ds = new DataSet();
            try
            {
                ds = ExpenseItemService.GetExpenseItem(ExpenseItem);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            return ds;
        }
        //插入
        public static DataSet InsertExpenseItem(ExpenseItem ExpenseItem)
        {
            DataSet ds = new DataSet();
            try
            {
                ds = ExpenseItemService.InsertExpenseItem(ExpenseItem);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            return ds;
        }
        //更新
        public static DataSet UpdateExpenseItem(ExpenseItem ExpenseItem)
        {
            DataSet ds = new DataSet();
            try
            {
                ds = ExpenseItemService.UpdateExpenseItem(ExpenseItem);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            return ds;
        }
        //删除
        public static DataSet DeleteExpenseItem(ExpenseItem ExpenseItem)
        {
            DataSet ds = new DataSet();
            try
            {
                ds = ExpenseItemService.DeleteExpenseItem(ExpenseItem);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            return ds;
        }
    }
}
