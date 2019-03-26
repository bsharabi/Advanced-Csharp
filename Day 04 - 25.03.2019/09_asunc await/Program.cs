using System;
using System.Threading.Tasks;
namespace _09_async_await
{
    class Program
    {

        public static int Test()
        {
            return 1000;
        }

        public static void Main()
        {

            Task<int> t = new Task<int>(Test);
            t.Start();
            Console.WriteLine($"Main: {t.Result}");
            Res();
        }


        private static async void Res()
        {
            Task<int> t = new Task<int>(Test);
            t.Start();
            Console.WriteLine($"Res: {await t}");
        }
    }


}

