using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_list
{
    class Program
    {

       static void PrintList(List<string> myList)
        {
            Console.WriteLine("Capacity: "+myList.Capacity);

            foreach (string item in myList)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            List<string> myCart = new List<string>();
            PrintList(myCart);

            myCart.Add("Book1");
            myCart.Add("Book2");
            PrintList(myCart);

            myCart.AddRange(new string[] { "Book3", "Book4" });
            PrintList(myCart);


            myCart.Insert(2, "Book5");
            PrintList(myCart);

            myCart.InsertRange(0,new string[] { "Book6", "Book7" });
            PrintList(myCart);


            myCart.Remove("Book1");
            PrintList(myCart);


            myCart.RemoveAt(0);
            PrintList(myCart);


            myCart.RemoveRange(1, 3);
            PrintList(myCart);


            myCart.Reverse();
            PrintList(myCart);


            Console.WriteLine(myCart.IndexOf("Book8"));


        }
    }
}
