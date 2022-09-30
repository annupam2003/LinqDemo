using System.Collections;
using System.Linq;

namespace ExtensionDemo;
public class Program
{
    public static void Main()
    {
        List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        Console.WriteLine("Linq Demo Where clause");
        var where = list.MyWhere(x => x % 2 == 0);
        foreach (var item in where)
            Console.WriteLine(item);

        Console.WriteLine("Linq Demo Select clause");
        var select = list.MySelect(x => x);
        foreach (var item in select)
            Console.WriteLine(item);
    }
}