namespace _03.SumNumbers
{
    internal class SumNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double sum = 0;

            for (int i = 1; i <= n; i++)
            {
                double currentNum = double.Parse(Console.ReadLine());

                sum += currentNum;

            }

            Console.WriteLine(sum);
        }
    }
}