using System.Collections.Generic;

namespace A2_cs
{
    public class Cart
	{
		public string Owner;
		public string _Owner{
			set{
				this.Owner=value;
			}
			get{
				return Owner;
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
		public Cart(string owner, List<Product> products)
		{	_Owner=owner;
			_Products=products;
			
		}
		public void AddProduct(Product p)
		{
            _Products.Add(p);
        }
        public long CalculatePrice()
		{	long SumOfProducts=0;
			foreach(Product p in this.Products){
			SumOfProducts+=p._Price;
			}
            
            return SumOfProducts;
        }

    }
}

