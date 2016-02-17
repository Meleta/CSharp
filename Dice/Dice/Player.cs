namespace Dice
{
    public class Player
    {
        public int Attribute { get; set; }

        public State StatePlayer { get; set; }

        public enum State 
        {
            Normal = 5, 

            Blessed = 4, 

            Cursed = 2, 

            Fallout = 1
        }
    }
}
