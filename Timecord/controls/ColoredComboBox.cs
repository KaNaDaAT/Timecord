using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace Timecord.Controls {
	public partial class ColoredComboBox : ComboBox {
		//the default colors from list        
		public List<Color> Colors = new List<Color>();

		protected int inMargin;
		protected int boxWidth;

		private const int WM_PAINT = 0xF;
		private int buttonWidth = SystemInformation.HorizontalScrollBarArrowWidth;

		protected override void WndProc(ref Message m) {
			base.WndProc(ref m);
			if(m.Msg == WM_PAINT) {
				using(var g = Graphics.FromHwnd(Handle)) {
					using(var p = new Pen(this.BorderColor, 1)) {
						g.DrawRectangle(p, 0, 0, Width - 1, Height - 1);
					}
				}
			}
		}

		[Browsable(true)]
		[Category("Appearance")]
		[DefaultValue(typeof(Color), "DimGray")]
		public Color BorderColor { get; set; }

		public ColoredComboBox() {
			DrawMode = DrawMode.OwnerDrawFixed;
			DropDownStyle = ComboBoxStyle.DropDown;
			inMargin = 2;
			boxWidth = 4;
			BorderColor = Color.LightBlue;
			InitializeComponent();
		}


		public void AddItem(Object item, Color color) {
			this.Items.Add(item);
			this.Colors.Add(color);
		}

		public void RemoveItem(Object item) {
			int index = this.Items.IndexOf(item);
			if(index >= 0 && index < this.Items.Count) {
				this.Items.RemoveAt(index);
				this.Colors.RemoveAt(index);
			}
		}

		public void ClearItems() {
			this.Items.Clear();
			this.Colors.Clear();
		}

		public void Reset() {
			this.Text = "";
			ClearItems();
			this.Refresh();
		}

		protected override void OnDrawItem(DrawItemEventArgs e) {
			base.OnDrawItem(e);
			if((e.State & DrawItemState.ComboBoxEdit) != DrawItemState.ComboBoxEdit)
				e.DrawBackground();

			Graphics g = e.Graphics;
			if(e.Index == -1)  //if index is -1 do nothing
				return;

			//draw strings
			object[] destination = new object[Items.Count];
			Items.CopyTo(destination, 0);
			g.DrawString(destination[e.Index].ToString(), e.Font, new SolidBrush(ForeColor),
				new RectangleF(
					2 * this.inMargin,
					e.Bounds.Y,
					(e.Bounds.Width - (e.Bounds.Width / this.boxWidth)) - this.inMargin * 3,
					e.Bounds.Height
				)
			);

			Color c = Colors.ElementAt(e.Index);
			if(c == Color.Empty)
				return;
			//the color rectangle
			g.FillRectangle(new SolidBrush(c),
				e.Bounds.Width - (e.Bounds.X + this.inMargin) - e.Bounds.Width / this.boxWidth,
				e.Bounds.Y + this.inMargin,
				e.Bounds.Width / this.boxWidth - 2 * this.inMargin,
				e.Bounds.Height - 2 * this.inMargin - 1
			);
			//draw border around color rectangle
			g.DrawRectangle(Pens.Black,
				e.Bounds.Width - (e.Bounds.X + this.inMargin) - e.Bounds.Width / this.boxWidth,
				e.Bounds.Y + this.inMargin,
				e.Bounds.Width / this.boxWidth - 2 * this.inMargin,
				e.Bounds.Height - 2 * this.inMargin - 1
			);
		}
	}
}
