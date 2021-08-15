using System;

namespace HttpAPIDemo{
    public class Dailyreport{
        public int recoverd{get;set;}
        public int active{get;set;}
        public int confirmed{get;set;}
        public int death{get;set;}
        public DateTime date{get;set;}

        public override string ToString(){
            return "Dead:  "+death.ToString()+"recoverds:  "+recoverd.ToString()+"confirmed:  "+confirmed.ToString()+"date:  "+date.ToString();
        }
    }
}