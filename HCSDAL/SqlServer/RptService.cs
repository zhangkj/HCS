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
    public class RptService:IRptService
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

      
        #region IRptService 成员

        public DataSet GetRpt(string strProcedure,string[] strArray)
        {
            DataSet ds = new DataSet();
            SqlParameter[] asqlpara = new SqlParameter[] {
                        new SqlParameter("@vchrByType", System.Data.SqlDbType.VarChar)
            };
            asqlpara[0].Value = strArray[0].ToString();
            ds = RunProcedure(strProcedure, asqlpara, "Rpt");
            return ds;
        }

        #endregion
    }
}
