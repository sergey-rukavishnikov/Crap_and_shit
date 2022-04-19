using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPr
{
    internal class Dog
    {
        public string Name { get; set; }
        public string Breed { get; set; }

        public Dog (string _name, string _breed)
        {
            Name = _name;
            Breed = _breed;
        }

        public void Barking ()
        {
            Console.WriteLine("Bark Bark !");
        }
    }
}
