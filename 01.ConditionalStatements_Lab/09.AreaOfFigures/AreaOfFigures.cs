namespace _09.AreaOfFigures
{
    internal class AreaOfFigures
    {
        static void Main(string[] args)
        {
            string figureType = Console.ReadLine();

            if (figureType == "square")
            {
                double size = double.Parse(Console.ReadLine());
                double area = size * size;
                Console.WriteLine($"{area:f2}");
            }
            else if (figureType == "rectangle")
            {
                double num1 = double.Parse(Console.ReadLine());
                double num2 = double.Parse(Console.ReadLine());
                double area = num1 * num2;
                Console.WriteLine($"{area:f2}");
            }
            else if (figureType == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                double area = Math.PI * Math.Pow(radius, 2);
                Console.WriteLine($"{area:f2}");
            }
            else
            {
                Console.WriteLine("Invalid figure.");
            }
        }
    }
}