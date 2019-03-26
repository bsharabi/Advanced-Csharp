using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threads_Example
{
    class Program
    {
        static void Print1(Object limit)
        {
            Console.WriteLine("\nThe Print1 (" + Thread.CurrentThread.ManagedThreadId + ")");
            for(int i=0;i<(int)limit;i++)
            {
                Console.WriteLine($"For loop in {i}");
                Thread.Sleep(2000);

            }
        }
        static void Print2()
        {
            Console.WriteLine("\nThe Print2 (" + Thread.CurrentThread.ManagedThreadId + ")");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"For loop in {i}");
            }
        }
        static void Test()
        {
            Console.WriteLine("Line1 (" + Thread.CurrentThread.ManagedThreadId + ")");// --> 1
            Thread.Sleep(5000);
            Console.WriteLine("Line2 (" + Thread.CurrentThread.ManagedThreadId + ")");// --> 1

            //Console.WriteLine("Line1 (" + Thread.CurrentThread.Name + ")");// --> 
            //Thread.Sleep(1000);
            //Console.WriteLine("Line2 (" + Thread.CurrentThread.Name + ")");// --> 
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Main Start:(" + Thread.CurrentThread.ManagedThreadId + ")");
            //Test();//--> syncronic
            Thread t = new Thread(Test);// --> asyncronic
            Thread t1 = new Thread(Print1);// --> asyncronic
            t.Start();//--> start Thread
            t1.Start(3);
            Console.WriteLine("Main End:(" + Thread.CurrentThread.ManagedThreadId + ")");
            //t.Join();//-->משאיר את התהליך פתוח בנקודת זמן זו עד שמסיים וממשיך לרוץ
            Console.WriteLine("Main End:(" + Thread.CurrentThread.ManagedThreadId + ")");
            t.IsBackground = true;//-->פקודה מחליטה האם הטרייד ימשיך לרוץ גם אם טרייד הראשי סיים 


        }
    }
}
