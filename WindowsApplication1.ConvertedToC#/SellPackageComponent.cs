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
using System.Data.SqlClient;
namespace WindowsApplication1
{
	public partial class SellPackageMemberComponent
	{
		DataSet dsM = new DataSet();
		SqlDataAdapter dap = new SqlDataAdapter();
		string OldID = "";
		private void SellPackageMemberComponent_Load(object sender, EventArgs e)
		{
			Module1.connectDatabase();
			initializeData();
		}

		private void SellPackageMemberComponent_VisibleChanged(object sender, EventArgs e)
		{
			if (Visible == true) {
				initializeData();
			}
		}
		public void setAutoID()
		{
			txtSellID.Text = (Conversion.Val(Module1.getMaxID("Sell_BillMember", "[S_ID]").ToString()) + 1).ToString();
		}
		public void initializeData()
		{
			SqlDataAdapter dap = new SqlDataAdapter("Select * from Package", Module1.conn);
			DataSet dsp = new DataSet();
			dap.Fill(dsp, "P");
			cbPackageID.DataSource = dsp.Tables[0];
			cbPackageID.DisplayMember = "P_Name";
			cbPackageID.ValueMember = "P_ID";
			this.MemberAutoID.SetAutocompleteMenu(txtSellMID, MemberAutoID);
			SetAutocompleteMemberID();
			setAutoID();
			setPrice();
			Module1.ClearReader(dsp, dap);
		}
		//@SetAutocompletememberID
		public void SetAutocompleteMemberID()
		{
			try {
				dap = new SqlDataAdapter("Select MID from Member_Detail", Module1.conn);
				dap.Fill(dsM, "Member");
				dsM.Tables["Member"].Clear();
				dap.Fill(dsM, "Member");
				if (dsM.Tables["Member"].Rows.Count > 0) {
					for (int id = 0; id <= dsM.Tables["Member"].Rows.Count - 1; id++) {
						AutocompleteMenuNS.AutocompleteItem itemAuto = new AutocompleteMenuNS.AutocompleteItem();
						itemAuto.Text = dsM.Tables["Member"].Rows[id][0].ToString();
						itemAuto.ToolTipText = "Memeber ID " + itemAuto.Text;
						itemAuto.ToolTipTitle = "Select A Member ID";
						MemberAutoID.AddItem(itemAuto);
					}
				}
				MemberAutoID.Update();
				dap.Dispose();
				dsM.Dispose();

			} catch (Exception ex) {
			}

		}

		private void MemberAutoID_Selected(object sender, AutocompleteMenuNS.SelectedEventArgs e)
		{
			txtSellMID.Text = "";
			txtSellMID.Text = e.Item.Text;
			txtSellMID.SelectionStart = txtSellMID.TextLength;
			txtSellMID.SelectionLength = 0;
			txtSellMID.ScrollToCaret();
		}

		private void cbPackageID_SelectionChangeCommitted(object sender, EventArgs e)
		{
			setPrice();
		}
		private void setPrice()
		{
			txtMPrice.Text = Module1.getSqlDataSpecifix("Package", "P_Price", "Where P_ID='" + cbPackageID.SelectedValue + "'").ToString();
		}
		public void SaveSellPackage()
		{
			if (string.IsNullOrEmpty(txtSellMID.Text)) {
				MessageBox.Show("ກະລຸນາປ້ອນຂໍ້ມູນໃຫ້ຄົບ", "ຜົນນການກວດສອບ");
				txtSellMID.Focus();
				return;
			}
			try {
				if (!Module1.IsIDExists("[Member_Detail]", "MID", txtSellMID.Text.Replace("'", "''"), "non-number")) {
					Interaction.MsgBox("ລະຫັດສະມາຊິກນີ້ຍັງທໍທັນໄດ້ລົງທະບຽນ.", MsgBoxStyle.Information, "ຜົນນການກວດສອບ");
					txtSellMID.Focus();
					return;
				}

				if (Module1.IsIDExists("Sell_BillMember", "MID", txtSellMID.Text.Replace("'", "''"), "non-number")) {
					Interaction.MsgBox("ລະຫັດສະມາຊິກນີ້ໄດ້ສະໝັກສະມາຊິກຮຽບຮ້ອຍແລ້ວ!.", MsgBoxStyle.Information, "ຜົນນການກວດສອບ");
					txtSellMID.Focus();
					return;
				}
				Module1.cmd = new SqlCommand("Insert into [Sell_BillMember] values(@Mid,@P_ID,@S_Date,@S_Time)", Module1.conn);
				Module1.cmd.Parameters.AddWithValue("Mid", txtSellMID.Text);
				Module1.cmd.Parameters.AddWithValue("P_ID", cbPackageID.SelectedValue);
                Module1.cmd.Parameters.AddWithValue("S_Date", SellDate.Text);//.Value.format("hh:mm:ss: tt");
                Module1.cmd.Parameters.AddWithValue("S_Time", SellTime.Text);
				Module1.cmd.ExecuteNonQuery();

				ClearSellBillMember();
				txtSellMID.Focus();
				Interaction.MsgBox(" ບັນທຶກຂໍ້ມູນແລ້ວ", MsgBoxStyle.Information, "ການບັນທຶກຂໍ້ມູນ");
				setAutoID();
				setPrice();
			} catch (Exception ex) {
			}
		}


