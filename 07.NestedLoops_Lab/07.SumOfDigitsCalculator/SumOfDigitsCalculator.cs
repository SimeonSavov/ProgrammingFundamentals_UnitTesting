namespace _07.SumOfDigitsCalculator
{
    internal class SumOfDigitsCalculator
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "End") 
            {
                int sumOfDigits = 0;
                int currentNumber = int.Parse(input);

                for (int i = currentNumber; i > 0; i /= 10)
                {
                    int digit = i % 10;
                    sumOfDigits += digit;
                }

                Console.WriteLine($"Sum of digits = {sumOfDigits}");

                input = Console.ReadLine();
            }

            Console.WriteLine("Goodbye");
        }
    }
}