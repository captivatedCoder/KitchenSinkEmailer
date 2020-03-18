namespace SendEmail
{
    partial class EmailForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmailForm));
            this.SubjectLabel = new System.Windows.Forms.Label();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.ToBox = new System.Windows.Forms.TextBox();
            this.SubjectBox = new System.Windows.Forms.TextBox();
            this.MessageText = new System.Windows.Forms.TextBox();
            this.SendBtn = new System.Windows.Forms.Button();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.SendDirect = new System.Windows.Forms.CheckBox();
            this.AttachmentsLabel = new System.Windows.Forms.Label();
            this.attachmentDialog = new System.Windows.Forms.OpenFileDialog();
            this.Attachments = new System.Windows.Forms.TextBox();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.CrLfChk = new System.Windows.Forms.CheckBox();
            this.MailToChk = new System.Windows.Forms.CheckBox();
            this.MapiChk = new System.Windows.Forms.CheckBox();
            this.OutlookChk = new System.Windows.Forms.CheckBox();
            this.SmtpChk = new System.Windows.Forms.CheckBox();
            this.SmtpServerLabel = new System.Windows.Forms.Label();
            this.PortNumberLabel = new System.Windows.Forms.Label();
            this.SmtpServerUrl = new System.Windows.Forms.TextBox();
            this.PortNumber = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.FromLabel = new System.Windows.Forms.Label();
            this.FromBox = new System.Windows.Forms.TextBox();
            this.OutlookCmdChk = new System.Windows.Forms.CheckBox();
            this.TbirdChk = new System.Windows.Forms.CheckBox();
            this.OtherBtn = new System.Windows.Forms.Button();
            this.ToBtn = new System.Windows.Forms.Button();
            this.FromCbox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // SubjectLabel
            // 
            this.SubjectLabel.AutoSize = true;
            this.SubjectLabel.Location = new System.Drawing.Point(33, 60);
            this.SubjectLabel.Name = "SubjectLabel";
            this.SubjectLabel.Size = new System.Drawing.Size(46, 13);
            this.SubjectLabel.TabIndex = 2;
            this.SubjectLabel.Text = "Subject:";
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.Location = new System.Drawing.Point(26, 91);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(53, 13);
            this.MessageLabel.TabIndex = 3;
            this.MessageLabel.Text = "Message:";
            // 
            // ToBox
            // 
            this.ToBox.Location = new System.Drawing.Point(84, 30);
            this.ToBox.Name = "ToBox";
            this.ToBox.Size = new System.Drawing.Size(217, 20);
            this.ToBox.TabIndex = 5;
            // 
            // SubjectBox
            // 
            this.SubjectBox.Location = new System.Drawing.Point(84, 56);
            this.SubjectBox.Name = "SubjectBox";
            this.SubjectBox.Size = new System.Drawing.Size(217, 20);
            this.SubjectBox.TabIndex = 6;
            this.SubjectBox.Text = "Test";
            // 
            // MessageText
            // 
            this.MessageText.Location = new System.Drawing.Point(84, 90);
            this.MessageText.Multiline = true;
            this.MessageText.Name = "MessageText";
            this.MessageText.Size = new System.Drawing.Size(217, 81);
            this.MessageText.TabIndex = 7;
            this.MessageText.Text = "Tesssttsss";
            // 
            // SendBtn
            // 
            this.SendBtn.Location = new System.Drawing.Point(13, 297);
            this.SendBtn.Name = "SendBtn";
            this.SendBtn.Size = new System.Drawing.Size(75, 23);
            this.SendBtn.TabIndex = 8;
            this.SendBtn.Text = "Send";
            this.SendBtn.UseVisualStyleBackColor = true;
            this.SendBtn.Click += new System.EventHandler(this.SendBtn_Click);
            // 
            // OutputLabel
            // 
            this.OutputLabel.AutoSize = true;
            this.OutputLabel.Location = new System.Drawing.Point(110, 302);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(0, 13);
            this.OutputLabel.TabIndex = 9;
            // 
            // SendDirect
            // 
            this.SendDirect.AutoSize = true;
            this.SendDirect.Location = new System.Drawing.Point(94, 301);
            this.SendDirect.Name = "SendDirect";
            this.SendDirect.Size = new System.Drawing.Size(82, 17);
            this.SendDirect.TabIndex = 10;
            this.SendDirect.Text = "Send Direct";
            this.SendDirect.UseVisualStyleBackColor = true;
            // 
            // AttachmentsLabel
            // 
            this.AttachmentsLabel.AutoSize = true;
            this.AttachmentsLabel.Location = new System.Drawing.Point(10, 180);
            this.AttachmentsLabel.Name = "AttachmentsLabel";
            this.AttachmentsLabel.Size = new System.Drawing.Size(69, 13);
            this.AttachmentsLabel.TabIndex = 11;
            this.AttachmentsLabel.Text = "Attachments:";
            // 
            // Attachments
            // 
            this.Attachments.Location = new System.Drawing.Point(84, 177);
            this.Attachments.Name = "Attachments";
            this.Attachments.Size = new System.Drawing.Size(217, 20);
            this.Attachments.TabIndex = 12;
            // 
            // BrowseButton
            // 
            this.BrowseButton.Location = new System.Drawing.Point(307, 175);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(75, 23);
            this.BrowseButton.TabIndex = 13;
            this.BrowseButton.Text = "Browse";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // CrLfChk
            // 
            this.CrLfChk.AutoSize = true;
            this.CrLfChk.Location = new System.Drawing.Point(182, 301);
            this.CrLfChk.Name = "CrLfChk";
            this.CrLfChk.Size = new System.Drawing.Size(70, 17);
            this.CrLfChk.TabIndex = 14;
            this.CrLfChk.Text = "Add CrLF";
            this.CrLfChk.UseVisualStyleBackColor = true;
            // 
            // MailToChk
            // 
            this.MailToChk.AutoSize = true;
            this.MailToChk.Location = new System.Drawing.Point(307, 8);
            this.MailToChk.Name = "MailToChk";
            this.MailToChk.Size = new System.Drawing.Size(58, 17);
            this.MailToChk.TabIndex = 15;
            this.MailToChk.Text = "MailTo";
            this.MailToChk.UseVisualStyleBackColor = true;
            // 
            // MapiChk
            // 
            this.MapiChk.AutoSize = true;
            this.MapiChk.Location = new System.Drawing.Point(307, 31);
            this.MapiChk.Name = "MapiChk";
            this.MapiChk.Size = new System.Drawing.Size(49, 17);
            this.MapiChk.TabIndex = 16;
            this.MapiChk.Text = "Mapi";
            this.MapiChk.UseVisualStyleBackColor = true;
            // 
            // OutlookChk
            // 
            this.OutlookChk.AutoSize = true;
            this.OutlookChk.Location = new System.Drawing.Point(307, 54);
            this.OutlookChk.Name = "OutlookChk";
            this.OutlookChk.Size = new System.Drawing.Size(63, 17);
            this.OutlookChk.TabIndex = 17;
            this.OutlookChk.Text = "Outlook";
            this.OutlookChk.UseVisualStyleBackColor = true;
            this.OutlookChk.CheckedChanged += new System.EventHandler(this.OutlookChk_CheckedChanged);
            // 
            // SmtpChk
            // 
            this.SmtpChk.AutoSize = true;
            this.SmtpChk.Location = new System.Drawing.Point(307, 77);
            this.SmtpChk.Name = "SmtpChk";
            this.SmtpChk.Size = new System.Drawing.Size(56, 17);
            this.SmtpChk.TabIndex = 18;
            this.SmtpChk.Text = "SMTP";
            this.SmtpChk.UseVisualStyleBackColor = true;
            // 
            // SmtpServerLabel
            // 
            this.SmtpServerLabel.AutoSize = true;
            this.SmtpServerLabel.Location = new System.Drawing.Point(13, 247);
            this.SmtpServerLabel.Name = "SmtpServerLabel";
            this.SmtpServerLabel.Size = new System.Drawing.Size(71, 13);
            this.SmtpServerLabel.TabIndex = 19;
            this.SmtpServerLabel.Text = "SMTP Server";
            // 
            // PortNumberLabel
            // 
            this.PortNumberLabel.AutoSize = true;
            this.PortNumberLabel.Location = new System.Drawing.Point(256, 247);
            this.PortNumberLabel.Name = "PortNumberLabel";
            this.PortNumberLabel.Size = new System.Drawing.Size(66, 13);
            this.PortNumberLabel.TabIndex = 20;
            this.PortNumberLabel.Text = "Port Number";
            // 
            // SmtpServerUrl
            // 
            this.SmtpServerUrl.Location = new System.Drawing.Point(90, 244);
            this.SmtpServerUrl.Name = "SmtpServerUrl";
            this.SmtpServerUrl.Size = new System.Drawing.Size(134, 20);
            this.SmtpServerUrl.TabIndex = 21;
            // 
            // PortNumber
            // 
            this.PortNumber.Location = new System.Drawing.Point(328, 244);
            this.PortNumber.Name = "PortNumber";
            this.PortNumber.Size = new System.Drawing.Size(49, 20);
            this.PortNumber.TabIndex = 22;
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(90, 271);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(100, 20);
            this.Username.TabIndex = 23;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(277, 271);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(100, 20);
            this.Password.TabIndex = 24;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(24, 274);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(55, 13);
            this.UsernameLabel.TabIndex = 25;
            this.UsernameLabel.Text = "Username";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(218, 274);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(53, 13);
            this.PasswordLabel.TabIndex = 26;
            this.PasswordLabel.Text = "Password";
            // 
            // FromLabel
            // 
            this.FromLabel.AutoSize = true;
            this.FromLabel.Location = new System.Drawing.Point(46, 10);
            this.FromLabel.Name = "FromLabel";
            this.FromLabel.Size = new System.Drawing.Size(33, 13);
            this.FromLabel.TabIndex = 0;
            this.FromLabel.Text = "From:";
            // 
            // FromBox
            // 
            this.FromBox.Location = new System.Drawing.Point(84, 6);
            this.FromBox.Name = "FromBox";
            this.FromBox.Size = new System.Drawing.Size(217, 20);
            this.FromBox.TabIndex = 1;
            // 
            // OutlookCmdChk
            // 
            this.OutlookCmdChk.AutoSize = true;
            this.OutlookCmdChk.Location = new System.Drawing.Point(307, 100);
            this.OutlookCmdChk.Name = "OutlookCmdChk";
            this.OutlookCmdChk.Size = new System.Drawing.Size(87, 17);
            this.OutlookCmdChk.TabIndex = 28;
            this.OutlookCmdChk.Text = "Outlook Cmd";
            this.OutlookCmdChk.UseVisualStyleBackColor = true;
            // 
            // TbirdChk
            // 
            this.TbirdChk.AutoSize = true;
            this.TbirdChk.Location = new System.Drawing.Point(307, 123);
            this.TbirdChk.Name = "TbirdChk";
            this.TbirdChk.Size = new System.Drawing.Size(74, 17);
            this.TbirdChk.TabIndex = 29;
            this.TbirdChk.Text = "Tbird Cmd";
            this.TbirdChk.UseVisualStyleBackColor = true;
            // 
            // OtherBtn
            // 
            this.OtherBtn.Location = new System.Drawing.Point(302, 297);
            this.OtherBtn.Name = "OtherBtn";
            this.OtherBtn.Size = new System.Drawing.Size(75, 23);
            this.OtherBtn.TabIndex = 27;
            this.OtherBtn.Text = "Reg Check";
            this.OtherBtn.UseVisualStyleBackColor = true;
            this.OtherBtn.Click += new System.EventHandler(this.OtherBtn_Click);
            // 
            // ToBtn
            // 
            this.ToBtn.Location = new System.Drawing.Point(50, 28);
            this.ToBtn.Name = "ToBtn";
            this.ToBtn.Size = new System.Drawing.Size(29, 23);
            this.ToBtn.TabIndex = 30;
            this.ToBtn.Text = "To";
            this.ToBtn.UseVisualStyleBackColor = true;
            this.ToBtn.Click += new System.EventHandler(this.ToBtn_Click);
            // 
            // FromCbox
            // 
            this.FromCbox.FormattingEnabled = true;
            this.FromCbox.Location = new System.Drawing.Point(84, 5);
            this.FromCbox.Name = "FromCbox";
            this.FromCbox.Size = new System.Drawing.Size(217, 21);
            this.FromCbox.TabIndex = 31;
            this.FromCbox.Visible = false;
            // 
            // EmailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 326);
            this.Controls.Add(this.FromCbox);
            this.Controls.Add(this.ToBtn);
            this.Controls.Add(this.TbirdChk);
            this.Controls.Add(this.OutlookCmdChk);
            this.Controls.Add(this.OtherBtn);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.PortNumber);
            this.Controls.Add(this.SmtpServerUrl);
            this.Controls.Add(this.PortNumberLabel);
            this.Controls.Add(this.SmtpServerLabel);
            this.Controls.Add(this.SmtpChk);
            this.Controls.Add(this.OutlookChk);
            this.Controls.Add(this.MapiChk);
            this.Controls.Add(this.MailToChk);
            this.Controls.Add(this.CrLfChk);
            this.Controls.Add(this.BrowseButton);
            this.Controls.Add(this.Attachments);
            this.Controls.Add(this.AttachmentsLabel);
            this.Controls.Add(this.SendDirect);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.SendBtn);
            this.Controls.Add(this.MessageText);
            this.Controls.Add(this.SubjectBox);
            this.Controls.Add(this.ToBox);
            this.Controls.Add(this.FromBox);
            this.Controls.Add(this.MessageLabel);
            this.Controls.Add(this.SubjectLabel);
            this.Controls.Add(this.FromLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EmailForm";
            this.Text = "Email Form";
            this.Load += new System.EventHandler(this.EmailForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label SubjectLabel;
        private System.Windows.Forms.Label MessageLabel;
        private System.Windows.Forms.TextBox ToBox;
        private System.Windows.Forms.TextBox SubjectBox;
        private System.Windows.Forms.TextBox MessageText;
        private System.Windows.Forms.Button SendBtn;
        private System.Windows.Forms.Label OutputLabel;
        private System.Windows.Forms.CheckBox SendDirect;
        private System.Windows.Forms.Label AttachmentsLabel;
        private System.Windows.Forms.OpenFileDialog attachmentDialog;
        private System.Windows.Forms.TextBox Attachments;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.CheckBox CrLfChk;
        private System.Windows.Forms.CheckBox MailToChk;
        private System.Windows.Forms.CheckBox MapiChk;
        private System.Windows.Forms.CheckBox OutlookChk;
        private System.Windows.Forms.CheckBox SmtpChk;
        private System.Windows.Forms.Label SmtpServerLabel;
        private System.Windows.Forms.Label PortNumberLabel;
        private System.Windows.Forms.TextBox SmtpServerUrl;
        private System.Windows.Forms.TextBox PortNumber;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label FromLabel;
        private System.Windows.Forms.TextBox FromBox;
        private System.Windows.Forms.CheckBox OutlookCmdChk;
        private System.Windows.Forms.CheckBox TbirdChk;
        private System.Windows.Forms.Button OtherBtn;
        private System.Windows.Forms.Button ToBtn;
        private System.Windows.Forms.ComboBox FromCbox;
    }
}

