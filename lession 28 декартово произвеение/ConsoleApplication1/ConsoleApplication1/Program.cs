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
//             Декартово произведение 0 баллов из 5

//Одно из не совсем очевидных применений SelectMany — это вычисление декартова произведения двух множеств. Опробуйте этот трюк на следующей задаче:

//Вычислить координаты всех восьми соседей заданной точки.

//Можете полагаться на то, что в классе Point переопределен метод Equals, сравнивающий точки покоординатно.
            
        }
        public static IEnumerable<Point> GetNeighbours(Point p)
        {
            int[] d = { -1, 0, 1 }; // используйте подсказку, если не понимаете зачем тут этот массив :)
            return d
                .SelectMany(dx => d.Select(dy => new Point(p.X + dx, p.Y + dy)))
                .Where(point => !point.Equals(p));

            //int[] d = { -1, 0, 1 }; // используйте подсказку, если не понимаете зачем тут этот массив :)
            //return d.SelectMany(x => d.Select(y => new Point(p.X + x, p.Y + y))).Where(point => !p.Equals(point));
        }
    }
}
