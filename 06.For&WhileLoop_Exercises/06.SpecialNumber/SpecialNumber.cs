using System.Runtime.InteropServices;

namespace _06.SpecialNumber
{
    internal class SpecialNumber
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int startNumber = number;
            bool isSpecial = true;

            while (number > 0)
            {
                int lastDiggit = number % 10; // Get last diggit of the number

                if (startNumber % lastDiggit != 0)
                {
                    isSpecial = false;
                    break;
                }

                number /= 10; 
            }
            

            if (isSpecial)
            {
                Console.WriteLine($"{startNumber} is special"); // special
            }
            else
            {
                Console.WriteLine($"{startNumber} is not special"); // not special
            }
        }
    }
}