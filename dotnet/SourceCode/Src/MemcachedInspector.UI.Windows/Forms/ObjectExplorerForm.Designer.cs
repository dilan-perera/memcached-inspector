namespace MemcachedInspector.UI.Windows.Forms
{
    partial class ObjectExplorerForm
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
            this.rejectActionButton = new System.Windows.Forms.Button();
            this.acceptActionButton = new System.Windows.Forms.Button();
            this.objectDataPropertyGrid = new System.Windows.Forms.PropertyGrid();
            this.SuspendLayout();
            // 
            // rejectActionButton
            // 
            this.rejectActionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rejectActionButton.AutoEllipsis = true;
            this.rejectActionButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.rejectActionButton.Location = new System.Drawing.Point(497, 376);
            this.rejectActionButton.Name = "rejectActionButton";
            this.rejectActionButton.Size = new System.Drawing.Size(75, 23);
            this.rejectActionButton.TabIndex = 9;
            this.rejectActionButton.Text = "&Cancel";
            this.rejectActionButton.UseVisualStyleBackColor = true;
            // 
            // acceptActionButton
            // 
            this.acceptActionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.acceptActionButton.AutoEllipsis = true;
            this.acceptActionButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.acceptActionButton.Location = new System.Drawing.Point(416, 376);
            this.acceptActionButton.Name = "acceptActionButton";
            this.acceptActionButton.Size = new System.Drawing.Size(75, 23);
            this.acceptActionButton.TabIndex = 8;
            this.acceptActionButton.Text = "O&K";
            this.acceptActionButton.UseVisualStyleBackColor = true;
            // 
            // objectDataPropertyGrid
            // 
            this.objectDataPropertyGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.objectDataPropertyGrid.HelpVisible = false;
            this.objectDataPropertyGrid.Location = new System.Drawing.Point(12, 12);
            this.objectDataPropertyGrid.Name = "objectDataPropertyGrid";
            this.objectDataPropertyGrid.PropertySort = System.Windows.Forms.PropertySort.Alphabetical;
            this.objectDataPropertyGrid.Size = new System.Drawing.Size(560, 358);
            this.objectDataPropertyGrid.TabIndex = 10;
            this.objectDataPropertyGrid.ToolbarVisible = false;
            // 
            // ObjectExplorerForm
            // 
            this.AcceptButton = this.acceptActionButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.rejectActionButton;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.objectDataPropertyGrid);
            this.Controls.Add(this.rejectActionButton);
            this.Controls.Add(this.acceptActionButton);
            this.DoubleBuffered = true;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 450);
            this.Name = "ObjectExplorerForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Explore Object";
            this.Load += new System.EventHandler(this.ObjectExplorerForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button rejectActionButton;
        private System.Windows.Forms.Button acceptActionButton;
        private System.Windows.Forms.PropertyGrid objectDataPropertyGrid;
    }
}