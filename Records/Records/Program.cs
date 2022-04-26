using System;

namespace Registration // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool cicle = true;
            while (cicle)
            {
                List<Records> records = new List<Records>();
                Console.WriteLine("1. Print data\n" +
                                  "2. Add data\n" +
                                  "3. Remove data\n" +
                                  "Q. Exit\n");
                ConsoleKeyInfo choice = Console.ReadKey(true);
                switch (choice.Key)
                {
                    case ConsoleKey.D1:
                        {
                            foreach (Records aRecords in records)
                            {
                                Console.WriteLine(aRecords);
                            }
                            break;
                        }
                    case ConsoleKey.D2:
                        {
                            Console.WriteLine("Choose type of record:\n" +
                                              "1. Message\n" +
                                              "2. Person\n" +
                                              "3. Car \n");
                            ConsoleKeyInfo choice_type = Console.ReadKey(true);
                            switch (choice_type.Key)
                            {
                                case ConsoleKey.D1:
                                    {
                                        Console.WriteLine("Your message: ");
                                        records.Add(new Message(DateTime.Now, Console.ReadLine()));
                                        break;
                                    }
                                case ConsoleKey.D2:
                                    {
                                        Console.WriteLine("First Name: ");
                                        string F_Name = Console.ReadLine();
                                        Console.WriteLine("Last Name: ");
                                        string S_Name = Console.ReadLine();
                                        Console.WriteLine("Age: ");
                                        int Age = Console.Read();
                                        records.Add(new Person(DateTime.Now, F_Name, S_Name, Age));
                                        break;
                                    }
                                case ConsoleKey.D3:
                                    {
                                        Console.WriteLine("Car Name: ");
                                        string Car_Name = Console.ReadLine();
                                        Console.WriteLine("Car Year of Issue: ");
                                        int Car_Year = Console.Read();
                                        records.Add(new Car(DateTime.Now, Car_Name, Car_Year));
                                        break;
                                    }
                            }
                            break;
                        }
                    case ConsoleKey.D3:
                        {
                            Console.WriteLine("Choice data id: ");
                            records.RemoveAt(Console.Read());
                            break;
                        }
                    case ConsoleKey.Q:
                        {
                            cicle = false;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Wrong key. Try one more time.");
                            break;
                        }
                }
            }
        }
    }
}