using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Queue<string>> myDict = new Dictionary<string, Queue<string>>();
            myDict.Add("ServiceBank", new Queue<string>());
            myDict.Add("ChangeServiceMaony", new Queue<string>());
            myDict.Add("IsraelServicePost", new Queue<string>());
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter9j your name");
                string name = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Please choose :");
                Console.WriteLine("1. ServiceBank:");
                Console.WriteLine("2. ChangeServiceMaony:");
                Console.WriteLine("3. IsraelServicePost:");
                string num = Console.ReadLine();
                Console.Clear();
                switch (num)
                {
                    case "1":
                        myDict["ServiceBank"].Enqueue(name);
                        break;
                    case "2":
                        myDict["ChangeServiceMaony"].Enqueue(name);
                        break;
                    case "3":
                        myDict["IsraelServicePost"].Enqueue(name);
                        break;
                    default:
                        Console.WriteLine("Sorry, the number is not exits");
                        i--;
                        continue;
                }
            }
            foreach (KeyValuePair<string, Queue<string>> item in myDict)
            {
                Console.Write(item.Key+ " ");
                foreach (string x in item.Value)
                {
                    Console.Write(x +" ");
                    item.Value.Dequeue();

                }
                Console.WriteLine();
            }
            Console.WriteLine();

        }
    }
}
