using System;
using System.Drawing;

namespace C19_cs
{
    internal class Circle:Shape
    {
        private string name;
        private Point center;
        private double radius;

        public Circle(string name,ConsoleColor r, Point center, double radius):base()
        {
            this.center = center;
            this.radius = radius;
        }

        public override double Area => throw new System.NotImplementedException();

        public override double Perimiter => throw new System.NotImplementedException();

        public override void Draw()
        {
            throw new System.NotImplementedException();
        }
    }
}