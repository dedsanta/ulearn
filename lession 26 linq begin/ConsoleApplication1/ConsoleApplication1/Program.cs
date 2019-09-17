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
            //// The Three Parts of a LINQ Query:
            //// 1. Data source.
            //int[] numbers = new int[7] { 0, 1, 2, 3, 4, 5, 6 };

            //// 2. Query creation.
            //// numQuery is an IEnumerable<int>
            //var numQuery =
            //    from num in numbers
            //    where (num % 2) == 0
            //    select num;

            //// 3. Query execution.
            //foreach (int num in numQuery)
            //{
            //    Console.Write("{0,1} ", num); //0,2,4,6
            //}
            //string[] teams = { "Бавария", "Боруссия", "Реал Мадрид", "Манчестер Сити", "ПСЖ", "Барселона" };

            //var selectedTeams = from t in teams // определяем каждый объект из teams как t
            //                    where t.ToUpper().StartsWith("Б") //фильтрация по критерию
            //                    orderby t  // упорядочиваем по возрастанию
            //                    select t; // выбираем объект

            //foreach (string s in selectedTeams)
            //    Console.WriteLine(s);

            foreach (var num in ParseNumbers(new[] { "-0", "+0000" }))
                Console.WriteLine(num);
            foreach (var num in ParseNumbers(new List<string> { "1", "", "-03", "0" }))
                Console.WriteLine(num);

            // Функция тестирования ParsePoints

            foreach (var point in ParsePoints(new[] { "1 -2", "-3 4", "0 2" }))
                Console.WriteLine(point.X + " " + point.Y);
            foreach (var point in ParsePoints(new List<string> { "+01 -0042" }))
                Console.WriteLine(point.X + " " + point.Y);


        }
        //Напишите метод, который вернет массив всех чисел, присутствующих в исходном списке строк. 
        public static int[] ParseNumbers(IEnumerable<string> lines)
        {
            return lines
                .Where(p => p != "")
                .Select(p => int.Parse(p))
                .ToArray();
            //2 дня на эту строчку ушло
            //return lines.Where(x => !string.IsNullOrEmpty(x)).Select(int.Parse).ToArray(); //топ решение
        }
        public static List<Point> ParsePoints(IEnumerable<string> lines)
        {
            
            return (lines
                .Select(p => p.Split(' '))
                .Select(p => new Point(int.Parse(p[0]), int.Parse(p[1]))))
                .ToList();
            //топ решение
    //        return lines
    //.Select(str => str.Split(' '))
    //.Select(xy => xy.Select(i => int.Parse(i)).ToArray())
    //.Select(p => new Point(p[0], p[1]))
    //.ToList();
        }
    }
    public class Point
    {
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public int X, Y;
    }
}
