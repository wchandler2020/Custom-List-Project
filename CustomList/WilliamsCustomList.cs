﻿using System;
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

        public static WilliamsCustomList<T> Zip(WilliamsCustomList<T> odd, WilliamsCustomList<T> even)
        {
            WilliamsCustomList<T> myList = new WilliamsCustomList<T>();
            for (int i = 0; i < odd.count; i++)
            {
                myList.Add(odd[i]);
                myList.Add(even[i]);
            }
            return myList;
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return items[i];
            }
            yield return "Done";
        }

        public static WilliamsCustomList<T> AddMethod(WilliamsCustomList<T> odd, WilliamsCustomList<T> even)
        {
            WilliamsCustomList<T> newList = new WilliamsCustomList<T>();
                for (int i = 0; i < even.count; i++)
                {
                    newList.Add(even[i]);
                }
                for (int i = 0; i < odd.count; i++)
                {
                    newList.Add(odd[i]);
                }
            return newList;
        }

        public static WilliamsCustomList<T> MinusMethod(WilliamsCustomList<T> odd, WilliamsCustomList<T> even)
        {
            WilliamsCustomList<T> newList = new WilliamsCustomList<T>();
            for (int i = 0; i < even.count; i++)
            {
                newList.Remove(even[i]);
            }
            for (int i = 0; i < odd.count; i++)
            {
                newList.Remove(odd[i]);
            }
            return newList;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < count; i++)
            {
                sb.Append(items[i]);
            }
            return sb.ToString();
        }
    }
}
