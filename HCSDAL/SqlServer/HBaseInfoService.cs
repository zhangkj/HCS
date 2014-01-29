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
    public class HBaseInfoService:IHBaseInfoService
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

       
        #region IHBaseInfoService 成员

        public DataSet GetHBaseInfo(HBaseInfo HBaseInfo)
        {
            DataSet ds = new DataSet();
            SqlParameter[] asqlpara = new SqlParameter[] {
                        new SqlParameter("@intId", System.Data.SqlDbType.Int),
                        new SqlParameter("@intInfoType", System.Data.SqlDbType.Int),
                        new SqlParameter("@vchrName", System.Data.SqlDbType.VarChar),
                        new SqlParameter("@intSectionId", System.Data.SqlDbType.Int)
            };
            asqlpara[0].Value = HBaseInfo.Id;
            asqlpara[1].Value = HBaseInfo.InfoType;
            asqlpara[2].Value = HBaseInfo.Name;
            asqlpara[3].Value = HBaseInfo.SectionId;
            ds = RunProcedure("HCS_GetHBaseInfoList", asqlpara, "HBaseInfoList");
            return ds;
        }

        public DataSet InsertHBaseInfo(HBaseInfo HBaseInfo)
        {
            DataSet ds = new DataSet();
            SqlParameter[] asqlpara = new SqlParameter[] {
                        new SqlParameter("@intId", System.Data.SqlDbType.Int),
                        new SqlParameter("@intInfoType", System.Data.SqlDbType.Int),
                        new SqlParameter("@vchrName", System.Data.SqlDbType.VarChar),
                        new SqlParameter("@intSectionId", System.Data.SqlDbType.Int)
            };
            asqlpara[0].Value = HBaseInfo.Id;
            asqlpara[1].Value = HBaseInfo.InfoType;
            asqlpara[2].Value = HBaseInfo.Name;
            asqlpara[3].Value = HBaseInfo.SectionId;
            ds = RunProcedure("HCS_InsertHBaseInfo", asqlpara, "HBaseInfoList");
            return ds;
        }

        public DataSet UpdateHBaseInfo(HBaseInfo HBaseInfo)
        {
            DataSet ds = new DataSet();
            SqlParameter[] asqlpara = new SqlParameter[] {
                        new SqlParameter("@intId", System.Data.SqlDbType.Int),
                        new SqlParameter("@intInfoType", System.Data.SqlDbType.Int),
                        new SqlParameter("@vchrName", System.Data.SqlDbType.VarChar),
                        new SqlParameter("@intSectionId", System.Data.SqlDbType.Int)
            };
            asqlpara[0].Value = HBaseInfo.Id;
            asqlpara[1].Value = HBaseInfo.InfoType;
            asqlpara[2].Value = HBaseInfo.Name;
            asqlpara[3].Value = HBaseInfo.SectionId;
            ds = RunProcedure("HCS_UpdateHBaseInfo", asqlpara, "HBaseInfoList");
            return ds;
        }

        public DataSet DeleteHBaseInfo(HBaseInfo HBaseInfo)
        {
            DataSet ds = new DataSet();
            SqlParameter[] asqlpara = new SqlParameter[] {
                        new SqlParameter("@intId", System.Data.SqlDbType.Int),
                        new SqlParameter("@intInfoType", System.Data.SqlDbType.Int),
                        new SqlParameter("@intSectionId", System.Data.SqlDbType.Int)
            };
            asqlpara[0].Value = HBaseInfo.Id;
            asqlpara[1].Value = HBaseInfo.InfoType;
            asqlpara[2].Value = HBaseInfo.SectionId;
            ds = RunProcedure("HCS_DeleteHBaseInfo", asqlpara, "HBaseInfoList");
            return ds;
        }

        #endregion
    }
}
