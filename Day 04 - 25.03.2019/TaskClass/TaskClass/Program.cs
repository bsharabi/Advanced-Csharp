using System;
using System.Threading.Tasks;

namespace TaskClass
{
    class Program
    {
        static Task<int> f2(Object num)
        {
            return new Task<int>(() => (int)num * 2);
        }


        static Task<int> f1()
        {
            Console.WriteLine("Please enter your number");
            int num=Convert.ToInt32(Console.ReadLine());

            return f2(num);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Start of main");
            Task<Task<int>> t1 = new Task<Task<int>>(f1);
            t1.Start();
            t1.Result.Start();
            Console.WriteLine(t1.Result.Result);
            Console.WriteLine("End of main");
        }
    }
}
