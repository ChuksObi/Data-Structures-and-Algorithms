using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Queue.LinkedList
{
    public class Node<T>
    {
        public T Value { get; set; }
        public Node<T> next { get; set; }

        public Node(T value)
        {
            Value = value;
        }
    }
    public class MyQueue<T> : IMyQueue<T>
    {


        Node<T> First { get; set; }
        Node<T> Last { get; set; }
        int Length = 0;

        public Node<T> Dequeue()
        {
            if (First == null)
                return null;

            if (First == Last)
                this.Last = null;

            var removedNode = this.First;
            this.First = this.First.next;
            this.Length--;
            return removedNode;
        }

        public Node<T> Enqueue(T item)
        {
            var newNode = new Node<T>(item);
            if(Length == 0)
            {
                this.First = newNode;
                this.Last = newNode;
            }
            else
            {
                this.Last.next = newNode;
                this.Last = newNode;
            }
         
            this.Length++;
            return newNode;
        }

        public Node<T> Peek()
        {
            return First;
        }
    }
}
