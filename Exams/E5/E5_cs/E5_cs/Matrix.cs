namespace E5_cs
{
   public class Matrix
    {
        private int[,] Data;
       private int _ColCount;
       private int _RowCount;
        public int ColCount {
            get {return _ColCount;}
            set{_ColCount=value;}
        }
            
        public int RowCount {
            get{return _RowCount;
            } 
            set{_RowCount=value;}
        }

        public Matrix(int rows, int cols)
        {   RowCount=rows;
            ColCount=cols;
          this.Data=new int[rows,cols];
            
        }

        public Matrix(Matrix other)
        {
            this.ColCount=other.ColCount;
            this.RowCount=other.RowCount;
            Data=new int[RowCount,ColCount];

        }        

        public int[] this[int i]
        {
            get{ 
                  int[] a=new int[ColCount];
                    for (int j = 0; j < ColCount; j++)
                    {
                    a[j]=Data[i,j]; 
                    }
                    
                
                    return a;
                }
            set{
                for(int j=0;j<ColCount;j++){
                    this.Data[i,j]=value[j];
                }
                
            }
        }

        public int this[int i, int j]
        {
            get{ return Data[i,j];}
            set{Data[i,j]=value;}
        }

        // throw exception DimensionMisMatchException if dimensions don't match
        // You have to define DimensionMisMatchException yourself
        public static Matrix operator+(Matrix lhs, Matrix rhs) {
            Matrix total=new Matrix(lhs.RowCount,lhs.ColCount);
            if(lhs.ColCount==rhs.ColCount && lhs.RowCount==rhs.RowCount){
                for (int i=0;i<lhs.RowCount;i++){
                    for(int j=0;j<lhs.ColCount;j++){
                        total[i,j]=lhs[i][j]+rhs[i][j];
                    }
                }
               
            }
            else{
                throw new DimensionMisMatchException();
           }
            return total;
        }

        // Extra Point
        // throw exception DimensionMisMatchException if dimensions don't match
        public static Matrix operator*(Matrix lhs, Matrix rhs) => null;
    }
}