using System;
namespace Monopoly
{
    public abstract class Command : IdentifiableObject
    {
        public Command(string[] ids) : base(ids)
        {
        }

        public abstract string Execute(Board b, PositionalObject p, int newpos);
    }
}
