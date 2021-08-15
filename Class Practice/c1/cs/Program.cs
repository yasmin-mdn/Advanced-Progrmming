using System;

namespace cs
{
    class Program
    {
static void reverse <type>( type [] list){
    type tmp;
    for(int i=0;i<=list.Length/2;i++){
        int n=list.Length;
      tmp=list[i];
      list[i]=list[n-i-1];
      list[n-i-1]=tmp;
    }
}

 static void outputarray <type>(type[] list){
     foreach(type n in list)
     Console.Write(n);


}


        static void Main(string[] args)
        {int[] t={ 1,2,3,4,5,6};
        reverse(t);
        outputarray(t);
          
        }
    }
}
