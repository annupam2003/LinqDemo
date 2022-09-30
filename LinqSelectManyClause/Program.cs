using System.Collections;

namespace LinqSelectManyClause;
public class Program
{
    public static void Main()
    {
        List<Student> student = new List<Student>()
        {
            new Student{name="kumar11",marks = new int[]{101,201,301}},
            new Student{name="kumar22",marks = new int[]{102,202,302}},
            new Student{name="kumar33",marks = new int[]{103,203,303}},
            new Student{name="kumar44",marks = new int[]{104,204,304}},
            new Student{name="kumar55",marks = new int[]{105,205,305}}
        };


        /*
            public static IEnumerable<TResult> SelectMany<TSource, TResult>(
                this IEnumerable<TSource> source,
                Func<TSource, Int32, IEnumerable<TResult>> selector);
         */
        var result = student.SelectMany((x, xIndex) => x.marks.Select((y, yIndex) => ("Y:"+yIndex.ToString() + " X:" + xIndex.ToString() + " Value:" + y.ToString())));
        foreach (var show in result)
        {
            Console.WriteLine(show);
        }

        /*
            public static IEnumerable<TResult> SelectMany<TSource, TCollection, TResult>(
                this IEnumerable<TSource> source,
                Func<TSource, Int32, IEnumerable<TCollection>> collectionSelector,
                Func<TSource, TCollection, TResult> resultSelector);
         */

        var result2 = student.SelectMany((x, xIndex) => x.marks.Select(z => new { xIndex, z }), (x, y) => new { y.xIndex, y.z });
        foreach (var show in result2)
        {
            Console.WriteLine(show);
        }

        var result3 = student.SelectMany((x, xIndex) => x.marks.Select((z, zIndex) => new { xIndex, zIndex, z }), (x, y) => new { y.xIndex,y.zIndex, y.z });
        foreach (var show in result3)
        {
            Console.WriteLine(show);
        }
    }
}

public class Student
{
    public string name { get; set; }
    public int[] marks { get; set; }
}