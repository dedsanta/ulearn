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
            int a = 45;
            double b = 34.56;
           
            a = (int)Math.Round(b);

            float c = (float) b;
            

            float d = 45.78f;
            float dd = 45;
            long e = 300000000000000;
            //checked
            //{
            //    a = (int) e;
            //}
            

            Console.WriteLine(a);

            
        }
    }
}
