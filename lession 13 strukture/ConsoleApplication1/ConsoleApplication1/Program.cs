using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    struct Point
    {
        public int X;
        public int Y;

        public void Print()
        {
            Console.WriteLine("{0} {1}", X,Y );
        }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Test()
        {
        }
    }
    class Program
    {
        static Point staticPoint;
        Point dynamicPoint;

        static void Main(string[] args)
        {
            Point localPoint;
            localPoint.X = 10;
            localPoint.Y = 10;
            var array = new Point[10];
            array[0].X = 10;
            staticPoint.X = 10;
            var instance = new Program();
            instance.dynamicPoint.X = 10;

            Point point = new Point() {X = 10, Y = 30};
            Console.WriteLine(point.X);
    
            point = new Point(10, 20);
            point.Print();

            staticPoint.Print();

            //X[] xs = new X[10];
            //xs[0].A = 1; //только структура
            //xs[0] = new X(); //класс или структура
            X x;
            x = new X(); //класс или структура
            x.arr = 5; //только структура

        }
       } 
    struct X
        {
        public int arr;
            public void A(int input)
            {

            }
        }

    class X1
    {
        public int arr;
        public void A()
        {
            
        }
    }
}
