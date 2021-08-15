using System;

namespace c10_cs
{
    public struct IntBit
    {private int N;
        public int length;
          public IntBit(int v)
        {
            this.N = v;
            string binary = Convert.ToString(v, 2);
            this.length=binary.Length;
        }
        
        
        public bool this[int n]{
            get{
               var tmp= (this.N>>n)&1;
                return tmp==1 ;
            }
            set{
                switch(value){
                    case true:
                        this.N=(1<<n)|this.N;
                        break;
                    case false:
                        this.N=(~1<<n)& this.N;
                        break;
                }
            }
        }

        public static int operator+(IntBit lhs,IntBit rhs){
            int count=0;
            for(int i=0;i<lhs.length;i++){
                if(lhs[i])
                    count++;
            }
            for(int i=0;i<rhs.length;i++){
                if(rhs[i])
                    count++;
            }
            return count;
        }
      
    }
}