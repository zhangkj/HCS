namespace HCS
{
    partial class PatientList
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
            this.cmbNurseId = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.chkIsLeaveHospital = new System.Windows.Forms.CheckBox();
            this.dtpLeaveDate = new System.Windows.Forms.DateTimePicker();
            this.lblLeaveDate = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cmbSectionId = new System.Windows.Forms.ComboBox();
            this.cmbDoctorId = new System.Windows.Forms.ComboBox();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtRelativePeoplePhone = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtRelativePeopleName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.dtpRegisterDate = new System.Windows.Forms.DateTimePicker();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDoctorwords = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBedId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRoomNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.txtPatientId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.dgvPatientsList = new System.Windows.Forms.DataGridView();
            this.chkRecallPatient = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientsList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkRecallPatient);
            this.groupBox1.Controls.Add(this.cmbNurseId);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.chkIsLeaveHospital);
            this.groupBox1.Controls.Add(this.dtpLeaveDate);
            this.groupBox1.Controls.Add(this.lblLeaveDate);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.cmbSectionId);
            this.groupBox1.Controls.Add(this.cmbDoctorId);
            this.groupBox1.Controls.Add(this.txtRemark);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtRelativePeoplePhone);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtRelativePeopleName);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cmbGender);
            this.groupBox1.Controls.Add(this.dtpRegisterDate);
            this.groupBox1.Controls.Add(this.txtAge);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtDoctorwords);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtBedId);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtRoomNumber);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.btnNew);
            this.groupBox1.Controls.Add(this.txtPatientId);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPatientName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnSelect);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(896, 254);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "病人查询条件";
            // 
            // cmbNurseId
            // 
            this.cmbNurseId.FormattingEnabled = true;
            this.cmbNurseId.Location = new System.Drawing.Point(653, 114);
            this.cmbNurseId.Name = "cmbNurseId";
            this.cmbNurseId.Size = new System.Drawing.Size(100, 20);
            this.cmbNurseId.TabIndex = 48;
            this.cmbNurseId.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(575, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 12);
            this.label8.TabIndex = 47;
            this.label8.Text = "负责护士姓名";
            this.label8.Visible = false;
            // 
            // chkIsLeaveHospital
            // 
            this.chkIsLeaveHospital.AutoSize = true;
            this.chkIsLeaveHospital.Location = new System.Drawing.Point(497, 162);
            this.chkIsLeaveHospital.Name = "chkIsLeaveHospital";
            this.chkIsLeaveHospital.Size = new System.Drawing.Size(72, 16);
            this.chkIsLeaveHospital.TabIndex = 46;
            this.chkIsLeaveHospital.Text = "是否出院";
            this.chkIsLeaveHospital.UseVisualStyleBackColor = true;
            this.chkIsLeaveHospital.CheckedChanged += new System.EventHandler(this.chkIsLeaveHospital_CheckedChanged);
            // 
            // dtpLeaveDate
            // 
            this.dtpLeaveDate.Location = new System.Drawing.Point(653, 140);
            this.dtpLeaveDate.Name = "dtpLeaveDate";
            this.dtpLeaveDate.Size = new System.Drawing.Size(100, 21);
            this.dtpLeaveDate.TabIndex = 45;
            // 
            // lblLeaveDate
            // 
            this.lblLeaveDate.AutoSize = true;
            this.lblLeaveDate.Location = new System.Drawing.Point(575, 144);
            this.lblLeaveDate.Name = "lblLeaveDate";
            this.lblLeaveDate.Size = new System.Drawing.Size(53, 12);
            this.lblLeaveDate.TabIndex = 44;
            this.lblLeaveDate.Text = "出院时间";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(797, 206);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(53, 35);
            this.btnDelete.TabIndex = 42;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cmbSectionId
            // 
            this.cmbSectionId.FormattingEnabled = true;
            this.cmbSectionId.Location = new System.Drawing.Point(449, 23);
            this.cmbSectionId.Name = "cmbSectionId";
            this.cmbSectionId.Size = new System.Drawing.Size(100, 20);
            this.cmbSectionId.TabIndex = 39;
            this.cmbSectionId.TextChanged += new System.EventHandler(this.cmbSectionId_TextChanged);
            // 
            // cmbDoctorId
            // 
            this.cmbDoctorId.FormattingEnabled = true;
            this.cmbDoctorId.Location = new System.Drawing.Point(653, 26);
            this.cmbDoctorId.Name = "cmbDoctorId";
            this.cmbDoctorId.Size = new System.Drawing.Size(100, 20);
            this.cmbDoctorId.TabIndex = 38;
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(653, 83);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(204, 21);
            this.txtRemark.TabIndex = 36;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(575, 87);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 12);
            this.label14.TabIndex = 35;
            this.label14.Text = "备注";
            // 
            // txtRelativePeoplePhone
            // 
            this.txtRelativePeoplePhone.Location = new System.Drawing.Point(449, 85);
            this.txtRelativePeoplePhone.Name = "txtRelativePeoplePhone";
            this.txtRelativePeoplePhone.Size = new System.Drawing.Size(101, 21);
            this.txtRelativePeoplePhone.TabIndex = 34;
            this.txtRelativePeoplePhone.TextChanged += new System.EventHandler(this.txtRelativePeoplePhone_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(372, 89);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 33;
            this.label13.Text = "亲属电话";
            // 
            // txtRelativePeopleName
            // 
            this.txtRelativePeopleName.Location = new System.Drawing.Point(449, 56);
            this.txtRelativePeopleName.Name = "txtRelativePeopleName";
            this.txtRelativePeopleName.Size = new System.Drawing.Size(101, 21);
            this.txtRelativePeopleName.TabIndex = 32;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(384, 59);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 31;
            this.label12.Text = "亲属姓名";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(396, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 12);
            this.label11.TabIndex = 29;
            this.label11.Text = "科室";
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Location = new System.Drawing.Point(262, 54);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(100, 20);
            this.cmbGender.TabIndex = 28;
            // 
            // dtpRegisterDate
            // 
            this.dtpRegisterDate.Location = new System.Drawing.Point(653, 56);
            this.dtpRegisterDate.Name = "dtpRegisterDate";
            this.dtpRegisterDate.Size = new System.Drawing.Size(100, 21);
            this.dtpRegisterDate.TabIndex = 27;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(94, 53);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(101, 21);
            this.txtAge.TabIndex = 26;
            this.txtAge.TextChanged += new System.EventHandler(this.txtAge_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 25;
            this.label5.Text = "年龄";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(575, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 23;
            this.label10.Text = "入院时间";
            // 
            // txtDoctorwords
            // 
            this.txtDoctorwords.Location = new System.Drawing.Point(94, 111);
            this.txtDoctorwords.Multiline = true;
            this.txtDoctorwords.Name = "txtDoctorwords";
            this.txtDoctorwords.Size = new System.Drawing.Size(397, 92);
            this.txtDoctorwords.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 21;
            this.label9.Text = "医嘱";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(212, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 17;
            this.label7.Text = "性别";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(575, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 15;
            this.label6.Text = "主治医生姓名";
            // 
            // txtBedId
            // 
            this.txtBedId.Location = new System.Drawing.Point(262, 84);
            this.txtBedId.Name = "txtBedId";
            this.txtBedId.Size = new System.Drawing.Size(100, 21);
            this.txtBedId.TabIndex = 12;
            this.txtBedId.TextChanged += new System.EventHandler(this.txtBedId_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(212, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "床位号";
            // 
            // txtRoomNumber
            // 
            this.txtRoomNumber.Location = new System.Drawing.Point(94, 85);
            this.txtRoomNumber.Name = "txtRoomNumber";
            this.txtRoomNumber.Size = new System.Drawing.Size(100, 21);
            this.txtRoomNumber.TabIndex = 10;
            this.txtRoomNumber.TextChanged += new System.EventHandler(this.txtRoomNumber_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "房间号";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(734, 206);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(53, 35);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(665, 206);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(57, 35);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "修改";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(600, 206);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(55, 35);
            this.btnNew.TabIndex = 5;
            this.btnNew.Text = "新增";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtPatientId
            // 
            this.txtPatientId.Location = new System.Drawing.Point(94, 26);
            this.txtPatientId.Name = "txtPatientId";
            this.txtPatientId.Size = new System.Drawing.Size(100, 21);
            this.txtPatientId.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "病人ID";
            // 
            // txtPatientName
            // 
            this.txtPatientName.Location = new System.Drawing.Point(262, 26);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(100, 21);
            this.txtPatientName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "姓名";
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(499, 201);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(86, 52);
            this.btnSelect.TabIndex = 0;
            this.btnSelect.Text = "查询";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // dgvPatientsList
            // 
            this.dgvPatientsList.AllowUserToAddRows = false;
            this.dgvPatientsList.AllowUserToDeleteRows = false;
            this.dgvPatientsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatientsList.Location = new System.Drawing.Point(11, 272);
            this.dgvPatientsList.Name = "dgvPatientsList";
            this.dgvPatientsList.ReadOnly = true;
            this.dgvPatientsList.RowTemplate.Height = 23;
            this.dgvPatientsList.Size = new System.Drawing.Size(876, 265);
            this.dgvPatientsList.TabIndex = 2;
            this.dgvPatientsList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPatientsList_CellClick);
            // 
            // chkRecallPatient
            // 
            this.chkRecallPatient.AutoSize = true;
            this.chkRecallPatient.Location = new System.Drawing.Point(575, 162);
            this.chkRecallPatient.Name = "chkRecallPatient";
            this.chkRecallPatient.Size = new System.Drawing.Size(72, 16);
            this.chkRecallPatient.TabIndex = 49;
            this.chkRecallPatient.Text = "召回病人";
            this.chkRecallPatient.UseVisualStyleBackColor = true;
            this.chkRecallPatient.CheckedChanged += new System.EventHandler(this.chkRecallPatient_CheckedChanged);
            // 
            // PatientList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 559);
            this.Controls.Add(this.dgvPatientsList);
            this.Controls.Add(this.groupBox1);
            this.Name = "PatientList";
            this.Text = "病人信息维护";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientsList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.DataGridView dgvPatientsList;
        private System.Windows.Forms.TextBox txtPatientId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBedId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRoomNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.TextBox txtDoctorwords;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpRegisterDate;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.TextBox txtRelativePeoplePhone;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtRelativePeopleName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbSectionId;
        private System.Windows.Forms.ComboBox cmbDoctorId;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cmbNurseId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chkIsLeaveHospital;
        private System.Windows.Forms.DateTimePicker dtpLeaveDate;
        private System.Windows.Forms.Label lblLeaveDate;
        private System.Windows.Forms.CheckBox chkRecallPatient;

    }
}