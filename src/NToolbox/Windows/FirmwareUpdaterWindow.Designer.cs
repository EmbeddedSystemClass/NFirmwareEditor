﻿#pragma warning disable 108, 114
namespace NToolbox.Windows
{
	partial class FirmwareUpdaterWindow
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
			this.UpdateStatusLabel = new System.Windows.Forms.Label();
			this.UpdateProgressBar = new System.Windows.Forms.ProgressBar();
			this.BootModeTextBox = new System.Windows.Forms.TextBox();
			this.HardwareVersionTextBox = new System.Windows.Forms.TextBox();
			this.FirmwareVersionTextBox = new System.Windows.Forms.TextBox();
			this.DeviceNameTextBox = new System.Windows.Forms.TextBox();
			this.HardwareLabel = new System.Windows.Forms.Label();
			this.FirmwareLabel = new System.Windows.Forms.Label();
			this.ControlBorderedPanel = new NCore.UI.BorderedPanel();
			this.CancelButton = new System.Windows.Forms.Button();
			this.ActiveTabPanel = new System.Windows.Forms.Panel();
			this.CommonLinkLabel = new System.Windows.Forms.LinkLabel();
			this.DataflashLinkLabel = new System.Windows.Forms.LinkLabel();
			this.AdvancedLinkLabel = new System.Windows.Forms.LinkLabel();
			this.TabMultiPanel = new NCore.UI.MultiPanel();
			this.CommonPage = new NCore.UI.MultiPanelPage();
			this.UpdateFromFileButton = new System.Windows.Forms.LinkLabel();
			this.DataflashPage = new NCore.UI.MultiPanelPage();
			this.ResetDataflashButton = new System.Windows.Forms.LinkLabel();
			this.WriteDataflashButton = new System.Windows.Forms.LinkLabel();
			this.ReadDataflashButton = new System.Windows.Forms.LinkLabel();
			this.AdvancedPage = new NCore.UI.MultiPanelPage();
			this.ChangeBootModeButton = new System.Windows.Forms.LinkLabel();
			this.ChangeHWButton = new System.Windows.Forms.LinkLabel();
			this.cardPanel1 = new NCore.UI.CardPanel();
			this.DeviceInfoPanel = new NCore.UI.BorderedPanel();
			this.BootLabel = new System.Windows.Forms.Label();
			this.InactiveTabPanel = new System.Windows.Forms.Panel();
			this.ControlBorderedPanel.SuspendLayout();
			this.TabMultiPanel.SuspendLayout();
			this.CommonPage.SuspendLayout();
			this.DataflashPage.SuspendLayout();
			this.AdvancedPage.SuspendLayout();
			this.cardPanel1.SuspendLayout();
			this.DeviceInfoPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// UpdateStatusLabel
			// 
			this.UpdateStatusLabel.AutoEllipsis = true;
			this.UpdateStatusLabel.BackColor = System.Drawing.Color.Transparent;
			this.UpdateStatusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(167)))), ((int)(((byte)(169)))));
			this.MainLocalizationExtender.SetKey(this.UpdateStatusLabel, "");
			this.UpdateStatusLabel.Location = new System.Drawing.Point(9, 202);
			this.UpdateStatusLabel.Name = "UpdateStatusLabel";
			this.UpdateStatusLabel.Size = new System.Drawing.Size(336, 20);
			this.UpdateStatusLabel.TabIndex = 5;
			this.UpdateStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// UpdateProgressBar
			// 
			this.MainLocalizationExtender.SetKey(this.UpdateProgressBar, "");
			this.UpdateProgressBar.Location = new System.Drawing.Point(9, 225);
			this.UpdateProgressBar.Name = "UpdateProgressBar";
			this.UpdateProgressBar.Size = new System.Drawing.Size(336, 30);
			this.UpdateProgressBar.TabIndex = 4;
			// 
			// BootModeTextBox
			// 
			this.BootModeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.BootModeTextBox.BackColor = System.Drawing.Color.White;
			this.BootModeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.BootModeTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(167)))), ((int)(((byte)(169)))));
			this.MainLocalizationExtender.SetKey(this.BootModeTextBox, "");
			this.BootModeTextBox.Location = new System.Drawing.Point(219, 75);
			this.BootModeTextBox.Name = "BootModeTextBox";
			this.BootModeTextBox.Size = new System.Drawing.Size(106, 14);
			this.BootModeTextBox.TabIndex = 25;
			this.BootModeTextBox.TabStop = false;
			this.BootModeTextBox.Text = "APROM";
			this.BootModeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// HardwareVersionTextBox
			// 
			this.HardwareVersionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.HardwareVersionTextBox.BackColor = System.Drawing.Color.White;
			this.HardwareVersionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.HardwareVersionTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(167)))), ((int)(((byte)(169)))));
			this.MainLocalizationExtender.SetKey(this.HardwareVersionTextBox, "");
			this.HardwareVersionTextBox.Location = new System.Drawing.Point(111, 75);
			this.HardwareVersionTextBox.Name = "HardwareVersionTextBox";
			this.HardwareVersionTextBox.Size = new System.Drawing.Size(106, 14);
			this.HardwareVersionTextBox.TabIndex = 21;
			this.HardwareVersionTextBox.TabStop = false;
			this.HardwareVersionTextBox.Text = "1.00";
			this.HardwareVersionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// FirmwareVersionTextBox
			// 
			this.FirmwareVersionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.FirmwareVersionTextBox.BackColor = System.Drawing.Color.White;
			this.FirmwareVersionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.FirmwareVersionTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(167)))), ((int)(((byte)(169)))));
			this.MainLocalizationExtender.SetKey(this.FirmwareVersionTextBox, "");
			this.FirmwareVersionTextBox.Location = new System.Drawing.Point(3, 75);
			this.FirmwareVersionTextBox.Name = "FirmwareVersionTextBox";
			this.FirmwareVersionTextBox.Size = new System.Drawing.Size(106, 14);
			this.FirmwareVersionTextBox.TabIndex = 20;
			this.FirmwareVersionTextBox.TabStop = false;
			this.FirmwareVersionTextBox.Text = "1.00";
			this.FirmwareVersionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// DeviceNameTextBox
			// 
			this.DeviceNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.DeviceNameTextBox.BackColor = System.Drawing.Color.White;
			this.DeviceNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.DeviceNameTextBox.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.DeviceNameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(91)))), ((int)(((byte)(108)))));
			this.MainLocalizationExtender.SetKey(this.DeviceNameTextBox, "");
			this.DeviceNameTextBox.Location = new System.Drawing.Point(1, 16);
			this.DeviceNameTextBox.Name = "DeviceNameTextBox";
			this.DeviceNameTextBox.Size = new System.Drawing.Size(328, 19);
			this.DeviceNameTextBox.TabIndex = 19;
			this.DeviceNameTextBox.TabStop = false;
			this.DeviceNameTextBox.Text = "[W057] Vapor Shark SwitchBox RX";
			this.DeviceNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// HardwareLabel
			// 
			this.HardwareLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.HardwareLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(167)))), ((int)(((byte)(169)))));
			this.MainLocalizationExtender.SetKey(this.HardwareLabel, "Toolbox.FirmwareUpdater.HardwareLabel");
			this.HardwareLabel.Location = new System.Drawing.Point(111, 59);
			this.HardwareLabel.Name = "HardwareLabel";
			this.HardwareLabel.Size = new System.Drawing.Size(108, 13);
			this.HardwareLabel.TabIndex = 24;
			this.HardwareLabel.Text = "Hardware";
			this.HardwareLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// FirmwareLabel
			// 
			this.FirmwareLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.FirmwareLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(167)))), ((int)(((byte)(169)))));
			this.MainLocalizationExtender.SetKey(this.FirmwareLabel, "Toolbox.FirmwareUpdater.FirmwareLabel");
			this.FirmwareLabel.Location = new System.Drawing.Point(3, 59);
			this.FirmwareLabel.Name = "FirmwareLabel";
			this.FirmwareLabel.Size = new System.Drawing.Size(108, 13);
			this.FirmwareLabel.TabIndex = 23;
			this.FirmwareLabel.Text = "Firmware";
			this.FirmwareLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// ControlBorderedPanel
			// 
			this.ControlBorderedPanel.BackColor = System.Drawing.Color.Transparent;
			this.ControlBorderedPanel.BorderBottom = false;
			this.ControlBorderedPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
			this.ControlBorderedPanel.BorderLeft = false;
			this.ControlBorderedPanel.BorderRight = false;
			this.ControlBorderedPanel.BorderTop = true;
			this.ControlBorderedPanel.BorderWidth = 1F;
			this.ControlBorderedPanel.Controls.Add(this.CancelButton);
			this.ControlBorderedPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.MainLocalizationExtender.SetKey(this.ControlBorderedPanel, "");
			this.ControlBorderedPanel.Location = new System.Drawing.Point(0, 261);
			this.ControlBorderedPanel.Name = "ControlBorderedPanel";
			this.ControlBorderedPanel.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
			this.ControlBorderedPanel.Size = new System.Drawing.Size(354, 44);
			this.ControlBorderedPanel.TabIndex = 3;
			this.ControlBorderedPanel.Text = "borderedPanel1";
			// 
			// CancelButton
			// 
			this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.MainLocalizationExtender.SetKey(this.CancelButton, "Toolbox.FirmwareUpdater.CancelButton");
			this.CancelButton.Location = new System.Drawing.Point(246, 5);
			this.CancelButton.Name = "CancelButton";
			this.CancelButton.Size = new System.Drawing.Size(100, 35);
			this.CancelButton.TabIndex = 3;
			this.CancelButton.Text = "Cancel";
			this.CancelButton.UseVisualStyleBackColor = true;
			// 
			// ActiveTabPanel
			// 
			this.ActiveTabPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.ActiveTabPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(146)))), ((int)(((byte)(221)))));
			this.MainLocalizationExtender.SetKey(this.ActiveTabPanel, "");
			this.ActiveTabPanel.Location = new System.Drawing.Point(0, 127);
			this.ActiveTabPanel.Name = "ActiveTabPanel";
			this.ActiveTabPanel.Size = new System.Drawing.Size(110, 3);
			this.ActiveTabPanel.TabIndex = 32;
			// 
			// CommonLinkLabel
			// 
			this.CommonLinkLabel.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(164)))));
			this.CommonLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.CommonLinkLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.MainLocalizationExtender.SetKey(this.CommonLinkLabel, "Toolbox.FirmwareUpdater.CommonTab");
			this.CommonLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
			this.CommonLinkLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(146)))), ((int)(((byte)(221)))));
			this.CommonLinkLabel.Location = new System.Drawing.Point(0, 108);
			this.CommonLinkLabel.Name = "CommonLinkLabel";
			this.CommonLinkLabel.Size = new System.Drawing.Size(110, 13);
			this.CommonLinkLabel.TabIndex = 47;
			this.CommonLinkLabel.TabStop = true;
			this.CommonLinkLabel.Text = "Common";
			this.CommonLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.CommonLinkLabel.VisitedLinkColor = System.Drawing.Color.White;
			// 
			// DataflashLinkLabel
			// 
			this.DataflashLinkLabel.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(164)))));
			this.DataflashLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.DataflashLinkLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.MainLocalizationExtender.SetKey(this.DataflashLinkLabel, "Toolbox.FirmwareUpdater.DatalfashTab");
			this.DataflashLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
			this.DataflashLinkLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
			this.DataflashLinkLabel.Location = new System.Drawing.Point(110, 108);
			this.DataflashLinkLabel.Name = "DataflashLinkLabel";
			this.DataflashLinkLabel.Size = new System.Drawing.Size(110, 13);
			this.DataflashLinkLabel.TabIndex = 48;
			this.DataflashLinkLabel.TabStop = true;
			this.DataflashLinkLabel.Text = "Dataflash";
			this.DataflashLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.DataflashLinkLabel.VisitedLinkColor = System.Drawing.Color.White;
			// 
			// AdvancedLinkLabel
			// 
			this.AdvancedLinkLabel.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(164)))));
			this.AdvancedLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.AdvancedLinkLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.MainLocalizationExtender.SetKey(this.AdvancedLinkLabel, "Toolbox.FirmwareUpdater.AdvancedTab");
			this.AdvancedLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
			this.AdvancedLinkLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
			this.AdvancedLinkLabel.Location = new System.Drawing.Point(221, 108);
			this.AdvancedLinkLabel.Name = "AdvancedLinkLabel";
			this.AdvancedLinkLabel.Size = new System.Drawing.Size(109, 13);
			this.AdvancedLinkLabel.TabIndex = 49;
			this.AdvancedLinkLabel.TabStop = true;
			this.AdvancedLinkLabel.Text = "Advanced";
			this.AdvancedLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.AdvancedLinkLabel.VisitedLinkColor = System.Drawing.Color.White;
			// 
			// TabMultiPanel
			// 
			this.TabMultiPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TabMultiPanel.Controls.Add(this.CommonPage);
			this.TabMultiPanel.Controls.Add(this.DataflashPage);
			this.TabMultiPanel.Controls.Add(this.AdvancedPage);
			this.MainLocalizationExtender.SetKey(this.TabMultiPanel, "");
			this.TabMultiPanel.Location = new System.Drawing.Point(11, 141);
			this.TabMultiPanel.Name = "TabMultiPanel";
			this.TabMultiPanel.SelectedPage = this.DataflashPage;
			this.TabMultiPanel.Size = new System.Drawing.Size(330, 40);
			this.TabMultiPanel.TabIndex = 50;
			// 
			// CommonPage
			// 
			this.CommonPage.Controls.Add(this.UpdateFromFileButton);
			this.CommonPage.Description = null;
			this.CommonPage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.MainLocalizationExtender.SetKey(this.CommonPage, "");
			this.CommonPage.Location = new System.Drawing.Point(0, 0);
			this.CommonPage.Name = "CommonPage";
			this.CommonPage.Size = new System.Drawing.Size(330, 40);
			this.CommonPage.TabIndex = 0;
			this.CommonPage.Text = "Common";
			// 
			// UpdateFromFileButton
			// 
			this.UpdateFromFileButton.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(146)))), ((int)(((byte)(221)))));
			this.UpdateFromFileButton.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(167)))), ((int)(((byte)(169)))));
			this.UpdateFromFileButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.UpdateFromFileButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(167)))), ((int)(((byte)(169)))));
			this.MainLocalizationExtender.SetKey(this.UpdateFromFileButton, "Toolbox.FirmwareUpdater.UpdateButton");
			this.UpdateFromFileButton.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
			this.UpdateFromFileButton.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(146)))), ((int)(((byte)(221)))));
			this.UpdateFromFileButton.Location = new System.Drawing.Point(1, 6);
			this.UpdateFromFileButton.Name = "UpdateFromFileButton";
			this.UpdateFromFileButton.Size = new System.Drawing.Size(328, 20);
			this.UpdateFromFileButton.TabIndex = 42;
			this.UpdateFromFileButton.TabStop = true;
			this.UpdateFromFileButton.Text = "Update from file";
			this.UpdateFromFileButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.UpdateFromFileButton.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(146)))), ((int)(((byte)(221)))));
			// 
			// DataflashPage
			// 
			this.DataflashPage.Controls.Add(this.ResetDataflashButton);
			this.DataflashPage.Controls.Add(this.WriteDataflashButton);
			this.DataflashPage.Controls.Add(this.ReadDataflashButton);
			this.DataflashPage.Description = null;
			this.DataflashPage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.MainLocalizationExtender.SetKey(this.DataflashPage, "");
			this.DataflashPage.Location = new System.Drawing.Point(0, 0);
			this.DataflashPage.Name = "DataflashPage";
			this.DataflashPage.Size = new System.Drawing.Size(330, 40);
			this.DataflashPage.TabIndex = 1;
			this.DataflashPage.Text = "Dataflash";
			// 
			// ResetDataflashButton
			// 
			this.ResetDataflashButton.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(146)))), ((int)(((byte)(221)))));
			this.ResetDataflashButton.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(167)))), ((int)(((byte)(169)))));
			this.ResetDataflashButton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ResetDataflashButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(167)))), ((int)(((byte)(169)))));
			this.MainLocalizationExtender.SetKey(this.ResetDataflashButton, "Toolbox.FirmwareUpdater.ResetDataFlashButton");
			this.ResetDataflashButton.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
			this.ResetDataflashButton.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(146)))), ((int)(((byte)(221)))));
			this.ResetDataflashButton.Location = new System.Drawing.Point(220, 8);
			this.ResetDataflashButton.Name = "ResetDataflashButton";
			this.ResetDataflashButton.Size = new System.Drawing.Size(110, 16);
			this.ResetDataflashButton.TabIndex = 43;
			this.ResetDataflashButton.TabStop = true;
			this.ResetDataflashButton.Text = "Reset dataflash";
			this.ResetDataflashButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.ResetDataflashButton.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(146)))), ((int)(((byte)(221)))));
			// 
			// WriteDataflashButton
			// 
			this.WriteDataflashButton.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(146)))), ((int)(((byte)(221)))));
			this.WriteDataflashButton.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(167)))), ((int)(((byte)(169)))));
			this.WriteDataflashButton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.WriteDataflashButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(167)))), ((int)(((byte)(169)))));
			this.MainLocalizationExtender.SetKey(this.WriteDataflashButton, "Toolbox.FirmwareUpdater.WriteDataflashButton");
			this.WriteDataflashButton.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
			this.WriteDataflashButton.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(146)))), ((int)(((byte)(221)))));
			this.WriteDataflashButton.Location = new System.Drawing.Point(110, 8);
			this.WriteDataflashButton.Name = "WriteDataflashButton";
			this.WriteDataflashButton.Size = new System.Drawing.Size(110, 16);
			this.WriteDataflashButton.TabIndex = 42;
			this.WriteDataflashButton.TabStop = true;
			this.WriteDataflashButton.Text = "Write dataflash";
			this.WriteDataflashButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.WriteDataflashButton.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(146)))), ((int)(((byte)(221)))));
			// 
			// ReadDataflashButton
			// 
			this.ReadDataflashButton.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(146)))), ((int)(((byte)(221)))));
			this.ReadDataflashButton.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(167)))), ((int)(((byte)(169)))));
			this.ReadDataflashButton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ReadDataflashButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(167)))), ((int)(((byte)(169)))));
			this.MainLocalizationExtender.SetKey(this.ReadDataflashButton, "Toolbox.FirmwareUpdater.ReadDataflashButton");
			this.ReadDataflashButton.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
			this.ReadDataflashButton.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(146)))), ((int)(((byte)(221)))));
			this.ReadDataflashButton.Location = new System.Drawing.Point(0, 8);
			this.ReadDataflashButton.Name = "ReadDataflashButton";
			this.ReadDataflashButton.Size = new System.Drawing.Size(110, 16);
			this.ReadDataflashButton.TabIndex = 41;
			this.ReadDataflashButton.TabStop = true;
			this.ReadDataflashButton.Text = "Read dataflash";
			this.ReadDataflashButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.ReadDataflashButton.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(146)))), ((int)(((byte)(221)))));
			// 
			// AdvancedPage
			// 
			this.AdvancedPage.Controls.Add(this.ChangeBootModeButton);
			this.AdvancedPage.Controls.Add(this.ChangeHWButton);
			this.AdvancedPage.Description = null;
			this.AdvancedPage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.MainLocalizationExtender.SetKey(this.AdvancedPage, "");
			this.AdvancedPage.Location = new System.Drawing.Point(0, 0);
			this.AdvancedPage.Name = "AdvancedPage";
			this.AdvancedPage.Size = new System.Drawing.Size(330, 40);
			this.AdvancedPage.TabIndex = 2;
			this.AdvancedPage.Text = "Advanced";
			// 
			// ChangeBootModeButton
			// 
			this.ChangeBootModeButton.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(146)))), ((int)(((byte)(221)))));
			this.ChangeBootModeButton.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(167)))), ((int)(((byte)(169)))));
			this.ChangeBootModeButton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ChangeBootModeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(167)))), ((int)(((byte)(169)))));
			this.MainLocalizationExtender.SetKey(this.ChangeBootModeButton, "Toolbox.FirmwareUpdater.SwitchBootModeButton");
			this.ChangeBootModeButton.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
			this.ChangeBootModeButton.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(146)))), ((int)(((byte)(221)))));
			this.ChangeBootModeButton.Location = new System.Drawing.Point(165, 8);
			this.ChangeBootModeButton.Name = "ChangeBootModeButton";
			this.ChangeBootModeButton.Size = new System.Drawing.Size(165, 16);
			this.ChangeBootModeButton.TabIndex = 44;
			this.ChangeBootModeButton.TabStop = true;
			this.ChangeBootModeButton.Text = "Switch boot mode";
			this.ChangeBootModeButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.ChangeBootModeButton.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(146)))), ((int)(((byte)(221)))));
			// 
			// ChangeHWButton
			// 
			this.ChangeHWButton.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(146)))), ((int)(((byte)(221)))));
			this.ChangeHWButton.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(167)))), ((int)(((byte)(169)))));
			this.ChangeHWButton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ChangeHWButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(167)))), ((int)(((byte)(169)))));
			this.MainLocalizationExtender.SetKey(this.ChangeHWButton, "Toolbox.FirmwareUpdater.ChangeHWVerButton");
			this.ChangeHWButton.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
			this.ChangeHWButton.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(146)))), ((int)(((byte)(221)))));
			this.ChangeHWButton.Location = new System.Drawing.Point(0, 8);
			this.ChangeHWButton.Name = "ChangeHWButton";
			this.ChangeHWButton.Size = new System.Drawing.Size(165, 16);
			this.ChangeHWButton.TabIndex = 43;
			this.ChangeHWButton.TabStop = true;
			this.ChangeHWButton.Text = "Change HW Version";
			this.ChangeHWButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.ChangeHWButton.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(146)))), ((int)(((byte)(221)))));
			// 
			// cardPanel1
			// 
			this.cardPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
			this.cardPanel1.Controls.Add(this.DeviceInfoPanel);
			this.cardPanel1.Controls.Add(this.TabMultiPanel);
			this.MainLocalizationExtender.SetKey(this.cardPanel1, "");
			this.cardPanel1.Location = new System.Drawing.Point(1, 6);
			this.cardPanel1.Name = "cardPanel1";
			this.cardPanel1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.cardPanel1.ShadowDensity = ((byte)(100));
			this.cardPanel1.ShadowLength = 10;
			this.cardPanel1.Size = new System.Drawing.Size(352, 195);
			this.cardPanel1.TabIndex = 51;
			// 
			// DeviceInfoPanel
			// 
			this.DeviceInfoPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.DeviceInfoPanel.BackColor = System.Drawing.Color.White;
			this.DeviceInfoPanel.BorderBottom = false;
			this.DeviceInfoPanel.BorderColor = System.Drawing.Color.LightGray;
			this.DeviceInfoPanel.BorderLeft = false;
			this.DeviceInfoPanel.BorderRight = false;
			this.DeviceInfoPanel.BorderTop = false;
			this.DeviceInfoPanel.BorderWidth = 1F;
			this.DeviceInfoPanel.Controls.Add(this.BootLabel);
			this.DeviceInfoPanel.Controls.Add(this.BootModeTextBox);
			this.DeviceInfoPanel.Controls.Add(this.HardwareVersionTextBox);
			this.DeviceInfoPanel.Controls.Add(this.DeviceNameTextBox);
			this.DeviceInfoPanel.Controls.Add(this.FirmwareVersionTextBox);
			this.DeviceInfoPanel.Controls.Add(this.CommonLinkLabel);
			this.DeviceInfoPanel.Controls.Add(this.DataflashLinkLabel);
			this.DeviceInfoPanel.Controls.Add(this.FirmwareLabel);
			this.DeviceInfoPanel.Controls.Add(this.HardwareLabel);
			this.DeviceInfoPanel.Controls.Add(this.ActiveTabPanel);
			this.DeviceInfoPanel.Controls.Add(this.AdvancedLinkLabel);
			this.DeviceInfoPanel.Controls.Add(this.InactiveTabPanel);
			this.MainLocalizationExtender.SetKey(this.DeviceInfoPanel, "");
			this.DeviceInfoPanel.Location = new System.Drawing.Point(11, 3);
			this.DeviceInfoPanel.Name = "DeviceInfoPanel";
			this.DeviceInfoPanel.Size = new System.Drawing.Size(330, 130);
			this.DeviceInfoPanel.TabIndex = 0;
			// 
			// BootLabel
			// 
			this.BootLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.BootLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(167)))), ((int)(((byte)(169)))));
			this.MainLocalizationExtender.SetKey(this.BootLabel, "Toolbox.FirmwareUpdater.BootLabel");
			this.BootLabel.Location = new System.Drawing.Point(219, 59);
			this.BootLabel.Name = "BootLabel";
			this.BootLabel.Size = new System.Drawing.Size(108, 13);
			this.BootLabel.TabIndex = 26;
			this.BootLabel.Text = "Boot";
			this.BootLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// InactiveTabPanel
			// 
			this.InactiveTabPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.InactiveTabPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.MainLocalizationExtender.SetKey(this.InactiveTabPanel, "");
			this.InactiveTabPanel.Location = new System.Drawing.Point(0, 127);
			this.InactiveTabPanel.Name = "InactiveTabPanel";
			this.InactiveTabPanel.Size = new System.Drawing.Size(330, 3);
			this.InactiveTabPanel.TabIndex = 33;
			// 
			// FirmwareUpdaterWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(354, 305);
			this.Controls.Add(this.UpdateProgressBar);
			this.Controls.Add(this.UpdateStatusLabel);
			this.Controls.Add(this.cardPanel1);
			this.Controls.Add(this.ControlBorderedPanel);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MainLocalizationExtender.SetKey(this, "");
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FirmwareUpdaterWindow";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "NToolbox - Updater";
			this.Load += new System.EventHandler(this.FirmwareUpdaterWindow_Load);
			this.ControlBorderedPanel.ResumeLayout(false);
			this.TabMultiPanel.ResumeLayout(false);
			this.CommonPage.ResumeLayout(false);
			this.DataflashPage.ResumeLayout(false);
			this.AdvancedPage.ResumeLayout(false);
			this.cardPanel1.ResumeLayout(false);
			this.DeviceInfoPanel.ResumeLayout(false);
			this.DeviceInfoPanel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private NCore.UI.BorderedPanel ControlBorderedPanel;
		private System.Windows.Forms.Button CancelButton;
		private System.Windows.Forms.Label HardwareLabel;
		private System.Windows.Forms.TextBox HardwareVersionTextBox;
		private System.Windows.Forms.Label FirmwareLabel;
		private System.Windows.Forms.TextBox FirmwareVersionTextBox;
		private System.Windows.Forms.TextBox DeviceNameTextBox;
		private System.Windows.Forms.ProgressBar UpdateProgressBar;
		private System.Windows.Forms.Label UpdateStatusLabel;
		private System.Windows.Forms.TextBox BootModeTextBox;
		private System.Windows.Forms.Panel ActiveTabPanel;
		private System.Windows.Forms.LinkLabel CommonLinkLabel;
		private System.Windows.Forms.LinkLabel DataflashLinkLabel;
		private System.Windows.Forms.LinkLabel AdvancedLinkLabel;
		private NCore.UI.MultiPanel TabMultiPanel;
		private NCore.UI.MultiPanelPage CommonPage;
		private NCore.UI.MultiPanelPage DataflashPage;
		private NCore.UI.MultiPanelPage AdvancedPage;
		private System.Windows.Forms.LinkLabel ResetDataflashButton;
		private System.Windows.Forms.LinkLabel WriteDataflashButton;
		private System.Windows.Forms.LinkLabel ReadDataflashButton;
		private System.Windows.Forms.LinkLabel UpdateFromFileButton;
		private System.Windows.Forms.LinkLabel ChangeBootModeButton;
		private System.Windows.Forms.LinkLabel ChangeHWButton;
		private NCore.UI.CardPanel cardPanel1;
		private NCore.UI.BorderedPanel DeviceInfoPanel;
		private System.Windows.Forms.Label BootLabel;
		private System.Windows.Forms.Panel InactiveTabPanel;
	}
}