using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        { var result = new Func<int, Func<int, int>>(x => y => y + x + 3)(2)(3);
            Func<int, string> toString = x => x.ToString("X"); // hex
            Func<double, int> round = x => (int) Math.Round(x);
            var f1 = Combine(round, toString);
            Console.WriteLine(f1(3.14)); // 3
            Console.WriteLine(f1(10.9)); // B 

            Func<int, int> doubleValue = x => 2*x;
            Func<int, int> minusOne = x => x - 1;
            var f2 = Combine(minusOne, doubleValue);
            Console.WriteLine(f2(2)); // 2
            Console.WriteLine(f2(5)); // 8
           
        }
        Func<double, double, double> h = (a, b) =>
        {
            b = a % b;
            return b % a;
        };
        static Func<T1, T3> Combine<T1, T2, T3>(Func<T1, T2> f, Func<T2, T3> g)
        {


            return a => g(f(a)); //вот вообще хз почему и как
        }

    }
}
