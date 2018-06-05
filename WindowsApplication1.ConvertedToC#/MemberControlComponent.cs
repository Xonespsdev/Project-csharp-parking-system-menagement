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
	public partial class MemberControlComponent
	{
		public void setAutoID()
		{
			txtMemberID.Text = (Conversion.Val(Module1.getMaxID("Member_Detail", "[MID]").ToString()) + 1).ToString();
		}
		private void MemberControlComponent_Load(object sender, EventArgs e)
		{
			Module1.connectDatabase();
			txtMemberBikeID.Focus();
			setAutoID();
		}
		//@SaveMember Function
		public void SaveMember()
		{
			if (string.IsNullOrEmpty(txtMemberBikeID.Text)) {
				MessageBox.Show("ກະລຸນາປ້ອນຂໍ້ມູນໃຫ້ຄົບ", "ຜົນນການກວດສອບ");
				txtMemberBikeID.Focus();
				return;
			}
			try {
				//dr.Close()
				//(Licence,LicenceName,BName,Model,Machine_Number,color,Name,LName,CardID,Adress,Tel,Email) 
				Module1.cmd = new SqlCommand("Insert into Member_Detail values(@Licence,@LicenceName,@BName,@Model,@Machine_Number,@color,@Name,@LName,@CardID,@Adress,@Tel,@Email)", Module1.conn);
				Module1.cmd.Parameters.AddWithValue("Licence", txtMemberBikeID.Text);
				Module1.cmd.Parameters.AddWithValue("LicenceName", cbBikeIDname.Text);
				Module1.cmd.Parameters.AddWithValue("BName", txtBName.Text);
				Module1.cmd.Parameters.AddWithValue("Model", txtBModel.Text);
				Module1.cmd.Parameters.AddWithValue("Machine_Number", txtBMachineNumber.Text);
				Module1.cmd.Parameters.AddWithValue("color", txtBcolor.Text);
				Module1.cmd.Parameters.AddWithValue("Name", txtMName.Text);
				Module1.cmd.Parameters.AddWithValue("LName", txtMLName.Text);
				Module1.cmd.Parameters.AddWithValue("CardID", txtMCardID.Text);
				Module1.cmd.Parameters.AddWithValue("Adress", txtMembrAdress.Text);
				Module1.cmd.Parameters.AddWithValue("Tel", txtMphone.Text);
				Module1.cmd.Parameters.AddWithValue("Email", txtMEmail.Text);
				Module1.cmd.ExecuteNonQuery();

				ClearMemberDetail();
				txtMemberBikeID.Focus();
				Interaction.MsgBox(" ບັນທຶກຂໍ້ມູນແລ້ວ", MsgBoxStyle.Information, "ການບັນທຶກຂໍ້ມູນ");
				setAutoID();
			} catch (Exception ex) {
			}
		}
		//@Edit MemberDetail 
		public void EditMember()
		{
			try {
				if (string.IsNullOrEmpty(txtMemberBikeID.Text)) {
					MessageBox.Show("ກະລຸນາປ້ອນລະຫັດສະມາຊິກ", "ຜົນນການກວດສອບ");
					txtMemberBikeID.Focus();
					return;
				}
				if (MessageBox.Show("ທ່ານຕ້ອງການແກ້ໄຂຂໍ້ມູນນິ້ ຫຼື ບໍ່?", "ຄຳຢືນຢັນ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
					Module1.cmd = new SqlCommand("update Member_Detail Set Licence=@Licence,LicenceName=@LicenceName,BName=@BName,Model=@Model,Machine_Number=@Machine_Number,color=@color,Name=@Name,LName=@LName,CardID=@CardID,Adress=@Adress,Tel=@Tel,Email=@Email where MID=@MID", Module1.conn);
					Module1.cmd.Parameters.AddWithValue("@MID", txtMemberID.Text);
					Module1.cmd.Parameters.AddWithValue("@Licence", txtMemberBikeID.Text);
					Module1.cmd.Parameters.AddWithValue("@LicenceName", cbBikeIDname.Text);
					Module1.cmd.Parameters.AddWithValue("@BName", txtBName.Text);
					Module1.cmd.Parameters.AddWithValue("@Model", txtBModel.Text);
					Module1.cmd.Parameters.AddWithValue("@Machine_Number", txtBMachineNumber.Text);
					Module1.cmd.Parameters.AddWithValue("@color", txtBcolor.Text);
					Module1.cmd.Parameters.AddWithValue("@Name", txtMName.Text);
					Module1.cmd.Parameters.AddWithValue("@LName", txtMLName.Text);
					Module1.cmd.Parameters.AddWithValue("@CardID", txtMCardID.Text);
					Module1.cmd.Parameters.AddWithValue("@Adress", txtMembrAdress.Text);
					Module1.cmd.Parameters.AddWithValue("@Tel", txtMphone.Text);
					Module1.cmd.Parameters.AddWithValue("@Email", txtMEmail.Text);
					Module1.cmd.ExecuteNonQuery();
					MessageBox.Show(" ແກ້ໄຂຂໍ້ມູນສຳເລັດແລ້ວ!", "ແກ້ໄຂຂໍ້ມູນ");
					ClearMemberDetail();
					txtMemberBikeID.Focus();
				}

			} catch (Exception ex) {
			}
		}
		//@Delete MemberDetail
		public void DeleteMember()
		{

			try {
				if (string.IsNullOrEmpty(txtMemberBikeID.Text)) {
					MessageBox.Show("ກາລຸນາເລືອກຂໍ້ມູນສະມາຊິກກ່ອນ", "ການລຶບຂໍ້ມູນ", MessageBoxButtons.OK, MessageBoxIcon.Question);
					txtMemberBikeID.Focus();
					return;
				}
				if (MessageBox.Show("ທ່ານຕ້ອງການລຶບຂໍ້ມູນນີ້ ຫຼື ບໍ່?", "ຄຳຢືນຢັນການລຶບ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
					Module1.cmd = new SqlCommand("delete from  Member_Detail where MID = @MID", Module1.conn);
					Module1.cmd.Parameters.AddWithValue("@MID", txtMemberID.Text);
					Module1.cmd.ExecuteNonQuery();
					MessageBox.Show("ລຶບຂໍ້ມູນສຳເລັດແລ້ວ!", "ການລອບຂໍ້ມູນ", MessageBoxButtons.OK, MessageBoxIcon.Information);
					ClearMemberDetail();
					txtMemberBikeID.Focus();
				}

			} catch (Exception ex) {
			}
		}
		//@ShowMember Function
		public void ShowMember(int Member)
		{
			try {
				//dr.Close()
				Module1.cmd = new SqlCommand("select *from Member_Detail", Module1.conn);
				Module1.da = new SqlDataAdapter(Module1.cmd);
				Module1.da.Fill(Module1.table);
				Module1.table.Clear();
				Module1.da.Fill(Module1.table);
				if ((Module1.table.Rows.Count > 0)) {
					txtMemberID.Text = Module1.table.Rows[Member][0].ToString();
					txtMemberBikeID.Text = Module1.table.Rows[Member][1].ToString();
					cbBikeIDname.Text = Module1.table.Rows[Member][2].ToString();
					txtBName.Text = Module1.table.Rows[Member][3].ToString();
					txtBModel.Text = Module1.table.Rows[Member][4].ToString();
					txtBMachineNumber.Text = Module1.table.Rows[Member][5].ToString();
					txtBcolor.Text = Module1.table.Rows[Member][6].ToString();
					txtMName.Text = Module1.table.Rows[Member][7].ToString();
					txtMLName.Text = Module1.table.Rows[Member][8].ToString();
					txtMCardID.Text = Module1.table.Rows[Member][9].ToString();
					txtMembrAdress.Text = Module1.table.Rows[Member][10].ToString();
					txtMphone.Text = Module1.table.Rows[Member][11].ToString();
					txtMEmail.Text = Module1.table.Rows[Member][12].ToString();
				} else {
					Interaction.MsgBox("ບໍ່ມີຂໍ້ມູນໃນລະບົບ", MsgBoxStyle.Information, "ແຈ້ງເຕືອນ");
				}
			} catch (Exception ex) {
			}

		}
		public void SeachMember()
		{
			//Try
			//    Dim search As String = ""
			//    If MainComponentForm.txtSearch.Text = "" Then
			//        MessageBox.Show("ກາລຸນາປ້ອນຂໍ້ມູນກ່ອນ", "ແຈ້ງເຕືອນ")
			//        Exit Sub
			//    End If
			//    'Try
			//    search = "select *from Member_Detail where MID =@MID"
			//    dr.Close()
			//    cmd = New SqlCommand(search, conn)
			//    cmd.Parameters.Add("MID", SqlDbType.NVarChar).Value = MainComponentForm.txtSearch.Text
			//    da = New SqlDataAdapter(cmd)
			//    da.Fill(table)
			//    table.Clear()
			//    da.Fill(table)
			//    If (table.Rows.Count() > 0) Then
			//        txtMemberID.Text = table.Rows(0)(0).ToString
			//        txtMemberBikeID.Text = table.Rows(0)(1).ToString
			//        cbBikeIDname.Text = table.Rows(0)(2).ToString
			//        txtBName.Text = table.Rows(0)(3).ToString
			//        txtBModel.Text = table.Rows(0)(4).ToString
			//        txtBMachineNumber.Text = table.Rows(0)(5).ToString
			//        txtBcolor.Text = table.Rows(0)(6).ToString
			//        txtMName.Text = table.Rows(0)(7).ToString
			//        txtMLName.Text = table.Rows(0)(8).ToString
			//        txtMCardID.Text = table.Rows(0)(9).ToString
			//        txtMembrAdress.Text = table.Rows(0)(10).ToString
			//        txtMphone.Text = table.Rows(0)(11).ToString
			//        txtMEmail.Text = table.Rows(0)(12).ToString
			//    Else
			//        MessageBox.Show("ບໍ່ມີຂໍ້ມູນໃນລະບົບ", "ແຂ້ງເຕືອນ")
			//        MainComponentForm.txtSearch.Clear()
			//        MainComponentForm.txtSearch.Focus()
			//    End If

			//Catch ex As Exception

			//End Try
		}
		public void ClearMemberDetail()
		{
			txtMemberID.Clear();
			txtMemberBikeID.Clear();
			txtBName.Clear();
			txtBModel.Clear();
			txtBMachineNumber.Clear();
			txtBcolor.Clear();
			txtMName.Clear();
			txtMLName.Clear();
			txtMCardID.Clear();
			txtMembrAdress.Clear();
			txtMEmail.Clear();
			txtMphone.Clear();
			txtMEmail.Clear();
		}
		public void NextMember()
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
		public void PreviousMember()
		{
			Module1.index -= 1;
			if (Module1.index < 0) {
				Module1.index = 0;
			}
			ShowMember(Module1.index);

		}
		public void FirstMember()
		{
			Module1.index = 0;
			ShowMember(Module1.index);
		}
		public void LastMember()
		{
			Module1.index = Module1.table.Rows.Count - 1;
			ShowMember(Module1.index);
		}
		private void txtMemberBikeID_KeyDown(object sender, KeyEventArgs e)
		{
			if ((e.KeyCode == Keys.Enter)) {
				txtBName.Focus();
			}
		}

		private void txtBName_KeyDown(object sender, KeyEventArgs e)
		{
			if ((e.KeyCode == Keys.Enter)) {
				txtBModel.Focus();
			}
		}

		private void txtBModel_KeyDown(object sender, KeyEventArgs e)
		{
			if ((e.KeyCode == Keys.Enter)) {
				txtBMachineNumber.Focus();
			}
		}

		private void txtBMachineNumber_KeyDown(object sender, KeyEventArgs e)
		{
			if ((e.KeyCode == Keys.Enter)) {
				txtBcolor.Focus();
			}
		}

		private void txtBcolor_KeyDown(object sender, KeyEventArgs e)
		{
			if ((e.KeyCode == Keys.Enter)) {
				txtMName.Focus();
			}
		}

		private void txtMName_KeyDown(object sender, KeyEventArgs e)
		{
			if ((e.KeyCode == Keys.Enter)) {
				txtMLName.Focus();
			}
		}

		private void txtMLName_KeyDown(object sender, KeyEventArgs e)
		{
			if ((e.KeyCode == Keys.Enter)) {
				txtMCardID.Focus();
			}
		}

		private void txtMCardID_KeyDown(object sender, KeyEventArgs e)
		{
			if ((e.KeyCode == Keys.Enter)) {
				txtMembrAdress.Focus();
			}
		}

		private void txtMembrAdress_KeyDown(object sender, KeyEventArgs e)
		{
			if ((e.KeyCode == Keys.Enter)) {
				txtMphone.Focus();
			}
		}

		private void txtMphone_KeyDown(object sender, KeyEventArgs e)
		{
			if ((e.KeyCode == Keys.Enter)) {
				txtMEmail.Focus();
			}
		}

		private void txtMEmail_KeyDown(object sender, KeyEventArgs e)
		{
			if ((e.KeyCode == Keys.Enter)) {
				txtMemberBikeID.Focus();
			}
		}

		public void setSearchAutoCompletion()
		{
			//@reset
			//dr.Close()
			try {
				My.MyProject.Forms.MainComponentForm.AutocompleteSearch.Items = new string[] { "" };
				My.MyProject.Forms.MainComponentForm.AutocompleteSearch.SetAutocompleteMenu(My.MyProject.Forms.MainComponentForm.txtSearch, My.MyProject.Forms.MainComponentForm.AutocompleteSearch);
				var da_meb = Module1.getSqlDataAdapter("Select [MID] , [Licence] , [LicenceName] from Member_Detail");
				DataSet ds_meb = new DataSet();
				Module1.ClearTables(ds_meb, "Search_members");
				da_meb.Fill(ds_meb, "Search_members");
				if (ds_meb.Tables["Search_members"].Rows.Count > 0) {
					for (int i = 0; i <= ds_meb.Tables["Search_members"].Rows.Count - 1; i++) {
						AutocompleteMenuNS.AutocompleteItem itemAuto = new AutocompleteMenuNS.AutocompleteItem();
						var dtSet = ds_meb.Tables["Search_members"].Rows[i];
						itemAuto.Text = dtSet[0].ToString();
						itemAuto.ToolTipText = "Search By ID " + itemAuto.Text;
						itemAuto.ToolTipTitle = "Search A Member By ID";
						My.MyProject.Forms.MainComponentForm.AutocompleteSearch.AddItem(itemAuto);
						itemAuto = new AutocompleteMenuNS.AutocompleteItem();
						//license
						itemAuto.Text = dtSet[1].ToString();
						itemAuto.ToolTipText = "Search By Licence " + itemAuto.Text;
						itemAuto.ToolTipTitle = "Search A Member By Licence";
						My.MyProject.Forms.MainComponentForm.AutocompleteSearch.AddItem(itemAuto);
						//license name
						itemAuto = new AutocompleteMenuNS.AutocompleteItem();
						//license
						itemAuto.Text = dtSet[2].ToString();
						itemAuto.ToolTipText = "Search By LicenceName " + itemAuto.Text;
						itemAuto.ToolTipTitle = "Search A Member By LicenceName";
						My.MyProject.Forms.MainComponentForm.AutocompleteSearch.AddItem(itemAuto);
					}
				}
				My.MyProject.Forms.MainComponentForm.AutocompleteSearch.Update();
				Module1.ClearReader(ds_meb, da_meb);

			} catch (Exception ex) {
			}

		}
		//@SearchAutocompleteMember
		public void SearchByAutoComplete(string selectItem)
		{
			try {
				var search_ = "SELECT * FROM Member_Detail WHERE MID LIKE '%" + selectItem + "%' OR [Licence] LIKE N'%" + selectItem + "%' OR [LicenceName] LIKE N'%" + selectItem + "%'";
				var da_meb_search = Module1.getSqlDataAdapter(search_);
				DataSet dtSet_meb = new DataSet();
				Module1.ClearTables(dtSet_meb, "res_member");
				da_meb_search.Fill(dtSet_meb, "res_member");
				var dt_data = dtSet_meb.Tables["res_member"];
				if ((dt_data.Rows.Count > 0)) {
					txtMemberID.Text = dt_data.Rows[0][0].ToString();
					txtMemberBikeID.Text = dt_data.Rows[0][1].ToString();
					cbBikeIDname.Text = dt_data.Rows[0][2].ToString();
					txtBName.Text = dt_data.Rows[0][3].ToString();
					txtBModel.Text = dt_data.Rows[0][4].ToString();
					txtBMachineNumber.Text = dt_data.Rows[0][5].ToString();
					txtBcolor.Text = dt_data.Rows[0][6].ToString();
					txtMName.Text = dt_data.Rows[0][7].ToString();
					txtMLName.Text = dt_data.Rows[0][8].ToString();
					txtMCardID.Text = dt_data.Rows[0][9].ToString();
					txtMembrAdress.Text = dt_data.Rows[0][10].ToString();
					txtMphone.Text = dt_data.Rows[0][11].ToString();
					txtMEmail.Text = dt_data.Rows[0][12].ToString();
				} else {
					Interaction.MsgBox("ບໍ່ມີຂໍ້ມູນໃນລະບົບ", MsgBoxStyle.Information, "ແຂ້ງເຕືອນ");
					My.MyProject.Forms.MainComponentForm.txtSearch.Clear();
					My.MyProject.Forms.MainComponentForm.txtSearch.Focus();
				}

			} catch (Exception ex) {
			}

		}

	}
}
