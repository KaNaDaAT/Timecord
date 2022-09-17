using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timecord.Properties;
using Timecord.Utils;
using static Timecord.Utils.TableRow;

namespace Timecord.Forms {
	public partial class MainForm : Form {

		private bool ShowInputPanel = false;
		private int InputPanelMinHeight;
		private int InputPanelMaxHeight = 110;
		private int InputPanelAnimSpeed = 8;
		private string htmlTable;
		private string currentFile = null;

		private OptionForm optionForm;


		private TimecordFile tcFile = new TimecordFile();

		public MainForm(string path) {
			Init();
			this.currentFile = path;
			this.Text = "Timecord - " + currentFile;
			Open();
		}

		public MainForm() {
			Init();
		}

		private void Init() {
			InitializeComponent();
			htmlTable = File.ReadAllText(Path.GetDirectoryName(Application.ExecutablePath) + "/src/html/table.html");
			browser.NavigateToString(htmlTable);

			menu.Renderer = new MenuItemRender();
			mFile.DropDown.DropShadowEnabled = false;
			mEdit.DropDown.DropShadowEnabled = false;
			mHelp.DropDown.DropShadowEnabled = false;
			miLastUsed.DropDown.DropShadowEnabled = false;
			miExport.DropDown.DropShadowEnabled = false;
			miOpenWithTextEditor.DropDown.DropShadowEnabled = false;
			miExport.DropDownItems.Add(miExportPdf);
			miExport.DropDownItems.Add(miExportHtml);

			InputPanelMinHeight = pInput.Size.Height;

			UpdateLastOpend();
			if(Settings.Default.expandedInputField) {
				ShowInputPanel = true;
				bShowInputPanel.BackgroundImage = Resources.angle_down;
				inputPanel.Height = InputPanelMaxHeight;
				pInput.Height = InputPanelMaxHeight;
			}
		}

		public void RefreshTable() {
			string htmlTableCopy = htmlTable;
			int indexOfArray = htmlTableCopy.LastIndexOf("var data = [") + "var data = [".Length;
			string pre = htmlTableCopy.Substring(0, indexOfArray);
			string suf = htmlTableCopy.Substring(indexOfArray, htmlTableCopy.Length - indexOfArray);
			string data = "";
			for(int i = 0; i < inputPanel.Rows.Count; i++) {
				data += inputPanel.Rows[i].ToString() + ",\n";
			}
			htmlTableCopy = pre + data + suf;

			indexOfArray = htmlTableCopy.LastIndexOf("var backgroundColor = {") + "var backgroundColor = {".Length;
			pre = htmlTableCopy.Substring(0, indexOfArray);
			suf = htmlTableCopy.Substring(indexOfArray, htmlTableCopy.Length - indexOfArray);
			data = "";
			for(int i = 0; i < inputPanel.ccbUserStory.Items.Count; i++) {
				Color color = inputPanel.ccbUserStory.Colors[i];
				string name = inputPanel.ccbUserStory.Items[i] as string;
				data += "'" + name + "': { back : 'rgb(" + color.R + ", " + color.G + ", " + color.B + ")',\n";
				data += "text : " + (((color.R + color.B + color.G) / 3) > 255 / 2 ? "'black'" : "'white'") + "},";
			}

			string html = pre + data + suf;
			browser.NavigateToString(pre + data + suf);
		}

		public void AddLastOpend(string path) {
			if(Settings.Default.lastUsed == null)
				Settings.Default.lastUsed = new System.Collections.Specialized.StringCollection();
			if(!Settings.Default.lastUsed.Contains(path))
				Settings.Default.lastUsed.Insert(0, path);
			for(int i = 0; i < Settings.Default.lastUsed.Count; i++) {
				if(!File.Exists(Settings.Default.lastUsed[i]))
					Settings.Default.lastUsed.RemoveAt(i);
			}
			while(Settings.Default.lastUsed.Count > 8) {
				Settings.Default.lastUsed.RemoveAt(Settings.Default.lastUsed.Count - 1);
			}
			Settings.Default.Save();
			UpdateLastOpend();
		}

