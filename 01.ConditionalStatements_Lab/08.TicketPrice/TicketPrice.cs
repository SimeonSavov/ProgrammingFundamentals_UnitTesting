namespace _08.TicketPrice
{
    internal class TicketPrice
    {
        static void Main(string[] args)
        {
            string ticketType = Console.ReadLine();
            double price = 0;

            if (ticketType == "student")
            {
                price = 1;
                Console.WriteLine($"${price:f2}");
            }
            else if (ticketType == "regular")
            {
                price = 1.6;
                Console.WriteLine($"${price:f2}");
            }
            else
            {
                Console.WriteLine("Invalid ticket type!");
            }
        }
    }
}