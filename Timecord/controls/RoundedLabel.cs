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

namespace Timecord.Controls {
	public partial class RoundedLabel : Label {
		public RoundedLabel() {
			InitializeComponent();
		}

		protected override void OnPaint(PaintEventArgs e) {
			base.OnPaint(e);
			Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);
			GraphicsPath graphPath = new GraphicsPath();
			int radius = 12;
			//Top Left Corner
			graphPath.AddArc(rect.X, rect.Y, 2 * radius, 2 * radius, 180, 90);
			//Top Edge
			graphPath.AddLine(rect.X + radius, rect.Y, rect.X + rect.Width - radius, rect.Y);
			//Top Right Corner
			graphPath.AddArc(rect.X + rect.Width - 2 * radius, rect.Y, 2 * radius, 2 * radius, 270, 90);
			//Right Edge
			graphPath.AddLine(rect.X + rect.Width, rect.Y + radius, rect.X + rect.Width, rect.Y + rect.Height);
			//Left Edge
			graphPath.AddLine(rect.X, rect.Y + rect.Height, rect.X, rect.Y + radius);

			//graphPath.AddArc(Rect.X, Rect.Y, 50, 50, 180, 90);
			//graphPath.AddArc(Rect.X + Rect.Width - 50, Rect.Y, 50, 50, 270, 90);
			//graphPath.AddArc(Rect.X + Rect.Width - 50, Rect.Y + Rect.Height - 50, 50, 50, 0, 90);
			//graphPath.AddArc(Rect.X, Rect.Y + Rect.Height - 50, 50, 50, 90, 90);
			this.Region = new Region(graphPath);
		}
	}
}
