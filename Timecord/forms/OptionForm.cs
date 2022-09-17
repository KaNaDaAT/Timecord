using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timecord.Properties;

namespace Timecord.Forms {
	public partial class OptionForm : Form {

		List<Panel> panels = new List<Panel>();

		Image expandedImage = null;
		Image foldedImage = null;

		public OptionForm() {
			InitializeComponent();

			expandedImage = Image.FromFile(Path.GetDirectoryName(Application.ExecutablePath) + "/src/img/expanded.png");
			foldedImage = Image.FromFile(Path.GetDirectoryName(Application.ExecutablePath) + "/src/img/folded.png");

			panels.Add(pSave);
			panels.Add(pAppearance);
			panels.Add(pTable);
			panels.Add(pTableData);
			panels.Add(pTableTemplate);

			cbAutoSave.Checked = Settings.Default.autoSave;
			cbExpandedInput.Checked = Settings.Default.expandedInputField;
		}

		private void Save() {
			Settings.Default.autoSave = cbAutoSave.Checked;
			Settings.Default.expandedInputField = cbExpandedInput.Checked;
			Settings.Default.Save();
		}

		private Panel PanelWithName(string name) {
			foreach(Panel panel in panels) {
				if(panel.Name.Equals("p" + name.Remove(0, 1), StringComparison.OrdinalIgnoreCase))
					return panel;
			}
			return null;
		}

		private void bCancel_Click(object sender, EventArgs e) {
			this.Close();
		}

		private void bApply_Click(object sender, EventArgs e) {
			this.Save();
			this.Close();
		}

		private void menu_AfterSelect(object sender, TreeViewEventArgs e) {
			Panel panel = PanelWithName(menu.SelectedNode.Name);
			if(panel != null)
				panel.BringToFront();
		}

	}
}
