using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HSCSApp.Client.Service
{
    public class ProductService : IProductService
    {
        public List<ProductService> Products { get; set; }

        public void LoadProducts()
        {
            Products = new List<ProductService>
            {
                new ProductService
                {
                }
            };
        }
    }
}