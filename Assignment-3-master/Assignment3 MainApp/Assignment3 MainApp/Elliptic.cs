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
    public partial class Elliptic : baseForm
    {
        public float ShapeHeight;
        public int ShapeWidth;
        public Elliptic(float p, int Width)
        {
            InitializeComponent();
            ShapeWidth = Width;
            ShapeHeight = Width * p;
        }

        private void Elliptic_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath shape = new System.Drawing.Drawing2D.GraphicsPath();
            shape.AddEllipse(0, 0, this.Width, this.Height);
            this.Region = new System.Drawing.Region(shape);
        }
    }
}
