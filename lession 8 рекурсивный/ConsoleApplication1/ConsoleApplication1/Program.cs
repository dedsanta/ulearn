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

            TestOnSize(1);
            TestOnSize(2);
            TestOnSize(0);
            TestOnSize(3);
            TestOnSize(4);
        }

        static void TestOnSize(int size)
        {
            var result = new List<int[]>();
            MakePermutations(new int[size], 0, result);
            foreach (var permutation in result)
                WritePermutation(permutation);
        }


        static void MakePermutations(int[] permutation, int position, List<int[]> result)
        {//WritePermutation(permutation);
            if (position == permutation.Length)
            {
                //доделать...
                result.Add(permutation.ToArray());
                return;
            }
            else
            {
                for (int i = 0; i < permutation.Length; i++)
                {
                    var index = Array.IndexOf(permutation, i, 0, position);
                    //если i не встречается среди первых position элементов массива permutation, то index == -1
                    //иначе index — это номер позиции элемента i в массиве.
                    if (index == -1)
                    {
                        // если число i ещё не было использовано, то...
                        // доделать.
                        permutation[position] = i;
                        MakePermutations(permutation, position + 1, result);
                    }
                }
            }
        }

        static void WritePermutation(int[] permutation)
        {
            foreach (var i in permutation)
                Console.Write(i + " ");
            Console.WriteLine();
        }
    }
}
