int max = Int32.MinValue, number, k = 0;
for (int i = 0;i < 10;)
{
    bool success = int.TryParse(Console.ReadLine(), out number);
    if (success)
    {
        i++;
        if (number > max)
        {
            max = number;
        }

    }
}

Console.WriteLine($"Максимальное значение - {max}");
