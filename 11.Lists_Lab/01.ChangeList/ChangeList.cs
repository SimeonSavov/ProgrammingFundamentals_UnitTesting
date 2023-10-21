List<int> numbers = Console.ReadLine() // "1 2 3 4 5 5 5 6"
                    .Split(" ")        // ["1", "2", "3", "4", "5", "5", "5", "6"]
                    .Select(int.Parse) // [1, 2, 3, 4, 5, 5, 5, 6]
                    .ToList();         // {1, 2, 3, 4, 5, 5, 5, 6}

string command = Console.ReadLine();

while(command != "end")
{
    // Valid command
    // 1. command = "Delete {element}".Split(" ") -> ["Delete", "{element}"]
    // 2. command = "Insert {element} {position}".Split(" ") --> ["Insert", {element}, {pisition}]
    string[] commandParts = command.Split(" ");

    string commandName = commandParts[0]; // name of the command: "Delete" or "Insert"

    int element = int.Parse(commandParts[1]);

    if (commandName == "Delete")
    {
        // delete all elements in the array, which are equal to the given element
        // { 1, 2, 3, 4, 5, 5, 5, 6}
        numbers.RemoveAll(number => number == element);
    }
    else if (commandName == "Insert")
    {
        int position = int.Parse(commandParts[2]);

        // insert the element at the given position
        numbers.Insert(position, element);
    }

    command = Console.ReadLine();
}

Console.WriteLine(string.Join(" ", numbers));

