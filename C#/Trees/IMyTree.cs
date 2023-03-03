using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Trees
{
    interface IMyTree<T>
    {
        Node<T> Insert(int value);
        Node<T> Lookup(int value);
        //TODO: Implement Remove
        //Node<T> Remove(int value);
    }
}
