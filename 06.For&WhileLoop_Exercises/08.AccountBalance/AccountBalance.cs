namespace _08.AccountBalance
{
    internal class AccountBalance
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            double balance = 0;

            while (input != "End")
            {
                double currentNumber = double.Parse(input);

                if (currentNumber > 0)
                {
                    balance += currentNumber;
                    Console.WriteLine($"Increase: {currentNumber:f2}");
                }
                else if (currentNumber < 0) 
                {

                    balance -= Math.Abs(currentNumber);
                    Console.WriteLine($"Decrease: {Math.Abs(currentNumber):f2}");
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Balance: {balance:f2}");
        }
    }
}