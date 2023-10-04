namespace _03.Sequence2k_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxNumber = int.Parse(Console.ReadLine());

            int num = 1;

            while (num <= maxNumber)
            {
                Console.WriteLine(num);
                num = num * 2 + 1;
            }

            // ALTERNATIVE

            //for (int i = num; i <= maxNumber; i = i * 2 + 1)
            //{
            //    Console.WriteLine(i);
            //}

        }
    }
}