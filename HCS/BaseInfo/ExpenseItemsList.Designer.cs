namespace HCS
{
    partial class ExpenseItemsList
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
            this.label8 = new System.Windows.Forms.Label();
            this.txtSpellCode = new System.Windows.Forms.TextBox();
            this.dgvExpenseItem = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenseItem)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(274, 25);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(95, 26);
            this.btnSelect.TabIndex = 0;
            this.btnSelect.Text = "查询";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 16;
            this.label8.Text = "项目拼音";
            // 
            // txtSpellCode
            // 
            this.txtSpellCode.Location = new System.Drawing.Point(120, 25);
            this.txtSpellCode.Name = "txtSpellCode";
            this.txtSpellCode.Size = new System.Drawing.Size(137, 21);
            this.txtSpellCode.TabIndex = 15;
            // 
            // dgvExpenseItem
            // 
            this.dgvExpenseItem.AllowUserToAddRows = false;
            this.dgvExpenseItem.AllowUserToDeleteRows = false;
            this.dgvExpenseItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExpenseItem.Location = new System.Drawing.Point(22, 84);
            this.dgvExpenseItem.Name = "dgvExpenseItem";
            this.dgvExpenseItem.ReadOnly = true;
            this.dgvExpenseItem.RowTemplate.Height = 23;
            this.dgvExpenseItem.Size = new System.Drawing.Size(838, 337);
            this.dgvExpenseItem.TabIndex = 26;
            this.dgvExpenseItem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExpenseItem_CellClick);
            // 
            // ExpenseItemsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 435);
            this.Controls.Add(this.dgvExpenseItem);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSpellCode);
            this.Controls.Add(this.btnSelect);
            this.Name = "ExpenseItemsList";
            this.Text = "检疗项目维护";
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenseItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSpellCode;
        private System.Windows.Forms.DataGridView dgvExpenseItem;
    }
}