using System;

namespace cs
{
 public class Program
    {
        public  static void Let(out int a,ref int b){
            a=b;
           
        }

        public  static void Square( ref int n){
            n=n*n;
        }

        public  static void Swap(ref int a,ref int b){
            int tmp;
            tmp=a;
            a=b;
            b=tmp;
        }

        public static void SwapArray(int[] a,int [] b){
            if(a.Length==b.Length){
                for (int i=0;i<a.Length;i++){
                    Swap(ref a[i],ref b[i]);
                }
            }
        }

        public static int MaximumValue(params int[] inputs){
            int max =inputs[0];
            foreach(int i in inputs){
                if(i>max)
                max=i;
            }
            return max;
        }

        public static ref int[] sort_function( ref int[] array){
         {
          int length = array.Length;
            int temp = array[0];
              for (int i = 0; i < length; i++)
                     {
                         for (int j = i+1; j < length; j++)
                             {
                             if (array[i] > array[j])
                                 { temp = array[i];
                                    array[i] = array[j];
                                     array[j] = temp;
                                          }
                                            }
                                            }
                                            return  ref array;        
                                     }}


    public static String[] stringsort(String[] c){
     int size =c.Length;
     for(int a = 0; a < size - 1; a++) 
      {
         for(int b = a + 1; b < c.Length; b++) 
         {
            if(c[a].CompareTo(c[b]) > 0) 
            {
               String temp = c[a];
               c[a] = c[b];
               c[b] = temp;
            }
         }
      }

        return c;
    }



        public static int[] CommonIntegerElements(int[] a,int[] b){
            int n=0;
             int [] c=new int[0];
            
            foreach(int i in a){
                foreach(int j in b){
                    if(i==j){
                        Array.Resize(ref c ,(int)c.Length+1);
                      c[n]=i;
                     n++;
                    }
                } 
            }
             c=sort_function(ref c);
            return c;
        }

        public static String[] CommonStringElements(String[] st1,String[] st2){
            int n=0;
             string [] Common=new string[0];
             foreach(string st in st1){
                 foreach(string str in st2){
                     if(st==str){
                     Array.Resize(ref Common ,(int)Common.Length+1);
                     Common[n]=st;
                     n++;
                     }
                 }
             }
             Common=stringsort(Common);
             //Array.Sort(Common);
            return Common;
        }
      
      
      public static _type[] CommonElements <_type> (_type[] a,_type[] b){
          _type[] Common=new _type[0];
          int n=0;
            foreach(_type t in a){
                foreach(_type t2 in b){
                    if(t.Equals(t2)){
                        Array.Resize(ref Common,Common.Length+1);
                        Common[n]=t;
                        n++;

                    }
                }
            }
          return Common; 
      }
      
        static void Main(string[] args)
        {
            
    }
}
} 
