using System;
struct Teststruct{
    public int x;
    public int y;
    public int z;
}

namespace c9_cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Teststruct[] values=Getinput();
            sort(ref values,null);
            output(values);
            Console.ReadKey();

        }

        private static void output(Teststruct[] values)
        {
            foreach(var v in values){
                Console.WriteLine("x:"+v.x.ToString()+",y:"+v.y.ToString()+",z:"+v.z.ToString());
            }
        }

        private static void sort(ref Teststruct[] values, bool ?  v )
        { 
            if(v.HasValue){
           
             if (v==true){
                
                for(int j=0;j<values.Length;j++){ 
                 for(int i=j+1;i<values.Length;i++){
                     if(values[j].x>values[i].x)
                      swap(ref values[i],ref values[j]);
                 }
                
             }
             }
            else {
                 for(int j=0;j<values.Length;j++){ 
                 for(int i=j+1;i<values.Length;i++){
                     if(values[j].y>values[i].y)
                      swap(ref values[i],ref values[j]);
                 }
                
             }
             }
        }
         else{
                 for(int j=0;j<values.Length;j++){ 
                 for(int i=j+1;i<values.Length;i++){
                     if(values[j].z>values[i].z)
                      swap(ref values[i],ref values[j]);
                 }
                
             }
         }


          
        }

        private static void swap(ref Teststruct teststruct1,ref Teststruct teststruct2)
        {Teststruct temp=teststruct1;
        teststruct1=teststruct2;
        teststruct2=temp;
            
        }

        private static Teststruct[] Getinput()
        {Console.Write("howmany??");
            int count=int.Parse(Console.ReadLine());
             Teststruct[] list=new Teststruct[count];
             for(int i=0;i<count;i++){
                     list[i] =GetXYZ();
                     Console.WriteLine("made");  
             }
             return list;  
        }

        private static Teststruct GetXYZ()
        {
            int x=int.Parse(Console.ReadLine());
            int y=int.Parse(Console.ReadLine());
            int z=int.Parse(Console.ReadLine());
            Teststruct t;
            t.x=x;
            t.y=y;
            t.z=z;
            return t;
        }
    }
}
