namespace _12.CoffeeShopWithChecks
{
    internal class CoffeeShopWithChecks
    {
        static void Main(string[] args)
        {
            string drink = Console.ReadLine();
            string extra = Console.ReadLine();

            double price = 0;
            bool isValid = true;

            if (drink == "coffee")
            {
                price += 1;
            }
            else if (drink == "tea")
            {
                price += 0.6;
            }
            else
            {
                Console.WriteLine("Unknown drink");
                isValid = false;
            }

            if (isValid)
            {
                if (extra == "sugar")
                {
                    price += 0.4;
                }
                else if (extra == "no")
                {
                    price += 0.0;
                }
                else
                {
                    Console.WriteLine("Unknown extra");
                    isValid = false;
                }

                if (isValid )
                {
                    Console.WriteLine($"Final price: ${price:f2}");
                }
            }
            
        }
    }
}