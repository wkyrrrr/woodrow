using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;

namespace Tesseract.WinFormDemo.OCR
{
    public class ImageProcess
    {
        private const string directoryStore = "./OCRTmpStore";
        public string Process(Bitmap bitmap, RecognitionTemplate rcgTmp)
        {
            string storeDirectoryName = PrepareFileStore();
            Bitmap divisionBmp;
            int fileIndex = 1;
            foreach (BasePane item in rcgTmp.ExistsPanes)
            {
                divisionBmp = cutImage(bitmap, rcgTmp.GetRealPoint(item.StartPoint), rcgTmp.GetRealWidth(item.Width), rcgTmp.GetRealHeight(item.Height));
                bmpSave(divisionBmp, directoryStore + "/" + storeDirectoryName + "/" + fileIndex.ToString() + ".tif");
                item.SplitFileName = fileIndex.ToString() + ".tif";
                fileIndex++;
            }
            return directoryStore + "/" + storeDirectoryName;
        }

        private Bitmap bmpScale(Image originalImage, Point point, int width, int height)
        {
            GraphicsUnit units = GraphicsUnit.Pixel; //代表像素  
            Rectangle rect = new Rectangle(0, 0, width, height);
            Bitmap newbitmap = new Bitmap(width, height);
            Graphics g = Graphics.FromImage(newbitmap);
            g.DrawImage(originalImage, rect, rect, units);
            g.Dispose();

            return newbitmap;
        }

        //截取图片  主要操作区域
        private Bitmap cutImage(Image srcImage, Point pos, int cutWidth, int cutHeight)
        {

            //先初始化一个位图对象，来存储截取后的图像
            Bitmap bmpDest = new Bitmap(cutWidth, cutHeight, PixelFormat.Format32bppRgb);

            //这个矩形定义了，你将要在被截取的图像上要截取的图像区域的左顶点位置和截取的大小
            Rectangle rectSource = new Rectangle(pos.X, pos.Y, cutWidth, cutHeight);

            //这个矩形定义了，你将要把 截取的图像区域 绘制到初始化的位图的位置和大小
            //我的定义，说明，我将把截取的区域，从位图左顶点开始绘制，绘制截取的区域原来大小
            Rectangle rectDest = new Rectangle(0, 0, cutWidth, cutHeight);

            Graphics g = Graphics.FromImage(bmpDest);
            //第一个参数就是加载你要截取的图像对象，第二个和第三个参数及如上所说定义截取和绘制图像过程中的相关属性，第四个属性定义了属性值所使用的度量单位
            g.DrawImage(srcImage, rectDest, rectSource, GraphicsUnit.Pixel);
            g.Dispose();
            return bmpDest;
        }

        private void bmpSave(Bitmap bitmap, string fileName)
        {
            bitmap.Save(fileName, System.Drawing.Imaging.ImageFormat.Tiff);
        }

        private string PrepareFileStore()
        {
            if (!Directory.Exists(directoryStore))
            {
                Directory.CreateDirectory(directoryStore);
            }

            //string storeName = DateTime.Now.ToLongDateString();
            string storeName = DateTime.Now.ToString("yyyyMMddHHmmss");
            Directory.CreateDirectory(directoryStore + "/" + storeName);
            return storeName;
        }
    }
}
