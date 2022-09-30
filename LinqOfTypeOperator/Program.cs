using System.Collections;

namespace LinqOfTypeOperator;
public class Program
{

    static ArrayList developers = new ArrayList();
    public static void Main()
    {
        developers.Add(1);
        developers.Add(2);
        developers.Add(3);
        developers.Add("One");
        developers.Add("Two");
        developers.Add("Three");
        developers.Add(new Developer { Name = "Paolo", Language = "C#" });
        developers.Add(new Developer { Name = "Marco", Language = "C#" });
        developers.Add(new Developer { Name = "Frank", Language = "VB.NET" });
        developers.Add(new Tester { Name = "Kumar", Project = "LMS" });
        developers.Add(new Tester { Name = "Singh", Project = "SSC" });
        developers.Add(new Tester { Name = "Baba", Project = "LMS" });

        Console.WriteLine("--Developer--");
        var developersUsingCSharp = from d in developers.OfType<Developer>() where d.Language == "C#" select d;
        foreach (var item in developersUsingCSharp)
            Console.WriteLine(item.Name);

        Console.WriteLine("--Tester--");
        var testerUsingCSharp = from d in developers.OfType<Tester>() where d.Project == "LMS" select d;
        foreach (var item in testerUsingCSharp)
            Console.WriteLine(item.Name);

        Console.WriteLine("--Int--");
        var intUsingCSharp = from d in developers.OfType<int>() select d;
        foreach (var item in intUsingCSharp)
            Console.WriteLine(item);

        Console.WriteLine("--String--");
        var StringUsingCSharp = from d in developers.OfType<string>() select d;
        foreach (var item in StringUsingCSharp)
            Console.WriteLine(item);

    }
}

public class Developer
{
    public string Name { get; set; } = string.Empty;
    public string Language { get; set; } = string.Empty;
}

public class Tester
{
    public string Name { get; set; } = string.Empty;
    public string Project { get; set; } = string.Empty;
}
