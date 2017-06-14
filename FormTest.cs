using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tesseract.WinFormDemo.OCR;

namespace Tesseract.WinFormDemo
{
    public partial class FormTest : Form
    {
        /// <summary>
        /// 识别模板实例
        /// </summary>
        RecognitionTemplate rcgTmp = new RecognitionTemplate();

        bool bDrawStart = false;  //是否开始画了 
        bool bChange = false; //是否要修改矩形，以鼠标点击点在矩形内部为准，修改时自动在4个端点创建4个小方框，不能创建其他的矩形 
        //bool bChangeMove = false;  //修改矩形时鼠标点击进4个小方框内，确认要根据鼠标移动修改 

        Point pointStart = Point.Empty; //矩形的起始点 
        Point pointContinue = Point.Empty; //矩形的起始点的对角点，鼠标移动点 

        PaneType curPaneType = PaneType.Title; //当前画的框体类型
        
        BasePane curChangingPane; //当前修改的Pane
        //修改矩形时移动点的X、Y记录，好根据它在dicPoints找到对应的矩形，或dicPointsChange找到对应小方框 
        Point pMove1 = Point.Empty;
        Point pMove2 = Point.Empty;
        
        public FormTest()
        {
            InitializeComponent();
        }

        private void FormTest_Load(object sender, EventArgs e)
        { 
            picbMain.Image = Bitmap.FromFile(@"F:\AbnerLib\Git\repository\woodrow\woodrow\Original.jpg");
        }

        private void picbMain_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.LimeGreen);
            pen.Width = 2;
            if (bDrawStart && !bChange)
            {
                //实时的画矩形
                Graphics g = e.Graphics;
                g.DrawRectangle(pen, pointStart.X, pointStart.Y, pointContinue.X - pointStart.X, pointContinue.Y - pointStart.Y);
            }

            //实时的画之前已经画好的矩形
            foreach (BasePane item in rcgTmp.ExistsPanes)
            {
                Point p1 = item.StartPoint;
                Point p2 = item.EndPoint;
                e.Graphics.DrawRectangle(pen, p1.X, p1.Y, p2.X - p1.X, p2.Y - p1.Y);
            }

            pen.Width = 1;
            pen.Color = Color.Red;
            foreach (BasePane item in rcgTmp.TinyPanes)
            {
                Point p1 = item.StartPoint;
                Point p2 = item.EndPoint;
                e.Graphics.DrawRectangle(pen, p1.X, p1.Y, p2.X - p1.X, p2.Y - p1.Y);
            }
            
            pen.Dispose();
        }

        private void picbMain_MouseDown(object sender, MouseEventArgs e)
        {
            

            if (bChange)
            {
                bDrawStart = false;
                //判断是否点在框体里
                if (curChangingPane != null && curChangingPane.IsInside(e.Location))
                {
                    return;
                }
                else
                {
                    bChange = false;
                    rcgTmp.TinyPanes.Clear();
                    Refresh();
                }
                
            }
            else
            {
                foreach (BasePane pane in rcgTmp.ExistsPanes)
                {
                    Point p1 = pane.StartPoint;
                    Point p2 = pane.EndPoint;
                    
                    if(pane.IsInside(e.Location))
                    {
                        bDrawStart = false; //不能画新矩形了
                        bChange = true;
                        rcgTmp.TinyPanes.Clear();
                        pMove1 = p1;
                        pMove2 = p2;

                        //画出点击矩形的4个端点的4个小方框
                        Graphics g = picbMain.CreateGraphics();
                        System.Drawing.Pen pen = new System.Drawing.Pen(Color.Red);
                        g.DrawRectangle(pen, p1.X - 5, p1.Y - 5, 10, 10);
                        g.DrawRectangle(pen, p2.X - 5, p2.Y - 5, 10, 10);
                        g.DrawRectangle(pen, p1.X - 5, p2.Y - 5, 10, 10);
                        g.DrawRectangle(pen, p2.X - 5, p1.Y - 5, 10, 10);
                        pen.Dispose();

                        ChangPane changPane1 = new ChangPane() { StartPoint = new Point(p1.X - 5, p1.Y - 5), EndPoint = new Point(p1.X + 5, p1.Y + 5) };
                        ChangPane changPane2 = new ChangPane() { StartPoint = new Point(p2.X - 5, p2.Y - 5), EndPoint = new Point(p2.X + 5, p2.Y + 5) };
                        ChangPane changPane3 = new ChangPane() { StartPoint = new Point(p2.X - 5, p1.Y - 5), EndPoint = new Point(p2.X + 5, p1.Y + 5) };
                        ChangPane changPane4 = new ChangPane() { StartPoint = new Point(p1.X - 5, p2.Y - 5), EndPoint = new Point(p1.X + 5, p2.Y + 5) };
                        rcgTmp.TinyPanes.Add(changPane1);
                        rcgTmp.TinyPanes.Add(changPane2);
                        rcgTmp.TinyPanes.Add(changPane3);
                        rcgTmp.TinyPanes.Add(changPane4);

                        curChangingPane = pane;
                        break;
                    }
                }
            }

            if (bChange)
            {
                bDrawStart = false;
                return;
            }

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
            if (bChange)
            {
                return;
            }

            if (bDrawStart)
            {
                pointContinue = e.Location;
                Refresh();
            }

            Refresh();
        }

        private void picbMain_MouseUp(object sender, MouseEventArgs e)
        {
            if (bChange)
            {
                return;
            }
            if (bDrawStart)
            {
                if ((Math.Abs(pointStart.X - pointContinue.X) < 3 || Math.Abs(pointStart.Y - pointContinue.Y) < 3)
                    || (pointContinue.X == 0 && pointContinue.Y == 0))
                {
                    //当框体太小时或者结束像素点为Empty时，不画框。
                    bDrawStart = false;
                }
                else
                {
                    //此时矩形画完，记录矩形两个对角点，在Paint里画
                    if (curPaneType == PaneType.Title)
                    {
                        TitlePane titlePane = new OCR.TitlePane();
                        titlePane.Name = "金额";  //TODO 设置name与code
                        titlePane.Code = "T001";
                        titlePane.StartPoint = pointStart;
                        titlePane.EndPoint = pointContinue;
                        rcgTmp.ExistsPanes.Add(titlePane);
                    }
                }
                pointStart = Point.Empty;
                pointContinue = Point.Empty;

            }

            bDrawStart = false;
        }
    }
}
