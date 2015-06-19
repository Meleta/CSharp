using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class Body
    {
        public static string[] Break(char sign,string Data) // разбиваем строку на массив строк по + (потом добавить еще 1 параметр и резать по - и по " ").
        {
            string[] element = Data.Split(new Char[] { sign });
            return element;
        }

        public static string[] TrimArray(string[] Data) // тримим массив
        {
            int QuantityString = Data.Length;
            string[] TrimString = new string[QuantityString];
            for (int i = 0; i < QuantityString; i++)
            {
                TrimString[i] = Trim(Data[i]);
            }

            return TrimString;
        }

        public static string Trim(string Data) // тримим поэлементно
        {
            string element = Data.Trim();
            return Data;
        }

        public static string Join(string separator, string[] Data) // сшиваем строки по знаку
        {
            return String.Join(separator, Data);
        }

        public static int[] StringToIntArray(string[] element) // переводим массив строк в массив чисел
        {
            int QuantityString = element.Length;

            int[] number = new int[QuantityString];

            for (int i = 0; i < QuantityString; i++)
            {
                number[i] = Branch(StringToInt(element[i]));
            }

            return number;
        }

        public static int Branch(int numberMod1) // обрезаем числа-слагаемые до 1000
        {
            const int limitLeft = -1000;
            const int limitRight = 1000;

            if (numberMod1 < limitLeft)
            {
                return limitLeft;
            }

            if (numberMod1 > limitRight)
            {
                return limitRight;
            }

            int numberMod2 = numberMod1;
            return numberMod2;
        }

        public static int StringToInt(string element) // переводим строку слагаемых в число, переводим не инты в 0
        {
            int numberMod1;
            bool result = int.TryParse(element, out numberMod1);
            if (result)
            {
                return numberMod1;
            }
            else
            {
                return 0;
            }
        }

        public static int Sum(int[] number) // суммируем все числа массива
        {
            int Sum = 0;
            for (int i = 0; i < number.Length; i++)
            {
                Sum += number[i];
            }

            return Sum;
        }

        public static void Print(string example, int Data) // печатаем исходный пример с итоговой суммой.
        {
            Console.WriteLine("{0} = {1}", example, Data);
        }
    }
}
