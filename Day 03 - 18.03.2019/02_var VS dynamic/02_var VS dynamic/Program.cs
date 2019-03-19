using System;

namespace _02_var_VS_dynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var item in new int[] { 1, 3, 4})
            {

            }
            //---------------var--------------------
            var x0 = 4;
            x0 = 6;

            // Anonymous type
            var x1 = new { Name="Tom", Grade=100};
            Console.WriteLine(x1.Grade);
            Console.WriteLine(x1.Name);

            //Property or indexer '<anonymous type: string Name, int Grade>.Grade' cannot be assigned to --it is read only  
            //x.Grade--;

            x1 = new { Name = x1.Name.ToLower(), Grade = x1.Grade-1 };
            Console.WriteLine(x1.Grade);


            //---------------dynamic--------------------
            dynamic x2 = 7;
            x2 = "a";
            Console.WriteLine(x2.toMe());  // will throw error in runtime
        }
    }
}
