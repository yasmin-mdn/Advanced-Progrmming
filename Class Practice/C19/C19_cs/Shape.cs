using System;
using System.Drawing;

namespace C19_cs
{
    internal abstract class Shape
    {
        

        protected string Name;
        protected ConsoleColor Color;


         public Shape(string name, ConsoleColor c)
        {
            this.Color = c;
            this.Name = name;
        }
        public abstract  void Draw();

         public void SetColor()
        {}

        public void PrintInfo()
        {}
        
        public abstract double Area {get;}
        public abstract double Perimiter {get;}
        
    }
}