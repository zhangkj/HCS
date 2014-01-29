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
    public partial class ExpenseList : Form
    {
        public ExpenseList()
        {
            InitializeComponent();
            txtAllTotal.Text = "0.00";
            txtAllTotal.Enabled = false;
            txtAllTotalPayed.Text = "0.00";
            txtAllTotalPayed.Enabled = false;
            txtAllTotalNoPay.Text = "0.00";
            txtAllTotalNoPay.Enabled = false;
            ModuleBase.BindDropDownListH(cmbDoctor, 1, 1);
            ModuleBase.BindDropDownList(cmbSection, 1);
            ModuleBase.BindDropDownList(cmbGender, 2);
            btnSave.Enabled = false;

        }
        public static int  intAmount;
       
        private void ExpenseInput_Load(object sender, EventArgs e)
        {
            
        }

        private void BindDataSource(DataTable dt)
        {
            dgvExpenseInput.DataSource = dt;
            dgvExpenseInput.Columns["BillNo"].HeaderText = "费用单号";
            dgvExpenseInput.Columns["PatientNo"].HeaderText = "病人ID";
            dgvExpenseInput.Columns["PatientDescr"].HeaderText="病人姓名";
            dgvExpenseInput.Columns["ApplyById"].Visible = false;
            dgvExpenseInput.Columns["ApplyByName"].HeaderText = "录入人员名称";
            dgvExpenseInput.Columns["ApplyByDate"].HeaderText = "录入日期";
            dgvExpenseInput.Columns["TotalAmount"].HeaderText = "单据合计";
            dgvExpenseInput.Columns["IsDelete"].Visible = false;
            dgvExpenseInput.Columns["IsPay"].Visible = false;
            dgvExpenseInput.Columns["IsPayDescr"].HeaderText = "是否支付";
        }
        private void button5_Click(object sender, EventArgs e)
        {
            PatientInfoList patientinfo = new PatientInfoList();
            patientinfo.ShowDialog();
            if (patientinfo.DialogResult == DialogResult.OK)
            {
                Patient patient = ExpenseInput.staPatientInfo;
                txtPatientID.Text = patient.Id.ToString();
                txtPatientName.Text = patient.Name;
                cmbSection.SelectedValue = patient.SectionId;
                cmbDoctor.SelectedValue = patient.DoctorId;
                cmbGender.SelectedValue = patient.Gender;
                txtAge.Text = patient.Age.ToString();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            ExpenseHeader eh = new ExpenseHeader();
            if (txtPatientID.Text.Trim() != "")
            {
                string strId = txtPatientID.Text.Trim().ToString();
                try
                {
                    eh.PatientId = Convert.ToInt32(strId);
                }
                catch
                {
                    ModuleBase.PullMessageBox("病人ID为数字类型,请重新输入");
                    return;
                }
            }
            else
            {
                eh.PatientId = 1;
            }

            DataSet ds = new DataSet();
            ds = ExpenseHeaderManager.GetExpenseHeader(eh);
            if (ds.Tables.Count > 0)
            {
                double dbltotal = 0.00;
                double dblTotalPayed = 0.00;
                double dblTotalNoPay = 0.00;
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    DataRow dr = ds.Tables[0].Rows[i];
                    dbltotal = dbltotal + Convert.ToDouble(dr["TotalAmount"]);
                    if (Convert.ToInt32(dr["IsPay"]) == 1)
                    {
                        dblTotalPayed = dblTotalPayed + Convert.ToDouble(dr["TotalAmount"]);
                    }
                    if (Convert.ToInt32(dr["IsPay"])  == 0)
                    {
                        dblTotalNoPay = dblTotalNoPay + Convert.ToDouble(dr["TotalAmount"]);
                    }
                }
                txtAllTotal.Text = dbltotal.ToString();
                txtAllTotalPayed.Text = dblTotalPayed.ToString();
                txtAllTotalNoPay.Text = dblTotalNoPay.ToString();
                BindDataSource(ds.Tables[0]);
            }
            else
            {
                MessageBox.Show("不存在记录！");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPatientID.Text = "";
            txtPatientName.Text = "";
            cmbSection.SelectedIndex = 0;
            cmbDoctor.SelectedIndex = 0;
            cmbGender.SelectedValue = 0;
            txtAge.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult DialogResult = MessageBox.Show("确认删除?", "提示信息", MessageBoxButtons.YesNo);
            if (DialogResult == DialogResult.Yes)
           {
               DataTable dt = (DataTable)dgvExpenseInput.DataSource;
               int RowIndex = dgvExpenseInput.CurrentCell.RowIndex;
               DataRow dr = dt.Rows[RowIndex];
               ExpenseHeader eh = new ExpenseHeader();
               eh.BillNo = dr["BillNo"].ToString();
               eh.ApplyById = dr["ApplyById"].ToString();
               eh.ApplyByDate = Convert.ToDateTime(dr["ApplyByDate"]);
               eh.PatientId = Convert.ToInt32(dr["PatientNo"]);
               eh.TotalAmount = Convert.ToDouble(dr["TotalAmount"]);
               eh.IsDelete = Convert.ToInt32(dr["IsDelete"]);
               eh.IsPay = Convert.ToInt32(dr["IsPay"]);
               DataSet ds = new DataSet();
               try
               {
                   ds = ExpenseHeaderManager.SaveExpenseHeader(eh, "3");
                   MessageBox.Show("删除成功!");
                   BindDataSource(ds.Tables[0]);
               }
               catch
               {
                   MessageBox.Show("删除失败");
               }
               
           }
        }

        private void dgvExpenseInput_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             DataTable dt = (DataTable)dgvExpenseInput.DataSource;
               int RowIndex = dgvExpenseInput.CurrentCell.RowIndex;
               DataRow dr = dt.Rows[RowIndex];
               ExpenseHeader eh = new ExpenseHeader();
               eh.BillNo = dr["BillNo"].ToString();
               eh.ApplyById = dr["ApplyById"].ToString();
               eh.ApplyByDate = Convert.ToDateTime(dr["ApplyByDate"]);
               eh.PatientId = Convert.ToInt32(dr["PatientNo"]);
               eh.TotalAmount = Convert.ToDouble(dr["TotalAmount"]);
               eh.IsDelete = Convert.ToInt32(dr["IsDelete"]);
               eh.IsPay = Convert.ToInt32(dr["IsPay"]);
               ExpenseEdit expenseedit = new ExpenseEdit(eh, "view");
               expenseedit.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtPatientID.Text.Trim() == "")
            {
                ModuleBase.PullMessageBox("请先要出院的病人信息");
                return;
            }

            Patient patient = new Patient();
            patient.Id = Convert.ToInt32(txtPatientID.Text);
            DataSet ds = new DataSet();
            ds= ExpenseHeaderManager.PayAllExpense(patient);

            BindDataSource(ds.Tables[0]);

            btnClear_Click(this, e);
        }

        private void chkPatientLeaveHospital_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPatientLeaveHospital.Checked)
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
