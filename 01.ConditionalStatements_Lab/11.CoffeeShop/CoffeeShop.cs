namespace _11.CoffeeShop
{
    internal class CoffeeShop
    {
        static void Main(string[] args)
        {
            string drink = Console.ReadLine();
            string extra = Console.ReadLine();

            double price = 0;

            if (drink == "coffee")
            {
                price = 1;
            }
            else if (drink == "tea")
            {
                price = 0.6;
            }

            if (extra == "sugar")
            {
                price += 0.4;
            }

            Console.WriteLine($"Final price: ${price:f2}");
        }
    }
}