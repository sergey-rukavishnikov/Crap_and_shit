using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    // Насекомые
    public class Insects
    {

    }

    public class Hornet : Insects, Flying
    {

    }

    public class Locust : Insects, herbivory, Flying
    {

    }

    public class Butterfly : Insects, Pollen, Flying
    {

    }

    public class Bee : Insects, Pollen, Flying
    {

    }


}
