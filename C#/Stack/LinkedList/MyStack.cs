using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Stack.LinkedList
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
    public class MyStack<T> : IMyStack<T>
    {
        Node<T> Top { get; set; }
        Node<T> Bottom { get; set; }
        int Length { get; set; }



        public Node<T> Peek()
        {
            return Top;
        }

        public Node<T> Pop()
        {
            if(Top == null)
                return null;

            var currentPointer = Top;
            Top = Top.next;
            Length--;
            return currentPointer;
        }

        public Node<T> Push(T item)
        {
            if(Length == 0)
            {
                Top = new Node<T>(item);
                Bottom = Top;
                Length++;
                return Top;
            }
            else
            {
                var newNode = new Node<T>(item);
                var holdingPointer = Top;
                Top = newNode;
                newNode.next = holdingPointer;
                Length++;
                return newNode;
            }

        }
    }
}
