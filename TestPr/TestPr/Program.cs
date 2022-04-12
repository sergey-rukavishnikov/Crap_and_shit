Random randomGenerator = new Random();

int x = 10, y = 10;
char[,] map = new char[20, 20];
for (int i = 0; i < 20; i++)
    for (int j = 0; j < 20; j++)
        map[i, j] = '0';
for (int i = 0; i < 5; i++)
    map[randomGenerator.Next(20), randomGenerator.Next(20)] = 'T';

for (int i = 0; i < 20; i++)
{
    Console.Write('\n');
    for (int j = 0; j < 20; j++)
        Console.Write(map[i, j]);
}

double Fright;
Fright = 0.15;
Console.SetCursorPosition(0, 21);
while (true)
{
    ConsoleKeyInfo move = Console.ReadKey(true);
    int prevX, prevY, number;
    string choice;
    prevX = x;
    prevY = y;
    map[prevX, prevY] = '0';

    switch (move.Key)
    {
        case ConsoleKey.W:
            y--;
            break;
        case ConsoleKey.A:
            x--;
            break;
        case ConsoleKey.S:
            y++;
            break;
        case ConsoleKey.D:
            x++;
            break;
    }

    if (map[y - 1, x] == 'T')
    {
        map[y - 1, x] = '@';
        Console.SetCursorPosition(x, y);
        Console.Write(map[y - 1, x]);
        Console.SetCursorPosition(prevX, prevY);
        Console.Write(map[prevX, prevY]);

        Console.SetCursorPosition(0, 21);
        Console.Write(" ");
        Console.SetCursorPosition(0, 21);
        Console.WriteLine("Continue - 1\n" +
        "Exit - 2\n");
        choice = Console.ReadLine();


        if (Int32.TryParse(choice, out number))
        {
            if (number == 1)
            {
                double Check_Fear = randomGenerator.NextDouble();
                if (Check_Fear < Fright)
                {
                    Console.WriteLine("You got scared and ran away");
                    break;
                }
                Fright = Fright + 0.02;
            }
            if (number == 2)
                break;
        }
    }

    map[x, y] = '@';
    Console.SetCursorPosition(prevX, prevY);
    Console.Write(map[prevX, prevY]);
    Console.SetCursorPosition(x, y);
    Console.Write(map[x, y]);
}