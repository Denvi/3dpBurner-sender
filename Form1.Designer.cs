/*  3dpBurner Sender. A GCODE sender for GRBL based devices.
    This file is part of 3dpBurner Sender application.
   
    Copyright (C) 2014-2015  Adrian V. J. (villamany) contact: villamany@gmail.com

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/
//Form 1 (Main form) design

namespace _3dpBurner
{
    partial class frm3dpBurner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm3dpBurner));
            this.bOpenPort = new System.Windows.Forms.Button();
            this.cbPort = new System.Windows.Forms.ComboBox();
            this.cbBaud = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.bXdown = new System.Windows.Forms.Button();
            this.bXup = new System.Windows.Forms.Button();
            this.bYup = new System.Windows.Forms.Button();
            this.bYdown = new System.Windows.Forms.Button();
            this.btnLaserOn = new System.Windows.Forms.Button();
            this.btsLaserOff = new System.Windows.Forms.Button();
            this.btnCustom1 = new System.Windows.Forms.Button();
            this.btnUnlock = new System.Windows.Forms.Button();
            this.tbFile = new System.Windows.Forms.TextBox();
            this.bOpenfile = new System.Windows.Forms.Button();
            this.bStart = new System.Windows.Forms.Button();
            this.bSendCmd = new System.Windows.Forms.Button();
            this.bHome = new System.Windows.Forms.Button();
            this.tbStepSize = new System.Windows.Forms.TextBox();
            this.pbFile = new System.Windows.Forms.ProgressBar();
            this.pbBufer = new System.Windows.Forms.ProgressBar();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCustom2 = new System.Windows.Forms.Button();
            this.tbCustom1 = new System.Windows.Forms.TextBox();
            this.tbCustom2 = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.RadioButton();
            this.button19 = new System.Windows.Forms.RadioButton();
            this.button20 = new System.Windows.Forms.RadioButton();
            this.button21 = new System.Windows.Forms.RadioButton();
            this.button22 = new System.Windows.Forms.RadioButton();
            this.gbJog = new System.Windows.Forms.GroupBox();
            this.chkAbsolute = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnZdown = new System.Windows.Forms.Button();
            this.btnZup = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bEdit = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.axisMillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.axisLaserPWRSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.axisLaserPWRZToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.axisLaserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restoreSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblRemaining = new System.Windows.Forms.Label();
            this.lblBuf = new System.Windows.Forms.Label();
            this.lblFileProgress = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblElapsed = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbLaserPwr = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tmrUpdates = new System.Windows.Forms.Timer(this.components);
            this.gbConecction = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bRefreshport = new System.Windows.Forms.Button();
            this.gbLaserControl = new System.Windows.Forms.GroupBox();
            this.btnLaserPwr = new System.Windows.Forms.Button();
            this.tbCommand = new System.Windows.Forms.TextBox();
            this.gbConsole = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.btlClearLog = new System.Windows.Forms.Button();
            this.gbReference = new System.Windows.Forms.GroupBox();
            this.btnZeroZ = new System.Windows.Forms.Button();
            this.btnZeroXY = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblWPos = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblWPosX = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblWPosY = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblWPosZ = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel8 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblMPosX = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblMPosY = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblMPosZ = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.mnuFile = new System.Windows.Forms.MenuItem();
            this.mnuFileOpen = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.mnuFileExit = new System.Windows.Forms.MenuItem();
            this.mnuMode = new System.Windows.Forms.MenuItem();
            this.mnuModeMill = new System.Windows.Forms.MenuItem();
            this.mnuModeLaserS = new System.Windows.Forms.MenuItem();
            this.mnuModeLaserZ = new System.Windows.Forms.MenuItem();
            this.mnuModeLaser = new System.Windows.Forms.MenuItem();
            this.mnuSettings = new System.Windows.Forms.MenuItem();
            this.mnuSettingsStoreZ = new System.Windows.Forms.MenuItem();
            this.mnuSettingsStoreXY = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.mnuSettingsRestore = new System.Windows.Forms.MenuItem();
            this.mnuHelp = new System.Windows.Forms.MenuItem();
            this.mnuHelpAbout = new System.Windows.Forms.MenuItem();
            this.gbJog.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.gbConecction.SuspendLayout();
            this.gbLaserControl.SuspendLayout();
            this.gbConsole.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbReference.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bOpenPort
            // 
            resources.ApplyResources(this.bOpenPort, "bOpenPort");
            this.bOpenPort.Name = "bOpenPort";
            this.bOpenPort.UseVisualStyleBackColor = true;
            this.bOpenPort.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbPort
            // 
            resources.ApplyResources(this.cbPort, "cbPort");
            this.cbPort.FormattingEnabled = true;
            this.cbPort.Name = "cbPort";
            // 
            // cbBaud
            // 
            resources.ApplyResources(this.cbBaud, "cbBaud");
            this.cbBaud.FormattingEnabled = true;
            this.cbBaud.Items.AddRange(new object[] {
            resources.GetString("cbBaud.Items"),
            resources.GetString("cbBaud.Items1"),
            resources.GetString("cbBaud.Items2"),
            resources.GetString("cbBaud.Items3"),
            resources.GetString("cbBaud.Items4")});
            this.cbBaud.Name = "cbBaud";
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            this.serialPort1.ReadBufferSize = 2048;
            this.serialPort1.ReadTimeout = 3000;
            this.serialPort1.WriteTimeout = 3000;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // bXdown
            // 
            resources.ApplyResources(this.bXdown, "bXdown");
            this.bXdown.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bXdown.Name = "bXdown";
            this.bXdown.UseVisualStyleBackColor = false;
            this.bXdown.Click += new System.EventHandler(this.bXdown_Click);
            // 
            // bXup
            // 
            resources.ApplyResources(this.bXup, "bXup");
            this.bXup.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bXup.Name = "bXup";
            this.bXup.UseVisualStyleBackColor = false;
            this.bXup.Click += new System.EventHandler(this.bXup_Click);
            // 
            // bYup
            // 
            resources.ApplyResources(this.bYup, "bYup");
            this.bYup.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bYup.Name = "bYup";
            this.bYup.UseVisualStyleBackColor = false;
            this.bYup.Click += new System.EventHandler(this.bYup_Click);
            // 
            // bYdown
            // 
            resources.ApplyResources(this.bYdown, "bYdown");
            this.bYdown.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bYdown.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bYdown.Name = "bYdown";
            this.bYdown.UseVisualStyleBackColor = false;
            this.bYdown.Click += new System.EventHandler(this.bYdown_Click);
            // 
            // btnLaserOn
            // 
            resources.ApplyResources(this.btnLaserOn, "btnLaserOn");
            this.btnLaserOn.Name = "btnLaserOn";
            this.btnLaserOn.UseVisualStyleBackColor = false;
            this.btnLaserOn.Click += new System.EventHandler(this.btnLaserOn_Click);
            // 
            // btsLaserOff
            // 
            resources.ApplyResources(this.btsLaserOff, "btsLaserOff");
            this.btsLaserOff.Name = "btsLaserOff";
            this.btsLaserOff.UseVisualStyleBackColor = false;
            this.btsLaserOff.Click += new System.EventHandler(this.btsLaserOff_Click);
            // 
            // btnCustom1
            // 
            resources.ApplyResources(this.btnCustom1, "btnCustom1");
            this.btnCustom1.Name = "btnCustom1";
            this.btnCustom1.UseVisualStyleBackColor = true;
            this.btnCustom1.Click += new System.EventHandler(this.btnCustom1_Click);
            // 
            // btnUnlock
            // 
            resources.ApplyResources(this.btnUnlock, "btnUnlock");
            this.btnUnlock.Name = "btnUnlock";
            this.btnUnlock.UseVisualStyleBackColor = false;
            this.btnUnlock.Click += new System.EventHandler(this.button11_Click);
            // 
            // tbFile
            // 
            resources.ApplyResources(this.tbFile, "tbFile");
            this.tbFile.Name = "tbFile";
            // 
            // bOpenfile
            // 
            resources.ApplyResources(this.bOpenfile, "bOpenfile");
            this.bOpenfile.Name = "bOpenfile";
            this.bOpenfile.Click += new System.EventHandler(this.bOpenfile_Click);
            // 
            // bStart
            // 
            resources.ApplyResources(this.bStart, "bStart");
            this.bStart.Name = "bStart";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.bStar_Click);
            // 
            // bSendCmd
            // 
            resources.ApplyResources(this.bSendCmd, "bSendCmd");
            this.bSendCmd.Name = "bSendCmd";
            this.bSendCmd.UseVisualStyleBackColor = true;
            this.bSendCmd.Click += new System.EventHandler(this.bSendCmd_Click);
            // 
            // bHome
            // 
            resources.ApplyResources(this.bHome, "bHome");
            this.bHome.Name = "bHome";
            this.bHome.UseVisualStyleBackColor = false;
            this.bHome.Click += new System.EventHandler(this.bHome_Click);
            // 
            // tbStepSize
            // 
            resources.ApplyResources(this.tbStepSize, "tbStepSize");
            this.tbStepSize.Name = "tbStepSize";
            this.tbStepSize.TextChanged += new System.EventHandler(this.tbStepSize_TextChanged);
            // 
            // pbFile
            // 
            resources.ApplyResources(this.pbFile, "pbFile");
            this.pbFile.Name = "pbFile";
            this.pbFile.Step = 1;
            this.pbFile.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // pbBufer
            // 
            resources.ApplyResources(this.pbBufer, "pbBufer");
            this.pbBufer.BackColor = System.Drawing.SystemColors.Control;
            this.pbBufer.Name = "pbBufer";
            this.pbBufer.Step = 1;
            this.pbBufer.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // btnCustom2
            // 
            resources.ApplyResources(this.btnCustom2, "btnCustom2");
            this.btnCustom2.Name = "btnCustom2";
            this.btnCustom2.UseVisualStyleBackColor = true;
            this.btnCustom2.Click += new System.EventHandler(this.btnCustom2_Click);
            // 
            // tbCustom1
            // 
            resources.ApplyResources(this.tbCustom1, "tbCustom1");
            this.tbCustom1.Name = "tbCustom1";
            this.tbCustom1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCustom1_KeyPress);
            // 
            // tbCustom2
            // 
            resources.ApplyResources(this.tbCustom2, "tbCustom2");
            this.tbCustom2.Name = "tbCustom2";
            this.tbCustom2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCustom2_KeyPress);
            // 
            // btnReset
            // 
            resources.ApplyResources(this.btnReset, "btnReset");
            this.btnReset.BackColor = System.Drawing.Color.Red;
            this.btnReset.ForeColor = System.Drawing.Color.Yellow;
            this.btnReset.Name = "btnReset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.button5_Click);
            // 
            // button12
            // 
            resources.ApplyResources(this.button12, "button12");
            this.button12.AutoCheck = false;
            this.button12.Name = "button12";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.btnStepClick);
            // 
            // button19
            // 
            resources.ApplyResources(this.button19, "button19");
            this.button19.AutoCheck = false;
            this.button19.Name = "button19";
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.btnStepClick);
            // 
            // button20
            // 
            resources.ApplyResources(this.button20, "button20");
            this.button20.AutoCheck = false;
            this.button20.Name = "button20";
            this.button20.UseVisualStyleBackColor = false;
            this.button20.Click += new System.EventHandler(this.btnStepClick);
            // 
            // button21
            // 
            resources.ApplyResources(this.button21, "button21");
            this.button21.AutoCheck = false;
            this.button21.Name = "button21";
            this.button21.UseVisualStyleBackColor = false;
            this.button21.Click += new System.EventHandler(this.btnStepClick);
            // 
            // button22
            // 
            resources.ApplyResources(this.button22, "button22");
            this.button22.AutoCheck = false;
            this.button22.Name = "button22";
            this.button22.UseVisualStyleBackColor = false;
            this.button22.Click += new System.EventHandler(this.btnStepClick);
            // 
            // gbJog
            // 
            resources.ApplyResources(this.gbJog, "gbJog");
            this.gbJog.BackColor = System.Drawing.SystemColors.Control;
            this.gbJog.Controls.Add(this.chkAbsolute);
            this.gbJog.Controls.Add(this.label9);
            this.gbJog.Controls.Add(this.label6);
            this.gbJog.Controls.Add(this.btnZdown);
            this.gbJog.Controls.Add(this.btnZup);
            this.gbJog.Controls.Add(this.button1);
            this.gbJog.Controls.Add(this.button22);
            this.gbJog.Controls.Add(this.button21);
            this.gbJog.Controls.Add(this.button20);
            this.gbJog.Controls.Add(this.button19);
            this.gbJog.Controls.Add(this.button12);
            this.gbJog.Controls.Add(this.tbStepSize);
            this.gbJog.Controls.Add(this.bYdown);
            this.gbJog.Controls.Add(this.bYup);
            this.gbJog.Controls.Add(this.bXup);
            this.gbJog.Controls.Add(this.bXdown);
            this.gbJog.Name = "gbJog";
            this.gbJog.TabStop = false;
            // 
            // chkAbsolute
            // 
            resources.ApplyResources(this.chkAbsolute, "chkAbsolute");
            this.chkAbsolute.Name = "chkAbsolute";
            this.chkAbsolute.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // btnZdown
            // 
            resources.ApplyResources(this.btnZdown, "btnZdown");
            this.btnZdown.BackColor = System.Drawing.SystemColors.Control;
            this.btnZdown.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnZdown.Name = "btnZdown";
            this.btnZdown.UseVisualStyleBackColor = false;
            this.btnZdown.Click += new System.EventHandler(this.btnZdown_Click);
            // 
            // btnZup
            // 
            resources.ApplyResources(this.btnZup, "btnZup");
            this.btnZup.BackColor = System.Drawing.SystemColors.Control;
            this.btnZup.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnZup.Name = "btnZup";
            this.btnZup.UseVisualStyleBackColor = false;
            this.btnZup.Click += new System.EventHandler(this.btnZup_Click);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.AutoCheck = false;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnStepClick);
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.bEdit);
            this.groupBox2.Controls.Add(this.menuStrip1);
            this.groupBox2.Controls.Add(this.lblRemaining);
            this.groupBox2.Controls.Add(this.lblBuf);
            this.groupBox2.Controls.Add(this.lblFileProgress);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.pbFile);
            this.groupBox2.Controls.Add(this.bStart);
            this.groupBox2.Controls.Add(this.bOpenfile);
            this.groupBox2.Controls.Add(this.lblElapsed);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.tbFile);
            this.groupBox2.Controls.Add(this.pbBufer);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // bEdit
            // 
            resources.ApplyResources(this.bEdit, "bEdit");
            this.bEdit.Name = "bEdit";
            this.bEdit.UseVisualStyleBackColor = true;
            this.bEdit.Click += new System.EventHandler(this.BEditClick);
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.BackColor = System.Drawing.Color.Gainsboro;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.modeToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            // 
            // openToolStripMenuItem
            // 
            resources.ApplyResources(this.openToolStripMenuItem, "openToolStripMenuItem");
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItemClick);
            // 
            // toolStripMenuItem1
            // 
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            // 
            // exitToolStripMenuItem
            // 
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
            // 
            // modeToolStripMenuItem
            // 
            resources.ApplyResources(this.modeToolStripMenuItem, "modeToolStripMenuItem");
            this.modeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.axisMillToolStripMenuItem,
            this.axisLaserPWRSToolStripMenuItem,
            this.axisLaserPWRZToolStripMenuItem,
            this.axisLaserToolStripMenuItem});
            this.modeToolStripMenuItem.Name = "modeToolStripMenuItem";
            // 
            // axisMillToolStripMenuItem
            // 
            resources.ApplyResources(this.axisMillToolStripMenuItem, "axisMillToolStripMenuItem");
            this.axisMillToolStripMenuItem.CheckOnClick = true;
            this.axisMillToolStripMenuItem.Name = "axisMillToolStripMenuItem";
            this.axisMillToolStripMenuItem.Click += new System.EventHandler(this.axisMillToolStripMenuItem_Click);
            // 
            // axisLaserPWRSToolStripMenuItem
            // 
            resources.ApplyResources(this.axisLaserPWRSToolStripMenuItem, "axisLaserPWRSToolStripMenuItem");
            this.axisLaserPWRSToolStripMenuItem.Checked = true;
            this.axisLaserPWRSToolStripMenuItem.CheckOnClick = true;
            this.axisLaserPWRSToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.axisLaserPWRSToolStripMenuItem.Name = "axisLaserPWRSToolStripMenuItem";
            this.axisLaserPWRSToolStripMenuItem.Click += new System.EventHandler(this.axisLaserPWRSToolStripMenuItem_Click);
            // 
            // axisLaserPWRZToolStripMenuItem
            // 
            resources.ApplyResources(this.axisLaserPWRZToolStripMenuItem, "axisLaserPWRZToolStripMenuItem");
            this.axisLaserPWRZToolStripMenuItem.CheckOnClick = true;
            this.axisLaserPWRZToolStripMenuItem.Name = "axisLaserPWRZToolStripMenuItem";
            this.axisLaserPWRZToolStripMenuItem.Click += new System.EventHandler(this.axisLaserPWRZToolStripMenuItem_Click);
            // 
            // axisLaserToolStripMenuItem
            // 
            resources.ApplyResources(this.axisLaserToolStripMenuItem, "axisLaserToolStripMenuItem");
            this.axisLaserToolStripMenuItem.CheckOnClick = true;
            this.axisLaserToolStripMenuItem.Name = "axisLaserToolStripMenuItem";
            this.axisLaserToolStripMenuItem.Click += new System.EventHandler(this.axisLaserToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            resources.ApplyResources(this.settingsToolStripMenuItem, "settingsToolStripMenuItem");
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restoreSettingsToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            // 
            // restoreSettingsToolStripMenuItem
            // 
            resources.ApplyResources(this.restoreSettingsToolStripMenuItem, "restoreSettingsToolStripMenuItem");
            this.restoreSettingsToolStripMenuItem.Name = "restoreSettingsToolStripMenuItem";
            this.restoreSettingsToolStripMenuItem.Click += new System.EventHandler(this.restoreSettingsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            // 
            // aboutToolStripMenuItem
            // 
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // lblRemaining
            // 
            resources.ApplyResources(this.lblRemaining, "lblRemaining");
            this.lblRemaining.ForeColor = System.Drawing.Color.Red;
            this.lblRemaining.Name = "lblRemaining";
            // 
            // lblBuf
            // 
            resources.ApplyResources(this.lblBuf, "lblBuf");
            this.lblBuf.Name = "lblBuf";
            // 
            // lblFileProgress
            // 
            resources.ApplyResources(this.lblFileProgress, "lblFileProgress");
            this.lblFileProgress.BackColor = System.Drawing.Color.Transparent;
            this.lblFileProgress.Name = "lblFileProgress";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // lblElapsed
            // 
            resources.ApplyResources(this.lblElapsed, "lblElapsed");
            this.lblElapsed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblElapsed.Name = "lblElapsed";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // tbLaserPwr
            // 
            resources.ApplyResources(this.tbLaserPwr, "tbLaserPwr");
            this.tbLaserPwr.Name = "tbLaserPwr";
            this.tbLaserPwr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbLaserPwr_KeyPress);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            resources.ApplyResources(this.openFileDialog1, "openFileDialog1");
            // 
            // tmrUpdates
            // 
            this.tmrUpdates.Enabled = true;
            this.tmrUpdates.Interval = 500;
            this.tmrUpdates.Tick += new System.EventHandler(this.tmrUpdates_Tick);
            // 
            // gbConecction
            // 
            resources.ApplyResources(this.gbConecction, "gbConecction");
            this.gbConecction.Controls.Add(this.label5);
            this.gbConecction.Controls.Add(this.label4);
            this.gbConecction.Controls.Add(this.bRefreshport);
            this.gbConecction.Controls.Add(this.cbBaud);
            this.gbConecction.Controls.Add(this.cbPort);
            this.gbConecction.Controls.Add(this.bOpenPort);
            this.gbConecction.Name = "gbConecction";
            this.gbConecction.TabStop = false;
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // bRefreshport
            // 
            resources.ApplyResources(this.bRefreshport, "bRefreshport");
            this.bRefreshport.BackgroundImage = global::_3dpBurner.Properties.Resources.refresh;
            this.bRefreshport.Name = "bRefreshport";
            this.bRefreshport.UseVisualStyleBackColor = true;
            this.bRefreshport.Click += new System.EventHandler(this.bRefreshport_Click);
            // 
            // gbLaserControl
            // 
            resources.ApplyResources(this.gbLaserControl, "gbLaserControl");
            this.gbLaserControl.Controls.Add(this.btnLaserPwr);
            this.gbLaserControl.Controls.Add(this.tbLaserPwr);
            this.gbLaserControl.Controls.Add(this.btsLaserOff);
            this.gbLaserControl.Controls.Add(this.btnLaserOn);
            this.gbLaserControl.Name = "gbLaserControl";
            this.gbLaserControl.TabStop = false;
            // 
            // btnLaserPwr
            // 
            resources.ApplyResources(this.btnLaserPwr, "btnLaserPwr");
            this.btnLaserPwr.Name = "btnLaserPwr";
            this.btnLaserPwr.UseVisualStyleBackColor = false;
            this.btnLaserPwr.Click += new System.EventHandler(this.btnLaserPwr_Click);
            // 
            // tbCommand
            // 
            resources.ApplyResources(this.tbCommand, "tbCommand");
            this.tbCommand.Name = "tbCommand";
            this.tbCommand.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCommand_KeyPress);
            // 
            // gbConsole
            // 
            resources.ApplyResources(this.gbConsole, "gbConsole");
            this.gbConsole.Controls.Add(this.btnCustom2);
            this.gbConsole.Controls.Add(this.label3);
            this.gbConsole.Controls.Add(this.btnCustom1);
            this.gbConsole.Controls.Add(this.label2);
            this.gbConsole.Controls.Add(this.tbCustom2);
            this.gbConsole.Controls.Add(this.panel1);
            this.gbConsole.Controls.Add(this.tbCustom1);
            this.gbConsole.Controls.Add(this.btlClearLog);
            this.gbConsole.Controls.Add(this.bSendCmd);
            this.gbConsole.Controls.Add(this.tbCommand);
            this.gbConsole.Name = "gbConsole";
            this.gbConsole.TabStop = false;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.rtbLog);
            this.panel1.Name = "panel1";
            // 
            // rtbLog
            // 
            resources.ApplyResources(this.rtbLog, "rtbLog");
            this.rtbLog.BackColor = System.Drawing.SystemColors.Window;
            this.rtbLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbLog.DetectUrls = false;
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.ReadOnly = true;
            // 
            // btlClearLog
            // 
            resources.ApplyResources(this.btlClearLog, "btlClearLog");
            this.btlClearLog.Name = "btlClearLog";
            this.btlClearLog.UseVisualStyleBackColor = true;
            this.btlClearLog.Click += new System.EventHandler(this.btlClearLog_Click);
            // 
            // gbReference
            // 
            resources.ApplyResources(this.gbReference, "gbReference");
            this.gbReference.Controls.Add(this.btnZeroZ);
            this.gbReference.Controls.Add(this.btnZeroXY);
            this.gbReference.Controls.Add(this.btnZero);
            this.gbReference.Controls.Add(this.bHome);
            this.gbReference.Controls.Add(this.btnUnlock);
            this.gbReference.Controls.Add(this.btnReset);
            this.gbReference.Name = "gbReference";
            this.gbReference.TabStop = false;
            // 
            // btnZeroZ
            // 
            resources.ApplyResources(this.btnZeroZ, "btnZeroZ");
            this.btnZeroZ.Name = "btnZeroZ";
            this.btnZeroZ.UseVisualStyleBackColor = false;
            this.btnZeroZ.Click += new System.EventHandler(this.btnZeroZ_Click);
            // 
            // btnZeroXY
            // 
            resources.ApplyResources(this.btnZeroXY, "btnZeroXY");
            this.btnZeroXY.Name = "btnZeroXY";
            this.btnZeroXY.UseVisualStyleBackColor = false;
            this.btnZeroXY.Click += new System.EventHandler(this.btnZeroXY_Click);
            // 
            // btnZero
            // 
            resources.ApplyResources(this.btnZero, "btnZero");
            this.btnZero.Name = "btnZero";
            this.btnZero.UseVisualStyleBackColor = false;
            this.btnZero.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // statusStrip1
            // 
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel1,
            this.lblStatus,
            this.toolStripStatusLabel3,
            this.lblWPos,
            this.lblWPosX,
            this.lblWPosY,
            this.lblWPosZ,
            this.toolStripStatusLabel8,
            this.lblMPosX,
            this.lblMPosY,
            this.lblMPosZ});
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.ShowItemToolTips = true;
            this.statusStrip1.SizingGrip = false;
            // 
            // toolStripStatusLabel2
            // 
            resources.ApplyResources(this.toolStripStatusLabel2, "toolStripStatusLabel2");
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            // 
            // toolStripStatusLabel1
            // 
            resources.ApplyResources(this.toolStripStatusLabel1, "toolStripStatusLabel1");
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            // 
            // lblStatus
            // 
            resources.ApplyResources(this.lblStatus, "lblStatus");
            this.lblStatus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Spring = true;
            // 
            // toolStripStatusLabel3
            // 
            resources.ApplyResources(this.toolStripStatusLabel3, "toolStripStatusLabel3");
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            // 
            // lblWPos
            // 
            resources.ApplyResources(this.lblWPos, "lblWPos");
            this.lblWPos.AutoToolTip = true;
            this.lblWPos.Name = "lblWPos";
            this.lblWPos.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            // 
            // lblWPosX
            // 
            resources.ApplyResources(this.lblWPosX, "lblWPosX");
            this.lblWPosX.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lblWPosX.Name = "lblWPosX";
            this.lblWPosX.Spring = true;
            // 
            // lblWPosY
            // 
            resources.ApplyResources(this.lblWPosY, "lblWPosY");
            this.lblWPosY.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lblWPosY.Name = "lblWPosY";
            this.lblWPosY.Spring = true;
            // 
            // lblWPosZ
            // 
            resources.ApplyResources(this.lblWPosZ, "lblWPosZ");
            this.lblWPosZ.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lblWPosZ.Name = "lblWPosZ";
            this.lblWPosZ.Spring = true;
            // 
            // toolStripStatusLabel8
            // 
            resources.ApplyResources(this.toolStripStatusLabel8, "toolStripStatusLabel8");
            this.toolStripStatusLabel8.AutoToolTip = true;
            this.toolStripStatusLabel8.Name = "toolStripStatusLabel8";
            this.toolStripStatusLabel8.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            // 
            // lblMPosX
            // 
            resources.ApplyResources(this.lblMPosX, "lblMPosX");
            this.lblMPosX.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lblMPosX.Name = "lblMPosX";
            this.lblMPosX.Spring = true;
            // 
            // lblMPosY
            // 
            resources.ApplyResources(this.lblMPosY, "lblMPosY");
            this.lblMPosY.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lblMPosY.Name = "lblMPosY";
            this.lblMPosY.Spring = true;
            // 
            // lblMPosZ
            // 
            resources.ApplyResources(this.lblMPosZ, "lblMPosZ");
            this.lblMPosZ.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lblMPosZ.Name = "lblMPosZ";
            this.lblMPosZ.Spring = true;
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuFile,
            this.mnuMode,
            this.mnuSettings,
            this.mnuHelp});
            resources.ApplyResources(this.mainMenu1, "mainMenu1");
            // 
            // mnuFile
            // 
            resources.ApplyResources(this.mnuFile, "mnuFile");
            this.mnuFile.Index = 0;
            this.mnuFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuFileOpen,
            this.menuItem3,
            this.mnuFileExit});
            // 
            // mnuFileOpen
            // 
            resources.ApplyResources(this.mnuFileOpen, "mnuFileOpen");
            this.mnuFileOpen.Index = 0;
            this.mnuFileOpen.Click += new System.EventHandler(this.OpenToolStripMenuItemClick);
            // 
            // menuItem3
            // 
            resources.ApplyResources(this.menuItem3, "menuItem3");
            this.menuItem3.Index = 1;
            // 
            // mnuFileExit
            // 
            resources.ApplyResources(this.mnuFileExit, "mnuFileExit");
            this.mnuFileExit.Index = 2;
            this.mnuFileExit.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
            // 
            // mnuMode
            // 
            resources.ApplyResources(this.mnuMode, "mnuMode");
            this.mnuMode.Index = 1;
            this.mnuMode.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuModeMill,
            this.mnuModeLaserS,
            this.mnuModeLaserZ,
            this.mnuModeLaser});
            this.mnuMode.RadioCheck = true;
            // 
            // mnuModeMill
            // 
            resources.ApplyResources(this.mnuModeMill, "mnuModeMill");
            this.mnuModeMill.Index = 0;
            this.mnuModeMill.RadioCheck = true;
            this.mnuModeMill.Click += new System.EventHandler(this.axisMillToolStripMenuItem_Click);
            // 
            // mnuModeLaserS
            // 
            resources.ApplyResources(this.mnuModeLaserS, "mnuModeLaserS");
            this.mnuModeLaserS.Index = 1;
            this.mnuModeLaserS.RadioCheck = true;
            this.mnuModeLaserS.Click += new System.EventHandler(this.axisLaserPWRSToolStripMenuItem_Click);
            // 
            // mnuModeLaserZ
            // 
            resources.ApplyResources(this.mnuModeLaserZ, "mnuModeLaserZ");
            this.mnuModeLaserZ.Index = 2;
            this.mnuModeLaserZ.RadioCheck = true;
            this.mnuModeLaserZ.Click += new System.EventHandler(this.axisLaserPWRZToolStripMenuItem_Click);
            // 
            // mnuModeLaser
            // 
            resources.ApplyResources(this.mnuModeLaser, "mnuModeLaser");
            this.mnuModeLaser.Index = 3;
            this.mnuModeLaser.RadioCheck = true;
            this.mnuModeLaser.Click += new System.EventHandler(this.axisLaserToolStripMenuItem_Click);
            // 
            // mnuSettings
            // 
            resources.ApplyResources(this.mnuSettings, "mnuSettings");
            this.mnuSettings.Index = 2;
            this.mnuSettings.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuSettingsStoreZ,
            this.mnuSettingsStoreXY,
            this.menuItem2,
            this.mnuSettingsRestore});
            // 
            // mnuSettingsStoreZ
            // 
            resources.ApplyResources(this.mnuSettingsStoreZ, "mnuSettingsStoreZ");
            this.mnuSettingsStoreZ.Index = 0;
            this.mnuSettingsStoreZ.Click += new System.EventHandler(this.mnuSettingsStoreZ_Click);
            // 
            // mnuSettingsStoreXY
            // 
            resources.ApplyResources(this.mnuSettingsStoreXY, "mnuSettingsStoreXY");
            this.mnuSettingsStoreXY.Index = 1;
            this.mnuSettingsStoreXY.Click += new System.EventHandler(this.mnuSettingsStoreXY_Click);
            // 
            // menuItem2
            // 
            resources.ApplyResources(this.menuItem2, "menuItem2");
            this.menuItem2.Index = 2;
            // 
            // mnuSettingsRestore
            // 
            resources.ApplyResources(this.mnuSettingsRestore, "mnuSettingsRestore");
            this.mnuSettingsRestore.Index = 3;
            this.mnuSettingsRestore.Click += new System.EventHandler(this.restoreSettingsToolStripMenuItem_Click);
            // 
            // mnuHelp
            // 
            resources.ApplyResources(this.mnuHelp, "mnuHelp");
            this.mnuHelp.Index = 3;
            this.mnuHelp.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuHelpAbout});
            // 
            // mnuHelpAbout
            // 
            resources.ApplyResources(this.mnuHelpAbout, "mnuHelpAbout");
            this.mnuHelpAbout.Index = 0;
            this.mnuHelpAbout.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // frm3dpBurner
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.gbLaserControl);
            this.Controls.Add(this.gbReference);
            this.Controls.Add(this.gbConsole);
            this.Controls.Add(this.gbConecction);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbJog);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Menu = this.mainMenu1;
            this.Name = "frm3dpBurner";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm3dpBurner_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbJog.ResumeLayout(false);
            this.gbJog.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbConecction.ResumeLayout(false);
            this.gbConecction.PerformLayout();
            this.gbLaserControl.ResumeLayout(false);
            this.gbLaserControl.PerformLayout();
            this.gbConsole.ResumeLayout(false);
            this.gbConsole.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.gbReference.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.CheckBox chkAbsolute;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
                      
        #endregion
        
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button bOpenPort;
        private System.Windows.Forms.ComboBox cbPort;
        private System.Windows.Forms.ComboBox cbBaud;
		private System.Windows.Forms.Button bXup;
        private System.Windows.Forms.Button bYup;
        private System.Windows.Forms.Button bXdown;
        private System.Windows.Forms.Button bYdown;
        private System.Windows.Forms.Button btnLaserOn;
        private System.Windows.Forms.Button btsLaserOff;
        private System.Windows.Forms.Button btnCustom1;
        private System.Windows.Forms.Button btnUnlock;
        private System.Windows.Forms.TextBox tbFile;
        private System.Windows.Forms.Button bOpenfile;
        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.Button bSendCmd;
        private System.Windows.Forms.Button bHome;
        private System.Windows.Forms.TextBox tbStepSize;
        private System.Windows.Forms.ProgressBar pbFile;
        private System.Windows.Forms.ProgressBar pbBufer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCustom2;
        private System.Windows.Forms.TextBox tbCustom1;
        private System.Windows.Forms.TextBox tbCustom2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.RadioButton button12;
        private System.Windows.Forms.RadioButton button19;
        private System.Windows.Forms.RadioButton button20;
        private System.Windows.Forms.RadioButton button21;
        private System.Windows.Forms.RadioButton button22;
        private System.Windows.Forms.GroupBox gbJog;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbLaserPwr;
        private System.Windows.Forms.Button bRefreshport;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblFileProgress;
        private System.Windows.Forms.Label lblElapsed;
        private System.Windows.Forms.Timer tmrUpdates;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gbConecction;
        private System.Windows.Forms.RadioButton button1;
        private System.Windows.Forms.GroupBox gbLaserControl;
        private System.Windows.Forms.TextBox tbCommand;
        private System.Windows.Forms.GroupBox gbConsole;
        private System.Windows.Forms.GroupBox gbReference;
        private System.Windows.Forms.Button btnLaserPwr;
        private System.Windows.Forms.Button btlClearLog;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.Label lblBuf;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btnZdown;
        private System.Windows.Forms.Button btnZup;
        private System.Windows.Forms.Button btnZeroZ;
        private System.Windows.Forms.Button btnZeroXY;
        private System.Windows.Forms.ToolStripMenuItem modeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem axisMillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem axisLaserPWRSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem axisLaserPWRZToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem axisLaserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restoreSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Label lblRemaining;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripStatusLabel lblWPos;
        private System.Windows.Forms.ToolStripStatusLabel lblWPosX;
        private System.Windows.Forms.ToolStripStatusLabel lblWPosY;
        private System.Windows.Forms.ToolStripStatusLabel lblWPosZ;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel8;
        private System.Windows.Forms.ToolStripStatusLabel lblMPosX;
        private System.Windows.Forms.ToolStripStatusLabel lblMPosY;
        private System.Windows.Forms.ToolStripStatusLabel lblMPosZ;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button bEdit;
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem mnuFile;
        private System.Windows.Forms.MenuItem mnuFileOpen;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem mnuFileExit;
        private System.Windows.Forms.MenuItem mnuMode;
        private System.Windows.Forms.MenuItem mnuModeMill;
        private System.Windows.Forms.MenuItem mnuModeLaserS;
        private System.Windows.Forms.MenuItem mnuModeLaserZ;
        private System.Windows.Forms.MenuItem mnuModeLaser;
        private System.Windows.Forms.MenuItem mnuSettings;
        private System.Windows.Forms.MenuItem mnuSettingsRestore;
        private System.Windows.Forms.MenuItem mnuHelp;
        private System.Windows.Forms.MenuItem mnuHelpAbout;
        private System.Windows.Forms.MenuItem mnuSettingsStoreXY;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem mnuSettingsStoreZ;
    }
}