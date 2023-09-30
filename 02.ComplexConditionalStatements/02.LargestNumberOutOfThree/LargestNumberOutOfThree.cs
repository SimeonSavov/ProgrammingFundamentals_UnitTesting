namespace _02.LargestNumberOutOfThree
{
    internal class LargestNumberOutOfThree
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3) 
                {
                    Console.WriteLine(num1);
                }
                else
                {
                    Console.WriteLine(num3);
                }
            }
            else if (num1 < num2)
            {
                if (num2 > num3)
                {
                    Console.WriteLine(num2);
                }
                else
                {
                    Console.WriteLine(num3);
                }
            }
        }
    }
}