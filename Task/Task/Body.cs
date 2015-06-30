using System;

namespace Task
{
    public static class Body
    {
        public static int Result(string incomingString)
        {
            var sum = Rec(NullOrEmpty(incomingString));
            Print(incomingString, sum);
            return sum;
        }

        private static string NullOrEmpty(string testString) // проверка на ноль
        {
            return string.IsNullOrEmpty(testString) ? "0" : testString;
        }

        private static int Rec(string intactString) // рекурсия
        {
            if (intactString == "0")
            {
                return 0;
            }

            var fragment = Remove(intactString);
            var number = Branch(StringToInt(ReplaceMinus(ReplacePlus(fragment)))); 
            var sum = number + Rec(SubString(intactString));
            return sum; // нужно чтоб счетчик останавливался здесь
        }

        private static string Remove(string intactString) // режем до 1го + или -
        {
            var stringTrim = intactString.Trim();
            var index = Index(stringTrim);
            return CutRemove(intactString, index);
        }

        private static int Index(string stringTrim)
        {
            var stringShort = stringTrim.Remove(0, 1);
            return IndexAny(stringShort) == -1 ? -1 : IndexAny(stringShort) + 1;
        }

        private static int IndexAny(string indexableString) // номер 1го + или - 
        {
            return indexableString.IndexOfAny(new[] { '+', '-' });
        }

        private static string CutRemove(string stringTrim, int index) // режем до 1го + или -
        {
            return index == -1 ? stringTrim : stringTrim.Remove(index);
        }

        private static int Branch(int number) // обрезаем числа-слагаемые до 1000
        {
            if (number < -1000)
            {
                return -1000;
            }

            if (number > 1000)
            {
                return 1000;
            }

            return number;
        }

        private static int StringToInt(string fragmentMod) // переводим в число
        {
            int number;
            var result = int.TryParse(fragmentMod, out number);

            return result ? number : 0;
        }

        private static string ReplaceMinus(string stringTrim) // замена
        {
            if (stringTrim.StartsWith("- "))
            {
                return stringTrim.Replace("- ", "-");
            }

            return stringTrim;
        }

        private static string ReplacePlus(string stringTrim) // замена
        {
            if (stringTrim.StartsWith("+ ") || stringTrim.StartsWith("+") || stringTrim.StartsWith(" +"))
            {
                return stringTrim.TrimStart('+');
            }

            return stringTrim;
        }

        private static string SubString(string intactString) // строка без куска // протестить
        {
            var stringTrim = intactString.Trim();
            var index = Index(stringTrim);
            return CutSubstring(stringTrim, index);
        }

        private static string CutSubstring(string stringTrim, int index) // режем сабстринг
        {
            return index == -1 ? "0" : stringTrim.Substring(index);
        }

        private static void Print(string incomingString, int sum)
        {
            Console.WriteLine("{0} = {1}", incomingString, sum);
        }
    }
}
