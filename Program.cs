﻿using System;

namespace Data_Structure___Stack_and_Queue
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            // Stack Data Structure
            
            Stack<int> stack = new Stack<int>();

            stack.Push(70);
            stack.Push(30);
            stack.Push(56);

            stack.Display();

            Console.WriteLine("");
            stack.Pop();

            stack.Display();

            Console.WriteLine("");

            stack.Peek();

            // execute pop and peek operation untill stack is empty

            
            Console.WriteLine("");
            stack.Pop();

            stack.Display();

            Console.WriteLine("");

            stack.Peek();

            Console.WriteLine("");
            stack.Pop();

            stack.Display();

            Console.WriteLine("");

            stack.Peek();
            

            // Queue Data Structure

            Queue<int> queue = new Queue<int>();

            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(56);

            Console.WriteLine("");
            queue.Display();

            Console.WriteLine("");

            queue.Dequeue();

            queue.Display();

        }
    }
}
