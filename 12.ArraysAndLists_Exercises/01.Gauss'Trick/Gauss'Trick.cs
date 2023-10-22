List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();


List<int> output = new List<int>(); // Empty list for the output

for (int i = 0; i < numbers.Count / 2; i++)
{
    int sum = numbers[0 + i] + numbers[numbers.Count - 1 - i];
    output.Add(sum);
}

if (numbers.Count % 2 != 0) // Odd count numbers in the list
{
    int middleDigit = numbers[numbers.Count / 2]; // Get the middle digit
    output.Add(middleDigit);
}

Console.WriteLine(string.Join(" ", output));