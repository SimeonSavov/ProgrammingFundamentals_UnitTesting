namespace _01.NumbersInRange
{
    internal class NumbersInRange
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int finish = int.Parse(Console.ReadLine());

            for (int i = start; i <= finish; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}