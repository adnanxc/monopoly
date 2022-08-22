using System;
namespace Monopoly
{
    public class Dice : IdentifiableObject
    {
        private Random rnd;
        public Dice() : base(new string[] {"dice"})
        {
            rnd = new Random();
        }

        public int RollDice()
        {
            
            return (rnd.Next(1, 6)); // Returns a random value between 1 and 6
        }
    }
}
