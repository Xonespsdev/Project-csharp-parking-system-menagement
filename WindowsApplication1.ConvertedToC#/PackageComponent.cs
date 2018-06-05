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
	public partial class PackageComponent
	{
		DataTable table = new DataTable();
		private void PackageComponent_Load(object sender, EventArgs e)
		{
			Module1.connectDatabase();
		}
		public void SavePackage()
		{
			if (string.IsNullOrEmpty(txtPackageID.Text)) {
				MessageBox.Show("ກະລຸນາປ້ອນຂໍ້ມູນໃຫ້ຄົບ", "ຜົນນການກວດສອບການບັນທຶກ");
				txtPackageID.Focus();
				return;
			}

			try {
				Module1.cmd = new SqlCommand("Insert into Package values(@P_ID,@P_Name,@P_Detail,@P_Price)", Module1.conn);
				Module1.cmd.Parameters.AddWithValue("P_ID", txtPackageID.Text);
				Module1.cmd.Parameters.AddWithValue("P_Name", txtPackageName.Text);
				Module1.cmd.Parameters.AddWithValue("P_Detail", txtPackageDetail.Text);
				Module1.cmd.Parameters.AddWithValue("P_Price", txtPrice.Text);
				//   cmd.Parameters.AddWithValue("UserPhotoPath", lbPath.Text)
				Module1.cmd.ExecuteNonQuery();
				Interaction.MsgBox(" ບັນທຶກຂໍ້ມູນແລ້ວ", MsgBoxStyle.Information, "ການບັນທຶກຂໍ້ມູນ");
				ClearPackage();
				txtPackageID.Focus();
			} catch (Exception ex) {
			}
		}
		public void EditPackage()
		{
			try {
				if (string.IsNullOrEmpty(txtPackageID.Text)) {
					MessageBox.Show("ກະລຸນາປ້ອນລະຫັດສະມາຊິກ", "ຜົນນການກວດສອບ");
					txtPackageID.Focus();
					return;
				}
				if (MessageBox.Show("ທ່ານຕ້ອງການແກ້ໄຂຂໍ້ມູນນິ້ ຫຼື ບໍ່?", "ຄຳຢືນຢັນ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
					Module1.cmd = new SqlCommand("update Package Set P_Name=@P_Name,P_Detail=@P_Detail,P_Price=@P_Price where P_ID=@P_ID", Module1.conn);
					Module1.cmd.Parameters.AddWithValue("@P_ID", txtPackageID.Text);
					Module1.cmd.Parameters.AddWithValue("@P_Name", txtPackageName.Text);
					Module1.cmd.Parameters.AddWithValue("@P_Detail", txtPackageDetail.Text);
					Module1.cmd.Parameters.AddWithValue("@P_Price", txtPrice.Text);
					Module1.cmd.ExecuteNonQuery();
					Module1.da.Fill(table);
					table.Clear();
					Module1.da.Fill(table);
					Interaction.MsgBox(" ແກ້ໄຂຂໍ້ມູນສຳເລັດແລ້ວ!", MsgBoxStyle.Information, "ແກ້ໄຂຂໍ້ມູນ");
					ClearPackage();
					txtPackageID.Focus();
				}
			} catch (Exception ex) {
			}
		}
		public void DeletePackage()
		{
			try {
				if (string.IsNullOrEmpty(txtPackageID.Text)) {
					MessageBox.Show("ກາລຸນາເລືອກຂໍ້ມູນສະມາຊິກກ່ອນ", "ການລຶບຂໍ້ມູນ", MessageBoxButtons.OK, MessageBoxIcon.Question);
					txtPackageID.Focus();
					return;
				}
				if (MessageBox.Show("ທ່ານຕ້ອງການລຶບຂໍ້ມູນນີ້ ຫຼື ບໍ່?", "ຄຳຢືນຢັນການລຶບ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
					Module1.cmd = new SqlCommand("delete from  Package where P_ID=@P_ID", Module1.conn);
					Module1.cmd.Parameters.AddWithValue("@P_ID", txtPackageID.Text);
					Module1.cmd.ExecuteNonQuery();
					MessageBox.Show("ລຶບຂໍ້ມູນສຳເລັດແລ້ວ!", "ການລຶບຂໍ້ມູນ", MessageBoxButtons.OK, MessageBoxIcon.Information);
					ClearPackage();
					txtPackageID.Focus();
				}
			} catch (Exception ex) {
			}
		}
		public void SearchPackage(string st)
		{
			try {
				string search = "";
				if (st.Equals("")) {
					Interaction.MsgBox("ກາລຸນາປ້ອນຂໍ້ມູນກ່ອນ", MsgBoxStyle.Information, "ແຈ້ງເຕືອນ");
					return;
				}
				search = "select *from Package where P_ID =@P_ID";
				Module1.cmd = new SqlCommand(search, Module1.conn);
				Module1.cmd.Parameters.Add("P_ID", SqlDbType.NVarChar).Value = st;
				Module1.da = new SqlDataAdapter(Module1.cmd);
				Module1.da.Fill(table);
				table.Clear();
				Module1.da.Fill(table);
				if ((table.Rows.Count > 0)) {
					txtPackageID.Text = table.Rows[0][0].ToString();
					txtPackageName.Text = table.Rows[0][1].ToString();
					txtPackageDetail.Text = table.Rows[0][2].ToString();
					txtPrice.Text = table.Rows[0][3].ToString();
				} else {
					Interaction.MsgBox("ບໍ່ມີຂໍ້ມູນໃນລະບົບ", MsgBoxStyle.Information, "ແຈ້ງເຕືອນ");
					ClearPackage();
					txtPackageID.Focus();
				}
			} catch (Exception ex) {
			}
		}
		public void Nexts()
		{
			if (Module1.index < 0) {
				Module1.index = 0;
			}
			Module1.index += 1;
			if (Module1.index > table.Rows.Count - 1) {
				Module1.index = table.Rows.Count - 1;
			}
			ShowPackage(Module1.index);
		}
		public void Previous()
		{
			Module1.index -= 1;
			if (Module1.index < 0) {
				Module1.index = 0;
			}
			ShowPackage(Module1.index);
		}
		public void First()
		{
			Module1.index = 0;
			ShowPackage(Module1.index);
		}
		public void Last()
		{
			Module1.index = table.Rows.Count - 1;
			ShowPackage(Module1.index);
		}
		public void ShowPackage(int Package)
		{
			//Try
			Module1.cmd = new SqlCommand("select * from Package", Module1.conn);
			Module1.da = new SqlDataAdapter(Module1.cmd);
			Module1.da.Fill(table);
			table.Clear();
			Module1.da.Fill(table);
			if ((table.Rows.Count > 0)) {
				txtPackageID.Text = table.Rows[0][0].ToString();
				txtPackageName.Text = table.Rows[0][1].ToString();
				txtPackageDetail.Text = table.Rows[0][2].ToString();
				txtPrice.Text = table.Rows[0][3].ToString();
			} else {
				Interaction.MsgBox("ບໍ່ມີຂໍ້ມູນໃນລະບົບ", MsgBoxStyle.Information, "ແຂ້ງເຕືອນ");
			}
			//Catch ex As Exception
			//End Try
		}
		public void ClearPackage()
		{
			txtPackageID.Clear();
			txtPackageName.Clear();
			txtPackageDetail.Clear();
			txtPrice.Clear();
			txtPackageID.Focus();
		}
	}
}