		public void UpdateLastOpend() {
			this.miLastUsed.DropDownItems.Clear();
			if(Settings.Default.lastUsed != null) {
				List<string> lastUsed = Settings.Default.lastUsed.Cast<String>().ToList();
				for(int i = 0; i < lastUsed.Count; i++) {
					ToolStripMenuItem item = new ToolStripMenuItem();
					item.Text = lastUsed[i];
					item.Click += new EventHandler(this.lastUsedItem_Click);
					this.miLastUsed.DropDownItems.Add(item);
				}
			}
		}

		public void Open() {
			if(!tcFile.Open(this.currentFile))
				return;
			inputPanel.Rows = tcFile.Content.TableRows;
			inputPanel.Reset();
			foreach(UserStoryItem item in tcFile.Content.UserStorys) {
				inputPanel.ccbUserStory.AddItem(item.Name, item.Color);
			}
			foreach(string item in tcFile.Content.Participants) {
				inputPanel.ccbParticipant.AddItem(item, Color.Empty);
			}
			RefreshTable();
		}

		public void Save(string path) {
			tcFile.Save(path);
			if(this.Text.EndsWith(" *")) {
				this.Text = this.Text.Substring(0, this.Text.Length - 2);
			}
		}

		public void Save() {
			tcFile.Save(currentFile);
			if(this.Text.EndsWith(" *")) {
				this.Text = this.Text.Substring(0, this.Text.Length - 2);
			}
		}

