List<int> array = Console.ReadLine().Split().Select(int.Parse).ToList();
int rotations = int.Parse(Console.ReadLine());

for (int rotation = 0; rotation < rotations; rotation++)
{
    int lastElement = array[array.Count - 1];
    array.RemoveAt(array.Count - 1);
    array.Insert(0, lastElement);
}

Console.WriteLine(string.Join(", ", array));
