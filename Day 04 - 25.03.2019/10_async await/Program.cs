using System;
using System.Threading.Tasks;
namespace _09_async_await
{
    class Program
    {
        private static Task<int> f1()
        {
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());
            Task<int> res = f2(num);
            res.Start();
            return res;
        }

        public static Task<int> f2(object num)
        {
            return new Task<int>(()=>(int)num*2);
        }

        public static void Main()
        {
            Task<Task<int>> t = new Task<Task<int>>(f1);
            t.Start();
            Console.WriteLine(t.Result.Result);    
        }
       
    }

}

