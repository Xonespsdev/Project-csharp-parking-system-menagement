namespace WindowsApplication1
{
    partial class PrintCard
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
            this.txtsearchpint = new System.Windows.Forms.TextBox();
            this.txtprint = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtsearchpint
            // 
            this.txtsearchpint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsearchpint.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearchpint.Location = new System.Drawing.Point(38, 43);
            this.txtsearchpint.Multiline = true;
            this.txtsearchpint.Name = "txtsearchpint";
            this.txtsearchpint.Size = new System.Drawing.Size(175, 37);
            this.txtsearchpint.TabIndex = 0;
            this.txtsearchpint.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtprint
            // 
            this.txtprint.Font = new System.Drawing.Font("Saysettha OT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprint.Location = new System.Drawing.Point(73, 97);
            this.txtprint.Name = "txtprint";
            this.txtprint.Size = new System.Drawing.Size(93, 39);
            this.txtprint.TabIndex = 1;
            this.txtprint.Text = "ພິມບັດ";
            this.txtprint.UseVisualStyleBackColor = true;
            this.txtprint.Click += new System.EventHandler(this.txtprint_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Saysettha OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "ປ້ນອລະຫັດສະມາຊິກເພື່ອພິມບັດ";
            // 
            // PrintCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 204);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtprint);
            this.Controls.Add(this.txtsearchpint);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PrintCard";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrintCard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtsearchpint;
        private System.Windows.Forms.Button txtprint;
        private System.Windows.Forms.Label label1;
    }
}