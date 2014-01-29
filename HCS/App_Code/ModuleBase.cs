using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HCS.Models;
using HCS.BLL;
using System.Data;
namespace HCS
{
    public class ModuleBase
    {
        private static string strUserId;
        private static string strUserName;
        private static string strUserPassword;

        public static string UserId
        {
            get { return strUserId; }
            set { strUserId = value; }
        }

        public static string UserName
        {
            get { return strUserName; }
            set { strUserName = value; }
        }

        public static string UserPassword
        {
            get { return strUserPassword; }
            set { strUserPassword = value; }

        }

        public static void BindDropDownList(ComboBox cbx, int InfoType)
        {
            SBaseInfo sbaseinfo = new SBaseInfo();
            sbaseinfo.Id = 1;
            sbaseinfo.Name = "";
            sbaseinfo.InfoType = InfoType;
            DataSet ds = SBaseInfoManager.GetSBaseInfo(sbaseinfo);
            DataRow dr = ds.Tables[0].NewRow();
            dr["Id"] = 0;
            dr["Name"] = "——";
            ds.Tables[0].Rows.InsertAt(dr, 0);
            cbx.DataSource = ds.Tables[0];
            cbx.ValueMember = "Id";
            cbx.DisplayMember = "Name";

        }
        public static void BindDropDownListH(ComboBox cbx, int InfoType,int sectionId)
        {
            HBaseInfo HBaseInfo = new HBaseInfo();
            HBaseInfo.Id = 1;
            HBaseInfo.Name = "";
            HBaseInfo.InfoType = InfoType;
            HBaseInfo.SectionId = sectionId;
            DataSet ds =HBaseInfoManager.GetHBaseInfo(HBaseInfo);
            DataRow dr = ds.Tables[0].NewRow();
            dr["InfoId"] = 0;
            dr["InfoName"] = "——";
            ds.Tables[0].Rows.InsertAt(dr, 0);
            cbx.DataSource = ds.Tables[0];
            cbx.ValueMember = "InfoId";
            cbx.DisplayMember = "InfoName";

        }

        //弹出提示框
        public static void PullMessageBox(string strMessages)
        {
            MessageBox.Show(strMessages, "提示信息");
        }

        public static DialogResult IsOrNotDeleteData()
        {
            DialogResult dr = MessageBox.Show("是否删除", "提示信息", MessageBoxButtons.OKCancel);
            return dr;
        }
    }
    public class ListItem
    {
        public ListItem()
        {
 
        }
        public ListItem(string strvalue, string strtext)
        {
            this.value1 = strvalue;
            this.text = strtext;
        }
        protected string value1;
        protected string text;

        public string Value
        {
            get { return value1; }
            set { value1=value; }
        }

        public string Text
        {
            get { return text; }
            set { text = value; }
        }
    }
}
