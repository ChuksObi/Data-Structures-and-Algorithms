using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main.Array
{
    interface IMyArray<T>
    {
        T Get(int index);
        T Push(T obj);
        T Pop();
        T Shift();
        void unshift(int index, params T[] values);
    }
}
