﻿using System;
namespace Uppgift_3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vad heter du ?");
            string namn = Console.ReadLine().ToLower();
            if (namn == "stig")
{
                Console.WriteLine(" Du har namnsdag idag!");
            }
else if (namn == "abraham")
{
                Console.WriteLine("Du har namnsdag imorgon!");
            }
else
            {
                Console.WriteLine("Du har inte namnsdag idag eller imorgon.");
            }
        }
    }
}