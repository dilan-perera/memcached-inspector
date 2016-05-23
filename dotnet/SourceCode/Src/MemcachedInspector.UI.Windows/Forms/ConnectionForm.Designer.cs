namespace MemcachedInspector.UI.Windows.Forms
{
    partial class ConnectionForm
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
            this.acceptActionButton = new System.Windows.Forms.Button();
            this.rejectActionButton = new System.Windows.Forms.Button();
            this.nameDataTextBox = new System.Windows.Forms.TextBox();
            this.nameCaptionLabel = new System.Windows.Forms.Label();
            this.hostNameCaptionLabel = new System.Windows.Forms.Label();
            this.hostNameDataTextBox = new System.Windows.Forms.TextBox();
            this.portCaptionLabel = new System.Windows.Forms.Label();
            this.portDataNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.portDataNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // acceptActionButton
            // 
            this.acceptActionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.acceptActionButton.AutoEllipsis = true;
            this.acceptActionButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.acceptActionButton.Location = new System.Drawing.Point(242, 105);
            this.acceptActionButton.Name = "acceptActionButton";
            this.acceptActionButton.Size = new System.Drawing.Size(75, 23);
            this.acceptActionButton.TabIndex = 6;
            this.acceptActionButton.Text = "O&K";
            this.acceptActionButton.UseVisualStyleBackColor = true;
            this.acceptActionButton.Click += new System.EventHandler(this.AcceptActionButton_Click);
            // 
            // rejectActionButton
            // 
            this.rejectActionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rejectActionButton.AutoEllipsis = true;
            this.rejectActionButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.rejectActionButton.Location = new System.Drawing.Point(323, 105);
            this.rejectActionButton.Name = "rejectActionButton";
            this.rejectActionButton.Size = new System.Drawing.Size(75, 23);
            this.rejectActionButton.TabIndex = 7;
            this.rejectActionButton.Text = "&Cancel";
            this.rejectActionButton.UseVisualStyleBackColor = true;
            // 
            // nameDataTextBox
            // 
            this.nameDataTextBox.Location = new System.Drawing.Point(90, 12);
            this.nameDataTextBox.Name = "nameDataTextBox";
            this.nameDataTextBox.Size = new System.Drawing.Size(308, 20);
            this.nameDataTextBox.TabIndex = 1;
            // 
            // nameCaptionLabel
            // 
            this.nameCaptionLabel.AutoSize = true;
            this.nameCaptionLabel.Location = new System.Drawing.Point(21, 15);
            this.nameCaptionLabel.Name = "nameCaptionLabel";
            this.nameCaptionLabel.Size = new System.Drawing.Size(38, 13);
            this.nameCaptionLabel.TabIndex = 0;
            this.nameCaptionLabel.Text = "&Name:";
            // 
            // hostNameCaptionLabel
            // 
            this.hostNameCaptionLabel.AutoSize = true;
            this.hostNameCaptionLabel.Location = new System.Drawing.Point(21, 41);
            this.hostNameCaptionLabel.Name = "hostNameCaptionLabel";
            this.hostNameCaptionLabel.Size = new System.Drawing.Size(63, 13);
            this.hostNameCaptionLabel.TabIndex = 2;
            this.hostNameCaptionLabel.Text = "&Host Name:";
            // 
            // hostNameDataTextBox
            // 
            this.hostNameDataTextBox.Location = new System.Drawing.Point(90, 38);
            this.hostNameDataTextBox.Name = "hostNameDataTextBox";
            this.hostNameDataTextBox.Size = new System.Drawing.Size(308, 20);
            this.hostNameDataTextBox.TabIndex = 3;
            // 
            // portCaptionLabel
            // 
            this.portCaptionLabel.AutoSize = true;
            this.portCaptionLabel.Location = new System.Drawing.Point(21, 69);
            this.portCaptionLabel.Name = "portCaptionLabel";
            this.portCaptionLabel.Size = new System.Drawing.Size(29, 13);
            this.portCaptionLabel.TabIndex = 4;
            this.portCaptionLabel.Text = "&Port:";
            // 
            // portDataNumericUpDown
            // 
            this.portDataNumericUpDown.Location = new System.Drawing.Point(90, 64);
            this.portDataNumericUpDown.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.portDataNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.portDataNumericUpDown.Name = "portDataNumericUpDown";
            this.portDataNumericUpDown.Size = new System.Drawing.Size(62, 20);
            this.portDataNumericUpDown.TabIndex = 5;
            this.portDataNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.portDataNumericUpDown.ThousandsSeparator = true;
            this.portDataNumericUpDown.Value = new decimal(new int[] {
            11211,
            0,
            0,
            0});
            // 
            // ConnectionForm
            // 
            this.AcceptButton = this.acceptActionButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.rejectActionButton;
            this.ClientSize = new System.Drawing.Size(410, 140);
            this.Controls.Add(this.portDataNumericUpDown);
            this.Controls.Add(this.portCaptionLabel);
            this.Controls.Add(this.hostNameCaptionLabel);
            this.Controls.Add(this.hostNameDataTextBox);
            this.Controls.Add(this.nameCaptionLabel);
            this.Controls.Add(this.nameDataTextBox);
            this.Controls.Add(this.rejectActionButton);
            this.Controls.Add(this.acceptActionButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConnectionForm";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Connection";
            this.Load += new System.EventHandler(this.ConnectionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.portDataNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button acceptActionButton;
        private System.Windows.Forms.Button rejectActionButton;
        private System.Windows.Forms.TextBox nameDataTextBox;
        private System.Windows.Forms.Label nameCaptionLabel;
        private System.Windows.Forms.Label hostNameCaptionLabel;
        private System.Windows.Forms.TextBox hostNameDataTextBox;
        private System.Windows.Forms.Label portCaptionLabel;
        private System.Windows.Forms.NumericUpDown portDataNumericUpDown;
    }
}