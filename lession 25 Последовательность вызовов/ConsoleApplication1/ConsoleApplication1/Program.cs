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
            foreach (var element0 in GetSequence())
                Console.WriteLine("f");

            Console.WriteLine("////////////////////////////");

            foreach (var element1 in GetSequence().ToList())
                Console.WriteLine("f");

            Console.WriteLine("////////////////////////////");

            var element2 = GetSequence().FirstOrDefault();
            Console.WriteLine("f");

            Console.WriteLine("////////////////////////////");

            foreach (var element3 in GetSequence().ToList().Take(1))
                Console.WriteLine("f");


        }
       static IEnumerable<int> GetSequence()
        {
            for (var i = 0; i < 2; ++i)
            {
                Console.WriteLine("s");
                yield return i;
            }
        }
    }
}
