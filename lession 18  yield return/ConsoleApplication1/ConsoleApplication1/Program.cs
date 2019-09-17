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
            Console.WriteLine(string.Join(" ", ZipSum(new[] { 1 }, new[] { 0 })));
            Console.WriteLine(string.Join(" ", ZipSum(new[] { 1, 2 }, new[] { 1, 2 })));
            Console.WriteLine(string.Join(" ", ZipSum(new int[0], new int[0])));
            Console.WriteLine(string.Join(" ", ZipSum(new[] { 1, 3, 5 }, new[] { 5, 3, -1 })));
        }

       public static IEnumerable<int> ZipSum(IEnumerable<int> first, IEnumerable<int> second)
        {
            var e1 = first.GetEnumerator();
            var e2 = second.GetEnumerator();
            var count = 0;
            while (first.Count() > count)
            {
                count++;
                e1.MoveNext();
                e2.MoveNext();
                yield return (e1.Current + e2.Current);
            }
            //var e1 = first.GetEnumerator();
            //var e2 = second.GetEnumerator();
            //while (e1.MoveNext() && e2.MoveNext())
            //{
            //    yield return e1.Current + e2.Current;
            //}
        }
    }
}
