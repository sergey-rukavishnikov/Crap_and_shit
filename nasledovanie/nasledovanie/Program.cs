// See https://aka.ms/new-console-template for more information

using System;

namespace nasledovanie // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NotBase exp = new NotBase();
            exp.print();
            exp.ChangeName();
            exp.print();
        }
    }
}