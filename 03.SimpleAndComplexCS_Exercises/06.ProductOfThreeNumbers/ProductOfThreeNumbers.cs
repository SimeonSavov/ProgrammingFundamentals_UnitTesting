﻿using System.ComponentModel.Design;

namespace _06.ProductOfThreeNumbers
{
    internal class ProductOfThreeNumbers
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            if (num1 == 0 || num2 == 0 || num3 == 0)
                Console.WriteLine("zero");
            else if (num1 > 0 && num2 > 0 && num3 > 0)
                Console.WriteLine("positive");
            else if (num1 > 0 && num2 > 0 && num3 < 0)
                Console.WriteLine("negative");
            else if (num1 > 0 && num2 < 0 && num3 > 0)
                Console.WriteLine("negative");
            else if (num1 > 0 && num2 < 0 && num3 < 0)
                Console.WriteLine("positive");
            else if (num1 < 0 && num2 > 0 && num3 > 0)
                Console.WriteLine("negative");
            else if (num1 < 0 && num2 > 0 && num3 < 0)
                Console.WriteLine("positive");
            else if (num1 < 0 && num2 < 0 && num3 > 0)
                Console.WriteLine("positive");
            else if (num1 < 0 && num2 < 0 && num3 < 0)
                Console.WriteLine("negative");
        }
    }
}