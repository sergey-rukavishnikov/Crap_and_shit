// See https://aka.ms/new-console-template for more information
List <int> temperature = new List<int>();
List <int> minus = new List<int>();
string temp = Console.ReadLine();
int temp_int;
int i = 0;
while (temp != "stop")
{
    i++;
    int.TryParse(temp, out temp_int);
    if(temp_int < 0)
    {
        temp_int = -temp_int;
        minus.Add(1);
    }
    else if(temp_int > 0)
        minus.Add(2);
    else
    minus.Add(0);
    temperature.Add(temp_int);
    temp = Console.ReadLine();
}
Console.Clear();
int j = 0;
foreach (int tempe in temperature)
{
    Console.Write(j);
    Console.Write(". ");
    if (minus[j] == 1)
        Console.Write("(-)");
    else if(minus[j] == 2)
        Console.Write("(+)");
    Console.Write(tempe);
    Console.Write("\n");
    j++;
}
