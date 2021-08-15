using System;

namespace aw6_cs
{
    public enum Athlete
        {
       LongHands=0,
       Height=1,
       Pace=2,
       Brain=4,
       LongLegs=8,
       None=16
    }
   
   public class Program
    {
       
         public static string WhichSport(Athlete e){
             bool height=((Athlete.Height|e)==e);
             bool brain=((Athlete.Brain|e)==e);
             bool longhands=((Athlete.LongHands|e)==e);
             bool longlegs=((Athlete.LongLegs|e)==e);
             bool pace=((Athlete.Pace|e)==e);
             bool none=((Athlete.None|e)==e);

            string st="";
             if (height&&longhands &&pace){
                st="Volleyball";
            }
           else if(height&&longhands){
                st="Basketball";
            }
           
            else if (longlegs&&pace){
                st="Karate";
            }
           else if (longlegs&& brain){
                st="Karate";
            }
            else  if (pace&& brain){
                st="Boxing";
            }
           else if (brain){
                st="Chess";
            }
             else if(none)
                st="Mench!!!";
            

        return st;
    }
        static void Main(string[] args)
        {
            
        }
    }
}
