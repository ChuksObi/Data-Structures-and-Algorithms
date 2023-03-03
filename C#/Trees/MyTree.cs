using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Trees
{
    public class Node<T> {

        public  int Value { get; set; }
        public Node<T> Left { get; set; }
        public Node<T> Right { get; set; }

        public Node(int value)
        {
            Value = value;
        }    

    }

    public class MyTree<T> : IMyTree<T>
    {
        public Node<T> Root { get; set; }
        public MyTree()
        {
            Root = default;
        }
        public Node<T> Insert(int value)
        {
            Node<T> newNode = new (value);
            if (Root == null)
            {
                Root = newNode;
                return newNode;
            }
            else
            {
                var currentNode = Root;
                while (true)
                {
                    if(value < currentNode.Value)
                    {
                        //Left
                        if(currentNode.Left != null)
                        {
                            currentNode.Left = newNode;
                            return newNode;
                        }
                        currentNode = currentNode.Left;
                    }
                    else
                    {
                        //Right
                        if (currentNode.Right != null)
                        {
                            currentNode.Right = newNode;
                            return newNode;
                        }
                        currentNode = currentNode.Right;
                        
                    }
                }
            }
        }

        public Node<T> Lookup(int value)
        {
            if(Root == null)
            {
                throw new InvalidOperationException();
            }

            var currentNode = Root;
            while (currentNode != null)
            {
                if(value < currentNode.Value)
                    currentNode = currentNode.Left;
                else if (value > currentNode.Value)
                    currentNode = currentNode.Right;
                else if(currentNode.Value == value)
                    return currentNode;
                
            }
            return null;
        }


    }
}
