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
    public class ExpenseHeaderService:IExpenseHeaderService
    {
        string st;
        #region Private Members
        //从配置文件中读取数据库连接字符串
        public readonly string connString = ConfigurationManager.ConnectionStrings["HCSConnectionString"].ToString();
        private readonly string dboOwner = ConfigurationManager.ConnectionStrings["DataBaseOwner"].ToString();
        #endregion


        #region IPatientService 成员
        //新增病人数据，并获取最新病人列表
        public DataSet InsertPatient(Patient patient)
        {
            
            SqlParameter[]  asqlpara = new SqlParameter[] {
                        new SqlParameter("@intId", System.Data.SqlDbType.Int),
                        new SqlParameter("@vchrPName", System.Data.SqlDbType.VarChar),
                        new SqlParameter("@intPage", System.Data.SqlDbType.Int),
                        new SqlParameter("@intGender", System.Data.SqlDbType.Int),
                        new SqlParameter("@intRoomNumber", System.Data.SqlDbType.Int),
                        new SqlParameter("@intBedID", System.Data.SqlDbType.Int),
                        
                        new SqlParameter("@intDoctorID", System.Data.SqlDbType.Int),
                        new SqlParameter("@intNurseId", System.Data.SqlDbType.Int),
                        new SqlParameter("@vchrDoctorWords", System.Data.SqlDbType.VarChar),
                        new SqlParameter("@vchrRemark", System.Data.SqlDbType.VarChar),
                        new SqlParameter("@vchrRelativePeopleName", System.Data.SqlDbType.VarChar),
                        new SqlParameter("@intRelativePhoneNo", System.Data.SqlDbType.Int),
                        
                        new SqlParameter("@dtRegisterDate", System.Data.SqlDbType.DateTime),
                        new SqlParameter("@dtLeaveDate", System.Data.SqlDbType.DateTime),
                        new SqlParameter("@intSectionId", System.Data.SqlDbType.Int)
            };
            asqlpara[0].Value =patient.Id;
            asqlpara[1].Value =patient.Name;
            asqlpara[2].Value =patient.Age;
            asqlpara[3].Value =patient.Gender;
            asqlpara[4].Value =patient.RoomNumber;
            asqlpara[5].Value =patient.BedId;
            asqlpara[6].Value =patient.DoctorId;
            asqlpara[7].Value =patient.NurseId;
            asqlpara[8].Value =patient.DoctorWords;
            asqlpara[9].Value =patient.Remark;
            asqlpara[10].Value =patient.RelativePeopleName;
            asqlpara[11].Value =patient.RelativePhoneNo;
            asqlpara[12].Value =patient.RegisterDate;
            asqlpara[13].Value =patient.LeaveDate;
            asqlpara[14].Value =patient.SectionId;
            DataSet ds = RunProcedure("HCS_InsertPatient", asqlpara, "PatientInfo");
            return ds;
        }
        //新增病人数据，并获取最新病人列表
        public DataSet UpdatePatient(Patient patient)
        {

            SqlParameter[] asqlpara = new SqlParameter[] {
                        new SqlParameter("@intId", System.Data.SqlDbType.Int),
                        new SqlParameter("@vchrPName", System.Data.SqlDbType.VarChar),
                        new SqlParameter("@intPage", System.Data.SqlDbType.Int),
                        new SqlParameter("@intGender", System.Data.SqlDbType.Int),
                        new SqlParameter("@intRoomNumber", System.Data.SqlDbType.Int),
                        new SqlParameter("@intBedID", System.Data.SqlDbType.Int),
                        
                        new SqlParameter("@intDoctorID", System.Data.SqlDbType.Int),
                        new SqlParameter("@intNurseId", System.Data.SqlDbType.Int),
                        new SqlParameter("@vchrDoctorWords", System.Data.SqlDbType.VarChar),
                        new SqlParameter("@vchrRemark", System.Data.SqlDbType.VarChar),
                        new SqlParameter("@vchrRelativePeopleName", System.Data.SqlDbType.VarChar),
                        new SqlParameter("@intRelativePhoneNo", System.Data.SqlDbType.Int),
                        
                        new SqlParameter("@dtRegisterDate", System.Data.SqlDbType.DateTime),
                        new SqlParameter("@dtLeaveDate", System.Data.SqlDbType.DateTime),
                        new SqlParameter("@intSectionId", System.Data.SqlDbType.Int)
            };
            asqlpara[0].Value = patient.Id;
            asqlpara[1].Value = patient.Name;
            asqlpara[2].Value = patient.Age;
            asqlpara[3].Value = patient.Gender;
            asqlpara[4].Value = patient.RoomNumber;
            asqlpara[5].Value = patient.BedId;
            asqlpara[6].Value = patient.DoctorId;
            asqlpara[7].Value = patient.NurseId;
            asqlpara[8].Value = patient.DoctorWords;
            asqlpara[9].Value = patient.Remark;
            asqlpara[10].Value = patient.RelativePeopleName;
            asqlpara[11].Value = patient.RelativePhoneNo;
            asqlpara[12].Value = patient.RegisterDate;
            asqlpara[13].Value = patient.LeaveDate;
            asqlpara[14].Value = patient.SectionId;
            DataSet ds = RunProcedure("HCS_UpdatePatient", asqlpara, "PatientInfo");
            return ds;
        }
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


        #region IExpenseHeaderService 成员

        public DataSet GetExpenseHeader(ExpenseHeader ExpenseHeader)
        {
             DataSet ds = new DataSet();
            SqlParameter[] asqlpara = new SqlParameter[] {
                        new SqlParameter("@intPatientNo", System.Data.SqlDbType.Int)
            };
           
            asqlpara[0].Value = ExpenseHeader.PatientId;
            ds = RunProcedure("HCS_GetExpenseHeader", asqlpara, "ExpenseHeaer");
            return ds;
        }

        public DataSet SaveExpenseHeader(ExpenseHeader ExpenseHeader,string strChangeType)
        {
            SqlParameter[] asqlpara = new SqlParameter[] {
                        new SqlParameter("@vchrBillNo", System.Data.SqlDbType.VarChar),
                        new SqlParameter("@intPatientNo", System.Data.SqlDbType.Int),
                        new SqlParameter("@vchrApplyById", System.Data.SqlDbType.VarChar),
                        new SqlParameter("@dtApplyByDate", System.Data.SqlDbType.DateTime),
                        new SqlParameter("@fltTotalAmount", System.Data.SqlDbType.Float),
                        new SqlParameter("@intIsDelete", System.Data.SqlDbType.Int),
                        new SqlParameter("@vchrChangeType", System.Data.SqlDbType.VarChar),
                        new SqlParameter("@intIsPay", System.Data.SqlDbType.Int)};
            asqlpara[0].Value = ExpenseHeader.BillNo;
            asqlpara[1].Value = ExpenseHeader.PatientId;
            asqlpara[2].Value = ExpenseHeader.ApplyById;
            asqlpara[3].Value = ExpenseHeader.ApplyByDate;
            asqlpara[4].Value = ExpenseHeader.TotalAmount;
            asqlpara[5].Value = ExpenseHeader.IsDelete;
            asqlpara[6].Value = strChangeType;
            asqlpara[7].Value = ExpenseHeader.IsPay;
            DataSet ds = RunProcedure("HCS_SaveExpenseHeader", asqlpara, "ExpenseHeaer");
            return ds;
        }

        public DataSet UpdateExpenseHeader(ExpenseHeader ExpenseHeader)
        {
            throw new NotImplementedException();
        }

        public DataSet DeleteExpenseHeader(ExpenseHeader ExpenseHeader)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region IExpenseHeaderService 成员


        public DataSet GetExpenseHeaderEdit(ExpenseHeader ExpenseHeader)
        {
            DataSet ds = new DataSet();
            SqlParameter[] asqlpara = new SqlParameter[] {
                        new SqlParameter("@vchrBillNo", System.Data.SqlDbType.VarChar)
            };

            asqlpara[0].Value = ExpenseHeader.BillNo;
            ds = RunProcedure("HCS_GetExpenseHeaderEdit", asqlpara, "ExpenseHeaer");
            return ds;
        }


        public DataSet PayAllExpense(Patient patient)
        {
            DataSet ds = new DataSet();
            SqlParameter[] asqlpara = new SqlParameter[] {
                        new SqlParameter("@intId", System.Data.SqlDbType.Int)
            };

            asqlpara[0].Value = patient.Id;
            ds = RunProcedure("HCS_PayAllExpense", asqlpara, "ExpenseHeaer");
            return ds;
        }

        #endregion
    }
}
