namespace A2_cs
{
    public class Product
	{
		public ID Id;
		public ID _Id{
			set{
				this.Id=value;
			}
			get{
				return Id;
			}
		}
		public string Name;
		public string _Name{
			set{
				this.Name=value;
			}
			get{
				return Name;
			}
		}


		public int Price;
		public int _Price{
			set{
				this.Price=value;
			}
			get{
				return Price;
			}
		}

		public double Rate;
			public double _Rate{
			set{
				this.Rate=value;
			}
			get{
				return Rate;
			}
		}


		public Product(ID id , string name, int price, double rate)
		{
           _Id=id;
		   _Name=name;
		   _Price=price;
		   _Rate=rate;
		
        }
    }
}

