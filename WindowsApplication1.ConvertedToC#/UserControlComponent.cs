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
	public partial class UserControlComponent
	{
		DataTable table = new DataTable();
		private void UserControlComponent_Load(object sender, EventArgs e)
		{
			//txtPassword.UseSystemPasswordChar = True
			Module1.connectDatabase();
            setAutoID();

        }
        public void setAutoID()
        {
            txtUserID.Text = (Conversion.Val(Module1.getMaxID("Member_Detail", "[MID]").ToString()) + 1).ToString();
        }
        public void SaveUser()
		{
			if (string.IsNullOrEmpty(txtUserName.Text)) {
				MessageBox.Show("ກະລຸນາປ້ອນຂໍ້ມູນໃຫ້ຄົບ", "ຜົນນການກວດສອບການບັນທຶກ");
				txtUserID.Focus();
				return;
			}
			//try {
				Module1.cmd = new SqlCommand("Insert into TB_User values(@UserName,@UserPassword,@UserRole)", Module1.conn);
				Module1.cmd.Parameters.AddWithValue("UserID", txtUserID.Text);
				Module1.cmd.Parameters.AddWithValue("UserName", txtUserName.Text);
				Module1.cmd.Parameters.AddWithValue("UserPassword", txtPassword.Text);
				Module1.cmd.Parameters.AddWithValue("UserRole", cbRoll.Text);
				Module1.cmd.ExecuteNonQuery();
				Interaction.MsgBox(" ບັນທຶກຂໍ້ມູນແລ້ວ", MsgBoxStyle.Information, "ການບັນທຶກຂໍ້ມູນ");
				clearUser();
				txtUserID.Focus();
            setAutoID();
			//} catch (Exception ex) {
			//}
		}
		public void DeleteUsers()
		{

			try {
				if (string.IsNullOrEmpty(txtUserID.Text)) {
					MessageBox.Show("ກະລຸນາເລືອກຂໍ້ມູນທີຕ້ອງລຶບກ່ອນ", "ຜົນນການກວດສອບການລົບ");
					txtUserID.Focus();
					return;
				}
				if (MessageBox.Show("ເຈົ້າຕ້ງການລຶບຂໍ້ມູນນີ້ ຫຼື ບໍ່?", "ຄຳຢືນຢັນ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
					Module1.cmd = new SqlCommand("delete from  TB_User where UserID=@UserID", Module1.conn);
					Module1.cmd.Parameters.AddWithValue("@UserID", txtUserID.Text);
					Module1.cmd.ExecuteNonQuery();
					txtUserID.Focus();
					clearUser();
				}

			} catch (Exception ex) {
			}
		}
		public void EditUser()
		{
			try {
				if (string.IsNullOrEmpty(txtUserID.Text)) {
					MessageBox.Show("ກະລຸນາປ້ອນລະຫັດສະມາຊິກ", "ຜົນນການກວດສອບ");
					txtUserID.Focus();
					return;
				}
				if (MessageBox.Show("ທ່ານຕ້ອງການແກ້ໄຂຂໍ້ມູນນິ້ ຫຼື ບໍ່?", "ຄຳຢືນຢັນ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
					Module1.cmd = new SqlCommand("update TB_User Set UserName=@UserName,UserPassword=@UserPassword,UserRole=@UserRole where UserID=@UserID", Module1.conn);
					Module1.cmd.Parameters.AddWithValue("@UserID", txtUserID.Text);
					Module1.cmd.Parameters.AddWithValue("@UserName", txtUserName.Text);
					Module1.cmd.Parameters.AddWithValue("@UserPassword", txtPassword.Text);
					Module1.cmd.Parameters.AddWithValue("@UserRole", cbRoll.Text);
					Module1.cmd.ExecuteNonQuery();
					Interaction.MsgBox(" ແກ້ໄຂຂໍ້ມູນສຳເລັດແລ້ວ!", MsgBoxStyle.Information, "ແກ້ໄຂຂໍ້ມູນ");

					clearUser();
					txtUserID.Focus();
				}

			} catch (Exception ex) {
			}

		}
		public void SearchUser(string st)
		{
			string search = "";
			if (st.Equals("")) {
				Interaction.MsgBox("ກາລຸນາປ້ອນຂໍ້ມູນກ່ອນ", MsgBoxStyle.Information, "ແຈ້ງເຕືອນ");
				return;
			}
			try {
				search = "select *from TB_User where UserID =@UserID";
				Module1.cmd = new SqlCommand(search, Module1.conn);
				Module1.cmd.Parameters.Add("UserID", SqlDbType.NVarChar).Value = st;
				Module1.da = new SqlDataAdapter(Module1.cmd);
				Module1.da.Fill(table);
				table.Clear();
				Module1.da.Fill(table);

				if ((table.Rows.Count > 0)) {
					txtUserID.Text = table.Rows[0][0].ToString();
					txtUserName.Text = table.Rows[0][1].ToString();
					txtPassword.Text = table.Rows[0][2].ToString();
					cbRoll.Text = table.Rows[0][3].ToString();
				} else {
					Interaction.MsgBox("ບໍ່ມີຂໍ້ມູນໃນລະບົບ", MsgBoxStyle.Information, "ແຈ້ງເຕືອນ");
					clearUser();
					txtUserID.Focus();
				}
			} catch (Exception ex) {
			}

		}
		public void clearUser()
		{
			txtUserID.Clear();
			txtUserName.Clear();
			txtPassword.Clear();
			cbRoll.SelectedIndex = 0;
		}
		public void NextUser()
		{
			if (Module1.index < 0) {
				Module1.index = 0;
			}
			Module1.index += 1;
			if (Module1.index > table.Rows.Count - 1) {
				Module1.index = table.Rows.Count - 1;
			}
			ShowUser(Module1.index);
		}
		public void Previous()
		{
			Module1.index -= 1;
			if (Module1.index < 0) {
				Module1.index = 0;
			}
			ShowUser(Module1.index);

		}
		public void FirstUser()
		{
			Module1.index = 0;
			ShowUser(Module1.index);
		}
		public void LastUser()
		{
			Module1.index = table.Rows.Count - 1;
			ShowUser(Module1.index);
		}
		public void ShowUser(int user)
		{
			try {
				Module1.cmd = new SqlCommand("select *from TB_User", Module1.conn);
				Module1.da = new SqlDataAdapter(Module1.cmd);
				Module1.da.Fill(table);
				Module1.ds.Clear();
				Module1.da.Fill(table);
				if ((table.Rows.Count > 0)) {
					txtUserID.Text = table.Rows[user][0].ToString();
					txtUserName.Text = table.Rows[user][1].ToString();
					txtPassword.Text = table.Rows[user][2].ToString();
					cbRoll.Text = table.Rows[user][3].ToString();
				} else {
					Interaction.MsgBox("ບໍ່ມີຂໍ້ມູນໃນລະບົບ", MsgBoxStyle.Information, "ແຈ້ງເຕືອນ");
				}

			} catch (Exception ex) {
			}

		}

		private void txtUserID_KeyUp(object sender, KeyEventArgs e)
		{
			if ((e.KeyCode == Keys.Enter)) {
				txtUserName.Focus();
			}
		}
		private void txtUserName_KeyUp(object sender, KeyEventArgs e)
		{
			if ((e.KeyCode == Keys.Enter)) {
				txtPassword.Focus();
			}
		}
	}
}
