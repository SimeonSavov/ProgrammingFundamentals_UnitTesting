int[] array = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();


int middleStart = array.Length / 2 - 1;
int middleEnd = middleStart + 1;

double sum = 0;

for (int i = middleStart; i <= middleEnd; i++)
{
    sum += array[i];
}

double average = sum / 2;


Console.WriteLine($"{average:f2}");