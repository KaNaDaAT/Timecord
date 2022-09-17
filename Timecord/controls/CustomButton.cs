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
	public partial class CustomButton : Button {

		private Color borderColorActive = Color.Black;
		public Color BorderColorActive {
			get => borderColorActive;
			set => borderColorActive = value;
		}

		public CustomButton() : base() {
			FlatAppearance.BorderSize = 1;
			FlatStyle = FlatStyle.Flat;
			SetStyle(ControlStyles.UserPaint, true);
		}

		protected override void OnPaint(PaintEventArgs e) {
			int borderSize = FlatAppearance.BorderSize;
			FlatAppearance.BorderSize = 0;
			base.OnPaint(e);
			FlatAppearance.BorderSize = borderSize;
			if(this.Focused) {
				Pen pen = new Pen(borderColorActive, FlatAppearance.BorderSize);
				Rectangle rectangle = new Rectangle(0, 0, Size.Width - 1, Size.Height - 1);
				e.Graphics.DrawRectangle(pen, rectangle);
			} else {
				Pen pen = new Pen(FlatAppearance.BorderColor, FlatAppearance.BorderSize);
				Rectangle rectangle = new Rectangle(0, 0, Size.Width - 1, Size.Height - 1);
				e.Graphics.DrawRectangle(pen, rectangle);
			}
		}
	}
}
