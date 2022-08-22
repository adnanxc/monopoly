using System;
namespace Monopoly
{
    public abstract class GameObject : IdentifiableObject
    {
        private string _name;

        public GameObject(string name, string[] ids) : base(ids)
        {
            _name = name;
        }

        public virtual string Description
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

    }
}
