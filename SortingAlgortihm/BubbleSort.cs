namespace SortingAlgortihm
{
    public class BubbleSort
    {
        public static void bubbleSort<T>(T[] array) where T : IComparable<T>
        {
            int n=array.Length;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n-1-i; j++)
                {
                    if(array[j].CompareTo(array[j + 1])>=1)  //array[j]>array[j+1]
                    {
                        var temp=array[j];
                        array[j]=array[j+1];
                        array[j+1]=temp;
                    }
                }
            }
        }

        public static void Swap<T>(T[] array,int first,int second)
        {
            var temp = array[first];
            array[first]=array[second];
            array[second] = temp;
        }
    }

    
}