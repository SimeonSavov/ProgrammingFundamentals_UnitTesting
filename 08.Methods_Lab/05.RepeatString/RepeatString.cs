static string RepeatString(string text, int count)
{
    string output = "";
	for (int i = 0; i < count; i++)
	{
		output += text;
	}

    return output;
}

string text = Console.ReadLine();
int count = int.Parse(Console.ReadLine());

string result = RepeatString(text, count);


Console.WriteLine(result);