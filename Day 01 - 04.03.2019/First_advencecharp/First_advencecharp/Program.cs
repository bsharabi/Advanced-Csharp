using System;
using System.Collections.Generic;

namespace First_advencecharp
{
    class Program
    {
        static void print(List<string> mycart)
        {
            foreach ( string item in mycart)
                {
                Console.Write(item + " ");
                }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            List<string> mycart = new List<string>();
            while(true)
            {
                Console.WriteLine("Please entart a product");
                string product = Console.ReadLine();
                if (mycart.IndexOf(product) == -1)
                {
                    mycart.Add(product);
                }
                else
                {
                    Console.WriteLine("Sorry the product already exiest");
                }
           
                Console.WriteLine("for continue press y else press n");
                product = Console.ReadLine();
                if (product == "n")
                    break;
            }
            print(mycart);
        }
    }
}
