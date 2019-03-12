using System;
using System.Collections.Generic;

namespace _01_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            // LIFO = last in first out
            Stack<string> shirtsStack = new Stack<string>();

            // add a new element to the end of the stack
            shirtsStack.Push("shirt1");
            shirtsStack.Push("shirt2");
            shirtsStack.Push("shirt3");

            Console.WriteLine(shirtsStack.Count);  //--> 3

            // Removes and returns the object at the top of the stack
            string topOfStack = shirtsStack.Pop();

            Console.WriteLine(topOfStack + " " + shirtsStack.Count);  //--> shirt3 2


            // Returns the object at the top of the stack without removing it.
            string peekNext = shirtsStack.Peek();

            Console.WriteLine(peekNext + " " + shirtsStack.Count);  //--> shirt2 2

        }
    }
}
