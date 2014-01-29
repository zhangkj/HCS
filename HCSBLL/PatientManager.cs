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
    public static class PatientManager
    {

        public static AbstractDALFactory facotory = AbstractDALFactory.ChooseFactory();
        public static IPatientService patientService = facotory.CreatePatientService();
        //获取全部病人信息列表
        public static DataSet GetPatients()
        {
            DataSet ds = new DataSet();
            try
            {
                ds = patientService.GetPatients();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            return ds;
        }
        //查询病人信息
        public static DataSet GetPatients(Patient patient)
        {
            DataSet ds = new DataSet();
            try
            {
                ds = patientService.GetPatients(patient);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            return ds;
        }
        //插入一条病人信息
        public static DataSet InsertPatient(Patient patient)
        {
            DataSet ds = new DataSet();
            try
            {
                ds = patientService.InsertPatient(patient);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            return ds;
        }
        //更新一条病人信息
        public static DataSet UpdatePatient(Patient patient)
        {
            DataSet ds = new DataSet();
            try
            {
                ds = patientService.UpdatePatient(patient);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            return ds;
        }
        //删除一条病人信息
        public static DataSet DeletePatient(Patient patient)
        {
            DataSet ds = new DataSet();
            try
            {
                ds = patientService.DeletePatient(patient);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            return ds;
        }
    }
}
