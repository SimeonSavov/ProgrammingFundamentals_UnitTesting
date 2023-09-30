namespace _05.VacationExpenses
{
    internal class VacationExpenses
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string accType = Console.ReadLine();
            int countOfDays = int.Parse(Console.ReadLine());

            double totalExpenses = 0;

            if (season == "Spring")
            {
                if (accType == "Hotel")
                {
                    totalExpenses = countOfDays * 30;
                    
                }
                else if (accType == "Camping")
                {
                    totalExpenses = countOfDays * 10;
                    
                }
                totalExpenses *= 0.8;
            }
            else if (season == "Summer")
            {
                if ( accType == "Hotel")
                {
                    totalExpenses = countOfDays * 50;
                }
                else if (accType == "Camping")
                {
                    totalExpenses = countOfDays * 30;
                }
            }
            else if (season == "Autumn")
            {
                if (accType == "Hotel")
                {
                    totalExpenses = countOfDays * 20;
                }
                else if (accType == "Camping")
                {
                    totalExpenses = countOfDays * 15;
                }
                totalExpenses *= 0.7;
            }
            else if (season == "Winter")
            {
                if (accType == "Hotel")
                {
                    totalExpenses = countOfDays * 40;
                }
                else if (accType == "Camping")
                {
                    totalExpenses = countOfDays * 10;
                }
                totalExpenses *= 0.9;
            }

            Console.WriteLine($"{totalExpenses:f2}");
        }
    }
}