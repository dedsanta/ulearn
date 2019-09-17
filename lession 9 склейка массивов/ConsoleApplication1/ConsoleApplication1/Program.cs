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
            var ints = new[] { 1, 2 };
            var strings = new[] { "A", "B" };

            Print(Combine(ints, ints));
            Print(Combine(ints, ints, ints));
            Print(Combine(ints));
            Print(Combine());
            Print(Combine(strings, strings));
            Print(Combine(ints, strings));
        }

        static void Print(Array array)
        {
            if (array == null)
            {
                Console.WriteLine("null");
                return;
            }
            for (int i = 0; i < array.Length; i++)
                Console.Write("{0} ", array.GetValue(i));
            Console.WriteLine();
        }

        public static Array Combine(params Array[] arrays)
        {

            if (arrays.Length == 0)
                return null;
            if (arrays.Length > 1 && arrays[0].GetType().GetElementType() != arrays[1].GetType().GetElementType())
                return null;
            var summaryLenght = 0;
            var elementType = arrays[0].GetType().GetElementType();
            for (int i = 0; i < arrays.Length; i++)
            {
                summaryLenght += arrays[i].Length;
            }
            var result = Array.CreateInstance(elementType, summaryLenght);
            int index = 0;
            for (var i = 0; i < arrays.Length; i++)
            {
                Array.Copy(arrays[i], 0, result, index, arrays[i].Length);
                index += arrays[i].Length;
            }
            return result;
        }
    }
}
