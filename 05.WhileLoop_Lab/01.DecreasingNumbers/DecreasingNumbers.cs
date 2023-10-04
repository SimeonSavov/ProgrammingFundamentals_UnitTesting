namespace _01.DecreasingNumbers
{
    internal class DecreasingNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            while (n >= 1)
            {
                Console.WriteLine(n);
                n--;
            }
        }
    }
}