namespace _04.SumDigits
{
    internal class SumDigits
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int sum = 0;

            while (num > 0)
            {
                int digit = num % 10; // 1234 % 10 == 4
                sum += digit;
                num /= 10; // 1234 / 10 == 123 and again to the "%"
            }

            Console.WriteLine(sum);
        }
    }
}