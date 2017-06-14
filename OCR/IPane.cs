using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Tesseract.WinFormDemo.OCR
{
    public interface IPane
    {
        void SetPaneColor();
        bool IsInside(Point point);
    }
}
