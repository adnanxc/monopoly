using System;
namespace Monopoly
{
    public class MoveCommand : Command
    {
        public MoveCommand() : base(new string[] { "move", "move player", "change position", "advance" })
        {
        }

        public override string Execute(Board b, PositionalObject p, int posincrement)
        {
            p.Position += posincrement;
            return NewPositionDescription(b.FetchSpot(p.Position));
            
        }

        public string NewPositionDescription(Property p)
        {
            return p.Description;
        }

    }
}
