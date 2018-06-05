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
using CrystalDecisions.CrystalReports.Engine;
namespace WindowsApplication1
{
	public partial class MainComponentForm
	{
		UserControlComponent user = new UserControlComponent();
		MemberControlComponent meb = new MemberControlComponent();
		PrintCard print = new PrintCard();
		PackageComponent package = new PackageComponent();
		SellPackageMemberComponent SellBill = new SellPackageMemberComponent();
		frmAboutus aboutus = new frmAboutus();
         //MBReport cryRpt = new MBReport();
        frmHowtouse help = new frmHowtouse();
        frmReportMember rptReportMember = new frmReportMember();
      

        frmLogin frmlogin = new frmLogin();
		private void btnUser_Click(object sender, EventArgs e)
		{
			removeAll();
			removecolor();
			user.Dock = DockStyle.Fill;
			PanelParentContents.Controls.Add(user);
			user.Visible = true;
			btnUser.BackColor = Color.Blue;
		}
		//@set bike amount 
		private void setBikeAmout()
		{
			int AmountMember = 0;
			int Gr = 0;
			Module1.AmountBike = (int)(Conversion.Val(Module1.getAgree("[Sell_BillMember]", "*", "Count")) + Conversion.Val(Module1.getAgree("[Genral_Client]", "*", "Count")));
			AmountMember = (int)Conversion.Val(Module1.getAgree("[Sell_BillMember]", "*", "Count"));
			Gr = (int)Conversion.Val(Module1.getAgree("[Genral_Client]", "*", "Count"));
		//	lbGerneralClient.Text = Gr + " ຄັນ";
		//	lbamountMember.Text = AmountMember + " ຄັນ";
			lbAmountBike.Text = "ລວມຈຳນວນລົດ: " + AmountMember + " ຄັນ";
			lbEmpty.Text = (Module1.AmountParking - Module1.AmountBike) + " ບ່ອນ ";
		}
		//@load
		private void MainComponent_Load(object sender, EventArgs e)
		{
			setBikeAmout();
			TimerCalculate.Enabled = true;
			this.AllowDrop = true;
			lbTime.Text = DateAndTime.TimeOfDay.ToString("h:mm:ss:tt");
			lbDate.Text = DateAndTime.Now.Date.ToShortDateString();

			lbUsername.Text = "ຊື່ຜູ້ໃຊ້ລະບົບ: " + Module1.Username;
			//UserAuthor = UserAuthor.Replace(" ", "")
			Module1.UserAuthor = Strings.Trim(Module1.UserAuthor);
			if (Module1.UserAuthor.Equals("ພະນັກງານທົ່ວໄປ")) {
				Staff();
			} else if (Module1.UserAuthor.Equals("ຜູ້ບໍລິຫານລະບົບ")) {
				Admin();
			}
			MenuVisibleflase();
		}
		public void Admin()
		{
			btnRegister.Enabled = true;
			btnUser.Enabled = true;
			btnPagekage.Enabled = true;
			btnPrintCard.Enabled = true;
			btnMember.Enabled = true;
		}
		public void Staff()
		{
			btnRegister.Enabled = true;
			btnUser.Enabled = false;
			btnPagekage.Enabled = false;
			btnPrintCard.Enabled = true;
			btnMember.Enabled = true;
		}

		private void removeAll()
		{
			foreach (Control com in PanelParentContents.Controls) {
				com.Visible = false;
			}
		}

		private void removecolor()
		{
			btnMember.BackColor = Color.Silver;
			btnPrintCard.BackColor = Color.Silver;
			btnUser.BackColor = Color.Silver;
			btnPagekage.BackColor = Color.Silver;
			btnRegister.BackColor = Color.Silver;
			bthelp.BackColor = Color.Silver;
			btnReportMember.BackColor = Color.Silver;
            btnabout.BackColor = Color.Silver;
            btnPrintCard.BackColor = Color.Silver;
            

		}
		private void btnPagekage_Click(object sender, EventArgs e)
		{
			removeAll();
			removecolor();
			package.Dock = DockStyle.Fill;
			PanelParentContents.Controls.Add(package);
			package.Visible = true;
			btnPagekage.BackColor = Color.Blue;
		}

