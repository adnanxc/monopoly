using System;
namespace Monopoly
{
    public interface IHavePosition
    {
        public int Position
        {
            get;
            set;
        }

        public string Description
        {
            get;
            set;
        }
    }
}
