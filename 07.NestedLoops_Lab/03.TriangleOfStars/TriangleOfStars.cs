namespace _03.TriangleOfStars
{
    internal class TriangleOfStars
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            for (int row = 1; row <= size; row++)
            {
                for (int numberOfStar = 1; numberOfStar <= row; numberOfStar++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}