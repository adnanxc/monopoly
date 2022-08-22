using System;
using System.Collections.Generic;
namespace Monopoly
{
    public class IdentifiableObject
    {
        private List<string> _identifiers = new List<string>();

        public IdentifiableObject(string[] ids)
        {
            foreach(string s in ids)
            {
                AddIdentifier(s);
            }
        }

        public void AddIdentifier(string id)
        {
            id = id.ToLower();
            _identifiers.Add(id);
        }

        public string FirstId
        {
            get
            {
                if (_identifiers.Count == 0)
                {
                    return "";
                }
                return _identifiers[0];
            }
        }

        public bool AreYou(string id)
        {
            foreach(string s in _identifiers)
            {
                if(s == id.ToLower())
                {
                    return true;
                }
            }

            return false;
        }
    }
}
