
using Algoritma_connection;

var array=new Book[] {};
using (var context=new DbConext())
{
    var list = context.Books;
    var list2=new List<Book>();
    array = list.ToArray();
    foreach (var item in list)
    {
        //Console.WriteLine(item.Price);
    }
    //snuc cıktı
    SortingAlgortihm.BubbleSort.bubbleSort(array);
    foreach (var item in array)
    {
        Console.WriteLine(item.Price +"    "+item.Title);
    }
}


Console.ReadLine();

