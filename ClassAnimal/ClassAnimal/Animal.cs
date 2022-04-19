using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAnimal
{
    internal class Animal
    {
        public string Name { get; set; }
        public string Kind { get; set; }
        public double Weigth { get; set; }
        public double Grouth { get; set; }
        public string Sound { get; set; }
        public Animal()
        {
            Name = "Животное";
            Kind = "Вид";
            Weigth = 10;
            Grouth = 120;
            Sound = "ROR";
        }
        public Animal(string name, string kind, double weight, double growth, string sound)
        {
            Name = name;
            Kind = kind;
            Weigth = weight;
            Grouth = growth;
            Sound = sound;
        }
        public void do_sound()
        {
            Console.WriteLine(Sound);
        }
    }
}
