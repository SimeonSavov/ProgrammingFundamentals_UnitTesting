﻿namespace _02.ATM
{
    internal class ATM
    {
        static void Main(string[] args)
        {
            int balance = int.Parse(Console.ReadLine());
            int withdraw = int.Parse(Console.ReadLine());
            int limit = int.Parse(Console.ReadLine());

            if (withdraw <= balance)
            {
                Console.WriteLine("The withdraw was successful.");
            }
            else if (withdraw > limit)
            {
                Console.WriteLine("The limit was exceeded.");
            }
            else
            {
                Console.WriteLine("Insufficient availability.");
            }
        }
    }
}