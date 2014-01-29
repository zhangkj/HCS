using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HCS.Models;
using HCS.IDAL;
using System.Data;
/*********************************
 * 类名： IPatientService
 * 创建日期：2012-12-09
 * 功能描述：提供病人信息访问接口
 * *******************************/
namespace HCS.IDAL
{
    public interface IPatientService
    {
        //得到病人实体对象合集
        DataSet GetPatients();
        DataSet GetPatients(Patient patient);
        DataSet InsertPatient(Patient patient);
        DataSet UpdatePatient(Patient patient);
        DataSet DeletePatient(Patient patient);
    }
}
