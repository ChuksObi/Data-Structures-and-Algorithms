using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.HashTable
{
    internal interface IMyHashTable<T, G>
    {
        T[] Keys();
        Node<T, G> Get(T key);
        Node<T, G> Set(T key, G value);

    }
}
