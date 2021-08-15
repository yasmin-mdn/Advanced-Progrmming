using System;

namespace c10_cs
{
    class Program
    {
        static void Main(string[] args)
        {
            IntBit n =new IntBit(31);
            bool bit0=n[0];
           // Console.WriteLine(n[4]);
            n[4]=false;
            IntBit n1=new IntBit(64);
            int w=n1+n;
            //Console.WriteLine(n[4]);
            Console.WriteLine(w);
        }
    }
}
