namespace _04.NumbersEndingIn7
{
    internal class NumbersEndingIn7
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 7; i < n; i += 10)
            {
                Console.WriteLine(i);
            }
        }
    }
}