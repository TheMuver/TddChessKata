using System;
using TddChessEngineLib;
using Xunit;

namespace TddChessEngineLibTests
{
    public class ElephantTests
    {
        const string e2Position = "E2";
        const string e9Position = "E9";
        const string p2Position = "P2";
        
        [Fact]
        public void WhenCreatingElephantOnE2_ThenItCurrentPositionE2()
        {
            Elephant elephant = new Elephant(e2Position);

            Assert.Equal(e2Position, elephant.CurrentPosition);
        }

        [Fact]
        public void WhenTryCreatingElephantOnE9_ThenItThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Elephant(e9Position));
        }

        [Fact]
        public void WhenTryCreatingElephantOnP2_ThenItThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Elephant(p2Position));
        }
    }
}