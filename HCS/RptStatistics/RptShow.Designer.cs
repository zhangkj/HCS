namespace HCS
{
    partial class RptShow
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
            this.RptView = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // RptView
            // 
            this.RptView.ActiveViewIndex = -1;
            this.RptView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RptView.DisplayGroupTree = false;
            this.RptView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RptView.Location = new System.Drawing.Point(0, 0);
            this.RptView.Name = "RptView";
            this.RptView.SelectionFormula = "";
            this.RptView.Size = new System.Drawing.Size(835, 732);
            this.RptView.TabIndex = 0;
            this.RptView.ViewTimeSelectionFormula = "";
            // 
            // RptShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 732);
            this.Controls.Add(this.RptView);
            this.Name = "RptShow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "呈现报表";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer RptView;

    }
}