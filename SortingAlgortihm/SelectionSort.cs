using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgortihm
{
    public class SelectionSort
    {
        public static void selectionSort<T>(T[] array) where T : IComparable<T>
        {
            for (int i = 0; i < array.Length-1; i++)
            {
                int minIndex = i;
                T value=array[i];
                for (int j = i+1; j < array.Length; j++)
                {
                    if (array[i].CompareTo(array[j]) < 0)
                    {
                        T temp=array[j];
                        array[j]=array[j+1];
                        array[j+1]=temp;
                    }
                }
            }
        }
    }
}
