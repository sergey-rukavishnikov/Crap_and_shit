using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetInt
{
    internal class Bank
    {
        public string Name { get; set; }
        public int ATMs { get; set; }

        public Bank()
        {
            Name = "Sber";
            ATMs = 3;
        }


    }
}
