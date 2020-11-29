using System;
using TddChessEngineLib;
using Xunit;

namespace TddChessEngineLibTests
{
    public class PawnTests
    {
        const string e2Position = "E2";
        const string e3Position = "E3";
        const string e4Position = "E4";
        const string e5Position = "E5";

        [Fact]
        public void WhenWhitePawnTurnsFromE2ToE4_ThenItsPositionsChanges()
        {
            Pawn p = new Pawn(e2Position, FigureColor.White);
            p.TurnTo(e3Position);
            Assert.Equal(e3Position, p.CurrentPosition);
        }

        [Fact]
        public void WhenBlackPawnTriesGoBack_ThenItsCantGoBack()
        {
            Pawn p = new Pawn(e2Position, FigureColor.Black);

            Assert.Throws<ArgumentException>(() => p.TurnTo(e3Position));
        }

        [Fact]
        public void WhenWhitePawnTriesGoBack_ThenItsCantGoBack()
        {
            Pawn p = new Pawn(e3Position, FigureColor.White);

            Assert.Throws<ArgumentException>(() => p.TurnTo(e2Position));
        }

        [Fact]
        public void WhenWhitePawnTurnsFromE3ToE5_ThenItsCantJump()
        {
            Pawn p = new Pawn(e3Position, FigureColor.White);

            Assert.Throws<ArgumentException>(() => p.TurnTo(e5Position));
        }
    }
}
