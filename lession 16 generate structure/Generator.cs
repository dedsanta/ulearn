using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profiling
{
    class Generator
    {
        public static string GenerateDeclarations()
        {
            string result = "";
            string structure = "struct S";
            string classure = "class C";
            string byteValue = "byte Value";
            for (int i = 1; i <= 512; i *= 2)
            {
                string byteValueRes = "";
                for (int j = 0; j < i; j++)
                {
                    byteValueRes += byteValue + j + "; ";
                }
                result += structure + i + "{" + byteValueRes + "}";
                result += classure + i + "{" + byteValueRes + "}";
            }
            return result;
        }

        public static string GenerateArrayRunner()
        {
            string result = "public class ArrayRunner : IRunner {";
            for (int i = 1; i <= 512; i *= 2)
            {
                result += "void PC" + i + "() { var array = new C" + i +
                          "[Constants.ArraySize]; for (int i = 0; i < Constants.ArraySize; i++) array[i] = new C" + i +
                          "();} void PS" + i + "() { var array = new S" + i + "[Constants.ArraySize];}";
            }
            result += "public vois Call(bool isClass, int size, int count) {";
            for (int i = 1; i <= 512; i *= 2)
            {
                result += "if (isClass && size ==" + i + ") { for (int =0; i<count; i++) PC" + i +
                          "(); return;} if (!isClass && size ==" + i + ") { for(int i =0; i <count;i++) PS" + i + "(); return;}";
            }
            result += "throw new ArgumentException();}}";
            return result;
        } 

        public static string GenerateCallRunner()
        {
            string part1 = "public class CallRunner : IRunner { ";
            string part2 = "public void Call(bool isClass, int size, int count) { ";
            string part3 = " throw new ArgumentException();}}";
            for (int i = 1; i <= 512; i *= 2)
            {
                part1 += "void PC" + i + "(C" + i + " o) { } ";
                part1 += "void PS" + i + "(S" + i + " o) { } ";
                part2 += "if (isClass && size == " + i + ") { var o = new C" + i + "(); for (int i =0; i< count; i++) PC" +
                         i + "(o); return; } ";
                part2 += "if (!isClass && size == " + i + ") { var o = new S" + i + "(); for (int i =0; i< count; i++) PS" +
                         i + "(o); return; } ";
            }
            return part1+part2+part3;
        }
    }
}

            