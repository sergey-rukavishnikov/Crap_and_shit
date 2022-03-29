// See https://aka.ms/new-console-template for more information
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        enum size
        {
            маленькая,
            средняя,
            большая
        }
        static void Main(string[] args)
        {
            Console.WriteLine($"Выберите порция {(int)size.маленькая} = {size.маленькая}, {(int)size.средняя} = {size.средняя}, {(int)size.большая} = {size.большая}");
        }
        int.TryParse(Console.ReadLine(), out int vote);
        switch(vote):
            case(0):
            Console.Wri
    }
}