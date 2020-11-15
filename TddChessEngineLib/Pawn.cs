using System;

namespace TddChessEngineLib
{
    public class Pawn
    {
        public string Position {get; private set;}

        public void TurnTo(string finishPosition)
        {
            Position = finishPosition;
        }
    }
}
