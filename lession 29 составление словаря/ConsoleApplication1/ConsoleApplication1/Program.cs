using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
//            Текст задан массивом строк. Вам нужно составить лексикографически упорядоченный список всех встречающихся в этом тексте слов.

//Слова нужно сравнивать регистронезависимо, а выводить в нижнем регистре.

            var vocabulary = GetSortedWords(
    "Hello, hello, hello, how low",
    "",
    "With the lights out, it's less dangerous",
    "Here we are now; entertain us",
    "I feel stupid and contagious",
    "Here we are now; entertain us",
    "A mulatto, an albino, a mosquito, my libido...",
    "Yeah, hey"
);
            foreach (var word in vocabulary)
                Console.WriteLine(word);
        }
        public static string[] GetSortedWords(params string[] textLines)
        {
            return (textLines.SelectMany(s => Regex.Split(s, @"\W+"))) //ключевым ооказалась переменная "s" 
            .Where(x => x != "") //в топ решении этой строчки нет
            .Select(x => x.ToLower())
            .OrderBy(x=>x)
            .Distinct()            
            .ToArray();
            //from internet
            //return textLines.SelectMany(x => Regex.Split(x, @"\W+"))//разбиваем текст на слова
            //    .Select(x => x.ToLower()) //изменяем регистр слов на нижний
            //    .Where(i => i != "") //ищем пустые строки
            //    .OrderBy(x => x)//производим сортировку
            //    .Distinct().ToArray(); //производим удаление всех дубликатов и все это упаковываем в массив string
        }
    }
}
