﻿using osu_trainer.Controls;

namespace osu_trainer
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.BpmMultiplierLabel = new osu_trainer.Controls.AntiAliasedLabel();
            this.BeatmapUpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.OriginalBpmLabel = new osu_trainer.Controls.AntiAliasedLabel();
            this.NewBpmLabel = new osu_trainer.Controls.AntiAliasedLabel();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.ChangePitchCheck = new osu_trainer.Controls.OsuCheckBox();
            this.ScaleODCheck = new osu_trainer.Controls.OsuCheckBox();
            this.ScaleARCheck = new osu_trainer.Controls.OsuCheckBox();
            this.NewBpmTextBox = new System.Windows.Forms.TextBox();
            this.NewBpmRangeTextBox = new System.Windows.Forms.TextBox();
            this.OriginalBpmRangeTextBox = new System.Windows.Forms.TextBox();
            this.OriginalBpmTextBox = new System.Windows.Forms.TextBox();
            this.BpmMultiplierUpDown = new osu_trainer.NumericUpDownFix();
            this.Middle1Panel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ODLockCheck = new osu_trainer.Controls.ToggleIconButton();
            this.ARLockCheck = new osu_trainer.Controls.ToggleIconButton();
            this.CSLockCheck = new osu_trainer.Controls.ToggleIconButton();
            this.odlabel = new osu_trainer.Controls.AntiAliasedLabel();
            this.ODDisplay = new System.Windows.Forms.TextBox();
            this.ODSlider = new osu_trainer.OptionSlider();
            this.arlabel = new osu_trainer.Controls.AntiAliasedLabel();
            this.ARDisplay = new System.Windows.Forms.TextBox();
            this.ARSlider = new osu_trainer.OptionSlider();
            this.cslabel = new osu_trainer.Controls.AntiAliasedLabel();
            this.CSDisplay = new System.Windows.Forms.TextBox();
            this.CSSlider = new osu_trainer.OptionSlider();
            this.hplabel = new osu_trainer.Controls.AntiAliasedLabel();
            this.HPDisplay = new System.Windows.Forms.TextBox();
            this.HPSlider = new osu_trainer.OptionSlider();
            this.HPLockCheck = new osu_trainer.Controls.ToggleIconButton();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.DeleteButton = new osu_trainer.Controls.OsuButton();
            this.ResetButton = new osu_trainer.Controls.OsuButton();
            this.GenerateMapButton = new osu_trainer.Controls.OsuButton();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.SongDisplay = new osu_trainer.Controls.SongDisplay();
            this.closeButton = new System.Windows.Forms.Button();
            this.OsuRunningTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.AimSpeedBar = new osu_trainer.Controls.ExtendedRatioBar();
            this.StarsDisplay = new osu_trainer.Controls.StarsDisplay();
            this.BackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BpmMultiplierUpDown)).BeginInit();
            this.Middle1Panel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.BottomPanel.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.titlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BpmMultiplierLabel
            // 
            this.BpmMultiplierLabel.AutoSize = true;
            this.BpmMultiplierLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(126)))), ((int)(((byte)(114)))));
            this.BpmMultiplierLabel.Location = new System.Drawing.Point(8, 13);
            this.BpmMultiplierLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BpmMultiplierLabel.Name = "BpmMultiplierLabel";
            this.BpmMultiplierLabel.Size = new System.Drawing.Size(101, 16);
            this.BpmMultiplierLabel.TabIndex = 1;
            this.BpmMultiplierLabel.Text = "BPM Multiplier";
            this.BpmMultiplierLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BeatmapUpdateTimer
            // 
            this.BeatmapUpdateTimer.Interval = 20;
            this.BeatmapUpdateTimer.Tick += new System.EventHandler(this.BeatmapUpdateTimer_Tick);
            // 
            // OriginalBpmLabel
            // 
            this.OriginalBpmLabel.AutoSize = true;
            this.OriginalBpmLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(126)))), ((int)(((byte)(114)))));
            this.OriginalBpmLabel.Location = new System.Drawing.Point(19, 48);
            this.OriginalBpmLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OriginalBpmLabel.Name = "OriginalBpmLabel";
            this.OriginalBpmLabel.Size = new System.Drawing.Size(90, 16);
            this.OriginalBpmLabel.TabIndex = 9;
            this.OriginalBpmLabel.Text = "Original BPM";
            this.OriginalBpmLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NewBpmLabel
            // 
            this.NewBpmLabel.AutoSize = true;
            this.NewBpmLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(126)))), ((int)(((byte)(114)))));
            this.NewBpmLabel.Location = new System.Drawing.Point(42, 72);
            this.NewBpmLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NewBpmLabel.Name = "NewBpmLabel";
            this.NewBpmLabel.Size = new System.Drawing.Size(67, 16);
            this.NewBpmLabel.TabIndex = 9;
            this.NewBpmLabel.Text = "New BPM";
            this.NewBpmLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Panel3
            // 
            this.Panel3.Controls.Add(this.ChangePitchCheck);
            this.Panel3.Controls.Add(this.ScaleODCheck);
            this.Panel3.Controls.Add(this.ScaleARCheck);
            this.Panel3.Controls.Add(this.NewBpmTextBox);
            this.Panel3.Controls.Add(this.NewBpmRangeTextBox);
            this.Panel3.Controls.Add(this.OriginalBpmRangeTextBox);
            this.Panel3.Controls.Add(this.OriginalBpmTextBox);
            this.Panel3.Controls.Add(this.OriginalBpmLabel);
            this.Panel3.Controls.Add(this.NewBpmLabel);
            this.Panel3.Controls.Add(this.BpmMultiplierLabel);
            this.Panel3.Controls.Add(this.BpmMultiplierUpDown);
            this.Panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel3.Location = new System.Drawing.Point(0, 311);
            this.Panel3.Name = "Panel3";
            this.Panel3.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.Panel3.Size = new System.Drawing.Size(427, 100);
            this.Panel3.TabIndex = 7;
            this.Panel3.Click += new System.EventHandler(this.Unfocus);
            // 
            // ChangePitchCheck
            // 
            this.ChangePitchCheck.Location = new System.Drawing.Point(276, 69);
            this.ChangePitchCheck.Name = "ChangePitchCheck";
            this.ChangePitchCheck.Size = new System.Drawing.Size(148, 24);
            this.ChangePitchCheck.TabIndex = 22;
            this.ChangePitchCheck.Text = "Change pitch";
            this.ChangePitchCheck.UseVisualStyleBackColor = true;
            // 
            // ScaleODCheck
            // 
            this.ScaleODCheck.Location = new System.Drawing.Point(276, 38);
            this.ScaleODCheck.Name = "ScaleODCheck";
            this.ScaleODCheck.Size = new System.Drawing.Size(148, 25);
            this.ScaleODCheck.TabIndex = 21;
            this.ScaleODCheck.Text = "Scale OD";
            this.ScaleODCheck.UseVisualStyleBackColor = true;
            // 
            // ScaleARCheck
            // 
            this.ScaleARCheck.Location = new System.Drawing.Point(276, 8);
            this.ScaleARCheck.Name = "ScaleARCheck";
            this.ScaleARCheck.Size = new System.Drawing.Size(148, 24);
            this.ScaleARCheck.TabIndex = 20;
            this.ScaleARCheck.Text = "Scale AR";
            this.ScaleARCheck.UseVisualStyleBackColor = true;
            // 
            // NewBpmTextBox
            // 
            this.NewBpmTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(16)))), ((int)(((byte)(25)))));
            this.NewBpmTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NewBpmTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.NewBpmTextBox.Location = new System.Drawing.Point(116, 71);
            this.NewBpmTextBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.NewBpmTextBox.Name = "NewBpmTextBox";
            this.NewBpmTextBox.Size = new System.Drawing.Size(42, 17);
            this.NewBpmTextBox.TabIndex = 10;
            this.NewBpmTextBox.Text = "200";
            this.NewBpmTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NewBpmTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NewBpmTextBox_KeyDown);
            this.NewBpmTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NewBpmTextBox_KeyPress);
            this.NewBpmTextBox.Leave += new System.EventHandler(this.NewBpmTextBox_Leave);
            // 
            // NewBpmRangeTextBox
            // 
            this.NewBpmRangeTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(35)))), ((int)(((byte)(53)))));
            this.NewBpmRangeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NewBpmRangeTextBox.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewBpmRangeTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(134)))));
            this.NewBpmRangeTextBox.Location = new System.Drawing.Point(164, 72);
            this.NewBpmRangeTextBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.NewBpmRangeTextBox.Name = "NewBpmRangeTextBox";
            this.NewBpmRangeTextBox.ReadOnly = true;
            this.NewBpmRangeTextBox.Size = new System.Drawing.Size(85, 17);
            this.NewBpmRangeTextBox.TabIndex = 10;
            this.NewBpmRangeTextBox.Text = "(180 - 210)";
            // 
            // OriginalBpmRangeTextBox
            // 
            this.OriginalBpmRangeTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(35)))), ((int)(((byte)(53)))));
            this.OriginalBpmRangeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OriginalBpmRangeTextBox.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OriginalBpmRangeTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(134)))));
            this.OriginalBpmRangeTextBox.Location = new System.Drawing.Point(164, 48);
            this.OriginalBpmRangeTextBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.OriginalBpmRangeTextBox.Name = "OriginalBpmRangeTextBox";
            this.OriginalBpmRangeTextBox.ReadOnly = true;
            this.OriginalBpmRangeTextBox.Size = new System.Drawing.Size(85, 17);
            this.OriginalBpmRangeTextBox.TabIndex = 10;
            this.OriginalBpmRangeTextBox.Text = "(180 - 210)";
            // 
            // OriginalBpmTextBox
            // 
            this.OriginalBpmTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.OriginalBpmTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OriginalBpmTextBox.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OriginalBpmTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.OriginalBpmTextBox.Location = new System.Drawing.Point(116, 47);
            this.OriginalBpmTextBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.OriginalBpmTextBox.Name = "OriginalBpmTextBox";
            this.OriginalBpmTextBox.ReadOnly = true;
            this.OriginalBpmTextBox.Size = new System.Drawing.Size(42, 17);
            this.OriginalBpmTextBox.TabIndex = 10;
            this.OriginalBpmTextBox.Text = "200";
            this.OriginalBpmTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.OriginalBpmTextBox.Enter += new System.EventHandler(this.Unfocus);
            // 
            // BpmMultiplierUpDown
            // 
            this.BpmMultiplierUpDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(16)))), ((int)(((byte)(25)))));
            this.BpmMultiplierUpDown.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BpmMultiplierUpDown.DecimalPlaces = 2;
            this.BpmMultiplierUpDown.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BpmMultiplierUpDown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BpmMultiplierUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.BpmMultiplierUpDown.Location = new System.Drawing.Point(116, 8);
            this.BpmMultiplierUpDown.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BpmMultiplierUpDown.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.BpmMultiplierUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.BpmMultiplierUpDown.Name = "BpmMultiplierUpDown";
            this.BpmMultiplierUpDown.Size = new System.Drawing.Size(68, 24);
            this.BpmMultiplierUpDown.TabIndex = 4;
            this.BpmMultiplierUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BpmMultiplierUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.BpmMultiplierUpDown.ValueChanged += new System.EventHandler(this.BpmMultiplierUpDown_ValueChanged);
            // 
            // Middle1Panel
            // 
            this.Middle1Panel.Controls.Add(this.tableLayoutPanel1);
            this.Middle1Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Middle1Panel.Location = new System.Drawing.Point(0, 193);
            this.Middle1Panel.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.Middle1Panel.Name = "Middle1Panel";
            this.Middle1Panel.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.Middle1Panel.Size = new System.Drawing.Size(427, 118);
            this.Middle1Panel.TabIndex = 10;
            this.Middle1Panel.Click += new System.EventHandler(this.Unfocus);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.Controls.Add(this.ODLockCheck, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.ARLockCheck, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.CSLockCheck, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.odlabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.ODDisplay, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.ODSlider, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.arlabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.ARDisplay, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.ARSlider, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.cslabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.CSDisplay, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.CSSlider, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.hplabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.HPDisplay, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.HPSlider, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.HPLockCheck, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00063F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00063F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.99813F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(407, 108);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ODLockCheck
            // 
            this.ODLockCheck.CheckedImage = ((System.Drawing.Image)(resources.GetObject("ODLockCheck.CheckedImage")));
            this.ODLockCheck.Location = new System.Drawing.Point(384, 84);
            this.ODLockCheck.Name = "ODLockCheck";
            this.ODLockCheck.Size = new System.Drawing.Size(20, 21);
            this.ODLockCheck.TabIndex = 15;
            this.ODLockCheck.UncheckedImage = ((System.Drawing.Image)(resources.GetObject("ODLockCheck.UncheckedImage")));
            this.ODLockCheck.UseVisualStyleBackColor = true;
            this.ODLockCheck.CheckedChanged += new System.EventHandler(this.OdSlider_ValueChanged);
            // 
            // ARLockCheck
            // 
            this.ARLockCheck.CheckedImage = ((System.Drawing.Image)(resources.GetObject("ARLockCheck.CheckedImage")));
            this.ARLockCheck.Location = new System.Drawing.Point(384, 57);
            this.ARLockCheck.Name = "ARLockCheck";
            this.ARLockCheck.Size = new System.Drawing.Size(20, 21);
            this.ARLockCheck.TabIndex = 14;
            this.ARLockCheck.UncheckedImage = ((System.Drawing.Image)(resources.GetObject("ARLockCheck.UncheckedImage")));
            this.ARLockCheck.UseVisualStyleBackColor = true;
            this.ARLockCheck.CheckedChanged += new System.EventHandler(this.ArSlider_ValueChanged);
            // 
            // CSLockCheck
            // 
            this.CSLockCheck.CheckedImage = ((System.Drawing.Image)(resources.GetObject("CSLockCheck.CheckedImage")));
            this.CSLockCheck.Location = new System.Drawing.Point(384, 30);
            this.CSLockCheck.Name = "CSLockCheck";
            this.CSLockCheck.Size = new System.Drawing.Size(20, 21);
            this.CSLockCheck.TabIndex = 13;
            this.CSLockCheck.UncheckedImage = ((System.Drawing.Image)(resources.GetObject("CSLockCheck.UncheckedImage")));
            this.CSLockCheck.UseVisualStyleBackColor = true;
            this.CSLockCheck.CheckedChanged += new System.EventHandler(this.CsLockCheck_CheckedChanged);
            // 
            // odlabel
            // 
            this.odlabel.AutoSize = true;
            this.odlabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.odlabel.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Bold);
            this.odlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(126)))), ((int)(((byte)(114)))));
            this.odlabel.Location = new System.Drawing.Point(3, 84);
            this.odlabel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.odlabel.Name = "odlabel";
            this.odlabel.Size = new System.Drawing.Size(32, 24);
            this.odlabel.TabIndex = 9;
            this.odlabel.Text = "OD";
            this.odlabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ODDisplay
            // 
            this.ODDisplay.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ODDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.ODDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ODDisplay.Enabled = false;
            this.ODDisplay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ODDisplay.Location = new System.Drawing.Point(41, 86);
            this.ODDisplay.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.ODDisplay.Name = "ODDisplay";
            this.ODDisplay.ReadOnly = true;
            this.ODDisplay.Size = new System.Drawing.Size(42, 21);
            this.ODDisplay.TabIndex = 10;
            this.ODDisplay.Text = "0.0";
            this.ODDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ODDisplay.Enter += new System.EventHandler(this.Unfocus);
            // 
            // ODSlider
            // 
            this.ODSlider.BodyColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(27)))), ((int)(((byte)(47)))));
            this.ODSlider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ODSlider.FillDraggingNipple = false;
            this.ODSlider.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ODSlider.Location = new System.Drawing.Point(89, 84);
            this.ODSlider.MaxValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ODSlider.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ODSlider.Name = "ODSlider";
            this.ODSlider.NippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ODSlider.NippleDiameter = 15;
            this.ODSlider.NippleExpandedDiameter = 18;
            this.ODSlider.NippleIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(134)))));
            this.ODSlider.NippleStrokeWidth = 2;
            this.ODSlider.Size = new System.Drawing.Size(289, 21);
            this.ODSlider.TabIndex = 11;
            this.ODSlider.Text = "HPSlider";
            this.ODSlider.Thickness = 4;
            this.ODSlider.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ODSlider.ValueChanged += new System.EventHandler(this.OdSlider_ValueChanged);
            // 
            // arlabel
            // 
            this.arlabel.AutoSize = true;
            this.arlabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.arlabel.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Bold);
            this.arlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(126)))), ((int)(((byte)(114)))));
            this.arlabel.Location = new System.Drawing.Point(3, 57);
            this.arlabel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.arlabel.Name = "arlabel";
            this.arlabel.Size = new System.Drawing.Size(32, 24);
            this.arlabel.TabIndex = 6;
            this.arlabel.Text = "AR";
            this.arlabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ARDisplay
            // 
            this.ARDisplay.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ARDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.ARDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ARDisplay.Enabled = false;
            this.ARDisplay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ARDisplay.Location = new System.Drawing.Point(41, 59);
            this.ARDisplay.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.ARDisplay.Name = "ARDisplay";
            this.ARDisplay.ReadOnly = true;
            this.ARDisplay.Size = new System.Drawing.Size(42, 21);
            this.ARDisplay.TabIndex = 7;
            this.ARDisplay.Text = "0.0";
            this.ARDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ARDisplay.Enter += new System.EventHandler(this.Unfocus);
            // 
            // ARSlider
            // 
            this.ARSlider.BodyColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(27)))), ((int)(((byte)(47)))));
            this.ARSlider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ARSlider.FillDraggingNipple = false;
            this.ARSlider.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ARSlider.Location = new System.Drawing.Point(89, 57);
            this.ARSlider.MaxValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ARSlider.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ARSlider.Name = "ARSlider";
            this.ARSlider.NippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ARSlider.NippleDiameter = 15;
            this.ARSlider.NippleExpandedDiameter = 18;
            this.ARSlider.NippleIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(134)))));
            this.ARSlider.NippleStrokeWidth = 2;
            this.ARSlider.Size = new System.Drawing.Size(289, 21);
            this.ARSlider.TabIndex = 8;
            this.ARSlider.Text = "HPSlider";
            this.ARSlider.Thickness = 4;
            this.ARSlider.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ARSlider.ValueChanged += new System.EventHandler(this.ArSlider_ValueChanged);
            // 
            // cslabel
            // 
            this.cslabel.AutoSize = true;
            this.cslabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cslabel.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Bold);
            this.cslabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(126)))), ((int)(((byte)(114)))));
            this.cslabel.Location = new System.Drawing.Point(3, 30);
            this.cslabel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.cslabel.Name = "cslabel";
            this.cslabel.Size = new System.Drawing.Size(32, 24);
            this.cslabel.TabIndex = 3;
            this.cslabel.Text = "CS";
            this.cslabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CSDisplay
            // 
            this.CSDisplay.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CSDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.CSDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CSDisplay.Enabled = false;
            this.CSDisplay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CSDisplay.Location = new System.Drawing.Point(41, 32);
            this.CSDisplay.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.CSDisplay.Name = "CSDisplay";
            this.CSDisplay.ReadOnly = true;
            this.CSDisplay.Size = new System.Drawing.Size(42, 21);
            this.CSDisplay.TabIndex = 4;
            this.CSDisplay.Text = "0.0";
            this.CSDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CSDisplay.Enter += new System.EventHandler(this.Unfocus);
            // 
            // CSSlider
            // 
            this.CSSlider.BodyColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(27)))), ((int)(((byte)(47)))));
            this.CSSlider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CSSlider.FillDraggingNipple = false;
            this.CSSlider.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.CSSlider.Location = new System.Drawing.Point(89, 30);
            this.CSSlider.MaxValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.CSSlider.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.CSSlider.Name = "CSSlider";
            this.CSSlider.NippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.CSSlider.NippleDiameter = 15;
            this.CSSlider.NippleExpandedDiameter = 18;
            this.CSSlider.NippleIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(134)))));
            this.CSSlider.NippleStrokeWidth = 2;
            this.CSSlider.Size = new System.Drawing.Size(289, 21);
            this.CSSlider.TabIndex = 5;
            this.CSSlider.Text = "HPSlider";
            this.CSSlider.Thickness = 4;
            this.CSSlider.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.CSSlider.ValueChanged += new System.EventHandler(this.CsSlider_ValueChanged);
            // 
            // hplabel
            // 
            this.hplabel.AutoSize = true;
            this.hplabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hplabel.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Bold);
            this.hplabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(126)))), ((int)(((byte)(114)))));
            this.hplabel.Location = new System.Drawing.Point(3, 3);
            this.hplabel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.hplabel.Name = "hplabel";
            this.hplabel.Size = new System.Drawing.Size(32, 24);
            this.hplabel.TabIndex = 0;
            this.hplabel.Text = "HP";
            this.hplabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // HPDisplay
            // 
            this.HPDisplay.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.HPDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.HPDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HPDisplay.Enabled = false;
            this.HPDisplay.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HPDisplay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.HPDisplay.Location = new System.Drawing.Point(41, 5);
            this.HPDisplay.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.HPDisplay.Name = "HPDisplay";
            this.HPDisplay.ReadOnly = true;
            this.HPDisplay.Size = new System.Drawing.Size(42, 21);
            this.HPDisplay.TabIndex = 1;
            this.HPDisplay.Text = "0.0";
            this.HPDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.HPDisplay.Enter += new System.EventHandler(this.Unfocus);
            // 
            // HPSlider
            // 
            this.HPSlider.BodyColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(27)))), ((int)(((byte)(47)))));
            this.HPSlider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HPSlider.FillDraggingNipple = false;
            this.HPSlider.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.HPSlider.Location = new System.Drawing.Point(89, 3);
            this.HPSlider.MaxValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.HPSlider.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.HPSlider.Name = "HPSlider";
            this.HPSlider.NippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.HPSlider.NippleDiameter = 15;
            this.HPSlider.NippleExpandedDiameter = 18;
            this.HPSlider.NippleIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(134)))));
            this.HPSlider.NippleStrokeWidth = 2;
            this.HPSlider.Size = new System.Drawing.Size(289, 21);
            this.HPSlider.TabIndex = 2;
            this.HPSlider.Text = "HPSlider";
            this.HPSlider.Thickness = 4;
            this.HPSlider.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.HPSlider.ValueChanged += new System.EventHandler(this.HpSlider_ValueChanged);
            // 
            // HPLockCheck
            // 
            this.HPLockCheck.CheckedImage = global::osu_trainer.Properties.Resources.lock_solid;
            this.HPLockCheck.Location = new System.Drawing.Point(384, 3);
            this.HPLockCheck.Name = "HPLockCheck";
            this.HPLockCheck.Size = new System.Drawing.Size(20, 21);
            this.HPLockCheck.TabIndex = 12;
            this.HPLockCheck.UncheckedImage = global::osu_trainer.Properties.Resources.unlock_solid;
            this.HPLockCheck.UseVisualStyleBackColor = true;
            this.HPLockCheck.CheckedChanged += new System.EventHandler(this.HpLockCheck_CheckedChanged);
            // 
            // BottomPanel
            // 
            this.BottomPanel.Controls.Add(this.DeleteButton);
            this.BottomPanel.Controls.Add(this.ResetButton);
            this.BottomPanel.Controls.Add(this.GenerateMapButton);
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Location = new System.Drawing.Point(0, 411);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Padding = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.BottomPanel.Size = new System.Drawing.Size(427, 62);
            this.BottomPanel.TabIndex = 11;
            this.BottomPanel.Click += new System.EventHandler(this.Unfocus);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BrightnessRange = 0.01F;
            this.DeleteButton.Color = System.Drawing.Color.CornflowerBlue;
            this.DeleteButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.ForeColor = System.Drawing.Color.DarkGray;
            this.DeleteButton.Image = global::osu_trainer.Properties.Resources.trash_alt_solid;
            this.DeleteButton.Location = new System.Drawing.Point(328, 8);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Progress = 0F;
            this.DeleteButton.ProgressColor = System.Drawing.Color.Transparent;
            this.DeleteButton.Size = new System.Drawing.Size(40, 40);
            this.DeleteButton.TabIndex = 1;
            this.DeleteButton.TriangleCount = 30;
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.BrightnessRange = 0.01F;
            this.ResetButton.Color = System.Drawing.Color.CornflowerBlue;
            this.ResetButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.ResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetButton.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton.ForeColor = System.Drawing.Color.DarkGray;
            this.ResetButton.Image = global::osu_trainer.Properties.Resources.reset;
            this.ResetButton.Location = new System.Drawing.Point(374, 8);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Progress = 0F;
            this.ResetButton.ProgressColor = System.Drawing.Color.Transparent;
            this.ResetButton.Size = new System.Drawing.Size(40, 40);
            this.ResetButton.TabIndex = 1;
            this.ResetButton.TriangleCount = 30;
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // GenerateMapButton
            // 
            this.GenerateMapButton.BackColor = System.Drawing.Color.Transparent;
            this.GenerateMapButton.BrightnessRange = 0.01F;
            this.GenerateMapButton.Color = System.Drawing.Color.CornflowerBlue;
            this.GenerateMapButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GenerateMapButton.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Bold);
            this.GenerateMapButton.ForeColor = System.Drawing.Color.White;
            this.GenerateMapButton.Location = new System.Drawing.Point(10, 8);
            this.GenerateMapButton.Margin = new System.Windows.Forms.Padding(30, 3, 30, 3);
            this.GenerateMapButton.Name = "GenerateMapButton";
            this.GenerateMapButton.Progress = 0F;
            this.GenerateMapButton.ProgressColor = System.Drawing.Color.SpringGreen;
            this.GenerateMapButton.Size = new System.Drawing.Size(314, 40);
            this.GenerateMapButton.TabIndex = 0;
            this.GenerateMapButton.Text = "Create Map";
            this.GenerateMapButton.TriangleCount = 30;
            this.GenerateMapButton.UseVisualStyleBackColor = false;
            this.GenerateMapButton.Click += new System.EventHandler(this.GenerateMapButton_Click);
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(27)))), ((int)(((byte)(47)))));
            this.TopPanel.Controls.Add(this.SongDisplay);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 30);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Padding = new System.Windows.Forms.Padding(10);
            this.TopPanel.Size = new System.Drawing.Size(427, 121);
            this.TopPanel.TabIndex = 12;
            // 
            // SongDisplay
            // 
            this.SongDisplay.Artist = null;
            this.SongDisplay.Cover = null;
            this.SongDisplay.Difficulty = null;
            this.SongDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SongDisplay.ErrorMessage = null;
            this.SongDisplay.Location = new System.Drawing.Point(10, 10);
            this.SongDisplay.Name = "SongDisplay";
            this.SongDisplay.Size = new System.Drawing.Size(407, 101);
            this.SongDisplay.TabIndex = 7;
            this.SongDisplay.Text = "songDisplay1";
            this.SongDisplay.Title = null;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(27)))), ((int)(((byte)(47)))));
            this.closeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(27)))), ((int)(((byte)(47)))));
            this.closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(10)))), ((int)(((byte)(20)))));
            this.closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Segoe UI Semilight", 9F);
            this.closeButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.closeButton.Location = new System.Drawing.Point(382, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(45, 30);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "✕";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // OsuRunningTimer
            // 
            this.OsuRunningTimer.Interval = 500;
            this.OsuRunningTimer.Tick += new System.EventHandler(this.OsuRunningTimer_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.AimSpeedBar);
            this.panel1.Controls.Add(this.StarsDisplay);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 151);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.panel1.Size = new System.Drawing.Size(427, 42);
            this.panel1.TabIndex = 13;
            // 
            // AimSpeedBar
            // 
            this.AimSpeedBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.AimSpeedBar.LeftColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(133)))), ((int)(((byte)(201)))));
            this.AimSpeedBar.LeftPercent = 40;
            this.AimSpeedBar.LeftText = "aim";
            this.AimSpeedBar.Location = new System.Drawing.Point(10, 5);
            this.AimSpeedBar.Name = "AimSpeedBar";
            this.AimSpeedBar.RightColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(241)))), ((int)(((byte)(184)))));
            this.AimSpeedBar.RightText = "speed";
            this.AimSpeedBar.Size = new System.Drawing.Size(323, 27);
            this.AimSpeedBar.TabIndex = 21;
            // 
            // StarsDisplay
            // 
            this.StarsDisplay.Dock = System.Windows.Forms.DockStyle.Right;
            this.StarsDisplay.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StarsDisplay.GameMode = FsBeatmapProcessor.GameMode.osu;
            this.StarsDisplay.Location = new System.Drawing.Point(333, 5);
            this.StarsDisplay.Name = "StarsDisplay";
            this.StarsDisplay.Size = new System.Drawing.Size(84, 32);
            this.StarsDisplay.Stars = 0F;
            this.StarsDisplay.TabIndex = 22;
            this.StarsDisplay.Text = "starsDisplay1";
            // 
            // BackgroundWorker
            // 
            this.BackgroundWorker.WorkerReportsProgress = true;
            this.BackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker_DoWork);
            this.BackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackgroundWorker_ProgressChanged);
            this.BackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorker_RunWorkerCompleted);
            // 
            // titlePanel
            // 
            this.titlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(27)))), ((int)(((byte)(47)))));
            this.titlePanel.Controls.Add(this.minimizeButton);
            this.titlePanel.Controls.Add(this.closeButton);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.Location = new System.Drawing.Point(0, 0);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(427, 30);
            this.titlePanel.TabIndex = 14;
            this.titlePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.titlePanel_Paint);
            this.titlePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelMove_MouseDown);
            this.titlePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelMove_MouseMove);
            this.titlePanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PanelMove_MouseUp);
            // 
            // minimizeButton
            // 
            this.minimizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(27)))), ((int)(((byte)(47)))));
            this.minimizeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.minimizeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(27)))), ((int)(((byte)(47)))));
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.Font = new System.Drawing.Font("Segoe UI Semilight", 9F);
            this.minimizeButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.minimizeButton.Location = new System.Drawing.Point(337, 0);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(45, 30);
            this.minimizeButton.TabIndex = 3;
            this.minimizeButton.Text = "🗕";
            this.minimizeButton.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(35)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(427, 473);
            this.Controls.Add(this.Panel3);
            this.Controls.Add(this.Middle1Panel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BottomPanel);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.titlePanel);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "osu trainer";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.Panel3.ResumeLayout(false);
            this.Panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BpmMultiplierUpDown)).EndInit();
            this.Middle1Panel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.BottomPanel.ResumeLayout(false);
            this.TopPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.titlePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private AntiAliasedLabel BpmMultiplierLabel;
        private NumericUpDownFix BpmMultiplierUpDown;
        private System.Windows.Forms.Timer BeatmapUpdateTimer;
        private AntiAliasedLabel OriginalBpmLabel;
        private AntiAliasedLabel NewBpmLabel;
        private OsuButton GenerateMapButton;
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel Panel3;
        private System.Windows.Forms.Panel Middle1Panel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private AntiAliasedLabel hplabel;
        private System.Windows.Forms.TextBox HPDisplay;
        private OptionSlider HPSlider;
        private AntiAliasedLabel odlabel;
        private System.Windows.Forms.TextBox ODDisplay;
        private OptionSlider ODSlider;
        private AntiAliasedLabel arlabel;
        private System.Windows.Forms.TextBox ARDisplay;
        private OptionSlider ARSlider;
        private AntiAliasedLabel cslabel;
        private System.Windows.Forms.TextBox CSDisplay;
        private OptionSlider CSSlider;
        private System.Windows.Forms.TextBox NewBpmTextBox;
        private System.Windows.Forms.TextBox NewBpmRangeTextBox;
        private System.Windows.Forms.TextBox OriginalBpmRangeTextBox;
        private System.Windows.Forms.TextBox OriginalBpmTextBox;
        private OsuButton ResetButton;
        private System.Windows.Forms.Timer OsuRunningTimer;
        private OsuButton DeleteButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Panel panel1;
        private StarsDisplay StarsDisplay;
        private ExtendedRatioBar AimSpeedBar;
        private OsuCheckBox ScaleARCheck;
        private OsuCheckBox ChangePitchCheck;
        private OsuCheckBox ScaleODCheck;
        private ToggleIconButton ODLockCheck;
        private ToggleIconButton ARLockCheck;
        private ToggleIconButton CSLockCheck;
        private ToggleIconButton HPLockCheck;
        public System.ComponentModel.BackgroundWorker BackgroundWorker;
        private SongDisplay SongDisplay;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Button minimizeButton;
    }
}