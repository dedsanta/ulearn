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
            string[] words = { "ab", "", "c", "de" };
            IEnumerable<char> letters = words.SelectMany(w => w.ToCharArray());
            var letters2 = words.SelectMany(w => w).ToArray(); // <= исчез вызов ToCharArray
Console.WriteLine(letters);

                    Classroom[] classes =
            {
                new Classroom {Students = {"Pavel", "Ivan", "Petr"},},
                new Classroom {Students = {"Anna", "Ilya", "Vladimir"},},
                new Classroom {Students = {"Bulat", "Alex", "Galina"},}
            };
                    var allStudents = GetAllStudents(classes);
                    Array.Sort(allStudents);
                    Console.WriteLine(string.Join(" ", allStudents));

                }
                public static string[] GetAllStudents(Classroom[] classes)
                {
                    return classes.SelectMany(w => w.Students).ToArray(); 
                }
            }
            public class Classroom
            {
                public List<string> Students = new List<string>();
        }
    }

