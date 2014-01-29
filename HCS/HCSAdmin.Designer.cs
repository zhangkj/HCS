namespace HCS
{
    partial class HCSAdmin
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HCSAdmin));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.基本资料ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.科室信息维护ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.检疗项目维护ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDoctorBaseInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiItemStandard = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiItemUnit = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIRegisterManager = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPatientInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHospitalManager = new System.Windows.Forms.ToolStripMenuItem();
            this.费用录入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.病人费用查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIFinanceMananger = new System.Windows.Forms.ToolStripMenuItem();
            this.病人结账ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.统计报表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SectionStatisticsRpt = new System.Windows.Forms.ToolStripMenuItem();
            this.SectionFigureRpt = new System.Windows.Forms.ToolStripMenuItem();
            this.PatientExpenseRpt = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuTools = new System.Windows.Forms.ToolStrip();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.tsbAdmin = new System.Windows.Forms.ToolStripButton();
            this.tsbAccount = new System.Windows.Forms.ToolStripButton();
            this.tsLoginInfo = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tslblUserName = new System.Windows.Forms.ToolStripLabel();
            this.dfdsf = new System.Windows.Forms.ToolStripButton();
            this.tsbtnLoginDate = new System.Windows.Forms.ToolStripLabel();
            this.menuStrip1.SuspendLayout();
            this.tsMenuTools.SuspendLayout();
            this.tsLoginInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.基本资料ToolStripMenuItem,
            this.TSMIRegisterManager,
            this.tsmiHospitalManager,
            this.TSMIFinanceMananger,
            this.统计报表ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(794, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 基本资料ToolStripMenuItem
            // 
            this.基本资料ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.科室信息维护ToolStripMenuItem,
            this.检疗项目维护ToolStripMenuItem,
            this.tsmiDoctorBaseInfo,
            this.tsmiItemStandard,
            this.tsmiItemUnit});
            this.基本资料ToolStripMenuItem.Name = "基本资料ToolStripMenuItem";
            this.基本资料ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.基本资料ToolStripMenuItem.Text = "基本资料";
            // 
            // 科室信息维护ToolStripMenuItem
            // 
            this.科室信息维护ToolStripMenuItem.Name = "科室信息维护ToolStripMenuItem";
            this.科室信息维护ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.科室信息维护ToolStripMenuItem.Text = "科室信息维护";
            this.科室信息维护ToolStripMenuItem.Click += new System.EventHandler(this.科室信息维护ToolStripMenuItem_Click);
            // 
            // 检疗项目维护ToolStripMenuItem
            // 
            this.检疗项目维护ToolStripMenuItem.Name = "检疗项目维护ToolStripMenuItem";
            this.检疗项目维护ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.检疗项目维护ToolStripMenuItem.Text = "检疗项目维护";
            this.检疗项目维护ToolStripMenuItem.Click += new System.EventHandler(this.检疗项目维护ToolStripMenuItem_Click);
            // 
            // tsmiDoctorBaseInfo
            // 
            this.tsmiDoctorBaseInfo.Name = "tsmiDoctorBaseInfo";
            this.tsmiDoctorBaseInfo.Size = new System.Drawing.Size(172, 22);
            this.tsmiDoctorBaseInfo.Text = "医生信息维护";
            this.tsmiDoctorBaseInfo.Click += new System.EventHandler(this.tsmiDoctorBaseInfo_Click);
            // 
            // tsmiItemStandard
            // 
            this.tsmiItemStandard.Name = "tsmiItemStandard";
            this.tsmiItemStandard.Size = new System.Drawing.Size(172, 22);
            this.tsmiItemStandard.Text = "检疗项目规格维护";
            this.tsmiItemStandard.Click += new System.EventHandler(this.tsmiItemStandard_Click);
            // 
            // tsmiItemUnit
            // 
            this.tsmiItemUnit.Name = "tsmiItemUnit";
            this.tsmiItemUnit.Size = new System.Drawing.Size(172, 22);
            this.tsmiItemUnit.Text = "检疗项目单位维护";
            this.tsmiItemUnit.Click += new System.EventHandler(this.tsmiItemUnit_Click);
            // 
            // TSMIRegisterManager
            // 
            this.TSMIRegisterManager.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiPatientInfo});
            this.TSMIRegisterManager.Name = "TSMIRegisterManager";
            this.TSMIRegisterManager.Size = new System.Drawing.Size(68, 21);
            this.TSMIRegisterManager.Text = "入院管理";
            this.TSMIRegisterManager.Click += new System.EventHandler(this.费用挂历ToolStripMenuItem_Click);
            // 
            // tsmiPatientInfo
            // 
            this.tsmiPatientInfo.Name = "tsmiPatientInfo";
            this.tsmiPatientInfo.Size = new System.Drawing.Size(152, 22);
            this.tsmiPatientInfo.Text = "病人信息维护";
            this.tsmiPatientInfo.Click += new System.EventHandler(this.tsmiPatientInfo_Click);
            // 
            // tsmiHospitalManager
            // 
            this.tsmiHospitalManager.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.费用录入ToolStripMenuItem,
            this.病人费用查询ToolStripMenuItem});
            this.tsmiHospitalManager.Name = "tsmiHospitalManager";
            this.tsmiHospitalManager.Size = new System.Drawing.Size(68, 21);
            this.tsmiHospitalManager.Text = "住院管理";
            // 
            // 费用录入ToolStripMenuItem
            // 
            this.费用录入ToolStripMenuItem.Name = "费用录入ToolStripMenuItem";
            this.费用录入ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.费用录入ToolStripMenuItem.Text = "费用录入";
            this.费用录入ToolStripMenuItem.Click += new System.EventHandler(this.费用录入ToolStripMenuItem_Click);
            // 
            // 病人费用查询ToolStripMenuItem
            // 
            this.病人费用查询ToolStripMenuItem.Name = "病人费用查询ToolStripMenuItem";
            this.病人费用查询ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.病人费用查询ToolStripMenuItem.Text = "病人费用查询";
            this.病人费用查询ToolStripMenuItem.Click += new System.EventHandler(this.病人费用查询ToolStripMenuItem_Click);
            // 
            // TSMIFinanceMananger
            // 
            this.TSMIFinanceMananger.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.病人结账ToolStripMenuItem});
            this.TSMIFinanceMananger.Name = "TSMIFinanceMananger";
            this.TSMIFinanceMananger.Size = new System.Drawing.Size(68, 21);
            this.TSMIFinanceMananger.Text = "财务管理";
            // 
            // 病人结账ToolStripMenuItem
            // 
            this.病人结账ToolStripMenuItem.Name = "病人结账ToolStripMenuItem";
            this.病人结账ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.病人结账ToolStripMenuItem.Text = "病人结账";
            this.病人结账ToolStripMenuItem.Click += new System.EventHandler(this.病人结账ToolStripMenuItem_Click);
            // 
            // 统计报表ToolStripMenuItem
            // 
            this.统计报表ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SectionStatisticsRpt,
            this.SectionFigureRpt,
            this.PatientExpenseRpt});
            this.统计报表ToolStripMenuItem.Name = "统计报表ToolStripMenuItem";
            this.统计报表ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.统计报表ToolStripMenuItem.Text = "统计报表";
            // 
            // SectionStatisticsRpt
            // 
            this.SectionStatisticsRpt.Name = "SectionStatisticsRpt";
            this.SectionStatisticsRpt.Size = new System.Drawing.Size(184, 22);
            this.SectionStatisticsRpt.Text = "科室工作量统计报表";
            this.SectionStatisticsRpt.Click += new System.EventHandler(this.SectionStatisticsRpt_Click);
            // 
            // SectionFigureRpt
            // 
            this.SectionFigureRpt.Name = "SectionFigureRpt";
            this.SectionFigureRpt.Size = new System.Drawing.Size(184, 22);
            this.SectionFigureRpt.Text = "科室收入统计报表";
            this.SectionFigureRpt.Click += new System.EventHandler(this.SectionFigureRpt_Click);
            // 
            // PatientExpenseRpt
            // 
            this.PatientExpenseRpt.Name = "PatientExpenseRpt";
            this.PatientExpenseRpt.Size = new System.Drawing.Size(184, 22);
            this.PatientExpenseRpt.Text = "病人住院费用清单";
            this.PatientExpenseRpt.Click += new System.EventHandler(this.PatientExpenseRpt_Click);
            // 
            // tsMenuTools
            // 
            this.tsMenuTools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.tsbAdmin,
            this.tsbAccount});
            this.tsMenuTools.Location = new System.Drawing.Point(0, 25);
            this.tsMenuTools.Name = "tsMenuTools";
            this.tsMenuTools.Size = new System.Drawing.Size(794, 25);
            this.tsMenuTools.TabIndex = 1;
            this.tsMenuTools.Text = "toolStrip1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(76, 22);
            this.toolStripButton2.Text = "病人查询";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // tsbAdmin
            // 
            this.tsbAdmin.Image = global::HCS.Properties.Resources.tool_customer;
            this.tsbAdmin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdmin.Name = "tsbAdmin";
            this.tsbAdmin.Size = new System.Drawing.Size(76, 22);
            this.tsbAdmin.Tag = "";
            this.tsbAdmin.Text = "费用录入";
            this.tsbAdmin.Click += new System.EventHandler(this.tsbAdmin_Click);
            // 
            // tsbAccount
            // 
            this.tsbAccount.Image = global::HCS.Properties.Resources.tool_Finance;
            this.tsbAccount.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAccount.Name = "tsbAccount";
            this.tsbAccount.Size = new System.Drawing.Size(76, 22);
            this.tsbAccount.Text = "病人结账";
            this.tsbAccount.Click += new System.EventHandler(this.tsbAccount_Click);
            // 
            // tsLoginInfo
            // 
            this.tsLoginInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tsLoginInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.tslblUserName,
            this.dfdsf,
            this.tsbtnLoginDate});
            this.tsLoginInfo.Location = new System.Drawing.Point(0, 400);
            this.tsLoginInfo.Name = "tsLoginInfo";
            this.tsLoginInfo.Size = new System.Drawing.Size(794, 25);
            this.tsLoginInfo.TabIndex = 2;
            this.tsLoginInfo.Text = "tsLoginInfo";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::HCS.Properties.Resources.tool_customer;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(100, 22);
            this.toolStripButton1.Text = "当前登陆用户";
            // 
            // tslblUserName
            // 
            this.tslblUserName.Name = "tslblUserName";
            this.tslblUserName.Size = new System.Drawing.Size(29, 22);
            this.tslblUserName.Text = "000";
            // 
            // dfdsf
            // 
            this.dfdsf.Image = global::HCS.Properties.Resources.tool_Date;
            this.dfdsf.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.dfdsf.Name = "dfdsf";
            this.dfdsf.Size = new System.Drawing.Size(76, 22);
            this.dfdsf.Text = "登陆时间";
            // 
            // tsbtnLoginDate
            // 
            this.tsbtnLoginDate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnLoginDate.Name = "tsbtnLoginDate";
            this.tsbtnLoginDate.Size = new System.Drawing.Size(29, 22);
            this.tsbtnLoginDate.Text = "000";
            // 
            // HCSAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 425);
            this.Controls.Add(this.tsLoginInfo);
            this.Controls.Add(this.tsMenuTools);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HCSAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "医院收费管理系统";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tsMenuTools.ResumeLayout(false);
            this.tsMenuTools.PerformLayout();
            this.tsLoginInfo.ResumeLayout(false);
            this.tsLoginInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TSMIRegisterManager;
        private System.Windows.Forms.ToolStripMenuItem TSMIFinanceMananger;
        private System.Windows.Forms.ToolStrip tsMenuTools;
        private System.Windows.Forms.ToolStripButton tsbAdmin;
        private System.Windows.Forms.ToolStripButton tsbAccount;
        private System.Windows.Forms.ToolStripMenuItem tsmiHospitalManager;
        private System.Windows.Forms.ToolStripMenuItem tsmiPatientInfo;
        private System.Windows.Forms.ToolStripMenuItem 费用录入ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 病人费用查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 基本资料ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 科室信息维护ToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripMenuItem 检疗项目维护ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiDoctorBaseInfo;
        private System.Windows.Forms.ToolStripMenuItem 统计报表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SectionStatisticsRpt;
        private System.Windows.Forms.ToolStripMenuItem SectionFigureRpt;
        private System.Windows.Forms.ToolStripMenuItem PatientExpenseRpt;
        private System.Windows.Forms.ToolStrip tsLoginInfo;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel tslblUserName;
        private System.Windows.Forms.ToolStripButton dfdsf;
        private System.Windows.Forms.ToolStripLabel tsbtnLoginDate;
        private System.Windows.Forms.ToolStripMenuItem tsmiItemStandard;
        private System.Windows.Forms.ToolStripMenuItem tsmiItemUnit;
        private System.Windows.Forms.ToolStripMenuItem 病人结账ToolStripMenuItem;

    }
}

