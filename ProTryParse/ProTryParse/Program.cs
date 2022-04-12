// See https://aka.ms/new-console-template for more information
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static int ProTryParse(string s)
        {
            int i;
             while(!int.TryParse(s, out i))
            {
                Console.Clear();
                Console.WriteLine("Введите заново: ");
                s = Console.ReadLine();
            }
            Console.Clear();
            return i;
        }
        static void Main(string[] args)
        {
            string s;
            Console.WriteLine("Ввод: ");
            s = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"Ваше числа: {ProTryParse(s)}");
        }
    }
}