int numCount = int.Parse(Console.ReadLine());

List<int> firstList = new List<int>();
List<int> secondList = new List<int>();

for (int i = 0; i < numCount; i++)
{
    List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList(); // Read two integers from the console and add it to the empty list;

    int num1 = numbers[0]; // Get the first digit from the list with index "0";
    int num2 = numbers[1]; // Get the second digit from the list with index "1";

    if (i % 2 == 0) // Even rows
    {
        firstList.Add(num1);
        secondList.Add(num2);
    }
    else // Odd rows
    {
        firstList.Add(num2);
        secondList.Add(num1);
    }
}

Console.WriteLine(string.Join(" ", firstList));
Console.WriteLine(string.Join(" ", secondList));
