namespace C12_cs
{
    interface IPointComparer
    {
        bool IsGreater(Point p1, Point p2);
    }

    class PointXComparer: IPointComparer
    {
       public bool IsGreater(Point p1, Point p2){
           return p1.x<p2.x;
       }

        
    }

    class PointYComparer: IPointComparer
    {
        public bool IsGreater(Point p1, Point p2){
           return p1.y<p2.y;
       }
    }

    class PointManitudeComparer: IPointComparer
    {
        public bool IsGreater(Point p1, Point p2){
           return p1.Magnitude<p2.Magnitude;
       } 
    }


    class PointComparer
    {
        public static PointManitudeComparer pointManitudeComparer= new PointManitudeComparer(); 
        
        public static PointXComparer pointXComparer = new PointXComparer();
        
        public static PointYComparer pointYComparer = new PointYComparer(); 
        
    }
}