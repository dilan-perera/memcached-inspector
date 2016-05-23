namespace MemcachedInspector.UI.Windows.Controls
{
    partial class CacheOperationsControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sessionContentContainerPanel = new System.Windows.Forms.SplitContainer();
            this.contentSplitContainer = new System.Windows.Forms.SplitContainer();
            this.slabsDataGridView = new System.Windows.Forms.DataGridView();
            this.itemsDataGridView = new System.Windows.Forms.DataGridView();
            this.consoleInputDataTextBox = new System.Windows.Forms.TextBox();
            this.consoleOutputDataTextBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.sessionContentContainerPanel)).BeginInit();
            this.sessionContentContainerPanel.Panel1.SuspendLayout();
            this.sessionContentContainerPanel.Panel2.SuspendLayout();
            this.sessionContentContainerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contentSplitContainer)).BeginInit();
            this.contentSplitContainer.Panel1.SuspendLayout();
            this.contentSplitContainer.Panel2.SuspendLayout();
            this.contentSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slabsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // sessionContentContainerPanel
            // 
            this.sessionContentContainerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sessionContentContainerPanel.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.sessionContentContainerPanel.Location = new System.Drawing.Point(0, 0);
            this.sessionContentContainerPanel.Name = "sessionContentContainerPanel";
            this.sessionContentContainerPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // sessionContentContainerPanel.Panel1
            // 
            this.sessionContentContainerPanel.Panel1.Controls.Add(this.contentSplitContainer);
            this.sessionContentContainerPanel.Panel1MinSize = 280;
            // 
            // sessionContentContainerPanel.Panel2
            // 
            this.sessionContentContainerPanel.Panel2.Controls.Add(this.consoleInputDataTextBox);
            this.sessionContentContainerPanel.Panel2.Controls.Add(this.consoleOutputDataTextBox);
            this.sessionContentContainerPanel.Panel2MinSize = 100;
            this.sessionContentContainerPanel.Size = new System.Drawing.Size(707, 495);
            this.sessionContentContainerPanel.SplitterDistance = 391;
            this.sessionContentContainerPanel.TabIndex = 0;
            // 
            // contentSplitContainer
            // 
            this.contentSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.contentSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.contentSplitContainer.Name = "contentSplitContainer";
            // 
            // contentSplitContainer.Panel1
            // 
            this.contentSplitContainer.Panel1.Controls.Add(this.slabsDataGridView);
            this.contentSplitContainer.Panel1MinSize = 200;
            // 
            // contentSplitContainer.Panel2
            // 
            this.contentSplitContainer.Panel2.Controls.Add(this.itemsDataGridView);
            this.contentSplitContainer.Panel2MinSize = 500;
            this.contentSplitContainer.Size = new System.Drawing.Size(707, 391);
            this.contentSplitContainer.SplitterDistance = 200;
            this.contentSplitContainer.TabIndex = 0;
            // 
            // slabsDataGridView
            // 
            this.slabsDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.slabsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.slabsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.slabsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.slabsDataGridView.MultiSelect = false;
            this.slabsDataGridView.Name = "slabsDataGridView";
            this.slabsDataGridView.ReadOnly = true;
            this.slabsDataGridView.RowHeadersVisible = false;
            this.slabsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.slabsDataGridView.Size = new System.Drawing.Size(200, 391);
            this.slabsDataGridView.TabIndex = 0;
            // 
            // itemsDataGridView
            // 
            this.itemsDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.itemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.itemsDataGridView.MultiSelect = false;
            this.itemsDataGridView.Name = "itemsDataGridView";
            this.itemsDataGridView.ReadOnly = true;
            this.itemsDataGridView.RowHeadersVisible = false;
            this.itemsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.itemsDataGridView.Size = new System.Drawing.Size(503, 391);
            this.itemsDataGridView.TabIndex = 0;
            // 
            // consoleInputDataTextBox
            // 
            this.consoleInputDataTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.consoleInputDataTextBox.BackColor = System.Drawing.Color.Black;
            this.consoleInputDataTextBox.ForeColor = System.Drawing.Color.White;
            this.consoleInputDataTextBox.Location = new System.Drawing.Point(0, 80);
            this.consoleInputDataTextBox.Name = "consoleInputDataTextBox";
            this.consoleInputDataTextBox.Size = new System.Drawing.Size(707, 20);
            this.consoleInputDataTextBox.TabIndex = 7;
            // 
            // consoleOutputDataTextBox
            // 
            this.consoleOutputDataTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.consoleOutputDataTextBox.BackColor = System.Drawing.Color.Black;
            this.consoleOutputDataTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.consoleOutputDataTextBox.ForeColor = System.Drawing.Color.Lime;
            this.consoleOutputDataTextBox.Location = new System.Drawing.Point(0, 0);
            this.consoleOutputDataTextBox.Name = "consoleOutputDataTextBox";
            this.consoleOutputDataTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.consoleOutputDataTextBox.Size = new System.Drawing.Size(707, 81);
            this.consoleOutputDataTextBox.TabIndex = 6;
            this.consoleOutputDataTextBox.Text = "";
            // 
            // CacheOperationsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sessionContentContainerPanel);
            this.DoubleBuffered = true;
            this.Name = "CacheOperationsControl";
            this.Size = new System.Drawing.Size(707, 495);
            this.Load += new System.EventHandler(this.CacheOperationsControl_Load);
            this.sessionContentContainerPanel.Panel1.ResumeLayout(false);
            this.sessionContentContainerPanel.Panel2.ResumeLayout(false);
            this.sessionContentContainerPanel.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sessionContentContainerPanel)).EndInit();
            this.sessionContentContainerPanel.ResumeLayout(false);
            this.contentSplitContainer.Panel1.ResumeLayout(false);
            this.contentSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.contentSplitContainer)).EndInit();
            this.contentSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.slabsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer sessionContentContainerPanel;
        private System.Windows.Forms.TextBox consoleInputDataTextBox;
        private System.Windows.Forms.RichTextBox consoleOutputDataTextBox;
        private System.Windows.Forms.SplitContainer contentSplitContainer;
        private System.Windows.Forms.DataGridView slabsDataGridView;
        private System.Windows.Forms.DataGridView itemsDataGridView;
    }
}
