using System;
using System.Numerics;

namespace C11_cs
{
    class Program
    {
        static void Main(string[] args)
        {
            complex c=new complex(1,2);
            complex c2=new complex(5,3);
            complex c3=c+c2;
            complex c4=4;
            complex c5="3+2i";
            int a=c4;
            complex c6=c*c2;
            


            Console.WriteLine(c2.ToString());
            Console.WriteLine(c3.ToString());
            Console.WriteLine(c6.ToString());
            Console.WriteLine(c5.ToString());
            Console.WriteLine(a);
            Console.WriteLine(c4.ToString());

        }
    }
}
