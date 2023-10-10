namespace _08.PrimeNumbers
{
    internal class PrimeNumbers
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            for (int currentNumber = start; currentNumber <= end; currentNumber++)
            {
                bool isPrime = true;
                int divider = 2;

                while (divider < end)
                {
                    if (currentNumber == divider)
                    {
                        divider++;
                        continue;
                    }

                    if (currentNumber % divider == 0)
                    {
                        isPrime = false;
                        break;
                    }

                    divider++;
                }

                if (isPrime)
                {
                    Console.Write($"{currentNumber} ");
                }
            }
        }
    }
}