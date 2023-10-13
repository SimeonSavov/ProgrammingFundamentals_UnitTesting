string text = Console.ReadLine();

Console.WriteLine(GetCountVowels(text));


static int GetCountVowels(string text)
{
	int count = 0; // vowels count

	for (int position = 0; position <= text.Length - 1; position++)
	{
		char currentSymbol = text[position];
		if (currentSymbol == 'A' || currentSymbol == 'a'
			|| currentSymbol == 'E' || currentSymbol == 'e'
			|| currentSymbol == 'I' || currentSymbol == 'i'
			|| currentSymbol == 'O' || currentSymbol == 'o'
			|| currentSymbol == 'U' || currentSymbol == 'u')
		{
			count++;
		}
	}

	return count;
}
