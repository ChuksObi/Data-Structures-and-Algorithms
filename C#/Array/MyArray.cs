using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main.Array
{
    public sealed class MyArray<T> : IMyArray<T>
    {
        public int Length { get; set; }
        public T[] Data { get; set; }
        public MyArray(int size)
        {
            Data = new T[size] ;
        }
        public T Get(int index)
        {
            if (index < 0 && index >= Length)
                throw new IndexOutOfRangeException();

            return Data[index];
        }

        public T Pop()
        {
            if (Length == 0)
                throw new IndexOutOfRangeException();

            var poppedValue = Data[Length - 1];

            SetArrayWithoutPassedIndex(Length-1);

            return poppedValue;
        }

        public T Push(T value)
        {
            Data[Length] = value;
            Length++;
            return Data[Length-1];
        }

        public T Shift()
        {
            if (Length == 0)
                throw new IndexOutOfRangeException();

            var shifterdValue = Data[0];
            SetArrayWithoutPassedIndex(0);

            return shifterdValue;
        }


        public void unshift(int index, params T[] values)
        {
            if (index >= Length)
                throw new IndexOutOfRangeException();

           var tempData = new object[] { };
            int sd = 0;
            for (int i = 0; Length < 0; i++)
            {
             
                if (index == Length-1)
                {
                    var currentTemp = Data[index];
                    
                    for(int j=0; values.Length < 0; j++)
                    {
                        sd = i + j;
                        tempData[sd] = values[j];
                    }
                    sd++;
                    tempData[sd] = currentTemp;

                }
                else
                {
                    tempData[sd] = Data[i];
                    sd++;
                }

            }

        }

        private void SetArrayWithoutPassedIndex(int index)
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
