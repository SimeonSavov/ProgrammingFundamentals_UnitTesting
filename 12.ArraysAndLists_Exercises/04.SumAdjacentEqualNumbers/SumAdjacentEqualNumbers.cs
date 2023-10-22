List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();

for (int i = 0; i < input.Count - 1; i++)
{
    int num1 = input[i];
    int num2 = input[i + 1];

    if (num1 == num2)
    {
        input[i] = num1 + num2;
        input.RemoveAt(i + 1);

        i = -1;
    }
}

Console.WriteLine(string.Join(" ", input));