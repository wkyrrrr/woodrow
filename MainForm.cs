using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Tesseract.WinFormDemo
{
    public partial class frmMain : Form
    {
        private TesseractEngine tesseractEngine = null; // new TesseractEngine(@"./tessdata", "chi_sim+eng", EngineMode.Default);
        private float originalScaleX = 0;
        private float originalScaleY = 0;

        private Bitmap curBitmap;
        private Bitmap originalBitmap;
        private bool showCurBitmap = false;
        private Color btnShowCurBitmapBackColor;
        private Color btnShowCurBitmapForeColor;

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnImageSelect_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == openFileDialog1.ShowDialog())
            {
                txtImagePath.Text = openFileDialog1.FileName;
                picbOriginal.Image = Image.FromFile(openFileDialog1.FileName);
                setOriginalScale(picbOriginal.Image.Size.Width, picbOriginal.Image.Size.Height);
                originalBitmap = (Bitmap)picbOriginal.Image;
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
            txtOriginalScaleX.Text = scaleX.ToString();
            txtOriginalScaleY.Text = scaleY.ToString();
        }

        private void getCurrentScale(ref float scaleX, ref float scaleY)
        {
            if (string.IsNullOrWhiteSpace(txtScaleX.Text.Trim()) || string.IsNullOrEmpty(txtScaleX.Text.Trim()))
            {
                scaleX = originalScaleX;
            }
            else
            {
                if (!float.TryParse(txtScaleX.Text.Trim(), out scaleX))
                {
                    scaleX = originalScaleX;
                }
            }
            if (string.IsNullOrWhiteSpace(txtScaleY.Text.Trim()) || string.IsNullOrEmpty(txtScaleY.Text.Trim()))
            {
                scaleY = originalScaleY;
            }
            else
            {
                if (!float.TryParse(txtScaleY.Text.Trim(), out scaleY))
                {
                    scaleY = originalScaleY;
                }
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {

            Test01();

        }

        private void Test()
        {
            txtResult.Clear();
            try
            {
                string testImagePath = getFileFullName();
                //using (var img = Pix.LoadTiffFromMemory(ConvertBitmapToByte((Bitmap)picbOriginal.Image)))
                using (var img = Pix.LoadFromFile(testImagePath))
                {
                    using (var page = tesseractEngine.Process(img))
                    {
                        var text = page.GetText();
                        txtResult.AppendText(string.Format("Mean confidence: {0} \r\n", page.GetMeanConfidence()));
                        //txtResult.AppendText(string.Format("Text (GetText): \r\n{0} \r\n", text));
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

        private void Test01()
        {
            txtResult.Clear();
            try
            {
                string testImagePath = getFileFullName();
                //using (var img = Pix.LoadTiffFromMemory(ConvertBitmapToByte((Bitmap)picbOriginal.Image)))
                var img = Pix.LoadFromFile(testImagePath);

                float curScaleX = 0;
                float curScaleY = 0;
                getCurrentScale(ref curScaleX, ref curScaleY);
                txtScaleX.Text = curScaleX.ToString();
                txtScaleY.Text = curScaleY.ToString();

                img = img.Scale(curScaleX, curScaleY);
                
                    using (var page = tesseractEngine.Process(img))
                    {
                        var text = page.GetText();
                        txtResult.AppendText(string.Format("Mean confidence: {0} \r\n", page.GetMeanConfidence()));
                        //txtResult.AppendText(string.Format("Text (GetText): \r\n{0} \r\n", text));
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

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //tesseractEngine.Dispose();
        }

        private void btnScale_Click(object sender, EventArgs e)
        {
            float curScaleX = 0;
            float curScaleY = 0;
            getCurrentScale(ref curScaleX, ref curScaleY);
            txtScaleX.Text = curScaleX.ToString();
            txtScaleY.Text = curScaleY.ToString();

            curBitmap = bmpScale(picbOriginal.Image, (int)curScaleX, (int)curScaleY);
            btnShowCurBmp_Click(null, null);
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

        private void btnShowCurBmp_Click(object sender, EventArgs e)
        {
            if (showCurBitmap)
            {
                if (originalBitmap != null)
                {
                    picbOriginal.Image = originalBitmap;
                }
                btnShowCurBmp.BackColor = btnShowCurBitmapBackColor;
                btnShowCurBmp.ForeColor = btnShowCurBitmapForeColor;
            }
            else
            {
                if (curBitmap != null)
                {
                    picbOriginal.Image = curBitmap;
                }
                btnShowCurBmp.BackColor = Color.Black;
                btnShowCurBmp.ForeColor = Color.White;
            }

            showCurBitmap = !showCurBitmap;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            btnShowCurBitmapBackColor = btnShowCurBmp.BackColor;
            btnShowCurBitmapForeColor = btnShowCurBmp.ForeColor;
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
                setMousePoint(pointEndX, pointEndY);
                DrawRecg();
                picbOriginal.Image = originalBitmap;
                picbOriginal.Refresh();
            }
        }

        private void picbOriginal_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void setMousePoint(int x, int y)
        {
            txtScaleX.Text = x.ToString();
            txtScaleY.Text = y.ToString();
        }

        int pointStartX, pointStartY, pointEndX, pointEndY;

        private void picbOriginal_Paint(object sender, PaintEventArgs e)
        {

        }

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
            int contentWidth = picbOriginal.Width;
            int contentHeight = picbOriginal.Height;

            int imgWidth = originalBitmap.Width;
            int imgHeight = originalBitmap.Height;

            realWidth = (imgWidth * curConWidth) / contentWidth;
            realHeight = (imgHeight * curConHeight) / contentHeight;
        }
        
    }
}