using System.Collections;
using System.Drawing;
using System.Windows.Forms;

namespace Timecord.Utils {


	public class MenuItemRender : ToolStripProfessionalRenderer {
		Hashtable ht = new Hashtable();
		int shortcutTextMargin = 5;
		Font cachedFont = null;

		public MenuItemRender() : base(new MenuItemColors()) { }

		protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e) {
			ToolStrip ts = e.Item.Owner;
			if(ts.Font != cachedFont) {
				cachedFont = ts.Font; // assumes all menu items use the same font
				ht.Clear();
			}

			ToolStripMenuItem mi = e.Item as ToolStripMenuItem;

			if(mi != null) {
				if(e.Text != mi.Text && mi.ShortcutKeys != (Keys) 0) {
					ToolStripMenuItem owner = (ToolStripMenuItem) e.Item.OwnerItem;
					e.TextFormat = TextFormatFlags.VerticalCenter;
					Size sz = TextRenderer.MeasureText(e.Graphics, e.Text, e.TextFont);

					int w = owner.DropDown.Width;
					int x = w - (sz.Width + shortcutTextMargin);
					int? xShortcut = (int?) ht[owner];
					if(!xShortcut.HasValue || x < xShortcut.Value) {
						xShortcut = x;
						ht[owner] = xShortcut;
						owner.DropDown.Invalidate();
					}

					Rectangle r = e.TextRectangle;
					r.X = xShortcut.Value;
					e.TextRectangle = r;
				} else if(ts.IsDropDown) {
					Rectangle r = e.TextRectangle;
					r.X = 20;
					e.TextRectangle = r;
				}
			}

			base.OnRenderItemText(e);
		}
	}


	class MenuItemColors : ProfessionalColorTable {
		public override Color MenuItemSelected {
			get { return Color.FromArgb(232, 234, 237); }
		}
		public override Color MenuItemSelectedGradientBegin {
			get { return Color.FromArgb(232, 234, 237); }
		}
		public override Color MenuItemSelectedGradientEnd {
			get { return Color.FromArgb(232, 234, 237); }
		}
		public override Color MenuItemBorder {
			get { return Color.FromArgb(232, 234, 237); }
		}
		public override Color MenuItemPressedGradientBegin {
			get { return Color.White; }
		}
		public override Color MenuItemPressedGradientMiddle {
			get { return Color.White; }
		}
		public override Color MenuItemPressedGradientEnd {
			get { return Color.White; }
		}
		public override Color ToolStripDropDownBackground {
			get { return Color.White; }
		}
		public override Color ImageMarginRevealedGradientMiddle {
			get { return Color.White; }
		}
		public override Color ImageMarginGradientBegin {
			get { return Color.White; }
		}
		public override Color ImageMarginGradientMiddle {
			get { return Color.White; }
		}
		public override Color ImageMarginGradientEnd {
			get { return Color.White; }
		}
		public override Color GripLight {
			get { return Color.Transparent; }
		}
	}
}