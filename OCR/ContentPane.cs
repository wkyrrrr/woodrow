using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Tesseract.WinFormDemo.OCR
{
    public class ContentPane : BasePane
    {
        private int titleConten;

        public int TitleConten
        {
            get
            {
                return titleConten;
            }

            set
            {
                titleConten = value;
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

        public void AddTitlePane(TitlePane titlePane)
        {
            throw new NotImplementedException();
        }

        public void RemoveTitlePane(TitlePane titlePane)
        {
            throw new NotImplementedException();
        }

        public void ClearTitlePane()
        {
            throw new NotImplementedException();
        }
    }
}
