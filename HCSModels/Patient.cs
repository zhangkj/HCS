using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*********************************
 * 类名： Patient
 * 创建日期：2012-12-09
 * 功能描述：病人信息实体类
 * *******************************/
namespace HCS.Models
{
    [Serializable]
    public class Patient
    {
        protected int id;
        protected string name;
        protected int  age;
        protected int  gender;
        protected int roomnumber;
        protected int bedid;
        protected int doctorid;
        protected int nurseid;
        protected string doctorwords;
        protected string relativepeoplename;
        protected int relativephoneno;
        protected DateTime registerdate;
        protected DateTime leavedate;
        protected int sectionId;
        protected string remark;
        protected int isleavehospital;

        public int Id
        {
            get { return  id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public int Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        public int RoomNumber
        {
            get { return roomnumber; }
            set { roomnumber = value; }
        }
        public int BedId
        {
            get { return bedid; }
            set { bedid = value; }
        }
        public int DoctorId
        {
            get { return doctorid; }
            set { doctorid = value; }
        }
        public int NurseId
        {
            get { return nurseid; }
            set { nurseid = value; }
        }
        public string DoctorWords
        {
            get { return doctorwords; }
            set { doctorwords = value; }
        }
        public string RelativePeopleName
        {
            get { return relativepeoplename; }
            set { relativepeoplename = value; }
        }
        public int RelativePhoneNo
        {
            get { return relativephoneno; }
            set { relativephoneno = value; }
        }
        public DateTime RegisterDate
        {
            get { return registerdate; }
            set { registerdate = value; }
        }
        public DateTime LeaveDate
        {
            get { return leavedate; }
            set { leavedate = value; }
        }
        public int SectionId
        {
            get { return sectionId; }
            set { sectionId = value; }
        }
        public string Remark
        {
            get { return remark; }
            set { remark = value; }
        }
        public int IsLeaveHospital
        {
            get { return isleavehospital; }
            set { isleavehospital = value; }
        }
    }
}
