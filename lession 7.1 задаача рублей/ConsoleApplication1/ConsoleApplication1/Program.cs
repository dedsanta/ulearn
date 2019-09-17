using System;
using System.IO;
//Напишите метод, склоняющий существительное «рублей» следующее за указанным числительным.
namespace Pluralize
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            // Это пример ввода сложных данных из файла.
            // Циклы, строки, массивы будут рассмотрены на лекциях чуть позже, но это не должно быть препятствием вашему любопытству! :)
            var lines = File.ReadAllLines("rubles.txt");
            var hasErrors = false;
            foreach (var line in lines)
            {
                var words = line.Split(' ');
                var count = int.Parse(words[0]);
                var rightAnswer = words[1];
                var pluralizedRubles = PluralizeTask.PluralizeRubles(count);
                if (pluralizedRubles != rightAnswer)
                {
                    hasErrors = true;
                    Console.WriteLine("Wrong answer: {0} {1}", count, pluralizedRubles);
                }
            }

            if (!hasErrors)
                Console.WriteLine("Correct!");
        }
    }

    public static class PluralizeTask
    {
        public static string PluralizeRubles(int count)
        {
            // Напишите функцию склонения слова "рублей" в зависимости от предшествующего числительного count.
            if (count % 100 == 11)
                return "рублей";
            else if (count % 10 == 1)
                return "рубль";
            else if (count % 100 >= 11 && count % 100 <= 20)
                return "рублей";
            else if ((20 > count) && (count > 9))
                return "рублей";
            else if ((5 > count % 10) && (count % 10 > 1))
                return "рубля";
            else
                return "рублей";
            return "руб.";
        }
    }
}