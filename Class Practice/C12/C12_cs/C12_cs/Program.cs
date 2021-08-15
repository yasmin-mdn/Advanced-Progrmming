using System;

namespace C12_cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point(x:1, y:12);
            Point p1 = new Point(x:5, y:5);
            Point p2 = new Point(x:2, y:-4);
            Point p3 = new Point(x:0, y:12);
            Point p4 = new Point(x:1, y:11);
           

            Point[] points = new Point[]{p,p1,p2,p3,p4};

            Sort(points, PointComparer.pointXComparer);
            PrintPoints(points);
            Console.WriteLine("//////////");
            Sort(points, PointComparer.pointYComparer);
            PrintPoints(points);
             Console.WriteLine("//////////");
            Sort(points, PointComparer.pointManitudeComparer);
            PrintPoints(points);
            Console.WriteLine("//////////");
        }

        static void Sort(Point[] points, IPointComparer cmp)
        {
            for(int i=0;i<points.Length;i++){
                for(int j=i+1;j<points.Length;j++){
                    if (cmp.IsGreater(points[i], points[j]))
                        Swap(points, i, j);
                }
            }
        }

          private static void PrintPoints(Point[] points)
        {
            foreach(var p in points)
                Console.WriteLine(p);                
        }  

         private static void Swap<_Type>(_Type[] points, int i, int j)
        {
            _Type s = points[i];
            points[i] = points[j];
            points[j] = s;
        }  
        
    }
}
