using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicStructures
{
    public class Node<T>
    {
        public Node(T data, int priority = 0)
        {
            this.Data = data;
            this.Priority = priority;
        }
        public T Data { get; set; }
        public Node<T> Next { get; set; }
        public Node<T> Prep { get; set; }
        public int Priority { get; set; }
    }
}