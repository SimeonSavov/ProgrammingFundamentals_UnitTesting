namespace _01.Freezing_Weather
{
    internal class FreezingWeather
    {
        static void Main(string[] args)
        {
            double celsius = double.Parse(Console.ReadLine());

            if (celsius <= 0)
            {
                Console.WriteLine("Freezing weather!");
            }
        }
    }
}