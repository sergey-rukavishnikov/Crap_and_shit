// See https://aka.ms/new-console-template for more information
using System;

namespace bool_method // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        /// <summary>
        /// Метод трансформации из int в bool
        /// </summary>
        /// <returns> Возвращает true, если пользователь вводит 1, и false,  если 0 </returns>
        static bool boolParse()
        {
            string input = Console.ReadLine();
            while(input != "0" && input != "1")
            {
                Console.WriteLine("Введите заново: ");
                input = Console.ReadLine();
            }
            return input == "1";
        }
        /// <summary>
        /// Требует ввести 0 или 1 и печатает "Да", если ввели 1, и "Нет", если 0
        /// </summary>
        /// <param name="args"></param>
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