namespace _03.BonusScore
{
    internal class BonusScore
    {
        static void Main(string[] args)
        {
            int points = int.Parse(Console.ReadLine());

            int bonus = 0;

            if (points >= 0 && points <= 3)
            {
                bonus = 5;
            }
            else if (points >= 4 && points <= 6)
            {
                bonus = 15;
            }
            else if (points >= 7 && points <= 9)
            {
                bonus = 20;
            }

            int totalSum = bonus + points;
            Console.WriteLine(totalSum);
        }
    }
}