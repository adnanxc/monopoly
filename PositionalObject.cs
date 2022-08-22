using System;
namespace Monopoly
{
    public class PositionalObject : GameObject
    {
        private int _position;
        protected string _typeOfObject;

        public PositionalObject(string name, string[] ids, int position) : base(name, ids)
        {

            _position = position;
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


        public string TypeOfObject
        {
            get
            {
                return _typeOfObject;
            }
        }

    }
}
