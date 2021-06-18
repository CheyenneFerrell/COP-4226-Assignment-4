using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Assignment3_Library
{
    public partial class baseForm : Form
    {


        public baseForm()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening_2(object sender, CancelEventArgs e)
        {
            colorMenuItem.Click += new System.EventHandler(this.colorMenuItem1_Click);
            closeMenuItem.Click += new System.EventHandler(this.closeMenuItem1_Click);


        }
        private void colorMenuItem1_Click(object sender, System.EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = dlg.Color;
            }

        }

        private void closeMenuItem1_Click(object sender, System.EventArgs e)
        {
            this.Close();

        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        //mousedown on where ever u wanna use the moving of form function in
        private void topPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void colorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = dlg.Color;
            }
        }

        private void closeChildToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }
