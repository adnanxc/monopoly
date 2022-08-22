using System;
using System.Collections.Generic;
namespace Monopoly
{
    public class Board
    {
        private List<Property> _properties;

        public Board()
        {
            _properties = new List<Property>();

        }

        public string Description()
        {
            string s = "";
            foreach(Property p in _properties)
            {
                s += p.Description;
            }
            return s;
        }

        public Property FetchProperty(int position)
        {
            foreach(Property p in _properties)
            {
                if (p.Position==position)
                {
                    return p;
                }
            }
            return null;
        }

        public Property Property()
        {
            get
            {
                return _properties.Count;
            }
        }
    }
}
