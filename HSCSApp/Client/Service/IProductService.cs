using System.Collections.Generic;

namespace HSCSApp.Client.Service
{
    public interface IProductService
    {
        List<ProductService> Products { get; set; }

        void LoadProducts();
    }
}