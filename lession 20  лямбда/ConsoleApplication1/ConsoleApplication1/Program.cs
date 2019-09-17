using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
   public class Program
    {
        public static void Sort<T>(T[] array, Func<T, T, int> comparer)
        {
            for (int i = array.Length - 1; i > 0; i--)
                for (int j = 1; j <= i; j++)
                {
                    var element1 = array[j - 1];
                    var element2 = array[j];
                    if (comparer(element1, element2) > 0)
                    {
                        var temporary = array[j];
                        array[j] = array[j - 1];
                        array[j - 1] = temporary;
                    }
                }
        }

        static Random rnd = new Random();

        static void Main()
        {
            var strings = new[] { "AA", "B", "AA" };
            //Лямбда-выражение - еще более краткая форма записи.
            //Теперь компилятор догадывается не только до типа возвращаемого значения,
            //но и до типа аргументов. 
            //Обратите внимание, что типы во всей программе выводятся из строки с 
            //объявлением массива!
            Sort(strings, (x, y) => x.Length.CompareTo(y.Length));
            Console.WriteLine(strings[0]);


            


            Func<int, int> f = x => x + 1;

            Console.WriteLine(f(1));

            Func<int> generator = () => rnd.Next();

            Console.WriteLine(generator());

            Func<double, double, double> h = (a, b) =>
            {
                b = a % b;
                return b % a;
            };

            Action<int> print = x => Console.WriteLine(x);

            print(generator());

            Action printRandomNumber = () => Console.WriteLine(rnd.Next());
            Action printRandomNumber1 = () => print(generator());
        }
        public static readonly Func<int> zero = () => 0;
        public static readonly Func<int, string> toString = input => input.ToString();
        public static readonly Func<double, double, double> add = (input1, input2) => input1 + input2;
        public static readonly Action<string> print = input => Console.WriteLine(input);

    }

}
