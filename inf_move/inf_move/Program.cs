// See https://aka.ms/new-console-template for more information
Console.WriteLine("Собирать? 1 - да, 2 - нет");
int.TryParse(Console.ReadLine(), out int choise1);
int mash = 0;
int choise2;
if (choise1 == 1)
{
    Console.Write("****************\n" +
"*              *\n" +
"*              *\n" +
"*              *\n" +
"*              *\n" +
"*              *\n" +
"*              *\n" +
"*              *\n" +
"*              *\n" +
"****************");
    //x=4, y=2; x=2,y=3; x=-6,y=3; x=-4, y=-1; x=4, x=-3   x = 13 y = 7
    int x = 0, y = 0;
    int shiftX = 8, shiftY = 6;
    Console.SetCursorPosition(x + shiftX, y + shiftY);
    Console.Write("@");
    ConsoleKeyInfo move;
    bool pock = true;
    Random rand = new Random();
    int mash_x, mash_y, x1, y1;
    mash_x = rand.Next(1, 13);
    mash_y = rand.Next(3, 9);
    Console.SetCursorPosition(mash_x, mash_y);
    Console.Write("$");
    int fear = 15;
    int go;
    while (pock && mash < 5)
    {
        move = Console.ReadKey(true);
        Console.SetCursorPosition(x + shiftX, y + shiftY);
        Console.Write(" ");
        switch (move.Key)
        {
            case ConsoleKey.W:
                if (y >= -2)
                    y--;

                break;
            case ConsoleKey.A:
                if (x >= -6)
                    x--;
                break;
            case ConsoleKey.S:
                if (y <= 3)
                    y++;
                break;
            case ConsoleKey.D:
                if (x <= 5)
                    x++;
                break;
        }
        if (x == mash_x - 8 && y == mash_y - 6)
        {
            mash++;
            fear += 2;
            Console.SetCursorPosition(0, 15);
            Console.WriteLine("Продолжить? 1 - да, 2 - нет");
            Console.SetCursorPosition(0, 15);
            Console.WriteLine("----------------------------");
            int.TryParse(Console.ReadLine(), out choise2);
            if (choise2 == 2)
                pock = false;
            mash_x = rand.Next(1, 13);
            mash_y = rand.Next(3, 9);
            Console.SetCursorPosition(mash_x, mash_y);
            Console.Write("$");
        }
        Console.SetCursorPosition(x + shiftX, y + shiftY);
        Console.Write("@");
        Console.SetCursorPosition(15, 15);
        Console.SetCursorPosition(0, 15);

        go = rand.Next(fear);
        if (go == 0)
            pock = false;
    }
}

Console.SetCursorPosition(0, 13);
Console.Write($"mash = {mash}");


