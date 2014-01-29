namespace HCS
{
    partial class ExpenseInput
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBillNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPatientID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtApplyByName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpApplyByDate = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.cmbDoctor = new System.Windows.Forms.ComboBox();
            this.cmbSection = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvExpenseInput = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.chkIsPay = new System.Windows.Forms.CheckBox();
            this.txtApplyById = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenseInput)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "收费单号";
            // 
            // txtBillNo
            // 
            this.txtBillNo.Location = new System.Drawing.Point(76, 36);
            this.txtBillNo.Name = "txtBillNo";
            this.txtBillNo.Size = new System.Drawing.Size(114, 21);
            this.txtBillNo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "录入时间";
            // 
            // txtPatientID
            // 
            this.txtPatientID.Location = new System.Drawing.Point(59, 9);
            this.txtPatientID.Name = "txtPatientID";
            this.txtPatientID.Size = new System.Drawing.Size(100, 21);
            this.txtPatientID.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "病人ID";
            // 
            // txtApplyByName
            // 
            this.txtApplyByName.Location = new System.Drawing.Point(76, 63);
            this.txtApplyByName.Name = "txtApplyByName";
            this.txtApplyByName.Size = new System.Drawing.Size(114, 21);
            this.txtApplyByName.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "收费员";
            // 
            // dtpApplyByDate
            // 
            this.dtpApplyByDate.Location = new System.Drawing.Point(76, 90);
            this.dtpApplyByDate.Name = "dtpApplyByDate";
            this.dtpApplyByDate.Size = new System.Drawing.Size(114, 21);
            this.dtpApplyByDate.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.cmbDoctor);
            this.panel1.Controls.Add(this.cmbSection);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtGender);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtAge);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtPatientName);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtPatientID);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(212, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(501, 111);
            this.panel1.TabIndex = 10;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(351, 66);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(121, 38);
            this.button5.TabIndex = 31;
            this.button5.Text = "点击选择病人信息";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // cmbDoctor
            // 
            this.cmbDoctor.FormattingEnabled = true;
            this.cmbDoctor.Location = new System.Drawing.Point(373, 36);
            this.cmbDoctor.Name = "cmbDoctor";
            this.cmbDoctor.Size = new System.Drawing.Size(121, 20);
            this.cmbDoctor.TabIndex = 22;
            // 
            // cmbSection
            // 
            this.cmbSection.FormattingEnabled = true;
            this.cmbSection.Location = new System.Drawing.Point(373, 9);
            this.cmbSection.Name = "cmbSection";
            this.cmbSection.Size = new System.Drawing.Size(121, 20);
            this.cmbSection.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(338, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 17;
            this.label10.Text = "科室";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(338, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 13;
            this.label8.Text = "医生";
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(211, 33);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(100, 21);
            this.txtGender.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(165, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 11;
            this.label7.Text = "性别";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(59, 66);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 21);
            this.txtAge.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "年龄";
            // 
            // txtPatientName
            // 
            this.txtPatientName.Location = new System.Drawing.Point(59, 36);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(100, 21);
            this.txtPatientName.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "姓名";
            // 
            // dgvExpenseInput
            // 
            this.dgvExpenseInput.AllowUserToAddRows = false;
            this.dgvExpenseInput.AllowUserToDeleteRows = false;
            this.dgvExpenseInput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExpenseInput.Location = new System.Drawing.Point(12, 206);
            this.dgvExpenseInput.Name = "dgvExpenseInput";
            this.dgvExpenseInput.ReadOnly = true;
            this.dgvExpenseInput.RowTemplate.Height = 23;
            this.dgvExpenseInput.Size = new System.Drawing.Size(809, 266);
            this.dgvExpenseInput.TabIndex = 11;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(70, 155);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 38);
            this.button3.TabIndex = 24;
            this.button3.Text = "检疗项目";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtTotal.Location = new System.Drawing.Point(285, 158);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(121, 30);
            this.txtTotal.TabIndex = 26;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(229, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 19);
            this.label9.TabIndex = 25;
            this.label9.Text = "总计：";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(2, 133);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(209, 12);
            this.label12.TabIndex = 27;
            this.label12.Text = "输入项目编号或点击检疗项目按钮选择";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(644, 478);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 40);
            this.button2.TabIndex = 29;
            this.button2.Text = "删除";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(732, 478);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 41);
            this.button1.TabIndex = 28;
            this.button1.Text = "返回";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(541, 479);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 40);
            this.btnSave.TabIndex = 30;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(35, 479);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 40);
            this.button6.TabIndex = 31;
            this.button6.Text = "改数量";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // chkIsPay
            // 
            this.chkIsPay.AutoSize = true;
            this.chkIsPay.Location = new System.Drawing.Point(432, 167);
            this.chkIsPay.Name = "chkIsPay";
            this.chkIsPay.Size = new System.Drawing.Size(84, 16);
            this.chkIsPay.TabIndex = 32;
            this.chkIsPay.Text = "是否已支付";
            this.chkIsPay.UseVisualStyleBackColor = true;
            // 
            // txtApplyById
            // 
            this.txtApplyById.AutoSize = true;
            this.txtApplyById.Location = new System.Drawing.Point(59, 66);
            this.txtApplyById.Name = "txtApplyById";
            this.txtApplyById.Size = new System.Drawing.Size(11, 12);
            this.txtApplyById.TabIndex = 33;
            this.txtApplyById.Text = "0";
            // 
            // ExpenseInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 530);
            this.Controls.Add(this.txtApplyById);
            this.Controls.Add(this.chkIsPay);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dgvExpenseInput);
            this.Controls.Add(this.dtpApplyByDate);
            this.Controls.Add(this.txtApplyByName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBillNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "ExpenseInput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "费用录入";
            this.Load += new System.EventHandler(this.ExpenseInput_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenseInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBillNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPatientID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtApplyByName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpApplyByDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvExpenseInput;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox cmbDoctor;
        private System.Windows.Forms.ComboBox cmbSection;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.CheckBox chkIsPay;
        private System.Windows.Forms.Label txtApplyById;
    }
}