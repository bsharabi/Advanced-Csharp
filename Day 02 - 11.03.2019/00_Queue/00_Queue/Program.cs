using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            // FIFO = first in first out
            Queue<string> superQueue = new Queue<string>();

            // add a new element to the end of the queue
            superQueue.Enqueue("Bob");
            superQueue.Enqueue("Alice");
            superQueue.Enqueue("Shadi");

            Console.WriteLine(superQueue.Count);  //--> 3

            // Removes and returns the object at the beginning of queue
            string nextInQueue = superQueue.Dequeue();

            Console.WriteLine(nextInQueue + " " + superQueue.Count);  //--> Bob 2


            // Returns the object at the beginning queue without removing it.
            string peekNextInQueue = superQueue.Peek();

            Console.WriteLine(peekNextInQueue + " " +superQueue.Count);  //--> Alice 2

        }
    }
}
