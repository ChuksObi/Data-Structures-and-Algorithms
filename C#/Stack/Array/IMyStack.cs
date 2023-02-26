using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Stack.Array
{
    interface IMyStack<T>
    {
        T Peek();
        T Push(T item);
        T Pop();
    }
}
