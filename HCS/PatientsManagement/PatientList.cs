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
using System.Text.RegularExpressions;
namespace HCS
{
    public partial class PatientList : Form
    {
        public PatientList()
        {
            InitializeComponent();
            //绑定下拉框
            //科室
            ModuleBase.BindDropDownList(cmbSectionId, 1);
            //性别
            ModuleBase.BindDropDownList(cmbGender, 2);
            //医生下拉框绑定
            ModuleBase.BindDropDownListH(cmbDoctorId, 1,0);
            //护士绑定，暂时绑定为医生
            ModuleBase.BindDropDownListH(cmbNurseId, 1, 0);
            txtPatientId.Text = "<系统自动生成>";
            txtPatientId.Enabled = false;
            lblLeaveDate.Visible = false;
            dtpLeaveDate.Visible = false;
            chkRecallPatient.Visible = false;
            
        }

        public  void DefaultData()
        {
            txtPatientId.Text = "<系统自动生成>";
            txtPatientName.Text = "";
            txtAge.Text = "20";
            txtBedId.Text = "001";
            txtRoomNumber.Text = "001";
            txtRelativePeoplePhone.Text = "0";
            txtRelativePeopleName.Text = "";
            txtDoctorwords.Text = "";
            txtRemark.Text = "";
            cmbGender.SelectedIndex = 0;
            cmbDoctorId.SelectedIndex = 0;
            cmbNurseId.SelectedIndex = 0;
            cmbSectionId.SelectedIndex = 0;
        }
        private void btnSelect_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient();
            if (txtPatientId.Text.Trim() == "<系统自动生成>")
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
            patient.IsLeaveHospital = Convert.ToInt32(chkIsLeaveHospital.Checked);
            DataSet ds = PatientManager.GetPatients(patient);

            //绑定查询到的病人列表
            BindDataSource(ds);

            DefaultData();
            EnableControl();
        }
        private bool IsNullCheck()
        {
            //姓名
            if (txtPatientName.Text.Trim() == "")
            {
                ModuleBase.PullMessageBox("姓名不能为空");
                txtPatientName.Focus();
                return false ;
            }
            
            //年龄
            if (txtAge.Text.Trim() == "")
            {
                ModuleBase.PullMessageBox("年龄不能为空");
                txtAge.Focus();
                return false;
            }

            //性别
            if ((int)cmbGender.SelectedValue == 0)
            {
                ModuleBase.PullMessageBox("性别不能为空");
                cmbGender.Focus();
                return false;
            }
            //科室
            if ((int)cmbSectionId.SelectedValue == 0)
            {
                ModuleBase.PullMessageBox("科室不能为空");
                cmbSectionId.Focus();
                return false;
            }
            //医生
            if ((int)cmbDoctorId.SelectedValue == 0)
            {
                ModuleBase.PullMessageBox("医生不能为空");
                cmbDoctorId.Focus();
                return false;
            }
            //房间
            if (txtRoomNumber.Text.Trim() == "")
            {
                ModuleBase.PullMessageBox("房间号不能为空");
                txtRoomNumber.Focus();
                return false;
            }
            //床位号
            if (txtBedId.Text.Trim() == "")
            {
                ModuleBase.PullMessageBox("床位号不能为空");
                txtBedId.Focus();
                return false;
            }
            //亲属姓名
            if (txtRelativePeopleName.Text == "")
            {
                ModuleBase.PullMessageBox("亲属姓名不能为空");
                txtRelativePeopleName.Focus();
                return false;
            }
            //亲属电话
            if (txtRelativePeoplePhone.Text.Trim()=="")
            {
                ModuleBase.PullMessageBox("亲属电话不能为空");
                txtRelativePeoplePhone.Focus();
                return false;
            }
            return true;
        }
        public void BindDataSource(DataSet ds)
        {
            dgvPatientsList.DataSource = ds.Tables[0];
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

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (txtPatientId.Text.Trim() != "<系统自动生成>")
            {
                DefaultData();
                EnableControl();
                //return;
            }
            DataTable dt = (DataTable)cmbSectionId.DataSource;

            if (!IsNullCheck())
            {
                return;
            }

            Patient patient = new Patient();
            patient.Id = 1;
            patient.Name = txtPatientName.Text.ToString();
            patient.Age = Convert.ToInt32(txtAge.Text.ToString());
            patient.Gender = Convert.ToInt32(cmbGender.SelectedValue.ToString());
            patient.RoomNumber = Convert.ToInt32(txtRoomNumber.Text.ToString()); 
            patient.DoctorId = Convert.ToInt32(cmbDoctorId.SelectedValue.ToString());
            patient.BedId = Convert.ToInt32(txtBedId.Text.ToString());
            patient.RegisterDate = Convert.ToDateTime(dtpRegisterDate.Text.ToString());
            patient.LeaveDate = Convert.ToDateTime("1900-01-01");
            patient.DoctorWords = txtDoctorwords.Text.ToString();
            patient.RelativePeopleName = txtRelativePeopleName.Text.ToString();
            try
            {
                patient.RelativePhoneNo = Convert.ToInt32(txtRelativePeoplePhone.Text.ToString());
            }
            catch
            {
                ModuleBase.PullMessageBox("电话号码输入类型不正确,请重新输入");
                return;
            }
            patient.Remark = txtRemark.Text.ToString();
            patient.SectionId = Convert.ToInt32(cmbSectionId.SelectedValue.ToString());

            DataSet ds = PatientManager.InsertPatient(patient);

            BindDataSource(ds);
            DefaultData();
            EnableControl();
        }

