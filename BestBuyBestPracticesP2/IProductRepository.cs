using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestBuyBestPracticesP2_
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts();
        public Product GetProduct(int id);
        public void UpdateProduct(Product product);
    }
}
