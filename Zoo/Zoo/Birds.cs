using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Birds
    {
        public int wings { get; set; }
        public Birds ()
        {
            wings = 2;
        }
    }

    public class Hummingbird : Birds,Pollen,Flying
    {

    }

    public class Emu : Birds, herbivory
    {

    }

    public class Сhiken : Birds, herbivory
    { 
    
    }

}
