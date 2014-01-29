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
    public partial class ExpenseInput : Form
    {
        public static Patient staPatientInfo;
        public static DataTable dtLine;
        public static int intAmount;
        public ExpenseInput()
        {
            InitializeComponent();
            ModuleBase.BindDropDownListH(cmbDoctor, 1, 1);
            ModuleBase.BindDropDownList(cmbSection, 1);
            dtLine = new DataTable();
            txtBillNo.Text = "<系统自动生成>";
            txtApplyByName.Text = ModuleBase.UserName;
            txtApplyByName.Enabled = false;
            txtApplyById.Text = ModuleBase.UserId;
            txtApplyById.Visible = false;
            txtBillNo.Enabled = false;
            txtTotal.Text = "0";
            txtTotal.Enabled = false;
            txtPatientID.Enabled = false;
            InitControls();
        }
        //初始化DataTable
        public void  InitControls()
        {
            dtLine.Columns.Add("ItemNo", typeof(string));
            dtLine.Columns.Add("ItemName", typeof(string));
            dtLine.Columns.Add("SalePrice", typeof(double));
            dtLine.Columns.Add("Amount", typeof(int));
            dtLine.Columns.Add("IsDelete", typeof(int));
            dtLine.Columns.Add("id", typeof(int));
        }
        //绑定检疗项目名称
        private void BindDataSource(DataView dv)
        {
            dgvExpenseInput.DataSource = dv;
            dgvExpenseInput.Columns["ItemNo"].HeaderText = "项目编号";
            dgvExpenseInput.Columns["ItemName"].HeaderText = "项目名称";
            dgvExpenseInput.Columns["SalePrice"].HeaderText = "价格";
            dgvExpenseInput.Columns["Amount"].HeaderText = "数量";
            dgvExpenseInput.Columns["IsDelete"].Visible = false;
            dgvExpenseInput.Columns["Id"].HeaderText = "行号";
        }
     
        private void ExpenseInput_Load(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PatientInfoList patientinfo = new PatientInfoList();
            patientinfo.ShowDialog();
            if (patientinfo.DialogResult == DialogResult.OK)
            {
                txtPatientID.Text = staPatientInfo.Id.ToString();
                txtPatientName.Text = staPatientInfo.Name;
                cmbSection.SelectedValue = staPatientInfo.SectionId;
                cmbDoctor.SelectedValue = staPatientInfo.DoctorId;
                txtGender.Text = staPatientInfo.Gender.ToString();
                txtAge.Text = staPatientInfo.Age.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ExpenseItemsList eil = new ExpenseItemsList("new");
            eil.ShowDialog();
            
            if (eil.DialogResult == DialogResult.OK)
            {
                DataView dv = dtLine.DefaultView;
                dv.RowFilter = "IsDelete=0";
                BindDataSource(dv);
            }
            GetTotal();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (dgvExpenseInput.Rows.Count <= 0)
            {
                MessageBox.Show("没有选中行,无法删除");
                return;
            }
            int idindex;
            if (dgvExpenseInput.DataSource is DataTable)
            {
                DataTable dt = (DataTable)dgvExpenseInput.DataSource;
                int RowIndex = dgvExpenseInput.CurrentCell.RowIndex;
                idindex = Convert.ToInt32(dt.Rows[RowIndex]["id"]);
            }
            else
            {
                DataView dt = (DataView)dgvExpenseInput.DataSource;

                int RowIndex = dgvExpenseInput.CurrentCell.RowIndex;
                idindex = Convert.ToInt32(dt[RowIndex]["id"]);
            }
            for (int i = 0; i < dtLine.Rows.Count; i++)
            {
                if (Convert.ToInt32(dtLine.Rows[i]["id"]) == idindex)
                {
                    ChangeAmount ca = new ChangeAmount(dtLine.Rows[i]);
                    ca.ShowDialog();
                    if (ca.DialogResult == DialogResult.OK)
                    {
                        dtLine.Rows[i]["Amount"] = intAmount;
                    }
                    break;
                }
            }
            DataView dv = dtLine.DefaultView;
            dv.RowFilter = "IsDelete =0";
            BindDataSource(dv);
            GetTotal();
        }

        public void  GetTotal()
        {
            double dblTotal = 0.00;
            foreach (DataRow dr in dtLine.Rows)
            {
                if (Convert.ToInt32(dr["IsDelete"]) != 1)
                {
                    dblTotal += Convert.ToDouble(dr["SalePrice"]) * Convert.ToInt32(dr["Amount"]);
                }
            }

            txtTotal.Text = dblTotal.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dtLine.Rows.Count == 0)
            {
                MessageBox.Show("这少输如一条检疗项目");
                return;
            }
            if (txtPatientID.Text.Trim() == "")
            {
                MessageBox.Show("病人信息不能为空");
                return;
            }
            ExpenseHeader eh = new ExpenseHeader();
            eh.BillNo = txtBillNo.Text.ToString();
            eh.ApplyById = txtApplyById.Text;
            eh.ApplyByDate = Convert.ToDateTime(dtpApplyByDate.Text);
            eh.PatientId = Convert.ToInt32(txtPatientID.Text);
            eh.TotalAmount = Convert.ToDouble(txtTotal.Text);
            eh.IsDelete = 0;
            eh.IsPay = Convert.ToInt32(chkIsPay.Checked);
            //1为插入，2为更新，3为删除
            string strChangedType = "1";
            DataSet ds = new DataSet();
            string strMessage =   ExpenseHeaderManager.SaveExpenseHeader(eh, dtLine, strChangedType);
            MessageBox.Show(strMessage);
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            int idindex;
            if (dgvExpenseInput.Rows.Count<=0)
            {
                MessageBox.Show("没有选中行,无法删除");
                return;
            }
            DialogResult dr = MessageBox.Show("确认删除？", "提示信息", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.Cancel)
            {
                return;
            }
            int RowIndex = dgvExpenseInput.CurrentCell.RowIndex;
            if (dgvExpenseInput.DataSource is DataView)
            {
                DataView dataview = (DataView)dgvExpenseInput.DataSource;
                idindex = Convert.ToInt32(dataview[RowIndex]["Id"]);
            }
            else
            {
                DataTable dt = (DataTable)dgvExpenseInput.DataSource;
                idindex = Convert.ToInt32(dt.Rows[RowIndex]["id"]);
            }
            for (int i = 0; i < dtLine.Rows.Count; i++)
            {
                if (Convert.ToInt32(dtLine.Rows[i]["id"]) == idindex)
                {
                    dtLine.Rows[i]["IsDelete"] = 1;
                    break;
                }
            }


            DataView dv = dtLine.DefaultView;
            dv.RowFilter = "IsDelete =0";
            BindDataSource(dv);
            GetTotal();
        }


       
    }
}
