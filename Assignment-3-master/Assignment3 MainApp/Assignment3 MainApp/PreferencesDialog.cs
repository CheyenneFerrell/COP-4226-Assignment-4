using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Assignment3_Library;


namespace Assignment3_MainApp
{
    public partial class PreferencesDialog : dialogForm
    {

        //0 - None, 1 - OK, 2 - Apply, 3 - Cancel
        public int Ell_W { set; get; }
        public int Rect_W { set; get; }
        public float Ell_H { set; get; }
        public float Rect_H { set; get; }

        public int buttonResult = 0;
        public PreferencesDialog()
        {
            InitializeComponent();
        }

        private void PreferencesDialog_Load(object sender, EventArgs e)
        {

        }


        private void EllipticWidthTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(EllipticWidthTextBox.Text))
            {
                e.Cancel = true;
                EllipticWidthTextBox.Focus();
            }

            int n;
            bool isNumeric = int.TryParse(EllipticWidthTextBox.Text, out n);

            if (!isNumeric)
            {
                e.Cancel = true;
                EllipticWidthTextBox.Focus();
            }
        }

        private void RectangleHeightTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(RectangleHeightTextBox.Text))
            {
                e.Cancel = true;
                RectangleHeightTextBox.Focus();
            }

            int n;
            bool isNumeric = int.TryParse(RectangleHeightTextBox.Text, out n);

            if (!isNumeric)
            {
                e.Cancel = true;
                RectangleHeightTextBox.Focus();
            }
        }

        private void WHRatioTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(WHRatioTextBox.Text))
            {
                e.Cancel = true;
                WHRatioTextBox.Focus();
            }

            float n;
            bool isNumeric = float.TryParse(WHRatioTextBox.Text, out n);

            if (!isNumeric)
            {
                e.Cancel = true;
                WHRatioTextBox.Focus();
            }
        }

        private void OKButton_Click(object sender, EventArgs e)
        {

            float ratio = float.Parse(WHRatioTextBox.Text);
            Ell_W = Int32.Parse(EllipticWidthTextBox.Text);
            Rect_H = Int64.Parse(RectangleHeightTextBox.Text);
            Rect_W = (int)(Rect_H * ratio);
            Ell_H = Ell_W / ratio;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            float ratio = float.Parse(WHRatioTextBox.Text);
            Ell_W = int.Parse(EllipticWidthTextBox.Text);
            Rect_H = Int64.Parse(RectangleHeightTextBox.Text);
            Rect_W = (int)(Rect_H * ratio);
            Ell_H = Ell_W / ratio;
            buttonResult = 2;
            
            MessageBox.Show("The apply is clicked " + Ell_H);
        }

        public void Disable_Apply_button()
        {
            ApplyButton.Enabled = true;
        }

        public void Enable_Apply_Button()
        {
            ApplyButton.Enabled = true;
        }

       
    }


}
