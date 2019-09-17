// Вставьте сюда финальное содержимое файла PluralizeTask.cs
namespace Pluralize
{
    public static class PluralizeTask
    {
        public static string PluralizeRubles(int count)
        {
            // Напишите функцию склонения слова "рублей" в зависимости от предшествующего числительного count.
            if (count == 1)
                return "рубль";
            else if (5 > count % 10 > 1)
                return "рубля";
            else if (count % 10 > 4)
                return "рублей";
            return "руб.";
        }
    }
}