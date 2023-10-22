List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

List<int> output = new List<int>(); 

int maxLength = 1; // Initialize the maximum length to 1
int currentLength = 1; // Initialize the current length to 1
int number = numbers[0]; // Initialize the current number

for (int i = 1; i < numbers.Count; i++)
{
    if (numbers[i] == numbers[i - 1])
    {
        currentLength++;

        if (currentLength > maxLength)
        {
            maxLength = currentLength;
            number = numbers[i]; // Update the number if the current sequence is longer
        }
    }
    else
    {
        currentLength = 1; // Reset the current length
    }
}

for (int i = 0; i < maxLength; i++)
{
    output.Add(number);
}

Console.WriteLine(string.Join(" ", output));
