int[] firstNumbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
int[] secondNumbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

bool isIdentical = true;

for (int index = 0; index <= firstNumbers.Length - 1; index++)
{
    if (firstNumbers[index] != secondNumbers[index])
    {
        isIdentical = false;
        Console.WriteLine("Arrays are not identical.");
        break;
    }
}

if (isIdentical)
{
    Console.WriteLine("Arrays are identical.");
}