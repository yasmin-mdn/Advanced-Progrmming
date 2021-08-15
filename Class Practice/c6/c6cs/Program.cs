using System;

namespace c6cs
{
    class Program
    {
        static void Main(string[] args)
        {
            TextIndex tiTrump= new TextIndex("Trump");
            TextIndex tiClinton= new TextIndex("Clinton");
            while (true)
            {Console.WriteLine("quary?");
            string quary =Console.ReadLine();
            if(quary=="exit")
            break;
            Console.WriteLine($"trump:{tiTrump.Quary(quary)},clinton:{tiClinton.Quary(quary)}");
            
                
            }
        }
    }
}
