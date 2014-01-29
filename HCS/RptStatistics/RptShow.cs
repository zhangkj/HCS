using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using CrystalDecisions.CrystalReports.Engine;
using System.IO;

namespace HCS
{
    public partial class RptShow : Form
    {
        public RptShow()
        {
            InitializeComponent();
        }
        public ReportDocument reportDoc = new ReportDocument();
        public string strAppPath = Application.StartupPath;
        public RptShow(DataTable dt,string strRportPath)
        {
            InitializeComponent();
            if(File.Exists(strAppPath+"\\"+strRportPath))
            {
               reportDoc.Load(strAppPath+"\\"+ strRportPath);
                reportDoc.SetDataSource(dt);

                RptView.ReportSource = reportDoc;
            }
            else
            {
                 MessageBox.Show("您请求打开的报表模版不存在！");
            }
            
        }
    }
}
