using System;

namespace C11_cs
{
    internal class complex
    {
        private int real;
        private int image;

        public complex(int v1, int v2)
        {
            this.real = v1;
            this.image = v2;
        }

        public complex(complex other){
            this.real=other.real;
            this.image=other.image;
        }

        public static complex operator+(complex lhs,complex rhs){
            return new complex(lhs.real+rhs.real,lhs.image+rhs.image);
        }


        public static complex operator*(complex lhs,complex rhs){
            var im=lhs.image*rhs.real+lhs.real*rhs.image;
            var re=lhs.real*rhs.real-lhs.image*rhs.image;
            return new complex(re,im);
        }

        public static implicit operator complex(string v)
        {
            string[] toks=v.Split('+','-','i','j');
            int r=int.Parse(toks[0]);
            int i=int.Parse(toks[1]);
            return new complex(r,i);
        }

         public static implicit operator complex(int v)
        {
            return new complex(v,0);
        }

         public override bool Equals(object obj)
        {
            complex t = obj as complex;
            if (!ReferenceEquals(t,null))
                return t.real == this.real && t.image == this.image;

            return false;
        }

        public override string ToString(){
            return $"{this.real}+ j * {this.image}" ; 
        }
        

          public static bool operator ==(complex lhs, complex rhs)
        {
            if (! ReferenceEquals(lhs, null))
                return lhs.Equals(rhs);            
            return false;
        }

        public static bool operator !=(complex lhs, complex rhs) => ! (lhs == rhs);

        public static bool operator <(complex lhs, complex rhs)
        {
           
           var abs1=Math.Sqrt(Math.Pow(rhs.real,2)+Math.Pow(rhs.image,2)) ;
            var abs2=Math.Sqrt(Math.Pow(lhs.real,2)+Math.Pow(lhs.image,2)) ;
            return abs1<abs2;
        }

        public static bool operator >(complex lhs, complex rhs) => 
            ! (lhs < rhs) && lhs != rhs;




    public static bool operator true(complex t)
        {
            return t.real != 0 || t.image != 0;            
        }
    public static bool operator false(complex t) 
        {
            if (t)
                return false;
            return true;
        }

        public static implicit operator int(complex v)
        {
            return v.real;
        }
    }


     
}