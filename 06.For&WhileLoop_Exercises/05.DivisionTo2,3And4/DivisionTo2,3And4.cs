namespace _05.DivisionTo2_3And4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countNumbers = int.Parse(Console.ReadLine());

            int count2 = 0; // Divided number by 2
            int count3 = 0; // Divided number by 3
            int count4 = 0; // Divided number by 4

            for (int i = 1; i <= countNumbers; i++)
            {
                int value = int.Parse(Console.ReadLine());

                if (value % 2 == 0)
                {
                    count2++;
                }

                if (value % 3 == 0)
                {
                    count3++;
                }

                if (value % 4 == 0)
                {
                    count4++;
                }
            }

            double perc2 = ((double)count2 / countNumbers) * 100;
            double perc3 = ((double)count3 / countNumbers) * 100;
            double perc4 = ((double)count4 / countNumbers) * 100;

            Console.WriteLine($"{perc2:f2}%");
            Console.WriteLine($"{perc3:f2}%");
            Console.WriteLine($"{perc4:f2}%");
        }
    }
}