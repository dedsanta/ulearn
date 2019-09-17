using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public delegate void TellUser(string input); //void !!! 
    class Program
    {
        public static void Main()
        {
            Run(Console.WriteLine);
        }

        static void Run(TellUser tellUser)
        {
            tellUser("hi!");
            tellUser("how r u?");
        }

    }


    delegate bool TryGet<T1,T2>(string input, Action<string> tellUser, out int age);
    //public delegate bool TryGet<T1,T2>(T1 x,Action<T1> z,out T2 y); //красивей и работоспособней
    class Program2
    {
        static void Main()
        {
            Run(AskUser, Console.WriteLine);
        }

        static void Run(TryGet<string, int> askUser, Action<string> tellUser)
        {
            int age;
            if (askUser("What is your age?", tellUser, out age))
                tellUser("Age: " + age);
        }

        static bool AskUser(string questionText, Action<string> tellUser, out int age)
        {
            tellUser(questionText);
            var answer = Console.ReadLine();
            return int.TryParse(answer, out age);
        }
    }
}
