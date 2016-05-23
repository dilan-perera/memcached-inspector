namespace MemcachedInspector.UI.Windows.Forms
{
    partial class CacheOperationsForm
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.inspectorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newConnectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inspectorSeparator1MenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.connectionToolStrip = new System.Windows.Forms.ToolStrip();
            this.connectionsLabel = new System.Windows.Forms.Label();
            this.connectionDataGridView = new System.Windows.Forms.DataGridView();
            this.connectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sessionsToolStrip = new System.Windows.Forms.ToolStrip();
            this.sessionsLabel = new System.Windows.Forms.Label();
            this.sessionTabControl = new System.Windows.Forms.TabControl();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hostNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.portColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.connectionDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inspectorToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(864, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // inspectorToolStripMenuItem
            // 
            this.inspectorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newConnectionToolStripMenuItem,
            this.inspectorSeparator1MenuItem,
            this.exitToolStripMenuItem});
            this.inspectorToolStripMenuItem.Name = "inspectorToolStripMenuItem";
            this.inspectorToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.inspectorToolStripMenuItem.Text = "&Inspector";
            // 
            // newConnectionToolStripMenuItem
            // 
            this.newConnectionToolStripMenuItem.Name = "newConnectionToolStripMenuItem";
            this.newConnectionToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newConnectionToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.newConnectionToolStripMenuItem.Text = "&New Connection...";
            this.newConnectionToolStripMenuItem.Click += new System.EventHandler(this.NewConnectionToolStripMenuItem_Click);
            // 
            // inspectorSeparator1MenuItem
            // 
            this.inspectorSeparator1MenuItem.Name = "inspectorSeparator1MenuItem";
            this.inspectorSeparator1MenuItem.Size = new System.Drawing.Size(212, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutApplicationToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutApplicationToolStripMenuItem
            // 
            this.aboutApplicationToolStripMenuItem.Name = "aboutApplicationToolStripMenuItem";
            this.aboutApplicationToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.aboutApplicationToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.aboutApplicationToolStripMenuItem.Text = "&About Memcache Inspector...";
            this.aboutApplicationToolStripMenuItem.Click += new System.EventHandler(this.AboutApplicationToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Location = new System.Drawing.Point(0, 599);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(864, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip";
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer.Location = new System.Drawing.Point(0, 24);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.connectionToolStrip);
            this.splitContainer.Panel1.Controls.Add(this.connectionsLabel);
            this.splitContainer.Panel1.Controls.Add(this.connectionDataGridView);
            this.splitContainer.Panel1MinSize = 260;
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.sessionsToolStrip);
            this.splitContainer.Panel2.Controls.Add(this.sessionsLabel);
            this.splitContainer.Panel2.Controls.Add(this.sessionTabControl);
            this.splitContainer.Panel2MinSize = 600;
            this.splitContainer.Size = new System.Drawing.Size(864, 575);
            this.splitContainer.SplitterDistance = 260;
            this.splitContainer.TabIndex = 2;
            // 
            // connectionToolStrip
            // 
            this.connectionToolStrip.Location = new System.Drawing.Point(0, 17);
            this.connectionToolStrip.Name = "connectionToolStrip";
            this.connectionToolStrip.Size = new System.Drawing.Size(260, 25);
            this.connectionToolStrip.TabIndex = 2;
            // 
            // connectionsLabel
            // 
            this.connectionsLabel.AutoEllipsis = true;
            this.connectionsLabel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.connectionsLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.connectionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectionsLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.connectionsLabel.Location = new System.Drawing.Point(0, 0);
            this.connectionsLabel.Name = "connectionsLabel";
            this.connectionsLabel.Size = new System.Drawing.Size(260, 17);
            this.connectionsLabel.TabIndex = 1;
            this.connectionsLabel.Text = "Connections";
            this.connectionsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // connectionDataGridView
            // 
            this.connectionDataGridView.AllowUserToAddRows = false;
            this.connectionDataGridView.AllowUserToDeleteRows = false;
            this.connectionDataGridView.AllowUserToResizeRows = false;
            this.connectionDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.connectionDataGridView.AutoGenerateColumns = false;
            this.connectionDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.connectionDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.connectionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.connectionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameColumn,
            this.hostNameColumn,
            this.portColumn});
            this.connectionDataGridView.DataSource = this.connectionBindingSource;
            this.connectionDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.connectionDataGridView.Location = new System.Drawing.Point(3, 45);
            this.connectionDataGridView.MultiSelect = false;
            this.connectionDataGridView.Name = "connectionDataGridView";
            this.connectionDataGridView.ReadOnly = true;
            this.connectionDataGridView.RowHeadersVisible = false;
            this.connectionDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.connectionDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.connectionDataGridView.Size = new System.Drawing.Size(257, 530);
            this.connectionDataGridView.TabIndex = 0;
            this.connectionDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ConnectionDataGridView_CellDoubleClick);
            // 
            // connectionBindingSource
            // 
            this.connectionBindingSource.DataSource = typeof(MemcachedInspector.UI.Process.Models.Connection);
            // 
            // sessionsToolStrip
            // 
            this.sessionsToolStrip.Location = new System.Drawing.Point(0, 17);
            this.sessionsToolStrip.Name = "sessionsToolStrip";
            this.sessionsToolStrip.Size = new System.Drawing.Size(600, 25);
            this.sessionsToolStrip.TabIndex = 6;
            // 
            // sessionsLabel
            // 
            this.sessionsLabel.AutoEllipsis = true;
            this.sessionsLabel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.sessionsLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.sessionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sessionsLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.sessionsLabel.Location = new System.Drawing.Point(0, 0);
            this.sessionsLabel.Name = "sessionsLabel";
            this.sessionsLabel.Size = new System.Drawing.Size(600, 17);
            this.sessionsLabel.TabIndex = 5;
            this.sessionsLabel.Text = "Sessions";
            this.sessionsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sessionTabControl
            // 
            this.sessionTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sessionTabControl.Location = new System.Drawing.Point(0, 45);
            this.sessionTabControl.Name = "sessionTabControl";
            this.sessionTabControl.SelectedIndex = 0;
            this.sessionTabControl.ShowToolTips = true;
            this.sessionTabControl.Size = new System.Drawing.Size(600, 530);
            this.sessionTabControl.TabIndex = 4;
            // 
            // nameColumn
            // 
            this.nameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameColumn.DataPropertyName = "Name";
            this.nameColumn.FillWeight = 40F;
            this.nameColumn.HeaderText = "Name";
            this.nameColumn.MinimumWidth = 100;
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.ReadOnly = true;
            // 
            // hostNameColumn
            // 
            this.hostNameColumn.DataPropertyName = "HostName";
            this.hostNameColumn.FillWeight = 50F;
            this.hostNameColumn.HeaderText = "Host";
            this.hostNameColumn.MinimumWidth = 100;
            this.hostNameColumn.Name = "hostNameColumn";
            this.hostNameColumn.ReadOnly = true;
            // 
            // portColumn
            // 
            this.portColumn.DataPropertyName = "Port";
            this.portColumn.FillWeight = 10F;
            this.portColumn.HeaderText = "Port";
            this.portColumn.MaxInputLength = 5;
            this.portColumn.MinimumWidth = 50;
            this.portColumn.Name = "portColumn";
            this.portColumn.ReadOnly = true;
            this.portColumn.Width = 50;
            // 
            // CacheOperationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 621);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.DoubleBuffered = true;
            this.Name = "CacheOperationsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Memcache Inspector";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CacheOperationsForm_FormClosing);
            this.Load += new System.EventHandler(this.CacheOperationsForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.connectionDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.TabControl sessionTabControl;
        private System.Windows.Forms.ToolStripMenuItem inspectorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newConnectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator inspectorSeparator1MenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutApplicationToolStripMenuItem;
        private System.Windows.Forms.DataGridView connectionDataGridView;
        private System.Windows.Forms.Label connectionsLabel;
        private System.Windows.Forms.ToolStrip connectionToolStrip;
        private System.Windows.Forms.ToolStrip sessionsToolStrip;
        private System.Windows.Forms.Label sessionsLabel;
        private System.Windows.Forms.BindingSource connectionBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hostNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn portColumn;
    }
}