		private void btnMember_Click(object sender, EventArgs e)
		{
			removeAll();
			removecolor();
			SellBill.Dock = DockStyle.Fill;
			PanelParentContents.Controls.Add(SellBill);
			SellBill.Visible = true;
			btnMember.BackColor = Color.Blue;
			SellBill.setSearchAutoCompletion();
		}
		private void btnabout_Click(object sender, EventArgs e)
		{
			removeAll();
			removecolor();
			aboutus.Dock = DockStyle.Fill;
			PanelParentContents.Controls.Add(aboutus);
			aboutus.Visible = true;
			//bthelp.BackColor = Color.Blue;
		}

		private void btnRegister_Click(object sender, EventArgs e)
		{
			removeAll();
			removecolor();
			meb.Dock = DockStyle.Fill;
			PanelParentContents.Controls.Add(meb);
			meb.Visible = true;
			btnRegister.BackColor = Color.Blue;
			meb.setSearchAutoCompletion();
		}
		private void btnclose_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("ທ່ານຕ້ອງການອອກຈາກໂປຣແກມ ຫຼື ບໍ່?", " ຄຳຢືນຢັນ ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
				this.Close();
			}
		}


		private void btnAdd_Click(object sender, EventArgs e)
		{

			if (btnUser.BackColor == Color.Blue) {
				user.clearUser();
			} else if (btnRegister.BackColor == Color.Blue) {
				meb.ClearMemberDetail();
				meb.setAutoID();
			} else if (btnPagekage.BackColor == Color.Blue) {
				package.ClearPackage();
			//} else if (btnGerneralClient.BackColor == Color.Blue) {
			//	grc.ClearGeneralClient();
			//	grc.AutoNumberClientID();
			} else if (btnMember.BackColor == Color.Blue) {
				SellBill.ClearSellBillMember();
				SellBill.setAutoID();
			}
		}

		private void btnHome_Click(object sender, EventArgs e)
		{
			removeAll();
			MenuVisibleflase();
		}
		//@Save Function
		private void btnSave_Click(object sender, EventArgs e)
		{
			if (btnPagekage.BackColor == Color.Blue) {
				package.SavePackage();
			} else if (btnRegister.BackColor == Color.Blue) {
				meb.SaveMember();
			//} else if (btnGerneralClient.BackColor == Color.Blue) {
			//	grc.SaveGeneralClient();
			} else if (btnUser.BackColor == Color.Blue) {
				user.SaveUser();
			} else if (btnMember.BackColor == Color.Blue) {
				SellBill.SaveSellPackage();
			}

		}
		//@Edit Function

