int number = int.Parse(Console.ReadLine());

for (int firstNumber = 2; firstNumber <= number; firstNumber += 2) // even digit
{

	for (int secondNumber = 1; secondNumber <= number; secondNumber += 2) // odd digit
	{
        Console.Write($"{firstNumber}{secondNumber}{firstNumber * secondNumber} ");
    }
}