using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HCS.Models;

namespace HCS
{
    public partial class ChangeAmount : Form
    {
        public ChangeAmount()
        {
            InitializeComponent();
        }
        public ChangeAmount(DataRow dr)
        {
            InitializeComponent();
            txtExpenseItem.Text = dr["ItemName"].ToString();
            txtAmount.Text = dr["Amount"].ToString();
            txtExpenseItem.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {      
            ExpenseInput.intAmount = Convert.ToInt32(txtAmount.Text);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
