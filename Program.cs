using System;

namespace Data_Structure___Stack_and_Queue
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Stack stack = new Stack();

            stack.Push(70);
            stack.Push(30);
            stack.Push(56);

            stack.Display();
        }
    }
}
