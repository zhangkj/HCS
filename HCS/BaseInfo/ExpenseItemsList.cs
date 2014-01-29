using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HCS.BLL;
using HCS.Models;
namespace HCS
{
    public partial class ExpenseItemsList : Form
    {
        public ExpenseItemsList()
        {
            InitializeComponent();
            btnSelect_Click(this,new  EventArgs());
        }
        public ExpenseItemsList(string OpenType)
        {
            InitializeComponent();
            btnSelect_Click(this, new EventArgs());
            strOpenType = OpenType;
        }
        public string strOpenType;
        private void btnSelect_Click(object sender, EventArgs e)
        {
            ExpenseItem ei = new ExpenseItem();
            ei.SpellCode = txtSpellCode.Text;
            DataSet ds = new DataSet();
            ds = ExpenseItemManager.GetExpenseItem(ei);

            BindDataSource(ds.Tables[0]);
        }
        private void BindDataSource(DataTable dt)
        {
            dgvExpenseItem.DataSource = dt;
            dgvExpenseItem.Columns["ItemNo"].HeaderText = "项目编号";
            dgvExpenseItem.Columns["ItemName"].HeaderText = "项目名称";
            dgvExpenseItem.Columns["SectionId"].Visible = false;
            dgvExpenseItem.Columns["SectionDescr"].HeaderText = "科室";
            dgvExpenseItem.Columns["ItemStandardId"].Visible = false;
            dgvExpenseItem.Columns["StandardDescr"].HeaderText = "规格";
            dgvExpenseItem.Columns["ItemUnitId"].Visible = false;
            dgvExpenseItem.Columns["UnitDescr"].HeaderText = "单位";
            dgvExpenseItem.Columns["SalePrice"].HeaderText = "价格";
            dgvExpenseItem.Columns["CurInventory"].HeaderText = "库存数量";
            dgvExpenseItem.Columns["SpellCode"].HeaderText = "项目缩写";
            dgvExpenseItem.Columns["Remark"].HeaderText = "备注";

        }
        private void dgvExpenseItem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = (DataTable)dgvExpenseItem.DataSource;
            int RowIndex = dgvExpenseItem.CurrentCell.RowIndex;
            DataRow dr  = dt.Rows[RowIndex];
            DataRow drLine;
            if (strOpenType == "edit")
            {
                drLine = ExpenseEdit.dtLine.NewRow();
            }
            else
            {
                drLine = ExpenseInput.dtLine.NewRow();                
            }
            ExpenseItem ei = new ExpenseItem();
            drLine["ItemNo"] = dr["ItemNo"].ToString();
            drLine["ItemName"]= dr["ItemName"].ToString();
            drLine["SalePrice"]=Convert.ToDouble(dr["SalePrice"].ToString());
            drLine["Amount"] = Convert.ToInt32(dr["CurInventory"]);
            drLine["IsDelete"] = 0;
            drLine["id"] = drLine.Table.Rows.Count+1;
            bool IsExist = false;
            DataRow datarow;
            for (int i = 0; i < drLine.Table.Rows.Count; i++)
            {
                datarow = drLine.Table.Rows[i];
                string strItemNoOld = datarow["ItemNo"].ToString();
                string strItemNoNew =drLine["ItemNo"].ToString();
                if ( strItemNoOld.Trim() ==strItemNoNew.Trim()&&Convert.ToInt32(datarow["IsDelete"])==0)
                {
                    int intAmount = Convert.ToInt32(datarow["Amount"]) + 1;
                    datarow["Amount"] = intAmount;
                    IsExist = true;
                    break;
                }
            }
            if (IsExist == false)
            {
                drLine.Table.Rows.Add(drLine);
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
