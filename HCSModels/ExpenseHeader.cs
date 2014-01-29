using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HCS.Models
{
    [Serializable]
    public class ExpenseHeader
    {
        protected string billno;
        protected int patientNo;
        protected string applyById;
        protected DateTime applyByDate;
        protected double totalAmount;
        protected string changetype;
        protected int isDelete;
        protected int ispay;
        public string BillNo
        {
            get { return billno; }
            set { billno = value; }
        }
        public int PatientId
        {
            get { return patientNo; }
            set { patientNo = value; }
        }
        public string ApplyById
        {
            get { return applyById; }
            set { applyById = value; }
        }
        public DateTime ApplyByDate
        {
            get { return applyByDate; }
            set { applyByDate = value; }
        }
        public double TotalAmount
        {
            get { return totalAmount; }
            set { totalAmount = value; }
        }
        public int IsDelete
        {
            get { return isDelete; }
            set { isDelete = value; }
        }
        public string ChangeType
        {
            get { return changetype; }
            set { changetype = value; }
        }
        public int IsPay
        {
            get { return ispay; }
            set { ispay = value; }
        }
    }
}
