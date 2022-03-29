// See https://aka.ms/new-console-template for more information
Console.WriteLine("number:");
int.TryParse(Console.ReadLine(), out int num);
if ((num / 100) % 10 != 0)
{
    if((num / 1000) % 10 != 0 )
    {
        Console.WriteLine("нет");
    }
    else
    Console.WriteLine("трёхзначное");
}
else
{
    Console.WriteLine("нет");
}
