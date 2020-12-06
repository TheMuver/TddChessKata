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
                throw new ArgumentException("Elephant can't created on E9");
            else if (position[0] == 'P')
                throw new ArgumentException("Elephant can't created on P2");
            this.CurrentPosition = position;   
        }
    }
}