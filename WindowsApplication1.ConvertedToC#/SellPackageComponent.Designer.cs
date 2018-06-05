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
	partial class SellPackageMemberComponent : System.Windows.Forms.UserControl
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellPackageMemberComponent));
			this.SellDate = new System.Windows.Forms.DateTimePicker();
			this.Label2 = new System.Windows.Forms.Label();
			this.cbPackageID = new System.Windows.Forms.ComboBox();
			this.MemberAutoID = new AutocompleteMenuNS.AutocompleteMenu();
			this.txtSellMID = new WindowsApplication1.WaterMark();
			this.txtSellID = new WindowsApplication1.WaterMark();
			this.txtMPrice = new WindowsApplication1.WaterMark();
			this.SellTime = new System.Windows.Forms.DateTimePicker();
			this.SuspendLayout();
			//
			//SellDate
			//
			this.SellDate.Font = new System.Drawing.Font("Saysettha OT", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.SellDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.SellDate.Location = new System.Drawing.Point(78, 343);
			this.SellDate.Name = "SellDate";
			this.SellDate.Size = new System.Drawing.Size(449, 41);
			this.SellDate.TabIndex = 1;
			//
			//Label2
			//
			this.Label2.AutoSize = true;
			this.Label2.Font = new System.Drawing.Font("Saysettha OT", 18f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label2.Location = new System.Drawing.Point(100, 9);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(321, 43);
			this.Label2.TabIndex = 25;
			this.Label2.Text = "ຟອມເຮັດບັດສະມາຊິກຈອດລົດ";
			//
			//cbPackageID
			//
			this.cbPackageID.Font = new System.Drawing.Font("Saysettha OT", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.cbPackageID.FormattingEnabled = true;
			this.cbPackageID.Location = new System.Drawing.Point(78, 200);
			this.cbPackageID.Name = "cbPackageID";
			this.cbPackageID.Size = new System.Drawing.Size(449, 42);
			this.cbPackageID.TabIndex = 27;
			this.cbPackageID.Text = "ເລືອກແພັກເກດ";
            this.cbPackageID.SelectionChangeCommitted += new EventHandler(this.cbPackageID_SelectionChangeCommitted);
            //
            //MemberAutoID
            //
            this.MemberAutoID.AppearInterval = 200;
			this.MemberAutoID.Colors = (AutocompleteMenuNS.Colors)resources.GetObject("MemberAutoID.Colors");
			this.MemberAutoID.Font = new System.Drawing.Font("Palatino Linotype", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.MemberAutoID.ImageList = null;
			this.MemberAutoID.Items = new string[-1 + 1];
			this.MemberAutoID.LeftPadding = 1;
			this.MemberAutoID.MaximumSize = new System.Drawing.Size(327, 35);
			this.MemberAutoID.MinFragmentLength = 1;
			this.MemberAutoID.SearchPattern = "[\\d+]";
			this.MemberAutoID.TargetControlWrapper = null;
            this.MemberAutoID.Selected += new EventHandler<AutocompleteMenuNS.SelectedEventArgs>(this.MemberAutoID_Selected);
			//
			//txtSellMID
			//
			this.txtSellMID.AutoCompleteCustomSource.AddRange(new string[] {
				"Avc",
				"asbee"
			});
			this.MemberAutoID.SetAutocompleteMenu(this.txtSellMID, this.MemberAutoID);
			this.txtSellMID.Font = new System.Drawing.Font("Saysettha OT", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.txtSellMID.Location = new System.Drawing.Point(78, 134);
			this.txtSellMID.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
			this.txtSellMID.Multiline = true;
			this.txtSellMID.Name = "txtSellMID";
			this.txtSellMID.SetWaterMarkColor = System.Drawing.Color.Gray;
			this.txtSellMID.SetWaterMarkFont = new System.Drawing.Font("Saysettha OT", 14.25f);
			this.txtSellMID.SetWaterMarkLeftCursor = 2;
			this.txtSellMID.SetWaterMarkText = "ລະຫັດສະມາຊິກ";
			this.txtSellMID.Size = new System.Drawing.Size(449, 54);
			this.txtSellMID.TabIndex = 22;
			//
			//txtSellID
			//
			this.MemberAutoID.SetAutocompleteMenu(this.txtSellID, null);
			this.txtSellID.Font = new System.Drawing.Font("Saysettha OT", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.txtSellID.Location = new System.Drawing.Point(78, 68);
			this.txtSellID.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
			this.txtSellID.Multiline = true;
			this.txtSellID.Name = "txtSellID";
			this.txtSellID.ReadOnly = true;
			this.txtSellID.SetWaterMarkColor = System.Drawing.Color.Gray;
			this.txtSellID.SetWaterMarkFont = new System.Drawing.Font("Saysettha OT", 14.25f);
			this.txtSellID.SetWaterMarkLeftCursor = 6;
			this.txtSellID.SetWaterMarkText = "ລະຫັດບັດ";
			this.txtSellID.Size = new System.Drawing.Size(449, 54);
			this.txtSellID.TabIndex = 21;
			//
			//txtMPrice
			//
			this.MemberAutoID.SetAutocompleteMenu(this.txtMPrice, null);
			this.txtMPrice.Font = new System.Drawing.Font("Saysettha OT", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.txtMPrice.Location = new System.Drawing.Point(78, 263);
			this.txtMPrice.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
			this.txtMPrice.Multiline = true;
			this.txtMPrice.Name = "txtMPrice";
			this.txtMPrice.ReadOnly = true;
			this.txtMPrice.SetWaterMarkColor = System.Drawing.Color.Gray;
			this.txtMPrice.SetWaterMarkFont = new System.Drawing.Font("Saysettha OT", 14.25f);
			this.txtMPrice.SetWaterMarkLeftCursor = 2;
			this.txtMPrice.SetWaterMarkText = "ລາຄາ";
			this.txtMPrice.Size = new System.Drawing.Size(449, 54);
			this.txtMPrice.TabIndex = 20;
			//
			//SellTime
			//
			this.SellTime.Font = new System.Drawing.Font("Saysettha OT", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.SellTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.SellTime.Location = new System.Drawing.Point(78, 407);
			this.SellTime.Name = "SellTime";
			this.SellTime.Size = new System.Drawing.Size(449, 41);
			this.SellTime.TabIndex = 28;
			//
			//SellPackageMemberComponent
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(9f, 29f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Transparent;
			this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Controls.Add(this.SellTime);
			this.Controls.Add(this.cbPackageID);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.txtSellMID);
			this.Controls.Add(this.txtSellID);
			this.Controls.Add(this.txtMPrice);
			this.Controls.Add(this.SellDate);
			this.Font = new System.Drawing.Font("Saysettha OT", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
			this.Name = "SellPackageMemberComponent";
			this.Size = new System.Drawing.Size(856, 527);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		internal DateTimePicker SellDate;
		internal WaterMark txtSellMID;
		internal WaterMark txtSellID;
		internal WaterMark txtMPrice;
		internal Label Label2;
        internal ComboBox cbPackageID; 
		private AutocompleteMenuNS.AutocompleteMenu withEventsField_MemberAutoID;
       internal AutocompleteMenuNS.AutocompleteMenu MemberAutoID; 
		internal DateTimePicker SellTime;
	}
}
