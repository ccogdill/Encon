using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encon
{
    public interface IDocument
    {
        
        void Write(string value);
        void Save();
    }
}
