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
            var dictionary = new Dictionary<char, Action>();
            for (char c = 'A'; c < 'Z'; c++)
            {       dictionary.Add(c, () => Console.Write(c));
            Console.WriteLine(c);
        }

        dictionary['X'](); //выведет Z, видимо сдвигает цикла еще на 1 шаг
            Console.ReadLine();

            Func<int, List<int>>[] f = new Func<int, List<int>>[] { };
            int result = (f[0](0))[0];            
            //Func<int> f;
            //Func<int>[] f;
            //Func<int[]>[] f;
            //Func<int[], int>[] f;
            //Func<int, List<int>>[] f; //вот что 
            //Action<Func<int, List<int>>> f;
            //Action<Func<int, List<int>>>[] f;

        }
    }
}
