namespace _07.LatinLetters
{
    internal class LatinLetters
    {
        static void Main(string[] args)
        {
            char letter1 = char.Parse(Console.ReadLine());
            char letter2 = char.Parse(Console.ReadLine());

            for (char ch = letter1; ch <= letter2; ch++)
            {
                Console.Write($"{ch} ");
            }
        }
    }
}