using BasicStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kosaraju.MyStructs
{
    public class SingleArray<T> : IArray<T>
    {
        T[] array;
        public SingleArray()
        {
            array = new T[0];
        }
        public int Size { get { return array.Length; } }

        public T[] Array { get { return array; } }
        public void Add(T item, int index)
        {
            int length = index + 1;
            T[] tempArray = new T[length];
            tempArray[index] = item;

            for (long i = 0; i < array.Length; i++)
            {
                tempArray[i] = array[i];
            }
            array = tempArray;
        }
        public T Get(int idx)
        {
            return array[idx];
        }
        public T Remove(int index)
        {
            T[] tempArray = new T[array.Length - 1];

            long count = 0;
            while (count < index)
            {
                tempArray[count] = array[count];
                count++;
            }
            while (count++ < tempArray.Length)
            {
                tempArray[count - 1] = array[count];
            }

            T outVal = array[index];
            array = tempArray;
            return outVal;
        }

        public void Insert(T item, int index)
        {
            if (index >= array.Length)
                Add(item, index);

            T[] newArray = new T[array.Length + 1];

            int count = 0;
            while (count < index)
            {
                newArray[count] = array[count];
                count++;
            }
            newArray[count] = item;

            while (++count < newArray.Length)
            {
                newArray[count] = array[count - 1];
            }

            array = newArray;
        }
    }
}
