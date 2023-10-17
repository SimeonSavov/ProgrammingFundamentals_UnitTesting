int[] numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

// Sum of even digits in the array
int evenSum = 0;

// Sum of odd digits in the array
int oddSum = 0;

foreach (int digit in numbers)
{
    if (digit % 2 == 0) // even digits
    {
        evenSum += digit;
    }
    else // odd digits
    {
        oddSum += digit;
    }
}

// Find the diff between even and odd sum and print it
Console.WriteLine(evenSum - oddSum);