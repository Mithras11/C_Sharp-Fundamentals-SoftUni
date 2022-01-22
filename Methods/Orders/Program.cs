﻿using System;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            CalculatePrice(product, quantity);

        }

         static void CalculatePrice(string product, int quantity)
        {
            double price = 0.0;
            switch (product)
            {
                case "coffee":
                    price = 1.50;
                    break;

                case "water":
                    price = 1.00;
                    break;

                case "coke":
                    price = 1.40;
                    break;

                case "snacks":
                    price = 2.00;
                    break;
            }
            price *= quantity;

            Console.WriteLine($"{price:F2}");
        }
    }
}
/*	coffee – 1.50
⦁	water – 1.00
⦁	coke – 1.40
⦁	snacks – 2.00*/
