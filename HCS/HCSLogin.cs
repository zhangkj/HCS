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
    public partial class HCSLogin : Form
    {
        public HCSLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!CheckText())
            {
                return;
            }
            UserInfo userinfo = new UserInfo();
            userinfo.UserName = txtUserID.Text;
            userinfo.UserPassword = txtPassword.Text;

            DataSet ds = new DataSet();

            ds = UserInfoManager.GetUserInfo(userinfo);

            if (ds.Tables[0].Rows.Count > 0)
            {
                this.DialogResult = DialogResult.OK;
                DataRow dr = ds.Tables[0].Rows[0];
                ModuleBase.UserId = dr["UserId"].ToString();
                ModuleBase.UserName = dr["UserName"].ToString();
                ModuleBase.UserPassword = dr["UserPassword"].ToString();
            }
            else
            {
                ModuleBase.PullMessageBox("用户名或密码不正确");
                return;
            }

        }

        private bool CheckText()
        {
            if (txtUserID.Text.Trim() == "")
            {
                ModuleBase.PullMessageBox("请输入用户名");
                txtUserID.Focus();
                return false;
            }

            return true;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
