List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

List<int> bomb = Console.ReadLine().Split().Select(int.Parse).ToList();
int bombNum = bomb[0];
int bombPow = bomb[1];


for (int i = 0; i < numbers.Count; i++)
{
    if (numbers[i] == bombNum)
    {
        int startIndex = i - bombPow;
        int removeCount = bombPow + bombPow + 1;

        if (startIndex < 0)
        {
            startIndex = 0;
        }

        if (startIndex + removeCount > numbers.Count)
        {
            removeCount = numbers.Count - startIndex;
        }

        numbers.RemoveRange(startIndex, removeCount);
        i = -1;
    }
}

int sum = numbers.Sum();

Console.WriteLine(sum);