        private void dgvPatientsList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = (DataTable)dgvPatientsList.DataSource;
            int RowIndex = dgvPatientsList.CurrentCell.RowIndex;
            DataRow dr = dt.Rows[RowIndex];
            txtPatientId.Text =dr["PId"].ToString();
            txtPatientName.Text = dr["PName"].ToString();
            txtAge.Text = dr["PAge"].ToString();
            cmbGender.SelectedValue = dr["PGender"].ToString();
            txtRoomNumber.Text = dr["PRoomNumber"].ToString();
            txtBedId.Text = dr["PBedId"].ToString();
            cmbDoctorId.SelectedValue= dr["PDoctorId"].ToString();
            cmbNurseId.SelectedValue = dr["PNurseId"].ToString();
            txtDoctorwords.Text = dr["PDoctoryWords"].ToString();
            txtRelativePeopleName.Text = dr["PRelativePeopleName"].ToString();
            txtRelativePeoplePhone.Text = dr["PRelativePhoneNo"].ToString();
            dtpRegisterDate.Text = dr["PRegisterDate"].ToString();
            dtpLeaveDate.Text = dr["PLeaveDate"].ToString();
            cmbSectionId.SelectedValue = dr["PSectionId"].ToString();
            txtRemark.Text = dr["PRemark"].ToString();
            DisableControl();

        }

       

        protected void DisableControl()
        {
            txtPatientId.Enabled = false;
            txtPatientName.Enabled = false;
            txtAge.Enabled = false;
            cmbGender.Enabled = false;
            txtRoomNumber.Enabled = false;
            txtBedId.Enabled = false;
            cmbDoctorId.Enabled = false;
            cmbNurseId.Enabled = false;
            txtDoctorwords.Enabled = false;
            txtRelativePeopleName.Enabled = false;
            txtRelativePeoplePhone.Enabled = false;
            dtpRegisterDate.Enabled = false;
            dtpLeaveDate.Enabled = false;
            cmbSectionId.Enabled = false;
            txtRemark.Enabled = false;
        }
        protected void EnableControl()
        {
            
            txtPatientName.Enabled = true;
            txtAge.Enabled = true;
            cmbGender.Enabled = true;
            txtRoomNumber.Enabled = true;
            txtBedId.Enabled = true;
            cmbDoctorId.Enabled = true;
            cmbNurseId.Enabled = true;
            txtDoctorwords.Enabled = true;
            txtRelativePeopleName.Enabled = true;
            txtRelativePeoplePhone.Enabled = true;
            dtpRegisterDate.Enabled = true;
            dtpLeaveDate.Enabled = true;
            cmbSectionId.Enabled = true;
            txtRemark.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)cmbSectionId.DataSource;
            if (!IsNullCheck())
            {
                return;
            }
            Patient patient = new Patient();
            patient.Id = Convert.ToInt32(txtPatientId.Text);
            patient.Name = txtPatientName.Text.ToString();
            patient.Age = Convert.ToInt32(txtAge.Text.ToString());
            patient.Gender = Convert.ToInt32(cmbGender.SelectedValue.ToString());
            patient.RoomNumber = Convert.ToInt32(txtRoomNumber.Text.ToString());
            patient.DoctorId = Convert.ToInt32(cmbDoctorId.SelectedValue.ToString());
            patient.BedId = Convert.ToInt32(txtBedId.Text.ToString());
            patient.RegisterDate = Convert.ToDateTime(dtpRegisterDate.Text.ToString());
            patient.LeaveDate = Convert.ToDateTime(dtpRegisterDate.Text.ToString());
            patient.DoctorWords = txtDoctorwords.Text.ToString();
            patient.RelativePeopleName = txtRelativePeopleName.Text.ToString();
            patient.RelativePhoneNo = Convert.ToInt32(txtRelativePeoplePhone.Text.ToString());
            patient.Remark = txtRemark.Text.ToString();
            patient.SectionId = Convert.ToInt32(cmbSectionId.SelectedValue.ToString());
            if (chkIsLeaveHospital.Checked)
            {
                if (chkRecallPatient.Checked)
                {
                    patient.IsLeaveHospital = 0;
                }
                else
                {
                    patient.IsLeaveHospital = 1;
                }
            }
            else
            {
                patient.IsLeaveHospital = 0;
            }
            DataSet ds = PatientManager.UpdatePatient(patient);

            BindDataSource(ds);
            DefaultData();
            EnableControl();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EnableControl();
            txtPatientId.Enabled = false;
            dtpRegisterDate.Enabled = false;
        }

        private void cmbSectionId_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)cmbSectionId.DataSource;
            int sectionid = Convert.ToInt32(dt.Rows[cmbSectionId.SelectedIndex]["Id"]);
            ModuleBase.BindDropDownListH(cmbDoctorId, 1,Convert.ToInt32(sectionid));
        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {
            if (!IsNumber(txtAge))
                return;
        }

        private bool IsNumber(TextBox textBox)
        {
            Regex r = new Regex("^[0-9]{1,}$");
            if (!r.IsMatch(textBox.Text))
            {
                ModuleBase.PullMessageBox("只能输入数字格式");
                textBox.Text = "";
                return false ;
            }

            return true;
        }

        private void txtRoomNumber_TextChanged(object sender, EventArgs e)
        {
            if (!IsNumber(txtRoomNumber))
                return;
        }

        private void txtBedId_TextChanged(object sender, EventArgs e)
        {
            if (!IsNumber(txtBedId))
                return;
        }

        private void txtRelativePeoplePhone_TextChanged(object sender, EventArgs e)
        {
            if (!IsNumber(txtRelativePeoplePhone))
                return;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK != ModuleBase.IsOrNotDeleteData())
            {
                return;
            }
            DataTable dt = (DataTable)dgvPatientsList.DataSource;
            int RowIndex = dgvPatientsList.CurrentCell.RowIndex;
            DataRow dr = dt.Rows[RowIndex];

            Patient patient = new Patient();
            patient.Id = Convert.ToInt32(dr["PId"]);
            DataSet ds = new DataSet();
            ds = PatientManager.DeletePatient(patient);
            BindDataSource(ds);

        }

        private void chkIsLeaveHospital_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIsLeaveHospital.Checked)
            {
                lblLeaveDate.Visible = true;
                dtpLeaveDate.Visible = true;
                chkRecallPatient.Visible = true;
                chkRecallPatient.Checked = false;
                btnSave.Enabled = false;
            }
            else 
            {
                lblLeaveDate.Visible = false;
                dtpLeaveDate.Visible = false;
                chkRecallPatient.Visible = false;
                chkRecallPatient.Checked = false;
                btnSave.Enabled = true;
            }
        }

        private void chkRecallPatient_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRecallPatient.Checked)
            {
                btnSave.Enabled = true;
            }
            else
            {
                btnSave.Enabled = false;
            }
        }


    }
}