		private void btnEdit_Click(object sender, EventArgs e)
		{
			if (btnUser.BackColor == Color.Blue) {
				user.EditUser();
			} else if (btnPagekage.BackColor == Color.Blue) {
				package.EditPackage();
			} else if (btnRegister.BackColor == Color.Blue) {
				meb.EditMember();
			//} else if (btnGerneralClient.BackColor == Color.Blue) {
			//	grc.EditGenerlaClient();
			} else if (btnMember.BackColor == Color.Blue) {
				SellBill.EditSellPackage();
			}
		}
		//@Delete Function

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (btnUser.BackColor == Color.Blue) {
				user.DeleteUsers();
			} else if (btnPagekage.BackColor == Color.Blue) {
				package.DeletePackage();
			} else if (btnRegister.BackColor == Color.Blue) {
				meb.DeleteMember();
			//} else if (btnGerneralClient.BackColor == Color.Blue) {
			//	grc.DeleteGeneralClient();
			} else if (btnMember.BackColor == Color.Blue) {
				SellBill.DeleteSellPackage();
			}
		}
		//@Search Function
		public void Search()
		{
			if (btnPagekage.BackColor == Color.Blue) {
				package.SearchPackage(txtSearch.Text);
			} else if (btnRegister.BackColor == Color.Blue) {
				meb.SearchByAutoComplete(txtSearch.Text.Replace("'", "''"));
			//} else if (btnGerneralClient.BackColor == Color.Blue) {
			//	grc.ShearchGeneralClient(txtSearch.Text);
			} else if (btnMember.BackColor == Color.Blue) {
				SellBill.SearchByAutoComplete(txtSearch.Text.Replace("'", "''"));
			} else if (btnUser.BackColor == Color.Blue) {
				user.SearchUser(txtSearch.Text);
			}
		}
		private void btnSearch_Click(object sender, EventArgs e)
		{
			Console.WriteLine(txtSearch.Text);
			Search();
		}

		//@AutocompleteSearch
		private void AutocompleteSearch_Selected(object sender, AutocompleteMenuNS.SelectedEventArgs e)
		{
			if (btnUser.BackColor == Color.Blue) {
			} else if (btnRegister.BackColor == Color.Blue) {
				meb.SearchByAutoComplete(e.Item.Text.Replace("'", "''"));
			} else if (btnPagekage.BackColor == Color.Blue) {
			} else if (btnMember.BackColor == Color.Blue) {
				SellBill.SearchByAutoComplete(e.Item.Text.Replace("'", "'"));

			} else if (btnPrintCard.BackColor == Color.Blue) {
			}
		}

     //   ReportDocument cryrpt = new ReportDocument();
        
		private void btnReport_Click(object sender, EventArgs e)
		{
			removeAll();
			removecolor();
            // cryRpt.Dock = DockStyle.Fill
            //  PanelParentContents.Controls.Add(cryRpt)
          // cryRpt.Visible = true;
            	btnReportMember.BackColor = Color.Blue;
            frmReportMember bill = new frmReportMember();
            bill.Show();

          //  cryrpt.Load("Put crystall report \\Crystall report.rpt");

        }

		private void btnMinimize_Click(object sender, EventArgs e)
		{
			btnRestore.Image = Image.FromFile("E:\\Parking System\\WindowsApplication1\\Resources\\Restore16px.png");
			if (this.WindowState == FormWindowState.Maximized) {
				this.WindowState = FormWindowState.Normal;
				btnRestore.Image = Image.FromFile("E:\\Parking System\\WindowsApplication1\\Resources\\Maximize16px.png");
			} else {
				this.WindowState = FormWindowState.Maximized;
			}
		}

		private void btnMinimize_Click_1(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void btnMenu_Click(object sender, EventArgs e)
		{
			MenuVisibletrue();
			if (Module1.UserAuthor.Equals("ພະນັກງານທົ່ວໄປ")) {
				Staff();
			} else if (Module1.UserAuthor.Equals("ຜູ້ບໍລິຫານລະບົບ")) {
				Admin();
			}
		}
		public void MenuVisibletrue()
		{
			btnRegister.Visible = true;
			btnUser.Visible = true;
			btnPagekage.Visible = true;
			btnMember.Visible = true;
			btnPrintCard.Visible = true;
			btnReportMember.Visible = true;
			bthelp.Visible = true;
            btnabout.Visible = true;
            btnPrintCard.Visible = true;
		}
		public void MenuVisibleflase()
		{
			btnRegister.Visible = false;
			btnUser.Visible = false;
			btnPagekage.Visible = false;
			btnMember.Visible = false;
			btnPrintCard.Visible = false;
			btnReportMember.Visible = false;
			bthelp.Visible = false;
            btnabout.Visible = false;
            btnPrintCard.Visible = false;
		}

		private void MainComponent_DragDrop(object sender, DragEventArgs e)
		{
			string[] files =(string[]) e.Data.GetData(DataFormats.FileDrop);
			foreach (string path in files) {
				Interaction.MsgBox(path);
			}
		}

		//@Next,Previous, First, Last
		private void btnNext_Click(object sender, EventArgs e)
		{
			if (btnUser.BackColor == Color.Blue) {
				user.NextUser();
			} else if (btnRegister.BackColor == Color.Blue) {
				meb.NextMember();
			} else if (btnMember.BackColor == Color.Blue) {
				SellBill.Nexts();
			//} else if (btnGerneralClient.BackColor == Color.Blue) {
			//	grc.NextGenneralClient();
			} else if (btnPagekage.BackColor == Color.Blue) {
				package.Nexts();
			}
		}

		private void btnPrevious_Click(object sender, EventArgs e)
		{
			if (btnUser.BackColor == Color.Blue) {
				user.Previous();
			} else if (btnRegister.BackColor == Color.Blue) {
			} else if (btnMember.BackColor == Color.Blue) {
				SellBill.Previous();
			//} else if (btnGerneralClient.BackColor == Color.Blue) {
			//	grc.PreviousGClient();
			} else if (btnPagekage.BackColor == Color.Blue) {
				package.Previous();
			}
		}

		private void btnFirst_Click(object sender, EventArgs e)
		{
			if (btnUser.BackColor == Color.Blue) {
				user.FirstUser();
			} else if (btnRegister.BackColor == Color.Blue) {
				meb.FirstMember();
			} else if (btnMember.BackColor == Color.Blue) {
				SellBill.First();
			//} else if (btnGerneralClient.BackColor == Color.Blue) {
			//	grc.FirstGClient();
			} else if (btnPagekage.BackColor == Color.Blue) {
				package.First();
			}
		}

		private void btnLast_Click(object sender, EventArgs e)
		{
			if (btnUser.BackColor == Color.Blue) {
				user.LastUser();
			} else if (btnRegister.BackColor == Color.Blue) {
				meb.LastMember();
			} else if (btnMember.BackColor == Color.Blue) {
				SellBill.Last();
			//} else if (btnGerneralClient.BackColor == Color.Blue) {
			//	grc.LastGClient();
			} else if (btnPagekage.BackColor == Color.Blue) {
				package.Last();
			}
		}




		private void btnLogout_Click(object sender, EventArgs e)
		{
			frmLogin frmLogin = new frmLogin();
			this.Hide();
			frmLogin.ShowDialog();
			this.Dispose();
			this.Close();
		}
		//@Tool Tip
		private void btnAdd_MouseHover(object sender, EventArgs e)
		{
			MyToolTip.Show("   ເພີ່ມ", btnAdd);
		}
		private void btnSave_MouseHover(object sender, EventArgs e)
		{
			MyToolTip.Show(" ບັນທຶກຂໍ້ມູນ", btnSave);
		}

		private void btnEdit_MouseHover(object sender, EventArgs e)
		{
			MyToolTip.Show(" ແກ້ໄຂຂໍ້ມູນ", btnEdit);
		}

		private void btnDelete_MouseHover(object sender, EventArgs e)
		{
			MyToolTip.Show(" ລຶບຂໍ້ມູນ", btnDelete);
		}

		private void btnMinimize_MouseHover(object sender, EventArgs e)
		{
			MyToolTip.Show(" Minimize", btnMinimize);
		}

		private void btnLogout_MouseHover(object sender, EventArgs e)
		{
			MyToolTip.Show(" Logout", btnLogout);
		}

		private void btnRestore_MouseHover(object sender, EventArgs e)
		{
			if (this.WindowState == FormWindowState.Maximized) {
				MyToolTip.Show(" Restore Downe", btnRestore);
			} else {
				MyToolTip.Show(" Maximize", btnRestore);
			}
		}

		private void btnclose_MouseHover(object sender, EventArgs e)
		{
			MyToolTip.Show(" close", btnclose);
		}

		private void TimerCalculate_Tick(object sender, EventArgs e)
		{
			setBikeAmout();
		}


		private void btnPrint_Click(object sender, EventArgs e)
		{
		}
		private void txtSearch_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter) {
				if (btnUser.BackColor == Color.Blue) {
					user.SearchUser(txtSearch.Text);
				} else if (btnRegister.BackColor == Color.Blue) {
					meb.SearchByAutoComplete(txtSearch.Text.Replace("'", "''"));
				} else if (btnPagekage.BackColor == Color.Blue) {
					package.SearchPackage(txtSearch.Text);
				} else if (btnMember.BackColor == Color.Blue) {
					SellBill.SearchByAutoComplete(txtSearch.Text.Replace("'", "''"));
				//} else if (btnGerneralClient.BackColor == Color.Blue) {
				//	grc.ShearchGeneralClient(txtSearch.Text);
				}
			}
		}
		public MainComponentForm()
		{
			DragDrop += MainComponent_DragDrop;
			Load += MainComponent_Load;
			InitializeComponent();
		}

        private void btnhelp(object sender, EventArgs e)
        {
            removeAll();
            removecolor();
            help.Dock = DockStyle.Fill;
            PanelParentContents.Controls.Add(help);
            help.Visible = true;
            bthelp.BackColor = Color.Blue;
        }

        private void btnabout_Click_1(object sender, EventArgs e)
        {
            removeAll();
            removecolor();
            aboutus.Dock = DockStyle.Fill;
            PanelParentContents.Controls.Add(aboutus);
            aboutus.Visible = true;
            btnabout.BackColor = Color.Blue;
        }

        private void btnPrintCard_Click_1(object sender, EventArgs e)
        {
            removeAll();
            removecolor();
            //print.Dock = DockStyle.Fill;
            //PanelParentContents.Controls.Add(print);
            if (btnPrintCard.Visible = true)
            {
                print.ShowDialog();
                btnPrintCard.BackColor = Color.Blue;
            }
            else
                print.Close();
            btnPrintCard.BackColor = Color.Silver;



        }
    }
}
