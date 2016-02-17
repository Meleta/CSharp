using System;

namespace Dice
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var player = new Player();
            player.Attribute = 100;
            player.StatePlayer = Player.State.Normal;

            var cast = new ThrowDice();
            
            Console.WriteLine(cast.SuccessStory(player, 1, 1, 1, true));

            var dice = new Dice();
            dice.DiceValue = 5;
            dice.DiceIncrease();
            Console.WriteLine(dice.DiceValue);
        }
    }
}
