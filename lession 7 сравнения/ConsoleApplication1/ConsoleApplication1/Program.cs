using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        public static void Main()
        {
            TestMove("a1", "d4");
            TestMove("f4", "e7");
            TestMove("a1", "a4");
            TestMove("a1", "a1");
            TestMove("a1", "b3");
            Console.WriteLine(MiddleOf(5, 0, 100)); // => 5
            Console.WriteLine(MiddleOf(12, 12, 11)); // => 12
            Console.WriteLine(MiddleOf(1, 1, 1)); // => 1
            Console.WriteLine(MiddleOf(2, 3, 2));
            Console.WriteLine(MiddleOf(8, 8, 8));
            Console.WriteLine(MiddleOf(5, 0, 1));
            Console.WriteLine(Method(true));
            //FinalTesting(); // Тестирование решения на секретных тестах
        }

        public static void TestMove(string from, string to)
        {
            Console.WriteLine("{0}-{1} {2}", from, to, IsCorrectMove(from, to));
        }
        public static bool IsCorrectMove(string from, string to)
        {//3-3-3 !1-3-2 0-3-0 !0-0-0
            var dx = Math.Abs(to[0] - from[0]); //смещение фигуры по горизонтали
            var dy = Math.Abs(to[1] - from[1]); //смещение фигуры по вертикали
            //var dz = Math.Abs(to[1] - from[0]); //смещение фигуры по 
            Console.WriteLine(dx + " " + dy + " " );
            return (dx != dy) || (dx <= dy) ||(dx != 0) ;
        }

        public static int MiddleOf(int a, int b, int c)
        {
            if (a > b)
                if (b > c) return b;
                else if (a >=c)
                    return c;
            else if (b > a)
                    if (a > c) return a;
                    else if (b > c)
                        return c;
            else if (c > b)
                        if (b > a) return b;
                        else if (c > a)
                            return a;



            return 1;
            //if (a > b)
            //    if (b > c) return b;
            //    else if (a > c) return c;
            //    else
            //        return a;
        }

        public static bool Method(bool a)
        {
            if (a == true) return true;
            else if (a == false) return false;
            else return !true && !false;
        }
    }
}
