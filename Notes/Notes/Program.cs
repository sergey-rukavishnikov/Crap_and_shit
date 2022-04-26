using System;

namespace Notes // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Time> note = new List<Time>();
            Console.WriteLine("Выберите действие:\n" +
                "1 = Print data\n2 = Add item\n3 = Remove item\nQ = Exit");

            ConsoleKeyInfo input = Console.ReadKey();
            int i = 0;
            int temp;
            switch (input.Key)
            {
                case ConsoleKey.D1:
                    foreach (Time note1 in note)
                    {
                        note1.print();
                    }
                        break;
                case ConsoleKey.D2:
                    AddItem();
                    break;
                case ConsoleKey.D3:
                    note.RemoveAt(--i);
                
                    break;
                case ConsoleKey.Q:
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("Выберите одно из предложенных действий");
                        break;
            }
            void AddItem()
            {
                Console.WriteLine("Что вы хотите добавить:\n" +
                    "1 = Message\n2 = Person\n3 = Car");
                ConsoleKeyInfo input1 = Console.ReadKey();

                switch (input1.Key)
                {
                    case ConsoleKey.D1:
                        note.Add(new Message());
                        Console.WriteLine("Введите сообщение");
                        ((Message)note[i]).Words = Console.ReadLine();
                        i++;
                        break;
                    case ConsoleKey.D2:
                        note.Add(new Person());
                        Console.WriteLine("Введите имя");
                        ((Person)note[i]).Name = Console.ReadLine(); // вместо ((Person)note[i]).Age = temp; передать значение в параметры note.Add(new Person());
                        Console.WriteLine("Введите фамилию");
                        ((Person)note[i]).LastName = Console.ReadLine();
                        Console.WriteLine("Введите возраст");//dgf
                        int.TryParse(Console.ReadLine(), out temp);
                        ((Person)note[i]).Age = temp;
                        i++;
                        break;
                    case ConsoleKey.D3:
                        note.Add(new Car());
                        Console.WriteLine("Введите название");
                        ((Car)note[i]).Mark = Console.ReadLine();
                        Console.WriteLine("Введите год выпуска");
                        int.TryParse(Console.ReadLine(), out temp);
                        ((Car)note[i]).Year = temp;
                        i++;
                        break;
                    default:
                        Console.WriteLine("Выберите одну из предложенных записей");
                        break;

                }
            }
        }
    }
}