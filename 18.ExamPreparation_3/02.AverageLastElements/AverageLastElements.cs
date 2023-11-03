int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
int selection = int.Parse(Console.ReadLine());

int sumOfElements = 0;

for (int i = array.Length - 1; i > array.Length - 1 - selection; i--)
{
    int currentNum = array[i];
    sumOfElements += currentNum;
}

double result = (double) sumOfElements / selection;
Console.WriteLine($"{result:F2}");