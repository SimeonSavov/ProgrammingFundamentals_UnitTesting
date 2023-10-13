int number = int.Parse(Console.ReadLine());

for (int firstDigit = 1; firstDigit <= 9; firstDigit++)
{
	for (int secondDigit = 0; secondDigit <= 9; secondDigit++)
	{
		for (int thirdDigit = 0; thirdDigit <= 9; thirdDigit++)
		{
			if (firstDigit * secondDigit * thirdDigit == number)
			{
				Console.Write($"{firstDigit}{secondDigit}{thirdDigit} ");
			} 

        }
	}
}