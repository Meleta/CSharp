using System;
using System.Collections.Generic;

using Dice;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using Dice = Dice.Dice;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TypeOfSuccess()
        {
            var player = new Player();
            player.Attribute = 100;
            player.StatePlayer = Player.State.Normal;

            var cast = new ThrowDice();
            Assert.IsInstanceOfType(cast.SuccessStory(player, 1, 1, 1, true), typeof(int));
        }
    }
}
