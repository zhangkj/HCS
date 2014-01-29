using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HCS.Models;
using HCS.IDAL;
using HCS.DAL;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
namespace HCS.DAL.SqlServce
{
    public class ExpenseLineService:IExpenseLineService
    {
        string st;
        #region Private Members
        //从配置文件中读取数据库连接字符串
        public readonly string connString = ConfigurationManager.ConnectionStrings["HCSConnectionString"].ToString();
        private readonly string dboOwner = ConfigurationManager.ConnectionStrings["DataBaseOwner"].ToString();
        #endregion
      
        /// <summary>
        /// 执行存储过程
        /// </summary>
        /// <param name="storedProcName">存储过程名</param>
        /// <param name="parameters">存储过程参数</param>
        /// <param name="tableName">DataSet结果中的表名</param>
        /// <returns>DataSet</returns>
        public DataSet RunProcedure(string storedProcName, IDataParameter[] parameters, string tableName)
        {
            using (SqlConnection connection = new SqlConnection(connString))
            {
                DataSet dataSet = new DataSet();
                connection.Open();
                SqlDataAdapter sqlDA = new SqlDataAdapter();
                sqlDA.SelectCommand = BuildQueryCommand(connection, storedProcName, parameters);
                sqlDA.Fill(dataSet, tableName);
                connection.Close();
                return dataSet;
            }
        }

        /// <summary>
        /// 构建 SqlCommand 对象(用来返回一个结果集，而不是一个整数值)
        /// </summary>
        /// <param name="connection">数据库连接</param>
        /// <param name="storedProcName">存储过程名</param>
        /// <param name="parameters">存储过程参数</param>
        /// <returns>SqlCommand</returns>
        private static SqlCommand BuildQueryCommand(SqlConnection connection, string storedProcName, IDataParameter[] parameters)
        {
            SqlCommand command = new SqlCommand(storedProcName, connection);
            command.CommandType = CommandType.StoredProcedure;
            foreach (SqlParameter parameter in parameters)
            {
                if (parameter != null)
                {
                    // 检查未分配值的输出参数,将其分配以DBNull.Value.
                    if ((parameter.Direction == ParameterDirection.InputOutput || parameter.Direction == ParameterDirection.Input) &&
                        (parameter.Value == null))
                    {
                        parameter.Value = DBNull.Value;
                    }
                    command.Parameters.Add(parameter);
                }
            }

            return command;
        }

        

        #region IExpenseItemService 成员

        public DataSet GetExpenseItem(ExpenseItem ExpenseItem)
        {
            DataSet ds = new DataSet();
            SqlParameter[] asqlpara = new SqlParameter[] {
                        new SqlParameter("@vchrSpellCode", System.Data.SqlDbType.VarChar)
            };
            if (ExpenseItem.SpellCode == null || ExpenseItem.SpellCode == "")
            {
                ExpenseItem.SpellCode = "";
            }
            asqlpara[0].Value = ExpenseItem.SpellCode;
            ds = RunProcedure("HCS_GetExpenseItems", asqlpara, "ExpenseItems");
            return ds;
        }

        public DataSet InsertExpenseItem(ExpenseItem ExpenseItem)
        {
            SqlParameter[] asqlpara = new SqlParameter[] {
                        new SqlParameter("@vchrItemNo", System.Data.SqlDbType.Int),
                        new SqlParameter("@vchrItemName", System.Data.SqlDbType.VarChar),
                        new SqlParameter("@intSectionId", System.Data.SqlDbType.Int),
                        new SqlParameter("@intItemStandardId", System.Data.SqlDbType.Int),
                        new SqlParameter("@fltSalePrice", System.Data.SqlDbType.Float),
                        new SqlParameter("@intCurInventory", System.Data.SqlDbType.Int),
                        new SqlParameter("@intItemUnitId", System.Data.SqlDbType.Int),
                        new SqlParameter("@vchrSpellCode", System.Data.SqlDbType.VarChar),
                        new SqlParameter("@vchrRemark", System.Data.SqlDbType.VarChar),
            };
            asqlpara[0].Value = ExpenseItem.ItemNo;
            asqlpara[1].Value = ExpenseItem.ItemName;
            asqlpara[2].Value = ExpenseItem.SectionId;
            asqlpara[3].Value = ExpenseItem.ItemStandaryId;
            asqlpara[4].Value = ExpenseItem.SalePrice;
            asqlpara[5].Value = ExpenseItem.CurInventory;
            asqlpara[6].Value = ExpenseItem.ItemUnitId;
            asqlpara[7].Value = ExpenseItem.SpellCode;
            asqlpara[8].Value = ExpenseItem.Remark;
            DataSet ds = RunProcedure("HCS_InsertExpenseItems", asqlpara, "ExpenseItem");
            return ds;
        }

        public DataSet UpdateExpenseItem(ExpenseItem ExpenseItem)
        {
            throw new NotImplementedException();
        }

        public DataSet DeleteExpenseItem(ExpenseItem ExpenseItem)
        {
            throw new NotImplementedException();
        }

        #endregion



        #region IExpenseLineService 成员

        public DataSet GetExpenseLine(ExpenseLine ExpenseLine)
        {
            DataSet ds = new DataSet();
            SqlParameter[] asqlpara = new SqlParameter[] {
                        new SqlParameter("@vchrBillNo", System.Data.SqlDbType.VarChar)
            };

            asqlpara[0].Value = ExpenseLine.BillNo;
            ds = RunProcedure("HCS_GetExpenseLine", asqlpara, "ExpenseLine");
            return ds;
        }

        public DataSet SaveExpenseLine(ExpenseLine ExpenseLine)
        {
            SqlParameter[] asqlpara = new SqlParameter[] {
                        new SqlParameter("@vchrBillNo", System.Data.SqlDbType.VarChar),
                        new SqlParameter("@vchrItemNo", System.Data.SqlDbType.VarChar),
                        new SqlParameter("@intItemLineNo", System.Data.SqlDbType.Int),
                        new SqlParameter("@intAmount", System.Data.SqlDbType.Int),
                        new SqlParameter("@intIsDelete", System.Data.SqlDbType.Int)

            };
            asqlpara[0].Value = ExpenseLine.BillNo;
            asqlpara[1].Value = ExpenseLine.ItemNo;
            asqlpara[2].Value = ExpenseLine.ItemLineNo;
            asqlpara[3].Value = ExpenseLine.Amount;
            asqlpara[4].Value = ExpenseLine.IsDelete;
            DataSet ds = RunProcedure("HCS_SaveExpenseLine", asqlpara, "ExpenseLine");
            return ds;
        }

        public DataSet UpdateExpenseLine(ExpenseLine ExpenseLine)
        {
            throw new NotImplementedException();
        }

        public DataSet DeleteExpenseLine(ExpenseLine ExpenseLine)
        {
            SqlParameter[] asqlpara = new SqlParameter[] {
                        new SqlParameter("@vchrBillNo", System.Data.SqlDbType.VarChar),
                        new SqlParameter("@vchrItemNo", System.Data.SqlDbType.VarChar)

            };
            asqlpara[0].Value = ExpenseLine.BillNo;
            asqlpara[1].Value = ExpenseLine.ItemNo;

            DataSet ds = RunProcedure("HCS_DeleteExpenseLine", asqlpara, "ExpenseLine");
            return ds;
        }

        #endregion
    }
}
