using System;

namespace E1
{
    class Program
    {
public class Student {
    public Student(double[] a,double[] b)
{
     double[] grades =new double[a.Length];
     double[] weighs =new double[b.Length] ;
    for(int i=0;i<a.Length;i++)
          for(int j=0;j<grades.Length;j++)
     grades[j]=a[i];

 for(int i=0;i<b.Length;i++)
          for(int j=0;j<weighs.Length;j++)
     weighs[j]=b[i];

}
   


    public  double avg (double[] grades,double[] weighs){
         double sum =0;
         double total =0;
         foreach(double d in grades){
             foreach(double c in weighs){
             sum +=d*c;
             total+=c;
             }
            

         }
          return sum/total;
     }
}








        static void Main(string[] args)
        {
            Double[] nums={17,12,20};
           Double[] w= {2,1,3};
            Student st =new Student(nums,w);
            double r= st.avg(nums,w);
            Console.WriteLine(r);

        }
    }
}
