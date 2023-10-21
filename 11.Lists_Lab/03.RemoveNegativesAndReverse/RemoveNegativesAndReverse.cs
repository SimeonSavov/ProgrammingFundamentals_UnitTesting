List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

numbers.RemoveAll(number => number < 0); //Remove negative numbers (number < 0)

numbers.Reverse();

if (numbers.Count == 0)
{
    Console.WriteLine("empty");
}
else
{
    Console.WriteLine(string.Join(" ", numbers));
}
