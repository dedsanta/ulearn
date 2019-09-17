using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int pos=0;
            string text = " a a 1 a 1";
             SkipSpaces(text, ref pos);
            ReadNumber(text, ref pos);
            
            WriteAllNumbersFromText("1 11111");
            WriteAllNumbersFromText("1 11 111");
        }

        public static void SkipSpaces(string text, ref int pos)
        {
            while (pos < text.Length && char.IsWhiteSpace(text[pos]))
                pos++;
            //Console.WriteLine(text, pos);
        }

        public static string ReadNumber(string text, ref int pos)
        {
            var start = pos;
            while (pos < text.Length && char.IsDigit(text[pos]))
                pos++;
            return text.Substring(start, pos - start);
        }

        public static void WriteAllNumbersFromText(string text)
        {
            int pos = 0;
            while (true)
            {
                SkipSpaces(text, ref pos);
                var num = ReadNumber(text, ref pos);
                if (num == "") break;
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
