using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Tesseract.WinFormDemo.OCR
{
    public abstract class BasePane : IPane
    {
        private PaneType paneType;
        private Point startPoint;
        private Point endPoint;
        private string name;
        private string code;
        private int width;
        private int height;
        private string splitFileName;

        public PaneType PaneType
        {
            get
            {
                return paneType;
            }

            set
            {
                paneType = value;
            }
        }

        public Point StartPoint
        {
            get
            {
                return startPoint;
            }

            set
            {
                startPoint = value;
            }
        }

        public Point EndPoint
        {
            get
            {
                return endPoint;
            }

            set
            {
                endPoint = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Code
        {
            get
            {
                return code;
            }

            set
            {
                code = value;
            }
        }

        public int Width
        {
            get
            {
                width = Math.Abs(startPoint.X - EndPoint.X);
                return width;
            }

            //set
            //{
            //    width = value;
            //}
        }

        public int Height
        {
            get
            {
                height = Math.Abs(startPoint.Y - EndPoint.Y);
                return height;
            }

            //set
            //{
            //    height = value;
            //}
        }

        public string SplitFileName
        {
            get
            {
                return splitFileName;
            }

            set
            {
                splitFileName = value;
            }
        }

        public bool IsInside(Point point)
        {
            if ((point.X > startPoint.X && point.X < endPoint.X && point.Y > startPoint.Y && point.Y < endPoint.Y) ||
                (point.X > endPoint.X && point.X < startPoint.X && point.Y > endPoint.Y && point.Y < startPoint.Y) ||
                (point.X > endPoint.X && point.X < startPoint.X && point.Y > startPoint.Y && point.Y < endPoint.Y) ||
                (point.X > startPoint.X && point.X < endPoint.X && point.Y > endPoint.Y && point.Y < startPoint.Y))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public abstract void SetPaneColor();


    }
}
