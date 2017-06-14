using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Tesseract.WinFormDemo.OCR;

namespace Tesseract.WinFormDemo
{
    public partial class RecgonitionMain : Form
    {
        private TesseractEngine tesseractEngine = new TesseractEngine(@"./tessdata", "chi_sim+eng", EngineMode.Default);
        private float originalScaleX = 0;
        private float originalScaleY = 0;

        private Bitmap curBitmap;
        private Bitmap originalBitmap;

        public RecgonitionMain()
        {
            InitializeComponent();
        }


        #region 按钮事件
        private void btnImageSelect_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == openFileDialog1.ShowDialog())
            {
                txtImagePath.Text = openFileDialog1.FileName;
                rcgTmpUC.SetImage(openFileDialog1.FileName);
                
                setOriginalScale(rcgTmpUC.Image.Size.Width, rcgTmpUC.Image.Size.Height);
                originalBitmap = (Bitmap)rcgTmpUC.Image;
            }
        }
        private void btnStart_Click(object sender, EventArgs e)
        {

            try
            {
                string testImagePath = getFileFullName();
                using (var engine = new TesseractEngine(@"./tessdata", "chi_sim+eng", EngineMode.Default))
                {
                    using (var img = Pix.LoadFromFile(testImagePath))
                    {
                        using (var page = engine.Process(img))
                        {
                            var text = page.GetText();
                            txtResult.AppendText(string.Format("Mean confidence: {0} \r\n", page.GetMeanConfidence()));
                            txtResult.AppendText(string.Format("Text (GetText): \r\n{0} \r\n", text));
                            txtResult.AppendText("Text (iterator): \r\n");

                            using (var iter = page.GetIterator())
                            {
                                iter.Begin();

                                do
                                {
                                    do
                                    {
                                        do
                                        {
                                            do
                                            {
                                                if (iter.IsAtBeginningOf(PageIteratorLevel.Block))
                                                {
                                                    //txtResult.AppendText("<BLOCK>");
                                                }

                                                txtResult.AppendText(iter.GetText(PageIteratorLevel.Word));
                                                txtResult.AppendText(" ");

                                                if (iter.IsAtFinalOf(PageIteratorLevel.TextLine, PageIteratorLevel.Word))
                                                {
                                                    txtResult.AppendText("\r\n");
                                                }
                                            } while (iter.Next(PageIteratorLevel.TextLine, PageIteratorLevel.Word));

                                            if (iter.IsAtFinalOf(PageIteratorLevel.Para, PageIteratorLevel.TextLine))
                                            {
                                                txtResult.AppendText("\r\n");
                                            }
                                        } while (iter.Next(PageIteratorLevel.Para, PageIteratorLevel.TextLine));
                                    } while (iter.Next(PageIteratorLevel.Block, PageIteratorLevel.Para));
                                } while (iter.Next(PageIteratorLevel.Block));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                if ((ex as FileNotFoundException) != null)
                {
                    MessageBox.Show("选择的文件不存在！");
                }
                else
                {
                    MessageBox.Show("Unexpected Error: " + ex.Message + " Details: " + ex.ToString());
                }
            }
        }
        private void btnTest_Click(object sender, EventArgs e)
        {

            Test01();

        }
        
        #endregion

        #region 页面事件

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //tesseractEngine.Dispose();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void picbOriginal_MouseDown(object sender, MouseEventArgs e)
        {
            calcRateImage(e.Location.X, e.Location.Y, out pointStartX, out pointStartY);
        }

        private void picbOriginal_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                calcRateImage(e.Location.X, e.Location.Y, out pointEndX, out pointEndY);
                
                DrawRecg();
            }
        }

        private void picbOriginal_MouseUp(object sender, MouseEventArgs e)
        {
            
        }


        private void picbOriginal_Paint(object sender, PaintEventArgs e)
        {

        }
        #endregion

        #region 其他事件

        #endregion



        private string getFileFullName()
        {
            string imagePath = txtImagePath.Text.Trim();
            if (File.Exists(imagePath))
            {
                return imagePath;
            }
            else
            {
                throw new FileNotFoundException();
            }
        }

        private void setOriginalScale(float scaleX, float scaleY)
        {
            originalScaleX = scaleX;
            originalScaleY = scaleY;
        }

        


        private string GetText(string fileFullName)
        {
            string resultText = string.Empty;
            try
            {
                using (var img = Pix.LoadFromFile(fileFullName))
                {
                    using (var page = tesseractEngine.Process(img))
                    {
                        resultText = page.GetText();
                        //txtResult.AppendText(string.Format("Mean confidence: {0} \r\n", page.GetMeanConfidence()));
                        //txtResult.AppendText("Text (iterator): \r\n");

                        //using (var iter = page.GetIterator())
                        //{
                        //    iter.Begin();

                        //    do
                        //    {
                        //        do
                        //        {
                        //            do
                        //            {
                        //                do
                        //                {
                        //                    if (iter.IsAtBeginningOf(PageIteratorLevel.Block))
                        //                    {
                        //                        //txtResult.AppendText("<BLOCK>");
                        //                    }

                        //                    txtResult.AppendText(iter.GetText(PageIteratorLevel.Word));
                        //                    txtResult.AppendText(" ");

                        //                    if (iter.IsAtFinalOf(PageIteratorLevel.TextLine, PageIteratorLevel.Word))
                        //                    {
                        //                        txtResult.AppendText("\r\n");
                        //                    }
                        //                } while (iter.Next(PageIteratorLevel.TextLine, PageIteratorLevel.Word));

                        //                if (iter.IsAtFinalOf(PageIteratorLevel.Para, PageIteratorLevel.TextLine))
                        //                {
                        //                    txtResult.AppendText("\r\n");
                        //                }
                        //            } while (iter.Next(PageIteratorLevel.Para, PageIteratorLevel.TextLine));
                        //        } while (iter.Next(PageIteratorLevel.Block, PageIteratorLevel.Para));
                        //    } while (iter.Next(PageIteratorLevel.Block));
                        //}
                    }
                }
            }
            catch (Exception ex)
            {
                if ((ex as FileNotFoundException) != null)
                {
                    MessageBox.Show("选择的文件不存在！");
                }
                else
                {
                    MessageBox.Show("Unexpected Error: " + ex.Message + " Details: " + ex.ToString());
                }
            }
            return resultText;
        }

        private void Test01()
        {
            if (rcgTmpUC.Image == null)
            {
                MessageBox.Show("请先选择图片！");
                return;
            }
            if (rcgTmpUC.RcgTmp.ExistsPanes.Count == 0)
            {
                MessageBox.Show("请先制作模板！");
                return;
            }

            txtResult.Clear();
            try
            {
                ImageProcess imgProcess = new ImageProcess();
                string filePath = imgProcess.Process((Bitmap)rcgTmpUC.Image, rcgTmpUC.RcgTmp);
                string[] files = Directory.GetFiles(filePath, "*.tif");
                List<string> results = new List<string>();
                foreach (string fileFullName in files)
                {
                    BasePane pane = rcgTmpUC.RcgTmp.GetPaneByFullFileName(fileFullName);
                    if (pane != null)
                    {
                        results.Add(pane.Name + " :" + GetText(fileFullName));
                    }
                    else
                    {
                        results.Add(fileFullName + " :" + GetText(fileFullName));
                    }
                }
                foreach (string item in results)
                {
                    txtResult.AppendText(item);
                    txtResult.AppendText("\r\n");
                }
            }
            catch (Exception ex)
            {
                if ((ex as FileNotFoundException) != null)
                {
                    MessageBox.Show("选择的文件不存在！");
                }
                else
                {
                    MessageBox.Show("Unexpected Error: " + ex.Message + " Details: " + ex.ToString());
                }
            }
        }

        
        private byte[] ConvertBitmapToByte(Bitmap bmp)
        {
            MemoryStream ms = new MemoryStream();
            bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
            byte[] bytes = ms.GetBuffer();  //byte[]   bytes=   ms.ToArray(); 这两句都可以，至于区别么，下面有解释
            ms.Close();
            return bytes;
        }
        

        private Bitmap bmpScale(Image originalImage, int width, int height)
        {
            GraphicsUnit units = GraphicsUnit.Pixel; //代表像素  

            Rectangle rect = new Rectangle(0, 0, width, height);
            Rectangle rect1 = new Rectangle(0, 0, (int)originalScaleX, (int)originalScaleY);
            //Rectangle rect1 = new Rectangle(0, 0, (int)originalScaleX, (int)originalScaleY);

            Bitmap newbitmap = new Bitmap(width, height);
            Graphics g = Graphics.FromImage(newbitmap);
            g.DrawImage(originalImage, rect, rect, units);
            g.Dispose();

            return newbitmap;
        }

        


       

        

        int pointStartX, pointStartY, pointEndX, pointEndY;


        private void DrawRecg()
        {
            //C#中利用GDI+ ，在MouseMove事件中绘制矩形    
            int iWidth = pointEndX - pointStartX;
            int iHeight = pointEndY - pointStartY;

            // 每次鼠标移动都拷贝原图bitmapSource，去除之前的留下的矩形
            Pen pen = new Pen(Color.Red);
            Graphics gh = Graphics.FromImage(originalBitmap);
            Rectangle rectNew = new Rectangle(pointStartX, pointStartY, iWidth, iHeight);
            // 画矩形
            gh.DrawRectangle(pen, rectNew);
        }

        private void calcRateImage(int curConWidth, int curConHeight, out int realWidth, out int realHeight)
        {
            int contentWidth = rcgTmpUC.Size.Width;
            int contentHeight = rcgTmpUC.Size.Height;

            int imgWidth = originalBitmap.Width;
            int imgHeight = originalBitmap.Height;

            realWidth = (imgWidth * curConWidth) / contentWidth;
            realHeight = (imgHeight * curConHeight) / contentHeight;
        }
        
    }
}