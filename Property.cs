using System;
namespace Monopoly
{
    public class Property
    {
        private int _rent;
        private int _price;
        private int _position;
        private Player _owner;
        

        public Property(string name, int position, int rent, int price)
        {
            _rent = rent;
            _price = price;
            _owner = null;
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

        public int Position
        {
            get
            {
                return _position;
            }
            set
            {
                _position = value;
            }
        }

        public bool IsBought()
        {
            if(_owner != null)
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
