using System;
using TddChessEngineLib;
using Xunit;

namespace TddChessEngineLibTests
{
    public class PawnTests
    {
        const string E2Position = "E2";
        const string E3Position = "E3";
        const string E4Position = "E4";
        const string E5Position = "E5";

        [Fact]
        public void WhenWhitePawnTurnsFromE2ToE4_ThenItsPositionsChanges()
        {
            Pawn p = new Pawn(E2Position, FigureColor.White);
            p.TurnTo(E3Position);
            Assert.Equal(E3Position, p.CurrentPosition);
        }

        [Fact]
        public void WhenBlackPawnTriesGoBack_ThenItsCantGoBack()
        {
            Pawn p = new Pawn(E2Position, FigureColor.Black);

            Assert.Throws<ArgumentException>(() => p.TurnTo(E3Position));
        }

        [Fact]
        public void WhenWhitePawnTriesGoBack_ThenItsCantGoBack()
        {
            Pawn p = new Pawn(E3Position, FigureColor.White);

            Assert.Throws<ArgumentException>(() => p.TurnTo(E2Position));
        }

        [Fact]
        public void WhenWhitePawnTurnsFromE3ToE5_ThenItsCantJump()
        {
            Pawn p = new Pawn(E3Position, FigureColor.White);

            Assert.Throws<ArgumentException>(() => p.TurnTo(E5Position));
        }
    }
}
