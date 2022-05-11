using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgortihm
{
    public class QuickSort
    {
        /*
        static int partition<T>(T[] array,int low,int high) where T:IComparable<T>
        {
            
            T pivot = array[high];
            int i = low - 1;
            for (int j = 0; j < high; j++)
            {
                if (array[j].CompareTo(pivot)!=1)
                {
                    i++;
                    T temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
            T temp = array[i + 1];
            array[i + 1] = array[high];
            array[high] = temp;
            return i + 1;
            
        }*/

        /*
        static void QuickSort<T>(T[] array,int low,int high)
        {
            if (low<high)
            {
                int pi = partition(array, low, high);
                QuickSort(array,low, pi-1);
                QuickSort(array,pi+1, high);
            }
        }
        */
    }
}
