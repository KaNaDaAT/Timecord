using System;
using System.IO;
using Timecord.Properties;

namespace Timecord.Forms {
	partial class MainForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.menu = new System.Windows.Forms.MenuStrip();
			this.mFile = new System.Windows.Forms.ToolStripMenuItem();
			this.miNew = new System.Windows.Forms.ToolStripMenuItem();
			this.seperator1 = new Timecord.Controls.CustomToolStripSeparator();
			this.miOpen = new System.Windows.Forms.ToolStripMenuItem();
			this.miLastUsed = new System.Windows.Forms.ToolStripMenuItem();
			this.miOpenWithTextEditor = new System.Windows.Forms.ToolStripMenuItem();
			this.seperator2 = new Timecord.Controls.CustomToolStripSeparator();
			this.miSave = new System.Windows.Forms.ToolStripMenuItem();
			this.miSaveAs = new System.Windows.Forms.ToolStripMenuItem();
			this.seperator3 = new Timecord.Controls.CustomToolStripSeparator();
			this.miExport = new System.Windows.Forms.ToolStripMenuItem();
			this.mEdit = new System.Windows.Forms.ToolStripMenuItem();
			this.miEditTable = new System.Windows.Forms.ToolStripMenuItem();
			this.mHelp = new System.Windows.Forms.ToolStripMenuItem();
			this.miWebsite = new System.Windows.Forms.ToolStripMenuItem();
			this.miGithub = new System.Windows.Forms.ToolStripMenuItem();
			this.miMail = new System.Windows.Forms.ToolStripMenuItem();
			this.tShowInputPanel = new System.Windows.Forms.Timer(this.components);
			this.pInput = new System.Windows.Forms.Panel();
			this.inputPanel = new Timecord.Forms.InputPanel();
			this.bShowInputPanel = new System.Windows.Forms.Button();
			this.line1 = new Timecord.Controls.Line();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.browser = new Microsoft.Toolkit.Forms.UI.Controls.WebView();
			this.miExportPdf = new System.Windows.Forms.ToolStripMenuItem();
			this.miExportHtml = new System.Windows.Forms.ToolStripMenuItem();
			this.preventBrowserFocus = new System.Windows.Forms.Timer(this.components);
			this.miOptions = new System.Windows.Forms.ToolStripMenuItem();
			this.menu.SuspendLayout();
			this.pInput.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.browser)).BeginInit();
			this.SuspendLayout();
			// 
			// menu
			// 
			this.menu.BackColor = System.Drawing.SystemColors.Window;
			this.menu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
			this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mFile,
            this.mEdit,
            this.mHelp});
			this.menu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
			this.menu.Location = new System.Drawing.Point(0, 0);
			this.menu.MinimumSize = new System.Drawing.Size(0, 23);
			this.menu.Name = "menu";
			this.menu.Padding = new System.Windows.Forms.Padding(0);
			this.menu.Size = new System.Drawing.Size(1004, 23);
			this.menu.TabIndex = 0;
			// 
			// mFile
			// 
			this.mFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miNew,
            this.seperator1,
            this.miOpen,
            this.miLastUsed,
            this.miOpenWithTextEditor,
            this.seperator2,
            this.miSave,
            this.miSaveAs,
            this.seperator3,
            this.miExport});
			this.mFile.Name = "mFile";
			this.mFile.Padding = new System.Windows.Forms.Padding(6, 2, 6, 2);
			this.mFile.ShowShortcutKeys = false;
			this.mFile.Size = new System.Drawing.Size(50, 23);
			this.mFile.Text = "Datei";
			// 
			// miNew
			// 
			this.miNew.BackColor = System.Drawing.SystemColors.Window;
			this.miNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.miNew.Name = "miNew";
			this.miNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
			this.miNew.Size = new System.Drawing.Size(215, 22);
			this.miNew.Text = "Neue Datei";
			this.miNew.Click += new System.EventHandler(this.miNew_Click);
			// 
			// seperator1
			// 
			this.seperator1.Name = "seperator1";
			this.seperator1.Size = new System.Drawing.Size(212, 6);
			// 
			// miOpen
			// 
			this.miOpen.BackColor = System.Drawing.SystemColors.Window;
			this.miOpen.Name = "miOpen";
			this.miOpen.Size = new System.Drawing.Size(215, 22);
			this.miOpen.Text = "Öffnen";
			this.miOpen.Click += new System.EventHandler(this.miOpen_Click);
			// 
			// miLastUsed
			// 
			this.miLastUsed.Name = "miLastUsed";
			this.miLastUsed.Size = new System.Drawing.Size(215, 22);
			this.miLastUsed.Text = "Zuletzt Verwendet";
			// 
			// miOpenWithTextEditor
			// 
			this.miOpenWithTextEditor.Name = "miOpenWithTextEditor";
			this.miOpenWithTextEditor.Size = new System.Drawing.Size(215, 22);
			this.miOpenWithTextEditor.Text = "Öffnen mit Text-Editor";
			this.miOpenWithTextEditor.Click += new System.EventHandler(this.miOpenWithTextEditor_Click);
			// 
			// seperator2
			// 
			this.seperator2.Name = "seperator2";
			this.seperator2.Size = new System.Drawing.Size(212, 6);
			// 
			// miSave
			// 
			this.miSave.Name = "miSave";
			this.miSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.miSave.Size = new System.Drawing.Size(215, 22);
			this.miSave.Text = "Speichern";
			this.miSave.Click += new System.EventHandler(this.miSave_Click);
			// 
			// miSaveAs
			// 
			this.miSaveAs.Name = "miSaveAs";
			this.miSaveAs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.S)));
			this.miSaveAs.Size = new System.Drawing.Size(215, 22);
			this.miSaveAs.Text = "Speichern als...";
			this.miSaveAs.Click += new System.EventHandler(this.miSaveAs_Click);
			// 
			// seperator3
			// 
			this.seperator3.Name = "seperator3";
			this.seperator3.Size = new System.Drawing.Size(212, 6);
			// 
			// miExport
			// 
			this.miExport.Name = "miExport";
			this.miExport.Size = new System.Drawing.Size(215, 22);
			this.miExport.Text = "Exportieren";
			// 
			// mEdit
			// 
			this.mEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miEditTable,
            this.miOptions});
			this.mEdit.Name = "mEdit";
			this.mEdit.Padding = new System.Windows.Forms.Padding(6, 2, 6, 2);
			this.mEdit.ShowShortcutKeys = false;
			this.mEdit.Size = new System.Drawing.Size(79, 23);
			this.mEdit.Text = "Bearbeiten";
			// 
			// miEditTable
			// 
			this.miEditTable.Name = "miEditTable";
			this.miEditTable.Size = new System.Drawing.Size(159, 22);
			this.miEditTable.Text = "Tabelle Editieren";
			// 
			// miOptions
			// 
			this.miOptions.Name = "mOptions";
			this.miOptions.Size = new System.Drawing.Size(159, 22);
			this.miOptions.Text = "Einstellungen";
			this.miOptions.Click += new System.EventHandler(this.miOptions_Click);
			// 
			// mHelp
			// 
			this.mHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miWebsite,
            this.miGithub,
            this.miMail});
			this.mHelp.Name = "mHelp";
			this.mHelp.Padding = new System.Windows.Forms.Padding(6, 2, 6, 2);
			this.mHelp.ShowShortcutKeys = false;
			this.mHelp.Size = new System.Drawing.Size(48, 23);
			this.mHelp.Text = "Hilfe";
			// 
			// miWebsite
			// 
			this.miWebsite.BackColor = System.Drawing.SystemColors.Window;
			this.miWebsite.Name = "miWebsite";
			this.miWebsite.Size = new System.Drawing.Size(122, 22);
			this.miWebsite.Text = "Webseite";
			// 
			// miGithub
			// 
			this.miGithub.BackColor = System.Drawing.SystemColors.Window;
			this.miGithub.Name = "miGithub";
			this.miGithub.Size = new System.Drawing.Size(122, 22);
			this.miGithub.Text = "GitHub";
			// 
			// miMail
			// 
			this.miMail.BackColor = System.Drawing.SystemColors.Window;
			this.miMail.Name = "miMail";
			this.miMail.Size = new System.Drawing.Size(122, 22);
			this.miMail.Text = "E-Mail";
			// 
			// tShowInputPanel
			// 
			this.tShowInputPanel.Interval = 5;
			this.tShowInputPanel.Tick += new System.EventHandler(this.tShowInputPanel_Tick);
			// 
			// pInput
			// 
			this.pInput.BackColor = System.Drawing.SystemColors.Window;
			this.pInput.Controls.Add(this.inputPanel);
			this.pInput.Controls.Add(this.bShowInputPanel);
			this.pInput.Controls.Add(this.line1);
			this.pInput.Dock = System.Windows.Forms.DockStyle.Top;
			this.pInput.Location = new System.Drawing.Point(0, 23);
			this.pInput.Name = "pInput";
			this.pInput.Size = new System.Drawing.Size(1004, 28);
			this.pInput.TabIndex = 2;
			// 
			// inputPanel
			// 
			this.inputPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.inputPanel.Location = new System.Drawing.Point(0, -114);
			this.inputPanel.Margin = new System.Windows.Forms.Padding(0);
			this.inputPanel.Name = "inputPanel";
			this.inputPanel.Size = new System.Drawing.Size(960, 140);
			this.inputPanel.TabIndex = 2;
			this.inputPanel.SendData += new System.EventHandler(this.inputPanel_SendData);
			this.inputPanel.UserStoryChanged += new System.EventHandler(this.inputPanel_UserStroyChanged);
			this.inputPanel.ParticipientChanged += new System.EventHandler(this.inputPanel_ParticipentChanged);
			// 
			// bShowInputPanel
			// 
			this.bShowInputPanel.BackgroundImage = global::Timecord.Properties.Resources.angle_up;
			this.bShowInputPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.bShowInputPanel.Dock = System.Windows.Forms.DockStyle.Right;
			this.bShowInputPanel.FlatAppearance.BorderSize = 0;
			this.bShowInputPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bShowInputPanel.Location = new System.Drawing.Point(960, 0);
			this.bShowInputPanel.Margin = new System.Windows.Forms.Padding(0);
			this.bShowInputPanel.MaximumSize = new System.Drawing.Size(50, 26);
			this.bShowInputPanel.MinimumSize = new System.Drawing.Size(44, 26);
			this.bShowInputPanel.Name = "bShowInputPanel";
			this.bShowInputPanel.Padding = new System.Windows.Forms.Padding(2);
			this.bShowInputPanel.Size = new System.Drawing.Size(44, 26);
			this.bShowInputPanel.TabIndex = 1;
			this.bShowInputPanel.UseVisualStyleBackColor = true;
			this.bShowInputPanel.Click += new System.EventHandler(this.bShowInputPanel_Click);
			// 
			// line1
			// 
			this.line1.BackColor = System.Drawing.Color.Transparent;
			this.line1.Color = System.Drawing.Color.Silver;
			this.line1.Degrees = Timecord.Controls.Degrees.Degrees_0;
			this.line1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.line1.LineWidth = 2;
			this.line1.Location = new System.Drawing.Point(0, 26);
			this.line1.MinimumSize = new System.Drawing.Size(0, 1);
			this.line1.Name = "line1";
			this.line1.Size = new System.Drawing.Size(1004, 2);
			this.line1.TabIndex = 0;
			this.line1.TabStop = false;
			// 
			// openFileDialog
			// 
			this.openFileDialog.Filter = "Timecord Files|*.tc";
			this.openFileDialog.RestoreDirectory = true;
			this.openFileDialog.Title = "Öffnen";
			// 
			// saveFileDialog
			// 
			this.saveFileDialog.Filter = "Timecord Files|*.tc";
			this.saveFileDialog.RestoreDirectory = true;
			this.saveFileDialog.Title = "Neu";
			// 
			// browser
			// 
			this.browser.Dock = System.Windows.Forms.DockStyle.Fill;
			this.browser.Location = new System.Drawing.Point(0, 51);
			this.browser.MinimumSize = new System.Drawing.Size(20, 20);
			this.browser.Name = "browser";
			this.browser.Size = new System.Drawing.Size(1004, 510);
			this.browser.Source = new System.Uri("ms-appx-web:///src/Table.html", System.UriKind.Absolute);
			this.browser.TabIndex = 3;
			this.browser.TabStop = false;
			// 
			// miExportPdf
			// 
			this.miExportPdf.Name = "miExportPdf";
			this.miExportPdf.Size = new System.Drawing.Size(101, 22);
			this.miExportPdf.Text = "Pdf";
			this.miExportPdf.Click += new System.EventHandler(this.miExportPdf_Click);
			// 
			// miExportHtml
			// 
			this.miExportHtml.Name = "miExportHtml";
			this.miExportHtml.Size = new System.Drawing.Size(101, 22);
			this.miExportHtml.Text = "Html";
			this.miExportHtml.Click += new System.EventHandler(this.miExportHtml_Click);
			// 
			// preventBrowserFocus
			// 
			this.preventBrowserFocus.Enabled = true;
			this.preventBrowserFocus.Interval = 1;
			this.preventBrowserFocus.Tick += new System.EventHandler(this.preventBrowserFocus_Tick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(1004, 561);
			this.Controls.Add(this.browser);
			this.Controls.Add(this.pInput);
			this.Controls.Add(this.menu);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menu;
			this.MinimumSize = new System.Drawing.Size(1020, 600);
			this.Name = "MainForm";
			this.Text = "Timecord";
			this.menu.ResumeLayout(false);
			this.menu.PerformLayout();
			this.pInput.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.browser)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		private void OptionForm_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e) {
			optionForm = null;
		}

		#endregion

		private System.Windows.Forms.MenuStrip menu;
		private System.Windows.Forms.ToolStripMenuItem mFile;
		private System.Windows.Forms.ToolStripMenuItem miNew;
		private System.Windows.Forms.ToolStripMenuItem miOpen;
		private System.Windows.Forms.ToolStripMenuItem mHelp;
		private System.Windows.Forms.ToolStripMenuItem miWebsite;
		private System.Windows.Forms.ToolStripMenuItem miGithub;
		private System.Windows.Forms.ToolStripMenuItem miMail;
		private System.Windows.Forms.Timer tShowInputPanel;
		private System.Windows.Forms.Panel pInput;
		private System.Windows.Forms.Button bShowInputPanel;
		private Forms.InputPanel inputPanel;
		private Controls.Line line1;
		private System.Windows.Forms.ToolStripMenuItem miLastUsed;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.SaveFileDialog saveFileDialog;
		private Controls.CustomToolStripSeparator seperator1;
		private Controls.CustomToolStripSeparator seperator2;
		private System.Windows.Forms.ToolStripMenuItem miSave;
		private System.Windows.Forms.ToolStripMenuItem miSaveAs;
		private System.Windows.Forms.ToolStripMenuItem miExport;
		private System.Windows.Forms.ToolStripMenuItem mEdit;
		private System.Windows.Forms.ToolStripMenuItem miEditTable;
		private Controls.CustomToolStripSeparator seperator3;
		private Microsoft.Toolkit.Forms.UI.Controls.WebView browser;
		private System.Windows.Forms.ToolStripMenuItem miExportPdf;
		private System.Windows.Forms.ToolStripMenuItem miExportHtml;
		private System.Windows.Forms.ToolStripMenuItem miOpenWithTextEditor;
		private System.Windows.Forms.Timer preventBrowserFocus;
		private System.Windows.Forms.ToolStripMenuItem miOptions;
	}
}

