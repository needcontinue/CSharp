using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public enum SortType
    {
        Ascending,
        Descending
    }
    class SimpleSort
    {

        public void BubbleSort<T>(T[] items, SortType sortOrder)
            where T: struct,IComparable
        {
            int i, n;
            T temp;
            bool sorted = false;

            n = items.Length;
            while(!sorted)
            {
                sorted = true;
                for (i=1; i<n; i++)
                {
                    switch (sortOrder)
                    {
                        case SortType.Ascending:
                            if (items[i-1].CompareTo(items[i]) > 0)
                            {
                                temp = items[i-1];
                                items[i-1] = items[i];
                                items[i] = temp;
                                sorted = false;
                            }
                            break;
                        case SortType.Descending:
                            if (items[i-1].CompareTo(items[i]) < 0)
                            {
                                temp = items[i-1];
                                items[i-1] = items[i];
                                items[i] = temp;
                                sorted = false;
                            }
                            break;
                    }
                }
                n--;
            }
        }
    }
}
