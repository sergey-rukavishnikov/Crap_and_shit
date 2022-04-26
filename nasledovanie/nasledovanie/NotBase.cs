using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nasledovanie
{
    internal class NotBase:Base1
    {
        public NotBase() : base()
        {

        }
        public void ChangeName()
        {
            Name = "А это не база";
        }
    }
}
