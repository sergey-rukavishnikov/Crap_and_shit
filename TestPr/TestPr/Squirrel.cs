using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPr
{
    internal class Squirrel
    {

        public Squirrel (string _tree, string _color)
        {
            Tree = _tree;
            Color = _color;
        }
        public string Tree { get; set; }

        public string Color { get; set; }

        public void Gnawing ()
        {
            Console.WriteLine("Squirrel gnawing the nut");
        }


    }
}
