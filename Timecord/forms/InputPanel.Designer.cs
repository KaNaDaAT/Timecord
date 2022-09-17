using System;

namespace Timecord.Forms {
	partial class InputPanel {
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			this.layoutMainTablePanel = new System.Windows.Forms.TableLayoutPanel();
			this.line4 = new Timecord.Controls.Line();
			this.line3 = new Timecord.Controls.Line();
			this.line2 = new Timecord.Controls.Line();
			this.pWorking = new System.Windows.Forms.Panel();
			this.tbWorking = new System.Windows.Forms.TextBox();
			this.lWorking = new System.Windows.Forms.Label();
			this.pUserStory = new System.Windows.Forms.Panel();
			this.bRemoveUserStory = new Timecord.Controls.CustomButton();
			this.bSelectColorUserStory = new System.Windows.Forms.FlowLayoutPanel();
			this.bAddUserStory = new Timecord.Controls.CustomButton();
			this.ccbUserStory = new Timecord.Controls.ColoredComboBox();
			this.lUserStory = new System.Windows.Forms.Label();
			this.line1 = new Timecord.Controls.Line();
			this.pEstimatedTime = new System.Windows.Forms.Panel();
			this.bMinuteMinus = new Timecord.Controls.CustomButton();
			this.bMinutePlus = new Timecord.Controls.CustomButton();
			this.bHourMinus = new Timecord.Controls.CustomButton();
			this.bHourPlus = new Timecord.Controls.CustomButton();
			this.tbEstimatedTime = new System.Windows.Forms.TextBox();
			this.lEstimatedTime = new System.Windows.Forms.Label();
			this.pProgress = new System.Windows.Forms.Panel();
			this.tProgress = new System.Windows.Forms.TextBox();
			this.sProgress = new Timecord.controls.Slider();
			this.trackBar1 = new System.Windows.Forms.TrackBar();
			this.lProgress = new System.Windows.Forms.Label();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.bRecord = new Timecord.Controls.CustomButton();
			this.bStartPause = new Timecord.Controls.CustomButton();
			this.pParticipant = new System.Windows.Forms.Panel();
			this.bRemoveParticipant = new Timecord.Controls.CustomButton();
			this.bAddParticipant = new Timecord.Controls.CustomButton();
			this.lParticipant = new System.Windows.Forms.Label();
			this.ccbParticipant = new Timecord.Controls.ColoredComboBox();
			this.cdUserStory = new System.Windows.Forms.ColorDialog();
			this.timerProgress = new System.Windows.Forms.Timer(this.components);
			this.layoutMainTablePanel.SuspendLayout();
			this.pWorking.SuspendLayout();
			this.pUserStory.SuspendLayout();
			this.pEstimatedTime.SuspendLayout();
			this.pProgress.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			this.pParticipant.SuspendLayout();
			this.SuspendLayout();
			// 
			// layoutMainTablePanel
			// 
			this.layoutMainTablePanel.BackColor = System.Drawing.SystemColors.Window;
			this.layoutMainTablePanel.ColumnCount = 13;
			this.layoutMainTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.layoutMainTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
			this.layoutMainTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.layoutMainTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
			this.layoutMainTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.layoutMainTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
			this.layoutMainTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.layoutMainTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
			this.layoutMainTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.layoutMainTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
			this.layoutMainTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.layoutMainTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 44F));
			this.layoutMainTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
			this.layoutMainTablePanel.Controls.Add(this.line4, 2, 0);
			this.layoutMainTablePanel.Controls.Add(this.line3, 8, 0);
			this.layoutMainTablePanel.Controls.Add(this.line2, 6, 0);
			this.layoutMainTablePanel.Controls.Add(this.pWorking, 5, 0);
			this.layoutMainTablePanel.Controls.Add(this.pUserStory, 1, 0);
			this.layoutMainTablePanel.Controls.Add(this.line1, 4, 0);
			this.layoutMainTablePanel.Controls.Add(this.pEstimatedTime, 7, 0);
			this.layoutMainTablePanel.Controls.Add(this.pProgress, 9, 0);
			this.layoutMainTablePanel.Controls.Add(this.tableLayoutPanel1, 11, 0);
			this.layoutMainTablePanel.Controls.Add(this.pParticipant, 3, 0);
			this.layoutMainTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutMainTablePanel.Location = new System.Drawing.Point(0, 0);
			this.layoutMainTablePanel.Margin = new System.Windows.Forms.Padding(0);
			this.layoutMainTablePanel.Name = "layoutMainTablePanel";
			this.layoutMainTablePanel.RowCount = 1;
			this.layoutMainTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.layoutMainTablePanel.Size = new System.Drawing.Size(960, 110);
			this.layoutMainTablePanel.TabIndex = 0;
			// 
			// line4
			// 
			this.line4.BackColor = System.Drawing.Color.Transparent;
			this.line4.Color = System.Drawing.Color.Gray;
			this.line4.Degrees = Timecord.Controls.Degrees.Degrees_90;
			this.line4.Dock = System.Windows.Forms.DockStyle.Top;
			this.line4.LineWidth = 1;
			this.line4.Location = new System.Drawing.Point(183, 3);
			this.line4.MinimumSize = new System.Drawing.Size(0, 2);
			this.line4.Name = "line4";
			this.line4.Size = new System.Drawing.Size(14, 104);
			this.line4.TabIndex = 7;
			this.line4.TabStop = false;
			// 
			// line3
			// 
			this.line3.BackColor = System.Drawing.Color.Transparent;
			this.line3.Color = System.Drawing.Color.Gray;
			this.line3.Degrees = Timecord.Controls.Degrees.Degrees_90;
			this.line3.Dock = System.Windows.Forms.DockStyle.Top;
			this.line3.LineWidth = 1;
			this.line3.Location = new System.Drawing.Point(723, 3);
			this.line3.MinimumSize = new System.Drawing.Size(0, 2);
			this.line3.Name = "line3";
			this.line3.Size = new System.Drawing.Size(14, 104);
			this.line3.TabIndex = 3;
			this.line3.TabStop = false;
			// 
			// line2
			// 
			this.line2.BackColor = System.Drawing.Color.Transparent;
			this.line2.Color = System.Drawing.Color.Gray;
			this.line2.Degrees = Timecord.Controls.Degrees.Degrees_90;
			this.line2.Dock = System.Windows.Forms.DockStyle.Top;
			this.line2.LineWidth = 1;
			this.line2.Location = new System.Drawing.Point(543, 3);
			this.line2.MinimumSize = new System.Drawing.Size(0, 2);
			this.line2.Name = "line2";
			this.line2.Size = new System.Drawing.Size(14, 104);
			this.line2.TabIndex = 2;
			this.line2.TabStop = false;
			// 
			// pWorking
			// 
			this.pWorking.Controls.Add(this.tbWorking);
			this.pWorking.Controls.Add(this.lWorking);
			this.pWorking.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pWorking.Location = new System.Drawing.Point(380, 0);
			this.pWorking.Margin = new System.Windows.Forms.Padding(0);
			this.pWorking.Name = "pWorking";
			this.pWorking.Size = new System.Drawing.Size(160, 110);
			this.pWorking.TabIndex = 1;
			// 
			// tbWorking
			// 
			this.tbWorking.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbWorking.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbWorking.Location = new System.Drawing.Point(5, 41);
			this.tbWorking.MaxLength = 1000;
			this.tbWorking.Multiline = true;
			this.tbWorking.Name = "tbWorking";
			this.tbWorking.Size = new System.Drawing.Size(152, 57);
			this.tbWorking.TabIndex = 3;
			this.tbWorking.TextChanged += new System.EventHandler(this.tbWorking_TextChanged);
			// 
			// lWorking
			// 
			this.lWorking.Dock = System.Windows.Forms.DockStyle.Top;
			this.lWorking.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lWorking.Location = new System.Drawing.Point(0, 0);
			this.lWorking.Name = "lWorking";
			this.lWorking.Size = new System.Drawing.Size(160, 38);
			this.lWorking.TabIndex = 0;
			this.lWorking.Text = "Arbeit";
			this.lWorking.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// pUserStory
			// 
			this.pUserStory.Controls.Add(this.bRemoveUserStory);
			this.pUserStory.Controls.Add(this.bSelectColorUserStory);
			this.pUserStory.Controls.Add(this.bAddUserStory);
			this.pUserStory.Controls.Add(this.ccbUserStory);
			this.pUserStory.Controls.Add(this.lUserStory);
			this.pUserStory.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pUserStory.Location = new System.Drawing.Point(20, 0);
			this.pUserStory.Margin = new System.Windows.Forms.Padding(0);
			this.pUserStory.Name = "pUserStory";
			this.pUserStory.Size = new System.Drawing.Size(160, 110);
			this.pUserStory.TabIndex = 0;
			// 
			// bRemoveUserStory
			// 
			this.bRemoveUserStory.BackgroundImage = global::Timecord.Properties.Resources.remove;
			this.bRemoveUserStory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.bRemoveUserStory.BorderColorActive = System.Drawing.Color.Gray;
			this.bRemoveUserStory.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.bRemoveUserStory.FlatAppearance.BorderSize = 0;
			this.bRemoveUserStory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bRemoveUserStory.Location = new System.Drawing.Point(32, 41);
			this.bRemoveUserStory.Name = "bRemoveUserStory";
			this.bRemoveUserStory.Size = new System.Drawing.Size(24, 24);
			this.bRemoveUserStory.TabIndex = 3;
			this.bRemoveUserStory.UseVisualStyleBackColor = true;
			this.bRemoveUserStory.Click += new System.EventHandler(this.bRemoveUserStory_Click);
			// 
			// bSelectColorUserStory
			// 
			this.bSelectColorUserStory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.bSelectColorUserStory.Location = new System.Drawing.Point(107, 41);
			this.bSelectColorUserStory.Name = "bSelectColorUserStory";
			this.bSelectColorUserStory.Size = new System.Drawing.Size(50, 24);
			this.bSelectColorUserStory.TabIndex = 1;
			this.bSelectColorUserStory.TabStop = true;
			this.bSelectColorUserStory.Click += new System.EventHandler(this.bSelectColorUserStory_Click);
			// 
			// bAddUserStory
			// 
			this.bAddUserStory.BackgroundImage = global::Timecord.Properties.Resources.plus;
			this.bAddUserStory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.bAddUserStory.BorderColorActive = System.Drawing.Color.Gray;
			this.bAddUserStory.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.bAddUserStory.FlatAppearance.BorderSize = 0;
			this.bAddUserStory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bAddUserStory.Location = new System.Drawing.Point(5, 41);
			this.bAddUserStory.Name = "bAddUserStory";
			this.bAddUserStory.Size = new System.Drawing.Size(24, 24);
			this.bAddUserStory.TabIndex = 0;
			this.bAddUserStory.UseVisualStyleBackColor = true;
			this.bAddUserStory.Click += new System.EventHandler(this.bAddUserStory_Click);
			// 
			// ccbUserStory
			// 
			this.ccbUserStory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.ccbUserStory.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.ccbUserStory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.ccbUserStory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ccbUserStory.FormattingEnabled = true;
			this.ccbUserStory.IntegralHeight = false;
			this.ccbUserStory.ItemHeight = 22;
			this.ccbUserStory.Location = new System.Drawing.Point(5, 70);
			this.ccbUserStory.MaxDropDownItems = 6;
			this.ccbUserStory.Name = "ccbUserStory";
			this.ccbUserStory.Size = new System.Drawing.Size(152, 28);
			this.ccbUserStory.TabIndex = 2;
			this.ccbUserStory.SelectedIndexChanged += new System.EventHandler(this.ccbUserStory_SelectedIndexChanged);
			this.ccbUserStory.SelectionChangeCommitted += new System.EventHandler(this.ccbUserStory_SelectedIndexChanged);
			// 
			// lUserStory
			// 
			this.lUserStory.Dock = System.Windows.Forms.DockStyle.Top;
			this.lUserStory.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lUserStory.Location = new System.Drawing.Point(0, 0);
			this.lUserStory.Name = "lUserStory";
			this.lUserStory.Size = new System.Drawing.Size(160, 38);
			this.lUserStory.TabIndex = 0;
			this.lUserStory.Text = "UserStory";
			this.lUserStory.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// line1
			// 
			this.line1.BackColor = System.Drawing.Color.Transparent;
			this.line1.Color = System.Drawing.Color.Gray;
			this.line1.Degrees = Timecord.Controls.Degrees.Degrees_90;
			this.line1.Dock = System.Windows.Forms.DockStyle.Top;
			this.line1.LineWidth = 1;
			this.line1.Location = new System.Drawing.Point(363, 3);
			this.line1.MinimumSize = new System.Drawing.Size(0, 2);
			this.line1.Name = "line1";
			this.line1.Size = new System.Drawing.Size(14, 104);
			this.line1.TabIndex = 0;
			this.line1.TabStop = false;
			// 
			// pEstimatedTime
			// 
			this.pEstimatedTime.Controls.Add(this.bMinuteMinus);
			this.pEstimatedTime.Controls.Add(this.bMinutePlus);
			this.pEstimatedTime.Controls.Add(this.bHourMinus);
			this.pEstimatedTime.Controls.Add(this.bHourPlus);
			this.pEstimatedTime.Controls.Add(this.tbEstimatedTime);
			this.pEstimatedTime.Controls.Add(this.lEstimatedTime);
			this.pEstimatedTime.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pEstimatedTime.Location = new System.Drawing.Point(560, 0);
			this.pEstimatedTime.Margin = new System.Windows.Forms.Padding(0);
			this.pEstimatedTime.Name = "pEstimatedTime";
			this.pEstimatedTime.Size = new System.Drawing.Size(160, 110);
			this.pEstimatedTime.TabIndex = 4;
			// 
			// bMinuteMinus
			// 
			this.bMinuteMinus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.bMinuteMinus.BorderColorActive = System.Drawing.Color.Gray;
			this.bMinuteMinus.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.bMinuteMinus.FlatAppearance.BorderSize = 0;
			this.bMinuteMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bMinuteMinus.Font = new System.Drawing.Font("Arial", 10F);
			this.bMinuteMinus.Location = new System.Drawing.Point(133, 41);
			this.bMinuteMinus.Name = "bMinuteMinus";
			this.bMinuteMinus.Size = new System.Drawing.Size(24, 24);
			this.bMinuteMinus.TabIndex = 6;
			this.bMinuteMinus.Text = "-";
			this.bMinuteMinus.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
			this.bMinuteMinus.UseVisualStyleBackColor = true;
			this.bMinuteMinus.Click += new System.EventHandler(this.bMinuteMinus_Click);
			// 
			// bMinutePlus
			// 
			this.bMinutePlus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.bMinutePlus.BorderColorActive = System.Drawing.Color.Gray;
			this.bMinutePlus.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.bMinutePlus.FlatAppearance.BorderSize = 0;
			this.bMinutePlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bMinutePlus.Font = new System.Drawing.Font("Arial", 10F);
			this.bMinutePlus.Location = new System.Drawing.Point(106, 41);
			this.bMinutePlus.Name = "bMinutePlus";
			this.bMinutePlus.Size = new System.Drawing.Size(24, 24);
			this.bMinutePlus.TabIndex = 5;
			this.bMinutePlus.Text = "+";
			this.bMinutePlus.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
			this.bMinutePlus.UseVisualStyleBackColor = true;
			this.bMinutePlus.Click += new System.EventHandler(this.bMinutePlus_Click);
			// 
			// bHourMinus
			// 
			this.bHourMinus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.bHourMinus.BorderColorActive = System.Drawing.Color.Gray;
			this.bHourMinus.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.bHourMinus.FlatAppearance.BorderSize = 0;
			this.bHourMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bHourMinus.Font = new System.Drawing.Font("Arial", 10F);
			this.bHourMinus.Location = new System.Drawing.Point(32, 41);
			this.bHourMinus.Name = "bHourMinus";
			this.bHourMinus.Size = new System.Drawing.Size(24, 24);
			this.bHourMinus.TabIndex = 4;
			this.bHourMinus.Text = "-";
			this.bHourMinus.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
			this.bHourMinus.UseVisualStyleBackColor = true;
			this.bHourMinus.Click += new System.EventHandler(this.bHourMinus_Click);
			// 
			// bHourPlus
			// 
			this.bHourPlus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.bHourPlus.BorderColorActive = System.Drawing.Color.Gray;
			this.bHourPlus.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.bHourPlus.FlatAppearance.BorderSize = 0;
			this.bHourPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bHourPlus.Font = new System.Drawing.Font("Arial", 10F);
			this.bHourPlus.Location = new System.Drawing.Point(5, 41);
			this.bHourPlus.Name = "bHourPlus";
			this.bHourPlus.Size = new System.Drawing.Size(24, 24);
			this.bHourPlus.TabIndex = 3;
			this.bHourPlus.Text = "+";
			this.bHourPlus.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
			this.bHourPlus.UseVisualStyleBackColor = true;
			this.bHourPlus.Click += new System.EventHandler(this.bHourPlus_Click);
			// 
			// tbEstimatedTime
			// 
			this.tbEstimatedTime.BackColor = System.Drawing.Color.White;
			this.tbEstimatedTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbEstimatedTime.Location = new System.Drawing.Point(5, 70);
			this.tbEstimatedTime.Margin = new System.Windows.Forms.Padding(0);
			this.tbEstimatedTime.MinimumSize = new System.Drawing.Size(4, 28);
			this.tbEstimatedTime.Name = "tbEstimatedTime";
			this.tbEstimatedTime.ReadOnly = true;
			this.tbEstimatedTime.Size = new System.Drawing.Size(152, 26);
			this.tbEstimatedTime.TabIndex = 2;
			this.tbEstimatedTime.Text = "00:00";
			this.tbEstimatedTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.tbEstimatedTime.TextChanged += new System.EventHandler(this.tbEstimitedTime_TextChanged);
			// 
			// lEstimatedTime
			// 
			this.lEstimatedTime.Dock = System.Windows.Forms.DockStyle.Top;
			this.lEstimatedTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lEstimatedTime.Location = new System.Drawing.Point(0, 0);
			this.lEstimatedTime.Name = "lEstimatedTime";
			this.lEstimatedTime.Size = new System.Drawing.Size(160, 38);
			this.lEstimatedTime.TabIndex = 0;
			this.lEstimatedTime.Text = "Geplante Zeit";
			this.lEstimatedTime.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// pProgress
			// 
			this.pProgress.Controls.Add(this.tProgress);
			this.pProgress.Controls.Add(this.sProgress);
			this.pProgress.Controls.Add(this.trackBar1);
			this.pProgress.Controls.Add(this.lProgress);
			this.pProgress.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pProgress.Location = new System.Drawing.Point(740, 0);
			this.pProgress.Margin = new System.Windows.Forms.Padding(0);
			this.pProgress.Name = "pProgress";
			this.pProgress.Size = new System.Drawing.Size(160, 110);
			this.pProgress.TabIndex = 5;
			// 
			// tProgress
			// 
			this.tProgress.BackColor = System.Drawing.Color.White;
			this.tProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tProgress.Location = new System.Drawing.Point(113, 40);
			this.tProgress.MaxLength = 5;
			this.tProgress.MinimumSize = new System.Drawing.Size(4, 24);
			this.tProgress.Name = "tProgress";
			this.tProgress.Size = new System.Drawing.Size(44, 22);
			this.tProgress.TabIndex = 4;
			this.tProgress.Text = "0 %";
			this.tProgress.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.tProgress.TextChanged += new System.EventHandler(this.tProgress_TextChanged);
			this.tProgress.LostFocus += new System.EventHandler(this.tProgress_LostFocus);
			// 
			// sProgress
			// 
			this.sProgress.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.sProgress.BorderWidth = 1;
			this.sProgress.Location = new System.Drawing.Point(3, 70);
			this.sProgress.MaxValue = 100;
			this.sProgress.MinValue = 0;
			this.sProgress.Name = "sProgress";
			this.sProgress.Size = new System.Drawing.Size(154, 28);
			this.sProgress.TabIndex = 3;
			this.sProgress.Text = "Value";
			this.sProgress.Value = 0;
			this.sProgress.ValueChanged += new System.EventHandler(this.sProgress_ValueChanged);
			// 
			// trackBar1
			// 
			this.trackBar1.Location = new System.Drawing.Point(5, 70);
			this.trackBar1.Maximum = 100;
			this.trackBar1.MaximumSize = new System.Drawing.Size(0, 28);
			this.trackBar1.Name = "trackBar1";
			this.trackBar1.Size = new System.Drawing.Size(0, 45);
			this.trackBar1.TabIndex = 2;
			this.trackBar1.TickFrequency = 10;
			// 
			// lProgress
			// 
			this.lProgress.Dock = System.Windows.Forms.DockStyle.Top;
			this.lProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lProgress.Location = new System.Drawing.Point(0, 0);
			this.lProgress.Name = "lProgress";
			this.lProgress.Size = new System.Drawing.Size(160, 38);
			this.lProgress.TabIndex = 1;
			this.lProgress.Text = "Fortschritt";
			this.lProgress.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.bRecord, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.bStartPause, 0, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(906, 0);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 5;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 4F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(44, 110);
			this.tableLayoutPanel1.TabIndex = 6;
			// 
			// bRecord
			// 
			this.bRecord.BackgroundImage = global::Timecord.Properties.Resources.Stop_disabled;
			this.bRecord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.bRecord.BorderColorActive = System.Drawing.Color.Gray;
			this.bRecord.Dock = System.Windows.Forms.DockStyle.Fill;
			this.bRecord.Enabled = false;
			this.bRecord.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.bRecord.FlatAppearance.BorderSize = 0;
			this.bRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bRecord.Location = new System.Drawing.Point(0, 57);
			this.bRecord.Margin = new System.Windows.Forms.Padding(0);
			this.bRecord.Name = "bRecord";
			this.bRecord.Size = new System.Drawing.Size(44, 44);
			this.bRecord.TabIndex = 1;
			this.bRecord.UseVisualStyleBackColor = true;
			this.bRecord.Click += new System.EventHandler(this.bRecord_Click);
			// 
			// bStartPause
			// 
			this.bStartPause.BackgroundImage = global::Timecord.Properties.Resources.play_enabled;
			this.bStartPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.bStartPause.BorderColorActive = System.Drawing.Color.Gray;
			this.bStartPause.Dock = System.Windows.Forms.DockStyle.Fill;
			this.bStartPause.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.bStartPause.FlatAppearance.BorderSize = 0;
			this.bStartPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bStartPause.Location = new System.Drawing.Point(0, 9);
			this.bStartPause.Margin = new System.Windows.Forms.Padding(0);
			this.bStartPause.Name = "bStartPause";
			this.bStartPause.Size = new System.Drawing.Size(44, 44);
			this.bStartPause.TabIndex = 7;
			this.bStartPause.UseVisualStyleBackColor = true;
			this.bStartPause.Click += new System.EventHandler(this.bStartPause_Click);
			// 
			// pParticipant
			// 
			this.pParticipant.Controls.Add(this.bRemoveParticipant);
			this.pParticipant.Controls.Add(this.bAddParticipant);
			this.pParticipant.Controls.Add(this.lParticipant);
			this.pParticipant.Controls.Add(this.ccbParticipant);
			this.pParticipant.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pParticipant.Location = new System.Drawing.Point(200, 0);
			this.pParticipant.Margin = new System.Windows.Forms.Padding(0);
			this.pParticipant.Name = "pParticipant";
			this.pParticipant.Size = new System.Drawing.Size(160, 110);
			this.pParticipant.TabIndex = 9;
			// 
			// bRemoveParticipant
			// 
			this.bRemoveParticipant.BackgroundImage = global::Timecord.Properties.Resources.remove;
			this.bRemoveParticipant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.bRemoveParticipant.BorderColorActive = System.Drawing.Color.Gray;
			this.bRemoveParticipant.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.bRemoveParticipant.FlatAppearance.BorderSize = 0;
			this.bRemoveParticipant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bRemoveParticipant.Location = new System.Drawing.Point(32, 41);
			this.bRemoveParticipant.Name = "bRemoveParticipant";
			this.bRemoveParticipant.Size = new System.Drawing.Size(24, 24);
			this.bRemoveParticipant.TabIndex = 10;
			this.bRemoveParticipant.UseVisualStyleBackColor = true;
			this.bRemoveParticipant.Click += new System.EventHandler(this.bRemoveParticipant_Click);
			// 
			// bAddParticipant
			// 
			this.bAddParticipant.BackgroundImage = global::Timecord.Properties.Resources.plus;
			this.bAddParticipant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.bAddParticipant.BorderColorActive = System.Drawing.Color.Gray;
			this.bAddParticipant.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.bAddParticipant.FlatAppearance.BorderSize = 0;
			this.bAddParticipant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bAddParticipant.Location = new System.Drawing.Point(5, 41);
			this.bAddParticipant.Name = "bAddParticipant";
			this.bAddParticipant.Size = new System.Drawing.Size(24, 24);
			this.bAddParticipant.TabIndex = 9;
			this.bAddParticipant.UseVisualStyleBackColor = true;
			this.bAddParticipant.Click += new System.EventHandler(this.bAddParticipant_Click);
			// 
			// lParticipant
			// 
			this.lParticipant.Dock = System.Windows.Forms.DockStyle.Top;
			this.lParticipant.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lParticipant.Location = new System.Drawing.Point(0, 0);
			this.lParticipant.Name = "lParticipant";
			this.lParticipant.Size = new System.Drawing.Size(160, 38);
			this.lParticipant.TabIndex = 1;
			this.lParticipant.Text = "Teilnehmer";
			this.lParticipant.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// ccbParticipant
			// 
			this.ccbParticipant.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.ccbParticipant.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.ccbParticipant.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.ccbParticipant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ccbParticipant.FormattingEnabled = true;
			this.ccbParticipant.IntegralHeight = false;
			this.ccbParticipant.ItemHeight = 22;
			this.ccbParticipant.Location = new System.Drawing.Point(5, 70);
			this.ccbParticipant.MaxDropDownItems = 6;
			this.ccbParticipant.Name = "ccbParticipant";
			this.ccbParticipant.Size = new System.Drawing.Size(152, 28);
			this.ccbParticipant.TabIndex = 8;
			// 
			// timerProgress
			// 
			this.timerProgress.Enabled = true;
			this.timerProgress.Interval = 1;
			this.timerProgress.Tick += new System.EventHandler(this.tProgress_SelectionController);
			// 
			// InputPanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.layoutMainTablePanel);
			this.Margin = new System.Windows.Forms.Padding(0);
			this.Name = "InputPanel";
			this.Size = new System.Drawing.Size(960, 110);
			this.layoutMainTablePanel.ResumeLayout(false);
			this.pWorking.ResumeLayout(false);
			this.pWorking.PerformLayout();
			this.pUserStory.ResumeLayout(false);
			this.pEstimatedTime.ResumeLayout(false);
			this.pEstimatedTime.PerformLayout();
			this.pProgress.ResumeLayout(false);
			this.pProgress.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.pParticipant.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel layoutMainTablePanel;
		private System.Windows.Forms.Panel pWorking;
		private Controls.Line line1;
		private System.Windows.Forms.ColorDialog cdUserStory;
		private Controls.Line line3;
		private System.Windows.Forms.Label lWorking;
		private System.Windows.Forms.TextBox tbWorking;
		private System.Windows.Forms.Panel pUserStory;
		private System.Windows.Forms.FlowLayoutPanel bSelectColorUserStory;
		private Controls.CustomButton bAddUserStory;
		private System.Windows.Forms.Label lUserStory;
		private Controls.Line line2;
		private System.Windows.Forms.Panel pEstimatedTime;
		private System.Windows.Forms.TextBox tbEstimatedTime;
		private System.Windows.Forms.Label lEstimatedTime;
		private Controls.CustomButton bHourPlus;
		private Controls.CustomButton bHourMinus;
		private Controls.CustomButton bMinuteMinus;
		private Controls.CustomButton bMinutePlus;
		private System.Windows.Forms.Panel pProgress;
		private System.Windows.Forms.Label lProgress;
		private System.Windows.Forms.TrackBar trackBar1;
		private controls.Slider sProgress;
		private System.Windows.Forms.TextBox tProgress;
		private System.Windows.Forms.Timer timerProgress;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private Controls.CustomButton bRecord;
		private Controls.CustomButton bStartPause;
		private Controls.Line line4;
		private System.Windows.Forms.Panel pParticipant;
		private System.Windows.Forms.Label lParticipant;
		private Controls.CustomButton bAddParticipant;
		private Controls.CustomButton bRemoveUserStory;
		private Controls.CustomButton bRemoveParticipant;
		public Controls.ColoredComboBox ccbUserStory;
		public Controls.ColoredComboBox ccbParticipant;
	}
}
