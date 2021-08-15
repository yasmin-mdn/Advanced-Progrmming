using System;
using System.Collections.Generic;

namespace A4_cs
{
    public enum Config
    {
        Graphic=1,
         Memory =2,
        Cpu =4
    }
    public class MemoryHeap
    {//char[] lst;
       List<char> lst = new List<char>(0);


        public void Allocate(int bytes)
        {  
             if(bytes%2==0){
                for(int i=0;i<bytes/2;i++)
                {
                    lst.Add('0');
                }
                }
                else{
                    for(int i=0;i<(bytes-1)/2;i++){
                        lst.Add('0');
                    }
                }
           
            
        }
        public void DeAllocate()
        {
            lst=null;
            }
        }
    

    public class Memory
    {
    public int? Capacity ;
    public int? Pins ;
    public string  Type;

     public Memory(int? capacity=null ,int? pins=null ,string type=null){
         this.Capacity=capacity;
         this.Type=type;
         this.Pins=pins;
     }

    }
    public class Graphic
    {
        public int? Size ;
        public string Coprocessor;
        public string  Type;

         public Graphic(int? size=null,string coprocessor="",string type=""){
            this.Size=size;
            this.Coprocessor=coprocessor;
            this.Type=type;
        }
    }
    public class Cpu
    {
       public string  Model ;
       public double?  Weight ;
        public string Speed;

        public  Cpu(string model=null,double? weight=null,string speed=null){
            this.Speed=speed;
            this.Model=model;
            this.Weight=weight;

        }
    }
    
    
       public struct Struct_Size5{
           char b,q,h,k,l;

        }
        
        public struct Struct_Size10{
            Struct_Size5 size5;
            Struct_Size5 Size5;
        }
        public struct Struct_Size12{
            int a,b,c;
        }
        public struct Struct_Size105{
          Struct_Size10 s1,s2,s3,s4,s5,s6,s7,s8,s9,s10;
           Struct_Size5 Size5;
            

        }
    public class Program
    {
      

        static void Main(string[] args) {
            MemoryHeap memory=new MemoryHeap();
            memory.Allocate(4001);
          
            }

        public static string ChooseBest(Config c)
        {   string st="";
            bool graphic=((Config.Graphic|c)==c);
            bool cpu=((Config.Cpu|c)==c);
            bool memory=((Config.Memory|c)==c);
            if(graphic&&memory&&cpu)
                st="Excellent";
            else if((graphic&&memory)||(memory&&cpu))
                st="Very Good";
            else if(memory)
                st="Good";
            else if(cpu||graphic)
                st="Not Bad";
            return st;
        }
        public static void SwapConfigs(object o1, object o2)
        {
            if(o1 is Graphic && o2 is Graphic){
               Graphic obj1=o1 as Graphic;
               Graphic obj2=o2 as Graphic;
                Swap(ref obj1.Coprocessor,ref obj2.Coprocessor);
                Swap(ref obj1.Size,ref obj2.Size);
                Swap(ref obj1.Type,ref obj2.Type);
                
            }
            else if(o1 is Memory && o2 is Memory){
                Memory obj1=o1 as Memory;
                Memory obj2=o2 as Memory;
                Swap(ref obj1.Capacity,ref obj2.Capacity);
                Swap(ref obj1.Pins,ref obj2.Pins);
                Swap(ref obj1.Type,ref obj2.Type);
             }

            else if(o1 is Cpu && o2 is Cpu){
                Cpu obj1=o1 as Cpu;
                Cpu obj2=o2 as Cpu;
                Swap(ref obj1.Model,ref obj2.Model);
                Swap(ref obj1.Speed,ref obj2.Speed);
                Swap(ref obj1.Weight,ref obj2.Weight);
             }



        }
        
        private static void Swap<Type>(ref Type a1, ref Type a2)
        {
           Type tmp=a1;
            a1=a2;
            a2=tmp;
        
        }
    }
}
