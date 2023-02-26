using System;
using System.Collections.Generic;
namespace CSharp.DoublyLinkedList
{
    public class Node<T>
    {
        public T Value { get; set; }
        public Node<T> Next { get; set; }
        public Node<T> Prev { get; set; }
        public Node() { }

        public Node(T value, Node<T> next, Node<T> prev)
        {
            this.Value = value;
            this.Next = next;
            this.Prev = prev;
        }
    }

    public class DoublyLinkedList<T> : IMyDoublyLinkedLists<T>
    {
        public Node<T> head;
        public Node<T> tail;
        public Node<T> prev;
        public int Length;
        public DoublyLinkedList() { }
        public DoublyLinkedList(T Value)
        {
            head = new Node<T>() { Value = Value };
            tail = head;
            Length = 1;
        }

        public Node<T> Append(T Value)
        {
            Node<T> node = new() { Value = Value };
            node.Prev = tail;
            tail.Next = node;
            tail = node;
            Length++;
            return node;
        }

        public Node<T> Prepend(T Value)
        {
            Node<T> newNode = new() { Value = Value };
            newNode.Next = head;
            head.Prev = newNode;
            head = newNode;
            Length++;
            return newNode;
        }

        public Node<T> Insert(int index, T value)
        {
            if (index >= Length)
            {
                return this.Append(value);
            }
            Node<T> newNode = new() { Value = value };
            Node<T> leader = TraverseToindex(index - 1);
            Node<T> follower = leader.Next;
            leader.Next = newNode;
            newNode.Prev = leader;
            newNode.Next = follower;
            follower.Prev = newNode;
            Length++;
            return newNode;

        }

        public T Delete(int index)
        {

            Node<T> leader = TraverseToindex(index - 1);
            Node<T> nodeNotWanted = leader.Next;
            leader.Next = nodeNotWanted.Next;
            Length--;
            return nodeNotWanted.Value;
        }

        public Node<T> TraverseToindex(int index)
        {
            //TODO: Defensive test
            int counter = 0;
            Node<T> currentNode = this.head;
            while (counter != index)
            {
                currentNode = currentNode.Next;
                counter++;
            }
            return currentNode;
        }

        //public string PrintAllValues()
        //{
        //    string output = string.Empty;
        //    Node<T> currentNode = this.head;
        //    while (currentNode.Next != null)
        //    {
        //        Console.WriteLine(currentNode.Value);
        //        currentNode = currentNode.Next;

        //    }
        //    return output;
        //}

    }
}

