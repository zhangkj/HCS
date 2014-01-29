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
    public partial class ExpenseEdit : Form
    {
        public ExpenseEdit()
        {
            InitializeComponent();
            ModuleBase.BindDropDownListH(cmbDoctor, 1, 1);
            ModuleBase.BindDropDownList(cmbSection, 1);
            ModuleBase.BindDropDownList(cmbGender, 2);
            InitControls();
            dtLine = new DataTable();
            txtApplyByName.Text = ModuleBase.UserName;
            txtApplyByName.Enabled = false;
            txtApplyById.Text = ModuleBase.UserId;
            txtApplyById.Visible = false;
            txtBillNo.Text = "<系统自动生成>";
            txtBillNo.Enabled = false;
            txtTotal.Text = "0";
            txtTotal.Enabled = false;
            InitRight();
        }
        private void InitRight()
        {
            //已支付的单据不能再修改和添加新的明细项
            if (chkIsPay.Checked)
            {
                btnAddExpenseItem.Enabled = false;
                btnChangeAmount.Enabled = false;
                btnDelete.Enabled = false;
                btnSave.Enabled = false;
            }
            else
            {
                btnAddExpenseItem.Enabled = true;
                btnChangeAmount.Enabled = true;
                btnDelete.Enabled = true;
                btnSave.Enabled = true;
            }
        }
          public static   DataTable dtHeader = new DataTable() ;
          public static DataTable dtLine;
        //strOpenType：view/add/edit
        public ExpenseEdit(ExpenseHeader expenseheader, string strOpenType)
        {
            //控件初始化
            InitializeComponent();
            
            ModuleBase.BindDropDownListH(cmbDoctor,1,1);
            ModuleBase.BindDropDownList(cmbSection, 1);
            ModuleBase.BindDropDownList(cmbGender,2);
            dtLine = new DataTable();
            txtApplyByName.Enabled = false;
            txtApplyById.Visible = false;
            dtpApplyByDate.Enabled = false;
            txtBillNo.Enabled = false;
            txtTotal.Enabled = false;
            txtPatientID.Enabled = false;
            btnSelectPatientInfo.Enabled = false;
            

            //获取主单据信息和明细信息
            DataSet ds = new DataSet();
            ds = ExpenseHeaderManager.GetExpenseHeaderEdit(expenseheader);
            dtHeader = ds.Tables[0];
            dtLine = ds.Tables[1];

            txtBillNo.Text = expenseheader.BillNo;
            txtApplyById.Text = expenseheader.ApplyById.ToString();
            txtApplyByName.Text = dtHeader.Rows[0]["ApplyByName"].ToString();
            dtpApplyByDate.Text = expenseheader.ApplyByDate.ToString();
            txtTotal.Text = expenseheader.TotalAmount.ToString();
            chkIsPay.Checked = Convert.ToBoolean(expenseheader.IsPay);

            //病人信息
            txtPatientID.Text = dtHeader.Rows[0]["PId"].ToString();
            txtPatientName.Text = dtHeader.Rows[0]["PName"].ToString();
            txtAge.Text = dtHeader.Rows[0]["PAge"].ToString();
            cmbGender.SelectedValue = dtHeader.Rows[0]["PGender"].ToString();
            cmbSection.SelectedValue = dtHeader.Rows[0]["PSectionId"].ToString();
            cmbDoctor.SelectedValue = dtHeader.Rows[0]["PDoctorId"].ToString();
            DataView dv = dtLine.DefaultView;
            BindDataSource(dv);

            InitRight();

            if (strOpenType == "view")
            {

                //TODO;呈现明细查看画面
            }
            else if (strOpenType == "edit")
            {
                //TODO;呈现修改画面
                
            }
            
        }
        
        public static Patient staPatientInfo;
        public static int  intAmount;
        //初始化明细表结构
        public void InitControls()
        {

            ExpenseInput.dtLine.Columns.Add("ItemNo", typeof(string));
            ExpenseInput.dtLine.Columns.Add("ItemName", typeof(string));
            ExpenseInput.dtLine.Columns.Add("SalePrice", typeof(double));
            ExpenseInput.dtLine.Columns.Add("Amount", typeof(int));
            ExpenseInput.dtLine.Columns.Add("IsDelete", typeof(int));
            ExpenseInput.dtLine.Columns.Add("id", typeof(int));
        }
        

        //为DataGridView绑定数据源，并筛选可现实列
        private void BindDataSource(DataView dv)
        {
            dgvExpenseInput.DataSource = dv;
            dgvExpenseInput.Columns["ItemNo"].HeaderText = "项目编号";
            dgvExpenseInput.Columns["ItemName"].HeaderText = "项目名称";
            dgvExpenseInput.Columns["ItemStandardId"].Visible = false;
            dgvExpenseInput.Columns["ItemStandardDescr"].HeaderText = "规格";
            dgvExpenseInput.Columns["ItemUnitId"].Visible = false;
            dgvExpenseInput.Columns["ItemUnitDescr"].HeaderText = "单位";
            dgvExpenseInput.Columns["SalePrice"].HeaderText = "价格";
            dgvExpenseInput.Columns["Amount"].HeaderText = "数量";
            dgvExpenseInput.Columns["SectionId"].Visible = false;
            dgvExpenseInput.Columns["SectionName"].HeaderText = "科室";
            dgvExpenseInput.Columns["Id"].Visible = false;
            dgvExpenseInput.Columns["IsDelete"].Visible = false;
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
                cmbGender.SelectedValue = staPatientInfo.Gender.ToString();
                txtAge.Text = staPatientInfo.Age.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ExpenseItemsList eil = new ExpenseItemsList("edit");
            eil.ShowDialog();
            
            if (eil.DialogResult == DialogResult.OK)
            {

                DataView dv = dtLine.DefaultView;
                dv.RowFilter = "IsDelete=0";
                dgvExpenseInput.DataSource = dv;
            }
            GetTotal();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (dgvExpenseInput.Rows.Count <= 0)
            {
                MessageBox.Show("没有选中行,无法修改数量");
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
            dgvExpenseInput.DataSource = dv;
            GetTotal();
        }
        /// <summary>
        /// 计算所有检疗项目总费用
        /// </summary>
        public void  GetTotal()
        {
            double dblTotal=0.00;
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
            string strChangedType = "2";
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
            if (dgvExpenseInput.Rows.Count <= 0)
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
            DataView dataview = (DataView)dgvExpenseInput.DataSource;
            idindex = Convert.ToInt32(dataview[RowIndex]["Id"]);
            for(int i =0;i<dtLine.Rows.Count;i++)
            {
                if (Convert.ToInt32(dtLine.Rows[i]["id"]) == idindex)
                {
                    dtLine.Rows[i]["IsDelete"] = 1;
                    break;
                }
            }


            DataView dv = dtLine.DefaultView;
            dv.RowFilter="IsDelete =0";
            dgvExpenseInput.DataSource = dv;
            GetTotal();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
           //TODO; 根据输入的检疗项目拼音简写，动态呈现符合条件的数据
        }

     
    }
}
