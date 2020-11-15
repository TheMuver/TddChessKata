using System;
using TddChessEngineLib;
using Xunit;

namespace TddChessEngineLibTests
{
    public class PawnTests
    {
        [Fact]
        public void WhenPawnTurnsFromE2ToE4_ThenItsPositionsChanges()
        {
            string finalPosition = "E4";

            Pawn p = new Pawn();
            p.TurnTo(finalPosition);
            Assert.Equal(finalPosition, p.Position);
        }
    }
}
