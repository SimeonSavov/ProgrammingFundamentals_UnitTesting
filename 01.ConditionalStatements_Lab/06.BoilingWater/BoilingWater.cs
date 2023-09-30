using System.Diagnostics.Metrics;

namespace _06.BoilingWater
{
    internal class BoilingWater
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());

            if (number > 100)
            {
                Console.WriteLine("The water is boiling");
            }
            else
            {
                Console.WriteLine("The water is not hot enough");
            }


        }
    }
}