		public void lastUsedItem_Click(object sender, EventArgs e) {
			ToolStripMenuItem item = (ToolStripMenuItem) sender;
			if(File.Exists(item.Text)) {
				Settings.Default.lastPath = item.Text;
				Settings.Default.Save();
				this.Text = "Timecord - " + item.Text;
				this.currentFile = item.Text;
				AddLastOpend(item.Text);
				Open();
			} else {
				miLastUsed.DropDownItems.Remove(item);
				Settings.Default.lastUsed.Remove(item.Text);
				Settings.Default.Save();
				MessageBox.Show("Datei konnte nicht gefunden werden!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void bShowInputPanel_Click(object sender, EventArgs e) {
			if(ShowInputPanel) {
				tShowInputPanel.Stop();
				ShowInputPanel = false;
				bShowInputPanel.BackgroundImage = Resources.angle_up;
				tShowInputPanel.Start();
			} else {
				tShowInputPanel.Stop();
				ShowInputPanel = true;
				bShowInputPanel.BackgroundImage = Resources.angle_down;
				tShowInputPanel.Start();
			}
		}

		private void tShowInputPanel_Tick(object sender, EventArgs e) {
			if(ShowInputPanel) {
				Size size = pInput.Size;
				size.Height += InputPanelAnimSpeed;
				if(size.Height >= InputPanelMaxHeight) {
					size.Height = InputPanelMaxHeight;
					tShowInputPanel.Stop();
				}
				pInput.Size = size;
				if(inputPanel.Height > InputPanelMaxHeight)
					inputPanel.Height -= 10;
				if(inputPanel.Height < InputPanelMaxHeight)
					inputPanel.Height = InputPanelMaxHeight;
			} else {
				Size size = pInput.Size;
				size.Height -= InputPanelAnimSpeed;
				if(size.Height <= InputPanelMinHeight) {
					size.Height = InputPanelMinHeight;
					tShowInputPanel.Stop();
				}
				pInput.Size = size;
				if(inputPanel.Height < InputPanelMaxHeight + 30)
					inputPanel.Height += 10;
				if(inputPanel.Height > InputPanelMaxHeight + 30)
					inputPanel.Height = InputPanelMaxHeight + 30;
			}
		}

		private void inputPanel_SendData(object sender, EventArgs e) {
			tcFile.Content.TableRows = inputPanel.Rows;
			if(Settings.Default.autoSave) {
				miSave_Click(sender, e);
			} else {
				if(!this.Text.EndsWith(@" *"))
					this.Text += " *";
			}
			RefreshTable();
		}

		private void inputPanel_UserStroyChanged(object sender, EventArgs e) {
			tcFile.Content.SetUserStory(
				inputPanel.ccbUserStory.Items.Cast<String>().ToList(),
				inputPanel.ccbUserStory.Colors
			);
			if(Settings.Default.autoSave) {
				miSave_Click(sender, e);
			} else {
				if(!this.Text.EndsWith(@" *"))
					this.Text += " *";
			}
		}

		private void inputPanel_ParticipentChanged(object sender, EventArgs e) {
			tcFile.Content.Participants = inputPanel.ccbParticipant.Items.Cast<String>().ToList();
			if(Settings.Default.autoSave) {
				miSave_Click(sender, e);
			} else {
				if(!this.Text.EndsWith(@" *"))
					this.Text += " *";
			}
		}

		private void miNew_Click(object sender, EventArgs e) {
			saveFileDialog.FileName = "Timecord.tc";
			DialogResult dialogResult = saveFileDialog.ShowDialog();
			if(dialogResult == DialogResult.OK) {
				File.WriteAllText(saveFileDialog.FileName, "");
				Settings.Default.lastPath = saveFileDialog.FileName;
				Settings.Default.Save();
				this.Text = "Timecord - " + saveFileDialog.FileName;
				this.currentFile = saveFileDialog.FileName;
				AddLastOpend(saveFileDialog.FileName);
			}
		}

		private void miOpen_Click(object sender, EventArgs e) {
			DialogResult dialogResult = openFileDialog.ShowDialog();
			if(dialogResult == DialogResult.OK) {
				Settings.Default.lastPath = openFileDialog.FileName;
				Settings.Default.Save();
				this.Text = "Timecord - " + openFileDialog.FileName;
				this.currentFile = openFileDialog.FileName;
				AddLastOpend(openFileDialog.FileName);
				Open();
			}
		}

		private void miOpenWithTextEditor_Click(object sender, EventArgs e) {
			if(File.Exists(this.currentFile))
				Process.Start("notepad.exe", this.currentFile);
		}

		private void miSave_Click(object sender, EventArgs e) {
			if(currentFile == null) {
				miSaveAs_Click(sender, e);
			} else {
				Save();
			}
		}

		private void miSaveAs_Click(object sender, EventArgs e) {
			saveFileDialog.FileName = "Timecord.tc";
			DialogResult dialogResult = saveFileDialog.ShowDialog();
			if(dialogResult == DialogResult.OK) {
				Settings.Default.lastPath = saveFileDialog.FileName;
				Settings.Default.Save();
				this.Text = "Timecord - " + saveFileDialog.FileName;
				this.currentFile = saveFileDialog.FileName;
				AddLastOpend(saveFileDialog.FileName);
				Save();
			}
		}

		private async void miExportPdf_Click(object sender, EventArgs e) {
			try {
				string fileName = Path.GetFileName(this.currentFile);
				saveFileDialog.FileName = fileName.Substring(0, fileName.Length - 3) + ".pdf";
				saveFileDialog.Filter = "Portable Document Format|*.pdf";
				DialogResult dialogResult = saveFileDialog.ShowDialog();
				if(dialogResult == DialogResult.OK) {
					string htmlText = await CreateHtmlTextAsync();

					SelectPdf.HtmlToPdf converter = new SelectPdf.HtmlToPdf();
					converter.Options.PdfPageOrientation = SelectPdf.PdfPageOrientation.Landscape;
					converter.Options.MarginTop = 20;
					converter.Options.MarginBottom = 20;
					converter.Options.MarginLeft = 20;
					converter.Options.MarginRight = 20;
					converter.Options.WebPageWidth = 1350;
					SelectPdf.PdfDocument doc = converter.ConvertHtmlString(htmlText);

					doc.Save(saveFileDialog.FileName);
					doc.Close();
				}
				saveFileDialog.Filter = "Timecord Files|*.tc";
			} catch(Exception) {
				MessageBox.Show("Pdf-Datei konnte nicht generiert werden!");
			}
		}

		private async void miExportHtml_Click(object sender, EventArgs e) {
			try {
				string fileName = Path.GetFileName(this.currentFile);
				saveFileDialog.FileName = fileName.Substring(0, fileName.Length - 3) + ".html";
				saveFileDialog.Filter = "Hypertext Markup Language|*.html";
				DialogResult dialogResult = saveFileDialog.ShowDialog();
				if(dialogResult == DialogResult.OK) {
					string htmlText = await CreateHtmlTextAsync();

					StreamWriter writer = new StreamWriter(saveFileDialog.FileName);
					writer.Write(htmlText);
					writer.Close();
				}
				saveFileDialog.Filter = "Timecord Files|*.tc";
			} catch(Exception exc) {
				Console.WriteLine(exc.Message);
				MessageBox.Show("Html-Datei konnte nicht generiert werden!");
			}
		}

		private async Task<string> CreateHtmlTextAsync() {
			string htmlText = await browser.InvokeScriptAsync("eval", new string[] { "document.documentElement.outerHTML;" });

			// Remove javascript table gen
			htmlText =
				htmlText.Substring(0, htmlText.IndexOf("$table.bootstrapTable({")) +
				htmlText.Substring(
					htmlText.IndexOf("//$table-marker") + "//$table-marker".Length,
					htmlText.Length - (htmlText.IndexOf("//$table-marker") + "//$table-marker".Length)
				);

			// Add footer
			int searchLength = "</tbody></table></div>".Length;
			int index = htmlText.IndexOf("</tbody></table></div>");

			string footer = "";
			List<string> participants = new List<string>();
			foreach(TableRow row in tcFile.Content.TableRows) {
				if(!participants.Contains(row.Participant)) {
					participants.Add(row.Participant);
				}
			}
			int i = 0;
			foreach(string participant in participants) {
				int estimatedTime = 0;
				int realTime = 0;
				int breakTime = 0;
				int deviation = 0;
				foreach(TableRow row in tcFile.Content.TableRows) {
					if(!row.Participant.Equals(participant, StringComparison.OrdinalIgnoreCase))
						continue;
					estimatedTime += row.EstimatedTime;
					realTime += row.RealTime;
					breakTime += row.BreakTime;
					deviation += row.Deviation;
				}
				if(i == 0) {
					footer += "<tr style=\"border-top: 2px solid; border-color: #111;\">";
				} else {
					footer += "<tr>";
				}
				footer += 
					"<td style = \"page-break-inside: avoid; page-break-before: auto;\"> <b>Total</b> </td>\n" + 
					"<td style = \"page-break-inside: avoid; page-break-before: auto;\">" + participant + "</td>\n" +
					"<td style = \"page-break-inside: avoid; page-break-before: auto;\"> - </td>\n" +
					"<td style = \"page-break-inside: avoid; page-break-before: auto;\">" + TableRow.FormatMillis(estimatedTime) + "</td>\n" +
					"<td style = \"page-break-inside: avoid; page-break-before: auto;\"> - </td>\n" +
					"<td style = \"page-break-inside: avoid; page-break-before: auto;\"> - </td>\n" +
					"<td style = \"page-break-inside: avoid; page-break-before: auto;\">" + TableRow.FormatMillis(realTime) + "</td>\n" +
					"<td style = \"page-break-inside: avoid; page-break-before: auto;\">" + TableRow.FormatMillis(breakTime) + "</td>\n" +
					"<td style = \"page-break-inside: avoid; page-break-before: auto;\">" + TableRow.FormatMillis(deviation) + "</td>\n" +
					"<td style = \"page-break-inside: avoid; page-break-before: auto;\"> - </td>\n" +
					"</tr>\n";
				i++;
			}
			htmlText = htmlText.Insert(index, footer);

			return htmlText;
		}

		private void miOptions_Click(object sender, EventArgs e) {
			if(optionForm == null) {
				optionForm = new OptionForm();
				optionForm.ShowDialog(this);
				optionForm = null;
			} else {
				optionForm.Activate();
			}
		}

		protected override void OnFormClosing(FormClosingEventArgs e) {
			base.OnFormClosing(e);
			if(this.Text.EndsWith("*")) {
				DialogResult result = MessageBox.Show("Die Datei wurde noch nicht gespeichert. Forfahren ohne Speichern?", "Speichern",
					MessageBoxButtons.OKCancel, MessageBoxIcon.Information
				);
				e.Cancel = DialogResult.Cancel == result;
			}
		}

		private void preventBrowserFocus_Tick(object sender, EventArgs e) {
			if(browser.Focused) {
				Console.WriteLine("Browser is Focused!");
				this.Focus();
			}
		}
	}
}