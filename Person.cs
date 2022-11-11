using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddbUC7
{
    public class Person
    {
        public string Name { get; set;}
        public string City { get; set; }
        public string State { get; set; }
        //public string Name { get; set; }
        public Person(string name,string city,string state)
        {
            Name = name;
            City = city;
            State = state;
        }
    }

}
