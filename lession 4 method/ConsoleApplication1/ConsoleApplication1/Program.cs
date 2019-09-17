using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        /// <summary>
        /// документирование
        /// </summary>
        /// <param name="a">делимое</param>
        /// <param name="b">делитель</param>
        /// <returns>округленное частное</returns>
        public static int DivideAndRound(double a, double b)
        {
            //var c = a/b;
            //var d = (int) Math.Round(c);
            return (int)Math.Round(a/b);
        }

        public static void WriteNember(int a)
        {
            Console.WriteLine("a is int");
            Console.WriteLine(a);
        }

        public static void WriteNember(double a)
        {
            Console.WriteLine("a is double");
            Console.WriteLine(a);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(DivideAndRound(2.0, 3.0));
            WriteNember((double)23);
            WriteNember(23.0);
            DivideAndRound(10, 20);

            string text = "1 00 0";
            int lenght = text.Length /2;
	string newText = text.Replace(" ","");
            Console.WriteLine(text.Substring((int) text.Length/2).Replace(" ",""));
        }
    }
}
