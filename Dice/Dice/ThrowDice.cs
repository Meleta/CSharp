using System;
using System.Collections.Generic;
using System.Linq;

namespace Dice
{
    public class ThrowDice
    {
        private List<Dice> _dicelist;

        private List<Dice> ThrowFewDice(Player player) // кидаем n кубикov
        {
            var diceList = new Dice[player.Attribute];

            var rnd = new Random();

            for (var i = 0; i < player.Attribute; i++)
            {
                diceList[i] = new Dice();
                diceList[i].DiceValue = rnd.Next(1, 7);
                diceList[i].Limit = (int)player.StatePlayer;
            }

            _dicelist = diceList.ToList();

            return _dicelist;
        }

        private List<Dice> DiceListMod(int diceNumberPlus, int diceNumberReroll, int diceNumberSuccess, bool doubleSix) // модификаторы
        {
             if (diceNumberPlus != 0)
             {
                 _dicelist[diceNumberPlus - 1].DiceIncrease();
            }

            if (diceNumberReroll != 0)
            {
                _dicelist[diceNumberReroll - 1].DiceReRoll();
            }

            if (diceNumberSuccess != 0)
            {
                _dicelist[diceNumberSuccess - 1].LuckyDice();
            }

            if (doubleSix)
            {
                var count = _dicelist.Count(dice => dice.DiceValue == 6); // считаем кол-во шестерок

                if (count != 0)
                {
                    for (var i = 0; i < count; i++)
                    {
                        _dicelist.Add(new Dice { DiceValue = 6, Limit = 6 });
                    }
                }

                return _dicelist;
            }

            return _dicelist;
        }

        public int SuccessStory(Player player, int diceNumberPlus, int diceNumberReroll, int diceNumberSuccess, bool doubleSix)
        {
            _dicelist = ThrowFewDice(player);
            _dicelist = DiceListMod(diceNumberPlus, diceNumberReroll, diceNumberSuccess, doubleSix);

            return _dicelist.Count(dice => dice.Success == 1);
        }
    }
}
