string password = Console.ReadLine();

// 1. Valid length --> 6 to 10 symbols
bool isValidLength = password.Length >= 6 && password.Length <= 10;
// 2. Only letters and digits
bool isValidContent = CheckContent(password);
// 3. At least 2 digits
bool isValidCountDigits = CheckCountDigits(password);

// Valid password
if (isValidLength && isValidContent && isValidCountDigits)
{

    Console.WriteLine("Password is valid");
}
else 
{
    // Invalid password

    // Invalid length
    if (!isValidLength)
    {

        Console.WriteLine("Password must be between 6 and 10 characters");
    }

    // Invalid content of the password
    if (!isValidContent)
    {
        Console.WriteLine("Password must consist only of letters and digits");
    }


    // Invalid pass for wrong digits count
    if (!isValidCountDigits)
    {
        Console.WriteLine("Password must have at least 2 digits");
    }
}


static bool CheckContent(string password)
{
    for (int position = 0; position <= password.Length - 1; position++)
    {
        char symbol = password[position];

        if (char.IsLetterOrDigit(symbol) == false) // Give 'false' if the current digit is not letter or digit!
        {
            return false; // invalid content
        }
    }

    return true; // valid content
}


static bool CheckCountDigits(string password)
{
    int count = 0; // count of the digits in the password
    for (int position = 0; position <= password.Length - 1; position++)
    {
        char symbol = password[position];

        if (char.IsDigit(symbol) == true) // if return 'true', the current symbol is digit!
        {
            count++;
        }
    }

    return count >= 2; // The count is less than 2, the result is 'false'
}
