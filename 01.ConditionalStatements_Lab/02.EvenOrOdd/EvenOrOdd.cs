namespace _02.EvenOrOdd
{
    internal class EvenOrOdd
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }
        }
    }
}