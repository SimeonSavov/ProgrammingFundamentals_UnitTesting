namespace _05.NumberPyramid
{
    internal class NumberPyramid
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 1;

            for (int rows = 1; rows < n; rows++)
            {
                for (int cols = 1; cols <= rows; cols++)
                {
                    Console.Write($"{counter} ");
                    counter++;

                    if (counter > n)
                    {
                        break;
                    }
                }

                Console.WriteLine();

                if (counter > n)
                {
                    break;
                }
            }
        }
    }
}