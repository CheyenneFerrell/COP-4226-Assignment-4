using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Assignment3_Library;

namespace Assignment3_MainApp
{
    public partial class Rectangle : baseForm
    {

        public int ShapeHeight;
        public float ShapeWidth;
        public Rectangle(float p, int height)
        {
            InitializeComponent();
            ShapeHeight = height;
            ShapeWidth = height * p;
        }

        private void Rectangle_Load(object sender, EventArgs e)
        {

        }
    }
}
