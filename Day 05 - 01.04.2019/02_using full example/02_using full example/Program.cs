using System;

namespace _02_using_full_example
{

    class Test : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("test Dispose is running");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (Test t = new Test())
                {
                    Console.WriteLine("Inside using - Before error");
                    int a = 0;
                    int b = 3 / a;
                    Console.WriteLine("Inside using - After error");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine($"The error: {e.Message}");
            }

            Console.WriteLine("After using");
        }
    }
}



/*
OUTPUT:
_____________________________

Inside using - Before error
test Dispose is running
The error: Attempted to divide by zero.
After using

*/
