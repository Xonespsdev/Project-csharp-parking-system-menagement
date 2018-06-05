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
	partial class PackageComponent : System.Windows.Forms.UserControl
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
            this.Label1 = new System.Windows.Forms.Label();
            this.txtPrice = new WindowsApplication1.WaterMark();
            this.txtPackageDetail = new WindowsApplication1.WaterMark();
            this.txtPackageName = new WindowsApplication1.WaterMark();
            this.txtPackageID = new WindowsApplication1.WaterMark();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Saysettha OT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(216, 26);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(153, 43);
            this.Label1.TabIndex = 9;
            this.Label1.Text = "ຟອມແພັກເກດ";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Saysettha OT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.ForeColor = System.Drawing.Color.Black;
            this.txtPrice.Location = new System.Drawing.Point(95, 384);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(6, 16, 6, 16);
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.SetWaterMarkColor = System.Drawing.Color.Gray;
            this.txtPrice.SetWaterMarkFont = new System.Drawing.Font("Saysettha OT", 14.25F);
            this.txtPrice.SetWaterMarkLeftCursor = 2;
            this.txtPrice.SetWaterMarkText = "ລາຄາ";
            this.txtPrice.Size = new System.Drawing.Size(449, 54);
            this.txtPrice.TabIndex = 8;
            // 
            // txtPackageDetail
            // 
            this.txtPackageDetail.Font = new System.Drawing.Font("Saysettha OT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPackageDetail.ForeColor = System.Drawing.Color.Black;
            this.txtPackageDetail.Location = new System.Drawing.Point(95, 223);
            this.txtPackageDetail.Margin = new System.Windows.Forms.Padding(6, 16, 6, 16);
            this.txtPackageDetail.Multiline = true;
            this.txtPackageDetail.Name = "txtPackageDetail";
            this.txtPackageDetail.SetWaterMarkColor = System.Drawing.Color.Gray;
            this.txtPackageDetail.SetWaterMarkFont = new System.Drawing.Font("Saysettha OT", 14.25F);
            this.txtPackageDetail.SetWaterMarkLeftCursor = 2;
            this.txtPackageDetail.SetWaterMarkText = "ລາຍລະອຽດ";
            this.txtPackageDetail.Size = new System.Drawing.Size(449, 144);
            this.txtPackageDetail.TabIndex = 7;
            // 
            // txtPackageName
            // 
            this.txtPackageName.Font = new System.Drawing.Font("Saysettha OT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPackageName.ForeColor = System.Drawing.Color.Black;
            this.txtPackageName.Location = new System.Drawing.Point(95, 153);
            this.txtPackageName.Margin = new System.Windows.Forms.Padding(6, 16, 6, 16);
            this.txtPackageName.Multiline = true;
            this.txtPackageName.Name = "txtPackageName";
            this.txtPackageName.SetWaterMarkColor = System.Drawing.Color.Gray;
            this.txtPackageName.SetWaterMarkFont = new System.Drawing.Font("Saysettha OT", 14.25F);
            this.txtPackageName.SetWaterMarkLeftCursor = 2;
            this.txtPackageName.SetWaterMarkText = "ຊື່ແພັກເກດ";
            this.txtPackageName.Size = new System.Drawing.Size(449, 54);
            this.txtPackageName.TabIndex = 6;
            // 
            // txtPackageID
            // 
            this.txtPackageID.ForeColor = System.Drawing.Color.Black;
            this.txtPackageID.Location = new System.Drawing.Point(95, 85);
            this.txtPackageID.Margin = new System.Windows.Forms.Padding(6, 16, 6, 16);
            this.txtPackageID.Multiline = true;
            this.txtPackageID.Name = "txtPackageID";
            this.txtPackageID.SetWaterMarkColor = System.Drawing.Color.Gray;
            this.txtPackageID.SetWaterMarkFont = new System.Drawing.Font("Saysettha OT", 12F);
            this.txtPackageID.SetWaterMarkLeftCursor = 4;
            this.txtPackageID.SetWaterMarkText = "ລະຫັດແພັດເກດ";
            this.txtPackageID.Size = new System.Drawing.Size(449, 54);
            this.txtPackageID.TabIndex = 5;
            // 
            // PackageComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtPackageDetail);
            this.Controls.Add(this.txtPackageName);
            this.Controls.Add(this.txtPackageID);
            this.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.Name = "PackageComponent";
            this.Size = new System.Drawing.Size(856, 527);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		internal Label Label1;
		internal WaterMark txtPrice;
		internal WaterMark txtPackageDetail;
		internal WaterMark txtPackageName;
		internal WaterMark txtPackageID;
		public PackageComponent()
		{
			Load += PackageComponent_Load;
			InitializeComponent();
		}
	}
}
