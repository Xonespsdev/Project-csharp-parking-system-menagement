namespace WindowsApplication1
{
    partial class frmReportCardBill
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
            this.crystalReportPintcard = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.rptPrintCard1 = new WindowsApplication1.rptPrintCard();
            this.SuspendLayout();
            // 
            // crystalReportPintcard
            // 
            this.crystalReportPintcard.ActiveViewIndex = 0;
            this.crystalReportPintcard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportPintcard.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportPintcard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportPintcard.Location = new System.Drawing.Point(0, 0);
            this.crystalReportPintcard.Name = "crystalReportPintcard";
            this.crystalReportPintcard.ReportSource = this.rptPrintCard1;
            this.crystalReportPintcard.Size = new System.Drawing.Size(590, 359);
            this.crystalReportPintcard.TabIndex = 0;
            // 
            // rptPrintCard1
            // 
            this.rptPrintCard1.FileName = "rassdk://C:\\Users\\Xone\\AppData\\Local\\Temp\\temp_ffd6c65c-4a84-4118-a330-18f5809095" +
    "dc.rpt";
            // 
            // frmReportCardBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 359);
            this.Controls.Add(this.crystalReportPintcard);
            this.Name = "frmReportCardBill";
            this.Text = "frmReportCardBill";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportPintcard;
        private rptPrintCard rptPrintCard1;
    }
}