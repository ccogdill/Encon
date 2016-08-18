using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encon
{
    public class Document
    {
        public virtual void ValidateFolderPath(string path)
        {

            string absolutePath = System.IO.Path.GetDirectoryName(path);

            if (!System.IO.Directory.Exists(absolutePath))
            {
                System.IO.Directory.CreateDirectory(absolutePath);
            }
        }

    }
}
