using System;
using System.Diagnostics.CodeAnalysis;

namespace e6cs
{public class Vector:IVector,IComparable<Vector>,IEquatable<Vector>{
    private int[] Nums;
    
    public Vector(params int[] nums){
        this.Nums=nums;
       
    }

        public int this[int i] { get => this.Nums[i]; set {this.Nums[i]=value;} }

        public int Length => Nums.Length;


        
        public double Magnitude{
            get{
                 var s=0.0;
            for(int i=0;i<Nums.Length;i++)
                s=Math.Pow(Nums[i],2);
            return (double)Math.Sqrt(s);
            }

        } 
            
            
           
                
        

        public int CompareTo(Vector other){
            if (this.Magnitude>other.Magnitude){return 1;}
            else if(this.Magnitude<other.Magnitude){return -1;}
        return 0;
    }
    public bool Equals(Vector other){
        bool b=true;
        for(int i=0;i<Nums.Length;i++){
            if(this.Nums[i]!=other.Nums[i]){
                b=false;
                break;
            }
        }
        return this.Length==other.Length && b;
    }
}

}