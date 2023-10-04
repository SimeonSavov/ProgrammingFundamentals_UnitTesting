namespace _02.FirstNNumbersSum
{
    internal class FirstNNumbersSum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 1;
            Console.Write(1);

            for (int i = 2; i <= n; i++)
            {
                Console.Write($"+{i}");

                sum += i;
            }

            Console.Write($"={sum}");

        }
    }
}