using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure___Stack_and_Queue
{
    internal class Queue<T> where T : IComparable<T>
    {

        // UC3 - Create a queue
        Node<T> front;
        Node<T> rear;

        public void Enqueue(T data)
        {
            Node<T> newNode = new Node<T>(data);
            if (front == null)
            {
                rear = newNode; 
                front = rear;
            }
            else
            {
                rear.Next = newNode;
                rear = rear.Next;
            }
        }

        // UC4 - delete an element
        public void Dequeue()
        {
            if (front == null)
            {
                Console.WriteLine("Queue is empty.");
            }
            else
            {
                front = front.Next;
            }
        }
        public void Display()
        {
            if (front == null)
            {
                Console.WriteLine("Queue is empty.");
            }
            else
            {
                Node<T> temp = front;
                while (temp != null)
                {
                    Console.WriteLine("| " + temp.Data + " |");
                    temp = temp.Next;
                }
            }
        }
    }
}
