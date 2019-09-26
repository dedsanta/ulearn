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
            var tree = new TreeNode { Value = 10 };
            Console.WriteLine(10 +" "+ GetMinValue(tree));
           // Assert.AreEqual(10, GetMinValue(tree));

            tree.Left = new TreeNode { Value = 5 };
            tree.Right = new TreeNode { Value = 15 };
            Console.WriteLine(5 + " " + GetMinValue(tree));

            tree.Left.Left = new TreeNode { Value = 2 };
            tree.Left.Left.Right = new TreeNode { Value = 3 };
            tree.Left.Right = new TreeNode { Value = 6 };
            Console.WriteLine(2 + " " + GetMinValue(tree));
        }

        public class TreeNode
        {
            public int Value;
            public TreeNode Left, Right;
        }
        public static int GetMinValue(TreeNode  root)
        {


            return root.Left == null ? root.Value : GetMinValue(root.Left); //как же я старадал над этим, помнить б о тернарном почаще

            //if (root.Left == null) return root.Value;
            //return GetMinValue(root.Left);

            //if (root.Left == null) return root.Value;
            //if (root.Left.Left == null) return root.Left.Value;
            //return root.Left.Left.Value;
        }
    }
}
