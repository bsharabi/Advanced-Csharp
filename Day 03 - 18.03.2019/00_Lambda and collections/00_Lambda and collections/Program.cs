using System;
using System.Collections.Generic;
using System.Linq;

namespace _00_Lambda_and_collections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            names.AddRange(new string[] {"Bob","Alice","Ben","Ofek","Ariel","Roi" });

            // Determines whether a sequence contains any elements.
            Console.WriteLine(names.Any());

            // Determines whether a sequence contains any element with less than 1 char
            Console.WriteLine(names.Any(x=>x.Length<1));


            // Determines whether all elements of a sequence satisfy a condition.
            Console.WriteLine(names.All(x => x.Length > 1));


            // Returns the first element in a sequence that satisfies a specified condition.
            // Throws "System.InvalidOperationException:" if Sequence contains no matching element
            Console.WriteLine(names.First(x => x.Length > 1));  


            // Returns the first element of the sequence that satisfies a condition or a default value if no such element is found.
            Console.WriteLine(names.FirstOrDefault(x => x.Length < 1));

            // Returns the last element in a sequence that satisfies a specified condition.
            // Throws "System.InvalidOperationException:" if Sequence contains no matching element
            Console.WriteLine(names.Last(x => x.Length > 1));


            // Returns the last element of the sequence that satisfies a condition or a default value if no such element is found.
            Console.WriteLine(names.LastOrDefault(x => x.Length < 1));

            //Inverts the order of the elements in a sequence.
            names.Select(x => x.Length < 1).ToList().ForEach(x => Console.Write(x + " "));
            Console.WriteLine();


            Console.WriteLine(names.Find(x => x.Length > 3));

            //Retrieves all the elements that match the conditions defined by the specified predicate.
            names.FindAll(x => x.Length > 3).ForEach(x => Console.Write(x+ " "));
            Console.WriteLine();

            Console.WriteLine(names.GroupBy(x=>x.StartsWith("a")));
        }
    }
}
