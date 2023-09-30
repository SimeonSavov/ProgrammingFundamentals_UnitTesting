namespace _01.NumberType
{
    internal class NumberType
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            if (number < 0 )
            {
                Console.WriteLine("negative");
            }
            else if (number == 0)
            {
                Console.WriteLine("zero");
            }
            else
            {
                Console.WriteLine("positive");
            }
        }
    }
}