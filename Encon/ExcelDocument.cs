using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Spreadsheet;


namespace Encon
{
    public class ExcelDocument : Document, IDocument
    {

        Workbook book;
        string filename = string.Empty;
        

        public ExcelDocument(string Filename)
        {
            book = new Workbook();
            filename = Filename;
        }

      

        void IDocument.Write(string value)
        {
            book.Worksheets[0].Cells["B2"].Value = "Hello World";
            book.Worksheets[0].Cells[2, 3].Value = "Skiddle, Hop";
        }

        void IDocument.Save()
        {
            book.SaveDocument(filename); 
        }
    }
}
