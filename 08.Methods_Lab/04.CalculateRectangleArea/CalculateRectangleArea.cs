static int CalculateRectArea(int width, int height)
{
    return width * height;
}

int width = int.Parse(Console.ReadLine());
int height = int.Parse(Console.ReadLine());

int area = CalculateRectArea(width, height);

Console.WriteLine(area);
