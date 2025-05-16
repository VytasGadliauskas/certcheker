namespace sslcheker
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
            this.checkBoxEnableMail = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWarningDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownErrorDays)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.Image = global::sslcheker.Properties.Resources.icons8_verified_account_48;
            this.buttonOK.Location = new System.Drawing.Point(424, 203);
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
            this.buttonClose.Location = new System.Drawing.Point(521, 203);
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
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Check time (minutes) ";
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
            this.groupBox2.Controls.Add(this.checkBoxEnableMail);
            this.groupBox2.Location = new System.Drawing.Point(286, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(310, 167);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " Email ";
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
            // 
            // FormSeetings
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonClose;
            this.ClientSize = new System.Drawing.Size(621, 278);
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
    }
}