using System.Runtime.InteropServices;

int number = int.Parse(Console.ReadLine());

bool isThereNoMatchingNumbers = true;

for (int i = 1; i <= number; i++)
{
    int workingNum = i;
    int digitSum = 0;
    bool isAllDigitsPrime = true;
    
    while (workingNum > 0)
    {
        int digit = workingNum % 10;
        workingNum = workingNum / 10;

        bool isDigitPrime = isPrime(digit);

        if (isDigitPrime)
        {
            digitSum += digit;
        }
        else
        {
            isAllDigitsPrime = false;
            break;
        }
    }


    if (isAllDigitsPrime && digitSum % 2 == 0)
    {
        Console.Write(i + " ");
        isThereNoMatchingNumbers = false;
    }
}

if (isThereNoMatchingNumbers)
{
    Console.WriteLine("no");
}


static bool isPrime(int n)
{
    bool answer = true;

    if (n <= 1)
    {
        answer = false;
    }
    else
    {
        for (int i = 2; i < n; i++)
        {
            if (n % i == 0)
            {
                answer = false;
                break;
            }
        }
    }
    return answer;
}