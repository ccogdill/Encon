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
        string filename;
        int x = 0;
        int y = 0;

        public string Extension
        {
            get { return ".xls"; }
        }

        public ExcelDocument(string Path, string Filename)
        {
            book = new Workbook();
            filename = System.IO.Path.Combine(Path, Filename + Extension);
            base.ValidateFolderPath(filename);
        }

      

        void IDocument.Write(string value)
        {
            if(value != Environment.NewLine)
            {
                Cell current = book.Worksheets[0].Cells[y,x];
                current.Value = "'" + value;  // this is crap!
                
                x++;
            }
            else
            { 
                x = 0; 
                y++; 
            }
        }

        void IDocument.Save()
        {
            book.SaveDocument(filename);
            x = 0;
            y = 0;
        }
    }
}
