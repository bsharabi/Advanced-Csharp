using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_sort_list_of_student
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            students.AddRange(
                new Student[]
                {
                    new Student {Name="Bob", Age=15, Grade=100 },
                    new Student {Name="Tom", Age=16, Grade=98 },
                    new Student {Name="Yakir", Age=20, Grade=84 },
                    new Student {Name="Alice", Age=30, Grade=50 }
                });


            Console.WriteLine("*********************Sort*********************");
            Console.WriteLine("-----------By Age------------");
            students.Sort((s1, s2) => s2.Age- s1.Age);
            students.ForEach(s => Console.WriteLine(s));

            Console.WriteLine("-----------By Grade------------");
            students.Sort((s1, s2) => s2.Grade - s1.Grade);
            students.ForEach(s => Console.WriteLine(s));

            Console.WriteLine("-----------By Name------------");
            students.Sort((s1, s2) => s1.Name.CompareTo(s2.Name));
            students.ForEach(s => Console.WriteLine(s));


            Console.WriteLine("*********************OrderByDescending*********************");
            Console.WriteLine("-----------By Age------------");
            students.OrderByDescending(s=> s.Age).ToList().ForEach(s => Console.WriteLine(s));

            Console.WriteLine("-----------By Grade------------");
            students.OrderByDescending(s => s.Grade).ToList().ForEach(s => Console.WriteLine(s));

            Console.WriteLine("-----------By Name------------");
            students.OrderByDescending(s => s.Name).ToList().ForEach(s => Console.WriteLine(s));

            
            Console.WriteLine("-----------By Default------------");
            students.OrderBy(s => s).ToList().ForEach(s => Console.WriteLine(s));

        }
    }
}
