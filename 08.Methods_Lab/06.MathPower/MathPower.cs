static int MathPower(int baseNumber, int powerNumber)
{
    int output = baseNumber;
	for (int i = 0; i < powerNumber - 1; i++)
	{
		output *= baseNumber;
	}

	return output;
}

int baseNumber = int.Parse(Console.ReadLine());
int powerNumber = int.Parse(Console.ReadLine());

int result = MathPower(baseNumber, powerNumber);

Console.WriteLine(result);
