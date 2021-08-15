using System;

namespace e6cs
{
    interface IVector
    {
        
        int Length {get; }
        int this[int i] {get; set;}
        double Magnitude {
            get;
            }
    }
}