using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Assignment3_MainApp
{
    public partial class MainForm : Form
    {
        int numOfEll = 0;
        int numOfRect = 0;
        public float rect_H = 3;
        public int rect_W = 5;
        public float ellip_H = 3;
        public int ellip_W = 5;
        public Elliptic[] elliptic_arr = new Elliptic[20];
        public Rectangle[] rectangle_arr = new Rectangle[20];
        PreferencesDialog pDialog = new PreferencesDialog(); 

        public MainForm()
        {
            InitializeComponent();
            OpenPreferencesModallyItem.Click += new EventHandler(OpenPreferences_Modally);
            OpenPreferencesModelesslyItem.Click += new EventHandler(OpenPreferences_Modelessly);

            OpenElliptic.Click += new EventHandler(Open_Elliptic_Shape);
            CloseAllElliptics.Click += new EventHandler(Close_All_Elliptics);

            OpenRectangle.Click += new EventHandler(Open_Rectangle_Shape);
            CloseAllRectangles.Click += new EventHandler(Close_All_Rectangles);

            CloseApplication.Click += new EventHandler(Close_Application);
        }

        private void OpenPreferences_Modally(object sender, EventArgs e)
        {
            pDialog = new PreferencesDialog();
            pDialog.Disable_Apply_button();
            if (pDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.ellip_H = pDialog.Ell_H;
                this.ellip_W = pDialog.Ell_W;
                this.rect_H = pDialog.Rect_H;
                this.rect_W = pDialog.Rect_W;
                
            }
        }

        private void OpenPreferences_Modelessly(object sender, EventArgs e)
        {
            pDialog = new PreferencesDialog();
            //pDialog.ShowDialog();
            if (pDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.ellip_H = pDialog.Ell_H;
                this.ellip_W = pDialog.Ell_W;
                this.rect_H = pDialog.Rect_H;
                this.rect_W = pDialog.Rect_W;
                
            }

        }

        private void Open_Elliptic_Shape(object sender, EventArgs e)
        {
            elliptic_arr[numOfEll] = new Elliptic(this.ellip_H,this.ellip_W);

            elliptic_arr[numOfEll].Show();

            numOfEll++;

        }

        private void Open_Rectangle_Shape(object sender, EventArgs e)
        {
            rectangle_arr[numOfRect] = new Rectangle(this.rect_H,this.rect_W);


            rectangle_arr[numOfRect].Show();

            numOfRect++;
        }

        private void Close_All_Elliptics(object sender, EventArgs e)
        {
            for (int i = 0; i < numOfEll; i++)
            {
                elliptic_arr[i].Close();
            
            }
            
        }

        private void Close_All_Rectangles(object sender, EventArgs e)
        {
            for (int i = 0; i < numOfRect; i++)
            {
                rectangle_arr[i].Close();

            }
        }


        private void Close_Application(object sender, EventArgs e)
        {
            if (MessageBox.Show("You have some names saved.Do you want to close.CONFIRM", "Close Application", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("The program will close", "Closing", MessageBoxButtons.OK);
            }
            else
            {
               
                this.Activate();

            }
        }

        private void Menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void PreferencesDialog_Leave(object sender, FormClosingEventArgs  e)
        {
            this.ellip_H = pDialog.Ell_H;
            this.ellip_W = pDialog.Ell_W;
            this.rect_H = pDialog.Rect_H;
            this.rect_W = pDialog.Rect_W;
            MessageBox.Show("Leaving and adding values" + ellip_H);
        }

        private void PreferencesDialog_Closed(object sender, FormClosedEventArgs e)
        {
            this.ellip_H = pDialog.Ell_H;
            this.ellip_W = pDialog.Ell_W;
            this.rect_H = pDialog.Rect_H;
            this.rect_W = pDialog.Rect_W;
            MessageBox.Show("Leaving and adding values" + ellip_H);

        }

        private void Close_Application_M(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to close the application", "Close Application", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("The program will close", "Closing", MessageBoxButtons.OK);
            }
            else
            {
                e.Cancel = true;
                this.Activate();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
