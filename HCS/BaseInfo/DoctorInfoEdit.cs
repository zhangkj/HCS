using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HCS.Models;
using HCS.BLL;

namespace HCS
{
    public partial class DoctorInfoEdit : Form
    {
        public DoctorInfoEdit()
        {
            InitializeComponent();
            ModuleBase.BindDropDownList(cmbSection, 1);
            
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            HBaseInfo HBaseInfo = new HBaseInfo();
            if (txtId.Text.Trim() == "")
            {
                
                HBaseInfo.Id = 1;
            }
            else
            {
                HBaseInfo.Id = Convert.ToInt32(txtId.Text);
            }
            HBaseInfo.Name = txtName.Text;
            HBaseInfo.InfoType = 1;//infotype 1为科室信息类型
            HBaseInfo.SectionId = Convert.ToInt32(cmbSection.SelectedValue);
            DataSet ds = HBaseInfoManager.GetHBaseInfo(HBaseInfo);
            BindDataSource(ds.Tables[0]);
            
        }
        public void BindDataSource(DataTable dt)
        {
            dgvList.DataSource = dt;
            dgvList.Columns["InfoId"].HeaderText = "医生ID";
            dgvList.Columns["InfoName"].HeaderText = "医生姓名";
            dgvList.Columns["SectionDescr"].HeaderText = "科室";
            dgvList.Columns["SectionId"].Visible = false;
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            if (btnNew.Text == "新增")
            {
                EnableCOntrol();
                DefaultData();
                btnNew.Text = "保存";
            }
            else
            {
                if (txtId.Text.Trim() == "" || txtName.Text.Trim() == ""||cmbSection.SelectedValue.ToString()=="0")
                {
                    MessageBox.Show("不允许为空！");
                    return;
                 }

                HBaseInfo HBaseInfo = new HBaseInfo();
                HBaseInfo.Id = Convert.ToInt32(txtId.Text);
                HBaseInfo.Name = txtName.Text;
                HBaseInfo.InfoType = 1;//infotype 1为医生信息类型
                HBaseInfo.SectionId = Convert.ToInt32(cmbSection.SelectedValue);
                DataSet ds = HBaseInfoManager.InsertHBaseInfo(HBaseInfo);
                BindDataSource(ds.Tables[0]);
                btnNew.Text = "保存";
                DefaultData();
            }
        }

        private void dgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = (DataTable)dgvList.DataSource;
            int RowIndex = dgvList.CurrentCell.RowIndex;
            if (dt.Rows.Count > RowIndex)
            {
                DataRow dr = dt.Rows[RowIndex];
                txtId.Text = dr["InfoId"].ToString();
                txtName.Text = dr["InfoName"].ToString();
                cmbSection.SelectedValue = dr["SectionId"].ToString();
                DisableControl();
            }
        }
        private void DisableControl()
        {
            txtId.Enabled = false;
            txtName.Enabled = false;
            btnEdit.Text = "修改";
            btnNew.Text = "新增";
        }
        private void EnableCOntrol()
        {
            txtId.Enabled = true;
            txtName.Enabled = true;

        }
        private void DefaultData()
        {
            txtId.Text = "";
            txtName.Text= "";
            btnNew.Text = "新增";
            btnEdit.Text = "修改";
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
           
            if (btnEdit.Text == "修改")
            {
                if (txtName.Text.Trim() == "" || txtId.Text.Trim() == "")
                {
                    MessageBox.Show("请先选择医生信息");

                    return;
                }
                btnEdit.Text = "保存";
                EnableCOntrol();
                txtId.Enabled = false;
            }
            else
            {
                HBaseInfo HBaseInfo = new HBaseInfo();
                HBaseInfo.Id = Convert.ToInt32(txtId.Text);
                HBaseInfo.Name = txtName.Text;
                HBaseInfo.InfoType = 1;//infotype 1为医生信息类型
                HBaseInfo.SectionId = Convert.ToInt32(cmbSection.SelectedValue);
                DataSet ds = HBaseInfoManager.UpdateHBaseInfo(HBaseInfo);
                BindDataSource(ds.Tables[0]);
                btnEdit.Text = "修改";
                EnableCOntrol();
                DefaultData();

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("确认删除?", "提示信息", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.Cancel)
            {
                return;
            }
            HBaseInfo HBaseInfo = new HBaseInfo();
            HBaseInfo.Id = Convert.ToInt32(txtId.Text);
            HBaseInfo.Name = txtName.Text;
            HBaseInfo.InfoType = 1;//infotype 1为医生室信息类型

            DataSet ds = HBaseInfoManager.DeleteHBaseInfo(HBaseInfo);
            BindDataSource(ds.Tables[0]);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            //限制id 数据为数字类型
            if (!char.IsDigit(e.KeyChar)) //  放弃该输入          
            {
                e.Handled = true;
                return;
            }
        }
    }
}
