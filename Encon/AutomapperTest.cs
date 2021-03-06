﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using AutoMapper;
using Encon.Dto;

namespace Encon
{
    public partial class AutomapperTest : Form
    {
        public AutomapperTest()
        {
            InitializeComponent();
        } 


        Person p;
        List<Address> Addys;
        Address CurrentAddress;


        State NoDak = new State { ID = 1, Name = "North Dakota", AB = "ND", Flower = "Wild Prairie Rose", Moto = "The Peace Garden State" };
        State Louan = new State { ID = 44, Name = "Louisiana", AB = "LA", Flower = "Styrofoam Cup", Moto = "Somthin French" };

     

        private void button2_Click(object sender, EventArgs e)
        {
            Mapper.CreateMap<Person, View.MailingAddress>();
            Mapper.CreateMap<Address, View.MailingAddress>();

            var model = Mapper.Map<Person, View.MailingAddress>(p);
            model = Mapper.Map<Address, View.MailingAddress>(CurrentAddress, model);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Mapper.CreateMap<Person, View.MailingAddress>();
          //  List<View.MailingAddress> people = Mapper.Map<List<Person>, List<View.MailingAddress>>(p);
            var model  = Mapper.Map<Person, View.MailingAddress>(p);
         
        }




        private void AutomapperTest_Load(object sender, EventArgs e)
        {
            Address a1 = new Address { ID = 2, Address1 = "4121 Carlyss Dr.", City = "Sulphur", State = Louan, Zip = "70665", CurrentAddress = true };
            Address a2 = new Address { ID = 17, Address1 = "Rt 1 Box 58", City = "Burlington", State = NoDak, Zip = "58722" };

            Addys = new System.Collections.Generic.List<Address>();
            Addys.Add(a1);
            Addys.Add(a2);


            p = new Person { ID = 11,Name = "Cory Cogdill", SSN = "523-25-7595", Age = 47, Addresses = Addys };
            CurrentAddress = new Address { Address1 = "4121 Carlyss Dr.", City = "Sulphur", State = Louan, Zip = "70665" };

        }



    }
}
