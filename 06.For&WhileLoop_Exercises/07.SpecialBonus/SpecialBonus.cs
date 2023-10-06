namespace _07.SpecialBonus
{
    internal class SpecialBonus
    {
        static void Main(string[] args)
        {
            int stopNumber = int.Parse(Console.ReadLine());
            int prevNumber = stopNumber;

            while (true)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                if (currentNumber == stopNumber)
                {
                    Console.WriteLine(prevNumber * 1.2);
                    break;
                }

                prevNumber = currentNumber;
            }
        }
    }
}