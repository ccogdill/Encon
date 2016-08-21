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

        public string Extension
        {
            get { return "csv"; }
        }

        public CsvDocument(string Path , string Filename)
        {
            csv = new StringBuilder();
            filename = System.IO.Path.Combine(Path, Filename + Extension);
            base.ValidateFolderPath(filename);
        }


        void IDocument.Write(string value)
        {
            if (value != Environment.NewLine)
                csv.Append(value + ",");
            else
                csv.AppendLine(); 
        }

        void IDocument.Save()
        {
            File.WriteAllText(filename, csv.ToString());
            csv.Clear();
        }
    }
}
