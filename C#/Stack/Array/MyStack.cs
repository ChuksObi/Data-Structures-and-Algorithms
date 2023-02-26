using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Stack.Array
{
    public class MyStack<T> : IMyStack<T>
    {
        T[] Data;
        int Length;
        public MyStack(int size)
        {
            Data = new T[size];
        }
        public T Peek()
        {  
            return Data[this.Length-1];
        }

        public T Pop()
        {
            var arrayValue = Data[this.Length - 1];            
            PopArray(this.Length - 1);
            Length--;
            return arrayValue;
        }

        public T Push(T item)
        {
            Data[Length] = item;  
            Length++;
            return Data[Length];
        }
        private void PopArray(int index)
        {
            var tempData = new T[] { };

            for (int i = 0; i < Length - 1; i++)
            {
                if (i == index)
                    continue;
                tempData[i] = Data[i];
            }
            Length--;
            Data = tempData;
        }
    }
}
