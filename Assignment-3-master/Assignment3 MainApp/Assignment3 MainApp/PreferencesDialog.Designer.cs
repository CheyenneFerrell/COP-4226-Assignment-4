
namespace Assignment3_MainApp
{
    partial class PreferencesDialog
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreferencesDialog));
            this.OKButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.InputPanel = new System.Windows.Forms.Panel();
            this.WHRatio = new System.Windows.Forms.Label();
            this.RectangleHeightLabel = new System.Windows.Forms.Label();
            this.EllipticWidthLabel = new System.Windows.Forms.Label();
            this.WHRatioTextBox = new System.Windows.Forms.TextBox();
            this.RectangleHeightTextBox = new System.Windows.Forms.TextBox();
            this.EllipticWidthTextBox = new System.Windows.Forms.TextBox();
            this.InputPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // OKButton
            // 
            this.OKButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OKButton.Location = new System.Drawing.Point(854, 421);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 9;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.Location = new System.Drawing.Point(854, 455);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 10;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ApplyButton
            // 
            this.ApplyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ApplyButton.Location = new System.Drawing.Point(854, 491);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(75, 23);
            this.ApplyButton.TabIndex = 11;
            this.ApplyButton.Text = "Apply";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // InputPanel
            // 
            this.InputPanel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.InputPanel.BackColor = System.Drawing.Color.MistyRose;
            this.InputPanel.Controls.Add(this.WHRatio);
            this.InputPanel.Controls.Add(this.RectangleHeightLabel);
            this.InputPanel.Controls.Add(this.EllipticWidthLabel);
            this.InputPanel.Controls.Add(this.WHRatioTextBox);
            this.InputPanel.Controls.Add(this.RectangleHeightTextBox);
            this.InputPanel.Controls.Add(this.EllipticWidthTextBox);
            this.InputPanel.Location = new System.Drawing.Point(342, 421);
            this.InputPanel.Name = "InputPanel";
            this.InputPanel.Size = new System.Drawing.Size(266, 100);
            this.InputPanel.TabIndex = 12;
            // 
            // WHRatio
            // 
            this.WHRatio.AutoSize = true;
            this.WHRatio.Location = new System.Drawing.Point(26, 78);
            this.WHRatio.Name = "WHRatio";
            this.WHRatio.Size = new System.Drawing.Size(110, 15);
            this.WHRatio.TabIndex = 5;
            this.WHRatio.Text = "Width/Height Ratio";
            // 
            // RectangleHeightLabel
            // 
            this.RectangleHeightLabel.AutoSize = true;
            this.RectangleHeightLabel.Location = new System.Drawing.Point(38, 50);
            this.RectangleHeightLabel.Name = "RectangleHeightLabel";
            this.RectangleHeightLabel.Size = new System.Drawing.Size(98, 15);
            this.RectangleHeightLabel.TabIndex = 4;
            this.RectangleHeightLabel.Text = "Rectangle Height";
            // 
            // EllipticWidthLabel
            // 
            this.EllipticWidthLabel.AutoSize = true;
            this.EllipticWidthLabel.Location = new System.Drawing.Point(59, 19);
            this.EllipticWidthLabel.Name = "EllipticWidthLabel";
            this.EllipticWidthLabel.Size = new System.Drawing.Size(77, 15);
            this.EllipticWidthLabel.TabIndex = 3;
            this.EllipticWidthLabel.Text = "Elliptic Width";
            // 
            // WHRatioTextBox
            // 
            this.WHRatioTextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.WHRatioTextBox.Location = new System.Drawing.Point(142, 71);
            this.WHRatioTextBox.Name = "WHRatioTextBox";
            this.WHRatioTextBox.Size = new System.Drawing.Size(100, 23);
            this.WHRatioTextBox.TabIndex = 2;
            this.WHRatioTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.WHRatioTextBox_Validating);
            // 
            // RectangleHeightTextBox
            // 
            this.RectangleHeightTextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.RectangleHeightTextBox.Location = new System.Drawing.Point(142, 42);
            this.RectangleHeightTextBox.Name = "RectangleHeightTextBox";
            this.RectangleHeightTextBox.Size = new System.Drawing.Size(100, 23);
            this.RectangleHeightTextBox.TabIndex = 1;
            this.RectangleHeightTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.RectangleHeightTextBox_Validating);
            // 
            // EllipticWidthTextBox
            // 
            this.EllipticWidthTextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.EllipticWidthTextBox.Location = new System.Drawing.Point(142, 11);
            this.EllipticWidthTextBox.Name = "EllipticWidthTextBox";
            this.EllipticWidthTextBox.Size = new System.Drawing.Size(100, 23);
            this.EllipticWidthTextBox.TabIndex = 0;
            this.EllipticWidthTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.EllipticWidthTextBox_Validating);
            // 
            // PreferencesDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(941, 526);
            this.Controls.Add(this.InputPanel);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OKButton);
            this.Name = "PreferencesDialog";
            this.Text = "Preferences";
            this.Load += new System.EventHandler(this.PreferencesDialog_Load);
  
            this.Controls.SetChildIndex(this.OKButton, 0);
            this.Controls.SetChildIndex(this.CancelButton, 0);
            this.Controls.SetChildIndex(this.ApplyButton, 0);
            this.Controls.SetChildIndex(this.InputPanel, 0);
            this.InputPanel.ResumeLayout(false);
            this.InputPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.Panel InputPanel;
        private System.Windows.Forms.Label WHRatio;
        private System.Windows.Forms.Label RectangleHeightLabel;
        private System.Windows.Forms.Label EllipticWidthLabel;
        private System.Windows.Forms.TextBox WHRatioTextBox;
        private System.Windows.Forms.TextBox RectangleHeightTextBox;
        private System.Windows.Forms.TextBox EllipticWidthTextBox;
    }
}

