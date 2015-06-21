using System;
using System.Collections.Generic;
using System.Linq;

namespace Task
{
    public static class Body
    {
        public static void Result(string example) // итоговый метод
        {
            var withoutMinusSpace = Join("+-", TrimArray(Break('-', example)));
            var sum = Sum(StringToIntArray(Break('+', withoutMinusSpace)));
            Print(example, sum);
        }

        private static string[] Break(char sign, string data) // разбиваем строку на массив строк по знакам.
        {
            var element = data.Split(new[] { sign });
            return element;
        }

        private static string[] TrimArray(IList<string> data) // тримим массив
        {
            var quantityString = data.Count;
            var trimString = new string[quantityString];
            for (var i = 0; i < quantityString; i++)
            {
                trimString[i] = Trim(data[i]);
            }

            return trimString;
        }

        private static string Trim(string data) // тримим поэлементно
        {
            var element = data.Trim();
            return element;
        }

        private static string Join(string separator, string[] data) // сшиваем строки по знаку
        {
            return string.Join(separator, data);
        }

        private static IEnumerable<int> StringToIntArray(IList<string> element) // переводим массив строк в массив чисел
        {
            var quantityString = element.Count;

            var number = new int[quantityString];

            for (var i = 0; i < quantityString; i++)
            {
                number[i] = Branch(StringToInt(element[i]));
            }

            return number;
        }

        private static int Branch(int numberMod1) // обрезаем числа-слагаемые до 1000
        {
            if (numberMod1 < -1000)
            {
                return -1000;
            }

            if (numberMod1 > 1000)
            {
                return 1000;
            }

            var numberMod2 = numberMod1;
            return numberMod2;
        }

        private static int StringToInt(string element) // переводим строку слагаемых в число, переводим не инты в 0
        {
            int numberMod1;
            var result = int.TryParse(element, out numberMod1);

            return result ? numberMod1 : 0;
        }

        private static int Sum(IEnumerable<int> number) // суммируем все числа массива
        {
            return number.Sum();
        }

        private static void Print(string example, int data) // печатаем исходный пример с итоговой суммой.
        {
            Console.WriteLine("{0} = {1}", example, data);
        }
    }
}
