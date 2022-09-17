using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Timecord.controls {
	public partial class Slider : Control {
		public event EventHandler ValueChanged;

		private int minValue;
		public int MinValue {
			get { return minValue; }
			set {
				if(!(value > this.maxValue || value < 0))
					this.minValue = value;
			}
		}

		private int maxValue;
		public int MaxValue {
			get { return maxValue; }
			set {
				if(this.minValue < value)
					this.maxValue = value;
			}
		}

		private int value;
		public int Value {
			get { return value; }
			set {
				if(this.minValue <= value && value <= this.maxValue) {
					this.value = value;
					this.Refresh();
				}
			}
		}

		private Color borderColor;
		public Color BorderColor {
			get { return borderColor; }
			set { borderColor = value; }
		}

		private int borderWidth;
		public int BorderWidth {
			get { return borderWidth; }
			set { borderWidth = value; }
		}

		public Slider() {
			InitializeComponent();
			SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
			this.MinValue = 0;
			this.MaxValue = 100;
			this.Value = 50;
			this.Text = "Value";
		}

		protected override void OnPaint(PaintEventArgs pe) {
			base.OnPaint(pe);

			pe.Graphics.DrawRectangle(new Pen(this.BorderColor, this.BorderWidth), 0, 0, Width - 1, Height - 1);
			if(this.Value != 0) {
				using(GraphicsPath gp = new GraphicsPath()) {
					Rectangle rect = new Rectangle(0, 0, Value * (Width - 1) / MaxValue, Height - 1);
					gp.AddRectangle(rect);
					using(var br = new LinearGradientBrush(rect, Color.SteelBlue, Color.LightBlue, LinearGradientMode.Horizontal)) {
						pe.Graphics.FillPath(br, gp);
						pe.Graphics.DrawPath(Pens.DarkBlue, gp);
					}
				}
			}
		}

		private void SetClickValue(Point click_point) {
			int x = (click_point.X + 1) * MaxValue / Width;
			if(x < this.MinValue)
				x = this.MinValue;
			if(x > this.MaxValue)
				x = this.MaxValue;
			this.Value = x;
			this.Refresh();
			this.ValueChanged?.Invoke(this, new EventArgs());
		}

		protected override void OnMouseClick(MouseEventArgs e) {
			base.OnMouseClick(e);
			if(e.Button == MouseButtons.Left) {
				SetClickValue(e.Location);
			}
		}

		protected override void OnMouseMove(MouseEventArgs e) {
			base.OnMouseMove(e);
			if(e.Button == MouseButtons.Left) {
				SetClickValue(e.Location);
			}
		}

	}
}
