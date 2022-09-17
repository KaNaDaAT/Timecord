using System.Drawing;
using System.Windows.Forms;

namespace Timecord.Controls {
	public class CustomToolStripSeparator : ToolStripSeparator {
		public CustomToolStripSeparator() {
			Paint += CustomToolStripSeparator_Paint;
		}

		private void CustomToolStripSeparator_Paint(object sender, PaintEventArgs e) {
			ToolStripSeparator toolStripSeparator = (ToolStripSeparator) sender;
			int width = toolStripSeparator.Width;
			int height = toolStripSeparator.Height;
			e.Graphics.FillRectangle(new SolidBrush(Color.White), 0, 0, width, height);
			e.Graphics.FillRectangle(new SolidBrush(Color.LightGray), 0, height / 2, width, 1);
		}
	}
}