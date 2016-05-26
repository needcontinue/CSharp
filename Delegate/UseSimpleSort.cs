using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    class UseSimpleSort
    {
        public static void Main(string[] args)
        {
            double[] intArray = new double[10] { 23, 34, 56, 12, 2, 3, 67, 82, 12, 8 };
            SimpleSort simpleSort = new SimpleSort();
            
            Console.WriteLine("Sorted by Ascending:");
            simpleSort.BubbleSort(intArray, SortType.Ascending);
            foreach (double item in intArray)
                Console.Write("{0}, ", item);
            Console.WriteLine();

            Console.WriteLine("Sorted by Descending:");
            simpleSort.BubbleSort(intArray, SortType.Descending);
            foreach (double item in intArray)
                Console.Write("{0}, ", item);
            Console.WriteLine();

        }
    }
}
