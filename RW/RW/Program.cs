// See https://aka.ms/new-console-template for more information
string path = @"C:\Users\user\source\repos\ConsoleApp3\NewRepo\my-file.txt";
using (StreamReader sr = new StreamReader(path))
{
    while (sr.Peek() >= 0)
    {
        Console.WriteLine(sr.ReadLine());
    }
}
