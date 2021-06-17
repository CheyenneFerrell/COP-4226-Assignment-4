
namespace Assignment3_Library
{
    partial class dialogForm
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
            this.CourseInfoControl = new Assignment3_Library.courseInfo();
            this.GroupInfoControl = new Assignment3_Library.groupInfo();
            this.MiddleTransparentPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // CourseInfoControl
            // 
            this.CourseInfoControl.BackColor = System.Drawing.Color.Transparent;
            this.CourseInfoControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.CourseInfoControl.Location = new System.Drawing.Point(0, 0);
            this.CourseInfoControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CourseInfoControl.Name = "CourseInfoControl";
            this.CourseInfoControl.Size = new System.Drawing.Size(700, 90);
            this.CourseInfoControl.TabIndex = 0;
            this.CourseInfoControl.Load += new System.EventHandler(this.userControl21_Load);
            // 
            // GroupInfoControl
            // 
            this.GroupInfoControl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.GroupInfoControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GroupInfoControl.Location = new System.Drawing.Point(0, 220);
            this.GroupInfoControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GroupInfoControl.Name = "GroupInfoControl";
            this.GroupInfoControl.Size = new System.Drawing.Size(700, 118);
            this.GroupInfoControl.TabIndex = 1;
            this.GroupInfoControl.Load += new System.EventHandler(this.userControl11_Load);
            // 
            // MiddleTransparentPanel
            // 
            this.MiddleTransparentPanel.BackColor = System.Drawing.Color.Transparent;
            this.MiddleTransparentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MiddleTransparentPanel.Location = new System.Drawing.Point(0, 90);
            this.MiddleTransparentPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MiddleTransparentPanel.Name = "MiddleTransparentPanel";
            this.MiddleTransparentPanel.Size = new System.Drawing.Size(700, 130);
            this.MiddleTransparentPanel.TabIndex = 2;
            // 
            // dialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.MiddleTransparentPanel);
            this.Controls.Add(this.GroupInfoControl);
            this.Controls.Add(this.CourseInfoControl);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "dialogForm";
            this.Text = "Form2";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.ResumeLayout(false);

        }

        #endregion

        private courseInfo CourseInfoControl;
        private groupInfo GroupInfoControl;
        private System.Windows.Forms.Panel MiddleTransparentPanel;
    }
}