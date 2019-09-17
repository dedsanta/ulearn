using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //string str = "hello";
            //string input = Console.ReadLine();
            //double number = double.Parse(input, CultureInfo.InvariantCulture);
            //str = number.ToString();
            //Console.WriteLine(number+1);

            int a = 2;
            int b = 3;
            int c = b % a;
            double d = (double)b/a;
            double d1 = 1.0/2;
            double angle = 3.14159;

            Console.WriteLine(Math.Pow(2,3));
            var q = a*b;
            var w = q.ToString();
            Console.WriteLine(q);

            a = b = q; // a = (b = q)
            a += 2;
            b *= 3;
            Console.WriteLine(a + " "+b+ " "+q);

            var e = 2;
            Console.WriteLine(++e);
            Console.WriteLine(e);
            e = 2;
                Console.WriteLine(e++);
            Console.WriteLine(e);
            Console.WriteLine(e++ + ++e);
        }
    }
}
