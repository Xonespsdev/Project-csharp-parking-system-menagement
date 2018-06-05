using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Linq;
using System.Xml.Linq;
using System.Threading.Tasks;
namespace WindowsApplication1
{
	[Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
	partial class UserControlComponent : System.Windows.Forms.UserControl
	{

		//UserControl overrides dispose to clean up the component list.
		[System.Diagnostics.DebuggerNonUserCode()]
		protected override void Dispose(bool disposing)
		{
			try {
				if (disposing && components != null) {
					components.Dispose();
				}
			} finally {
				base.Dispose(disposing);
			}
		}

		//Required by the Windows Form Designer

		private System.ComponentModel.IContainer components;
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.  
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
            this.cbRoll = new System.Windows.Forms.ComboBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtPassword = new WindowsApplication1.WaterMark();
            this.txtUserName = new WindowsApplication1.WaterMark();
            this.txtUserID = new WindowsApplication1.WaterMark();
            this.SuspendLayout();
            // 
            // cbRoll
            // 
            this.cbRoll.Font = new System.Drawing.Font("Saysettha OT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRoll.FormattingEnabled = true;
            this.cbRoll.Items.AddRange(new object[] {
            "ຜູ້ບໍລິຫານລະບົບ",
            "ພະນັກງານທົ່ວໄປ"});
            this.cbRoll.Location = new System.Drawing.Point(72, 309);
            this.cbRoll.Name = "cbRoll";
            this.cbRoll.Size = new System.Drawing.Size(351, 42);
            this.cbRoll.TabIndex = 4;
            this.cbRoll.Text = "ກາລຸນາເລືອກສິດທີຜູ້ໃຊ້";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Blue;
            this.Label1.Font = new System.Drawing.Font("Saysettha OT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(137, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(218, 43);
            this.Label1.TabIndex = 21;
            this.Label1.Text = "ແບບຟອມຜູ້ໃຊ້ລະບົບ";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Saysettha OT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(72, 219);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.SetWaterMarkColor = System.Drawing.Color.Gray;
            this.txtPassword.SetWaterMarkFont = new System.Drawing.Font("Saysettha OT", 14.25F);
            this.txtPassword.SetWaterMarkLeftCursor = 4;
            this.txtPassword.SetWaterMarkText = "ລະຫັດຜ່ານຜູ້ໃຊ້";
            this.txtPassword.Size = new System.Drawing.Size(350, 50);
            this.txtPassword.TabIndex = 3;
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Saysettha OT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(72, 137);
            this.txtUserName.Multiline = true;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.SetWaterMarkColor = System.Drawing.Color.Gray;
            this.txtUserName.SetWaterMarkFont = new System.Drawing.Font("Saysettha OT", 14.25F);
            this.txtUserName.SetWaterMarkLeftCursor = 4;
            this.txtUserName.SetWaterMarkText = "ຊື່ຜູ້ໃຊ້";
            this.txtUserName.Size = new System.Drawing.Size(350, 50);
            this.txtUserName.TabIndex = 2;
            this.txtUserName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtUserName_KeyUp);
            // 
            // txtUserID
            // 
            this.txtUserID.Font = new System.Drawing.Font("Saysettha OT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserID.Location = new System.Drawing.Point(72, 58);
            this.txtUserID.Multiline = true;
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.SetWaterMarkColor = System.Drawing.Color.Gray;
            this.txtUserID.SetWaterMarkFont = new System.Drawing.Font("Saysettha OT", 14.25F);
            this.txtUserID.SetWaterMarkLeftCursor = 4;
            this.txtUserID.SetWaterMarkText = "ລະຫັດຜູ້ໃຊ້";
            this.txtUserID.Size = new System.Drawing.Size(350, 50);
            this.txtUserID.TabIndex = 1;
            this.txtUserID.Visible = false;
            this.txtUserID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtUserID_KeyUp);
            // 
            // UserControlComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::WindowsApplication1.Properties.Resources.backound;
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.cbRoll);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtUserID);
            this.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.Name = "UserControlComponent";
            this.Size = new System.Drawing.Size(858, 529);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		private WaterMark withEventsField_txtUserID;
        internal WaterMark txtUserID;
		private WaterMark withEventsField_txtUserName;
        internal WaterMark txtUserName;
		internal WaterMark txtPassword;
		internal ComboBox cbRoll;
		internal Label Label1;
		public UserControlComponent()
		{
			Load += UserControlComponent_Load;
			InitializeComponent();
		}
	}
}
