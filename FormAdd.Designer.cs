namespace sslcheker
{
    partial class FormAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdd));
            this.labelHostname = new System.Windows.Forms.Label();
            this.labelPort = new System.Windows.Forms.Label();
            this.textBoxHostname = new System.Windows.Forms.TextBox();
            this.numericUpDownPort = new System.Windows.Forms.NumericUpDown();
            this.checkBoxResolve = new System.Windows.Forms.CheckBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPort)).BeginInit();
            this.SuspendLayout();
            // 
            // labelHostname
            // 
            this.labelHostname.AutoSize = true;
            this.labelHostname.Location = new System.Drawing.Point(25, 30);
            this.labelHostname.Name = "labelHostname";
            this.labelHostname.Size = new System.Drawing.Size(55, 13);
            this.labelHostname.TabIndex = 0;
            this.labelHostname.Text = "Hostname";
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(25, 56);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(26, 13);
            this.labelPort.TabIndex = 1;
            this.labelPort.Text = "Port";
            // 
            // textBoxHostname
            // 
            this.textBoxHostname.Location = new System.Drawing.Point(86, 27);
            this.textBoxHostname.Name = "textBoxHostname";
            this.textBoxHostname.Size = new System.Drawing.Size(204, 20);
            this.textBoxHostname.TabIndex = 2;
            this.textBoxHostname.Click += new System.EventHandler(this.textBoxHostname_Click);
            // 
            // numericUpDownPort
            // 
            this.numericUpDownPort.Location = new System.Drawing.Point(86, 54);
            this.numericUpDownPort.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numericUpDownPort.Name = "numericUpDownPort";
            this.numericUpDownPort.Size = new System.Drawing.Size(72, 20);
            this.numericUpDownPort.TabIndex = 4;
            this.numericUpDownPort.Value = new decimal(new int[] {
            443,
            0,
            0,
            0});
            // 
            // checkBoxResolve
            // 
            this.checkBoxResolve.AutoSize = true;
            this.checkBoxResolve.Checked = true;
            this.checkBoxResolve.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxResolve.Location = new System.Drawing.Point(176, 87);
            this.checkBoxResolve.Name = "checkBoxResolve";
            this.checkBoxResolve.Size = new System.Drawing.Size(114, 17);
            this.checkBoxResolve.TabIndex = 6;
            this.checkBoxResolve.Text = "Resolve hostname";
            this.checkBoxResolve.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Image = global::sslcheker.Properties.Resources.icons8_add_48;
            this.buttonAdd.Location = new System.Drawing.Point(125, 132);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 51);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Image = global::sslcheker.Properties.Resources.icons8_unavailable_48;
            this.buttonCancel.Location = new System.Drawing.Point(215, 132);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 51);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FormAdd
            // 
            this.AcceptButton = this.buttonAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(307, 209);
            this.ControlBox = false;
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.checkBoxResolve);
            this.Controls.Add(this.numericUpDownPort);
            this.Controls.Add(this.textBoxHostname);
            this.Controls.Add(this.labelPort);
            this.Controls.Add(this.labelHostname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormAdd";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHostname;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.TextBox textBoxHostname;
        private System.Windows.Forms.NumericUpDown numericUpDownPort;
        private System.Windows.Forms.CheckBox checkBoxResolve;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
    }
}