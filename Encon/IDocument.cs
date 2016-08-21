using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encon
{
    public interface IDocument
    {
        string Extension { get; }
        void Write(string value);
        void Save();
    }
}
