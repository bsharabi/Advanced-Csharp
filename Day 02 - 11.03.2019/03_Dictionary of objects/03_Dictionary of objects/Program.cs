using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Dictionary_of_objects
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Food> foodStock = new Dictionary<string, Food>();
            foodStock.Add("Chips", new Food { Price = 17, IsVeg = false });
            foodStock.Add("Salad", new Food { Price = 50, IsVeg = true });
            foodStock.Add("Pizza", new Food { Price = 14, IsVeg = false });

            foreach (KeyValuePair<string, Food> item in foodStock)
            {
                Console.WriteLine($"{item.Key} - {item.Value.GetDesc()}");
            }

            string selectedFood = "Chips";
            Console.WriteLine(foodStock[selectedFood].GetDesc()); // --> Price: 17, IsVeg : False
        }
    }
}
