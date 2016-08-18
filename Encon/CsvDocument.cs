using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Encon
{
    public class CsvDocument : Document, IDocument
    {

        StringBuilder csv;
        string filename;

        public CsvDocument(string Filename)
        {
            csv = new StringBuilder();
            base.ValidateFolderPath(Filename);
            filename = Filename;
        }


        void IDocument.Write(string value)
        {
            csv.Append(value);
        }

        void IDocument.Save()
        {
            File.WriteAllText(filename, csv.ToString());
            csv.Clear();
        }
    }
}
