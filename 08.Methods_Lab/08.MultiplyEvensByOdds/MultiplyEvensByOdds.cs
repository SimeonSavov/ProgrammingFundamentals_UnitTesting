int number = int.Parse(Console.ReadLine());

number = Math.Abs(number); // Get absolute value of the negative numbers!
int output = GetMultipleOfEvenAndOdds(number);

Console.WriteLine(output);


static int GetMultipleOfEvenAndOdds(int number)
{
    int sumEven = GetSumOfEvenDigits(number);
    int sumOdd = GetSumOfOddDigits(number);

    int result = sumEven * sumOdd;
    return result;
}

static int GetSumOfOddDigits(int number)
{
    int sum = 0;
    while (number > 0)
    {
        int digit = number % 10;
        number /= 10;

        if (digit % 2 != 0) // Only the odd digits!
        {
            sum += digit;
        }
    }
    return sum;
}

static int GetSumOfEvenDigits(int number)
{
    int sum = 0;
    while (number > 0)
    {
        int digit = number % 10;
        number /= 10;

        if (digit % 2 == 0) // Only the even digits!
        {
            sum += digit;
        }
    }
    return sum;
}