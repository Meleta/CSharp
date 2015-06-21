using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class Interface
    {
        public static void Calculator()
        {
            Console.WriteLine("Сложение и вычитание натуральных чисел");
            Console.WriteLine("Напишите пример, который нужно посчитать (используйте цифры 0-9, знаки '+' и '-'):");

            ConsoleKeyInfo end;
            do
            {
                string example = Console.ReadLine();

                Body.Result(example);
            
                end = Console.ReadKey(true);
            }
            while (end.Key != ConsoleKey.Escape);

            Console.WriteLine("Спасибо за внимание :)");
        }
    }
}
