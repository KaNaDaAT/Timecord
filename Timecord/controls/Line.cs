using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timecord.Controls {
	public enum Degrees {
		Degrees_0 = 0,
		Degrees_45 = 1,
		Degrees_90 = 2,
		Degrees_135 = 3,
	}

	public partial class Line : UserControl {

		private Degrees degrees = Degrees.Degrees_0;
		public Degrees Degrees { get => degrees; set => degrees = value; }

		private int lineWidth = 2;
		public int LineWidth { get => lineWidth; set => lineWidth = value; }

		public Color Color { get => color; set => color = value; }
		private Color color = Color.Silver;


		public Line(Degrees degrees) {
			this.Degrees = degrees;
			this.Paint += new PaintEventHandler(LineSeparator_Paint);
			this.MinimumSize = new Size(0, 2);
			this.Width = 350;
			this.BackColor = Color.Transparent;
			this.TabStop = false;
			this.TabIndex = 0;
		}

		public Line() {
			InitializeComponent();
			this.Paint += new PaintEventHandler(LineSeparator_Paint);
			this.MinimumSize = new Size(0, 2);
			this.Width = 350;
			this.BackColor = Color.Transparent;
			this.TabStop = false;
			this.TabIndex = 0;
		}

		private void LineSeparator_Paint(object sender, PaintEventArgs e) {
			Graphics g = e.Graphics;
			switch(Degrees) {
				case Degrees.Degrees_0:
					g.DrawLine(new Pen(color, LineWidth), new Point(0, this.Height/2), new Point(this.Width, this.Height / 2));
					break;
				case Degrees.Degrees_45:
					g.DrawLine(new Pen(color, LineWidth), new Point(0, 0), new Point(this.Width, this.Height));
					break;
				case Degrees.Degrees_90:
					g.DrawLine(new Pen(color, LineWidth), new Point(this.Width/2, 0), new Point(this.Width / 2, this.Height));
					break;
				case Degrees.Degrees_135:
					g.DrawLine(new Pen(color, LineWidth), new Point(0, this.Height), new Point(this.Width, 0));
					break;
			}
		}
	}
}
