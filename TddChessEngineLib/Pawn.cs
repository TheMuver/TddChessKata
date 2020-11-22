using System;

namespace TddChessEngineLib
{
    public enum FigureColor { White, Black }

    public class Pawn
    {
        public string CurrentPosition {get; private set;}
        public FigureColor FigureColor { get; }

        public Pawn (string initPosition, FigureColor color)
        {
            CurrentPosition = initPosition;
            FigureColor = color;
        }

        public void TurnTo(string finishPosition)
        {
            CurrentPosition = finishPosition;
        }
    }
}
