var array = new int[] { 10, 20, 30, 40, 50, 60, 70 };
//int index = search.BinarySearch.Search<int>(array, 50);
int index = search.RecursiveBinarySearch.Search<int>(array, 0, array.Length - 1, 70);
if(index != -1)
{
    Console.WriteLine(index);
}
else
{
    Console.WriteLine("bulunamadı");
}
