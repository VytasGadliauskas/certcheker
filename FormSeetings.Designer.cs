﻿namespace sslcheker
{
    partial class FormSeetings
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
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDownMinutes = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownWarningDays = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownErrorDays = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxPeriodicCheck = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxEnableSSL = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.checkBoxAutentificate = new System.Windows.Forms.CheckBox();
            this.buttonTestEmail = new System.Windows.Forms.Button();
            this.numericUpDownSmtpPort = new System.Windows.Forms.NumericUpDown();
            this.textBoxMailTo = new System.Windows.Forms.TextBox();
            this.textBoxMailFrom = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSmtpHost = new System.Windows.Forms.TextBox();
            this.checkBoxEnableMail = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWarningDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownErrorDays)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSmtpPort)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Image = global::sslcheker.Properties.Resources.icons8_verified_account_48;
            this.buttonOK.Location = new System.Drawing.Point(427, 280);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 55);
            this.buttonOK.TabIndex = 0;
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClose.Image = global::sslcheker.Properties.Resources.icons8_unavailable_48;
            this.buttonClose.Location = new System.Drawing.Point(521, 280);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 55);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDownMinutes);
            this.groupBox1.Controls.Add(this.numericUpDownWarningDays);
            this.groupBox1.Controls.Add(this.numericUpDownErrorDays);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.checkBoxPeriodicCheck);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(24, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 172);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Check ";
            // 
            // numericUpDownMinutes
            // 
            this.numericUpDownMinutes.Location = new System.Drawing.Point(19, 129);
            this.numericUpDownMinutes.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownMinutes.Name = "numericUpDownMinutes";
            this.numericUpDownMinutes.Size = new System.Drawing.Size(73, 20);
            this.numericUpDownMinutes.TabIndex = 10;
            // 
            // numericUpDownWarningDays
            // 
            this.numericUpDownWarningDays.Location = new System.Drawing.Point(19, 64);
            this.numericUpDownWarningDays.Name = "numericUpDownWarningDays";
            this.numericUpDownWarningDays.Size = new System.Drawing.Size(73, 20);
            this.numericUpDownWarningDays.TabIndex = 9;
            // 
            // numericUpDownErrorDays
            // 
            this.numericUpDownErrorDays.Location = new System.Drawing.Point(19, 29);
            this.numericUpDownErrorDays.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownErrorDays.Name = "numericUpDownErrorDays";
            this.numericUpDownErrorDays.Size = new System.Drawing.Size(73, 20);
            this.numericUpDownErrorDays.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Check time ( hours ) ";
            // 
            // checkBoxPeriodicCheck
            // 
            this.checkBoxPeriodicCheck.AutoSize = true;
            this.checkBoxPeriodicCheck.Location = new System.Drawing.Point(19, 100);
            this.checkBoxPeriodicCheck.Name = "checkBoxPeriodicCheck";
            this.checkBoxPeriodicCheck.Size = new System.Drawing.Size(105, 17);
            this.checkBoxPeriodicCheck.TabIndex = 4;
            this.checkBoxPeriodicCheck.Text = "Periodical check";
            this.checkBoxPeriodicCheck.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Days to WARNING";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Days to ERROR";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxEnableSSL);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBoxPassword);
            this.groupBox2.Controls.Add(this.textBoxUser);
            this.groupBox2.Controls.Add(this.checkBoxAutentificate);
            this.groupBox2.Controls.Add(this.buttonTestEmail);
            this.groupBox2.Controls.Add(this.numericUpDownSmtpPort);
            this.groupBox2.Controls.Add(this.textBoxMailTo);
            this.groupBox2.Controls.Add(this.textBoxMailFrom);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBoxSmtpHost);
            this.groupBox2.Controls.Add(this.checkBoxEnableMail);
            this.groupBox2.Location = new System.Drawing.Point(286, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(310, 254);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " Email ";
            // 
            // checkBoxEnableSSL
            // 
            this.checkBoxEnableSSL.AutoSize = true;
            this.checkBoxEnableSSL.Location = new System.Drawing.Point(19, 130);
            this.checkBoxEnableSSL.Name = "checkBoxEnableSSL";
            this.checkBoxEnableSSL.Size = new System.Drawing.Size(82, 17);
            this.checkBoxEnableSSL.TabIndex = 22;
            this.checkBoxEnableSSL.Text = "Enable SSL";
            this.checkBoxEnableSSL.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(110, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(110, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "User";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(170, 129);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(122, 20);
            this.textBoxPassword.TabIndex = 19;
            // 
            // textBoxUser
            // 
            this.textBoxUser.Location = new System.Drawing.Point(145, 94);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(147, 20);
            this.textBoxUser.TabIndex = 18;
            // 
            // checkBoxAutentificate
            // 
            this.checkBoxAutentificate.AutoSize = true;
            this.checkBoxAutentificate.Location = new System.Drawing.Point(19, 97);
            this.checkBoxAutentificate.Name = "checkBoxAutentificate";
            this.checkBoxAutentificate.Size = new System.Drawing.Size(85, 17);
            this.checkBoxAutentificate.TabIndex = 17;
            this.checkBoxAutentificate.Text = "Autentificate";
            this.checkBoxAutentificate.UseVisualStyleBackColor = true;
            // 
            // buttonTestEmail
            // 
            this.buttonTestEmail.Enabled = false;
            this.buttonTestEmail.Location = new System.Drawing.Point(170, 19);
            this.buttonTestEmail.Name = "buttonTestEmail";
            this.buttonTestEmail.Size = new System.Drawing.Size(122, 23);
            this.buttonTestEmail.TabIndex = 16;
            this.buttonTestEmail.Text = "Send Test Email";
            this.buttonTestEmail.UseVisualStyleBackColor = true;
            this.buttonTestEmail.Click += new System.EventHandler(this.buttonTestEmail_Click);
            // 
            // numericUpDownSmtpPort
            // 
            this.numericUpDownSmtpPort.Location = new System.Drawing.Point(244, 54);
            this.numericUpDownSmtpPort.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownSmtpPort.Name = "numericUpDownSmtpPort";
            this.numericUpDownSmtpPort.Size = new System.Drawing.Size(48, 20);
            this.numericUpDownSmtpPort.TabIndex = 11;
            this.numericUpDownSmtpPort.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // textBoxMailTo
            // 
            this.textBoxMailTo.Location = new System.Drawing.Point(85, 214);
            this.textBoxMailTo.Name = "textBoxMailTo";
            this.textBoxMailTo.Size = new System.Drawing.Size(207, 20);
            this.textBoxMailTo.TabIndex = 15;
            // 
            // textBoxMailFrom
            // 
            this.textBoxMailFrom.Location = new System.Drawing.Point(85, 172);
            this.textBoxMailFrom.Name = "textBoxMailFrom";
            this.textBoxMailFrom.Size = new System.Drawing.Size(207, 20);
            this.textBoxMailFrom.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "MAIL to";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "MAIL from";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "SMTP host ";
            // 
            // textBoxSmtpHost
            // 
            this.textBoxSmtpHost.Location = new System.Drawing.Point(85, 54);
            this.textBoxSmtpHost.Name = "textBoxSmtpHost";
            this.textBoxSmtpHost.Size = new System.Drawing.Size(147, 20);
            this.textBoxSmtpHost.TabIndex = 9;
            // 
            // checkBoxEnableMail
            // 
            this.checkBoxEnableMail.AutoSize = true;
            this.checkBoxEnableMail.Location = new System.Drawing.Point(19, 25);
            this.checkBoxEnableMail.Name = "checkBoxEnableMail";
            this.checkBoxEnableMail.Size = new System.Drawing.Size(112, 17);
            this.checkBoxEnableMail.TabIndex = 8;
            this.checkBoxEnableMail.Text = "Enable send email";
            this.checkBoxEnableMail.UseVisualStyleBackColor = true;
            this.checkBoxEnableMail.CheckStateChanged += new System.EventHandler(this.checkBoxEnableMail_CheckStateChanged);
            // 
            // FormSeetings
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonClose;
            this.ClientSize = new System.Drawing.Size(621, 347);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormSeetings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Seetings";
            this.Load += new System.EventHandler(this.FormSeetings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWarningDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownErrorDays)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSmtpPort)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBoxPeriodicCheck;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxEnableMail;
        private System.Windows.Forms.NumericUpDown numericUpDownMinutes;
        private System.Windows.Forms.NumericUpDown numericUpDownWarningDays;
        private System.Windows.Forms.NumericUpDown numericUpDownErrorDays;
        private System.Windows.Forms.NumericUpDown numericUpDownSmtpPort;
        private System.Windows.Forms.TextBox textBoxMailTo;
        private System.Windows.Forms.TextBox textBoxMailFrom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSmtpHost;
        private System.Windows.Forms.Button buttonTestEmail;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.CheckBox checkBoxAutentificate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBoxEnableSSL;
    }
}