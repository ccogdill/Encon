using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Encon.Dto;
namespace Encon.View
{
    public class MailingAddress
    {
        public string Name { get; set; }
        public virtual List<Address> Addresses { get; set; }
    }
}
