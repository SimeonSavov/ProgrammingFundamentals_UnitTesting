List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();

int rotations = int.Parse(Console.ReadLine());

for (int i = 0; i < rotations; i++)
{
    int currentNumber = input[0];
    input.RemoveAt(0); // Remove the first digit in index "0"
    input.Add(currentNumber); // Add the digit in last position of the list
}

Console.WriteLine(string.Join(" ", input));