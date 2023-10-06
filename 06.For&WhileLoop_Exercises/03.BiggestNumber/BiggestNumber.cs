namespace _03.BiggestNumber
{
    internal class BiggestNumber
    {
        static void Main(string[] args)
        {
            int countNumbers = int.Parse(Console.ReadLine());

            int maxNumber = int.MinValue;

            for (int i = 1; i <= countNumbers; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                
                if (currentNumber > maxNumber)
                {
                    maxNumber = currentNumber;
                }
            }

            Console.WriteLine(maxNumber);

        }
    }
}