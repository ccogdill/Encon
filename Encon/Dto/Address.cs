using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encon.Dto
{
    public class Address
    {
        // This is wrong, it needs an id of sorts.
        //   I wonder if we have it all wrong, addresses really don't change, but the people and businesses that reside at those addresses do change.  
        //   A person or business can also have multiple addresses.
        //   Just as an address can have multiple phones.  

        
        public int ID { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public Boolean CurrentAddress { get; set; }
    }
}
