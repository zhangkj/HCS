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
    public partial class SectionInfoEdit : Form
    {
        public SectionInfoEdit()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            SBaseInfo sbaseinfo = new SBaseInfo();
            if (txtId.Text.Trim() == "")
            {
                //因为科室ID都为1011、1012、。。。格式的数字
                sbaseinfo.Id = 1;
            }
            else
            {
                sbaseinfo.Id = Convert.ToInt32(txtId.Text);
            }
            sbaseinfo.Name = txtName.Text;
            sbaseinfo.InfoType = 1;//infotype 1为科室信息类型
            DataSet ds = SBaseInfoManager.GetSBaseInfo(sbaseinfo);
            dgvList.DataSource = ds.Tables[0];
            
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
                if (txtId.Text.Trim() == "" || txtName.Text.Trim() == "")
                {
                    MessageBox.Show("不允许为空！");
                    return;
                 }

                SBaseInfo sbaseinfo = new SBaseInfo();
                sbaseinfo.Id = Convert.ToInt32(txtId.Text);
                sbaseinfo.Name = txtName.Text;
                sbaseinfo.InfoType = 1;//infotype 1为科室信息类型
                DataSet ds = SBaseInfoManager.InsertSBaseInfo(sbaseinfo);
                dgvList.DataSource = ds.Tables[0];
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
                txtId.Text = dr["Id"].ToString();
                txtName.Text = dr["Name"].ToString();
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
                    MessageBox.Show("请先选择科室信息");

                    return;
                }
                btnEdit.Text = "保存";
                EnableCOntrol();
                txtId.Enabled = false;
            }
            else
            {
                SBaseInfo sbaseinfo = new SBaseInfo();
                sbaseinfo.Id = Convert.ToInt32(txtId.Text);
                sbaseinfo.Name = txtName.Text;
                sbaseinfo.InfoType = 1;//infotype 1为科室信息类型
                DataSet ds = SBaseInfoManager.UpdatePatient(sbaseinfo);
                dgvList.DataSource = ds.Tables[0];
                btnEdit.Text = "修改";
                EnableCOntrol();
                DefaultData();

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SBaseInfo sbaseinfo = new SBaseInfo();
            sbaseinfo.Id = Convert.ToInt32(txtId.Text);
            sbaseinfo.Name = txtName.Text;
            sbaseinfo.InfoType = 1;//infotype 1为科室信息类型

            DataSet ds = SBaseInfoManager.DeleteSBaseInfo(sbaseinfo);
            dgvList.DataSource = ds.Tables[0];
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
