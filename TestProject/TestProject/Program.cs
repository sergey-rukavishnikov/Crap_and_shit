Console.SetCursorPosition(0, 0);
int x = 5, y = 5;
char[,] map = new char[10, 10];
for (int i = 0; i < 10; i++)
    for (int j = 0; j < 10; j++)
        map[i, j] = '0';
map[x, y] = '@';
for (int i = 0; i < 10; i++)
{
    Console.Write('\n');
    for (int j = 0; j < 10; j++)
        Console.Write(map[i, j]);
}

while (x != 10 || y != 10)
{
    ConsoleKeyInfo move = Console.ReadKey(true);
    map[x, y] = '0';
    switch (move.Key)
    {
        case ConsoleKey.W:
            x--;
            break;
        case ConsoleKey.A:
            y--;
            break;
        case ConsoleKey.S:
            x++;
            break;
        case ConsoleKey.D:
            y++;
            break;
    }
    map[x, y] = '@';
    Console.SetCursorPosition(0, 0);
    for (int i = 0; i < 10; i++)
    {
        Console.Write('\n');
        for (int j = 0; j < 10; j++)
            Console.Write(map[i, j]);
    }
}
