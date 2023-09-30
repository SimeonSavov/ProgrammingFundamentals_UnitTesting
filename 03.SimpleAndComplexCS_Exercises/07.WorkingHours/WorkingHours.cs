namespace _07.WorkingHours
{
    internal class WorkingHours
    {
        static void Main(string[] args)
        {
            int hourOfTheDay = int.Parse(Console.ReadLine());
            string day = Console.ReadLine();

            if (day == "Sunday")
            {
                Console.WriteLine("closed");
            }
            else
            {
                if (hourOfTheDay >= 10 && hourOfTheDay <= 18)
                {
                    Console.WriteLine("open");
                }
                else
                {
                    Console.WriteLine("closed");
                }
            }

        }
    }
}