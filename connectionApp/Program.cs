using Microsoft.Data.SqlClient;
using System.Data;

var conn = new SqlConnection(@"Data Source=DESKTOP-DELL\SQLEXPRESS;Initial Catalog=nTierDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
conn.Open();
var cmd = new SqlCommand("SELECT Title,Price FROM Books",conn);
var sda=new SqlDataAdapter(cmd);
var ds = new DataSet();
sda.Fill(ds);
var dizi = new int[] { };
var list=new List<string>();
var list1=new List<int>();
foreach (DataRow dr in ds.Tables[0].Rows)
{
    for (int i = 0; i < ds.Tables[0].Rows.Count-4; i++) //kitap sayısndan bir eksiği çıktı
    {
        //dizi.SetValue(dr["Title"].ToString(), i);
        list.Add(dr["Title"].ToString());
        list1.Add(int.Parse(dr["Price"].ToString()));
    }
    Console.WriteLine(dr["Title"].ToString());
}
Console.WriteLine("+++++++++++++++++++");
foreach (var item in list)
{
    Console.WriteLine(item);
}

var array = list.ToArray();

Console.WriteLine("+++++++++++++++++++  array hali baloncuksuz ");
foreach (var item in array)
{
    Console.WriteLine(item);
}

static void selectionSort<T>(T[] array) where T : IComparable<T>
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minIndex = i;
        T value = array[i];
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[i].CompareTo(array[j]) < 0)
            {
                T temp = array[j];
                array[j] = array[j + 1];
                array[j + 1] = temp;
            }
        }
    }
}

Console.WriteLine("+++++++++++++++++++  array hali baloncuk dizilimi ");
foreach (var item in array)
{
    Console.WriteLine(item);
}

Console.ReadLine();

