using System;
using System.Windows.Forms;
using System.ComponentModel;

namespace Discord
{
    partial class Form1
    {
        private IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.selectOS = new System.Windows.Forms.ComboBox();
            this.osLabel = new System.Windows.Forms.Label();
            this.channelLabel = new System.Windows.Forms.Label();
            this.selectChannel = new System.Windows.Forms.ComboBox();
            this.downloadbutton = new System.Windows.Forms.Button();
            this.logBox = new System.Windows.Forms.TextBox();
            this.downloadLabel = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.logLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.formatLabel = new System.Windows.Forms.Label();
            this.selectFormat = new System.Windows.Forms.ComboBox();
            this.archLabel = new System.Windows.Forms.Label();
            this.selectArch = new System.Windows.Forms.ComboBox();
            this.langLabel = new System.Windows.Forms.Label();
            this.turkishCheck = new System.Windows.Forms.CheckBox();
            this.englishCheck = new System.Windows.Forms.CheckBox();
            this.versionTitleLabel = new System.Windows.Forms.Label();
            this.darkMode = new System.Windows.Forms.CheckBox();
            this.lightMode = new System.Windows.Forms.CheckBox();
            this.darkLightLabel = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // selectOS
            // 
            this.selectOS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectOS.FormattingEnabled = true;
            this.selectOS.Items.AddRange(new object[] {
            resources.GetString("selectOS.Items"),
            resources.GetString("selectOS.Items1"),
            resources.GetString("selectOS.Items2")});
            resources.ApplyResources(this.selectOS, "selectOS");
            this.selectOS.Name = "selectOS";
            this.selectOS.SelectedIndexChanged += new System.EventHandler(this.selectOS_SelectedIndexChanged);
            // 
            // osLabel
            // 
            resources.ApplyResources(this.osLabel, "osLabel");
            this.osLabel.Name = "osLabel";
            // 
            // channelLabel
            // 
            resources.ApplyResources(this.channelLabel, "channelLabel");
            this.channelLabel.Name = "channelLabel";
            // 
            // selectChannel
            // 
            this.selectChannel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectChannel.FormattingEnabled = true;
            this.selectChannel.Items.AddRange(new object[] {
            resources.GetString("selectChannel.Items"),
            resources.GetString("selectChannel.Items1"),
            resources.GetString("selectChannel.Items2"),
            resources.GetString("selectChannel.Items3")});
            resources.ApplyResources(this.selectChannel, "selectChannel");
            this.selectChannel.Name = "selectChannel";
            this.selectChannel.SelectedIndexChanged += new System.EventHandler(this.selectChannel_SelectedIndexChanged);
            // 
            // downloadbutton
            // 
            resources.ApplyResources(this.downloadbutton, "downloadbutton");
            this.downloadbutton.Name = "downloadbutton";
            this.downloadbutton.UseVisualStyleBackColor = true;
            this.downloadbutton.Click += new System.EventHandler(this.downloadbutton_Click);
            // 
            // logBox
            // 
            resources.ApplyResources(this.logBox, "logBox");
            this.logBox.Name = "logBox";
            // 
            // downloadLabel
            // 
            resources.ApplyResources(this.downloadLabel, "downloadLabel");
            this.downloadLabel.Name = "downloadLabel";
            this.downloadLabel.TabStop = true;
            this.downloadLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // logLabel
            // 
            resources.ApplyResources(this.logLabel, "logLabel");
            this.logLabel.Name = "logLabel";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // formatLabel
            // 
            resources.ApplyResources(this.formatLabel, "formatLabel");
            this.formatLabel.Name = "formatLabel";
            // 
            // selectFormat
            // 
            this.selectFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectFormat.FormattingEnabled = true;
            this.selectFormat.Items.AddRange(new object[] {
            resources.GetString("selectFormat.Items"),
            resources.GetString("selectFormat.Items1")});
            resources.ApplyResources(this.selectFormat, "selectFormat");
            this.selectFormat.Name = "selectFormat";
            // 
            // archLabel
            // 
            resources.ApplyResources(this.archLabel, "archLabel");
            this.archLabel.Name = "archLabel";
            // 
            // selectArch
            // 
            this.selectArch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectArch.FormattingEnabled = true;
            this.selectArch.Items.AddRange(new object[] {
            resources.GetString("selectArch.Items")});
            resources.ApplyResources(this.selectArch, "selectArch");
            this.selectArch.Name = "selectArch";
            // 
            // langLabel
            // 
            resources.ApplyResources(this.langLabel, "langLabel");
            this.langLabel.Name = "langLabel";
            // 
            // turkishCheck
            // 
            resources.ApplyResources(this.turkishCheck, "turkishCheck");
            this.turkishCheck.Name = "turkishCheck";
            this.turkishCheck.UseVisualStyleBackColor = true;
            this.turkishCheck.CheckedChanged += new System.EventHandler(this.turkishCheck_CheckedChanged);
            // 
            // englishCheck
            // 
            resources.ApplyResources(this.englishCheck, "englishCheck");
            this.englishCheck.Checked = true;
            this.englishCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.englishCheck.Name = "englishCheck";
            this.englishCheck.UseVisualStyleBackColor = true;
            this.englishCheck.CheckedChanged += new System.EventHandler(this.englishCheck_CheckedChanged);
            // 
            // versionTitleLabel
            // 
            resources.ApplyResources(this.versionTitleLabel, "versionTitleLabel");
            this.versionTitleLabel.Name = "versionTitleLabel";
            // 
            // darkMode
            // 
            resources.ApplyResources(this.darkMode, "darkMode");
            this.darkMode.Checked = true;
            this.darkMode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.darkMode.Name = "darkMode";
            this.darkMode.UseVisualStyleBackColor = true;
            this.darkMode.CheckedChanged += new System.EventHandler(this.darkMode_CheckedChanged);
            // 
            // lightMode
            // 
            resources.ApplyResources(this.lightMode, "lightMode");
            this.lightMode.Name = "lightMode";
            this.lightMode.UseVisualStyleBackColor = true;
            this.lightMode.CheckedChanged += new System.EventHandler(this.lightMode_CheckedChanged);
            // 
            // darkLightLabel
            // 
            resources.ApplyResources(this.darkLightLabel, "darkLightLabel");
            this.darkLightLabel.Name = "darkLightLabel";
            // 
            // versionLabel
            // 
            resources.ApplyResources(this.versionLabel, "versionLabel");
            this.versionLabel.Name = "versionLabel";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.darkLightLabel);
            this.Controls.Add(this.lightMode);
            this.Controls.Add(this.darkMode);
            this.Controls.Add(this.versionTitleLabel);
            this.Controls.Add(this.englishCheck);
            this.Controls.Add(this.turkishCheck);
            this.Controls.Add(this.langLabel);
            this.Controls.Add(this.selectArch);
            this.Controls.Add(this.archLabel);
            this.Controls.Add(this.selectFormat);
            this.Controls.Add(this.formatLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.logLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.downloadLabel);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.downloadbutton);
            this.Controls.Add(this.selectChannel);
            this.Controls.Add(this.channelLabel);
            this.Controls.Add(this.osLabel);
            this.Controls.Add(this.selectOS);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox selectOS;
        private Label osLabel;
        private Label channelLabel;
        private ComboBox selectChannel;
        private Button downloadbutton;
        private TextBox logBox;
        private LinkLabel downloadLabel;
        private Label label3;
        private Label label5;
        private Label logLabel;
        private Label label6;
        private Label label8;
        private Label formatLabel;
        private ComboBox selectFormat;
        private ComboBox selectArch;
        private Label langLabel;
        private CheckBox turkishCheck;
        private CheckBox englishCheck;
        private Label versionTitleLabel;
        private CheckBox darkMode;
        private CheckBox lightMode;
        private Label darkLightLabel;
        private Label archLabel;
        private Label versionLabel;
    }
}