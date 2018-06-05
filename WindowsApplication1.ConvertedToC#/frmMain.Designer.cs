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
	partial class MainComponentForm : System.Windows.Forms.Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainComponentForm));
            this.PanelParentContents = new System.Windows.Forms.Panel();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.PanelHeader = new System.Windows.Forms.Panel();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.txtSearch = new WindowsApplication1.WaterMark();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.PanelLeft = new System.Windows.Forms.Panel();
            this.btnabout = new System.Windows.Forms.Button();
            this.bthelp = new System.Windows.Forms.Button();
            this.lbUsername = new System.Windows.Forms.Label();
            this.btnMember = new System.Windows.Forms.Button();
            this.btnPrintCard = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnReportMember = new System.Windows.Forms.Button();
            this.btnPagekage = new System.Windows.Forms.Button();
            this.Panelfooter = new System.Windows.Forms.Panel();
            this.lbAmountBike = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbEmpty = new System.Windows.Forms.Label();
            this.PanelRight = new System.Windows.Forms.Panel();
            this.Label1 = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.BunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.TimerCalculate = new System.Windows.Forms.Timer(this.components);
            this.MyToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.AutocompleteSearch = new AutocompleteMenuNS.AutocompleteMenu();
            this.PrintPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.PrintDialog1 = new System.Windows.Forms.PrintDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.PanelHeader.SuspendLayout();
            this.PanelLeft.SuspendLayout();
            this.Panelfooter.SuspendLayout();
            this.PanelRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelParentContents
            // 
            this.PanelParentContents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelParentContents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.PanelParentContents.BackgroundImage = global::WindowsApplication1.Properties.Resources.mainbackgound;
            this.PanelParentContents.ForeColor = System.Drawing.SystemColors.Desktop;
            this.PanelParentContents.Location = new System.Drawing.Point(214, 86);
            this.PanelParentContents.Name = "PanelParentContents";
            this.PanelParentContents.Size = new System.Drawing.Size(883, 568);
            this.PanelParentContents.TabIndex = 0;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.Silver;
            this.btnRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegister.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.Black;
            this.btnRegister.Location = new System.Drawing.Point(7, 103);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(186, 50);
            this.btnRegister.TabIndex = 1;
            this.btnRegister.Text = "ສະໝັກສະມາຊິກ";
            this.btnRegister.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.Color.Silver;
            this.btnUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUser.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.ForeColor = System.Drawing.Color.Black;
            this.btnUser.Location = new System.Drawing.Point(6, 53);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(187, 50);
            this.btnUser.TabIndex = 1;
            this.btnUser.Text = "ຜູ້ໃຊ້ລະບົບ";
            this.btnUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUser.UseVisualStyleBackColor = false;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // PanelHeader
            // 
            this.PanelHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelHeader.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.PanelHeader.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelHeader.Controls.Add(this.btnLast);
            this.PanelHeader.Controls.Add(this.btnFirst);
            this.PanelHeader.Controls.Add(this.btnSearch);
            this.PanelHeader.Controls.Add(this.btnNext);
            this.PanelHeader.Controls.Add(this.btnPrevious);
            this.PanelHeader.Controls.Add(this.txtSearch);
            this.PanelHeader.Controls.Add(this.btnAdd);
            this.PanelHeader.Controls.Add(this.btnSave);
            this.PanelHeader.Controls.Add(this.btnDelete);
            this.PanelHeader.Controls.Add(this.btnEdit);
            this.PanelHeader.ForeColor = System.Drawing.Color.Maroon;
            this.PanelHeader.Location = new System.Drawing.Point(212, 42);
            this.PanelHeader.Name = "PanelHeader";
            this.PanelHeader.Size = new System.Drawing.Size(1169, 43);
            this.PanelHeader.TabIndex = 2;
            // 
            // btnLast
            // 
            this.btnLast.BackColor = System.Drawing.Color.Transparent;
            this.btnLast.BackgroundImage = global::WindowsApplication1.Properties.Resources.Last_32px;
            this.btnLast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLast.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnLast.Location = new System.Drawing.Point(839, 4);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(32, 32);
            this.btnLast.TabIndex = 24;
            this.btnLast.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLast.UseVisualStyleBackColor = false;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.BackColor = System.Drawing.Color.Transparent;
            this.btnFirst.BackgroundImage = global::WindowsApplication1.Properties.Resources.First_32px;
            this.btnFirst.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirst.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnFirst.Location = new System.Drawing.Point(705, 3);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(32, 32);
            this.btnFirst.TabIndex = 23;
            this.btnFirst.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFirst.UseVisualStyleBackColor = false;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSearch.Location = new System.Drawing.Point(1112, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(32, 30);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.BackgroundImage = global::WindowsApplication1.Properties.Resources.Right_32px;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnNext.Location = new System.Drawing.Point(794, 3);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(32, 32);
            this.btnNext.TabIndex = 22;
            this.btnNext.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.Transparent;
            this.btnPrevious.BackgroundImage = global::WindowsApplication1.Properties.Resources.Long_Arrow_Left_32px;
            this.btnPrevious.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnPrevious.Location = new System.Drawing.Point(748, 3);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(32, 32);
            this.btnPrevious.TabIndex = 21;
            this.btnPrevious.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // txtSearch
            // 
            this.AutocompleteSearch.SetAutocompleteMenu(this.txtSearch, this.AutocompleteSearch);
            this.txtSearch.Location = new System.Drawing.Point(894, 1);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.SetWaterMarkColor = System.Drawing.Color.Gray;
            this.txtSearch.SetWaterMarkFont = new System.Drawing.Font("Saysettha OT", 12F);
            this.txtSearch.SetWaterMarkLeftCursor = 2;
            this.txtSearch.SetWaterMarkText = "ຄົ້ນຫາ";
            this.txtSearch.Size = new System.Drawing.Size(218, 35);
            this.txtSearch.TabIndex = 20;
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BackgroundImage = global::WindowsApplication1.Properties.Resources.Add_New_32px;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnAdd.Location = new System.Drawing.Point(31, 1);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(32, 32);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BackgroundImage = global::WindowsApplication1.Properties.Resources.Save_32px;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSave.Location = new System.Drawing.Point(85, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(32, 32);
            this.btnSave.TabIndex = 2;
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BackgroundImage = global::WindowsApplication1.Properties.Resources.Trash_32px;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnDelete.Location = new System.Drawing.Point(180, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(32, 32);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.BackgroundImage = global::WindowsApplication1.Properties.Resources.Edit_Property_32px;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnEdit.Location = new System.Drawing.Point(133, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(32, 32);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // PanelLeft
            // 
            this.PanelLeft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PanelLeft.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PanelLeft.Controls.Add(this.btnabout);
            this.PanelLeft.Controls.Add(this.bthelp);
            this.PanelLeft.Controls.Add(this.lbUsername);
            this.PanelLeft.Controls.Add(this.btnMember);
            this.PanelLeft.Controls.Add(this.btnPrintCard);
            this.PanelLeft.Controls.Add(this.btnUser);
            this.PanelLeft.Controls.Add(this.btnMenu);
            this.PanelLeft.Controls.Add(this.btnReportMember);
            this.PanelLeft.Controls.Add(this.btnRegister);
            this.PanelLeft.Controls.Add(this.btnPagekage);
            this.PanelLeft.Location = new System.Drawing.Point(15, 85);
            this.PanelLeft.Name = "PanelLeft";
            this.PanelLeft.Size = new System.Drawing.Size(198, 629);
            this.PanelLeft.TabIndex = 3;
            // 
            // btnabout
            // 
            this.btnabout.BackColor = System.Drawing.Color.Silver;
            this.btnabout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnabout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnabout.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnabout.ForeColor = System.Drawing.Color.Black;
            this.btnabout.Location = new System.Drawing.Point(9, 394);
            this.btnabout.Name = "btnabout";
            this.btnabout.Size = new System.Drawing.Size(186, 43);
            this.btnabout.TabIndex = 11;
            this.btnabout.Text = "ກ່ຽວກັບພວກເຮົາ";
            this.btnabout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnabout.UseVisualStyleBackColor = false;
            this.btnabout.Visible = false;
            this.btnabout.Click += new System.EventHandler(this.btnabout_Click_1);
            // 
            // bthelp
            // 
            this.bthelp.BackColor = System.Drawing.Color.Silver;
            this.bthelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bthelp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bthelp.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bthelp.ForeColor = System.Drawing.Color.Black;
            this.bthelp.Location = new System.Drawing.Point(9, 350);
            this.bthelp.Name = "bthelp";
            this.bthelp.Size = new System.Drawing.Size(186, 43);
            this.bthelp.TabIndex = 11;
            this.bthelp.Text = "ແນະນຳການນຳໃຊ້";
            this.bthelp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bthelp.UseVisualStyleBackColor = false;
            this.bthelp.Visible = false;
            this.bthelp.Click += new System.EventHandler(this.btnhelp);
            // 
            // lbUsername
            // 
            this.lbUsername.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.Location = new System.Drawing.Point(2, 595);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(204, 32);
            this.lbUsername.TabIndex = 0;
            // 
            // btnMember
            // 
            this.btnMember.BackColor = System.Drawing.Color.Silver;
            this.btnMember.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMember.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMember.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMember.ForeColor = System.Drawing.Color.Black;
            this.btnMember.Location = new System.Drawing.Point(7, 151);
            this.btnMember.Name = "btnMember";
            this.btnMember.Size = new System.Drawing.Size(186, 50);
            this.btnMember.TabIndex = 5;
            this.btnMember.Text = "ເຮັດບັດສະມາຊິກ";
            this.btnMember.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMember.UseVisualStyleBackColor = false;
            this.btnMember.Click += new System.EventHandler(this.btnMember_Click);
            // 
            // btnPrintCard
            // 
            this.btnPrintCard.BackColor = System.Drawing.Color.Silver;
            this.btnPrintCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPrintCard.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrintCard.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintCard.ForeColor = System.Drawing.Color.Black;
            this.btnPrintCard.Location = new System.Drawing.Point(7, 201);
            this.btnPrintCard.Name = "btnPrintCard";
            this.btnPrintCard.Size = new System.Drawing.Size(186, 50);
            this.btnPrintCard.TabIndex = 2;
            this.btnPrintCard.Text = "ພິມບັດ";
            this.btnPrintCard.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrintCard.UseVisualStyleBackColor = false;
            this.btnPrintCard.Click += new System.EventHandler(this.btnPrintCard_Click_1);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Saysettha OT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMenu.Location = new System.Drawing.Point(3, 6);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(190, 50);
            this.btnMenu.TabIndex = 10;
            this.btnMenu.Text = "ເລືອກເມນູ";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnReportMember
            // 
            this.btnReportMember.BackColor = System.Drawing.Color.Silver;
            this.btnReportMember.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnReportMember.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReportMember.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportMember.ForeColor = System.Drawing.Color.Black;
            this.btnReportMember.Location = new System.Drawing.Point(7, 299);
            this.btnReportMember.Name = "btnReportMember";
            this.btnReportMember.Size = new System.Drawing.Size(186, 50);
            this.btnReportMember.TabIndex = 7;
            this.btnReportMember.Text = "ລາຍງານສະມາຊິກ";
            this.btnReportMember.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReportMember.UseVisualStyleBackColor = false;
            this.btnReportMember.Visible = false;
            this.btnReportMember.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnPagekage
            // 
            this.btnPagekage.BackColor = System.Drawing.Color.Silver;
            this.btnPagekage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPagekage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPagekage.Font = new System.Drawing.Font("Saysettha OT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagekage.ForeColor = System.Drawing.Color.Black;
            this.btnPagekage.Location = new System.Drawing.Point(7, 250);
            this.btnPagekage.Name = "btnPagekage";
            this.btnPagekage.Size = new System.Drawing.Size(186, 50);
            this.btnPagekage.TabIndex = 3;
            this.btnPagekage.Text = "ແພັກເກດ";
            this.btnPagekage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPagekage.UseVisualStyleBackColor = false;
            this.btnPagekage.Click += new System.EventHandler(this.btnPagekage_Click);
            // 
            // Panelfooter
            // 
            this.Panelfooter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panelfooter.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Panelfooter.Controls.Add(this.lbAmountBike);
            this.Panelfooter.Controls.Add(this.lbTime);
            this.Panelfooter.Controls.Add(this.lbDate);
            this.Panelfooter.Location = new System.Drawing.Point(214, 653);
            this.Panelfooter.Margin = new System.Windows.Forms.Padding(6);
            this.Panelfooter.Name = "Panelfooter";
            this.Panelfooter.Size = new System.Drawing.Size(1169, 61);
            this.Panelfooter.TabIndex = 4;
            // 
            // lbAmountBike
            // 
            this.lbAmountBike.BackColor = System.Drawing.Color.LightGray;
            this.lbAmountBike.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbAmountBike.Font = new System.Drawing.Font("Saysettha OT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAmountBike.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbAmountBike.Location = new System.Drawing.Point(730, 0);
            this.lbAmountBike.Name = "lbAmountBike";
            this.lbAmountBike.Size = new System.Drawing.Size(419, 64);
            this.lbAmountBike.TabIndex = 2;
            this.lbAmountBike.Text = "ຈຳນວນລົດ";
            this.lbAmountBike.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbTime
            // 
            this.lbTime.BackColor = System.Drawing.Color.Gainsboro;
            this.lbTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbTime.Font = new System.Drawing.Font("Saysettha OT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.Location = new System.Drawing.Point(330, -2);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(401, 64);
            this.lbTime.TabIndex = 1;
            this.lbTime.Text = "ເວລາ";
            this.lbTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDate
            // 
            this.lbDate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbDate.Font = new System.Drawing.Font("Saysettha OT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.Location = new System.Drawing.Point(-9, 0);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(348, 64);
            this.lbDate.TabIndex = 0;
            this.lbDate.Text = "ວັນທີ";
            this.lbDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbEmpty
            // 
            this.lbEmpty.BackColor = System.Drawing.Color.Silver;
            this.lbEmpty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbEmpty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbEmpty.Font = new System.Drawing.Font("Saysettha OT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmpty.ForeColor = System.Drawing.Color.Blue;
            this.lbEmpty.Location = new System.Drawing.Point(0, 66);
            this.lbEmpty.Name = "lbEmpty";
            this.lbEmpty.Size = new System.Drawing.Size(261, 60);
            this.lbEmpty.TabIndex = 3;
            this.lbEmpty.Text = "ບ່ອນຈອດຫ່ວາງ";
            this.lbEmpty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelRight
            // 
            this.PanelRight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelRight.BackColor = System.Drawing.Color.Gray;
            this.PanelRight.Controls.Add(this.Label1);
            this.PanelRight.Controls.Add(this.lbEmpty);
            this.PanelRight.Location = new System.Drawing.Point(1098, 83);
            this.PanelRight.Name = "PanelRight";
            this.PanelRight.Size = new System.Drawing.Size(286, 571);
            this.PanelRight.TabIndex = 5;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Saysettha OT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(3, 13);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(256, 43);
            this.Label1.TabIndex = 4;
            this.Label1.Text = "ຈຳນວນບ່ອນຈອດຫວ່າງ";
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.BackgroundImage = global::WindowsApplication1.Properties.Resources.Compress_16px;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnMinimize.Location = new System.Drawing.Point(1277, 21);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(16, 16);
            this.btnMinimize.TabIndex = 8;
            this.btnMinimize.Text = "-";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click_1);
            this.btnMinimize.MouseHover += new System.EventHandler(this.btnMinimize_MouseHover);
            // 
            // btnRestore
            // 
            this.btnRestore.BackColor = System.Drawing.Color.Transparent;
            this.btnRestore.BackgroundImage = global::WindowsApplication1.Properties.Resources.Restore_Window_16px;
            this.btnRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestore.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnRestore.Location = new System.Drawing.Point(1305, 21);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(16, 16);
            this.btnRestore.TabIndex = 7;
            this.btnRestore.UseVisualStyleBackColor = false;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_MouseHover);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.BackgroundImage = global::WindowsApplication1.Properties.Resources.Logout_Rounded_Down_16px;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnLogout.Location = new System.Drawing.Point(1244, 22);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(16, 16);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.Transparent;
            this.btnclose.BackgroundImage = global::WindowsApplication1.Properties.Resources.Delete_16px;
            this.btnclose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnclose.Location = new System.Drawing.Point(1330, 21);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(16, 16);
            this.btnclose.TabIndex = 0;
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Saysettha OT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(15, 42);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(198, 43);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "ໜ້າຫຼັກ";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // BunifuDragControl1
            // 
            this.BunifuDragControl1.Fixed = true;
            this.BunifuDragControl1.Horizontal = true;
            this.BunifuDragControl1.TargetControl = this;
            this.BunifuDragControl1.Vertical = true;
            // 
            // TimerCalculate
            // 
            this.TimerCalculate.Interval = 1500;
            this.TimerCalculate.Tick += new System.EventHandler(this.TimerCalculate_Tick);
            // 
            // MyToolTip
            // 
            this.MyToolTip.BackColor = System.Drawing.SystemColors.Control;
            // 
            // AutocompleteSearch
            // 
            this.AutocompleteSearch.AppearInterval = 200;
            this.AutocompleteSearch.Colors = ((AutocompleteMenuNS.Colors)(resources.GetObject("AutocompleteSearch.Colors")));
            this.AutocompleteSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.AutocompleteSearch.ImageList = null;
            this.AutocompleteSearch.Items = new string[] {
        ""};
            this.AutocompleteSearch.LeftPadding = 2;
            this.AutocompleteSearch.MaximumSize = new System.Drawing.Size(204, 400);
            this.AutocompleteSearch.MinFragmentLength = 1;
            this.AutocompleteSearch.SearchPattern = "[a-zA-Z0-9\\w\\.+]";
            this.AutocompleteSearch.TargetControlWrapper = null;
            this.AutocompleteSearch.Selected += new System.EventHandler<AutocompleteMenuNS.SelectedEventArgs>(this.AutocompleteSearch_Selected);
            // 
            // PrintPreviewDialog1
            // 
            this.PrintPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.PrintPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.PrintPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.PrintPreviewDialog1.Enabled = true;
            this.PrintPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("PrintPreviewDialog1.Icon")));
            this.PrintPreviewDialog1.Name = "PrintPreviewDialog1";
            this.PrintPreviewDialog1.Visible = false;
            // 
            // PrintDialog1
            // 
            this.PrintDialog1.UseEXDialog = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Saysettha OT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(504, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(472, 37);
            this.label5.TabIndex = 26;
            this.label5.Text = "ໂປຣແກຣມຈັດການບັດສະມາຊິກຈອດລົດຫໍພັກຊີເກມ";
            // 
            // MainComponentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1354, 720);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.PanelRight);
            this.Controls.Add(this.Panelfooter);
            this.Controls.Add(this.PanelLeft);
            this.Controls.Add(this.PanelHeader);
            this.Controls.Add(this.PanelParentContents);
            this.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.MaximumSize = new System.Drawing.Size(1800, 720);
            this.MinimumSize = new System.Drawing.Size(200, 80);
            this.Name = "MainComponentForm";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Text = "frmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.PanelHeader.ResumeLayout(false);
            this.PanelHeader.PerformLayout();
            this.PanelLeft.ResumeLayout(false);
            this.Panelfooter.ResumeLayout(false);
            this.PanelRight.ResumeLayout(false);
            this.PanelRight.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		internal Panel PanelParentContents;
		private Button withEventsField_btnRegister;
        internal Button btnRegister;
		private Button withEventsField_btnUser;
        internal Button btnUser;
 
		private Button withEventsField_btnAdd;
        internal Button btnAdd; 
		internal Panel PanelHeader;
		internal Panel PanelLeft;
		private Button withEventsField_btnMember;
        internal Button btnMember;
		private Button withEventsField_btnGerneralClient;
        internal Button btnPrintCard; 
		private Button withEventsField_btnPagekage;
        internal Button btnPagekage;  
		private Button withEventsField_btnSearch;
        internal Button btnSearch; 
		private Button withEventsField_btnDelete;
        internal Button btnDelete;  
		private Button withEventsField_btnEdit;
        internal Button btnEdit;
		private Button withEventsField_btnSave;
        internal Button btnSave; 
		internal Panel Panelfooter;
		internal Panel PanelRight;
		private Button withEventsField_btnNext;
        internal Button btnNext;  
		private Button withEventsField_btnPrevious;
        internal Button btnPrevious;  
		private Button withEventsField_btnHome;
        internal Button btnHome;
		private Button withEventsField_btnclose;
        internal Button btnclose; 
		private Button withEventsField_btnLogout;
        internal Button btnLogout; 
		internal Label lbDate;
		internal Label lbEmpty;
		internal Label lbAmountBike;
		internal Label lbTime;
		private Button withEventsField_btnReportMember;
        internal Button btnReportMember;
		private Button withEventsField_btnRestore;
        internal Button btnRestore;  
		private Button withEventsField_btnMinimize;
        internal Button btnMinimize;  
		private Button withEventsField_btnMenu;
        internal Button btnMenu;  
		private Button withEventsField_btnLast;
        internal Button btnLast;
		private Button withEventsField_btnFirst;
        internal Button btnFirst;
		internal Bunifu.Framework.UI.BunifuDragControl BunifuDragControl1;
		private WaterMark withEventsField_txtSearch;
        public WaterMark txtSearch;
		private Timer withEventsField_TimerCalculate;
        internal Timer TimerCalculate; 
		internal ToolTip MyToolTip;
		internal Label lbUsername;
		private AutocompleteMenuNS.AutocompleteMenu withEventsField_AutocompleteSearch;
        public AutocompleteMenuNS.AutocompleteMenu AutocompleteSearch;
		//private Microsoft.Reporting.WinForms.ReportViewer PrintBillMember;
		internal PrintPreviewDialog PrintPreviewDialog1;
		//private Microsoft.Reporting.WinForms.ReportViewer ReportViewer1;
		internal Label Label1;
		internal PrintDialog PrintDialog1;
		private Button withEventsField_btnAboutUs;
        internal Button bthelp;
        internal Label label5;
        internal Button btnabout;
    }
}
