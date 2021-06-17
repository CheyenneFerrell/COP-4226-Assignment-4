
namespace Assignment3_MainApp
{
    partial class MainForm
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
            this.ContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.OpenPreferencesModallyItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenPreferencesModelesslyItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenContextMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.FileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenElliptic = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenRectangle = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenCloseSeperator = new System.Windows.Forms.ToolStripSeparator();
            this.CloseAllRectangles = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseAllElliptics = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseShapeCloseAppSeperator = new System.Windows.Forms.ToolStripSeparator();
            this.CloseApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenu.SuspendLayout();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContextMenu
            // 
            this.ContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenPreferencesModallyItem,
            this.OpenPreferencesModelesslyItem});
            this.ContextMenu.Name = "ContextMenu";
            this.ContextMenu.OwnerItem = this.OpenContextMenu;
            this.ContextMenu.Size = new System.Drawing.Size(230, 48);
            // 
            // OpenPreferencesModallyItem
            // 
            this.OpenPreferencesModallyItem.Name = "OpenPreferencesModallyItem";
            this.OpenPreferencesModallyItem.Size = new System.Drawing.Size(229, 22);
            this.OpenPreferencesModallyItem.Text = "Open Preferences Modally";
            // 
            // OpenPreferencesModelesslyItem
            // 
            this.OpenPreferencesModelesslyItem.Name = "OpenPreferencesModelesslyItem";
            this.OpenPreferencesModelesslyItem.Size = new System.Drawing.Size(229, 22);
            this.OpenPreferencesModelesslyItem.Text = "Open Preferences Modelessly";
            // 
            // OpenContextMenu
            // 
            this.OpenContextMenu.DropDown = this.ContextMenu;
            this.OpenContextMenu.Name = "OpenContextMenu";
            this.OpenContextMenu.Size = new System.Drawing.Size(80, 20);
            this.OpenContextMenu.Text = "Preferences";
            // 
            // Menu
            // 
            this.Menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenu,
            this.OpenContextMenu});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(800, 24);
            this.Menu.TabIndex = 1;
            this.Menu.Text = "Menu";
            this.Menu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.Menu_ItemClicked);
            // 
            // FileMenu
            // 
            this.FileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenElliptic,
            this.OpenRectangle,
            this.OpenCloseSeperator,
            this.CloseAllRectangles,
            this.CloseAllElliptics,
            this.CloseShapeCloseAppSeperator,
            this.CloseApplication});
            this.FileMenu.Name = "FileMenu";
            this.FileMenu.Size = new System.Drawing.Size(37, 20);
            this.FileMenu.Text = "File";
            // 
            // OpenElliptic
            // 
            this.OpenElliptic.Name = "OpenElliptic";
            this.OpenElliptic.Size = new System.Drawing.Size(180, 22);
            this.OpenElliptic.Text = "Create Elliptic";
            // 
            // OpenRectangle
            // 
            this.OpenRectangle.Name = "OpenRectangle";
            this.OpenRectangle.Size = new System.Drawing.Size(180, 22);
            this.OpenRectangle.Text = "Create Rectangle";
            // 
            // OpenCloseSeperator
            // 
            this.OpenCloseSeperator.Name = "OpenCloseSeperator";
            this.OpenCloseSeperator.Size = new System.Drawing.Size(177, 6);
            // 
            // CloseAllRectangles
            // 
            this.CloseAllRectangles.Name = "CloseAllRectangles";
            this.CloseAllRectangles.Size = new System.Drawing.Size(180, 22);
            this.CloseAllRectangles.Text = "Close All Rectangles";
            // 
            // CloseAllElliptics
            // 
            this.CloseAllElliptics.Name = "CloseAllElliptics";
            this.CloseAllElliptics.Size = new System.Drawing.Size(180, 22);
            this.CloseAllElliptics.Text = "Close All Elliptics";
            // 
            // CloseShapeCloseAppSeperator
            // 
            this.CloseShapeCloseAppSeperator.Name = "CloseShapeCloseAppSeperator";
            this.CloseShapeCloseAppSeperator.Size = new System.Drawing.Size(177, 6);
            // 
            // CloseApplication
            // 
            this.CloseApplication.Name = "CloseApplication";
            this.CloseApplication.Size = new System.Drawing.Size(180, 22);
            this.CloseApplication.Text = "Close App";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.ContextMenu;
            this.Controls.Add(this.Menu);
            this.MainMenuStrip = this.Menu;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ContextMenu.ResumeLayout(false);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Close_Application_M);
            pDialog.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PreferencesDialog_Leave);
            pDialog.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PreferencesDialog_Closed);
            

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip ContextMenu;
        private System.Windows.Forms.ToolStripMenuItem OpenPreferencesModallyItem;
        private System.Windows.Forms.ToolStripMenuItem OpenPreferencesModelesslyItem;
        private System.Windows.Forms.ToolStripMenuItem OpenContextMenu;
        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem FileMenu;
        private System.Windows.Forms.ToolStripMenuItem OpenElliptic;
        private System.Windows.Forms.ToolStripMenuItem OpenRectangle;
        private System.Windows.Forms.ToolStripSeparator OpenCloseSeperator;
        private System.Windows.Forms.ToolStripMenuItem CloseAllRectangles;
        private System.Windows.Forms.ToolStripMenuItem CloseAllElliptics;
        private System.Windows.Forms.ToolStripSeparator CloseShapeCloseAppSeperator;
        private System.Windows.Forms.ToolStripMenuItem CloseApplication;
    }
}