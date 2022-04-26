using System;

namespace Coordinates // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Field g= new Field(2,5,8);
            g.Print_coords();
        }
    }
}
