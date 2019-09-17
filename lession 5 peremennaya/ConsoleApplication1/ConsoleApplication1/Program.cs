using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    
    class Program
    {
        static int globalVariable;
        static string globalString;

        static int DoWork()
        {
            if (2 > 3)
            {
                int temoralVariable = 30;
                Console.WriteLine(temoralVariable);
            }

            int localVariable = 10;
           return 10;
        }
        
        static void Main(string[] args)
        {
          
            var localVariable = 0;
            Console.WriteLine(localVariable);
            localVariable = DoWork();
            Console.WriteLine(localVariable);
        }
    }

   
}
