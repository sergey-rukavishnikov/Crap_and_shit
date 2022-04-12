// See https://aka.ms/new-console-template for more information
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static bool boolParse()
        {
            string input = Console.ReadLine();
            while(input != "0" && input != "1")
            {
                Console.WriteLine("Введите зановов: ");
                input = Console.ReadLine();
            }
            return input == "1";
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Ввод: ");
            bool var = boolParse();
            if (var)
            {
                Console.WriteLine("Да");
            }
            else
            {
                Console.WriteLine("Нет");
            }
        }
    }
}