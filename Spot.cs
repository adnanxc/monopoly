using System;
using System.Collections.Generic;
namespace Monopoly
{
    public class Spot : IdentifiableObject
    {
        private int _position;
        private List<PositionalObject> _objects;

        public Spot(string id, int position) : base(new string[] {id})
        {
            _position = position;
        }


        public void AddObject(PositionalObject o)
        {
            _objects.Add(o);
        }

        public int Position
        {
            get
            {
                return _position;
            }

            set { }
        }

        public string Description()
        {
            string s = "You are on: ";
            int houseCount = 0;
            int hotelCount = 0;
            foreach (PositionalObject p in _objects)    //Property description
            {
                if (p.TypeOfObject == "property")
                {
                    s += p.Description + "\n";
                }
            }

            s += "On this property: ";

            foreach (PositionalObject p in _objects)    //Everything else
            {
                if (p.TypeOfObject == "player")
                {
                    s +=  p.Description + "\n";
                }
            }

            return s;

        }
    }
}
