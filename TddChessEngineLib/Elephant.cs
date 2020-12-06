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
                throw new ArgumentException("Elephant cann't created on E9");
            this.CurrentPosition = position;   
        }
    }
}