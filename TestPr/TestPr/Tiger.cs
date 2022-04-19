using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPr
{
    internal class Tiger
    {
        public Tiger (string _name, int _age)
        {
            Name = _name;
            Age = _age;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public void Growl()
        {
            Console.WriteLine("Grrraaaaahhh");
        }

    }

}
