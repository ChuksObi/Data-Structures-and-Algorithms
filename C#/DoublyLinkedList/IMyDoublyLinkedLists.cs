using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.DoublyLinkedList
{
    interface IMyDoublyLinkedLists<T>
    {
        Node<T> Append(T Value);
        Node<T> Prepend(T Value);
        Node<T> Insert(int index, T value);
        T Delete(int index);
    }

}
