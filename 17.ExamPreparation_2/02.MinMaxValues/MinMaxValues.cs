int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
int selection = int.Parse(Console.ReadLine());

int max = int.MinValue;
int min = int.MaxValue;

for (int i = 0; i < selection; i++) // Here I only loop to the "selection" input from the console
{
    int currentNum = numbers[i];

    if (max < currentNum)
    {
        max = currentNum;
    }

    if (min > currentNum)
    {
        min = currentNum;
    }
}

Console.WriteLine(max);
Console.WriteLine(min);