using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgortihm
{
    public class InsertionSort
    {
        static void insertionSort<T>(T[] array) where T : IComparable<T>
        {
            int n=array.Length;
            for (int i = 0; i < n; i++)
            {
                T deger = array[i];
                int j = i - 1;

                while (j >= 0 && array[j].CompareTo(deger) >= 1)
                {
                    array[j+1]=array[j];
                    j = j - 1;
                }
                array[j+1] = deger;
            }
        }
    }
}
