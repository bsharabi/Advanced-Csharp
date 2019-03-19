using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace result
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Queue<string>> queueManager = new Dictionary<string, Queue<string>>();

            queueManager.Add("Bank",new Queue<string>());
            queueManager.Add("Change", new Queue<string>());
            queueManager.Add("Post", new Queue<string>());
            /*
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter your name");
                string name = Console.ReadLine();

                Console.WriteLine("Enter your requiered service (Bank / Change / Post)");
                string service = Console.ReadLine();

                if (queueManager.ContainsKey(service))
                    queueManager[service].Enqueue(name);
            }
            */

            queueManager["Post"].Enqueue("A");
            queueManager["Post"].Enqueue("B");
            queueManager["Post"].Enqueue("C");

            queueManager["Change"].Enqueue("D");

            queueManager["Bank"].Enqueue("E");
        

            int emtyCnt = 0;
            while (emtyCnt < queueManager.Count)
            {
                emtyCnt = 0;
                foreach (KeyValuePair<string, Queue<string>> item in queueManager)
                {
                    if (item.Value.Count > 0)
                        Console.WriteLine($"queue {item.Key} is waiting for {item.Value.Dequeue()}");
                    else
                        emtyCnt++;
                }
                Console.WriteLine("----------------------");

            }

        }
    }
}
