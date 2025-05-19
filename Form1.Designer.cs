namespace sslcheker
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabelPeriodicalCheck = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonWebScrab = new System.Windows.Forms.Button();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.buttonExportCsv = new System.Windows.Forms.Button();
            this.buttonSeetings = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStripGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showMoreToolStripMenuItemShowSertificate = new System.Windows.Forms.ToolStripMenuItem();
            this.checkToolStripMenuItemCheck = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.editToolStripMenuItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteToolStripMenuItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.Hostname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Port = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Expires_in_days = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valid_from = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valid_to = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Last_cheked = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStripNotifyIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialogCsv = new System.Windows.Forms.SaveFileDialog();
            this.timerPeriodicalCheck = new System.Windows.Forms.Timer(this.components);
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStripGrid.SuspendLayout();
            this.contextMenuStripNotifyIcon.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1,
            this.toolStripStatusLabelPeriodicalCheck});
            this.statusStrip1.Location = new System.Drawing.Point(0, 511);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(929, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(48, 17);
            this.toolStripStatusLabel1.Text = "Status : ";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(250, 16);
            // 
            // toolStripStatusLabelPeriodicalCheck
            // 
            this.toolStripStatusLabelPeriodicalCheck.Name = "toolStripStatusLabelPeriodicalCheck";
            this.toolStripStatusLabelPeriodicalCheck.Size = new System.Drawing.Size(167, 17);
            this.toolStripStatusLabelPeriodicalCheck.Text = "Periodical Check enabled: OFF";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonWebScrab);
            this.panel1.Controls.Add(this.buttonAbout);
            this.panel1.Controls.Add(this.buttonCheck);
            this.panel1.Controls.Add(this.buttonExportCsv);
            this.panel1.Controls.Add(this.buttonSeetings);
            this.panel1.Controls.Add(this.buttonAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(929, 80);
            this.panel1.TabIndex = 1;
            // 
            // buttonWebScrab
            // 
            this.buttonWebScrab.Image = global::sslcheker.Properties.Resources.icons8_web_scraper_48;
            this.buttonWebScrab.Location = new System.Drawing.Point(186, 12);
            this.buttonWebScrab.Name = "buttonWebScrab";
            this.buttonWebScrab.Size = new System.Drawing.Size(63, 54);
            this.buttonWebScrab.TabIndex = 2;
            this.buttonWebScrab.UseVisualStyleBackColor = true;
            this.buttonWebScrab.Click += new System.EventHandler(this.buttonWebScrab_Click);
            // 
            // buttonAbout
            // 
            this.buttonAbout.Image = global::sslcheker.Properties.Resources.icons8_about_48;
            this.buttonAbout.Location = new System.Drawing.Point(449, 12);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(63, 54);
            this.buttonAbout.TabIndex = 5;
            this.buttonAbout.UseVisualStyleBackColor = true;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // buttonCheck
            // 
            this.buttonCheck.BackgroundImage = global::sslcheker.Properties.Resources.icons8_detective_48;
            this.buttonCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonCheck.Location = new System.Drawing.Point(12, 12);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(63, 54);
            this.buttonCheck.TabIndex = 0;
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // buttonExportCsv
            // 
            this.buttonExportCsv.Image = global::sslcheker.Properties.Resources.icons8_export_csv_48;
            this.buttonExportCsv.Location = new System.Drawing.Point(255, 12);
            this.buttonExportCsv.Name = "buttonExportCsv";
            this.buttonExportCsv.Size = new System.Drawing.Size(63, 54);
            this.buttonExportCsv.TabIndex = 3;
            this.buttonExportCsv.UseVisualStyleBackColor = true;
            this.buttonExportCsv.Click += new System.EventHandler(this.buttonExportCsv_Click);
            // 
            // buttonSeetings
            // 
            this.buttonSeetings.Image = global::sslcheker.Properties.Resources.icons8_gear_48;
            this.buttonSeetings.Location = new System.Drawing.Point(324, 12);
            this.buttonSeetings.Name = "buttonSeetings";
            this.buttonSeetings.Size = new System.Drawing.Size(63, 54);
            this.buttonSeetings.TabIndex = 4;
            this.buttonSeetings.UseVisualStyleBackColor = true;
            this.buttonSeetings.Click += new System.EventHandler(this.buttonSeetings_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Image = global::sslcheker.Properties.Resources.icons8_add_48;
            this.buttonAdd.Location = new System.Drawing.Point(117, 12);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(63, 54);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Status,
            this.Hostname,
            this.Port,
            this.CN,
            this.Expires_in_days,
            this.Valid_from,
            this.Valid_to,
            this.Last_cheked});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.Size = new System.Drawing.Size(929, 431);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDown);
            // 
            // Status
            // 
            this.Status.ContextMenuStrip = this.contextMenuStripGrid;
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Status.ToolTipText = "Status";
            this.Status.Width = 114;
            // 
            // contextMenuStripGrid
            // 
            this.contextMenuStripGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showMoreToolStripMenuItemShowSertificate,
            this.checkToolStripMenuItemCheck,
            this.toolStripSeparator1,
            this.editToolStripMenuItemEdit,
            this.toolStripSeparator3,
            this.deleteToolStripMenuItemDelete});
            this.contextMenuStripGrid.Name = "contextMenuStripGrid";
            this.contextMenuStripGrid.Size = new System.Drawing.Size(159, 104);
            // 
            // showMoreToolStripMenuItemShowSertificate
            // 
            this.showMoreToolStripMenuItemShowSertificate.Image = global::sslcheker.Properties.Resources.icons8_certification_48;
            this.showMoreToolStripMenuItemShowSertificate.Name = "showMoreToolStripMenuItemShowSertificate";
            this.showMoreToolStripMenuItemShowSertificate.Size = new System.Drawing.Size(158, 22);
            this.showMoreToolStripMenuItemShowSertificate.Text = "Show Sertificate";
            this.showMoreToolStripMenuItemShowSertificate.Click += new System.EventHandler(this.showMoreToolStripMenuItemShowSertificate_Click);
            // 
            // checkToolStripMenuItemCheck
            // 
            this.checkToolStripMenuItemCheck.Image = global::sslcheker.Properties.Resources.icons8_detective_48;
            this.checkToolStripMenuItemCheck.Name = "checkToolStripMenuItemCheck";
            this.checkToolStripMenuItemCheck.Size = new System.Drawing.Size(158, 22);
            this.checkToolStripMenuItemCheck.Text = "Check";
            this.checkToolStripMenuItemCheck.Click += new System.EventHandler(this.checkToolStripMenuItemCheck_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(155, 6);
            // 
            // editToolStripMenuItemEdit
            // 
            this.editToolStripMenuItemEdit.Image = global::sslcheker.Properties.Resources.icons8_edit_48;
            this.editToolStripMenuItemEdit.Name = "editToolStripMenuItemEdit";
            this.editToolStripMenuItemEdit.Size = new System.Drawing.Size(158, 22);
            this.editToolStripMenuItemEdit.Text = "Edit";
            this.editToolStripMenuItemEdit.Click += new System.EventHandler(this.editToolStripMenuItemEdit_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(155, 6);
            // 
            // deleteToolStripMenuItemDelete
            // 
            this.deleteToolStripMenuItemDelete.Image = global::sslcheker.Properties.Resources.icons8_delete_48;
            this.deleteToolStripMenuItemDelete.Name = "deleteToolStripMenuItemDelete";
            this.deleteToolStripMenuItemDelete.Size = new System.Drawing.Size(158, 22);
            this.deleteToolStripMenuItemDelete.Text = "Delete";
            this.deleteToolStripMenuItemDelete.Click += new System.EventHandler(this.deleteToolStripMenuItemDelete_Click);
            // 
            // Hostname
            // 
            this.Hostname.ContextMenuStrip = this.contextMenuStripGrid;
            this.Hostname.HeaderText = "Hostname";
            this.Hostname.Name = "Hostname";
            this.Hostname.ReadOnly = true;
            this.Hostname.Width = 114;
            // 
            // Port
            // 
            this.Port.ContextMenuStrip = this.contextMenuStripGrid;
            this.Port.HeaderText = "Port";
            this.Port.Name = "Port";
            this.Port.ReadOnly = true;
            this.Port.Width = 114;
            // 
            // CN
            // 
            this.CN.ContextMenuStrip = this.contextMenuStripGrid;
            this.CN.HeaderText = "CN";
            this.CN.Name = "CN";
            this.CN.ReadOnly = true;
            this.CN.Width = 114;
            // 
            // Expires_in_days
            // 
            this.Expires_in_days.ContextMenuStrip = this.contextMenuStripGrid;
            this.Expires_in_days.HeaderText = "Expires_in_days";
            this.Expires_in_days.Name = "Expires_in_days";
            this.Expires_in_days.ReadOnly = true;
            this.Expires_in_days.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Expires_in_days.Width = 108;
            // 
            // Valid_from
            // 
            this.Valid_from.ContextMenuStrip = this.contextMenuStripGrid;
            this.Valid_from.HeaderText = "Valid_from";
            this.Valid_from.Name = "Valid_from";
            this.Valid_from.ReadOnly = true;
            this.Valid_from.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Valid_from.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Valid_from.Width = 114;
            // 
            // Valid_to
            // 
            this.Valid_to.ContextMenuStrip = this.contextMenuStripGrid;
            this.Valid_to.HeaderText = "Valid_to";
            this.Valid_to.Name = "Valid_to";
            this.Valid_to.ReadOnly = true;
            this.Valid_to.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Valid_to.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Valid_to.Width = 114;
            // 
            // Last_cheked
            // 
            this.Last_cheked.ContextMenuStrip = this.contextMenuStripGrid;
            this.Last_cheked.HeaderText = "Last_cheked";
            this.Last_cheked.Name = "Last_cheked";
            this.Last_cheked.ReadOnly = true;
            this.Last_cheked.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Last_cheked.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Last_cheked.Width = 114;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStripNotifyIcon;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStripNotifyIcon
            // 
            this.contextMenuStripNotifyIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.contextMenuStripNotifyIcon.Name = "contextMenuStripNotifyIcon";
            this.contextMenuStripNotifyIcon.Size = new System.Drawing.Size(104, 54);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.showToolStripMenuItem.Text = "Show";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(100, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // saveFileDialogCsv
            // 
            this.saveFileDialogCsv.DefaultExt = "\".csv\"";
            // 
            // timerPeriodicalCheck
            // 
            this.timerPeriodicalCheck.Interval = 3600000;
            this.timerPeriodicalCheck.Tick += new System.EventHandler(this.timerPeriodicalCheck_Tick);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.ContextMenuStrip = this.contextMenuStripGrid;
            this.dataGridViewImageColumn1.HeaderText = "Status";
            this.dataGridViewImageColumn1.Image = global::sslcheker.Properties.Resources.icons8_certification_48;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.ToolTipText = "Status";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 533);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Web SSL cheker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStripGrid.ResumeLayout(false);
            this.contextMenuStripNotifyIcon.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.Button buttonExportCsv;
        private System.Windows.Forms.Button buttonSeetings;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripGrid;
        private System.Windows.Forms.ToolStripMenuItem showMoreToolStripMenuItemShowSertificate;
        private System.Windows.Forms.ToolStripMenuItem checkToolStripMenuItemCheck;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItemEdit;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItemDelete;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Button buttonWebScrab;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.SaveFileDialog saveFileDialogCsv;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hostname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Port;
        private System.Windows.Forms.DataGridViewTextBoxColumn CN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Expires_in_days;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valid_from;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valid_to;
        private System.Windows.Forms.DataGridViewTextBoxColumn Last_cheked;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripNotifyIcon;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Timer timerPeriodicalCheck;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelPeriodicalCheck;
    }
}

