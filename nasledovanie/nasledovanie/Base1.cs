using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nasledovanie
{
    internal class Base1
    {
        public string Name { get; set; }
        public Base1()
        {
            Name = "Это база";
        }
        public void print()
        {
            Console.WriteLine(Name);
        }
    }
}
