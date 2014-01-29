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
    public partial class ExpenseItemsEdit : Form
    {
        public ExpenseItemsEdit()
        {
            InitializeComponent();
            ModuleBase.BindDropDownList(cmbSection, 1);
            ModuleBase.BindDropDownList(cmbItemStandard, 3);
            ModuleBase.BindDropDownList(cmbItemUnit, 4);
            lblCurInventory.Visible = false;
            txtCurInventory.Visible = false;
        }
        private void BindDropDownList(ComboBox cbx, int InfoType)
        {
            SBaseInfo sbaseinfo = new SBaseInfo();
            sbaseinfo.Id = 1;
            sbaseinfo.Name = "";
            sbaseinfo.InfoType = InfoType;
            DataSet ds = SBaseInfoManager.GetSBaseInfo(sbaseinfo);
            cbx.DataSource = ds.Tables[0];
            cbx.ValueMember = "Id";
            cbx.DisplayMember = "Name";
        }
           
        private void btnSelect_Click(object sender, EventArgs e)
        {
            ExpenseItem ei = new ExpenseItem();
            ei.SpellCode = txtSelectCode.Text.ToString();
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
            DefaultData();
            EnableControls();
        }
        private void DisableControls()
        {
            txtItemNo.Enabled = false;
        }
        private void EnableControls()
        {
            txtItemNo.Enabled = true;
        }
        private void DefaultData()
        {
            txtItemNo.Text = "";
            txtItemName.Text = "";
            txtRemark.Text = "";
            txtSalePrice.Text = "";
            txtSpellCode.Text = "";
            cmbItemStandard.SelectedIndex = 0;
            cmbItemUnit.SelectedIndex = 0;
            cmbSection.SelectedIndex = 0;
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            if (txtItemNo.Enabled == false)
            {
                ModuleBase.PullMessageBox("请先清空信息，再新增");
                return;
            }
            if (txtItemNo.Text.Trim() == "")
            {
                ModuleBase.PullMessageBox("项目编号不能为空");
                txtItemNo.Focus();
                return;
            }
            if (txtItemName.Text.Trim() == "")
            {
                ModuleBase.PullMessageBox("项目名称不能为空");
                txtItemName.Focus();
                return;
            }

            if (cmbSection.SelectedIndex == 0)
            {
                ModuleBase.PullMessageBox("请选择科室");
                cmbSection.Focus();
                return;
            }

            if (cmbItemStandard.SelectedIndex == 0)
            {
                ModuleBase.PullMessageBox("请选择项目规格");
                cmbItemStandard.Focus();
                return;
            }

            if (cmbItemUnit.SelectedIndex == 0)
            {
                ModuleBase.PullMessageBox("请选择项目单位");
                cmbItemUnit.Focus();
                return;
            }

            if (txtSalePrice.Text.Trim() == "")
            {
                ModuleBase.PullMessageBox("销售单价不能为空");
                txtSalePrice.Focus();
                return;
            }
            
            ExpenseItem ei = new ExpenseItem();
            ei.ItemNo = txtItemNo.Text;
            ei.ItemName = txtItemName.Text;
            ei.SectionId = (int)cmbSection.SelectedValue;
            ei.ItemStandaryId = (int)cmbItemStandard.SelectedValue;
            try
            {
                ei.SalePrice = Convert.ToDouble(txtSalePrice.Text);
            }
            catch
            {
                ModuleBase.PullMessageBox("销售单价输入格式不正确");
                txtSalePrice.Focus();
                return;
            }
            ei.SpellCode = txtSpellCode.Text;
            ei.ItemUnitId = (int)cmbItemUnit.SelectedValue;
            ei.CurInventory = 1;
            ei.Remark = txtRemark.Text;
            DataSet ds = new DataSet();
            ds = ExpenseItemManager.InsertExpenseItem(ei);

            if (ds.Tables.Count > 0)
            {
                ModuleBase.PullMessageBox("新增成功");
            }

            BindDataSource(ds.Tables[0]);

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //数据为字母
            if (!char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                return;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ExpenseItem ei = new ExpenseItem();

            ei.ItemNo = txtItemNo.Text;
            ei.ItemName = txtItemName.Text;
            ei.ItemStandaryId = Convert.ToInt32(cmbItemStandard.SelectedValue);
            ei.ItemUnitId = Convert.ToInt32(cmbItemUnit.SelectedValue);
            ei.Remark = txtRemark.Text;
            try
            {
                ei.SalePrice = Convert.ToDouble(txtSalePrice.Text);
            }
            catch
            {
                ModuleBase.PullMessageBox("销售单价输入格式不正确");
                txtSalePrice.Focus();
                return;
            }
            ei.SectionId = Convert.ToInt32(cmbSection.SelectedValue);
            ei.SpellCode = txtSpellCode.Text;
            ei.CurInventory = 1;

            DataSet ds = new DataSet();
            ds = ExpenseItemManager.UpdateExpenseItem(ei);
            if (ds.Tables.Count > 0)
            {
                ModuleBase.PullMessageBox("修改成功");
            }
            BindDataSource(ds.Tables[0]);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK != ModuleBase.IsOrNotDeleteData())
            {
                return;
            }
            if (dgvExpenseItem.Rows.Count<=0)
            {
                ModuleBase.PullMessageBox("没有选中行,无法删除");
                return;
            }


            ExpenseItem ei = new ExpenseItem();

            DataTable dt = (DataTable)dgvExpenseItem.DataSource;
            int index = dgvExpenseItem.CurrentCell.RowIndex;
            DataRow dr = dt.Rows[index];

            ei.ItemNo = dr["ItemNo"].ToString();

            DataSet ds = new DataSet();

            ds = ExpenseItemManager.DeleteExpenseItem(ei);

            if (ds.Tables.Count > 0)
            {
                ModuleBase.PullMessageBox("删除成功");
            }

            BindDataSource(ds.Tables[0]);
            DefaultData();
        }

        private void dgvExpenseItem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = (DataTable)dgvExpenseItem.DataSource;
            int index = dgvExpenseItem.CurrentCell.RowIndex;

            DataRow dr = dt.Rows[index];

            txtItemNo.Text = dr["ItemNo"].ToString();
            txtItemName.Text = dr["ItemName"].ToString();
            txtRemark.Text = dr["Remark"].ToString();
            txtSalePrice.Text = dr["SalePrice"].ToString();
            txtSpellCode.Text = dr["SpellCode"].ToString();
            cmbItemStandard.SelectedValue = dr["ItemStandardId"].ToString();
            cmbItemUnit.SelectedValue = dr["ItemUnitId"].ToString();
            cmbSection.SelectedValue = dr["SectionId"].ToString();
            DisableControls();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DefaultData();
            txtSelectCode.Text = "";
            EnableControls();
        }
    }
}
