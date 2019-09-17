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
//Expr1. Как поменять местами значения двух переменных? Можно ли это сделать без ещё одной временной переменной. Стоит ли так делать?
            {
                int a = 1, b = 2;
                Console.WriteLine(a + " " + b);
                int c = 0;
                c = a;
                a = b;
                b = c;
                Console.WriteLine(a + " " + b);
                a = a + b;
                b = a - b;
                a = a - b;
                Console.WriteLine(a + " " + b);
            }


//Expr2. Задается натуральное трехзначное число (гарантируется, что трехзначное). Развернуть его, т.е. получить трехзначное число, записанное теми же цифрами в обратном порядке.
            {
                int a = 123;
                Console.WriteLine(a);
                string b = a.ToString();
                b = b[2].ToString() + b[1].ToString() + b[0].ToString();
                a = int.Parse(b);
                Console.WriteLine(a);
            }
//Expr3. Задано время Н часов (ровно). Вычислить угол в градусах между часовой и минутной стрелками. Например, 5 часов -> 150 градусов, 20 часов -> 120 градусов. Не использовать циклы.
            {
                int H = int.Parse(Console.ReadLine());
                switch (H)
                    //копиаст, по задаче 1 час = 30градусам, любое введеное значение надо приводить 6< и умножать на 30 
                {
                    case 1:
                        Console.WriteLine("30 грудусов");
                        break;
                    case 2:
                        Console.WriteLine("60 градусов");
                        break;
                    case 3:
                        Console.WriteLine("90 градусов");
                        break;
                    case 4:
                        Console.WriteLine("120 грудусов");
                        break;
                    case 5:
                        Console.WriteLine("150 градусов");
                        break;
                    case 6:
                        Console.WriteLine("180 градусов");
                        break;
                    case 7:
                        Console.WriteLine("150 грудусов");
                        break;
                    case 8:
                        Console.WriteLine("120 грудусов");
                        break;
                    case 9:
                        Console.WriteLine("90 грудусов");
                        break;
                    case 10:
                        Console.WriteLine("60 грудусов");
                        break;
                    case 11:
                        Console.WriteLine("30 грудусов");
                        break;
                    case 0:
                        Console.WriteLine("0 грудусов");
                        break;
                }
            }
//Expr4. Найти количество чисел меньших N, которые имеют простые делители X или Y.
            {
                int N = int.Parse(Console.ReadLine());
                int X = int.Parse(Console.ReadLine());
                int Y = int.Parse(Console.ReadLine());
                int delitel = X*Y;
                for (int i = 0; i < N; i++)
                {
                    if (i%delitel == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }

//Expr5. Найти количество високосных лет на отрезке [a, b] не используя циклы.

            {
                //копиаст, без циклов и рекурский кажется невозможно
                  // Рекурсивный метод
        //static int Rec_(int i)
        //{
        //    if (i % 4 == 0) return i;
        //    return Rec_(i--);
        //}
        //static int Rec(int i)
        //{
        //    if (i % 4 == 0) return i;
        //    return Rec(i++);
        //}
 
        //static void Main(string[] args)
        //{
 
        //    int Start = 833, Fin = 937;
        //    Start = Rec(Start);
        //    Fin = Rec_(Fin);
        //    Console.ReadLine();
        //}
            }

//Expr6. Посчитать расстояние от точки до прямой, заданной двумя разными точками.
            //геометрия?
//Expr7. Найти вектор, параллельный прямой. Перпендикулярный прямой. Прямая задана коэффициентами уравнения прямой.

//Expr8. Дана прямая L и точка A. Найти точку пересечения прямой L с перпендикулярной ей прямой P, проходящей через точку A. Можете считать, что прямая задана либо двумя точками, либо коэффициентами уравнения прямой — как вам удобнее.

        }
        }

}
