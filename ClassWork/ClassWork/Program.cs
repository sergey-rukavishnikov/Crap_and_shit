// See https://aka.ms/new-console-template for more information
Console.WriteLine("Вводите: ");
double.TryParse(Console.ReadLine(), out double num);
double max = num;
for(int i = 0; i < 9; i++)
{
    double.TryParse(Console.ReadLine(), out num);
    if(num > max)
    {
        max = num;
    }
}
Console.WriteLine($"Максимальное - {max}");
