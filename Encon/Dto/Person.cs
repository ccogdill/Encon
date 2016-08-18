﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encon.Dto
{
    public class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string SSN { get; set; }
        public int Age { get; set; }
        public virtual List<Address> Addresses { get; set; }
    }
}
