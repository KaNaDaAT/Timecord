namespace Timecord.Forms {
	partial class OptionForm {
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
			System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Speichern");
			System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Aussehen");
			System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Vorlagen");
			System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Daten");
			System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Tabelle", new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode14});
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.bCancel = new Timecord.Controls.CustomButton();
			this.bApply = new Timecord.Controls.CustomButton();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.menu = new System.Windows.Forms.TreeView();
			this.PanelContainer = new System.Windows.Forms.Panel();
			this.pTable = new System.Windows.Forms.Panel();
			this.pTableData = new System.Windows.Forms.Panel();
			this.pTableTemplate = new System.Windows.Forms.Panel();
			this.pSave = new System.Windows.Forms.Panel();
			this.cbAutoSave = new System.Windows.Forms.CheckBox();
			this.pAppearance = new System.Windows.Forms.Panel();
			this.cbExpandedInput = new System.Windows.Forms.CheckBox();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.PanelContainer.SuspendLayout();
			this.pSave.SuspendLayout();
			this.pAppearance.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(478, 275);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 4;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
			this.tableLayoutPanel2.Controls.Add(this.bCancel, 3, 0);
			this.tableLayoutPanel2.Controls.Add(this.bApply, 1, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 248);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(472, 24);
			this.tableLayoutPanel2.TabIndex = 1;
			// 
			// bCancel
			// 
			this.bCancel.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.bCancel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.bCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.bCancel.FlatAppearance.BorderSize = 0;
			this.bCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
			this.bCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
			this.bCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bCancel.Location = new System.Drawing.Point(392, 0);
			this.bCancel.Margin = new System.Windows.Forms.Padding(0);
			this.bCancel.Name = "bCancel";
			this.bCancel.Size = new System.Drawing.Size(80, 24);
			this.bCancel.TabIndex = 3;
			this.bCancel.Text = "Abbrechen";
			this.bCancel.UseVisualStyleBackColor = true;
			this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
			// 
			// bApply
			// 
			this.bApply.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.bApply.Dock = System.Windows.Forms.DockStyle.Fill;
			this.bApply.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.bApply.FlatAppearance.BorderSize = 0;
			this.bApply.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
			this.bApply.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
			this.bApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bApply.Location = new System.Drawing.Point(304, 0);
			this.bApply.Margin = new System.Windows.Forms.Padding(0);
			this.bApply.Name = "bApply";
			this.bApply.Size = new System.Drawing.Size(80, 24);
			this.bApply.TabIndex = 2;
			this.bApply.Text = "Anwenden";
			this.bApply.UseVisualStyleBackColor = true;
			this.bApply.Click += new System.EventHandler(this.bApply_Click);
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.ColumnCount = 2;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel3.Controls.Add(this.menu, 0, 0);
			this.tableLayoutPanel3.Controls.Add(this.PanelContainer, 1, 0);
			this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 1;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 257F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 257F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(478, 245);
			this.tableLayoutPanel3.TabIndex = 2;
			// 
			// menu
			// 
			this.menu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.menu.Dock = System.Windows.Forms.DockStyle.Fill;
			this.menu.Location = new System.Drawing.Point(3, 3);
			this.menu.Name = "menu";
			treeNode11.Name = "nSave";
			treeNode11.Text = "Speichern";
			treeNode12.Name = "nAppearance";
			treeNode12.Text = "Aussehen";
			treeNode13.Name = "nTableTemplate";
			treeNode13.Text = "Vorlagen";
			treeNode14.Name = "nTableData";
			treeNode14.Text = "Daten";
			treeNode15.Name = "nTable";
			treeNode15.Text = "Tabelle";
			this.menu.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode12,
            treeNode15});
			this.menu.ShowLines = false;
			this.menu.Size = new System.Drawing.Size(154, 239);
			this.menu.TabIndex = 0;
			this.menu.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.menu_AfterSelect);
			// 
			// PanelContainer
			// 
			this.PanelContainer.Controls.Add(this.pSave);
			this.PanelContainer.Controls.Add(this.pAppearance);
			this.PanelContainer.Controls.Add(this.pTable);
			this.PanelContainer.Controls.Add(this.pTableData);
			this.PanelContainer.Controls.Add(this.pTableTemplate);
			this.PanelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PanelContainer.Location = new System.Drawing.Point(163, 3);
			this.PanelContainer.Name = "PanelContainer";
			this.PanelContainer.Size = new System.Drawing.Size(312, 239);
			this.PanelContainer.TabIndex = 1;
			// 
			// pTable
			// 
			this.pTable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pTable.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pTable.Location = new System.Drawing.Point(0, 0);
			this.pTable.Name = "pTable";
			this.pTable.Padding = new System.Windows.Forms.Padding(4);
			this.pTable.Size = new System.Drawing.Size(312, 239);
			this.pTable.TabIndex = 1;
			// 
			// pTableData
			// 
			this.pTableData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pTableData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pTableData.Location = new System.Drawing.Point(0, 0);
			this.pTableData.Name = "pTableData";
			this.pTableData.Padding = new System.Windows.Forms.Padding(4);
			this.pTableData.Size = new System.Drawing.Size(312, 239);
			this.pTableData.TabIndex = 1;
			// 
			// pTableTemplate
			// 
			this.pTableTemplate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pTableTemplate.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pTableTemplate.Location = new System.Drawing.Point(0, 0);
			this.pTableTemplate.Name = "pTableTemplate";
			this.pTableTemplate.Padding = new System.Windows.Forms.Padding(4);
			this.pTableTemplate.Size = new System.Drawing.Size(312, 239);
			this.pTableTemplate.TabIndex = 1;
			// 
			// pSave
			// 
			this.pSave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pSave.Controls.Add(this.cbAutoSave);
			this.pSave.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pSave.Location = new System.Drawing.Point(0, 0);
			this.pSave.Name = "pSave";
			this.pSave.Padding = new System.Windows.Forms.Padding(11);
			this.pSave.Size = new System.Drawing.Size(312, 239);
			this.pSave.TabIndex = 1;
			// 
			// cbAutoSave
			// 
			this.cbAutoSave.AutoSize = true;
			this.cbAutoSave.Location = new System.Drawing.Point(7, 7);
			this.cbAutoSave.Name = "cbAutoSave";
			this.cbAutoSave.Size = new System.Drawing.Size(146, 17);
			this.cbAutoSave.TabIndex = 0;
			this.cbAutoSave.Text = "Automatisches Speichern";
			this.cbAutoSave.UseVisualStyleBackColor = true;
			// 
			// pAppearance
			// 
			this.pAppearance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pAppearance.Controls.Add(this.cbExpandedInput);
			this.pAppearance.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pAppearance.Location = new System.Drawing.Point(0, 0);
			this.pAppearance.Name = "pAppearance";
			this.pAppearance.Padding = new System.Windows.Forms.Padding(11);
			this.pAppearance.Size = new System.Drawing.Size(312, 239);
			this.pAppearance.TabIndex = 1;
			// 
			// cbExpandedInput
			// 
			this.cbExpandedInput.AutoSize = true;
			this.cbExpandedInput.Location = new System.Drawing.Point(7, 7);
			this.cbExpandedInput.Name = "cbExpandedInput";
			this.cbExpandedInput.Size = new System.Drawing.Size(175, 17);
			this.cbExpandedInput.TabIndex = 0;
			this.cbExpandedInput.Text = "Inputfeld beim Start ausklappen";
			this.cbExpandedInput.UseVisualStyleBackColor = true;
			// 
			// OptionForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(478, 275);
			this.ControlBox = false;
			this.Controls.Add(this.tableLayoutPanel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.HelpButton = true;
			this.Name = "OptionForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Einstellungen";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel3.ResumeLayout(false);
			this.PanelContainer.ResumeLayout(false);
			this.pSave.ResumeLayout(false);
			this.pSave.PerformLayout();
			this.pAppearance.ResumeLayout(false);
			this.pAppearance.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TreeView menu;
		private Controls.CustomButton bApply;
		private Controls.CustomButton bCancel;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.Panel pSave;
		private System.Windows.Forms.Panel pAppearance;
		private System.Windows.Forms.Panel pTable;
		private System.Windows.Forms.Panel pTableData;
		private System.Windows.Forms.Panel pTableTemplate;
		private System.Windows.Forms.CheckBox cbAutoSave;
		private System.Windows.Forms.Panel PanelContainer;
		private System.Windows.Forms.CheckBox cbExpandedInput;
	}
}