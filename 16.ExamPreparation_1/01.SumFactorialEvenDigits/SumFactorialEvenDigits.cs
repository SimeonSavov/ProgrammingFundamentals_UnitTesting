static int CalculateFactorial(int number)
{
    int result = 1;

    while (number > 0)
    {
        result *= number;
        number -= 1;
    }

    return result;
}


int number = int.Parse(Console.ReadLine());

int sumOfFactorials = 0;

while (number != 0)
{
    int digit = number % 10;
    if (digit % 2 == 0)
    {
        // int fact = CalculateFactorial(digit);
        sumOfFactorials += CalculateFactorial(digit);
    }

    number /= 10;
}

Console.WriteLine(sumOfFactorials);