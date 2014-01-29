namespace HCS
{
    partial class RptPatientExpense
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbByYear = new System.Windows.Forms.RadioButton();
            this.rdbByMonth = new System.Windows.Forms.RadioButton();
            this.btnSelectRpt = new System.Windows.Forms.Button();
            this.rdbByDay = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbByYear);
            this.groupBox1.Controls.Add(this.rdbByMonth);
            this.groupBox1.Controls.Add(this.btnSelectRpt);
            this.groupBox1.Controls.Add(this.rdbByDay);
            this.groupBox1.Location = new System.Drawing.Point(13, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 138);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "病人费用统计";
            // 
            // rdbByYear
            // 
            this.rdbByYear.AutoSize = true;
            this.rdbByYear.Location = new System.Drawing.Point(64, 93);
            this.rdbByYear.Name = "rdbByYear";
            this.rdbByYear.Size = new System.Drawing.Size(71, 16);
            this.rdbByYear.TabIndex = 6;
            this.rdbByYear.TabStop = true;
            this.rdbByYear.Text = "按年统计";
            this.rdbByYear.UseVisualStyleBackColor = true;
            // 
            // rdbByMonth
            // 
            this.rdbByMonth.AutoSize = true;
            this.rdbByMonth.Location = new System.Drawing.Point(64, 60);
            this.rdbByMonth.Name = "rdbByMonth";
            this.rdbByMonth.Size = new System.Drawing.Size(71, 16);
            this.rdbByMonth.TabIndex = 5;
            this.rdbByMonth.TabStop = true;
            this.rdbByMonth.Text = "按月统计";
            this.rdbByMonth.UseVisualStyleBackColor = true;
            // 
            // btnSelectRpt
            // 
            this.btnSelectRpt.Location = new System.Drawing.Point(192, 75);
            this.btnSelectRpt.Name = "btnSelectRpt";
            this.btnSelectRpt.Size = new System.Drawing.Size(70, 53);
            this.btnSelectRpt.TabIndex = 0;
            this.btnSelectRpt.Text = "查询报表";
            this.btnSelectRpt.UseVisualStyleBackColor = true;
            this.btnSelectRpt.Click += new System.EventHandler(this.btnSelectRpt_Click);
            // 
            // rdbByDay
            // 
            this.rdbByDay.AutoSize = true;
            this.rdbByDay.Location = new System.Drawing.Point(64, 20);
            this.rdbByDay.Name = "rdbByDay";
            this.rdbByDay.Size = new System.Drawing.Size(71, 16);
            this.rdbByDay.TabIndex = 4;
            this.rdbByDay.TabStop = true;
            this.rdbByDay.Text = "按日统计";
            this.rdbByDay.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(10, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 14);
            this.label1.TabIndex = 8;
            this.label1.Text = "病人费用统计分别可按天、月、年类别统计，请选择类别：";
            // 
            // RptPatientExpense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 330);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "RptPatientExpense";
            this.Text = "病人费用统计报表";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbByYear;
        private System.Windows.Forms.RadioButton rdbByMonth;
        private System.Windows.Forms.Button btnSelectRpt;
        private System.Windows.Forms.RadioButton rdbByDay;
        private System.Windows.Forms.Label label1;
    }
}