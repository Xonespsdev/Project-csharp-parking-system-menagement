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
using System.ComponentModel;
namespace WindowsApplication1
{
	public partial class frmLogin
	{
		SqlDataReader dr;
		DataTable dt = new DataTable();
		private void frmLogin_Load(object sender, EventArgs e)
		{
            try
            {
            txtPassword.UseSystemPasswordChar = true;
			Module1.connectDatabase();
            } catch (Exception ex)
            {

            }
			
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			Login();
		}

		private void btnclose_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("ທ່ານຕ້ອງການອອກຈາກໂປຣແກມ ຫຼື ບໍ່?", " ຄຳຢືນຢັນ ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
				this.Close();
			}
		}

		private void txtUsername_KeyDown(object sender, KeyEventArgs e)
		{
			if ((e.KeyCode == Keys.Enter)) {
				txtPassword.Focus();
			}

		}

		private void txtPassword_KeyDown(object sender, KeyEventArgs e)
		{
			if ((e.KeyCode == Keys.Enter)) {
				btnLogin.Focus();
				Login();
			}
		}
		public void Login()
		{
			bool UserFound = false;
			if (string.IsNullOrEmpty(txtUsername.Text)) {
				MessageBox.Show("ກາລຸນາປ້ອນຊື່ຜູ້ໃຊ້ ແລະ ລະຫັດຜ່ານ", "ກວດສອບຄວາມຖືກຕ້ອງ");
				txtPassword.Clear();
				return;
			}
			if (string.IsNullOrEmpty(txtPassword.Text)) {
				MessageBox.Show("ກາລຸນາປ້ອນ ຊື່ຜູ້ໃຊ້ ແລະ ລະຫັດຜ່ານ", "ກວດສອບຄວາມຖືກຕ້ອງ");
				txtUsername.Clear();
				return;
			}
			//try {
				Module1.cmd = new SqlCommand("Select * from TB_User where UserName=@UserName and UserPassword=@UserPassword", Module1.conn);
				Module1.cmd.Parameters.AddWithValue("UserName", txtUsername.Text);
				Module1.cmd.Parameters.AddWithValue("UserPassword", txtPassword.Text);
				dr = Module1.cmd.ExecuteReader();
				if (dr.HasRows) {
					Module1.Username = txtUsername.Text;
					dt.Load(dr);
					Module1.UserAuthor = dt.Rows[0][3].ToString();
					MainComponentForm frm = new MainComponentForm();
					this.Hide();
					frm.ShowDialog();
					this.Close();
					dr.Close();
					dt.Clear();

				} else {
					Interaction.MsgBox("ຊື່ຜູ້ໃຊ້ແລະລະຫັດຜ່ານບໍ່ຖືກຕ້ອງ", MsgBoxStyle.OkOnly, "ການກວດສອບ");
					txtUsername.Clear();
					txtPassword.Clear();
					txtUsername.Focus();
					dr.Close();
					//dt.Clear()
				}

			//} catch (Exception ex) {
			//}

		}
	}
}
