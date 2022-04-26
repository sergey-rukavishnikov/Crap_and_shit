using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes
{
    internal class Person:Time
    {
        public Person() : base()
        {
            Name = "Name";
            LastName = "Lastname";
            Age = 0;

        }
        public Person(string name, string lastname, int age)
        {
            Name = name;
            LastName = lastname;
            Age = age;
        }
        public override void print()
        {
            base.print();
            Console.Write($"[Person] {Name} {LastName}, {Age}"); // добавить gettype вместо [person]
        }
        private string _name;
        private string _lastname;
        private int _age;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (String.Compare(value, "0") >= 0)
                {
                    _name = value;
                }
                else
                {
                    _name = "Word";
                }
            }
        }
        public string LastName
        {
            get
            {
                return _lastname;
            }
            set
            {
                if (String.Compare(value, "0") >= 0)
                {
                    _lastname = value;
                }
                else
                {
                    _lastname = "Word";
                }
            }
        }
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if(value > 0)
                {
                    _age = value;
                }
                else
                {
                    _age = 0;
                }
            }
        }
    }
}
