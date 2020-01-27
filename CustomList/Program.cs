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
            myList.Add(6);
            myList.Add(12);
            myList.Add(18);
            myList.Add(24);
            myList.Add(30);

            for (int i = 0; i < myList.count; i++)
            {
                Console.WriteLine($"test: {myList[i]}");
            }
            Console.ReadLine();
        }
    }
}
