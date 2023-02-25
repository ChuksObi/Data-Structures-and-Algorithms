using System;
using System.Collections.Generic;
namespace CSharp.LinkedList
{
    public class Node<T>
    {
        public T value { get; set; }
        public Node<T> next { get; set; }
        public Node() { }

        public Node(T value, Node<T> next)
        {
            this.value = value;
            this.next = next;
        }
    }

    public class MyLinkedList<T> : IMyLinkedList<T>
    {
        public Node<T> head;
        public Node<T> tail;
        public int Length;
        public MyLinkedList() { }
        public MyLinkedList(T value)
        {
            head = new Node<T>() { value = value };
            tail = head;
            Length = 1;
        }

        public Node<T> Append(T value)
        {
            Node<T> node = new Node<T>() { value = value };
            tail.next = node;
            tail = node;
            Length++;
            return node;
        }

        public Node<T> Prepend(T value)
        {
            Node<T> newNode = new Node<T>() { value = value };
            newNode.next = head;
            head = newNode;
            Length++;
            return newNode;
        }

        public Node<T> Insert(int index, T value)
        {
            if (index >= Length)
            {
                return Append(value);
            }
            Node<T> newNode = new() { value = value };
            Node<T> leader = TraverseToindex(index - 1);
            Node<T> holdingPointer = leader.next;
            leader.next = newNode;
            newNode.next = holdingPointer;

            return newNode;
        }

        public T Delete(int index)
        {

            Node<T> leader = TraverseToindex(index - 1);
            Node<T> nodeNotWanted = leader.next;
            leader.next = nodeNotWanted.next;
            Length--;
            return nodeNotWanted.value;
        }

        public Node<T> TraverseToindex(int index)
        {
            //TODO: Defensive test
            int counter = 0;
            Node<T> currentNode = this.head;
            while (counter != index)
            {
                currentNode = currentNode.next;
                counter++;
            }
            return currentNode;
        }

 

        //public string printAllValues()
        //{
        //    string output = string.Empty;
        //    Node<T> currentNode = this.head;
        //    while (currentNode.next != null)
        //    {
        //        currentNode = currentNode.next;

        //    }
        //    return output;
        //}

    }
}

