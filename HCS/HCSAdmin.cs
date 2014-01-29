using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HCS
{
    public partial class HCSAdmin : Form
    {
        public HCSAdmin()
        {
            InitializeComponent();
        }
        public HCSAdmin(string strUserName)
        {
            InitializeComponent();
            tslblUserName.Text = strUserName;
            tsbtnLoginDate.Text = DateTime.Now.ToString();
        }
        private void 费用挂历ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 科室信息维护ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SectionInfoEdit sectionInfo = new SectionInfoEdit();
            sectionInfo.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

            PatientList patientlist = new PatientList();
            patientlist.Show();
        }

        private void 检疗项目维护ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExpenseItemsEdit ei = new ExpenseItemsEdit();
            ei.Show();
        }

        private void tsbAdmin_Click(object sender, EventArgs e)
        {
            ExpenseInput expenseinput = new ExpenseInput();
            expenseinput.Show();
        }

        private void 病人费用查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExpenseList expenselist = new ExpenseList();
            expenselist.Show();
        }

        private void tsmiDoctorBaseInfo_Click(object sender, EventArgs e)
        {
            DoctorInfoEdit die = new DoctorInfoEdit();
            die.Show();
        }

        private void tsmiPatientInfo_Click(object sender, EventArgs e)
        {
            PatientList patientlist = new PatientList();
            patientlist.Show();
        }

        private void SectionFigureRpt_Click(object sender, EventArgs e)
        {
            RptSectionFigures rsf = new RptSectionFigures();
            rsf.ShowDialog();
        }

        private void PatientExpenseRpt_Click(object sender, EventArgs e)
        {
            RptPatientExpense rpe = new RptPatientExpense();
            rpe.ShowDialog();
        }

        private void 费用录入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExpenseInput expenseinput = new ExpenseInput();
            expenseinput.Show();
        }

        private void tsbAccount_Click(object sender, EventArgs e)
        {
            ExpenseList el = new ExpenseList();
            el.ShowDialog();
        }

        private void tsmiItemStandard_Click(object sender, EventArgs e)
        {
            ItemStandardinfoEdit sie = new ItemStandardinfoEdit();
            sie.ShowDialog();
        }

        private void tsmiItemUnit_Click(object sender, EventArgs e)
        {
            ItemUnitInfoEdit iue = new ItemUnitInfoEdit();
            iue.ShowDialog();
        }

        private void tsmiSystemUserEdit_Click(object sender, EventArgs e)
        {

        }

        private void 病人结账ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExpenseList el = new ExpenseList();
            el.ShowDialog();
        }

        private void SectionStatisticsRpt_Click(object sender, EventArgs e)
        {
            RptSectionstatistics rss = new RptSectionstatistics();
            rss.ShowDialog();
        }


    }
}
