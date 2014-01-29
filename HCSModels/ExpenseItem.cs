using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HCS.Models
{
    [Serializable]
    public  class ExpenseItem
    {
        protected string itemno;
        protected string itemname;
        protected int sectionid;
        protected int itemstandaryid;
        protected double saleprice;
        protected int curinventory;
        protected int itemunitid;
        protected string spellcode;
        protected string remark;
        protected int isdelete;

        public string ItemNo
        {
            get { return itemno; }
            set { itemno = value; }
        }
        public string ItemName
        {
            get { return itemname; }
            set { itemname= value; }
        }
        public int SectionId
        {
            get { return sectionid; }
            set { sectionid = value; }
        }
        public int ItemStandaryId
        {
            get { return itemstandaryid; }
            set { itemstandaryid = value; }
        }
        public int ItemUnitId
        {
            get { return itemunitid; }
            set { itemunitid = value; }
        }
        public double　SalePrice
        {
            get { return saleprice; }
            set { saleprice = value; }
        }
        public int CurInventory
        {
            get { return curinventory; }
            set { curinventory = value; }
        }
        public string SpellCode
        {
            get { return spellcode; }
            set { spellcode = value; }
        }
        public string Remark
        {
            get { return remark; }
            set { remark = value; }
        }
        public int IsDelete
        {
            get { return isdelete; }
            set { isdelete = value; }
        }
    }
}
