using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure___Stack_and_Queue
{
    internal class Stack<T> where T : IComparable<T>
    {
        // UC1 - create a Stack

        Node<T> top;

        public Stack()
        {
            top = null;
        }

        public void Push(T data)
        {
            Node<T> newNode = new Node<T>(data);
            newNode.Next = top;
            top = newNode;
        }

        // UC2 - Pop and Peek element from stack
        public void Pop()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is empty");
            }
            else
            {
                top = top.Next;
            }
        }

        public void Peek()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is empty");
            }
            else
            {
                Console.WriteLine("Top element of stack is " + top.Data);
            }
        }

        public void Display()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is empty.");
            }
            else
            {
                Node<T> temp = top;
                while (temp != null)
                {
                    Console.WriteLine("| " + temp.Data + " |");
                    temp = temp.Next;
                }
            }
        }
    }
}
