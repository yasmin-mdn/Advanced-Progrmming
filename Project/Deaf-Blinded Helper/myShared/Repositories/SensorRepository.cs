using System.Collections.Generic;
using myShared.Models;
using System.Linq;
namespace myShared.Repositories{
public class SensorRepository{
    //sensor naming -> p i m a x and palm for showing fingers  1 2 3 ... for showing position in a finger
   public enum Sensor{
       //p finger
       sensor_Off=0,
       sensor_p1=1,
       sensor_p2=2,
       sensor_p3=4,
       ////i finger
       sensor_i1=8,
       sensor_i2=16,
       sensor_i3=32,
       sensor_i4=64,
       sensor_i5=128,
       sensor_i6=256,
       ///m finger
       sensor_m1=512,
       ///a finger
       sensor_a1=1024,
       ///x finger
       sensor_x1=2048,
       sensor_x2=4096,
       ///handpalm sensors
       sensor_palm0=8192,
       sensor_palm1=16384,
       sensor_palm2=32768,
       sensor_palm3=65536,
       sensor_palm4=131072,
       sensor_palm5=262144,
       sensor_palm6=524288,
       sensor_palm7=1048576
   }


   ///methodes

       
      

   
}
}