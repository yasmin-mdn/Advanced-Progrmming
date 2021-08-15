using System.Collections.Generic;
using myShared.Repositories;

namespace myShared.Models{
     public class Letter{
        public long Id{get;set;}
        public char Symbol{get;set;}
        public string PicPath{get;set;}
       public SensorRepository.Sensor  fingerorders;

     }


 }