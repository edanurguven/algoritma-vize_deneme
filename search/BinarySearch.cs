namespace search
{
    public class BinarySearch
    {
        public static int Search<T>(T[] array,T key) where T :IComparable<T>
        {
            return searchh(array, 0, array.Length - 1, key);
        }

        private static int searchh<T>(T[] array,int i,int j,T key) where T :IComparable<T>
        {
            while (true)
            {

                if (i == j)
                {
                    if (array[i].Equals(key))
                    {
                        return i;
                    }
                    return -1;
                }

                int middle = (i + j) / 2;

                if (array[middle].Equals(key))
                {
                    return middle;
                }
                if (array[middle].CompareTo(key) >= 1)   //byukte 1,eşitte 0,küçükte -1 döner
                {
                    j = middle;
                    continue;
                }
                i = middle + 1;
            }

        }
    }
}