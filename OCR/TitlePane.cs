using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Tesseract.WinFormDemo.OCR
{
    public class TitlePane : BasePane
    {
        private bool hasRelativeContent;

        public bool HasRelativeContent
        {
            get
            {
                return hasRelativeContent;
            }

            set
            {
                hasRelativeContent = value;
            }
        }
               

        public override void SetPaneColor()
        {
            throw new NotImplementedException();
        }

        public BasePane GetRelativeContent()
        {
            throw new NotImplementedException();
        }

        public void SetRelativeContent()
        {
            throw new NotImplementedException();
        }
    }
}
