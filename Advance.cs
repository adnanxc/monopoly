using System;
namespace Monopoly
{
    public class Advance
    {
        public Advance()
        {
        }

        public void Execute(Board b, Player p, int steps)
        {

            p.Position += steps;
            if(p.Position > b.PropertyCount)
            {
                 p.Position =- b.PropertyCount;

            }

            if (OwnedProperty(b.FetchProperty(p.Position)))
            {
                Console.WriteLine()
                PayRent(Player p, Property property);

            }
        }

        public bool OwnedProperty(Property p)
        {
            if (p.IsBought())
            {
                return true;
            }
            return false;
        }
    }
}
