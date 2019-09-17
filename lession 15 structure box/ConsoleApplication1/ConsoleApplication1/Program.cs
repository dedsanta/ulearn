using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        struct MyStruct
        {
            public int field;
        }

        static void Main(string[] args)
        {
            MyStruct original;
            original.field = 10;

            object boxed = (object) original;
            MyStruct unboxed = (MyStruct) boxed;

            unboxed.field = 20;

            Console.WriteLine(original.field);
            Console.WriteLine(unboxed.field);
            
            //S s = new S();
            //ShowEquals(s,s); //false

            object[] s = new object[2];
            s[0] = new S();
            s[1] = s[0];
            Console.WriteLine(s[0] == s[1]); //true
        }

        static void ShowEquals(object o1, object o2)
        {
            Console.WriteLine(o1 == o2);
        }

    }
    public struct S
    {
        int A;
    }
}
