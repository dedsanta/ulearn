using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int, int> f = (x, y, z) => x * y + z;
            var x0 = f(1, 2, 3);
            var x1 = Apply1(f, 100)(1, 11);

            var g = Apply2(Apply1(f, 10), 5);
            var x2 = g(3);
        }
        private static Func<int, int, int> Apply1(Func<int, int, int, int> func, int arg)
        {
            return (x, y) => func(x, arg, y);
        }

        private static Func<int, int> Apply2(Func<int, int, int> func, int arg)
        {
            return x => func(arg, x);
        }


    }
}
