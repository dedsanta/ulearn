using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication1
{
    public class Program
    {
        static void Main(string[] args)
        {
         
            FirstOrDefault(new[] { 1, 2, 3 }, x => x > 2);
            Console.WriteLine("OK");
        }

        public static T FirstOrDefault<T>(IEnumerable<T> source, Func<T, bool> filter)
        {
            
            return default(T);
        }
        //public static IEnumerable<T> Where<T>(this IEnumerable<T> enumerable, Func<T, bool> predicate)
        //{
        //    foreach (var e in enumerable)
        //        if (predicate(e))
        //            yield return e;
        //}
        //public static IEnumerable<T> Where<T>(this IEnumerable<T> enumerable, Func<T, bool> predicate)
        //{
        //    foreach (var e in enumerable)
        //        if (predicate(e))
        //            yield return e;
        //}

        //public static IEnumerable<TOut> Select<TIn, TOut>(this IEnumerable<TIn> enumerable, Func<TIn, TOut> selector)
        //{
        //    foreach (var e in enumerable)
        //        yield return selector(e);
        //}

        //public static List<T> ToList<T>(this IEnumerable<T> enumerable)
        //{
        //    var list = new List<T>();
        //    foreach (var e in enumerable)
        //        list.Add(e);
        //    return list;
        //}
    }
}
