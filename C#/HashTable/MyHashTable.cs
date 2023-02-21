using System;
using System.Collections.Generic;
namespace CSharp.HashTable
{
    public class Node<T,G>
    {
        public T Key { get; set; }
        public G Value { get; set; }
        public Node() { }

        public Node(T key, G value)
        {
            this.Key = key;
            this.Value = value;
        }
    }

    public class MyHashTable<T,G> : IMyHashTable<T,G>
    {
        private int length;
        Node<T,G>[] data;

        public MyHashTable(int size)
        {
            this.length = size;
            this.data = new Node<T,G>[size];
        }

        public int Hash(string key)
        {
            int hash = 0;
            for (int i = 0; i < key.Length; i++)
            {
                hash = (hash + (int)key[i] * i) % this.length;
                //https://stackoverflow.com/questions/3414900/how-to-get-a-char-from-an-ascii-character-code-in-c-sharp
            }
            return hash;
        }

        // public void printAllFromNode(Node[] array){ 
        //   foreach(var x in array){
        //   Console.WriteLine(x);
        //     if(x != null){
        //       Console.WriteLine(x.key + " _ "+ x.value);
        //     }
        //   }  
        // }

        public T[] Keys()
        {
            List<T> _keys = new List<T>();
            int count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] != null)
                {
                    _keys.Add(data[i].Key);
                    count++;
                }
            }
            return _keys.ToArray();
        }

        public Node<T,G> Get(T key)
        {
            if (key == null)
                throw new ArgumentNullException("key");

            int address = Hash(key.ToString());
            var currentNode = data[address];

            if (currentNode == null)
                throw new KeyNotFoundException(key.ToString());

            if (currentNode.Key.Equals(address))
                return currentNode;

            return new Node<T,G>();
        }

        public Node<T,G> Set(T key, G value)
        {
            if (key == null)
                throw new NullReferenceException();

            int address = Hash(key.ToString());
            if (data[address] != null)
            {
                data[address] = null;
            }
            data[address] = new Node<T,G>(key, value);
            // printAllFromNode(data);
            return data[address];
        }

    }
}


