namespace _05.NumbersInRange
{
    internal class NumbersInRange
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            bool inRange = num >= 1 && num <= 100; // Number between 1 and 100;

            while (!inRange)
            {
                num = int.Parse(Console.ReadLine());
                inRange = num >= 1 && num <= 100; // Again we need to check if the number is between the range
            }

            Console.WriteLine(num);
        }
    }
}