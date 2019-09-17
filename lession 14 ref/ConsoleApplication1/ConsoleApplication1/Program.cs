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
            var pointStruct = new PointStruct();
            ProcessStruct(pointStruct);
            Console.WriteLine(pointStruct.X); // 0

            var pointClass = new PointClass();
            ProcessClass(pointClass);
            Console.WriteLine(pointClass.X); //10


            var str = new MyStruct();
            str.myObject = new MyClass();
            ProcessStruct2(str);
            Console.WriteLine(str.myObject.classField); //10

            Console.WriteLine("ref:");

            Point point = new Point();
            ProcessStruct3(ref point);
            Console.WriteLine(point.X); //10

            int n = 0;
            ProcessInt(ref n);
            Console.WriteLine(n); //10

            var array = new int[3];
            ProcessArray(ref array);
            Console.WriteLine(array.Length); //2
        }

        static void ProcessStruct(PointStruct point)
        {
            point.X = 10;
        }

        static void ProcessClass(PointClass point)
        {
            point.X = 10;
        }

        static void ProcessStruct2(MyStruct str)
        {
            str.myObject.classField = 10;
        }

        struct Point
        {
            public int X;
            public int Y;
        }

        static void ProcessStruct3(ref Point point)
        {
            point.X = 10;
        }

        static void ProcessInt(ref int n)
        {
            n = 10;
        }

        static void ProcessArray(ref int[] array)
        {
            array = new int[2];
        }
}

    struct PointStruct
    {
        public int X;
        public int Y;
    }

    class PointClass
    {
        public int X;
        public int Y;
    }

    public class MyClass
    {
        public int classField;
    }
    public struct MyStruct
    {
        public MyClass myObject;
    }


}
