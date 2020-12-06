using System;
using TddChessEngineLib;
using Xunit;

namespace TddChessEngineLibTests
{
    public class ElephantTests
    {
        const string E2Position = "E2";
        const string E9Position = "E9";
        const string P2Position = "P2";
        const string E3Position = "E3";
        const string F3Position = "F3";
        
        [Fact]
        public void WhenCreatingElephantOnE2_ThenItCurrentPositionE2()
        {
            Elephant elephant = new Elephant(E2Position);

            Assert.Equal(E2Position, elephant.CurrentPosition);
        }

        [Fact]
        public void WhenTryCreatingElephantOnE9_ThenItThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Elephant(E9Position));
        }

        [Fact]
        public void WhenTryCreatingElephantOnP2_ThenItThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Elephant(P2Position));
        }

        [Fact]
        public void WhenElephantTurnFromE2ToE3_ThenItThrowsArgumentException()
        {
            Elephant elephant = new Elephant(E2Position);

            Assert.Throws<ArgumentException>(() => elephant.TurnTo(E3Position));
        }

        [Fact]
        public void WhenElephantTurnFromE2ToF3_ThenItChangesPosition()
        {
            Elephant elephant = new Elephant(E2Position);

            Assert.Throws<ArgumentException>(() => elephant.TurnTo(F3Position));
        }
    }
}