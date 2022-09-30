using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionDemo;

public static class ExtensionWhere
{
    public static IEnumerable<T> MyWhere<T>(this IEnumerable<T> source, Func<T, bool> predicate)
    {
        foreach (var item in source)
            if (predicate(item))
                yield return item;
    }
}

public static class ExtensionSelect
{
    public static IEnumerable<R> MySelect<T, R>(this IEnumerable<T> source, Func<T, R> projection)
    {
        foreach (var item in source)
            yield return projection(item);
    }
}
