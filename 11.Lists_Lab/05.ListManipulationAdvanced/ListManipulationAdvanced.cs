List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

string command = Console.ReadLine();

while (command != "end")
{
    if (command.StartsWith("Contains"))
    {
        int numberContains = int.Parse(command.Split(" ")[1]);
        if (numbers.Contains(numberContains))
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No such number");
        }

    }
    else if (command.StartsWith("PrintEven"))
    {
        foreach (int number in numbers)
        {
            if (number % 2 == 0)
            {
                Console.Write($"{number} ");
            }
        }
        Console.WriteLine();

    }
    else if (command.StartsWith("PrintOdd"))
    {
        foreach (int number in numbers)
        {
            if (number % 2 != 0)
            {
                Console.Write($"{number} ");
            }
        }
        Console.WriteLine();

    }
    else if (command.StartsWith("GetSum"))
    {
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine(string.Join(" ", sum));

    }
    else if (command.StartsWith("Filter"))
    {
        string[] filterParameters = command.Split(" ");
        string condition = filterParameters[1];
        int filterNumber = int.Parse(filterParameters[2]);

        if (condition == "<")
        {
            Console.WriteLine(string.Join(" ", numbers.Where(num => num < filterNumber)));
        }
        else if (condition == ">")
        {
            Console.WriteLine(string.Join(" ", numbers.Where(num => num > filterNumber)));
        }
        else if (condition == "<=")
        {
            Console.WriteLine(string.Join(" ", numbers.Where(num => num <= filterNumber)));
        }
        else if (condition == ">=")
        {
            Console.WriteLine(string.Join(" ", numbers.Where(num => num >= filterNumber)));
        }
    }

    command = Console.ReadLine();
}

Console.WriteLine(string.Join(" ", numbers));
