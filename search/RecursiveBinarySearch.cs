using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace search
{
    public class RecursiveBinarySearch
    {
        public static int Search<T>(T[] array,int first,int last,T key) where T:IComparable<T>
        {
            int middle = (first + last) / 2;
            if (array[middle].Equals(key))
            {
                return middle;
            }
            else if(first>=last)//yani indexi ilerletirken lastı geçiyorsa
            {
                return -1;
            }
            else if (key.CompareTo(array[middle])==-1) //key middledan  küçükse
            {
                return Search<T>(array,first,last,key); //sola git
            }
            else
            {
                return Search<T>(array,middle+1,last,key); //sağa git
            }
        }
    }
}
