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
using System.ComponentModel;
namespace WindowsApplication1
{

	public class WaterMark : TextBox
	{
		string WaterMarkText;
		Color WaterMarkColor;
		Font WaterMarkFont;
		SolidBrush WaterMarkBush;
		Panel WaterMarkContainer;
		int WaterMarkLefCursor = 2;
		public WaterMark() : base()
		{
			this.StartProcess();
		}
		private void StartProcess()
		{
			this.WaterMarkText = "Default WaterMake Text";
			this.WaterMarkColor = Color.FromArgb(64, 64, 64);
			this.WaterMarkFont = new Font("Century Gothic", 12f);
			this.WaterMarkBush = new SolidBrush(WaterMarkColor);
			this.CreateWaterMark();

			TextChanged += ChangeText;
			FontChanged += ChangeFont;

		}

		private void CreateWaterMark()
		{
			this.WaterMarkContainer = new Panel();
			this.Controls.Add(WaterMarkContainer);
			this.WaterMarkContainer.Click += this.Clicked;
			this.WaterMarkContainer.Paint += this.Painted;

		}
		private void RemoveWaterMark()
		{
			this.Controls.Remove(WaterMarkContainer);
		}

		private void ChangeText(object sender, EventArgs e)
		{
			if (this.Text.Length <= 0) {
				this.CreateWaterMark();
			} else if (this.Text.Length > 0) {
				this.RemoveWaterMark();
			}
		}

		private void ChangeFont(object sender, EventArgs e)
		{
			this.WaterMarkFont = new Font(this.Font, FontStyle.Regular);
		}
		private void Clicked(object sender, EventArgs e)
		{
			this.Focus();
		}
		private void Painted(object sender, PaintEventArgs e)
		{
			this.WaterMarkContainer.Location = new Point(WaterMarkLefCursor, 0);
			this.WaterMarkContainer.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			this.WaterMarkContainer.Width = this.Width;
			this.WaterMarkContainer.Height = this.Height;
			this.WaterMarkBush = new SolidBrush(WaterMarkColor);
			Graphics Graphic = e.Graphics;
			Graphic.DrawString(this.WaterMarkText, this.WaterMarkFont, this.WaterMarkBush, new PointF(-3.5f, 1f));

		}
		protected override void OnInvalidated(InvalidateEventArgs e)
		{
			base.OnInvalidated(e);
			this.WaterMarkContainer.Invalidate();
		}
		[Category("WaterMark Attributes"), Description("Sets WaterMark Text")]
		public string SetWaterMarkText {
			get { return this.WaterMarkText; }
			set {
				this.WaterMarkText = value;
				this.Invalidate();
			}
		}
		[Category("WaterMark Attributes"), Description("Sets WaterMark Color")]
		public Color SetWaterMarkColor {
			get { return this.WaterMarkColor; }
			set {
				this.WaterMarkColor = value;
				this.Invalidate();
			}
		}

		[Category("WaterMark Attributes"), Description("Sets WaterMark Font")]
		public Font SetWaterMarkFont {
			get { return this.WaterMarkFont; }
			set {
				this.WaterMarkFont = value;
				this.Invalidate();
			}
		}

		[Category("WaterMark Attributes"), Description("Sets WaterMark LeftCursor")]
		public int SetWaterMarkLeftCursor {
			get { return this.WaterMarkLefCursor; }
			set {
				this.WaterMarkLefCursor = value;
				this.Invalidate();
			}
		}


	}
}
