using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowsApplication1
{
    public partial class PrintCard : Form
    {
        public PrintCard()
        {
            InitializeComponent();
        }

        private void txtprint_Click(object sender, EventArgs e)
        {
            string sql = @"SELECT Member_Detail.Licence, Member_Detail.LicenceName, Sell_BillMember.S_Date, Package.P_Price, Sell_BillMember.S_ID
              FROM(Parking.dbo.Sell_BillMember Sell_BillMember INNER JOIN Parking.dbo.Member_Detail Member_Detail ON Sell_BillMember.MID = Member_Detail.MID) INNER JOIN Parking.dbo.Package Package ON Sell_BillMember.P_ID = Package.P_ID ='" +txtprint.Text +"'";
            Module1.connectDatabase();
            SqlDataAdapter da = new SqlDataAdapter(sql, Module1.strcon);
            DataSet ds = new DataSet();
            PrintCard frmPrint = new PrintCard();
            rptPrintCard rptPint = new rptPrintCard();
            frmReportCardBill print = new frmReportCardBill();
            //Module1.da.Fill(frmPrint, "print");
            //if ()
            //print.crystalReportPintcard.
           // print.ShowDialog();
        }
    }
}
