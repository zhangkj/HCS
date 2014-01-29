using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HCS.BLL;

namespace HCS
{
    public partial class RptSectionstatistics : Form
    {
        public RptSectionstatistics()
        {
            InitializeComponent();
            rdbByDay.Checked = true;
        }

        private void btnSelectRpt_Click(object sender, EventArgs e)
        {
            if (rdbByDay.Checked || rdbByMonth.Checked || rdbByYear.Checked)
            {
                string[] strArray = new string[1];
                string strRptFileName = "";
                if (rdbByDay.Checked)
                {
                    strArray[0] = "1";
                    strRptFileName = "RptSectionWorkByDay.rpt";
                }
                else if (rdbByMonth.Checked)
                {
                    strArray[0] = "2";
                    strRptFileName = "RptSectionWorkByMonth.rpt";
                }
                else if (rdbByYear.Checked)
                {
                    strArray[0] = "3";
                    strRptFileName = "RptSectionWorkByYear.rpt";
                }
                DataSet ds = new DataSet();
                ds = RptManager.GetRpt("HCS_GetRptSectionWork", strArray);
                RptShow rs = new RptShow(ds.Tables[0], strRptFileName);
                rs.ShowDialog();
            }
            else
            {
                MessageBox.Show("请选择查询统计类别!");
                return;
            }
        }
    }
}
