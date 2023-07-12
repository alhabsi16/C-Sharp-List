using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_List
{
    internal class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gander { get; set; }


        public Person(int Id, string Name, string Gander) 
        {
            this.Id = Id;
            this.Name = Name;
            this.Gander = Gander;
        }
    }
}
