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
            switch(FigureColor)
            {
                case FigureColor.White:
                    if (CurrentPosition[1] < finishPosition[1])
                    {
                        if (Math.Abs(CurrentPosition[1]-finishPosition[1]) == 1)
                            CurrentPosition = finishPosition;
                        else
                        { throw new ArgumentException("PawnCantOverstep"); }
                    }
                    else
                    { throw new ArgumentException("PawnCantGoBack"); }
                    break;
                case FigureColor.Black:
                    if (CurrentPosition[1] > finishPosition[1])
                    {
                        if (Math.Abs(CurrentPosition[1]-finishPosition[1]) == 1)
                            CurrentPosition = finishPosition;
                        else
                        { throw new ArgumentException("PawnCantOverstep"); }
                    }
                    else
                    { throw new ArgumentException("PawnCantGoBack"); }
                    break;
            }
        }
    }
}
