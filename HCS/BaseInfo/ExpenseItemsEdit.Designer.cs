namespace HCS
{
    partial class ExpenseItemsEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSelect = new System.Windows.Forms.Button();
            this.cmbSection = new System.Windows.Forms.ComboBox();
            this.txtSelectCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtItemNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSalePrice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSpellCode = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblCurInventory = new System.Windows.Forms.Label();
            this.txtCurInventory = new System.Windows.Forms.TextBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cmbItemStandard = new System.Windows.Forms.ComboBox();
            this.dgvExpenseItem = new System.Windows.Forms.DataGridView();
            this.cmbItemUnit = new System.Windows.Forms.ComboBox();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenseItem)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(449, 12);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 0;
            this.btnSelect.Text = "查询";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // cmbSection
            // 
            this.cmbSection.FormattingEnabled = true;
            this.cmbSection.Location = new System.Drawing.Point(91, 86);
            this.cmbSection.Name = "cmbSection";
            this.cmbSection.Size = new System.Drawing.Size(100, 20);
            this.cmbSection.TabIndex = 1;
            // 
            // txtSelectCode
            // 
            this.txtSelectCode.Location = new System.Drawing.Point(206, 9);
            this.txtSelectCode.Name = "txtSelectCode";
            this.txtSelectCode.Size = new System.Drawing.Size(186, 21);
            this.txtSelectCode.TabIndex = 2;
            this.txtSelectCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "输入拼音查询码——》";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "科室";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(212, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "项目名称";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "项目编号";
            // 
            // txtItemNo
            // 
            this.txtItemNo.Location = new System.Drawing.Point(91, 56);
            this.txtItemNo.Name = "txtItemNo";
            this.txtItemNo.Size = new System.Drawing.Size(100, 21);
            this.txtItemNo.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(212, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "项目规格";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(404, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 14;
            this.label7.Text = "销售单价";
            // 
            // txtSalePrice
            // 
            this.txtSalePrice.Location = new System.Drawing.Point(485, 56);
            this.txtSalePrice.Name = "txtSalePrice";
            this.txtSalePrice.Size = new System.Drawing.Size(100, 21);
            this.txtSalePrice.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(608, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 16;
            this.label8.Text = "项目拼音";
            // 
            // txtSpellCode
            // 
            this.txtSpellCode.Location = new System.Drawing.Point(687, 56);
            this.txtSpellCode.Name = "txtSpellCode";
            this.txtSpellCode.Size = new System.Drawing.Size(100, 21);
            this.txtSpellCode.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(404, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 18;
            this.label9.Text = "项目单位";
            // 
            // lblCurInventory
            // 
            this.lblCurInventory.AutoSize = true;
            this.lblCurInventory.Location = new System.Drawing.Point(608, 93);
            this.lblCurInventory.Name = "lblCurInventory";
            this.lblCurInventory.Size = new System.Drawing.Size(53, 12);
            this.lblCurInventory.TabIndex = 20;
            this.lblCurInventory.Text = "当前库存";
            // 
            // txtCurInventory
            // 
            this.txtCurInventory.Location = new System.Drawing.Point(687, 88);
            this.txtCurInventory.Name = "txtCurInventory";
            this.txtCurInventory.Size = new System.Drawing.Size(100, 21);
            this.txtCurInventory.TabIndex = 19;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(540, 12);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 21;
            this.btnNew.Text = "新增";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(625, 12);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 22;
            this.btnEdit.Text = "修改";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(712, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cmbItemStandard
            // 
            this.cmbItemStandard.FormattingEnabled = true;
            this.cmbItemStandard.Location = new System.Drawing.Point(271, 87);
            this.cmbItemStandard.Name = "cmbItemStandard";
            this.cmbItemStandard.Size = new System.Drawing.Size(100, 20);
            this.cmbItemStandard.TabIndex = 25;
            // 
            // dgvExpenseItem
            // 
            this.dgvExpenseItem.AllowUserToAddRows = false;
            this.dgvExpenseItem.AllowUserToDeleteRows = false;
            this.dgvExpenseItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExpenseItem.Location = new System.Drawing.Point(26, 177);
            this.dgvExpenseItem.Name = "dgvExpenseItem";
            this.dgvExpenseItem.ReadOnly = true;
            this.dgvExpenseItem.RowTemplate.Height = 23;
            this.dgvExpenseItem.Size = new System.Drawing.Size(838, 337);
            this.dgvExpenseItem.TabIndex = 26;
            this.dgvExpenseItem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExpenseItem_CellClick);
            // 
            // cmbItemUnit
            // 
            this.cmbItemUnit.FormattingEnabled = true;
            this.cmbItemUnit.Location = new System.Drawing.Point(485, 86);
            this.cmbItemUnit.Name = "cmbItemUnit";
            this.cmbItemUnit.Size = new System.Drawing.Size(100, 20);
            this.cmbItemUnit.TabIndex = 27;
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(271, 56);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(100, 21);
            this.txtItemName.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 30;
            this.label2.Text = "备注";
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(91, 124);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(280, 21);
            this.txtRemark.TabIndex = 29;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(406, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 33);
            this.button1.TabIndex = 31;
            this.button1.Text = "清空信息";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ExpenseItemsEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 526);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.cmbItemUnit);
            this.Controls.Add(this.dgvExpenseItem);
            this.Controls.Add(this.cmbItemStandard);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.lblCurInventory);
            this.Controls.Add(this.txtCurInventory);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSpellCode);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSalePrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtItemNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSelectCode);
            this.Controls.Add(this.cmbSection);
            this.Controls.Add(this.btnSelect);
            this.Name = "ExpenseItemsEdit";
            this.Text = "检疗项目维护";
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenseItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.ComboBox cmbSection;
        private System.Windows.Forms.TextBox txtSelectCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtItemNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSalePrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSpellCode;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblCurInventory;
        private System.Windows.Forms.TextBox txtCurInventory;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cmbItemStandard;
        private System.Windows.Forms.DataGridView dgvExpenseItem;
        private System.Windows.Forms.ComboBox cmbItemUnit;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Button button1;
    }
}