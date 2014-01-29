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
    public partial class PatientInfoList : Form
    {
        public PatientInfoList()
        {
            InitializeComponent();
            DataSet ds = PatientManager.GetPatients();
            BindDataSource(ds.Tables[0]);
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient();
            if (txtPatientId.Text.Trim() == "")
            {
                //如果为空，则赋值为1，表示查询全部病人信息
                patient.Id = 1;
            }
            else
            {
                string strId = txtPatientId.Text.Trim().ToString();
                try
                {
                    patient.Id = Convert.ToInt32(strId);
                }
                catch
                {
                    ModuleBase.PullMessageBox("病人ID为数字类型,请重新输入");
                    return;
                }
            }
            patient.Name = txtPatientName.Text.Trim();
            DataSet ds = PatientManager.GetPatients(patient);
            
            //绑定查询到的病人列表
            BindDataSource(ds.Tables[0]);
        }

        public void BindDataSource(DataTable dt)
        {
            dgvPatientsList.DataSource = dt;
            dgvPatientsList.Columns["PId"].HeaderText = "ID";
            dgvPatientsList.Columns["PName"].HeaderText = "姓名";
            dgvPatientsList.Columns["PAge"].HeaderText = "年龄";
            dgvPatientsList.Columns["PGender"].Visible = false;
            dgvPatientsList.Columns["PGenderDescr"].HeaderText = "性别";
            dgvPatientsList.Columns["PRoomNumber"].HeaderText = "病房号";
            dgvPatientsList.Columns["PBedId"].HeaderText = "病床号";
            dgvPatientsList.Columns["PDoctorDescr"].HeaderText = "主治医生";
            dgvPatientsList.Columns["PDoctorId"].Visible = false;
            dgvPatientsList.Columns["PNurseId"].Visible = false;
            dgvPatientsList.Columns["PDoctoryWords"].HeaderText = "医嘱";
            dgvPatientsList.Columns["PRelativePeopleName"].HeaderText = "病人亲属";
            dgvPatientsList.Columns["PRelativePhoneNo"].HeaderText = "病人亲属电话";
            dgvPatientsList.Columns["PRegisterDate"].HeaderText = "入院时间";
            dgvPatientsList.Columns["PLeaveDate"].HeaderText = "出院时间";
            dgvPatientsList.Columns["PSectionId"].Visible = false;
            dgvPatientsList.Columns["PSectionDescr"].HeaderText = "科室";
            dgvPatientsList.Columns["PRemark"].HeaderText = "备注";

        }
        private void dgvPatientsList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = (DataTable)dgvPatientsList.DataSource;
            int RowIndex = dgvPatientsList.CurrentCell.RowIndex;
            DataRow dr = dt.Rows[RowIndex];
            Patient patient = new Patient();
            patient.Id=Convert.ToInt32( dr["PId"].ToString());
            patient.Name = dr["PName"].ToString();
            patient.Age = Convert.ToInt32(dr["PAge"].ToString());
            patient.Gender = Convert.ToInt32(dr["PGender"].ToString());
            patient.DoctorId = Convert.ToInt32(dr["PDoctorId"].ToString());
            patient.SectionId = Convert.ToInt32(dr["PSectionId"].ToString());

            ExpenseInput.staPatientInfo = patient;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}
