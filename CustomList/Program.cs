using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    class Program
    {
        static void Main(string[] args)
        {
            WilliamsCustomList<int> myList = new WilliamsCustomList<int>();
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            //myList.Remove(2);

            WilliamsCustomList<int> anotherList = new WilliamsCustomList<int>();
            myList.Add(2);
            myList.Add(4);
            myList.Add(6);

            //myList.Zip(anotherList);

            int value = myList[0];

            for (int i = 0; i < myList.count; i++)
            {
                Console.WriteLine($"test: {myList[i]}");
            }
            Console.ReadLine();
        }
    }
}
