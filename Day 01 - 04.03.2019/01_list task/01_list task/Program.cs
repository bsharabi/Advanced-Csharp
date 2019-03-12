using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_list_task
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> myCart = new List<string>();
            while (true)
            {
                Console.WriteLine("Please enter a product");
                string product=Console.ReadLine();
                if (myCart.IndexOf(product) == -1)
                {
                    myCart.Add(product);
                }
                else
                {
                    Console.WriteLine("Sorry - you have already this item");
                }

                Console.WriteLine("Do you want to continue? (y/n)");
                string choice = Console.ReadLine();
                if (choice == "n")
                    break;

            }

            foreach (string item in myCart)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
