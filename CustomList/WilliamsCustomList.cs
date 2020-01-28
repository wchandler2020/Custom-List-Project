using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    
    public class WilliamsCustomList<T> : IEnumerable
    {
        T[] items = new T[4];
        public int count = 0;
        public int capacity = 4;
        

        //indexer
        public T this[int i]
        {
            get { return items[i]; }
            set { items[i] = value; }
        }

        //public T getItemAtIndex(int i)
        //{
        //    return items[i];
        //}

        public void Add(T item) 
        {
            items[count] = item;
            count++;

            if(count == capacity)
            {
               //update capacity
                capacity += 4;
                //I will need a new, bigger and better array
                T[] newItemList = new T[capacity + 4];
                //need to copy existing items to the new array
                for(int i = 0; i < items.Length; i++)
                {
                    newItemList[i] = items[i];
                }
                items = newItemList;
                
            }
        }

        public void Remove(T item)
        {
            T[] newItemList = new T[capacity];
            bool isFound = false;
            for (int i = 0; i < count; i++)
            {
                if (item.Equals(items[i]))
                {
                    isFound = true;
                    count--;
                }

                if (isFound == true)
                {
                    
                    newItemList[i] = items[i + 1];
                }
                else
                {
                    newItemList[i] = items[i];
                }
            }
            items = newItemList;
        }

        public void Zip()
        {
            WilliamsCustomList<int> newListItems = new WilliamsCustomList<int>() { 10, 30, 50};
            WilliamsCustomList<int> newListItems2 = new WilliamsCustomList<int>() { 20, 40, 60 };
            WilliamsCustomList<int> newListItems3 = new WilliamsCustomList<int>();
            for (int i = 0; i < newListItems.count; i++)
            {
                newListItems3.Add(newListItems[i]);
                newListItems3.Add(newListItems2[i]);
                Console.WriteLine(newListItems3[i]);
            }
            Console.ReadLine();
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
