using System;
using TddChessEngineLib;
using Xunit;

namespace TddChessEngineLibTests
{
    public class PawnTests
    {
        const string startPosition = "E2";
        const string finalPosition = "E4";

        [Fact]
        public void WhenWhitePawnTurnsFromE2ToE4_ThenItsPositionsChanges()
        {
            Pawn p = new Pawn(startPosition, FigureColor.White);
            p.TurnTo(finalPosition);
            Assert.Equal(finalPosition, p.CurrentPosition);
        }

        [Fact]
        public void WhenBlackPawnTriesGoBack_ThenItsCantGoBack()
        {
            Pawn p = new Pawn(startPosition, FigureColor.Black);
            p.TurnTo(finalPosition);
            Assert.Equal(startPosition, p.CurrentPosition);
        }
    }
}
