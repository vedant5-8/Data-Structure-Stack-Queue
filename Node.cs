﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure___Stack_and_Queue
{
    internal class Node<T> where T : IComparable<T>
    {
        public T Data;
        public Node<T> Next;
        public Node(T data)
        {
            this.Data = data;
            Next = null;
        }
    }
}
