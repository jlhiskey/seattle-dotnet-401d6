using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    // Vinicio - MyContainer will behave like an "array" that grows if it has
    // to many items
    class MyContainer<T> : IEnumerable<T>
    {
        T[] internalItems = new T[5];
        int currentIndex = 0;

        public void Add(T item)
        {
            if (currentIndex > internalItems.Length -1)
            {
                // Vinicio - think about this as a double pointer
                Array.Resize(ref internalItems, internalItems.Length * 2);
            }
            // Vinicio - adds the item into the array! :)
            internalItems[currentIndex] = item;
            currentIndex++;
        }

        public IEnumerator<T> GetEnumerator()
        {
            // Vinicio - this is a basic implementation of yield
            //yield return internalItems[0];
            //yield return internalItems[2];

            for(int i = 0; i < currentIndex; i++)
            {
                yield return internalItems[i];
            }
        }

        // Vinicio - mainly required for C# 1
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
