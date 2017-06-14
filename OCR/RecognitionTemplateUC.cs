using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Tesseract.WinFormDemo.OCR
{
    public partial class RecognitionTemplateUC : UserControl
    {
        /// <summary>
        /// 识别模板实例
        /// </summary>
        private RecognitionTemplate rcgTmp = new RecognitionTemplate();
        
        bool bDrawStart = false;  //是否开始画了 
        bool bChange = false; //是否要修改矩形，以鼠标点击点在矩形内部为准，修改时自动在4个端点创建4个小方框，不能创建其他的矩形 
        Point pointStart = Point.Empty; //矩形的起始点 
        Point pointContinue = Point.Empty; //矩形的起始点的对角点，鼠标移动点 
        PaneType curPaneType = PaneType.Title; //当前画的框体类型

        private BasePane curChangingPane; //当前修改的Pane
        private Image image;

        public Image Image
        {
            get
            {
                return image;
            }
        }

        public RecognitionTemplate RcgTmp
        {
            get
            {
                return rcgTmp;
            }
        }

        public RecognitionTemplateUC()
        {
            InitializeComponent();
            registerEventForPicBox();
        }

        public void SetImage(string imageFullName)
        {
            if (!File.Exists(imageFullName))
            {
                throw new FileNotFoundException();
            }
            
            picbMain.Image = Bitmap.FromFile(imageFullName);
            image = picbMain.Image;
            rcgTmp.ModImage = picbMain.Image;
            rcgTmp.ModContentWidth = picbMain.Size.Width;
            rcgTmp.ModContentHeight = picbMain.Size.Height;
            txtImageSize.Text = image.Width + "X" +image.Height;
        }
        
        private void picbMain_Paint(object sender, PaintEventArgs e)
        {
            if (image == null)
            {
                return;
            }

            //根据类型不同设置不同颜色的画笔
            Pen pen;
            switch (curPaneType)
            {
                case PaneType.Title:
                    pen = new Pen(Color.Blue);
                    break;
                case PaneType.Content:
                    pen = new Pen(Color.LimeGreen);
                    break;
                default:
                    pen = new Pen(Color.Blue);
                    break;
            }
            pen.Width = 2;
            if (bDrawStart && !bChange)
            {
                //实时的画矩形
                Graphics g = e.Graphics;
                g.DrawRectangle(pen, pointStart.X, pointStart.Y, pointContinue.X - pointStart.X, pointContinue.Y - pointStart.Y);
            }

            //实时的画之前已经画好的矩形
            foreach (BasePane item in RcgTmp.ExistsPanes)
            {
                switch (item.PaneType)
                {
                    case PaneType.Title:
                        pen.Color = Color.Blue;
                        break;
                    case PaneType.Content:
                        pen.Color = Color.LimeGreen;
                        break;
                    default:
                        pen.Color = Color.Blue;
                        break;
                }
                Point p1 = item.StartPoint;
                Point p2 = item.EndPoint;
                e.Graphics.DrawRectangle(pen, p1.X, p1.Y, p2.X - p1.X, p2.Y - p1.Y);
            }

            //实时的画修改的4个角落小框体
            pen.Width = 1;
            pen.Color = Color.Red;
            foreach (BasePane item in RcgTmp.TinyPanes)
            {
                Point p1 = item.StartPoint;
                Point p2 = item.EndPoint;
                e.Graphics.DrawRectangle(pen, p1.X, p1.Y, p2.X - p1.X, p2.Y - p1.Y);
            }

            pen.Dispose();
        }

        private void picbMain_MouseDown(object sender, MouseEventArgs e)
        {
            if (image == null)
            {
                return;
            }

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
                    showChangingPaneInfo(null);
                    bChange = false;
                    RcgTmp.TinyPanes.Clear();
                    Refresh();
                }
            }
            else
            {
                foreach (BasePane pane in RcgTmp.ExistsPanes)
                {
                    Point p1 = pane.StartPoint;
                    Point p2 = pane.EndPoint;

                    if (pane.IsInside(e.Location))
                    {
                        bDrawStart = false; //不能画新矩形了
                        bChange = true;
                        RcgTmp.TinyPanes.Clear();

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
                        RcgTmp.TinyPanes.Add(changPane1);
                        RcgTmp.TinyPanes.Add(changPane2);
                        RcgTmp.TinyPanes.Add(changPane3);
                        RcgTmp.TinyPanes.Add(changPane4);

                        showChangingPaneInfo(pane);
                        picbMain.Select();
                        break;
                    }
                }
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
            if (image == null)
            {
                return;
            }

            txtMousePoint.Text = e.X + "." + e.Y;

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
            if (image == null)
            {
                return;
            }

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
                    BasePane newPane = GenerateBasePane(curPaneType);
                    newPane.Name = GeneratePaneName();
                    newPane.Code = GeneratePaneCode();
                    newPane.StartPoint = pointStart;
                    newPane.EndPoint = pointContinue;
                    newPane.PaneType = curPaneType;
                    RcgTmp.ExistsPanes.Add(newPane);
                }
                pointStart = Point.Empty;
                pointContinue = Point.Empty;

            }

            bDrawStart = false;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text == null || txtName.Text.Trim().Length == 0)
            {

            }
        }

        private void rdbtnContent_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnContent.Checked)
            {
                curPaneType = PaneType.Content;
            }
            else if (rdbtnTitle.Checked)
            {
                curPaneType = PaneType.Title;
            }
        }

        private BasePane GenerateBasePane(PaneType paneType)
        {
            BasePane pane;
            switch (paneType)
            {
                case PaneType.Title:
                    pane = new TitlePane();
                    break;
                case PaneType.Content:
                    pane = new ContentPane();
                    break;
                default:
                    pane = new TitlePane();
                    break;
            }
            return pane;
        }

        private string GeneratePaneName()
        {
            string paneName = string.Empty;
            switch (curPaneType)
            {
                case PaneType.Title:
                    paneName += "Title";
                    break;
                case PaneType.Content:
                    paneName += "Content";
                    break;
                default:
                    paneName += "None";
                    break;
            }
            paneName += ((RcgTmp.ExistsPanes.Count + RcgTmp.TinyPanes.Count) + 1).ToString();
            return paneName;
        }

        private string GeneratePaneCode()
        {
            string paneCode = string.Empty;
            switch (curPaneType)
            {
                case PaneType.Title:
                    paneCode += "TM";
                    break;
                case PaneType.Content:
                    paneCode += "CM";
                    break;
                default:
                    paneCode += "NM";
                    break;
            }
            paneCode += ((RcgTmp.ExistsPanes.Count + RcgTmp.TinyPanes.Count) + 1).ToString();
            return paneCode;
        }

        private void showChangingPaneInfo(BasePane pane)
        {
            if (pane == null)
            {
                curChangingPane = null;
                txtName.Text = string.Empty;
                txtCode.Text = string.Empty;
                txtPaneType.Text = string.Empty;
                txtSP.Text = string.Empty;
                txtEP.Text = string.Empty;
            }
            else
            {
                curChangingPane = pane;
                txtName.Text = pane.Name;
                txtCode.Text = pane.Code;
                switch (pane.PaneType)
                {
                    case PaneType.Title:
                        txtPaneType.Text = "名称";
                        break;
                    case PaneType.Content:
                        txtPaneType.Text = "内容";
                        break;
                    default:
                        txtPaneType.Text = "其他";
                        break;
                }
                txtSP.Text = "X:" + pane.StartPoint.X + " Y:" + pane.StartPoint.Y;
                txtEP.Text = "X:" + pane.EndPoint.X + " Y:" + pane.EndPoint.Y;
            }
        }

        private void registerEventForPicBox()
        {
            picbMain.KeyDown += new KeyEventHandler(picbMain_KeyDown);
        }

        void picbMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && curChangingPane != null)
            {
                int deletedPane = rcgTmp.DeletePane(curChangingPane);
                bChange = false;
                bDrawStart = false;
                Refresh();
            }
        }

        private void RecognitionTemplateUC_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
