namespace DiscordURLGen
{
    partial class App
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.osLabel = new System.Windows.Forms.Label();
            this.selectOS = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.channelLabel = new System.Windows.Forms.Label();
            this.selectChannel = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.archLabel = new System.Windows.Forms.Label();
            this.selectArch = new Guna.UI2.WinForms.Guna2ComboBox();
            this.formatLabel = new System.Windows.Forms.Label();
            this.selectFormat = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.downloadButton = new Guna.UI2.WinForms.Guna2Button();
            this.createLinkButton = new Guna.UI2.WinForms.Guna2Button();
            this.versionLabel = new System.Windows.Forms.Label();
            this.vLabel = new System.Windows.Forms.Label();
            this.themeLabel = new System.Windows.Forms.Label();
            this.darkMode = new Guna.UI2.WinForms.Guna2CheckBox();
            this.lightMode = new Guna.UI2.WinForms.Guna2CheckBox();
            this.langLabel = new System.Windows.Forms.Label();
            this.turkishCheck = new Guna.UI2.WinForms.Guna2CheckBox();
            this.englishCheck = new Guna.UI2.WinForms.Guna2CheckBox();
            this.logBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "---------------------------------------------------------------------------------" +
    "----------------------------------------------------";
            // 
            // osLabel
            // 
            this.osLabel.AutoSize = true;
            this.osLabel.Location = new System.Drawing.Point(12, 37);
            this.osLabel.Name = "osLabel";
            this.osLabel.Size = new System.Drawing.Size(25, 13);
            this.osLabel.TabIndex = 1;
            this.osLabel.Text = "OS:";
            // 
            // selectOS
            // 
            this.selectOS.AutoRoundedCorners = true;
            this.selectOS.BackColor = System.Drawing.Color.Transparent;
            this.selectOS.BorderRadius = 17;
            this.selectOS.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.selectOS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectOS.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.selectOS.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.selectOS.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.selectOS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.selectOS.ItemHeight = 30;
            this.selectOS.Items.AddRange(new object[] {
            "Windows",
            "Linux",
            "MacOS"});
            this.selectOS.Location = new System.Drawing.Point(107, 25);
            this.selectOS.Name = "selectOS";
            this.selectOS.Size = new System.Drawing.Size(140, 36);
            this.selectOS.TabIndex = 2;
            this.selectOS.SelectedIndexChanged += new System.EventHandler(this.selectOS_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(406, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "---------------------------------------------------------------------------------" +
    "----------------------------------------------------";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(406, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "---------------------------------------------------------------------------------" +
    "----------------------------------------------------";
            // 
            // channelLabel
            // 
            this.channelLabel.AutoSize = true;
            this.channelLabel.Location = new System.Drawing.Point(12, 100);
            this.channelLabel.Name = "channelLabel";
            this.channelLabel.Size = new System.Drawing.Size(49, 13);
            this.channelLabel.TabIndex = 5;
            this.channelLabel.Text = "Channel:";
            // 
            // selectChannel
            // 
            this.selectChannel.AutoRoundedCorners = true;
            this.selectChannel.BackColor = System.Drawing.Color.Transparent;
            this.selectChannel.BorderRadius = 17;
            this.selectChannel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.selectChannel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectChannel.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.selectChannel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.selectChannel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.selectChannel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.selectChannel.ItemHeight = 30;
            this.selectChannel.Items.AddRange(new object[] {
            "stable",
            "ptb (beta)",
            "canary",
            "development"});
            this.selectChannel.Location = new System.Drawing.Point(107, 89);
            this.selectChannel.Name = "selectChannel";
            this.selectChannel.Size = new System.Drawing.Size(140, 36);
            this.selectChannel.TabIndex = 6;
            this.selectChannel.SelectedIndexChanged += new System.EventHandler(this.selectChannel_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(406, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "---------------------------------------------------------------------------------" +
    "----------------------------------------------------";
            // 
            // archLabel
            // 
            this.archLabel.AutoSize = true;
            this.archLabel.Location = new System.Drawing.Point(15, 177);
            this.archLabel.Name = "archLabel";
            this.archLabel.Size = new System.Drawing.Size(32, 13);
            this.archLabel.TabIndex = 8;
            this.archLabel.Text = "Arch:";
            // 
            // selectArch
            // 
            this.selectArch.AutoRoundedCorners = true;
            this.selectArch.BackColor = System.Drawing.Color.Transparent;
            this.selectArch.BorderRadius = 17;
            this.selectArch.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.selectArch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectArch.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.selectArch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.selectArch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.selectArch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.selectArch.ItemHeight = 30;
            this.selectArch.Items.AddRange(new object[] {
            "x86"});
            this.selectArch.Location = new System.Drawing.Point(108, 164);
            this.selectArch.Name = "selectArch";
            this.selectArch.Size = new System.Drawing.Size(140, 36);
            this.selectArch.TabIndex = 9;
            // 
            // formatLabel
            // 
            this.formatLabel.AutoSize = true;
            this.formatLabel.Location = new System.Drawing.Point(15, 177);
            this.formatLabel.Name = "formatLabel";
            this.formatLabel.Size = new System.Drawing.Size(42, 13);
            this.formatLabel.TabIndex = 10;
            this.formatLabel.Text = "Format:";
            // 
            // selectFormat
            // 
            this.selectFormat.AutoRoundedCorners = true;
            this.selectFormat.BackColor = System.Drawing.Color.Transparent;
            this.selectFormat.BorderRadius = 17;
            this.selectFormat.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.selectFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectFormat.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.selectFormat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.selectFormat.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.selectFormat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.selectFormat.ItemHeight = 30;
            this.selectFormat.Items.AddRange(new object[] {
            ".deb",
            ".tar.gz"});
            this.selectFormat.Location = new System.Drawing.Point(108, 164);
            this.selectFormat.Name = "selectFormat";
            this.selectFormat.Size = new System.Drawing.Size(140, 36);
            this.selectFormat.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(406, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "---------------------------------------------------------------------------------" +
    "----------------------------------------------------";
            // 
            // downloadButton
            // 
            this.downloadButton.Animated = true;
            this.downloadButton.AutoRoundedCorners = true;
            this.downloadButton.BackColor = System.Drawing.Color.Transparent;
            this.downloadButton.BorderRadius = 18;
            this.downloadButton.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.downloadButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.downloadButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.downloadButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.downloadButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.downloadButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.downloadButton.ForeColor = System.Drawing.Color.White;
            this.downloadButton.Location = new System.Drawing.Point(12, 246);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(126, 39);
            this.downloadButton.TabIndex = 13;
            this.downloadButton.Text = "Download";
            this.downloadButton.UseTransparentBackground = true;
            this.downloadButton.Click += new System.EventHandler(this.downloadButton_Clicked);
            // 
            // createLinkButton
            // 
            this.createLinkButton.Animated = true;
            this.createLinkButton.AutoRoundedCorners = true;
            this.createLinkButton.BackColor = System.Drawing.Color.Transparent;
            this.createLinkButton.BorderRadius = 18;
            this.createLinkButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.createLinkButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.createLinkButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.createLinkButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.createLinkButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.createLinkButton.ForeColor = System.Drawing.Color.White;
            this.createLinkButton.Location = new System.Drawing.Point(12, 246);
            this.createLinkButton.Name = "createLinkButton";
            this.createLinkButton.Size = new System.Drawing.Size(126, 39);
            this.createLinkButton.TabIndex = 14;
            this.createLinkButton.Text = "Create Link";
            this.createLinkButton.UseTransparentBackground = true;
            this.createLinkButton.Click += new System.EventHandler(this.createLinkButton_Click);
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Location = new System.Drawing.Point(437, 9);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(45, 13);
            this.versionLabel.TabIndex = 16;
            this.versionLabel.Text = "Version:";
            // 
            // vLabel
            // 
            this.vLabel.AutoSize = true;
            this.vLabel.Location = new System.Drawing.Point(488, 9);
            this.vLabel.Name = "vLabel";
            this.vLabel.Size = new System.Drawing.Size(37, 13);
            this.vLabel.TabIndex = 17;
            this.vLabel.Text = "v1.0.6";
            // 
            // themeLabel
            // 
            this.themeLabel.AutoSize = true;
            this.themeLabel.Location = new System.Drawing.Point(418, 328);
            this.themeLabel.Name = "themeLabel";
            this.themeLabel.Size = new System.Drawing.Size(81, 13);
            this.themeLabel.TabIndex = 18;
            this.themeLabel.Text = "Theme Settings";
            // 
            // darkMode
            // 
            this.darkMode.AutoSize = true;
            this.darkMode.Checked = true;
            this.darkMode.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.darkMode.CheckedState.BorderRadius = 0;
            this.darkMode.CheckedState.BorderThickness = 0;
            this.darkMode.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.darkMode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.darkMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.darkMode.Location = new System.Drawing.Point(421, 353);
            this.darkMode.Name = "darkMode";
            this.darkMode.Size = new System.Drawing.Size(49, 17);
            this.darkMode.TabIndex = 19;
            this.darkMode.Text = "Dark";
            this.darkMode.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.darkMode.UncheckedState.BorderRadius = 0;
            this.darkMode.UncheckedState.BorderThickness = 0;
            this.darkMode.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.darkMode.CheckedChanged += new System.EventHandler(this.darkMode_CheckedChanged);
            // 
            // lightMode
            // 
            this.lightMode.AutoSize = true;
            this.lightMode.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lightMode.CheckedState.BorderRadius = 0;
            this.lightMode.CheckedState.BorderThickness = 0;
            this.lightMode.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lightMode.Location = new System.Drawing.Point(421, 376);
            this.lightMode.Name = "lightMode";
            this.lightMode.Size = new System.Drawing.Size(49, 17);
            this.lightMode.TabIndex = 20;
            this.lightMode.Text = "Light";
            this.lightMode.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.lightMode.UncheckedState.BorderRadius = 0;
            this.lightMode.UncheckedState.BorderThickness = 0;
            this.lightMode.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.lightMode.CheckedChanged += new System.EventHandler(this.lightMode_CheckedChanged);
            // 
            // langLabel
            // 
            this.langLabel.AutoSize = true;
            this.langLabel.Location = new System.Drawing.Point(421, 415);
            this.langLabel.Name = "langLabel";
            this.langLabel.Size = new System.Drawing.Size(96, 13);
            this.langLabel.TabIndex = 21;
            this.langLabel.Text = "Language Settings";
            // 
            // turkishCheck
            // 
            this.turkishCheck.AutoSize = true;
            this.turkishCheck.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.turkishCheck.CheckedState.BorderRadius = 0;
            this.turkishCheck.CheckedState.BorderThickness = 0;
            this.turkishCheck.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.turkishCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.turkishCheck.Location = new System.Drawing.Point(421, 440);
            this.turkishCheck.Name = "turkishCheck";
            this.turkishCheck.Size = new System.Drawing.Size(61, 17);
            this.turkishCheck.TabIndex = 22;
            this.turkishCheck.Text = "Turkish";
            this.turkishCheck.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.turkishCheck.UncheckedState.BorderRadius = 0;
            this.turkishCheck.UncheckedState.BorderThickness = 0;
            this.turkishCheck.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.turkishCheck.CheckedChanged += new System.EventHandler(this.turkishCheck_CheckedChanged);
            // 
            // englishCheck
            // 
            this.englishCheck.AutoSize = true;
            this.englishCheck.Checked = true;
            this.englishCheck.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.englishCheck.CheckedState.BorderRadius = 0;
            this.englishCheck.CheckedState.BorderThickness = 0;
            this.englishCheck.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.englishCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.englishCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.englishCheck.Location = new System.Drawing.Point(421, 463);
            this.englishCheck.Name = "englishCheck";
            this.englishCheck.Size = new System.Drawing.Size(60, 17);
            this.englishCheck.TabIndex = 23;
            this.englishCheck.Text = "English";
            this.englishCheck.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.englishCheck.UncheckedState.BorderRadius = 0;
            this.englishCheck.UncheckedState.BorderThickness = 0;
            this.englishCheck.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.englishCheck.CheckedChanged += new System.EventHandler(this.englishCheck_CheckedChanged);
            // 
            // logBox
            // 
            this.logBox.BackColor = System.Drawing.Color.Silver;
            this.logBox.Enabled = false;
            this.logBox.Location = new System.Drawing.Point(12, 325);
            this.logBox.Multiline = true;
            this.logBox.Name = "logBox";
            this.logBox.Size = new System.Drawing.Size(400, 175);
            this.logBox.TabIndex = 24;
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(539, 512);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.englishCheck);
            this.Controls.Add(this.turkishCheck);
            this.Controls.Add(this.langLabel);
            this.Controls.Add(this.lightMode);
            this.Controls.Add(this.darkMode);
            this.Controls.Add(this.themeLabel);
            this.Controls.Add(this.vLabel);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.createLinkButton);
            this.Controls.Add(this.downloadButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.selectFormat);
            this.Controls.Add(this.formatLabel);
            this.Controls.Add(this.selectArch);
            this.Controls.Add(this.archLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.selectChannel);
            this.Controls.Add(this.channelLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.selectOS);
            this.Controls.Add(this.osLabel);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "App";
            this.Text = "Discord URL Creator";
            this.Load += new System.EventHandler(this.App_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label osLabel;
        private Guna.UI2.WinForms.Guna2ComboBox selectOS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label channelLabel;
        private Guna.UI2.WinForms.Guna2ComboBox selectChannel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label archLabel;
        private Guna.UI2.WinForms.Guna2ComboBox selectArch;
        private System.Windows.Forms.Label formatLabel;
        private Guna.UI2.WinForms.Guna2ComboBox selectFormat;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button downloadButton;
        private Guna.UI2.WinForms.Guna2Button createLinkButton;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.Label vLabel;
        private System.Windows.Forms.Label themeLabel;
        private Guna.UI2.WinForms.Guna2CheckBox darkMode;
        private Guna.UI2.WinForms.Guna2CheckBox lightMode;
        private System.Windows.Forms.Label langLabel;
        private Guna.UI2.WinForms.Guna2CheckBox turkishCheck;
        private Guna.UI2.WinForms.Guna2CheckBox englishCheck;
        private System.Windows.Forms.TextBox logBox;
    }
}