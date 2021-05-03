using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCustom
{
    class ArrayFunction<T> 
    {
        private T[] ItemArray { get; set; }
        public ArrayFunction(T[] itemArray)
        {
            ItemArray = itemArray;
        }

        public void Insert(T itemToInsert)
        {
            int length = ItemArray.Length;

            T[] newArray = new T[length +1];

            for(int i = 0; i<length; i++)
            {
                newArray[i] = ItemArray[i];
            }

            newArray[length] = itemToInsert;

            ItemArray = newArray;
        }

        public void InsertAt(int index, T itemToInsert)
        {
            int length = ItemArray.Length;

            if (index < 0 || index >= length)
                throw new ArgumentOutOfRangeException("Invalid index provided");

            T[] newArray = new T[length + 1];

            int j = 0;
            for (int i = 0; i < length; i++)
            {
                if (i == index)
                {
                    newArray[j] = itemToInsert;
                    j++;
                }

                newArray[j] = ItemArray[i];
                j++;
            }

            ItemArray = newArray;


        }

        public void RemoveAt(int index)
        {
            int length = ItemArray.Length;

            if( index<0 ||  index > length )
                throw new ArgumentOutOfRangeException("Invalid index provided");

            T[] newArray = new T[length - 1];

            int j = 0;
            for (int i = 0; i < length; i++)
            {
                if (i == index)
                {
                    continue;
                }

                newArray[j] = ItemArray[i];
                j++;
            }

            ItemArray = newArray;
        }

    }
}
