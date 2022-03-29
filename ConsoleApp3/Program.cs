// See https://aka.ms/new-console-template for more information
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        enum game
        {
            камень,
            бумага,
            ножницы
        }
        static void Main(string[] args)
        {
            Console.WriteLine($"Выберите предмет {(int) game.камень} = {game.камень}, {(int)game.бумага} = {game.бумага}, {(int)game.ножницы} = {game.ножницы}");
            int.TryParse(Console.ReadLine(), out int player1);
            Console.Clear();
            Console.WriteLine($"Выберите предмет {(int)game.камень} = {game.камень}, {(int)game.бумага} = {game.бумага}, {(int)game.ножницы} = {game.ножницы}");
            int.TryParse(Console.ReadLine(), out int player2);
            if (player1 > player2)
            {
                if((player1 - player2) > 1)
                    Console.WriteLine("Выйграл второй игрок");
                else
                Console.WriteLine("Выйграл первый игрок");
            }
            else
            {
                if (player2 == player1)
                {
                    Console.WriteLine("Ничья!");
                }
                else
                Console.WriteLine("Выйграл второй игрок");
            }
            
        }
    }
}