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
	public partial class AboutUsComponent
	{
		private void frmautoid_Load(object sender, EventArgs e)
		{
			Module1.connectDatabase();
		}
		public AboutUsComponent()
		{
			Load += frmautoid_Load;
			InitializeComponent();
		}
		//Sub SaveAuto()

		//    cmd = New SqlCommand("Insert into Autoincrement(Name) values(@Name)", conn)
		//    cmd.Parameters.AddWithValue("Name", txtName.Text)
		//    cmd.ExecuteNonQuery()
		//    MessageBox.Show("test")
		//End Sub
	}
}
