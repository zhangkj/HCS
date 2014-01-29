using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HCS.Models
{
    [Serializable]
    public  class ExpenseLine
    {
        protected string billno;
        protected string itemno;
        protected int itemlineno;
        protected int amount;
        protected int isdelete;
        protected string changetype;
        public string BillNo
        {
            get { return billno; }
            set { billno= value; }
        }
        public string ItemNo
        {
            get { return itemno; }
            set { itemno = value; }
        }
       
        public int ItemLineNo
        {
            get { return itemlineno; }
            set { itemlineno = value; }
        }
        public int Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        public int IsDelete
        {
            get { return isdelete; }
            set { isdelete = value; }
        }
        public string ChangeType
        {
            get { return changetype; }
            set { changetype = value; }
        }
       
    }
}