		public void EditSellPackage()
		{
			try {
				if (string.IsNullOrEmpty(txtSellMID.Text)) {
					Interaction.MsgBox("ກະລຸນາປ້ອນລະຫັດສະມາຊິກ", MsgBoxStyle.Information, "ຜົນນການກວດສອບ");
					txtSellMID.Focus();
					return;
				}

				if (!Module1.IsIDExists("[Member_Detail]", "MID", txtSellMID.Text.Replace("'", "''"), "non-number")) {
					MessageBox.Show("ລະຫັດສະມາຊິກນີ້ຍັງທໍທັນໄດ້ລົງທະບຽນ.", "ຜົນນການກວດສອບ");
					txtSellMID.Focus();
					return;
				}

				if (Module1.IsIDExists("Sell_BillMember", "MID", OldID.Replace("'", "''"), "non-number", true, txtSellMID.Text.Replace("'", "''"))) {
					Interaction.MsgBox("ລະຫັດສະມາຊິກນີ້ໄດ້ສະໝັກສະມາຊິກຮຽບຮ້ອຍແລ້ວ.", MsgBoxStyle.Information, "ຜົນນການກວດສອບ");
					txtSellMID.Focus();
					return;
				}

				if (MessageBox.Show("ທ່ານຕ້ອງການແກ້ໄຂຂໍ້ມູນນິ້ ຫຼື ບໍ່?", "ຄຳຢືນຢັນ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
					Module1.cmd = new SqlCommand("update Sell_BillMember Set Mid=@Mid,P_ID=@P_ID,S_Date=@S_Date,S_Time=@S_Time where S_ID=@S_ID", Module1.conn);
					Module1.cmd.Parameters.AddWithValue("@S_ID", txtSellID.Text);
					Module1.cmd.Parameters.AddWithValue("@Mid", txtSellMID.Text);
					Module1.cmd.Parameters.AddWithValue("@P_ID", cbPackageID.SelectedValue);
					Module1.cmd.Parameters.AddWithValue("@S_Date", Strings.Format(Convert.ToDateTime(SellDate.Text), "yyyy-MM-dd"));
					Module1.cmd.Parameters.AddWithValue("@S_Time", SellTime.Text);
					Module1.cmd.ExecuteNonQuery();
					ClearSellBillMember();
					txtSellMID.Focus();
					Interaction.MsgBox("ແກ້ໄຂຂໍ້ມູນແລ້ວ", MsgBoxStyle.Information, "ການແກ້ໄຂຂໍ້ມູນ");
					setAutoID();
					setPrice();
					OldID = "";
				}

			} catch (Exception ex) {

			}
		}
		//@DeleteSellPackage
		public void DeleteSellPackage()
		{

			try {
				if (string.IsNullOrEmpty(txtSellMID.Text)) {
					MessageBox.Show("ກາລຸນາເລືອກຂໍ້ມູນສະມາຊິກກ່ອນ", "ການລຶບຂໍ້ມູນ", MessageBoxButtons.OK, MessageBoxIcon.Question);
					txtSellMID.Focus();
					return;
				}
				if (MessageBox.Show("ທ່ານຕ້ອງການລຶບຂໍ້ມູນນີ້ ຫຼື ບໍ່?", "ຄຳຢືນຢັນການລຶບ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
					Module1.cmd = new SqlCommand("delete from  Sell_BillMember where S_ID = @S_ID", Module1.conn);
					Module1.cmd.Parameters.AddWithValue("@S_ID", txtSellID.Text);
					Module1.cmd.ExecuteNonQuery();
					MessageBox.Show("ລຶບຂໍ້ມູນສຳເລັດແລ້ວ!", "ການລອບຂໍ້ມູນ", MessageBoxButtons.OK, MessageBoxIcon.Information);
					ClearSellBillMember();
					txtSellMID.Focus();
					setAutoID();
					setPrice();
					OldID = "";
				}

			} catch (Exception ex) {
			}
		}
		//@SetSearchAutocomplete
		public void setSearchAutoCompletion()
		{
			//@reset
			try {
				//dr.Close()
				My.MyProject.Forms.MainComponentForm.AutocompleteSearch.Items = new string[] { "" };
				My.MyProject.Forms.MainComponentForm.AutocompleteSearch.SetAutocompleteMenu(My.MyProject.Forms.MainComponentForm.txtSearch, My.MyProject.Forms.MainComponentForm.AutocompleteSearch);
				var da_meb = Module1.getSqlDataAdapter("Select [S_ID] from Sell_BillMember");
				DataSet ds_meb = new DataSet();
				Module1.ClearTables(ds_meb, "Search_Bill_Member");
				da_meb.Fill(ds_meb, "Search_Bill_Member");
				if (ds_meb.Tables["Search_Bill_Member"].Rows.Count > 0) {
					for (int i = 0; i <= ds_meb.Tables["Search_Bill_Member"].Rows.Count - 1; i++) {
						AutocompleteMenuNS.AutocompleteItem itemAuto = new AutocompleteMenuNS.AutocompleteItem();
						var dtSet = ds_meb.Tables["Search_Bill_Member"].Rows[i];
						itemAuto.Text = dtSet[0].ToString();
						itemAuto.ToolTipText = "Search By Sell Package ID " + itemAuto.Text;
						itemAuto.ToolTipTitle = "Search A Sell Package By ID";
						My.MyProject.Forms.MainComponentForm.AutocompleteSearch.AddItem(itemAuto);
					}
				}
				My.MyProject.Forms.MainComponentForm.AutocompleteSearch.Update();
				Module1.ClearReader(ds_meb, da_meb);
			} catch (Exception ex) {
			}

		}

		//@SearchAutocomplete
		public void SearchByAutoComplete(string selectItem)
		{
			DateTime myDate = SellDate.Value.Date;
			try {
				var search_ = "SELECT * FROM Sell_BillMember WHERE S_ID='" + selectItem + "'";
				var da_search = Module1.getSqlDataAdapter(search_);
				DataSet dS_Bill = new DataSet();
				Module1.ClearTables(dS_Bill, "Bill_Member");
				da_search.Fill(dS_Bill, "Bill_Member");
				var dtS = dS_Bill.Tables["Bill_Member"];
				if ((dtS.Rows.Count > 0)) {
					txtSellID.Text = dtS.Rows[0][0].ToString();
					txtSellMID.Text = dtS.Rows[0][1].ToString();
					cbPackageID.SelectedValue = dtS.Rows[0][2].ToString();
					SellDate.Text = dtS.Rows[0][3].ToString();
					SellTime.Text = dtS.Rows[0][4].ToString();
					OldID = dtS.Rows[0][1].ToString();
					setPrice();
				} else {
					Interaction.MsgBox("ບໍ່ມີຂໍ້ມູນໃນລະບົບ", MsgBoxStyle.Information, "ແຈ້ງເຕືອນ");
					My.MyProject.Forms.MainComponentForm.txtSearch.Clear();
					My.MyProject.Forms.MainComponentForm.txtSearch.Focus();
				}

			} catch (Exception ex) {
			}

		}
		public void ClearSellBillMember()
		{
			txtSellMID.Clear();
			txtMPrice.Clear();
			//cbPackageID.SelectedIndex = 0
		}

		public void Nexts()
		{
			if (Module1.index < 0) {
				Module1.index = 0;
			}
			Module1.index += 1;
			if (Module1.index > Module1.table.Rows.Count - 1) {
				Module1.index = Module1.table.Rows.Count - 1;
			}
			ShowMember(Module1.index);
		}
		public void Previous()
		{
			Module1.index -= 1;
			if (Module1.index < 0) {
				Module1.index = 0;
			}
			ShowMember(Module1.index);

		}
		public void First()
		{
			Module1.index = 0;
			ShowMember(Module1.index);
		}
		public void Last()
		{
			Module1.index = Module1.table.Rows.Count - 1;
			ShowMember(Module1.index);
		}
		public void ShowMember(int Member)
		{
			DataTable dts = new DataTable();
			try {
				//dr.Close()
				Module1.cmd = new SqlCommand("select * from Sell_BillMember", Module1.conn);
				Module1.da = new SqlDataAdapter(Module1.cmd);
				Module1.da.Fill(Module1.table);
				Module1.table.Clear();
				Module1.da.Fill(Module1.table);
				if ((Module1.table.Rows.Count > 0)) {
					txtSellID.Text = dts.Rows[Member][0].ToString();
					txtSellMID.Text = dts.Rows[Member][1].ToString();
					cbPackageID.Text = dts.Rows[Member][2].ToString();
					SellDate.Text = dts.Rows[Member][3].ToString();
					SellTime.Text = dts.Rows[Member][4].ToString();
					setPrice();
				} else {
					Interaction.MsgBox("ບໍ່ມີຂໍ້ມູນໃນລະບົບ", MsgBoxStyle.Information, "ແຂ້ງເຕືອນ");
				}
			} catch (Exception ex) {
			}
		}
		public SellPackageMemberComponent()
		{
			VisibleChanged += SellPackageMemberComponent_VisibleChanged;
			Load += SellPackageMemberComponent_Load;
			InitializeComponent();
		}
	}
}
