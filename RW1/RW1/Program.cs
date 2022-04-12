// See https://aka.ms/new-console-template for more information
List<string> lines = new List<string>();
string s;
string path = @"C:\Users\user\source\repos\ConsoleApp3\NewRepo\my-file.txt";

Console.WriteLine("До: ");

using (StreamReader sr = new StreamReader(path))
{
    Console.WriteLine(sr.ReadToEnd());
}


Console.ReadKey();

Console.Clear();

Console.WriteLine("Ввод: ");

while ((s = Console.ReadLine()) != "stop")
{
    lines.Add(s);
}

Console.Clear();

using (StreamWriter sw = new StreamWriter(path, true)) {

    sw.WriteLine("\n");

    foreach (string line in lines)
    {
        sw.WriteLine(line);
    }
}

Console.Clear();

using (StreamReader sr = new StreamReader(path))
{
    Console.WriteLine(sr.ReadToEnd());
}
