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
            WilliamsCustomList<int> myList = new CustomList.WilliamsCustomList<int>();
            myList.Zip();
        }
    }
}
