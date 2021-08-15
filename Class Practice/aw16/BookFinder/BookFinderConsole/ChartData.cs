namespace BookFinderServer{
    public class ChartData{
        public int idx{ get; set;}
        public float Value{get; set;}
        public ChartData(int a , float b){
            this.idx=a;
            this.Value=b;
        }
    }
}