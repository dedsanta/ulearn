﻿using System;
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
//            Expr10. Найти сумму всех положительных чисел меньше 1000 кратных 3 или 5.
            int sum = 0;
            for (int i = 0; i < 1000; i++)
            {
                if (i%3 == 0 || i%5 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine(sum);
//Expr11. Дано время в часах и минутах. Найти угол от часовой к минутной стрелке на обычных часах.

//Expr12. 1885. Комфорт пассажиров

//Самолёт должен набрать высоту h метров в течение первых t секунд полёта и удерживать её в течение всего полёта. Разрешён набор высоты со скоростью не более чем v метров в секунду. До полного набора высоты запрещено снижаться. Известно, что уши заложены в те и только те моменты времени, когда самолёт поднимается со скоростью более x метров в секунду. Посчитайте минимальное и максимальное возможное время, в течение которого у пассажиров будут заложены уши. Считайте, что самолёт способен изменять скорость мгновенно.

//Expr13. 1084. Пусти козла в огород

//Козла пустили в квадратный огород и привязали к колышку. Колышек воткнули точно в центре огорода. Козёл ест всё, до чего дотянется, не перелезая через забор огорода и не разрывая веревку. Какая площадь огорода будет объедена? Даны длина веревки и размеры огорода.
        }
    }
}
