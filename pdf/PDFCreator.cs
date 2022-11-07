using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System.Diagnostics;
using System.IO.Enumeration;

namespace GradeBook.pdf
{
    internal class PDFCreator
    {

        private PdfDocument document;
        public PDFCreator(string fileName)
        {
            document = new PdfDocument(fileName);
        }

        public void CreateDeafaultDocument()
        {
            PdfPage page = document.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);
            XFont font = new XFont("Verdana", 20, XFontStyle.Bold);


            gfx.DrawString("Hello PDF!", font, XBrushes.Green, 
                new XRect(0, 0, page.Width, page.Height), XStringFormats.Center);
            document.Close();//Closing & saving PDF file
        }


    }
}
