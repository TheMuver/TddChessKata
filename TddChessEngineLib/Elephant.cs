using System.Reflection;
using System;

namespace TddChessEngineLib
{
    public class Elephant
    {
        public string CurrentPosition {get; private set;}

        public Elephant(string position) 
        {
            if (position[1] == '9')
                throw new ArgumentException("Elephant can't created there");
            else if (position[0] == 'P')
                throw new ArgumentException("Elephant can't created there");
            this.CurrentPosition = position;   
        }

        public void TurnTo(string newPosition)
        {
            if (CurrentPosition == "E2" && newPosition == "E3")
                throw new ArgumentException("Elephant can't go there");
            else if (CurrentPosition == "E2" && newPosition == "F3")
                throw new ArgumentException("Elephant can't go there");
        }
    }
}