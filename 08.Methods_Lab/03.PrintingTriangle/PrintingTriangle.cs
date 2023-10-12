static void PrintLine(int start, int end)
{
    for (int i = start; i <= end; i++)
    {
        Console.Write($"{i} ");
    }
    Console.WriteLine();
}

static void PrintTriangle(int num)
{
    for (int currentLine = 1; currentLine <= num; currentLine++)
    {
        PrintLine(1, currentLine);
    }

    for (int currentLine = num - 1; currentLine >= 1; currentLine--)
    {
        PrintLine(1, currentLine);
    }
}


int num = int.Parse(Console.ReadLine());

PrintTriangle(num);