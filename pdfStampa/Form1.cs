using PdfiumViewer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pdfStampa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var path = @"C:\Users\simone.denardi\Desktop\pdfs\000001a_50_11415_040121.pdf";
            using (var document = PdfDocument.Load(path))
            {
                using (var printDocument = document.CreatePrintDocument())
                {
                    printDocument.PrinterSettings.PrintFileName = "000001a_50_11415_040121.pdf";
                    printDocument.PrinterSettings.FromPage = 1;
                    printDocument.PrinterSettings.ToPage = 1;
                    printDocument.PrinterSettings.PrinterName = @"UfficioIT";
                    printDocument.DocumentName = "000001a_50_11415_040121.pdf";
                    printDocument.PrinterSettings.PrintFileName = "000001a_50_11415_040121.pdf";
                    printDocument.PrintController = new StandardPrintController();
                    printDocument.Print();
                }
            }
        }
    }
}
