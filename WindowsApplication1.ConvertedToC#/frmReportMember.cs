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
	public partial class frmReportMember
	{
		private void frmBillMember_Load(object sender, EventArgs e)
		{
			//ReportViewer1.Show();
		}
		public frmReportMember()
		{
			Load += frmBillMember_Load;
			InitializeComponent();
		}
	}
}
