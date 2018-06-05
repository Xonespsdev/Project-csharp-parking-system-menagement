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
	partial class frmLogin : System.Windows.Forms.Form
	{

		//Form overrides dispose to clean up the component list.
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
			this.Label1 = new System.Windows.Forms.Label();
			this.btnLogin = new System.Windows.Forms.Button();
			this.PictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnclose = new System.Windows.Forms.Button();
			this.BunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.txtUsername = new WindowsApplication1.WaterMark();
			this.txtPassword = new WindowsApplication1.WaterMark();
			((System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
			this.SuspendLayout();
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.Font = new System.Drawing.Font("Saysettha OT", 24f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label1.Location = new System.Drawing.Point(93, 25);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(172, 57);
			this.Label1.TabIndex = 1;
			this.Label1.Text = "ເຂົ້າສູ່ລະບົບ";
			//
			//btnLogin
			//
			this.btnLogin.BackColor = System.Drawing.Color.White;
			this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnLogin.Location = new System.Drawing.Point(36, 243);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(279, 44);
			this.btnLogin.TabIndex = 2;
			this.btnLogin.Text = "ເຂົ້າສູ່ລະບົບ";
			this.btnLogin.UseVisualStyleBackColor = false;
			//
			//PictureBox1
			//
			this.PictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.PictureBox1.BackgroundImage = (System.Drawing.Image)resources.GetObject("PictureBox1.BackgroundImage");
			this.PictureBox1.InitialImage = null;
			this.PictureBox1.Location = new System.Drawing.Point(374, 87);
			this.PictureBox1.Name = "PictureBox1";
			this.PictureBox1.Size = new System.Drawing.Size(200, 200);
			this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.PictureBox1.TabIndex = 5;
			this.PictureBox1.TabStop = false;
			//
			//btnclose
			//
			this.btnclose.BackgroundImage = (System.Drawing.Image)resources.GetObject("btnclose.BackgroundImage");
			this.btnclose.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnclose.ForeColor = System.Drawing.SystemColors.ActiveBorder;
			this.btnclose.Location = new System.Drawing.Point(632, 2);
			this.btnclose.Name = "btnclose";
			this.btnclose.Size = new System.Drawing.Size(16, 16);
			this.btnclose.TabIndex = 6;
			this.btnclose.UseVisualStyleBackColor = true;
			//
			//BunifuDragControl1
			//
			this.BunifuDragControl1.Fixed = true;
			this.BunifuDragControl1.Horizontal = true;
			this.BunifuDragControl1.TargetControl = this;
			this.BunifuDragControl1.Vertical = true;
			//
			//txtUsername
			//
			this.txtUsername.Location = new System.Drawing.Point(36, 106);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.SetWaterMarkColor = System.Drawing.Color.Silver;
			this.txtUsername.SetWaterMarkFont = new System.Drawing.Font("Saysettha OT", 12f);
			this.txtUsername.SetWaterMarkLeftCursor = 20;
			this.txtUsername.SetWaterMarkText = "ຊື່ຜູ້ໃຊ້";
			this.txtUsername.Size = new System.Drawing.Size(279, 35);
			this.txtUsername.TabIndex = 0;
			//
			//txtPassword
			//
			this.txtPassword.Location = new System.Drawing.Point(36, 178);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.SetWaterMarkColor = System.Drawing.Color.Silver;
			this.txtPassword.SetWaterMarkFont = new System.Drawing.Font("Saysettha OT", 12f);
			this.txtPassword.SetWaterMarkLeftCursor = 6;
			this.txtPassword.SetWaterMarkText = "ລະຫັດຜູ້ໃຊ້";
			this.txtPassword.Size = new System.Drawing.Size(279, 35);
			this.txtPassword.TabIndex = 1;
			//
			//frmLogin
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(9f, 29f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.ClientSize = new System.Drawing.Size(651, 322);
			this.Controls.Add(this.btnclose);
			this.Controls.Add(this.PictureBox1);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.txtUsername);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.Label1);
			this.Font = new System.Drawing.Font("Saysettha OT", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmLogin";
			this.Text = "frmLogin";
			((System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		internal Label Label1;
		private WaterMark withEventsField_txtPassword;
		internal WaterMark txtPassword {
			get { return withEventsField_txtPassword; }
			set {
				if (withEventsField_txtPassword != null) {
					withEventsField_txtPassword.KeyDown -= txtPassword_KeyDown;
				}
				withEventsField_txtPassword = value;
				if (withEventsField_txtPassword != null) {
					withEventsField_txtPassword.KeyDown += txtPassword_KeyDown;
				}
			}
		}
		private WaterMark withEventsField_txtUsername;
		internal WaterMark txtUsername {
			get { return withEventsField_txtUsername; }
			set {
				if (withEventsField_txtUsername != null) {
					withEventsField_txtUsername.KeyDown -= txtUsername_KeyDown;
				}
				withEventsField_txtUsername = value;
				if (withEventsField_txtUsername != null) {
					withEventsField_txtUsername.KeyDown += txtUsername_KeyDown;
				}
			}
		}
		private Button withEventsField_btnLogin;
		internal Button btnLogin {
			get { return withEventsField_btnLogin; }
			set {
				if (withEventsField_btnLogin != null) {
					withEventsField_btnLogin.Click -= btnLogin_Click;
				}
				withEventsField_btnLogin = value;
				if (withEventsField_btnLogin != null) {
					withEventsField_btnLogin.Click += btnLogin_Click;
				}
			}
		}
		internal PictureBox PictureBox1;
		private Button withEventsField_btnclose;
		internal Button btnclose {
			get { return withEventsField_btnclose; }
			set {
				if (withEventsField_btnclose != null) {
					withEventsField_btnclose.Click -= btnclose_Click;
				}
				withEventsField_btnclose = value;
				if (withEventsField_btnclose != null) {
					withEventsField_btnclose.Click += btnclose_Click;
				}
			}
		}
		internal Bunifu.Framework.UI.BunifuDragControl BunifuDragControl1;
		public frmLogin()
		{
			Load += frmLogin_Load;
			InitializeComponent();
		}
	}
}
