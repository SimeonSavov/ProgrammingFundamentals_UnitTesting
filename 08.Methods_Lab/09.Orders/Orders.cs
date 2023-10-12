string product = Console.ReadLine();
int quantity = int.Parse(Console.ReadLine());

double result = CalculatePrice(product, quantity);

Console.WriteLine($"{result:f2}");

static double CalculatePrice(string product, int quantity)
{
    double result = 0;

    if (product == "coffee")
    {
        result = quantity * 1.5;
    }
    else if (product == "water")
    {
        result = quantity * 1;
    }
    else if (product == "coke")
    {
        result = quantity * 1.4;
    }
    else if (product == "snacks")
    {
        result = quantity * 2;
    }

    return result;
}