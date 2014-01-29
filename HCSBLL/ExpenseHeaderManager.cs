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
    public static class ExpenseHeaderManager
    {

        public static AbstractDALFactory facotory = AbstractDALFactory.ChooseFactory();
        public static IExpenseHeaderService ExpenseHeaderService = facotory.CreateExpenseHeaderService();
        public static IExpenseLineService ExpenseLineService = facotory.CreateExpenseLineService();

         //获取费用单据列表
        public static DataSet GetExpenseHeader(ExpenseHeader ExpenseHeader)
        {
            DataSet ds = new DataSet();
            try
            {
                ds = ExpenseHeaderService.GetExpenseHeader(ExpenseHeader);
                //ds.Tables[1] = ExpenseLineService.GetExpenseLine(ExpenseLine);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            return ds;
        }
        //结账出院
        public static DataSet PayAllExpense(Patient patient)
        {
            DataSet ds = new DataSet();
            try
            {
                ds = ExpenseHeaderService.PayAllExpense(patient);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            return ds;
        }
        //获取主费用单据列表和明细费用
        public static DataSet GetExpenseHeaderEdit(ExpenseHeader ExpenseHeader)
        {
            DataSet ds = new DataSet();
            try
            {
                ds = ExpenseHeaderService.GetExpenseHeaderEdit(ExpenseHeader);
                //ds.Tables[1] = ExpenseLineService.GetExpenseLine(ExpenseLine);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            return ds;
        }
        //保存费用单据
        public static string  SaveExpenseHeader(ExpenseHeader ExpenseHeader, DataTable dtLine,string strChangedType)
        {
            DataSet ds = new DataSet();
            ExpenseLine expenseline;
            try
            {
                string strBillNo;
                ds=  ExpenseHeaderService.SaveExpenseHeader(ExpenseHeader,strChangedType);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    strBillNo = ds.Tables[0].Rows[0]["BillNo"].ToString();
                }
                else
                {
                    return "保存失败";
                }
                DataRow dr;
                for (int i = 0; i < dtLine.Rows.Count;i++ )
                {
                    dr = dtLine.Rows[i];
                    expenseline = new ExpenseLine();
                    expenseline.BillNo = strBillNo;
                    expenseline.ItemNo = dr["ItemNo"].ToString();
                    expenseline.Amount = Convert.ToInt32(dr["Amount"]);
                    expenseline.IsDelete = Convert.ToInt32(dr["IsDelete"]);

                    ExpenseLineService.SaveExpenseLine(expenseline);
                }
                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            return "保存成功";
        }
        //删除一条主费用数据，及所有明细费用数据
        public static DataSet SaveExpenseHeader(ExpenseHeader ExpenseHeader,string strChangeType)
        {
            DataSet ds = new DataSet();
            try
            {
                ds = ExpenseHeaderService.SaveExpenseHeader(ExpenseHeader, strChangeType);
                ExpenseLine el = new ExpenseLine ();
                el.BillNo = ExpenseHeader.BillNo;
                el.ItemNo ="";
                ExpenseLineService.DeleteExpenseLine(el);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            return ds;
        }
        
    }
}
