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
	partial class MemberControlComponent : System.Windows.Forms.UserControl
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
            this.cbBikeIDname = new System.Windows.Forms.ComboBox();
            this.txtMemberID = new WindowsApplication1.WaterMark();
            this.txtMembrAdress = new WindowsApplication1.WaterMark();
            this.txtMCardID = new WindowsApplication1.WaterMark();
            this.txtMLName = new WindowsApplication1.WaterMark();
            this.txtMName = new WindowsApplication1.WaterMark();
            this.txtMEmail = new WindowsApplication1.WaterMark();
            this.txtMphone = new WindowsApplication1.WaterMark();
            this.txtBcolor = new WindowsApplication1.WaterMark();
            this.txtBMachineNumber = new WindowsApplication1.WaterMark();
            this.txtBModel = new WindowsApplication1.WaterMark();
            this.txtBName = new WindowsApplication1.WaterMark();
            this.txtMemberBikeID = new WindowsApplication1.WaterMark();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Saysettha OT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(221, 5);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(267, 43);
            this.Label1.TabIndex = 14;
            this.Label1.Text = "ແບບຟອມສະໝັກສະມາຊິກ";
            // 
            // cbBikeIDname
            // 
            this.cbBikeIDname.Font = new System.Drawing.Font("Saysettha OT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBikeIDname.FormattingEnabled = true;
            this.cbBikeIDname.Items.AddRange(new object[] {
            "ນະຄອນຫຼວງວຽງຈັນ",
            "ວຽງຈັນ",
            "ບໍລິຄຳໄຊ",
            "ຄຳມ່ວນ",
            "ສະຫັວນນະເຂດ",
            "ສາລະວັນ",
            "ຈຳປາສັກ",
            "ເຊກອງ",
            "ອັດຕະປື",
            "ໄຊສົມບູນ",
            "ຊຽງຂວາງ",
            "ຫຼວງພະບາງ",
            "ອຸດົມໄຊ",
            "ໄຊຍະບູລີ",
            "ບໍ່ແກ້ວ",
            "ຜົງສາລີ",
            "ຫົວພັນ",
            "ຫັວພັນ"});
            this.cbBikeIDname.Location = new System.Drawing.Point(69, 168);
            this.cbBikeIDname.Name = "cbBikeIDname";
            this.cbBikeIDname.Size = new System.Drawing.Size(270, 42);
            this.cbBikeIDname.TabIndex = 32;
            this.cbBikeIDname.Text = "ເລືອກຊື່ທະບຽນລົດ";
            // 
            // txtMemberID
            // 
            this.txtMemberID.Font = new System.Drawing.Font("Saysettha OT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemberID.Location = new System.Drawing.Point(69, 64);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.ReadOnly = true;
            this.txtMemberID.SetWaterMarkColor = System.Drawing.Color.Gray;
            this.txtMemberID.SetWaterMarkFont = new System.Drawing.Font("Saysettha OT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemberID.SetWaterMarkLeftCursor = 2;
            this.txtMemberID.SetWaterMarkText = "ລະຫັດສະມາຊິກ";
            this.txtMemberID.Size = new System.Drawing.Size(270, 41);
            this.txtMemberID.TabIndex = 33;
            // 
            // txtMembrAdress
            // 
            this.txtMembrAdress.Font = new System.Drawing.Font("Saysettha OT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMembrAdress.Location = new System.Drawing.Point(386, 223);
            this.txtMembrAdress.Multiline = true;
            this.txtMembrAdress.Name = "txtMembrAdress";
            this.txtMembrAdress.SetWaterMarkColor = System.Drawing.Color.Gray;
            this.txtMembrAdress.SetWaterMarkFont = new System.Drawing.Font("Saysettha OT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMembrAdress.SetWaterMarkLeftCursor = 2;
            this.txtMembrAdress.SetWaterMarkText = "ທີ່ຢູ່";
            this.txtMembrAdress.Size = new System.Drawing.Size(303, 92);
            this.txtMembrAdress.TabIndex = 13;
            this.txtMembrAdress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMembrAdress_KeyDown);
            // 
            // txtMCardID
            // 
            this.txtMCardID.Font = new System.Drawing.Font("Saysettha OT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMCardID.Location = new System.Drawing.Point(386, 169);
            this.txtMCardID.Name = "txtMCardID";
            this.txtMCardID.SetWaterMarkColor = System.Drawing.Color.Gray;
            this.txtMCardID.SetWaterMarkFont = new System.Drawing.Font("Saysettha OT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMCardID.SetWaterMarkLeftCursor = 2;
            this.txtMCardID.SetWaterMarkText = "";
            this.txtMCardID.Size = new System.Drawing.Size(303, 41);
            this.txtMCardID.TabIndex = 12;
            this.txtMCardID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMCardID_KeyDown);
            // 
            // txtMLName
            // 
            this.txtMLName.Font = new System.Drawing.Font("Saysettha OT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMLName.Location = new System.Drawing.Point(386, 117);
            this.txtMLName.Name = "txtMLName";
            this.txtMLName.SetWaterMarkColor = System.Drawing.Color.Gray;
            this.txtMLName.SetWaterMarkFont = new System.Drawing.Font("Saysettha OT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMLName.SetWaterMarkLeftCursor = 2;
            this.txtMLName.SetWaterMarkText = "ນາມສະກຸນ";
            this.txtMLName.Size = new System.Drawing.Size(303, 41);
            this.txtMLName.TabIndex = 11;
            this.txtMLName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMLName_KeyDown);
            // 
            // txtMName
            // 
            this.txtMName.Font = new System.Drawing.Font("Saysettha OT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMName.Location = new System.Drawing.Point(386, 66);
            this.txtMName.Name = "txtMName";
            this.txtMName.SetWaterMarkColor = System.Drawing.Color.Gray;
            this.txtMName.SetWaterMarkFont = new System.Drawing.Font("Saysettha OT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMName.SetWaterMarkLeftCursor = 2;
            this.txtMName.SetWaterMarkText = "ຊື່ເຈົ້າຂອງລົດ";
            this.txtMName.Size = new System.Drawing.Size(303, 41);
            this.txtMName.TabIndex = 10;
            this.txtMName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMName_KeyDown);
            // 
            // txtMEmail
            // 
            this.txtMEmail.Font = new System.Drawing.Font("Saysettha OT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMEmail.Location = new System.Drawing.Point(386, 380);
            this.txtMEmail.Name = "txtMEmail";
            this.txtMEmail.SetWaterMarkColor = System.Drawing.Color.Gray;
            this.txtMEmail.SetWaterMarkFont = new System.Drawing.Font("Saysettha OT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMEmail.SetWaterMarkLeftCursor = 2;
            this.txtMEmail.SetWaterMarkText = "ອີເມວ";
            this.txtMEmail.Size = new System.Drawing.Size(303, 41);
            this.txtMEmail.TabIndex = 8;
            this.txtMEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMEmail_KeyDown);
            // 
            // txtMphone
            // 
            this.txtMphone.Font = new System.Drawing.Font("Saysettha OT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMphone.Location = new System.Drawing.Point(386, 324);
            this.txtMphone.Name = "txtMphone";
            this.txtMphone.SetWaterMarkColor = System.Drawing.Color.Gray;
            this.txtMphone.SetWaterMarkFont = new System.Drawing.Font("Saysettha OT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMphone.SetWaterMarkLeftCursor = 2;
            this.txtMphone.SetWaterMarkText = "ເບີໂທ";
            this.txtMphone.Size = new System.Drawing.Size(303, 41);
            this.txtMphone.TabIndex = 7;
            this.txtMphone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMphone_KeyDown);
            // 
            // txtBcolor
            // 
            this.txtBcolor.Font = new System.Drawing.Font("Saysettha OT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBcolor.Location = new System.Drawing.Point(69, 379);
            this.txtBcolor.Name = "txtBcolor";
            this.txtBcolor.SetWaterMarkColor = System.Drawing.Color.Gray;
            this.txtBcolor.SetWaterMarkFont = new System.Drawing.Font("Saysettha OT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBcolor.SetWaterMarkLeftCursor = 2;
            this.txtBcolor.SetWaterMarkText = "ສີລົດ";
            this.txtBcolor.Size = new System.Drawing.Size(270, 41);
            this.txtBcolor.TabIndex = 5;
            this.txtBcolor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBcolor_KeyDown);
            // 
            // txtBMachineNumber
            // 
            this.txtBMachineNumber.Font = new System.Drawing.Font("Saysettha OT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBMachineNumber.Location = new System.Drawing.Point(69, 325);
            this.txtBMachineNumber.Name = "txtBMachineNumber";
            this.txtBMachineNumber.SetWaterMarkColor = System.Drawing.Color.Gray;
            this.txtBMachineNumber.SetWaterMarkFont = new System.Drawing.Font("Saysettha OT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBMachineNumber.SetWaterMarkLeftCursor = 2;
            this.txtBMachineNumber.SetWaterMarkText = "ເລກຈັກລົດ";
            this.txtBMachineNumber.Size = new System.Drawing.Size(270, 41);
            this.txtBMachineNumber.TabIndex = 4;
            this.txtBMachineNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBModel_KeyDown);
            // 
            // txtBModel
            // 
            this.txtBModel.Font = new System.Drawing.Font("Saysettha OT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBModel.Location = new System.Drawing.Point(69, 274);
            this.txtBModel.Name = "txtBModel";
            this.txtBModel.SetWaterMarkColor = System.Drawing.Color.Gray;
            this.txtBModel.SetWaterMarkFont = new System.Drawing.Font("Saysettha OT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBModel.SetWaterMarkLeftCursor = 2;
            this.txtBModel.SetWaterMarkText = "ຍີ່ຫໍ່ລົດ";
            this.txtBModel.Size = new System.Drawing.Size(270, 41);
            this.txtBModel.TabIndex = 3;
            this.txtBModel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBModel_KeyDown);
            // 
            // txtBName
            // 
            this.txtBName.Font = new System.Drawing.Font("Saysettha OT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBName.Location = new System.Drawing.Point(69, 223);
            this.txtBName.Name = "txtBName";
            this.txtBName.SetWaterMarkColor = System.Drawing.Color.Gray;
            this.txtBName.SetWaterMarkFont = new System.Drawing.Font("Saysettha OT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBName.SetWaterMarkLeftCursor = 2;
            this.txtBName.SetWaterMarkText = "ຊື່ລົດ";
            this.txtBName.Size = new System.Drawing.Size(270, 41);
            this.txtBName.TabIndex = 2;
            this.txtBName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBName_KeyDown);
            // 
            // txtMemberBikeID
            // 
            this.txtMemberBikeID.Font = new System.Drawing.Font("Saysettha OT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemberBikeID.Location = new System.Drawing.Point(69, 117);
            this.txtMemberBikeID.Name = "txtMemberBikeID";
            this.txtMemberBikeID.SetWaterMarkColor = System.Drawing.Color.Gray;
            this.txtMemberBikeID.SetWaterMarkFont = new System.Drawing.Font("Saysettha OT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemberBikeID.SetWaterMarkLeftCursor = 2;
            this.txtMemberBikeID.SetWaterMarkText = "ເລກທະບຽນລົດ";
            this.txtMemberBikeID.Size = new System.Drawing.Size(270, 41);
            this.txtMemberBikeID.TabIndex = 0;
            this.txtMemberBikeID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMemberBikeID_KeyDown);
            // 
            // MemberControlComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.txtMemberID);
            this.Controls.Add(this.cbBikeIDname);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txtMembrAdress);
            this.Controls.Add(this.txtMCardID);
            this.Controls.Add(this.txtMLName);
            this.Controls.Add(this.txtMName);
            this.Controls.Add(this.txtMEmail);
            this.Controls.Add(this.txtMphone);
            this.Controls.Add(this.txtBcolor);
            this.Controls.Add(this.txtBMachineNumber);
            this.Controls.Add(this.txtBModel);
            this.Controls.Add(this.txtBName);
            this.Controls.Add(this.txtMemberBikeID);
            this.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.Name = "MemberControlComponent";
            this.Size = new System.Drawing.Size(856, 527);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        internal WaterMark txtMemberBikeID; 
		private WaterMark withEventsField_txtBName;
        internal WaterMark txtBName;
        internal WaterMark txtBModel;
        internal WaterMark txtBMachineNumber; 
        internal WaterMark txtBcolor;
        internal WaterMark txtMEmail;
        internal WaterMark txtMphone;
        internal WaterMark txtMembrAdress; 
        internal WaterMark txtMCardID;
		private WaterMark withEventsField_txtMLName;
        internal WaterMark txtMLName;
		
        internal WaterMark txtMName;
		internal Label Label1;
		internal ComboBox cbBikeIDname;
		internal WaterMark txtMemberID;
		public MemberControlComponent()
		{
			Load += MemberControlComponent_Load;
			InitializeComponent();
		}
    }
}
