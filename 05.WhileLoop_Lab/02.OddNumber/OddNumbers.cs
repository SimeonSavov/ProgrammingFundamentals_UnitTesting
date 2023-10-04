namespace _02.OddNumber
{
    internal class OddNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            while (n % 2 == 0)
            {
                n = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(n);


        }
    }
}