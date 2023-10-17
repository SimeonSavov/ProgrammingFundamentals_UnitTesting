int n = int.Parse(Console.ReadLine());

int[] numbers = new int[n];

for (int i = 0; i <= numbers.Length - 1; i++)
{
    numbers[i] = int.Parse(Console.ReadLine());
}

for (int index = numbers.Length - 1; index >= 0; index--)
{
    Console.Write(numbers[index] + " ");
}