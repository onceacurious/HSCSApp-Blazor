using HSCSApp.Shared;
using System.Collections.Generic;

namespace HSCSApp.Client.Services.ProductService
{
    public interface IProductService
    {
        List<Product> Products { get; set; }

        void LoadProducts();
    }
}