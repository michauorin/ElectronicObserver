﻿using System.Windows.Forms;

namespace ElectronicObserver.Window.Dialog
{
	partial class DialogConfigurationNotifier
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
			this.ButtonCancel = new System.Windows.Forms.Button();
			this.ButtonOK = new System.Windows.Forms.Button();
			this.GroupSound = new System.Windows.Forms.GroupBox();
			this.SoundPathDirectorize = new System.Windows.Forms.Button();
			this.LoopsSound = new System.Windows.Forms.CheckBox();
			this.label9 = new System.Windows.Forms.Label();
			this.SoundVolume = new System.Windows.Forms.NumericUpDown();
			this.PlaysSound = new System.Windows.Forms.CheckBox();
			this.SoundPathSearch = new System.Windows.Forms.Button();
			this.SoundPath = new System.Windows.Forms.TextBox();
			this.ButtonTest = new System.Windows.Forms.Button();
			this.IsEnabled = new System.Windows.Forms.CheckBox();
			this.GroupImage = new System.Windows.Forms.GroupBox();
			this.DrawsImage = new System.Windows.Forms.CheckBox();
			this.ImagePathSearch = new System.Windows.Forms.Button();
			this.ImagePath = new System.Windows.Forms.TextBox();
			this.GroupDialog = new System.Windows.Forms.GroupBox();
			this.label5 = new System.Windows.Forms.Label();
			this.CloseList = new System.Windows.Forms.CheckedListBox();
			this.ShowWithActivation = new System.Windows.Forms.CheckBox();
			this.label4 = new System.Windows.Forms.Label();
			this.DrawsMessage = new System.Windows.Forms.CheckBox();
			this.HasFormBorder = new System.Windows.Forms.CheckBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.ClosingInterval = new System.Windows.Forms.NumericUpDown();
			this.BackColorPreview = new System.Windows.Forms.Label();
			this.BackColorSelect = new System.Windows.Forms.Button();
			this.ForeColorPreview = new System.Windows.Forms.Label();
			this.ForeColorSelect = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.AccelInterval = new System.Windows.Forms.NumericUpDown();
			this.TopMostFlag = new System.Windows.Forms.CheckBox();
			this.LocationY = new System.Windows.Forms.NumericUpDown();
			this.LocationX = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.Alignment = new System.Windows.Forms.ComboBox();
			this.ShowsDialog = new System.Windows.Forms.CheckBox();
			this.GroupDamage = new System.Windows.Forms.GroupBox();
			this.NotifiesAtEndpoint = new System.Windows.Forms.CheckBox();
			this.ContainsFlagship = new System.Windows.Forms.CheckBox();
			this.ContainsSafeShip = new System.Windows.Forms.CheckBox();
			this.ContainsNotLockedShip = new System.Windows.Forms.CheckBox();
			this.label8 = new System.Windows.Forms.Label();
			this.LevelBorder = new System.Windows.Forms.NumericUpDown();
			this.NotifiesAfter = new System.Windows.Forms.CheckBox();
			this.NotifiesNow = new System.Windows.Forms.CheckBox();
			this.NotifiesBefore = new System.Windows.Forms.CheckBox();
			this.DialogColor = new System.Windows.Forms.ColorDialog();
			this.DialogOpenSound = new System.Windows.Forms.OpenFileDialog();
			this.DialogOpenImage = new System.Windows.Forms.OpenFileDialog();
			this.ToolTipText = new System.Windows.Forms.ToolTip(this.components);
			this.label10 = new System.Windows.Forms.Label();
			this.GroupAnchorageRepair = new System.Windows.Forms.GroupBox();
			this.label11 = new System.Windows.Forms.Label();
			this.AnchorageRepairNotificationLevel = new System.Windows.Forms.ComboBox();
			this.GroupBaseAirCorps = new System.Windows.Forms.GroupBox();
			this.BaseAirCorps_NotSupplied = new System.Windows.Forms.CheckBox();
			this.BaseAirCorps_Tired = new System.Windows.Forms.CheckBox();
			this.BaseAirCorps_NotOrganized = new System.Windows.Forms.CheckBox();
			this.BaseAirCorps_Rest = new System.Windows.Forms.CheckBox();
			this.BaseAirCorps_Retreat = new System.Windows.Forms.CheckBox();
			this.BaseAirCorps_Standby = new System.Windows.Forms.CheckBox();
			this.BaseAirCorps_NormalMap = new System.Windows.Forms.CheckBox();
			this.BaseAirCorps_EventMap = new System.Windows.Forms.CheckBox();
			this.BaseAirCorps_EquipmentRelocation = new System.Windows.Forms.CheckBox();
			this.BaseAirCorps_SquadronRelocation = new System.Windows.Forms.CheckBox();
			this.GroupBattleEnd = new System.Windows.Forms.GroupBox();
			this.BattleEnd_IdleTimerEnabled = new System.Windows.Forms.CheckBox();
			this.BattleEnd_IdleTime = new NumericUpDown();
			this.GroupSound.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.SoundVolume)).BeginInit();
			this.GroupImage.SuspendLayout();
			this.GroupDialog.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ClosingInterval)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.AccelInterval)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.LocationY)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.LocationX)).BeginInit();
			this.GroupDamage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.LevelBorder)).BeginInit();
			this.GroupAnchorageRepair.SuspendLayout();
			this.GroupBaseAirCorps.SuspendLayout();
			this.SuspendLayout();
			//
			// ButtonCancel
			//
			this.ButtonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.ButtonCancel.Location = new System.Drawing.Point(537, 407);
			this.ButtonCancel.Name = "ButtonCancel";
			this.ButtonCancel.Size = new System.Drawing.Size(75, 23);
			this.ButtonCancel.TabIndex = 7;
			this.ButtonCancel.Text = ConfigRes.Cancel;
			this.ButtonCancel.UseVisualStyleBackColor = true;
			this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
			//
			// ButtonOK
			//
			this.ButtonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.ButtonOK.Location = new System.Drawing.Point(456, 407);
			this.ButtonOK.Name = "ButtonOK";
			this.ButtonOK.Size = new System.Drawing.Size(75, 23);
			this.ButtonOK.TabIndex = 6;
			this.ButtonOK.Text = "OK";
			this.ButtonOK.UseVisualStyleBackColor = true;
			this.ButtonOK.Click += new System.EventHandler(this.ButtonOK_Click);
			//
			// GroupSound
			//
			this.GroupSound.Controls.Add(this.SoundPathDirectorize);
			this.GroupSound.Controls.Add(this.LoopsSound);
			this.GroupSound.Controls.Add(this.label9);
			this.GroupSound.Controls.Add(this.SoundVolume);
			this.GroupSound.Controls.Add(this.PlaysSound);
			this.GroupSound.Controls.Add(this.SoundPathSearch);
			this.GroupSound.Controls.Add(this.SoundPath);
			this.GroupSound.Location = new System.Drawing.Point(12, 37);
			this.GroupSound.Name = "GroupSound";
			this.GroupSound.Size = new System.Drawing.Size(298, 78);
			this.GroupSound.TabIndex = 1;
			this.GroupSound.TabStop = false;
			this.GroupSound.Text = NotifyRes.Sound;
			this.GroupSound.DragDrop += new System.Windows.Forms.DragEventHandler(this.GroupSound_DragDrop);
			this.GroupSound.DragEnter += new System.Windows.Forms.DragEventHandler(this.GroupSound_DragEnter);
			//
			// SoundPathDirectorize
			//
			this.SoundPathDirectorize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.SoundPathDirectorize.Location = new System.Drawing.Point(260, 47);
			this.SoundPathDirectorize.Name = "SoundPathDirectorize";
			this.SoundPathDirectorize.Size = new System.Drawing.Size(32, 23);
			this.SoundPathDirectorize.TabIndex = 6;
			this.SoundPathDirectorize.Text = "Dir";
			this.ToolTipText.SetToolTip(this.SoundPathDirectorize, "Delete the filename part in the previous file path column.\r\nSpecifying a folder as the file path will enable the program to\r\nrandomly play an audio file from the folder as notification sound.");
			this.SoundPathDirectorize.UseVisualStyleBackColor = true;
			this.SoundPathDirectorize.Click += new System.EventHandler(this.SoundPathDirectorize_Click);
			//
			// LoopsSound
			//
			this.LoopsSound.AutoSize = true;
			this.LoopsSound.Location = new System.Drawing.Point(90, 22);
			this.LoopsSound.Name = "LoopsSound";
			this.LoopsSound.Size = new System.Drawing.Size(55, 19);
			this.LoopsSound.TabIndex = 5;
			this.LoopsSound.Text = ConfigRes.Loop;
			this.LoopsSound.UseVisualStyleBackColor = true;
			//
			// label9
			//
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(163, 23);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(43, 15);
			this.label9.TabIndex = 1;
			this.label9.Text = ConfigRes.Volume;
			//
			// SoundVolume
			//
			this.SoundVolume.Location = new System.Drawing.Point(212, 18);
			this.SoundVolume.Name = "SoundVolume";
			this.SoundVolume.Size = new System.Drawing.Size(80, 23);
			this.SoundVolume.TabIndex = 2;
			this.SoundVolume.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.ToolTipText.SetToolTip(this.SoundVolume, "Specify volume of the notication sound (0-100).");
			//
			// PlaysSound
			//
			this.PlaysSound.AutoSize = true;
			this.PlaysSound.Location = new System.Drawing.Point(6, 22);
			this.PlaysSound.Name = "PlaysSound";
			this.PlaysSound.Size = new System.Drawing.Size(78, 19);
			this.PlaysSound.TabIndex = 0;
			this.PlaysSound.Text = NotifyRes.Enable;
			this.PlaysSound.UseVisualStyleBackColor = true;
			//
			// SoundPathSearch
			//
			this.SoundPathSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.SoundPathSearch.Location = new System.Drawing.Point(222, 47);
			this.SoundPathSearch.Name = "SoundPathSearch";
			this.SoundPathSearch.Size = new System.Drawing.Size(32, 23);
			this.SoundPathSearch.TabIndex = 4;
			this.SoundPathSearch.Text = "...";
			this.SoundPathSearch.UseVisualStyleBackColor = true;
			this.SoundPathSearch.Click += new System.EventHandler(this.SoundPathSearch_Click);
			//
			// SoundPath
			//
			this.SoundPath.AllowDrop = true;
			this.SoundPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.SoundPath.Location = new System.Drawing.Point(6, 47);
			this.SoundPath.Name = "SoundPath";
			this.SoundPath.Size = new System.Drawing.Size(210, 23);
			this.SoundPath.TabIndex = 3;
			this.SoundPath.TextChanged += new System.EventHandler(this.SoundPath_TextChanged);
			//
			// ButtonTest
			//
			this.ButtonTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.ButtonTest.Location = new System.Drawing.Point(12, 407);
			this.ButtonTest.Name = "ButtonTest";
			this.ButtonTest.Size = new System.Drawing.Size(75, 23);
			this.ButtonTest.TabIndex = 5;
			this.ButtonTest.Text = NotifyRes.Test;
			this.ToolTipText.SetToolTip(this.ButtonTest, NotifyRes.TestHint);
			this.ButtonTest.UseVisualStyleBackColor = true;
			this.ButtonTest.Click += new System.EventHandler(this.ButtonTest_Click);
			//
			// IsEnabled
			//
			this.IsEnabled.AutoSize = true;
			this.IsEnabled.Location = new System.Drawing.Point(12, 12);
			this.IsEnabled.Name = "IsEnabled";
			this.IsEnabled.Size = new System.Drawing.Size(111, 19);
			this.IsEnabled.TabIndex = 0;
			this.IsEnabled.Text = NotifyRes.EnableNotify;
			this.IsEnabled.UseVisualStyleBackColor = true;
			//
			// GroupImage
			//
			this.GroupImage.Controls.Add(this.DrawsImage);
			this.GroupImage.Controls.Add(this.ImagePathSearch);
			this.GroupImage.Controls.Add(this.ImagePath);
			this.GroupImage.Location = new System.Drawing.Point(316, 37);
			this.GroupImage.Name = "GroupImage";
			this.GroupImage.Size = new System.Drawing.Size(298, 78);
			this.GroupImage.TabIndex = 2;
			this.GroupImage.TabStop = false;
			this.GroupImage.Text = NotifyRes.Image;
			this.GroupImage.DragDrop += new System.Windows.Forms.DragEventHandler(this.GroupImage_DragDrop);
			this.GroupImage.DragEnter += new System.Windows.Forms.DragEventHandler(this.GroupImage_DragEnter);
			//
			// DrawsImage
			//
			this.DrawsImage.AutoSize = true;
			this.DrawsImage.Location = new System.Drawing.Point(6, 22);
			this.DrawsImage.Name = "DrawsImage";
			this.DrawsImage.Size = new System.Drawing.Size(78, 19);
			this.DrawsImage.TabIndex = 0;
			this.DrawsImage.Text = NotifyRes.Enable;
			this.DrawsImage.UseVisualStyleBackColor = true;
			//
			// ImagePathSearch
			//
			this.ImagePathSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ImagePathSearch.Location = new System.Drawing.Point(260, 47);
			this.ImagePathSearch.Name = "ImagePathSearch";
			this.ImagePathSearch.Size = new System.Drawing.Size(32, 23);
			this.ImagePathSearch.TabIndex = 2;
			this.ImagePathSearch.Text = "...";
			this.ImagePathSearch.UseVisualStyleBackColor = true;
			this.ImagePathSearch.Click += new System.EventHandler(this.ImagePathSearch_Click);
			//
			// ImagePath
			//
			this.ImagePath.AllowDrop = true;
			this.ImagePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.ImagePath.Location = new System.Drawing.Point(6, 47);
			this.ImagePath.Name = "ImagePath";
			this.ImagePath.Size = new System.Drawing.Size(248, 23);
			this.ImagePath.TabIndex = 1;
			this.ImagePath.TextChanged += new System.EventHandler(this.ImagePath_TextChanged);
			//
			// GroupDialog
			//
			this.GroupDialog.Controls.Add(this.label5);
			this.GroupDialog.Controls.Add(this.CloseList);
			this.GroupDialog.Controls.Add(this.ShowWithActivation);
			this.GroupDialog.Controls.Add(this.label4);
			this.GroupDialog.Controls.Add(this.DrawsMessage);
			this.GroupDialog.Controls.Add(this.HasFormBorder);
			this.GroupDialog.Controls.Add(this.label6);
			this.GroupDialog.Controls.Add(this.label7);
			this.GroupDialog.Controls.Add(this.ClosingInterval);
			this.GroupDialog.Controls.Add(this.BackColorPreview);
			this.GroupDialog.Controls.Add(this.BackColorSelect);
			this.GroupDialog.Controls.Add(this.ForeColorPreview);
			this.GroupDialog.Controls.Add(this.ForeColorSelect);
			this.GroupDialog.Controls.Add(this.label3);
			this.GroupDialog.Controls.Add(this.label2);
			this.GroupDialog.Controls.Add(this.AccelInterval);
			this.GroupDialog.Controls.Add(this.TopMostFlag);
			this.GroupDialog.Controls.Add(this.LocationY);
			this.GroupDialog.Controls.Add(this.LocationX);
			this.GroupDialog.Controls.Add(this.label1);
			this.GroupDialog.Controls.Add(this.Alignment);
			this.GroupDialog.Controls.Add(this.ShowsDialog);
			this.GroupDialog.Location = new System.Drawing.Point(12, 121);
			this.GroupDialog.Name = "GroupDialog";
			this.GroupDialog.Size = new System.Drawing.Size(602, 171);
			this.GroupDialog.TabIndex = 3;
			this.GroupDialog.TabStop = false;
			this.GroupDialog.Text = NotifyRes.NotifyDialog;
			//
			// label5
			//
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(473, 18);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(49, 15);
			this.label5.TabIndex = 20;
			this.label5.Text = NotifyRes.CloseOn + "：";
			//
			// CloseList
			//
			this.CloseList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.CloseList.CheckOnClick = true;
			this.CloseList.FormattingEnabled = true;
			this.CloseList.Items.AddRange(new object[] {
            NotifyRes.LeftClick,
            NotifyRes.LeftDoubleClick,
            NotifyRes.RightClick,
            NotifyRes.RightDoubleClick,
            NotifyRes.MiddleClick,
            NotifyRes.MiddleDoubleClick,
            NotifyRes.MouseOver});
			this.CloseList.Location = new System.Drawing.Point(476, 35);
			this.CloseList.Name = "CloseList";
			this.CloseList.Size = new System.Drawing.Size(120, 130);
			this.CloseList.TabIndex = 21;
			//
			// ShowWithActivation
			//
			this.ShowWithActivation.AutoSize = true;
			this.ShowWithActivation.Location = new System.Drawing.Point(6, 137);
			this.ShowWithActivation.Name = "ShowWithActivation";
			this.ShowWithActivation.Size = new System.Drawing.Size(151, 19);
			this.ShowWithActivation.TabIndex = 8;
			this.ShowWithActivation.Text = NotifyRes.ShowWithActivation;
			this.ToolTipText.SetToolTip(this.ShowWithActivation, "Activate the notification dialog when the dialog is being shown.\r\nEnabling this option will prevent accidental user interaction\r\n(e.g: advancing in critical damage).");
			this.ShowWithActivation.UseVisualStyleBackColor = true;
			//
			// label4
			//
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 78);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(43, 15);
			this.label4.TabIndex = 3;
			this.label4.Text = NotifyRes.Location + ":";
			//
			// DrawsMessage
			//
			this.DrawsMessage.AutoSize = true;
			this.DrawsMessage.Location = new System.Drawing.Point(6, 108);
			this.DrawsMessage.Name = "DrawsMessage";
			this.DrawsMessage.Size = new System.Drawing.Size(123, 19);
			this.DrawsMessage.TabIndex = 6;
			this.DrawsMessage.Text = NotifyRes.DisplayMessage;
			this.ToolTipText.SetToolTip(this.DrawsMessage, NotifyRes.DisplayMessageHint);
			this.DrawsMessage.UseVisualStyleBackColor = true;
			//
			// HasFormBorder
			//
			this.HasFormBorder.AutoSize = true;
			this.HasFormBorder.Location = new System.Drawing.Point(135, 108);
			this.HasFormBorder.Name = "HasFormBorder";
			this.HasFormBorder.Size = new System.Drawing.Size(102, 19);
			this.HasFormBorder.TabIndex = 7;
			this.HasFormBorder.Text = NotifyRes.DisplayWindowBorder;
			this.ToolTipText.SetToolTip(this.HasFormBorder, NotifyRes.WindowBorderHint);
			this.HasFormBorder.UseVisualStyleBackColor = true;
			//
			// label6
			//
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(444, 52);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(19, 15);
			this.label6.TabIndex = 14;
			this.label6.Text = NotifyRes.Sec;
			//
			// label7
			//
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(269, 52);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(83, 15);
			this.label7.TabIndex = 12;
			this.label7.Text = NotifyRes.AutoClose + ":";
			//
			// ClosingInterval
			//
			this.ClosingInterval.Location = new System.Drawing.Point(358, 47);
			this.ClosingInterval.Maximum = new decimal(new int[] {
			999,
			0,
			0,
			0});
			this.ClosingInterval.Name = "ClosingInterval";
			this.ClosingInterval.Size = new System.Drawing.Size(80, 23);
			this.ClosingInterval.TabIndex = 13;
			this.ClosingInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.ToolTipText.SetToolTip(this.ClosingInterval, NotifyRes.IntervalHint);
			//
			// BackColorPreview
			//
			this.BackColorPreview.AutoSize = true;
			this.BackColorPreview.Location = new System.Drawing.Point(269, 138);
			this.BackColorPreview.Name = "BackColorPreview";
			this.BackColorPreview.Size = new System.Drawing.Size(67, 15);
			this.BackColorPreview.TabIndex = 18;
			this.BackColorPreview.Text = NotifyRes.BackColorDisplay + ":";
			this.ToolTipText.SetToolTip(this.BackColorPreview, NotifyRes.BackColorDispHint);
			this.BackColorPreview.ForeColorChanged += new System.EventHandler(this.BackColorPreview_ForeColorChanged);
			//
			// BackColorSelect
			//
			this.BackColorSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.BackColorSelect.Location = new System.Drawing.Point(342, 134);
			this.BackColorSelect.Name = "BackColorSelect";
			this.BackColorSelect.Size = new System.Drawing.Size(32, 23);
			this.BackColorSelect.TabIndex = 19;
			this.BackColorSelect.Text = "...";
			this.ToolTipText.SetToolTip(this.BackColorSelect, NotifyRes.BackColorSelect);
			this.BackColorSelect.UseVisualStyleBackColor = true;
			this.BackColorSelect.Click += new System.EventHandler(this.BackColorSelect_Click);
			//
			// ForeColorPreview
			//
			this.ForeColorPreview.AutoSize = true;
			this.ForeColorPreview.Location = new System.Drawing.Point(269, 109);
			this.ForeColorPreview.Name = "ForeColorPreview";
			this.ForeColorPreview.Size = new System.Drawing.Size(67, 15);
			this.ForeColorPreview.TabIndex = 16;
			this.ForeColorPreview.Text = NotifyRes.ForeColorDisplay + ":";
			this.ToolTipText.SetToolTip(this.ForeColorPreview, NotifyRes.ForeColorDispHint);
			this.ForeColorPreview.ForeColorChanged += new System.EventHandler(this.ForeColorPreview_ForeColorChanged);
			//
			// ForeColorSelect
			//
			this.ForeColorSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ForeColorSelect.Location = new System.Drawing.Point(342, 105);
			this.ForeColorSelect.Name = "ForeColorSelect";
			this.ForeColorSelect.Size = new System.Drawing.Size(32, 23);
			this.ForeColorSelect.TabIndex = 17;
			this.ForeColorSelect.Text = "...";
			this.ToolTipText.SetToolTip(this.ForeColorSelect, NotifyRes.ForeColorSelect);
			this.ForeColorSelect.UseVisualStyleBackColor = true;
			this.ForeColorSelect.Click += new System.EventHandler(this.ForeColorSelect_Click);
			//
			// label3
			//
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(444, 23);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(19, 15);
			this.label3.TabIndex = 11;
			this.label3.Text = NotifyRes.Sec;
			//
			// label2
			//
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(269, 23);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(83, 15);
			this.label2.TabIndex = 9;
			this.label2.Text = NotifyRes.HurryBy + ":";
			//
			// AccelInterval
			//
			this.AccelInterval.Location = new System.Drawing.Point(358, 18);
			this.AccelInterval.Maximum = new decimal(new int[] {
			9999,
			0,
			0,
			0});
			this.AccelInterval.Minimum = new decimal(new int[] {
				9999,
				0,
				0,
				-2147483648});
			this.AccelInterval.Name = "AccelInterval";
			this.AccelInterval.Size = new System.Drawing.Size(80, 23);
			this.AccelInterval.TabIndex = 10;
			this.AccelInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.ToolTipText.SetToolTip(this.AccelInterval, NotifyRes.HurryHint);
			//
			// TopMostFlag
			//
			this.TopMostFlag.AutoSize = true;
			this.TopMostFlag.Location = new System.Drawing.Point(268, 77);
			this.TopMostFlag.Name = "TopMostFlag";
			this.TopMostFlag.Size = new System.Drawing.Size(114, 19);
			this.TopMostFlag.TabIndex = 15;
			this.TopMostFlag.Text = NotifyRes.ShowOnTop;
			this.TopMostFlag.UseVisualStyleBackColor = true;
			//
			// LocationY
			//
			this.LocationY.Location = new System.Drawing.Point(166, 76);
			this.LocationY.Maximum = new decimal(new int[] {
			99999,
			0,
			0,
			0});
			this.LocationY.Minimum = new decimal(new int[] {
			99999,
			0,
			0,
			-2147483648});
			this.LocationY.Name = "LocationY";
			this.LocationY.Size = new System.Drawing.Size(80, 23);
			this.LocationY.TabIndex = 5;
			this.LocationY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.ToolTipText.SetToolTip(this.LocationY, NotifyRes.LocYHint);
			this.LocationY.Value = new decimal(new int[] {
			99999,
			0,
			0,
			-2147483648});
			//
			// LocationX
			//
			this.LocationX.Location = new System.Drawing.Point(81, 76);
			this.LocationX.Maximum = new decimal(new int[] {
			99999,
			0,
			0,
			0});
			this.LocationX.Minimum = new decimal(new int[] {
			99999,
			0,
			0,
			-2147483648});
			this.LocationX.Name = "LocationX";
			this.LocationX.Size = new System.Drawing.Size(80, 23);
			this.LocationX.TabIndex = 4;
			this.LocationX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.ToolTipText.SetToolTip(this.LocationX, NotifyRes.LocXHint);
			this.LocationX.Value = new decimal(new int[] {
			99999,
			0,
			0,
			-2147483648});
			//
			// label1
			//
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 50);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(43, 15);
			this.label1.TabIndex = 1;
			this.label1.Text = NotifyRes.Alignment + ":";
			//
			// Alignment
			//
			this.Alignment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Alignment.FormattingEnabled = true;
			this.Alignment.Items.AddRange(new object[] {
			NotifyRes.AlignUnset,
			NotifyRes.AlignTopLeft,
			NotifyRes.AlignTop,
			NotifyRes.AlignTopRight,
			NotifyRes.AlignLeft,
			NotifyRes.AlignCenter,
			NotifyRes.AlignRight,
			NotifyRes.AlignBottomLeft,
			NotifyRes.AlignBottom,
			NotifyRes.AlignBottomRight,
			NotifyRes.AlignManualAbs,
			NotifyRes.AlignManualRel});
			this.Alignment.Location = new System.Drawing.Point(55, 47);
			this.Alignment.Name = "Alignment";
			this.Alignment.Size = new System.Drawing.Size(121, 23);
			this.Alignment.TabIndex = 2;
			this.ToolTipText.SetToolTip(this.Alignment, NotifyRes.AlignHint);
			//
			// ShowsDialog
			//
			this.ShowsDialog.AutoSize = true;
			this.ShowsDialog.Location = new System.Drawing.Point(6, 22);
			this.ShowsDialog.Name = "ShowsDialog";
			this.ShowsDialog.Size = new System.Drawing.Size(78, 19);
			this.ShowsDialog.TabIndex = 0;
			this.ShowsDialog.Text = NotifyRes.Enable;
			this.ShowsDialog.UseVisualStyleBackColor = true;
			//
			// GroupDamage
			//
			this.GroupDamage.Controls.Add(this.NotifiesAtEndpoint);
			this.GroupDamage.Controls.Add(this.ContainsFlagship);
			this.GroupDamage.Controls.Add(this.ContainsSafeShip);
			this.GroupDamage.Controls.Add(this.ContainsNotLockedShip);
			this.GroupDamage.Controls.Add(this.label8);
			this.GroupDamage.Controls.Add(this.LevelBorder);
			this.GroupDamage.Controls.Add(this.NotifiesAfter);
			this.GroupDamage.Controls.Add(this.NotifiesNow);
			this.GroupDamage.Controls.Add(this.NotifiesBefore);
			this.GroupDamage.Location = new System.Drawing.Point(12, 298);
			this.GroupDamage.Name = "GroupDamage";
			this.GroupDamage.Size = new System.Drawing.Size(602, 103);
			this.GroupDamage.TabIndex = 4;
			this.GroupDamage.TabStop = false;
			this.GroupDamage.Text = NotifyRes.DamageOptions;
			//
			// NotifiesAtEndpoint
			//
			this.NotifiesAtEndpoint.AutoSize = true;
			this.NotifiesAtEndpoint.Location = new System.Drawing.Point(292, 22);
			this.NotifiesAtEndpoint.Name = "NotifiesAtEndpoint";
			this.NotifiesAtEndpoint.Size = new System.Drawing.Size(112, 19);
			this.NotifiesAtEndpoint.TabIndex = 6;
			this.NotifiesAtEndpoint.Text = NotifyRes.NotifyEndNodes;
			this.ToolTipText.SetToolTip(this.NotifiesAtEndpoint, NotifyRes.NotifyEndHint);
			this.NotifiesAtEndpoint.UseVisualStyleBackColor = true;
			//
			// ContainsFlagship
			//
			this.ContainsFlagship.AutoSize = true;
			this.ContainsFlagship.Location = new System.Drawing.Point(146, 72);
			this.ContainsFlagship.Name = "ContainsFlagship";
			this.ContainsFlagship.Size = new System.Drawing.Size(90, 19);
			this.ContainsFlagship.TabIndex = 5;
			this.ContainsFlagship.Text = NotifyRes.IncludeFlagship;
			this.ContainsFlagship.UseVisualStyleBackColor = true;
			//
			// ContainsSafeShip
			//
			this.ContainsSafeShip.AutoSize = true;
			this.ContainsSafeShip.Location = new System.Drawing.Point(146, 47);
			this.ContainsSafeShip.Name = "ContainsSafeShip";
			this.ContainsSafeShip.Size = new System.Drawing.Size(136, 19);
			this.ContainsSafeShip.TabIndex = 4;
			this.ContainsSafeShip.Text = NotifyRes.IncludeDamecon;
			this.ContainsSafeShip.UseVisualStyleBackColor = true;
			//
			// ContainsNotLockedShip
			//
			this.ContainsNotLockedShip.AutoSize = true;
			this.ContainsNotLockedShip.Location = new System.Drawing.Point(146, 22);
			this.ContainsNotLockedShip.Name = "ContainsNotLockedShip";
			this.ContainsNotLockedShip.Size = new System.Drawing.Size(114, 19);
			this.ContainsNotLockedShip.TabIndex = 3;
			this.ContainsNotLockedShip.Text = NotifyRes.IncludeUnlocked;
			this.ContainsNotLockedShip.UseVisualStyleBackColor = true;
			//
			// label8
			//
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(289, 48);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(56, 15);
			this.label8.TabIndex = 7;
			this.label8.Text = NotifyRes.MinLv + ":";
			//
			// LevelBorder
			//
			this.LevelBorder.Location = new System.Drawing.Point(351, 46);
			this.LevelBorder.Maximum = new decimal(new int[] {
			150,
			0,
			0,
			0});
			this.LevelBorder.Minimum = new decimal(new int[] {
			1,
			0,
			0,
			0});
			this.LevelBorder.Name = "LevelBorder";
			this.LevelBorder.Size = new System.Drawing.Size(80, 23);
			this.LevelBorder.TabIndex = 8;
			this.LevelBorder.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.ToolTipText.SetToolTip(this.LevelBorder, NotifyRes.LvHint);
			this.LevelBorder.Value = new decimal(new int[] {
			1,
			0,
			0,
			0});
			//
			// NotifiesAfter
			//
			this.NotifiesAfter.AutoSize = true;
			this.NotifiesAfter.Location = new System.Drawing.Point(6, 72);
			this.NotifiesAfter.Name = "NotifiesAfter";
			this.NotifiesAfter.Size = new System.Drawing.Size(135, 19);
			this.NotifiesAfter.TabIndex = 2;
			this.NotifiesAfter.Text = NotifyRes.NotifyAfter;
			this.ToolTipText.SetToolTip(this.NotifiesAfter, NotifyRes.NotifyAfterHint);
			this.NotifiesAfter.UseVisualStyleBackColor = true;
			//
			// NotifiesNow
			//
			this.NotifiesNow.AutoSize = true;
			this.NotifiesNow.Location = new System.Drawing.Point(6, 47);
			this.NotifiesNow.Name = "NotifiesNow";
			this.NotifiesNow.Size = new System.Drawing.Size(135, 19);
			this.NotifiesNow.TabIndex = 1;
			this.NotifiesNow.Text = NotifyRes.NotifyNow;
			this.ToolTipText.SetToolTip(this.NotifiesNow, NotifyRes.NotifyNowHint);
			this.NotifiesNow.UseVisualStyleBackColor = true;
			//
			// NotifiesBefore
			//
			this.NotifiesBefore.AutoSize = true;
			this.NotifiesBefore.Location = new System.Drawing.Point(6, 22);
			this.NotifiesBefore.Name = "NotifiesBefore";
			this.NotifiesBefore.Size = new System.Drawing.Size(135, 19);
			this.NotifiesBefore.TabIndex = 0;
			this.NotifiesBefore.Text = NotifyRes.NotifyBefore;
			this.ToolTipText.SetToolTip(this.NotifiesBefore, NotifyRes.NotifyBeforeHint);
			this.NotifiesBefore.UseVisualStyleBackColor = true;
			//
			// DialogColor
			//
			this.DialogColor.AnyColor = true;
			this.DialogColor.FullOpen = true;
			//
			// DialogOpenSound
			//
			this.DialogOpenSound.Filter = "Wave|*.wav|File|*";
			this.DialogOpenSound.Title = NotifyRes.OpenSound;
			//
			// DialogOpenImage
			//
			this.DialogOpenImage.Filter = "Image|*.bmp;*.div;*.jpg;*.jpeg;*.jpe;*.jfif;*.gif;*.png;*.tif;*.tiff|BMP|*.bmp;*." +
    "div|JPEG|*.jpg;*.jpeg;*.jpe;*.jfif|GIF|*.gif|PNG|*.png|TIFF|*.tif;*.tiff|File|*";
			this.DialogOpenImage.Title = NotifyRes.OpenImage;
			//
			// ToolTipText
			//
			this.ToolTipText.AutoPopDelay = 30000;
			this.ToolTipText.InitialDelay = 500;
			this.ToolTipText.ReshowDelay = 100;
			//
			// label10
			//
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(93, 411);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(213, 15);
			this.label10.TabIndex = 8;
			this.label10.Text = "＊The settings will be applied at the time of the test";
			//
			// GroupAnchorageRepair
			//
			this.GroupAnchorageRepair.Controls.Add(this.AnchorageRepairNotificationLevel);
			this.GroupAnchorageRepair.Controls.Add(this.label11);
			this.GroupAnchorageRepair.Location = new System.Drawing.Point(12, 298);
			this.GroupAnchorageRepair.Name = "GroupAnchorageRepair";
			this.GroupAnchorageRepair.Size = new System.Drawing.Size(602, 103);
			this.GroupAnchorageRepair.TabIndex = 9;
			this.GroupAnchorageRepair.TabStop = false;
			this.GroupAnchorageRepair.Text = "Anchorage Repair Settings";
			//
			// label11
			//
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(7, 22);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(67, 15);
			this.label11.TabIndex = 0;
			this.label11.Text = "Trigger when：";
			// 
			// GroupBaseAirCorps
			// 
			this.GroupBaseAirCorps.Controls.Add(this.BaseAirCorps_SquadronRelocation);
			this.GroupBaseAirCorps.Controls.Add(this.BaseAirCorps_EquipmentRelocation);
			this.GroupBaseAirCorps.Controls.Add(this.BaseAirCorps_EventMap);
			this.GroupBaseAirCorps.Controls.Add(this.BaseAirCorps_NormalMap);
			this.GroupBaseAirCorps.Controls.Add(this.BaseAirCorps_Standby);
			this.GroupBaseAirCorps.Controls.Add(this.BaseAirCorps_Retreat);
			this.GroupBaseAirCorps.Controls.Add(this.BaseAirCorps_Rest);
			this.GroupBaseAirCorps.Controls.Add(this.BaseAirCorps_NotOrganized);
			this.GroupBaseAirCorps.Controls.Add(this.BaseAirCorps_Tired);
			this.GroupBaseAirCorps.Controls.Add(this.BaseAirCorps_NotSupplied);
			this.GroupBaseAirCorps.Location = new System.Drawing.Point(12, 298);
			this.GroupBaseAirCorps.Name = "GroupBaseAirCorps";
			this.GroupBaseAirCorps.Size = new System.Drawing.Size(602, 103);
			this.GroupBaseAirCorps.TabIndex = 10;
			this.GroupBaseAirCorps.TabStop = false;
			this.GroupBaseAirCorps.Text = "AB Settings";
			// 
			// BaseAirCorps_NotSupplied
			// 
			this.BaseAirCorps_NotSupplied.AutoSize = true;
			this.BaseAirCorps_NotSupplied.Location = new System.Drawing.Point(10, 22);
			this.BaseAirCorps_NotSupplied.Name = "BaseAirCorps_NotSupplied";
			this.BaseAirCorps_NotSupplied.Size = new System.Drawing.Size(74, 19);
			this.BaseAirCorps_NotSupplied.TabIndex = 0;
			this.BaseAirCorps_NotSupplied.Text = "Not Supplied";
			this.ToolTipText.SetToolTip(this.BaseAirCorps_NotSupplied, "Before a sortie, notify if any base wasn't resupplied.");
			this.BaseAirCorps_NotSupplied.UseVisualStyleBackColor = true;
			// 
			// BaseAirCorps_Tired
			// 
			this.BaseAirCorps_Tired.AutoSize = true;
			this.BaseAirCorps_Tired.Location = new System.Drawing.Point(10, 47);
			this.BaseAirCorps_Tired.Name = "BaseAirCorps_Tired";
			this.BaseAirCorps_Tired.Size = new System.Drawing.Size(62, 19);
			this.BaseAirCorps_Tired.TabIndex = 1;
			this.BaseAirCorps_Tired.Text = "Tired";
			this.ToolTipText.SetToolTip(this.BaseAirCorps_Tired, "Before a sortie, notify if any base has low morale.");
			this.BaseAirCorps_Tired.UseVisualStyleBackColor = true;
			// 
			// BaseAirCorps_NotOrganized
			// 
			this.BaseAirCorps_NotOrganized.AutoSize = true;
			this.BaseAirCorps_NotOrganized.Location = new System.Drawing.Point(10, 72);
			this.BaseAirCorps_NotOrganized.Name = "BaseAirCorps_NotOrganized";
			this.BaseAirCorps_NotOrganized.Size = new System.Drawing.Size(128, 19);
			this.BaseAirCorps_NotOrganized.TabIndex = 2;
			this.BaseAirCorps_NotOrganized.Text = "Unassigned/Relocating";
			this.ToolTipText.SetToolTip(this.BaseAirCorps_NotOrganized, "Before a sortie, notify if any base slot is unassigned or relocating.");
			this.BaseAirCorps_NotOrganized.UseVisualStyleBackColor = true;
			// 
			// BaseAirCorps_Rest
			// 
			this.BaseAirCorps_Rest.AutoSize = true;
			this.BaseAirCorps_Rest.Location = new System.Drawing.Point(147, 72);
			this.BaseAirCorps_Rest.Name = "BaseAirCorps_Rest";
			this.BaseAirCorps_Rest.Size = new System.Drawing.Size(60, 19);
			this.BaseAirCorps_Rest.TabIndex = 5;
			this.BaseAirCorps_Rest.Text = "Rest";
			this.ToolTipText.SetToolTip(this.BaseAirCorps_Rest, "Before a sortie, notify if any base is resting.");
			this.BaseAirCorps_Rest.UseVisualStyleBackColor = true;
			// 
			// BaseAirCorps_Retreat
			// 
			this.BaseAirCorps_Retreat.AutoSize = true;
			this.BaseAirCorps_Retreat.Location = new System.Drawing.Point(147, 47);
			this.BaseAirCorps_Retreat.Name = "BaseAirCorps_Retreat";
			this.BaseAirCorps_Retreat.Size = new System.Drawing.Size(60, 19);
			this.BaseAirCorps_Retreat.TabIndex = 4;
			this.BaseAirCorps_Retreat.Text = "Retreat";
			this.ToolTipText.SetToolTip(this.BaseAirCorps_Retreat, "Before a sortie, notify if any base is retreating.");
			this.BaseAirCorps_Retreat.UseVisualStyleBackColor = true;
			// 
			// BaseAirCorps_Standby
			// 
			this.BaseAirCorps_Standby.AutoSize = true;
			this.BaseAirCorps_Standby.Location = new System.Drawing.Point(147, 22);
			this.BaseAirCorps_Standby.Name = "BaseAirCorps_Standby";
			this.BaseAirCorps_Standby.Size = new System.Drawing.Size(60, 19);
			this.BaseAirCorps_Standby.TabIndex = 3;
			this.BaseAirCorps_Standby.Text = "Standby";
			this.ToolTipText.SetToolTip(this.BaseAirCorps_Standby, "Before a sortie, notify if any base is standing by.");
			this.BaseAirCorps_Standby.UseVisualStyleBackColor = true;
			// 
			// BaseAirCorps_NormalMap
			// 
			this.BaseAirCorps_NormalMap.AutoSize = true;
			this.BaseAirCorps_NormalMap.Location = new System.Drawing.Point(213, 22);
			this.BaseAirCorps_NormalMap.Name = "BaseAirCorps_NormalMap";
			this.BaseAirCorps_NormalMap.Size = new System.Drawing.Size(74, 19);
			this.BaseAirCorps_NormalMap.TabIndex = 6;
			this.BaseAirCorps_NormalMap.Text = "Normal Map";
			this.ToolTipText.SetToolTip(this.BaseAirCorps_NormalMap, "Enable notifications for normal maps.");
			this.BaseAirCorps_NormalMap.UseVisualStyleBackColor = true;
			// 
			// BaseAirCorps_EventMap
			// 
			this.BaseAirCorps_EventMap.AutoSize = true;
			this.BaseAirCorps_EventMap.Location = new System.Drawing.Point(213, 47);
			this.BaseAirCorps_EventMap.Name = "BaseAirCorps_EventMap";
			this.BaseAirCorps_EventMap.Size = new System.Drawing.Size(86, 19);
			this.BaseAirCorps_EventMap.TabIndex = 7;
			this.BaseAirCorps_EventMap.Text = "Event Map";
			this.ToolTipText.SetToolTip(this.BaseAirCorps_EventMap, "Enable notifications for event maps.");
			this.BaseAirCorps_EventMap.UseVisualStyleBackColor = true;
			// 
			// BaseAirCorps_EquipmentRelocation
			// 
			this.BaseAirCorps_EquipmentRelocation.AutoSize = true;
			this.BaseAirCorps_EquipmentRelocation.Location = new System.Drawing.Point(305, 46);
			this.BaseAirCorps_EquipmentRelocation.Name = "BaseAirCorps_EquipmentRelocation";
			this.BaseAirCorps_EquipmentRelocation.Size = new System.Drawing.Size(132, 19);
			this.BaseAirCorps_EquipmentRelocation.TabIndex = 9;
			this.BaseAirCorps_EquipmentRelocation.Text = "Equipment Relocation";
			this.ToolTipText.SetToolTip(this.BaseAirCorps_EquipmentRelocation, "Notify when aircraft is available again after it was removed.");
			this.BaseAirCorps_EquipmentRelocation.UseVisualStyleBackColor = true;
			// 
			// BaseAirCorps_SquadronRelocation
			// 
			this.BaseAirCorps_SquadronRelocation.AutoSize = true;
			this.BaseAirCorps_SquadronRelocation.Location = new System.Drawing.Point(305, 22);
			this.BaseAirCorps_SquadronRelocation.Name = "BaseAirCorps_SquadronRelocation";
			this.BaseAirCorps_SquadronRelocation.Size = new System.Drawing.Size(132, 19);
			this.BaseAirCorps_SquadronRelocation.TabIndex = 8;
			this.BaseAirCorps_SquadronRelocation.Text = "Squadron Relocation";
			this.ToolTipText.SetToolTip(this.BaseAirCorps_SquadronRelocation, "Notify when base slot is available again after an aircraft was removed.");
			this.BaseAirCorps_SquadronRelocation.UseVisualStyleBackColor = true;
			// 
			// GroupBattleEnd
			//
			this.GroupBattleEnd.Controls.Add(this.BattleEnd_IdleTimerEnabled);
			this.GroupBattleEnd.Controls.Add(this.BattleEnd_IdleTime);
			this.GroupBattleEnd.Location = new System.Drawing.Point(12, 298);
			this.GroupBattleEnd.Name = "GroupBattleEnd";
			this.GroupBattleEnd.Size = new System.Drawing.Size(602, 103);
			this.GroupBattleEnd.TabIndex = 10;
			this.GroupBattleEnd.TabStop = false;
			this.GroupBattleEnd.Text = "Battle end settings";
			// 
			// BattleEnd_IdleTimerEnabled
			// 
			this.BattleEnd_IdleTimerEnabled.AutoSize = true;
			this.BattleEnd_IdleTimerEnabled.Location = new System.Drawing.Point(10, 22);
			this.BattleEnd_IdleTimerEnabled.Name = "BattleEnd_IdleTimer";
			this.BattleEnd_IdleTimerEnabled.Size = new System.Drawing.Size(74, 19);
			this.BattleEnd_IdleTimerEnabled.TabIndex = 0;
			this.BattleEnd_IdleTimerEnabled.Text = "Enable idle time";
			this.ToolTipText.SetToolTip(this.BattleEnd_IdleTimerEnabled, "Notify a certain period of time after the battle started.");
			this.BattleEnd_IdleTimerEnabled.UseVisualStyleBackColor = true;
			//
			// BattleEnd_IdleTime
			//
			this.BattleEnd_IdleTime.Location = new System.Drawing.Point(10, 47);
			this.BattleEnd_IdleTime.Name = "BattleEnd_IdleTime";
			this.BattleEnd_IdleTime.AutoSize = true;
			this.BattleEnd_IdleTime.TabIndex = 2;
			this.BattleEnd_IdleTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.BattleEnd_IdleTime.Minimum = 1;
			this.BattleEnd_IdleTime.Maximum = int.MaxValue;
			this.BattleEnd_IdleTime.Text = "Idle time";
			this.ToolTipText.SetToolTip(this.BattleEnd_IdleTime, "Specify idle time in seconds.");
			//
			// AnchorageRepairNotificationLevel
			//
			this.AnchorageRepairNotificationLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.AnchorageRepairNotificationLevel.FormattingEnabled = true;
			this.AnchorageRepairNotificationLevel.Items.AddRange(new object[] {
			"Always",
			"Akashi as flagship",
			"Ship needed repair",
			"Preset"});
			this.AnchorageRepairNotificationLevel.Location = new System.Drawing.Point(80, 20);
			this.AnchorageRepairNotificationLevel.Name = "AnchorageRepairNotificationLevel";
			this.AnchorageRepairNotificationLevel.Size = new System.Drawing.Size(160, 23);
			this.AnchorageRepairNotificationLevel.TabIndex = 1;
			this.ToolTipText.SetToolTip(this.AnchorageRepairNotificationLevel, "Always: always trigger notification every 20 minutes.\r\nAkashi as flagship: + only if Akashi is set as flagship.\r\nShip needed repair: + only if there ships needed repair.");
			//
			// DialogConfigurationNotifier
			//
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(624, 442);
			this.Controls.Add(this.GroupBaseAirCorps);
			this.Controls.Add(this.GroupBattleEnd);
			this.Controls.Add(this.GroupAnchorageRepair);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.GroupDamage);
			this.Controls.Add(this.GroupDialog);
			this.Controls.Add(this.GroupImage);
			this.Controls.Add(this.IsEnabled);
			this.Controls.Add(this.ButtonTest);
			this.Controls.Add(this.GroupSound);
			this.Controls.Add(this.ButtonCancel);
			this.Controls.Add(this.ButtonOK);
			this.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "DialogConfigurationNotifier";
			this.ShowInTaskbar = false;
			this.Text = NotifyRes.Title;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Load += new System.EventHandler(this.DialogConfigurationNotifier_Load);
			this.GroupSound.ResumeLayout(false);
			this.GroupSound.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.SoundVolume)).EndInit();
			this.GroupImage.ResumeLayout(false);
			this.GroupImage.PerformLayout();
			this.GroupDialog.ResumeLayout(false);
			this.GroupDialog.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.ClosingInterval)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.AccelInterval)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.LocationY)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.LocationX)).EndInit();
			this.GroupDamage.ResumeLayout(false);
			this.GroupDamage.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.LevelBorder)).EndInit();
			this.GroupAnchorageRepair.ResumeLayout(false);
			this.GroupAnchorageRepair.PerformLayout();
			this.GroupBaseAirCorps.ResumeLayout(false);
			this.GroupBaseAirCorps.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button ButtonCancel;
		private System.Windows.Forms.Button ButtonOK;
		private System.Windows.Forms.GroupBox GroupSound;
		private System.Windows.Forms.Button ButtonTest;
		private System.Windows.Forms.CheckBox PlaysSound;
		private System.Windows.Forms.Button SoundPathSearch;
		internal System.Windows.Forms.TextBox SoundPath;
		private System.Windows.Forms.CheckBox IsEnabled;
		private System.Windows.Forms.GroupBox GroupImage;
		private System.Windows.Forms.CheckBox DrawsImage;
		private System.Windows.Forms.Button ImagePathSearch;
		internal System.Windows.Forms.TextBox ImagePath;
		private System.Windows.Forms.GroupBox GroupDialog;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown AccelInterval;
		private System.Windows.Forms.CheckBox TopMostFlag;
		private System.Windows.Forms.NumericUpDown LocationY;
		private System.Windows.Forms.NumericUpDown LocationX;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox Alignment;
		private System.Windows.Forms.CheckBox ShowsDialog;
		private System.Windows.Forms.Label BackColorPreview;
		private System.Windows.Forms.Button BackColorSelect;
		private System.Windows.Forms.Label ForeColorPreview;
		private System.Windows.Forms.Button ForeColorSelect;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.NumericUpDown ClosingInterval;
		private System.Windows.Forms.CheckBox HasFormBorder;
		private System.Windows.Forms.GroupBox GroupDamage;
		private System.Windows.Forms.CheckBox NotifiesAfter;
		private System.Windows.Forms.CheckBox NotifiesNow;
		private System.Windows.Forms.CheckBox NotifiesBefore;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.NumericUpDown LevelBorder;
		private System.Windows.Forms.CheckBox ContainsSafeShip;
		private System.Windows.Forms.CheckBox ContainsNotLockedShip;
		private System.Windows.Forms.CheckBox ContainsFlagship;
		private System.Windows.Forms.CheckBox DrawsMessage;
		private System.Windows.Forms.ColorDialog DialogColor;
		private System.Windows.Forms.OpenFileDialog DialogOpenSound;
		private System.Windows.Forms.OpenFileDialog DialogOpenImage;
		private System.Windows.Forms.CheckBox NotifiesAtEndpoint;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ToolTip ToolTipText;
		private System.Windows.Forms.CheckBox ShowWithActivation;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.CheckedListBox CloseList;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.NumericUpDown SoundVolume;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.CheckBox LoopsSound;
		private System.Windows.Forms.Button SoundPathDirectorize;
		private System.Windows.Forms.GroupBox GroupAnchorageRepair;
		private System.Windows.Forms.ComboBox AnchorageRepairNotificationLevel;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.GroupBox GroupBaseAirCorps;
		private System.Windows.Forms.CheckBox BaseAirCorps_SquadronRelocation;
		private System.Windows.Forms.CheckBox BaseAirCorps_EquipmentRelocation;
		private System.Windows.Forms.CheckBox BaseAirCorps_EventMap;
		private System.Windows.Forms.CheckBox BaseAirCorps_NormalMap;
		private System.Windows.Forms.CheckBox BaseAirCorps_Standby;
		private System.Windows.Forms.CheckBox BaseAirCorps_Retreat;
		private System.Windows.Forms.CheckBox BaseAirCorps_Rest;
		private System.Windows.Forms.CheckBox BaseAirCorps_NotOrganized;
		private System.Windows.Forms.CheckBox BaseAirCorps_Tired;
		private System.Windows.Forms.CheckBox BaseAirCorps_NotSupplied;
		private System.Windows.Forms.GroupBox GroupBattleEnd;
		private System.Windows.Forms.CheckBox BattleEnd_IdleTimerEnabled;
		private System.Windows.Forms.NumericUpDown BattleEnd_IdleTime;
	}
}
