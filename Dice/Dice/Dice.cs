using System;

namespace Dice
{
    public class Dice
    {
        public int DiceValue { get; set; }

        public int Limit { get; set; }

        public int Success
        {
            get
            {
                return DiceValue >= Limit ? 1 : 0;
            }
        }

        public int DiceIncrease() // увеличить значение кубика на 1
        {
            DiceValue = DiceValue + 1;
            return DiceValue;
        }

        public int DiceReRoll() // перебросить кубик
        {
            var rnd = new Random();
            DiceValue = rnd.Next(1, 7);
            return DiceValue;
        }

        public int LuckyDice() // успешный кубик
        {
            DiceValue = 6;
            return DiceValue;
        }
    }
}
