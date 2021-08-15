using System.Collections.Generic;
using System.Linq;

namespace A2_cs
{
    public class Store
    {
        public string Name;
        	public string _Name{
			set{
				this.Name=value;
			}
			get{
				return Name;
			}
		}
        public List<Category> Categories;
        public List<Category> _Categories{
            set{
               this.Categories=value;
            }
            get{
                return Categories;
            }
        }
        public List<Cart> Carts;
        public List<Cart> _Carts{
            set{
               this.Carts=value;
            }
            get{
                return Carts;
            }
        }
        public Store(string name, List<Category> categories, List<Cart> carts)
        {
            _Name=name;
            _Carts=carts;
            _Categories=categories;
        }
        public void AddCart(Cart c)
        {
            _Carts.Add(c);
        }
        public void AddCategory(Category c)
        {
            _Categories.Add(c);
        }


    
        public Product Bestselling()
        {   Dictionary<Product,int> dict=new Dictionary<Product, int>{}; 
            
             foreach(Cart cr in Carts){
            foreach(Product p in cr._Products){
                if(dict.ContainsKey( p)){
                    dict[p]++;
                }
                else
                dict.Add(p,1);

            }}
             int Bestselling = dict.Values.Max();
            int pr;
            ID id;
            string name;
            double rate;
            Product BestsellingProduct=new Product(id=00,name="",pr=00,rate=0.0) ;
            foreach(var v in dict){
                if(v.Value.Equals(Bestselling)){
                    BestsellingProduct=v.Key;
                     break;}
             }
            return BestsellingProduct;
            }
            
        
            
            
        
        public Product MostPopular()
        {  
              double max_rate=0.0,rate;
                int pr;
                 ID id;
                 string name;
                Product popular=new Product(id=00,name="",pr=00,rate=0.0) ;
               foreach(Category cat in Categories){
            foreach(Product p in cat._Products){
                if(p._Rate>max_rate){
                    popular=p;
                    max_rate=p._Rate;
                }
                
            }  
        }
              return popular; 



    }}}