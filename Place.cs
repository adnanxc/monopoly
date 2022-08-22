using System;
namespace Monopoly
{
    public class Place : Property
    {
        private int _rent;
        private int _price;
        private int _position;
        private Player _owner;

        public Property(string name, string[] ids, int position, int rent, int price) : base(name, ids, position)
        {
            _rent = rent;
            _price = price;
            _owner = null;
            _typeOfObject = "property";
        }

        public int Rent
        {
            get
            {
                return _rent;
            }
            set
            {
                _rent = value;
            }
        }

        public int Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
            }
        }

        public bool IsBought()
        {
            if (_owner != null)
            {
                return true;
            }
            return false;
        }

        public Player Owner
        {
            get
            {
                return _owner;
            }
            set
            {
                value = _owner;
            }
        }

    }
}
