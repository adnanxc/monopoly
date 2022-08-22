using System;
using System.Collections.Generic;
namespace Monopoly
{
    public class Player : PositionalObject
    {
        private int _cash; //The amount of money a player has
        private List<Property> _properties; //The properties a player owns

        public Player(string name, string[] ids) : base(name, ids, 1) //Players start in Position 1
        {
            _typeOfObject = "player";
        }

        public int Cash
        {
            get
            {
                return _cash;
            }

            set
            {
                _cash = value;
            }
        }

        public void AddCash(int i)
        {
            _cash += i;
        }

        public void DeductCash(int i)
        {
            _cash -= i;
        }



        public Property Property
        {
            get
            {
                foreach(Property p in _properties)
                {
                    return p;
                }
                return null;
            }
        }


        public void AddProperty()   //When player buys property
        {
            _properties.Add(Property);
        }

        public void RemoveProperty(string id)
        {
            foreach(Property p in _properties)  //When player sells property
            {
                if (p.AreYou(id))
                {
                    _properties.Remove(p);
                }
            }
        }

    }
}
