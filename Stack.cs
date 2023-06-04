using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure___Stack_and_Queue
{
    internal class Stack
    {
        // UC1 - create a Stack

        Node top;

        public Stack()
        {
            top = null;
        }

        public void Push(int data)
        {
            Node newNode = new Node(data);
            newNode.Next = top;
            top = newNode;
        }

        public void Display()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is empty.");
            }
            else
            {
                Node temp = top;
                while (temp != null)
                {
                    Console.WriteLine("| " + temp.Data + " |");
                    temp = temp.Next;
                }
            }
        }
    }
}
