namespace _09.Cinema
{
    internal class Cinema
    {
        static void Main(string[] args)
        {
            string typeOfMovie = Console.ReadLine();
            int countOfRows = int.Parse(Console.ReadLine());
            int countOfSeats = int.Parse(Console.ReadLine());

            int totalCountOfSeats = countOfRows * countOfSeats;
            double price = 0;

            if (typeOfMovie == "Premiere")
            {
                price = totalCountOfSeats * 12.0;
            }
            else if (typeOfMovie == "Normal")
            {
                price = totalCountOfSeats * 7.50;
            }
            else if (typeOfMovie == "Discount")
            {
                price = totalCountOfSeats * 5.00;
            }

            Console.WriteLine($"{price:f2}");

        }
    }
}