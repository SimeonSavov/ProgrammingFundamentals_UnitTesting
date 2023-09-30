namespace _10.SummerOutfit
{
    internal class SummerOutfit
    {
        static void Main(string[] args)
        {
            int temp = int.Parse(Console.ReadLine());
            string dayTime = Console.ReadLine();

            string shoes = "";
            string clothing = "";

            if ((dayTime == "Evening")
                || (dayTime == "Afternoon" && temp <= 18)
                || (dayTime == "Morning" && temp > 18 && temp <= 24))
            {
                clothing = "Shirt";
                shoes = "Moccasins";
            }
            else if ((dayTime == "Morning" && temp >= 25) 
                || (dayTime == "Afternoon" && temp > 18 && temp <= 24))
            {
                clothing = "T-Shirt";
                shoes = "Sandals";
            }
            else if (dayTime == "Morning" && temp <= 18)
            {
                clothing = "Sweatshirt";
                shoes = "Sneakers";
            }
            else if (dayTime == "Afternoon" && temp >= 25)
            {
                clothing = "Swim Suit";
                shoes = "Barefoot";
            }

            Console.WriteLine($"It's {temp} degrees, get your {clothing} and {shoes}.");
        }
    }
}