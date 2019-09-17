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

            Console.WriteLine(GetMinX(1, 2, 3));
            Console.WriteLine(GetMinX(0, 3, 2));
            Console.WriteLine(GetMinX(1, -2, -3));
            Console.WriteLine(GetMinX(5, 2, 1));
            Console.WriteLine(GetMinX(4, 3, 2));
            Console.WriteLine(GetMinX(0, 4, 5));

            // А в этих случаях решение существует:
            Console.WriteLine(GetMinX(0, 0, 2) != "Impossible");
            Console.WriteLine(GetMinX(0, 0, 0) != "Impossible");
        }

        private static string GetMinX(int a, int b, int c)
        {
            
            double x = 0.0;
            try
            {
                 x = -b/(2.0*a);
                 if (double.IsNegativeInfinity(x)) { return "Impossible"; }
            }
            catch{ return "Impossible";}
                return (x).ToString();

            int a = x%24;
            // так можно вернуть строковое представление числа
        }
    }
}
