﻿using System;

namespace Task
{
    public static class Interface
    {
        public static void Calculator()
        {
            Console.WriteLine("Сложение и вычитание натуральных чисел");
            Console.WriteLine("Напишите пример, который нужно посчитать (используйте цифры 0-9, знаки '+' и '-'):");

            ConsoleKeyInfo end;
            do
            {
                var incomingString = Console.ReadLine();

                Body.Result(incomingString);
            
                end = Console.ReadKey(true);
            }
            while (end.Key != ConsoleKey.Escape);

            Console.WriteLine("Спасибо за внимание :)");
        }
    }
}
