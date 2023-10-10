namespace _06.TravelSavings
{
    internal class TravelSavings
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();

            while(destination != "End")
            {
                double collectedSum = 0;

                double budget = double.Parse(Console.ReadLine());

                while (collectedSum < budget)
                {
                    double currentSum = double.Parse(Console.ReadLine());
                    collectedSum += currentSum;

                    Console.WriteLine($"Collected: {collectedSum:f2}");
                }

                Console.WriteLine($"Going to {destination}!");

                destination = Console.ReadLine();
            }
        }
    }
}