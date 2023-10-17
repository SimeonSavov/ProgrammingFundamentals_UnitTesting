int[] firstNumbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
int[] secondNumbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

int[] commonElements = firstNumbers.Intersect(secondNumbers).ToArray(); // Return only the common elements between "firstNumbers[]" array and "secondNumbers[]" array

Console.WriteLine(string.Join(" ", commonElements));
