using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeistConsole
{
    internal class Person
    {
        //this is how properties originally looked
        //field to hold the value, get/set methods for getting/setting

        private string _name;
        public string Name
        {
            get { return _name.ToUpper(); }
            set { _name = value; }
        }


        //current syntax for properties (auto properties)
        public int Age { get => _age; set { _age = value; } }
        private int _age;
    }
}