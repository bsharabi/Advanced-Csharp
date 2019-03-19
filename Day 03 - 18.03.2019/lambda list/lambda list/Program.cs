using System;
using System.Collections.Generic;

namespace lambda_list
{
    class Program
    {
        static void Main(string[] args)
        {
            int cnt = 0;
            int k = 3;
            List<Student> myStudent = new List<Student>();
            myStudent.AddRange(new Student[]{
                new Student(100,18,"barak"),
                new Student(85,23,"ofek"),
                new Student(98,26,"ariel"),
                new Student(56,31,"igal"),
                new Student(75,24,"nana")
            });

            Console.WriteLine("---------All----------");
            myStudent.ForEach(x => Console.WriteLine(x.GetInfo()));

            Console.WriteLine("--------Age-----------");
            myStudent.Sort((x, y) => x.Age.CompareTo(y.Age));
            myStudent.ForEach(x => Console.WriteLine(x.GetInfo()));

            Console.WriteLine("---------Greade----------");
            myStudent.Sort((x, y) => x.Greade.CompareTo(y.Greade));
            myStudent.ForEach(x => Console.WriteLine(x.GetInfo()));

            Console.WriteLine("----------Name---------");
            myStudent.Sort((x, y) => x.Name.CompareTo(y.Name));
            myStudent.ForEach(x => Console.WriteLine(x.GetInfo()));

            Console.WriteLine("----------Name---------");
            myStudent.Sort((x, y) => x.Name.CompareTo(y.Name));
            myStudent.ForEach(x => Console.WriteLine(x.GetInfo()));
            


        }
    }
}
