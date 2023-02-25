using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.LinkedList
{
    internal interface IMyLinkedList<T>
    {
        Node<T> Append(T item);
        Node<T> Prepend(T item);
        Node<T> Insert(int index, T value);
        T Delete(int index);

    }
}
