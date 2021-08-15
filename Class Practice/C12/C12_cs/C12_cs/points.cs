using System;

namespace C12_cs
{
 internal class Point//: ICanCompare<Point> // optional
    {
        public int x;
        public int y;
        public double Magnitude;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
            this.Magnitude=Math.Sqrt(Math.Pow(this.x,2)+(Math.Pow(this.y,2)));
        }

        public override string ToString(){
            return $"x: {x}\tY:{y}\tM:{Magnitude}";
        }
    }
}