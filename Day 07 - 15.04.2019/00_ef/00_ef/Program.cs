using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_ef
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (NorthwindEntities ef = new NorthwindEntities())
                {
                    foreach (Category item in ef.Categories)
                    {
                        Console.WriteLine(item.CategoryName);
                    }

                    Category change = ef.Categories.FirstOrDefault(x => x.CategoryName.StartsWith("B"));
                    Console.WriteLine($"we selected: {change.CategoryName}");

                    change.CategoryName = "NewCategory";
                    Console.WriteLine($"we changed to: {change.CategoryName}");

                    ef.SaveChanges();

                }


            }
            catch
            {
                Console.WriteLine("Error...");
            }
            }
    }
}
