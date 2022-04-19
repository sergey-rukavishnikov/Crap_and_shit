using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPr
{
    internal class Elephant
    {
        public Elephant (string _name, string _homeland)
        {
            Name = _name;
            Homeland = _homeland;
        }


        public string Name { get; set; }
        public string Homeland { get; set; }

        public void GetHomeland ()
        {
            Console.WriteLine(Homeland);
        }
    }


}
