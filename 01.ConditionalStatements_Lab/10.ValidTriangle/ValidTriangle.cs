namespace _10.ValidTriangle
{
    internal class ValidTriangle
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double num3 = double.Parse(Console.ReadLine());

            if (num1 + num2 <= num3)
            {
                Console.WriteLine("Invalid Triangle");
            }
            else if (num1 + num3 <= num2)
            {
                Console.WriteLine("Invalid Triangle");
            }
            else if (num2 + num3 <= num1)
            {
                Console.WriteLine("Invalid Triangle");
            }
            else
            {
                Console.WriteLine("Valid Triangle");
            }
        }
    }
}