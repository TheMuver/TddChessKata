using System;
using TddChessEngineLib;
using Xunit;

namespace TddChessEngineLibTests
{
    public class ElephantTests
    {
        const string e2Position = "E2";
        
        [Fact]
        public void WhenCreatingElephantOnE2_ThenItCurrentPositionE2()
        {
            Elephant elephant = new Elephant(E2);

            Assert.Equal(e2Position, elephant.CurrentPosition);
        }

        public void WhenTryCreatingElephantOnE9_ThenItThrowsArgumentException()
        {

        }
    }
}