using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    
    public class WilliamsCustomList<T>
    {
        T[] items = new T [4];
        public int count = 0;
        public int capacity = 4;

        public void Add(T item)
        {
            items[count] = item;
            count++;

            if(count == capacity)
            {
                //we need a new, bigger array
                T[] newItemList = new T[capacity + 4];
                //need to copy existing items to the new array
                for(int i = 0; i < items.Length; i++)
                {
                    newItemList[i] = items[i];
                }
                items = newItemList;
                //update capacity
                capacity += 4;
            }
        }

        public T getItemAtIndex(int index)
        {
            return items[index];
        }

        
    }
}
