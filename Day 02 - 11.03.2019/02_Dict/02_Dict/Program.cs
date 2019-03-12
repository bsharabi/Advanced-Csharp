using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Dict
{
    class Program
    {
        static void Main(string[] args)
        {

            // Dictionary can contain item with an unique key 
            Dictionary<string, double> studentsGrade = new Dictionary<string, double>();


            // Adds the specified key and value to the dictionary
            studentsGrade.Add("Bob", 90.5);
            studentsGrade.Add("Alice", 100);

            Console.WriteLine($"Bob got: {studentsGrade["Bob"]}");
            Console.WriteLine($"Alice got: {studentsGrade["Alice"]}");

            var s=studentsGrade.Keys;

            foreach (KeyValuePair<string,double> item in studentsGrade)
            {
                Console.WriteLine(item.Key + " " + item.Value );
            }


            // ContainsKey Determines whether we have already this key in the dictionary
            if (!studentsGrade.ContainsKey("Alice"))
            {
                studentsGrade.Add("Alice", 100);
            }
            else
            {
                Console.WriteLine("Alice already exists");
            }


        }
    }
}
