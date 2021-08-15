namespace C7
{
    public class Data
    {
    public string  Country{get;private set;}
    public int Year{get;private set;}


        public Data(string country,int year)
        { 
            this.Country=country;
            this.Year=year;
        }

        public override bool Equals(object obj)
        {
            if(obj is Data)
            return  this.Country==(obj as Data).Country&&this.Year==(obj as Data).Year;
            if(obj is string)
            return this.Country+Year.ToString()==obj as string;
            return false;
        }

        public override int GetHashCode()
        {
            return this.Country.GetHashCode() ^ this.Year.GetHashCode();
        }

        public override string ToString()
        {
            return  "children-per-woman for "+ this.Country+" in year:"+this.Year.ToString();}
    }
}