using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Tesseract.WinFormDemo.OCR
{
    public class RecognitionTemplate
    {
        private List<BasePane> existsPanes;
        private List<BasePane> tinyPanes;

        private int modContentWidth; //做模板时的框体宽度
        private int modContentHeight; //做模板时的框体高度
        private Image modImage;  //用于做模板的图片
        
        /// <summary>
        /// 当前全部创建的矩形的记录
        /// </summary>
        public List<BasePane> ExistsPanes
        {
            get
            {
                if (existsPanes == null)
                {
                    existsPanes = new List<BasePane>();
                }
                return existsPanes;
            }

            set
            {
                existsPanes = value;
            }
        }

        /// <summary>
        /// 矩形要修改大小时4个端点创建4个小方框的记录 
        /// </summary>
        public List<BasePane> TinyPanes
        {
            get
            {
                if (tinyPanes == null)
                {
                    tinyPanes = new List<BasePane>();
                }
                return tinyPanes;
            }

            set
            {
                tinyPanes = value;
            }
        }

        public Image ModImage
        {
            get
            {
                return modImage;
            }

            set
            {
                modImage = value;
            }
        }

        public int ModContentWidth
        {
            get
            {
                return modContentWidth;
            }

            set
            {
                modContentWidth = value;
            }
        }

        public int ModContentHeight
        {
            get
            {
                return modContentHeight;
            }

            set
            {
                modContentHeight = value;
            }
        }

        public bool IsInsideExistsPanes(Point point)
        {
            bool insideFlag = false;
            foreach (BasePane item in existsPanes)
            {
                if (item.IsInside(point))
                {
                    insideFlag = true;
                }
            }
            return insideFlag;
        }

        public int DeletePane(BasePane pane)
        {
            List<BasePane> deletedPanes = new List<BasePane>();
            List<BasePane> remainPanes = new List<BasePane>();
            foreach (BasePane item in existsPanes)
            {
                if (pane == item)
                {
                    deletedPanes.Add(item);
                }
                else
                {
                    remainPanes.Add(item);
                }
            }
            existsPanes = remainPanes;
            tinyPanes.Clear();

            return deletedPanes.Count;
        }

        public int GetRealWidth(int paneWidth)
        {
            return (ModImage.Width * paneWidth) / modContentWidth;
        }

        public int GetRealHeight(int paneHeight)
        {
            return (ModImage.Height * paneHeight) / modContentHeight;
        }

        public Point GetRealPoint(Point panePoint)
        {
            Point realPoint = new Point();
            realPoint.X = (ModImage.Width * panePoint.X) / modContentWidth;
            realPoint.Y = (ModImage.Height * panePoint.Y) / modContentHeight;

            return realPoint;
        }

        public BasePane GetPaneByFullFileName(string fileFullName)
        {
            if (string.IsNullOrWhiteSpace(fileFullName))
            {
                return null;
            }

            string fileName = fileFullName.Substring(fileFullName.LastIndexOf("\\") + 1, (fileFullName.LastIndexOf(".") - fileFullName.LastIndexOf("\\") - 1)); //文件名
            string fileExtension = fileFullName.Substring(fileFullName.LastIndexOf(".") + 1, (fileFullName.Length - fileFullName.LastIndexOf(".") - 1)); //扩展名
            string realFileName = fileName + "." + fileExtension;
            
            foreach (BasePane item in existsPanes)
            {
                if (realFileName.Equals(item.SplitFileName))
                {
                    return item;
                }
            }

            return null;
        }
        
    }
}
