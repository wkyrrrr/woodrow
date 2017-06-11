using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tesseract.WinFormDemo
{
    public partial class FormTest : Form
    {
        //是否开始画了 
        bool bDrawStart = false;
        //矩形的起始点 
        Point pointStart = Point.Empty;
        //矩形的起始点的对角点，鼠标移动点 
        Point pointContinue = Point.Empty;

        public FormTest()
        {
            InitializeComponent();
        }

        private void FormTest_Load(object sender, EventArgs e)
        { 
            picbMain.Image = Bitmap.FromFile(@"E:\AbnerLib\TesseractLib\Tess4NET\Original.jpg");
        }

        private void picbMain_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Pen pen = new System.Drawing.Pen(Color.LimeGreen);
            pen.Width = 2;
            if (bDrawStart)
            {
                //实时的画矩形
                Graphics g = e.Graphics;
                g.DrawRectangle(pen, pointStart.X, pointStart.Y, pointContinue.X - pointStart.X, pointContinue.Y - pointStart.Y);
            }
        }

        private void picbMain_MouseDown(object sender, MouseEventArgs e)
        {
            if (bDrawStart)
            {
                bDrawStart = false;
            }
            else
            {
                bDrawStart = true;
                pointStart = e.Location;
            }
        }

        private void picbMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (bDrawStart)
            {
                pointContinue = e.Location;
                Refresh();
            }
        }

        private void picbMain_MouseUp(object sender, MouseEventArgs e)
        {
            bDrawStart = false;
        }
    }
}
