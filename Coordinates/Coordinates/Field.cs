using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coordinates
{
    public struct Field
    {
        public double X { get;}
        public double Y { get;}
        public double Z { get;}

        public Field(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public void Print_coords()
        {
            Console.WriteLine(X + " " + Y + " " + Z);
        }

    }
}
