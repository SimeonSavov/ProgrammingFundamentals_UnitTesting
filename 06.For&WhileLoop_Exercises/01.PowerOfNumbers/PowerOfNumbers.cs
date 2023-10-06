namespace _01.PowerOfNumbers
{
    internal class PowerOfNumbers
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            int result = 1;
            for (int time = 1; time <= power; time++)
            {
                result = result * number;
            }

            Console.WriteLine(result);
        }
    }
}