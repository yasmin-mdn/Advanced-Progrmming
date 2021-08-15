using System.Collections.Generic;

namespace A2_cs
{
    public class Category
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
		public List<Product> Products;
        public List<Product> _Products{
            set{
               this.Products=value;
            }
            get{
                return Products;
            }
        }

		public Category(ID id, List<Product> products)
		{
            _Id=id;
            _Products= products;
        }
        public void AddProduct(Product p)
		{  if(p.Id==this.Id){
            Products.Add(p);
        }
           
        }
        public List<Product> FilterByPrice(int lower,int upper)
		{   List<Product> Aim_Products=new List<Product>(1);
            foreach(Product p in Products){
                if(p._Price>=lower&&p._Price<=upper){
                    Aim_Products.Add(p);
                }
            }
            
            return Aim_Products;
        }
    }
}

