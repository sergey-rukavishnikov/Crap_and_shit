// See https://aka.ms/new-console-template for more information
using System;

namespace ClassAnimal // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human();

            human.Year = 1999;

            Console.Write(human.GetAge());
        }
    }
}