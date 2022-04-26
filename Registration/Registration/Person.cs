using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration
{
    public class Person : Records
    {
        static string Type;

        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public Person(DateTime _date, string _name, string _surname, int _age)
        {
            this.ID = GetNextID();
            this.Record_Date = _date;
            this.Name = _name;
            this.Surname = _surname;
            this.Age = _age;
        }
        static Person() => Type = "Person";

        public override string ToString()
        {
            return ID + ". " + Record_Date + " " + Name + " " + Surname + ", " + Age;
        }
    }
}
